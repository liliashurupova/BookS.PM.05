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

namespace BookS.PageUser
{
    /// <summary>
    /// Логика взаимодействия для PageSupport.xaml
    /// </summary>
    public partial class PageSupport : Page
    {
        public PageSupport()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Сообщение отправлено! Ждите ответ.");
        }
    }
}
