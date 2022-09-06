using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace AsyncAwaitWPF
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

        private async Task<int> Calculate(int number1, int number2)
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(4000);
                return number1 + number2;
            });
        }


        private  async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int number1 = int.Parse(txtNumber1.Text);
            int number2 = int.Parse(txtNumber2.Text);
            int result = await Calculate(number1, number2);

            MessageBox.Show(result.ToString(CultureInfo.InvariantCulture));
        }

        //private  void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    int number1 = int.Parse(txtNumber1.Text);
        //    int number2 = int.Parse(txtNumber2.Text);
        //    int result = 0;
        //    Thread.Sleep(4000);
        //    result = number1 + number2;

        //    MessageBox.Show(result.ToString());
        //}
    }
}
