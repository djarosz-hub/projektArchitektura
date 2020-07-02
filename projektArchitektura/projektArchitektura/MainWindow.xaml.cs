using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace projektArchitektura
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

        private void clearR_Click(object sender, RoutedEventArgs e)
        {
            axLab.Content = "";
            ahLab.Content = "";
            alLab.Content = ""; 
            bxLab.Content = "";
            bhLab.Content = "";
            blLab.Content = ""; 
            cxLab.Content = "";
            chLab.Content = "";
            clLab.Content = ""; 
            dxLab.Content = "";
            dhLab.Content = "";
            dlLab.Content = "";

        }

        private void commandSubmit_Click(object sender, RoutedEventArgs e)
        {
            string input = commandInput.Text;
            if (!Check(input))
            {
                commandInput.Text = "Błędny format";
            }
            else
            {
                string[] commandTab = new string[3];
                commandTab[0] = input.Substring(0, input.IndexOf(' '));
                commandTab[1] = input.Substring(input.IndexOf(' ') + 1, input.IndexOf(',') - input.IndexOf(' ') - 1);
                commandTab[2] = input.Substring(input.IndexOf(',') + 1);
                axLab.Content = commandTab[0];
                bxLab.Content = commandTab[1];
                cxLab.Content = commandTab[2];
            }
            bool Check(string x)
            {
                bool a = x.Contains(' ');
                bool b = x.Contains(',');
                if (a && b && input.IndexOf(' ') < input.IndexOf(',')) return true;
                else return false;
            }
        }
        private int randomValues()
        {
            Random rnd = new Random();
            int val = rnd.Next(0, 65536);
            return val;
        }

        private void randomR_Click(object sender, RoutedEventArgs e)
        {
            int[] tab = new int[4];
            for(int i = 0; i < tab.Length; i++)
            {
                tab[i] = randomValues();
                Thread.Sleep(50);
            }
            axLab.Content = Convert.ToString(tab[0], 16);
            bxLab.Content = Convert.ToString(tab[1], 16);
            cxLab.Content = Convert.ToString(tab[2], 16);
            dxLab.Content = Convert.ToString(tab[3], 16);
            string ax2 = Convert.ToString(tab[0], 2);
            string bx2 = Convert.ToString(tab[1], 2);
            string cx2 = Convert.ToString(tab[2], 2);
            string dx2 = Convert.ToString(tab[3], 2);
            ahLab.Content = ax2.Substring(0, ax2.Length - 8);
            bhLab.Content = bx2.Substring(0, bx2.Length - 8);
            chLab.Content = cx2.Substring(0, cx2.Length - 8);
            dhLab.Content = dx2.Substring(0, dx2.Length - 8);

            alLab.Content = ax2.Substring(ax2.Length-8);
            blLab.Content = bx2.Substring(bx2.Length - 8);
            clLab.Content = cx2.Substring(cx2.Length - 8);
            dlLab.Content = dx2.Substring(dx2.Length - 8);
        }
    }
}
