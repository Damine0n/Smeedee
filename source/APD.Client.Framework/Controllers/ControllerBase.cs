#region File header

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
// The project webpage is located at http://agileprojectdashboard.org/
// which contains all the neccessary information.
// </contactinfo>

#endregion

using System;
using APD.Client.Framework.ViewModels;


namespace APD.Client.Framework.Controllers
{
    public abstract class ControllerBase<T>
        where T : AbstractViewModel
    {
        public T ViewModel { get; set; }
        protected INotifyWhenToRefresh refreshNotifier;
        protected IInvokeUI uiInvoker;

        public ControllerBase(INotifyWhenToRefresh refreshNotifier, IInvokeUI uiInvoker) :
            this(refreshNotifier, uiInvoker, (T)Activator.CreateInstance(typeof(T), uiInvoker))
        {
        }

        public ControllerBase(INotifyWhenToRefresh refreshNotifier, IInvokeUI uiInvoker, T viewModel)
        {
            this.uiInvoker = uiInvoker;
            this.ViewModel = viewModel;
            this.refreshNotifier = refreshNotifier;
            this.refreshNotifier.Refresh += OnNotifiedToRefresh;
        }

        protected abstract void OnNotifiedToRefresh(object sender, RefreshEventArgs e);
    }
}