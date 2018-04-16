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
using System.Data.Entity;
using System.Data;

namespace ITF_WPF_CRUD
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        loginEntities myData;

        public MainWindow()
        {
            myData = new loginEntities();
            InitializeComponent();
            this.myDatagrid.ItemsSource = myData.userMasks.ToList();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            myData.Database.Connection.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (myDatagrid.SelectedIndex != -1)
            {
                userMask selecteditem = (userMask)myDatagrid.Items[myDatagrid.SelectedIndex];
                MessageBox.Show(selecteditem.username + selecteditem.id);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource loginEntitiesViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("loginEntitiesViewSource")));
            // Laden Sie Daten durch Festlegen der CollectionViewSource.Source-Eigenschaft:
            // loginEntitiesViewSource.Source = [generische Datenquelle]
        }

        private void myDatagrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (myDatagrid.SelectedIndex != -1)
            {
                userMask selecteditem = (userMask)myDatagrid.Items[myDatagrid.SelectedIndex];
                MessageBox.Show("ID: " + selecteditem.id  + " Username: " + selecteditem.username + " Pass: " + selecteditem.password);
            }
        }
    }
}
