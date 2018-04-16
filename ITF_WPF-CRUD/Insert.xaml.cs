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
using System.Windows.Shapes;

namespace ITF_WPF_CRUD
{
    /// <summary>
    /// Interaktionslogik für Insert.xaml
    /// </summary>
    public partial class Insert : Window
    {
        loginEntities dataEntities = new loginEntities();

        public Insert()
        {
            InitializeComponent();
        }

        private void insertBtn_Click(object sender, RoutedEventArgs e)
        {
            userMask newUser = new userMask()
            {
                id = dataEntities.userMasks.Count() + 1,
                username = text_username.Text,
                password = text_password.Text
            };

            dataEntities.userMasks.Add(newUser);
            dataEntities.SaveChanges();
            dataEntities.SaveChangesAsync();
            this.Hide();
        }
    }
}
