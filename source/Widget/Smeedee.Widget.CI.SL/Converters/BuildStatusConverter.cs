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
// /copyright> 
// 
// <contactinfo>
// The project webpage is located at http://www.smeedee.org
// which contains all the neccessary information.
// </contactinfo>

#endregion

using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using Smeedee.Client.Framework.ResourceParsing;
using Smeedee.Client.Framework.SL.ResourceReading;

namespace Smeedee.Widget.CI.SL.Converters
{
    public class BuildStatusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Try casting value to a buildstatus, if it fails, use BuildStatus = Unknown
            var buildValue = ( value is BuildStatus ? (BuildStatus) value : BuildStatus.Unknown );

            if (targetType == typeof (string))
            {
                return buildValue.ToString();
            }

            if (targetType == typeof (Brush))
            {
                var xrd = new XamlResourceDictionary("Smeedee.Client.SL;component/Styles.xaml", new SLXamlReader());
                
                switch (buildValue)
                {
                    case BuildStatus.Unknown:
                        return xrd["GreyGradientBrush"];
                    case BuildStatus.Building:
                        return xrd["YellowGradientBrush"];
                    case BuildStatus.Successful:
                        return xrd["GreenGradientBrush"];
                    case BuildStatus.Failed:
                        return xrd["RedGradientBrush"];
					default:
                        return xrd["WhiteGradientBrush"];
                }
            }

            throw new ArgumentException("The target type is not supported by this converter..");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}