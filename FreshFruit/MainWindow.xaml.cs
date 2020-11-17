using FreshFruit.Controller;
using FreshFruit.Model;
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

namespace FreshFruit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, BucketEventListener
    {
        Seller toni;
        public MainWindow()
        {
            InitializeComponent();
            Bucket keranjangBuah = new Bucket(2);
            BucketController bucketController = new BucketController(keranjangBuah, this);
            toni = new Seller("toni", bucketController);
            ListBoxBucket.ItemsSource = keranjangBuah.findAll();
        }

        private void OnButtonAddAnggurClicked(object sender, RoutedEventArgs e)
        {
            Fruit anggur = new Fruit("Anggur");
            toni.addFruit(anggur);

            ListBoxBucket.Items.Refresh();
        }

        private void OnButtonAddAppleClicked(object sender, RoutedEventArgs e)
        {
            Fruit apple = new Fruit("Apple");
            toni.addFruit(apple);

            ListBoxBucket.Items.Refresh();
        }

        private void OnButtonAddPisangClicked(object sender, RoutedEventArgs e)
        {
            Fruit pisang = new Fruit("Pisang");
            toni.addFruit(pisang);

            ListBoxBucket.Items.Refresh();
        }

        private void OnButtonAddJerukClicked(object sender, RoutedEventArgs e)
        {
            Fruit jeruk = new Fruit("Jeruk");
            toni.addFruit(jeruk);

            ListBoxBucket.Items.Refresh();
        }

        public void onSucceed(string massage)
        {
            ListBoxBucket.Items.Refresh();
        }

        public void onFailed(string massage)
        {
            MessageBox.Show(massage, "Warning");
        }
    }
}
