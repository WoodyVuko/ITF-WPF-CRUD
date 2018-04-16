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
    /// Interaktionslogik für Update.xaml
    /// </summary>
    public partial class Update : Window
    {
        loginEntities dataEntities = new loginEntities();
        int Id;

        public Update()
        {
            InitializeComponent();
        }

        public Update(int memberID)
        {
            this.Id = memberID;
            InitializeComponent();
            text_ID.Text = this.Id.ToString();
            text_ID.IsEnabled = false;
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            //int x = Convert.ToInt32(text_ID.Text);
            userMask updateMember = (from m in dataEntities.userMasks
                                     where m.id == Id
                                     select m).Single();
            updateMember.username = text_username.Text;
            updateMember.password = text_password.Text;
            dataEntities.SaveChanges();

            //.ItemsSource = _db.members.ToList();
            this.Hide();

        }

    }
}
