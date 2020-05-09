using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TVGuide
{
    /// <summary>
    /// Interaction logic for TVGuidePage.xaml
    /// </summary>
    public partial class TVGuidePage : Page
    {
        public TVGuidePage()
        {
            InitializeComponent();
        }

        private void ScheduleButton_Click(object sender, RoutedEventArgs e)
        {
            TVGuideListings tVGuideListings = new TVGuideListings(this.channelListBox.SelectedItem);
            this.NavigationService.Navigate(tVGuideListings);
        }
    }
}
