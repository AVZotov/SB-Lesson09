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

namespace Task001
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStringSplit_Click(object sender, RoutedEventArgs e)
        {
            if(String.IsNullOrEmpty(txtBlock1.Text))
            {
                MessageBox.Show("Text block is empty",
                    this.Title,MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            lstBox.ItemsSource = txtBlock1.Text.Split(' ');
        }

        private void btnStringReverse_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtBlock2.Text))
            {
                MessageBox.Show("Text block is empty",
                    this.Title, MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var sentence = txtBlock2.Text.Split(" ");
            Array.Reverse(sentence);
            string result = String.Empty;

            foreach (var word in sentence)
            {
                result += word + " ";
            }

            label.Content = result;
        }
    }
}
