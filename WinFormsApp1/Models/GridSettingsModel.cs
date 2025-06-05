using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WinFormsApp1.Models
{
    
    public class GridSettingsModel : INotifyPropertyChanged
    {
        private int _rows;
        private int _columns;

        public int Rows
        {
            get => _rows;
            set
            {
                if (_rows != value && value >= 0)
                {
                    _rows = value;
                    OnPropertyChanged();
                }
            }
        }
        public int Columns
        {
            get => _columns;
            set
            {
                if (_columns != value && value >= 0)
                {
                    _columns = value;
                    OnPropertyChanged();
                }
            }
        }

       
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <param name="propertyName">Name of the property that changed</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}