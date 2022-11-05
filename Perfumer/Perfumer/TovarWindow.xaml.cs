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

namespace Perfumer
{
    /// <summary>
    /// Логика взаимодействия для TovarWindow.xaml
    /// </summary>
    public partial class TovarWindow : Window
    {
        PerfumerEntities db = new PerfumerEntities();
        public TovarWindow(int id)
        {
            InitializeComponent();
            
            foreach(User user in db.User)
            {
                if (user.Id == id) {
                    NameLabel.Content = user.Surname +" "+ user.Name+" " + user.MiddleName;
                }
            }
            GridTovar.ItemsSource = db.Product.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
