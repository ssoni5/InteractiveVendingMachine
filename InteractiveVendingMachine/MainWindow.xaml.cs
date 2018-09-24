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

namespace InteractiveVendingMachine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private VendingMachine.VendingMachine vm;
        public MainWindow()
        {
            InitializeComponent();
            vm = new VendingMachine.VendingMachine();
            lblTotalBars.Content = vm.TotalCandyBarsVended + " " + "bars vended";
            lblTotalMoney.Content = "Total Collected" + " " + vm.TotalMoneyCollected;
            txtAlmondJoyCount.Text = vm.AlmoundJoy + " " + "Bars";
            txtButterfingerCount.Text = vm.ButterFinger + " " + "Bars";
            txtTwixCount.Text = vm.Twix + " " + "Bars";
            txtSnickersCount.Text = vm.Snickers + " " + "Bars";
            lblQuarterDeposited.Content = vm.NumQuarters + " " + " Deposited";
            lblMessageOutput.Content = vm.MessageOutput;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            vm.DepositQuarter();
            lblTotalMoney.Content = "Total Collected" + " " + vm.TotalMoneyCollected;
            lblQuarterDeposited.Content = vm.NumQuarters + " " + " Deposited";
            lblMessageOutput.Content = vm.MessageOutput;
        }

        private void btnGetAlmondJoy_Click(object sender, RoutedEventArgs e)
        {
            vm.SelectCandy(VendingMachine.VendingMachine.CandyBar.AlmoundJoy);
            txtAlmondJoyCount.Text = vm.AlmoundJoy + " " + "Bars";
            lblTotalBars.Content = vm.TotalCandyBarsVended + " " + "bars vended";
            lblQuarterDeposited.Content = vm.NumQuarters + " " + " Deposited";
            lblMessageOutput.Content = vm.MessageOutput;
        }

        private void btnButterfinger_Click(object sender, RoutedEventArgs e)
        {
            vm.SelectCandy(VendingMachine.VendingMachine.CandyBar.ButterFinger);
            txtButterfingerCount.Text = vm.ButterFinger + " " + "Bars";
            lblTotalBars.Content = vm.TotalCandyBarsVended + " " + "bars vended";
            lblQuarterDeposited.Content = vm.NumQuarters + " " + " Deposited";
            lblMessageOutput.Content = vm.MessageOutput;
        }

        private void btnTwix_Click(object sender, RoutedEventArgs e)
        {
            vm.SelectCandy(VendingMachine.VendingMachine.CandyBar.Twix);
            txtTwixCount.Text = vm.Twix + " " + "Bars";
            lblTotalBars.Content = vm.TotalCandyBarsVended + " " + "bars vended";
            lblQuarterDeposited.Content = vm.NumQuarters + " " + " Deposited";
            lblMessageOutput.Content = vm.MessageOutput;
        }

        private void btnSnickers_Click(object sender, RoutedEventArgs e)
        {
            vm.SelectCandy(VendingMachine.VendingMachine.CandyBar.Snickers);
            txtSnickersCount.Text = vm.Snickers + " " + "Bars";
            lblTotalBars.Content = vm.TotalCandyBarsVended + " " + "bars vended";
            lblQuarterDeposited.Content = vm.NumQuarters + " " + " Deposited";
            lblMessageOutput.Content = vm.MessageOutput;
        }
    }
}
