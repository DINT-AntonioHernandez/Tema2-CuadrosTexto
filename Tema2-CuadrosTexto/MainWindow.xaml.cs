using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

namespace Tema2_CuadrosTexto
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

        void help_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                nombrehelpTextBlock.Visibility = Visibility.Visible;
                apellidohelpTextBlock.Visibility = Visibility.Visible; 
            }
            else if(e.Key == Key.F2)
            {
                try {
                    int numero = int.Parse(edadentradaTextBox.Text);
                }
                catch {
                    edadhelpTextBlock.Visibility = Visibility.Visible;
                }
            }
        }
    }
}
