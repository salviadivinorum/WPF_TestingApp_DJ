using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_TestingApp_DJ.Model;

namespace WPF_TestingApp_DJ.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {

        private string filterText;

        public MainViewModel()
        {
            ClearFilterCommand = new RelayCommand(ClearFilter, CanClearFilter);
        }


        public ICommand ClearFilterCommand { get; }

        public string FilterText
        {
            get => filterText;
            set
            {
                if (filterText != value)
                {
                    filterText = value;
                    OnPropertyChanged(nameof(FilterText));
                }
            }
        }
       

        private void ClearFilter()
        {
            FilterText = string.Empty;
        }

        private bool CanClearFilter()
        {
            return !string.IsNullOrEmpty(FilterText);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
