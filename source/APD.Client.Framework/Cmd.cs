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

using System.Windows;
using System.Windows.Input;
using System.Windows.Controls.Primitives;


namespace APD.Client.Framework
{
    public static class Cmd
    {
        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.RegisterAttached("Command", typeof(ICommand), typeof(Cmd),
            new PropertyMetadata(CommandPropertyChanged));

        public static void SetCommand(ButtonBase button, ICommand value)
        {
            button.SetValue(CommandProperty, value);
        }

        public static ICommand GetCommand(ButtonBase button)
        {
            return (ICommand)button.GetValue(CommandProperty);
        }

        private static void CommandPropertyChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            var element = o as FrameworkElement;
            if (element != null)
            {
                if (e.OldValue != null)
                {
                    UnhookCommand(element, (ICommand)e.OldValue);
                }
                if (e.NewValue != null)
                {
                    HookCommand(element, (ICommand)e.NewValue);
                }
            }
        }

        private static void HookCommand(FrameworkElement element, ICommand command)
        {
            if (element is ButtonBase)
            {
                var button = element as ButtonBase;
                button.Click += (o, e) =>
                {
                    command.Execute(null);   
                };
            }
        }

        private static void UnhookCommand(FrameworkElement element, ICommand command)
        {
            if (element is ButtonBase)
            {
                var button = element as ButtonBase;
                button.Click -= null;
            }
        }
    }
}
