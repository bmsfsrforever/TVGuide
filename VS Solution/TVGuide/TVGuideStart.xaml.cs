using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
    /// Interaction logic for TVGuideStart.xaml
    /// </summary>
    public partial class TVGuideStart : Page
    {
        public TVGuideStart()
        {
            InitializeComponent();
        }

        private void GoButton_Click(object sender, RoutedEventArgs e)
        {
            if (taskListBox.SelectedItem == view)
            {
                Uri uri = new Uri("TVGuidePage.xaml", UriKind.Relative);
                this.NavigationService.Navigate(uri);
            }
            if (taskListBox.SelectedItem == about)
            {
                Uri uri = new Uri("TVGuideAbout.xaml", UriKind.Relative);
                this.NavigationService.Navigate(uri);
            }
            if (taskListBox.SelectedItem == update)
            {
                string root = @"C:\TVGuide";
                Directory.CreateDirectory(root);
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile("http://dpp.mynetgear.com/tvguide/programdata.xml", "C:\\TVGuide\\programdata.xml");
                }
            }
        }
    }
}
