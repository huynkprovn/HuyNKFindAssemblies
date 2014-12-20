using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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
using System.Xml;
using System.Xml.Linq;

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
           
        }
         void Install(object sender, RoutedEventArgs e)
         {
             XmlReader xmlFile;
             xmlFile = XmlReader.Create("Data/Huynkconfig.xml", new XmlReaderSettings());
             DataSet ds = new DataSet();
             ds.ReadXml(xmlFile);
             int i = 0;
             for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
             {
                 MessageBox.Show(ds.Tables[0].Rows[i].ItemArray[5].ToString());
             } 
             
        }

        
    }
}
