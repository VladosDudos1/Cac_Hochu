using AccountingApp.Model;
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

namespace AccountingApp.Pages
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {

        List<GoodsMovement> sales = new List<GoodsMovement>()
        {
            new GoodsMovement(1, "Product1", 2, 30, new DateTime(2020,1,3)),
            new GoodsMovement(2, "Product2", 10, 100, new DateTime(2020,1,9)),
            new GoodsMovement(3, "Product3", 5, 20, new DateTime(2020,3,1)),
            new GoodsMovement(4, "Product4", 6, 45, new DateTime(2020,2,1)),
            new GoodsMovement(5, "Product5", 4, 23, new DateTime(2020,3,22)),
            new GoodsMovement(6, "Product6", 2, 3125, new DateTime(2020,1,11)),
        };

        List<GoodsMovement> arrivals = new List<GoodsMovement>()
        {
            new GoodsMovement(1, "Product1", 2, 30, new DateTime(2020,11,3)),
            new GoodsMovement(2, "Product2", 10, 100, new DateTime(2020,12,9)),
            new GoodsMovement(3, "Product3", 5, 20, new DateTime(2020,4,5)),
            new GoodsMovement(4, "Product4", 6, 45, new DateTime(2020,4,3)),
            new GoodsMovement(5, "Product5", 4, 23, new DateTime(2020,6,22)),
            new GoodsMovement(6, "Product6", 2, 3125, new DateTime(2020,6,11)),
        };
        public MainPage()
        {
            InitializeComponent();
            DGSale.ItemsSource = sales;
            DGArrival.ItemsSource = arrivals;
        }
    }
}
