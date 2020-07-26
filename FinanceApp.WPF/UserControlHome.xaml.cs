using FinanceApp.BL.Controller;
using FinanceApp.BL.Model;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace FinanceApp.WPF
{
    /// <summary>
    /// Логика взаимодействия для UserControlHome.xaml
    /// </summary>
    public partial class UserControlHome : UserControl
    {
        readonly ArticleController articleController = new ArticleController();

        public UserControlHome()
        {
            InitializeComponent();
            LoadingData();
        }

        private void LoadingData()
        {
            var data = articleController.LoadFromDB();
            FinanceDataGrid.ItemsSource = data.ToList();
        }

        private void ButtonRemove_Click(object sender, RoutedEventArgs e)
        {
            var Id = (FinanceDataGrid.SelectedItem as Article).Id;
            articleController.RemoveArticle(Id);

            LoadingData();
        }
    }
}
