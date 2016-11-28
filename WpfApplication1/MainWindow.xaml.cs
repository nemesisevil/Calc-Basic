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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string wyswietlteks = string.Empty;
       // int suma = 0;
        int a = 0;
        int liczba1 = 0;
        int bufor = 0;
        string znak = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PrzyciskSUMA_Click_1(object sender, RoutedEventArgs e)
        {
            Oblicz();
            WyswietlaczKalk.Text = Convert.ToString(liczba1) ;
        }

        private void PrzyciskLiczba1_Click(object sender, RoutedEventArgs e)
        {
            WyswietlaczKalk.Text += "1";
        }

        private void PrzyciskLiczba2_Click(object sender, RoutedEventArgs e)
        {
            WyswietlaczKalk.Text += "2";
        }

        private void PrzyciskLiczba3_Click(object sender, RoutedEventArgs e)
        {
            WyswietlaczKalk.Text += "3";
        }

        private void PrzyciskLiczba4_Click(object sender, RoutedEventArgs e)
        {
            WyswietlaczKalk.Text += "4";
        }

        private void PrzyciskLiczba5_Click(object sender, RoutedEventArgs e)
        {
            WyswietlaczKalk.Text += "5";
        }

        private void PrzyciskLiczba6_Click(object sender, RoutedEventArgs e)
        {
            WyswietlaczKalk.Text += "6";
        }

        private void PrzyciskLiczba7_Click(object sender, RoutedEventArgs e)
        {
            WyswietlaczKalk.Text += "7";
        }

        private void PrzyciskLiczba8_Click(object sender, RoutedEventArgs e)
        {
            WyswietlaczKalk.Text += "8";
        }

        private void PrzyciskLiczba9_Click(object sender, RoutedEventArgs e)
        {
            WyswietlaczKalk.Text += "9";
        }

        private void PrzyciZero_Click(object sender, RoutedEventArgs e)
        {
            WyswietlaczKalk.Text += "0";
        }

        private void PrzyciskMinus_Click(object sender, RoutedEventArgs e)
        {
            bufor = int.Parse(WyswietlaczKalk.Text);
            liczba1 = bufor;
            znak = "-";
            WyswietlaczKalk.Text = null;

        }

        private void PrzyciskPlus_Click(object sender, RoutedEventArgs e)
        {

            bufor = int.Parse(WyswietlaczKalk.Text);
            liczba1 = bufor;
            znak = "+";
            WyswietlaczKalk.Text = null;

        }
        public void Oblicz()
        {
            bufor = int.Parse(WyswietlaczKalk.Text);
            switch (znak)
            {
                case "+":

                    liczba1 += bufor;
                    break;

                case "-":
                    liczba1 -= bufor;
                    break;
                case "*":
                    liczba1 *= bufor;
                    break;
                case "/":
                    liczba1 = liczba1/bufor;
                    break;
            }
        }

        private void PrzyciskRESET_Click(object sender, RoutedEventArgs e)
        {
          //  suma = 0;
            znak = null;
            liczba1 = 0;
            WyswietlaczKalk.Text = null;
        }

        private void PrzyciskPomnoz(object sender, RoutedEventArgs e)
        {
            bufor = int.Parse(WyswietlaczKalk.Text);
            liczba1 = bufor;
            znak = "*";
            WyswietlaczKalk.Text = null;
        }

        private void PrzyciskPodziel(object sender, RoutedEventArgs e)
        {
            bufor = int.Parse(WyswietlaczKalk.Text);
            liczba1 = bufor;
            znak = "/";
            WyswietlaczKalk.Text = null;
        }
    }
}
