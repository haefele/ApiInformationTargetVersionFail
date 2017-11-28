using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace MyLibrary
{
    public class ControlFactory
    {
        public static Control GetNavigationControl()
        {
            if (ApiInformation.IsApiContractPresent(typeof(UniversalApiContract).FullName, 5))
            {
                return new NavigationView();
            }
            else
            {
                return new ListView();
            }
        }
    }
}
