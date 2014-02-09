using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace WpfApplication1
{
    public class MyDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate RackDataTemplate { get; set; }
        public DataTemplate BoxDataTemplate { get; set; }
        public DataTemplate CardDataTemplate { get; set; }
     
        public override DataTemplate SelectTemplate(object item, 
                   DependencyObject container)
        {
            FrameworkElement element = container as FrameworkElement;

            if (element != null && item != null)
            {
                BaseViewModel viewmodel = item as BaseViewModel;

                if (item is RackViewModel)
                    return
                        element.FindResource("RackDataTemplate") as DataTemplate;
                if (item is BoxViewModel)
                    return
                        element.FindResource("BoxDataTemplate") as DataTemplate;
                if (item is CardViewModel)
                    return
                        element.FindResource("CardDataTemplate") as DataTemplate;
            }

            return null;
        }
    }
}
