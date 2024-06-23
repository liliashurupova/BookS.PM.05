using BookS.ApplicationData;
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
    /// Логика взаимодействия для PageAddEdit.xaml
    /// </summary>
    public partial class PageAddEdit : Page
    {
        private books _currentbooks = new books();
        public PageAddEdit()
        {
            InitializeComponent();
            DataContext = _currentbooks;
            ComboCategory.ItemsSource = BookStoreEntities.GetContext().category.ToList();
        }


        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentbooks.title))
                errors.AppendLine("Введите название книги");
            if (string.IsNullOrWhiteSpace(_currentbooks.author))
                errors.AppendLine("Введите автора книги");
            if (string.IsNullOrWhiteSpace(_currentbooks.quantity))
                errors.AppendLine("Введите количество книг");
            if (string.IsNullOrWhiteSpace(_currentbooks.price))
                errors.AppendLine("Введите цену книги");
            if (_currentbooks.category1 == null)
                errors.AppendLine("Выберите категорию");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString()); return;
            }
            if (_currentbooks.id == 0)
                BookStoreEntities.GetContext().books.Add(_currentbooks);
            try
            {
                BookStoreEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация успешно сохранена");
                AppFrame.frameMain.GoBack();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void BtnBBack(object sender, RoutedEventArgs e)
        {

        }
    }
}
    
