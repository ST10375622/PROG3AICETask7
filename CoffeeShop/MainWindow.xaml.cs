using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Windows;
using static CoffeeShop.oldOrderSystem;

namespace CoffeeShop
{
    public partial class MainWindow : Window
    {

        private readonly CoffeeOrderFacade _orderFacade;

        public MainWindow()
        {
            InitializeComponent();
            _orderFacade = new CoffeeOrderFacade(new OrderAdapter());
        }

        private void btnOrderCoffee_Click(object sender, RoutedEventArgs e)
        {
            string coffeeType = cmbCoffeeType.Text;
            bool addMilk = chkMilk.IsChecked == true;
            bool addSugar = chkSugar.IsChecked == true;

            string orderSummary = _orderFacade.PlaceOrder(coffeeType, addMilk, addSugar);
            txtOrderSummary.Text = orderSummary;
        }
    }
}
