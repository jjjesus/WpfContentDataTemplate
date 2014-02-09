using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApplication1
{
    public class DeviceDetailsViewModel
    {
        public BaseViewModel SelectedViewModel { get; set; }

        public DeviceDetailsViewModel()
        {
            // TODO: Change the next line as needed
            //SelectedViewModel = new RackViewModel("RACK-1");
            //SelectedViewModel = new BoxViewModel("BOX-1");
            SelectedViewModel = new CardViewModel("CARD-1");
        }
    }
}
