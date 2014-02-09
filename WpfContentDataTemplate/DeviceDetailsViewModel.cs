using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace WpfApplication1
{
    public class DeviceDetailsViewModel : INotifyPropertyChanged
    {
        BaseViewModel _selectedViewModel;
        public BaseViewModel SelectedViewModel {
            get { return _selectedViewModel; }
            set
            {
                _selectedViewModel = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("SelectedViewModel"));
            }
        }

        public DeviceDetailsViewModel()
        {
            // TODO: Change the next line as needed
            //SelectedViewModel = new RackViewModel("RACK-1");
            SelectedViewModel = new BoxViewModel("BOX-1");
            //SelectedViewModel = new CardViewModel("CARD-1");
        }


        public event PropertyChangedEventHandler PropertyChanged;

    }
}
