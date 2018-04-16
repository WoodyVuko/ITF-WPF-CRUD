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
    }
}
