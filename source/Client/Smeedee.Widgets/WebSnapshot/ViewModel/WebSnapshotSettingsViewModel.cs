﻿using System;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace Smeedee.Widgets.WebSnapshot.ViewModel
{
    public partial class WebSnapshotSettingsViewModel
    {
        partial void OnInitialize()
        {
            AvailableImages = new ObservableCollection<string>();
        }

        public bool CanSave()
        {
            return true;
        }

        public bool IsSaving
        {
            get { return isSaving; }
            set
            {
                if (value != isSaving)
                {
                    isSaving = value;
                    TriggerPropertyChanged("IsSaving");
                }
            }
        }
        private bool isSaving;

        public string CropCoordinateX
        {
            get { return cropCoordinateX; }
            set
            {
                if (value != cropCoordinateX)
                {
                    cropCoordinateX = value;
                    TriggerPropertyChanged("CropCoordinateX");
                }
            }
        }
        private string cropCoordinateX;

        public string CropCoordinateY
        {
            get { return cropCoordinateY; }
            set
            {
                if (value != cropCoordinateY)
                {
                    cropCoordinateY = value;
                    TriggerPropertyChanged("CropCoordinateY");
                }
            }
        }
        private string cropCoordinateY;
        public string CropRectangleHeight
        {
            get { return cropRectangleHeight; }
            set
            {
                if (value != cropRectangleHeight)
                {
                    cropRectangleHeight = value;
                    TriggerPropertyChanged("CropRectangleHeight");
                }
            }
        }
        private string cropRectangleHeight;
        public string CropRectangleWidth
        {
            get { return cropRectangleWidth; }
            set
            {
                if (value != cropRectangleWidth)
                {
                    cropRectangleWidth = value;
                    TriggerPropertyChanged("CropRectangleWidth");
                }
            }
        }
        private string cropRectangleWidth;

        public virtual bool IsTimeToUpdate
        {
            get
            {
                OnGetIsTimeToUpdate(ref _IsTimeToUpdate);

                return _IsTimeToUpdate;
            }
            set
            {
                if (value != _IsTimeToUpdate)
                {
                    OnSetIsTimeToUpdate(ref value);
                    _IsTimeToUpdate = value;
                    TriggerPropertyChanged("IsTimeToUpdate");
                }
            }
        }
        private bool _IsTimeToUpdate;

        partial void OnGetIsTimeToUpdate(ref bool value);
        partial void OnSetIsTimeToUpdate(ref bool value);

    }
}
