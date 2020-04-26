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

namespace WpfApplication
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int a;
        int b;
        int result;

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            result = (int)Class.Add(a, b);
            TextBoxResult.Text = result.ToString();

        }

        private void TextBoxResult_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBoxNumber2_TextChanged(object sender, TextChangedEventArgs e)
        {
            b = Int32.Parse(TextBoxNumber2.Text);
            TextBoxResult.Text = "";

        }

        private void TextBoxNumber1_TextChanged(object sender, TextChangedEventArgs e)
        {
            a = Int32.Parse(TextBoxNumber1.Text);
            TextBoxResult.Text = "";

        }
    }
}
