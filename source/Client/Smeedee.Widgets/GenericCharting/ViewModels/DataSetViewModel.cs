﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Smeedee.Widgets.GenericCharting.ViewModels
{
    public partial class DataSetViewModel
    {
        partial void OnInitialize()
        {
            Data = new ObservableCollection<DataPointViewModel>();
        }
    }
}