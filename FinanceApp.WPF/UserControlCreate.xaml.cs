using FinanceApp.BL.Controller;
using System;
using System.Windows;
using System.Windows.Controls;

namespace FinanceApp.WPF
{
    /// <summary>
    /// Логика взаимодействия для UserControlCreate.xaml
    /// </summary>
    public partial class UserControlCreate : UserControl
    {
        public UserControlCreate()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var name = ArticleName.Text;
            var type = Type.Text;
            var description = Description.Text;
            var sum = ParseDouble(Sum.Text);

            ArticleName.Text = String.Empty;
            Type.Text = String.Empty;
            Description.Text = String.Empty;
            Sum.Text = String.Empty;

            var articleController = new ArticleController();
            articleController.Add(name, type, description, sum);
        }

        private static double ParseDouble(string num)
        {
            while (true)
            {
                if (double.TryParse(num, out double value))
                {
                    return value;
                }
            }
        }
    }
}
