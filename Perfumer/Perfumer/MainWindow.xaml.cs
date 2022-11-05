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

namespace Perfumer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int userid;
        PerfumerEntities db=new PerfumerEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach(User us in db.User)
            {
                if(us.Login==LoginTextbox.Text && us.Password == PasswordTextBox.Text)
                {
                    MessageBox.Show("Вы успешно авторизовались!");
                    userid = us.Id;
                    TovarWindow window=new TovarWindow(userid);
                    window.Show();
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            userid = 0;
            TovarWindow window = new TovarWindow(userid);
            window.Show();
        }
    }
}
