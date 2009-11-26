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
// The project webpage is located at http://agileprojectdashboard.org/
// which contains all the neccessary information.
// </contactinfo>
// 
// <author>Your Name</author>
// <email>your@email.com</email>
// <date>2009-MM-DD</date>

#endregion

using System;
using System.ServiceModel;
using System.Text.RegularExpressions;
using System.Windows;

namespace APD.Client.Framework.SL
{
    public class WebServiceEndpointResolver
    {
        public static EndpointAddress ResolveDynamicEndpointAddress(EndpointAddress configuredEndpoint)
        {
            Uri appUri = Application.Current.Host.Source;
            string virtualPath = Regex.Match( appUri.OriginalString,
                                 "http[s]?://[^/]+?/(?<VirtualPath>[^/]+)").Groups["VirtualPath"].Value;

            string serviceUrl = string.Format("{0}://{1}:{2}/{3}{4}",
                appUri.Scheme, appUri.Host, appUri.Port, virtualPath, configuredEndpoint.Uri.AbsolutePath)
            ;
            
            return new EndpointAddress(serviceUrl);

        }
    }
}