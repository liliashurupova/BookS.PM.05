using BookS.ApplicationData;
using BookS.PageM;
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

namespace BookS.PageAdmin
{
    /// <summary>
    /// Логика взаимодействия для PageMenuAdmin.xaml
    /// </summary>
    public partial class PageMenuAdmin : Page
    {

        public PageMenuAdmin()
        {
            InitializeComponent();
           
            //DGridBooks.ItemsSource = BookStoreEntities.GetContext().books.ToList();
        }    
        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
         
        }
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new PageAddEdit());
        }
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                BookStoreEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridBooks.ItemsSource = BookStoreEntities.GetContext().books.ToList();
            }
        }

        private void DGridBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
