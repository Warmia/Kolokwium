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

namespace WpfApplication7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Przychodnia x = new Przychodnia();
        public MainWindow()
        {
            InitializeComponent();
            Kol.Visibility = Visibility.Hidden;
            Por.Visibility = Visibility.Hidden;
            Bad.Visibility = Visibility.Hidden;
            GPac.Visibility = Visibility.Hidden;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            x.UstawLekarza(ImieLek.Text, Specjal.Text);
            Kol.Visibility = Visibility.Visible;
        }

        private void Kol_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                x.DodajDoKolejki(im.Text, int.Parse(w.Text), ch.Text);
            }
            catch
            {

            }
            GPac.Visibility = Visibility.Visible;
        }
    }
}
