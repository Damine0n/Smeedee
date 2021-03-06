﻿#region File header

// <copyright>
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
// </copyright> 
// 
// <contactinfo>
// The project webpage is located at http://smeedee.org/
// which contains all the neccessary information.
// </contactinfo>
// 
// <author>Your Name</author>
// <email>your@email.com</email>
// <date>2009-MM-DD</date>

#endregion

using System;
using System.Net;
using System.Threading;


namespace Smeedee.Integration.CI.CruiseControl.DomainModel.Repositories
{
    public class OptimizedHTTPRequest
    {
        private const int NUMBER_OF_RETRIES = 1;
        private const int COOLDOWN_MS = 10;
        private static Timer dosCooldownTimer = null;

        private IHTTPSocket httpConnection;
        private string httpResponse;

        public int NumberOfRetries { get; set; }
        public int CooldownMS { get; set; }

        public OptimizedHTTPRequest(IHTTPSocket httpSocket)
        {
            this.httpConnection = httpSocket;
            NumberOfRetries = NUMBER_OF_RETRIES;
            CooldownMS = COOLDOWN_MS;
        }

        public String RequestURL(String fileURL, int port, int maxLength)
        {
            for (int i = 0; i < NumberOfRetries; i++)
            {
                if (dosCooldownTimer != null)
                {
                    Thread.Sleep(CooldownMS);
                    continue;
                }
                try
                {
                    return GetDataFromUrl(fileURL, port, maxLength);
                }
                catch (Exception ex)
                {
                    if (ex.GetType() == typeof(HTTPSockectRejectedByHostException))
                        DenialOfServiceCooldown();
                }
            }

            throw new WebException("Failed to read after " + NumberOfRetries + " retries");
        }

        private void DenialOfServiceCooldown()
        {
            if (dosCooldownTimer == null)
            {
                dosCooldownTimer = new Timer(cooldownTimer_callback, null, CooldownMS, int.MaxValue);
            }
        }

        private static void cooldownTimer_callback(object state)
        {
            dosCooldownTimer = null;
        }

        private string GetDataFromUrl(String fileURL, int port, int maxLength)
        {
            httpConnection.Open(fileURL, port);

            if (httpConnection.IsConnected == false)
                throw new WebException("OptimizedHTTPRequest could not connect to host");

            SendGetRequest(fileURL);

            ReadData(maxLength);

            httpConnection.Close();

            return ParseData(maxLength);
        }

        private void SendGetRequest(string url)
        {
            Uri fileURI = new Uri(url);
            string httpGETRequest = String.Format("GET {0} HTTP/1.1\nHost: {1}\n\n",
                fileURI.AbsolutePath, fileURI.Host);
            httpConnection.Send(httpGETRequest);
        }

        private void ReadData(int maxLength)
        {
            int esitmatedHeaderSize = 1024 * 2;
            var data = httpConnection.Read(maxLength + esitmatedHeaderSize);

            httpResponse = System.Text.Encoding.ASCII.GetString(data);
        }

        private string ParseData(int maxLength)
        {
            string retString = "";
            if (string.IsNullOrEmpty(httpResponse))
                throw new Exception("Response from server was empty");
            if (httpResponse.Substring(0, 20).ToLower().Contains("200 ok") != true)
                throw new Exception("Response from server did not indicate '200 OK'");

            if (httpResponse.IndexOf("\n") < httpResponse.IndexOf("\r") || !httpResponse.Contains("\r"))
            {
                retString = httpResponse.Substring(httpResponse.IndexOf("\n\n") + 2);
            }
            else
            {
                retString = httpResponse.Substring(httpResponse.IndexOf("\r\n\r\n") + 4);
            }


            if (retString.Length > maxLength)
                retString = retString.Substring(0, maxLength);

            return retString;

        }


    }
}