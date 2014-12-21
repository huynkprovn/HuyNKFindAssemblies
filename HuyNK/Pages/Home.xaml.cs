using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net.Mime;
using System.Security.Cryptography.X509Certificates;
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
using System.Xml;
using System.Xml.Linq;
using Xceed.Wpf.DataGrid;

namespace HuyNK.Pages
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : UserControl
    {
        
    
        public Home()
        {

            InitializeComponent();
            var champslist = XElement.Load("Data/Huynkconfig.xml");
            dataGrid.DataContext = champslist;
            dataGrid.SelectionUnit = DataGridSelectionUnit.Cell;
            


        }


        void ShowHideDetails(object sender, RoutedEventArgs e)
        {
            for (var vis = sender as Visual; vis != null; vis = VisualTreeHelper.GetParent(vis) as Visual)
                if (vis is DataGridRow)
                {
                    var row = (DataGridRow)vis;
                    row.DetailsVisibility = row.DetailsVisibility == Visibility ? Visibility.Collapsed : Visibility;
                    break;
                }
        }


        private void DG_Hyperlink_Click(object sender, RoutedEventArgs e)
        {
           Hyperlink link = (Hyperlink)e.OriginalSource;
        
            ProcessStartInfo startInfo = new ProcessStartInfo("iexplore.exe", link.NavigateUri.AbsoluteUri);
            Process.Start(startInfo); 
            
        }
        
        private void DataGrid_OnSelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {

           
 
        }
    }
}
