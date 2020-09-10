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

namespace Methoden03.WPF
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

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            tblEuro.Text = GenerateReport(txtNetEuro.Text, txtVAT.Text);
            tblDollar.Text = GenerateReport(txtNetEuro.Text, txtVAT.Text, txtExchange.Text, "Dollar");
        }
        private string GenerateReport(string netInText, string vatInText, string exchangeRateInText = "1", string Currency = "Euro")
        {
            double net = double.Parse(netInText);
            double vat = double.Parse(vatInText);
            double exchangeRate = double.Parse(exchangeRateInText);
            net = net * exchangeRate;

            double vatTotal = net * (vat / 100);
            double totalAmount = net + vatTotal;
            string report = "Netto bedrag = " + net.ToString("#,##0.00") + " " + Currency + Environment.NewLine;
            report += "BTW " + vat.ToString("#,##0.00") + "% = " + vatTotal.ToString("#,##0.00") + " " + Currency + Environment.NewLine;
            report += "Totaal bedrag = " + totalAmount.ToString("#,##0.00") + " " + Currency;
            return report;
        }

        private string GenerateReport(string netInText, string vatInText)
        {
            double net = double.Parse(netInText);
            double vat = double.Parse(vatInText);

            double vatTotal = net * (vat / 100);
            double totalAmount = net + vatTotal;
            string report = "Netto bedrag = " + net.ToString("#,##0.00") + " EURO" + Environment.NewLine;
            report += "BTW " + vat.ToString("#,##0.00") + "% = " + vatTotal.ToString("#,##0.00") + " EURO" + Environment.NewLine;
            report += "Totaal bedrag = " + totalAmount.ToString("#,##0.00") + " EURO";
            return report;
        }
        private string GenerateReport(string netInText, string vatInText, string exchangeRateInText)
        {
            double net = double.Parse(netInText);
            double vat = double.Parse(vatInText);
            double exchangeRate = double.Parse(exchangeRateInText);
            net = net * exchangeRate;

            double vatTotal = net * (vat / 100);
            double totalAmount = net + vatTotal;
            string report = "Netto bedrag = " + net.ToString("#,##0.00") + " EURO" + Environment.NewLine;
            report += "BTW " + vat.ToString("#,##0.00") + "% = " + vatTotal.ToString("#,##0.00") + " EURO" + Environment.NewLine;
            report += "Totaal bedrag = " + totalAmount.ToString("#,##0.00") + " EURO";
            return report;
        }

        private string GenerateReportEuro(double net, double vat)
        {

            double vatTotal = net * (vat / 100);
            double totalAmount = net + vatTotal;
            string report = "Netto bedrag = " + net.ToString("#,##0.00") + " EURO" + Environment.NewLine;
            report += "BTW " + vat.ToString("#,##0.00") + "% = " + vatTotal.ToString("#,##0.00") + " EURO" + Environment.NewLine;
            report += "Totaal bedrag = " + totalAmount.ToString("#,##0.00") + " EURO";
            return report;
        }
        private string GenerateReportEuro(string netInText, string vatInText)
        {
            double net = double.Parse(netInText);
            double vat = double.Parse(vatInText);

            double vatTotal = net * (vat / 100);
            double totalAmount = net + vatTotal;
            string report = "Netto bedrag = " + net.ToString("#,##0.00") + " EURO" + Environment.NewLine;
            report += "BTW " + vat.ToString("#,##0.00") + "% = " + vatTotal.ToString("#,##0.00") + " EURO" + Environment.NewLine;
            report += "Totaal bedrag = " + totalAmount.ToString("#,##0.00") + " EURO";
            return report;
        }

        private string GenerateReportDollar(double net, double vat, double exchangeRate)
        {
            net = net * exchangeRate;
            double vatTotal = net * (vat / 100);
            double totalAmount = net + vatTotal;
            string report = "Netto bedrag = " + net.ToString("#,##0.00") + " DOLLAR" + Environment.NewLine;
            report += "BTW " + vat.ToString("#,##0.00") + "% = " + vatTotal.ToString("#,##0.00") + " DOLLAR" + Environment.NewLine;
            report += "Totaal bedrag = " + totalAmount.ToString("#,##0.00") + " DOLLAR";
            return report;

        }

    }
}
