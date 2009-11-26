﻿//      *********    DO NOT MODIFY THIS FILE     *********
//      This file is regenerated by a design tool. Making
//      changes to this file can cause errors.
namespace Expression.Blend.SampleData.UserSampleDataSource
{
	using System; 

// To significantly reduce the sample data footprint in your production application, you can set
// the DISABLE_SAMPLE_DATA conditional compilation constant and disable sample data at runtime.
#if DISABLE_SAMPLE_DATA
	internal class UserSampleDataSource { }
#else

	public class UserSampleDataSource : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		public UserSampleDataSource()
		{
			try
			{
				System.Uri resourceUri = new System.Uri("/APD.Client.Widget.Admin.SL;component/SampleData/UserSampleDataSource/UserSampleDataSource.xaml", System.UriKind.Relative);
				if (System.Windows.Application.GetResourceStream(resourceUri) != null)
				{
					System.Windows.Application.LoadComponent(this, resourceUri);
				}
			}
			catch (System.Exception)
			{
			}
		}

		private string _Name = string.Empty;

		public string Name
		{
			get
			{
				return this._Name;
			}

			set
			{
				if (this._Name != value)
				{
					this._Name = value;
					this.OnPropertyChanged("Name");
				}
			}
		}

		private string _Email = string.Empty;

		public string Email
		{
			get
			{
				return this._Email;
			}

			set
			{
				if (this._Email != value)
				{
					this._Email = value;
					this.OnPropertyChanged("Email");
				}
			}
		}

		private string _ImageUrl = string.Empty;

		public string ImageUrl
		{
			get
			{
				return this._ImageUrl;
			}

			set
			{
				if (this._ImageUrl != value)
				{
					this._ImageUrl = value;
					this.OnPropertyChanged("ImageUrl");
				}
			}
		}

		private string _Username = string.Empty;

		public string Username
		{
			get
			{
				return this._Username;
			}

			set
			{
				if (this._Username != value)
				{
					this._Username = value;
					this.OnPropertyChanged("Username");
				}
			}
		}
	}
#endif
}