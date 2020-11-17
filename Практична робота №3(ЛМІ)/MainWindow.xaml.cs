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

namespace WpfAppLMI
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
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e){ }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double ZNO1 = Convert.ToDouble(___ZNO1_.Text);
            double ZNO2 = Convert.ToDouble(___ZNO2_.Text);
            double ZNO =  (ZNO1 + ZNO2) / 2;
            double STD = Convert.ToDouble(___Study_.Text);
            string SCH = ___School_.Text;
            MessageBox.Show("AVG ZNO mark is " + ZNO + "; AVG study mark is " + STD + "; and you stood at " + SCH + ".");
        }
    }
}
