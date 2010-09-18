﻿//      *********    DO NOT MODIFY THIS FILE     *********
//      This file is regenerated by a design tool. Making
//      changes to this file can cause errors.
namespace Expression.Blend.SampleData.SettingsViewSampleData
{
	using System; 

// To significantly reduce the sample data footprint in your production application, you can set
// the DISABLE_SAMPLE_DATA conditional compilation constant and disable sample data at runtime.
#if DISABLE_SAMPLE_DATA
	internal class SettingsViewSampleData { }
#else

	public class SettingsViewSampleData : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		public SettingsViewSampleData()
		{
			try
			{
				System.Uri resourceUri = new System.Uri("/Smeedee.Widget.CI.SL;component/SampleData/SettingsViewSampleData/SettingsViewSampleData.xaml", System.UriKind.Relative);
				if (System.Windows.Application.GetResourceStream(resourceUri) != null)
				{
					System.Windows.Application.LoadComponent(this, resourceUri);
				}
			}
			catch (System.Exception)
			{
			}
		}

		private Servers _Servers = new Servers();

		public Servers Servers
		{
			get
			{
				return this._Servers;
			}
		}
	}

	public class ServersItem : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
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

		private Projects _Projects = new Projects();

		public Projects Projects
		{
			get
			{
				return this._Projects;
			}
		}
	}

	public class Servers : System.Collections.ObjectModel.ObservableCollection<ServersItem>
	{ 
	}

	public class ProjectsItem : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		private string _ProjectName = string.Empty;

		public string ProjectName
		{
			get
			{
				return this._ProjectName;
			}

			set
			{
				if (this._ProjectName != value)
				{
					this._ProjectName = value;
					this.OnPropertyChanged("ProjectName");
				}
			}
		}

		private bool _IsSelected = false;

		public bool IsSelected
		{
			get
			{
				return this._IsSelected;
			}

			set
			{
				if (this._IsSelected != value)
				{
					this._IsSelected = value;
					this.OnPropertyChanged("IsSelected");
				}
			}
		}
	}

	public class Projects : System.Collections.ObjectModel.ObservableCollection<ProjectsItem>
	{ 
	}
#endif
}