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

namespace fofo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void num1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (num1.Text != "" && num2.Text != "" && znak.SelectedIndex == 0)
            {
                result.Text = Convert.ToString(Convert.ToInt32(num1.Text) + Convert.ToInt32(num2.Text));
            }
            if (num1.Text != "" && num2.Text != "" && znak.SelectedIndex == 1)
            {
                result.Text = Convert.ToString(Convert.ToInt32(num1.Text) - Convert.ToInt32(num2.Text));
            }
            if (num1.Text != "" && num2.Text != "" && znak.SelectedIndex == 2)
            {
                result.Text = Convert.ToString(Convert.ToDouble(num1.Text) / Convert.ToDouble(num2.Text));
            }
            if (num1.Text != "" && num2.Text != "" && znak.SelectedIndex == 3)
            {
                result.Text = Convert.ToString(Convert.ToDouble(num1.Text) * Convert.ToDouble(num2.Text));
            }
        }
    }
}
