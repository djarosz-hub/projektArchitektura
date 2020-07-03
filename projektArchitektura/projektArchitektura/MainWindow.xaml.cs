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
            var ax = axLab;
            var ah = ahLab;
            var al = alLab;
            var bx = bxLab;
            var bh = bhLab;
            var bl = blLab;
            var cx = cxLab;
            var ch = chLab;
            var cl = clLab;
            var dx = dxLab;
            var dh = dhLab;
            var dl = dlLab;
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
                commandTab[2] = commandTab[2].Trim();
                if (commandTab[0] == "MOV" || commandTab[0] == "mov")
                {

                    if (commandTab[1] == "AX" || commandTab[1] == "ax")
                    {
                        if (ValueToMove(commandTab[2]))
                        {
                            MoveR(ax, commandTab[2]);
                        }
                        else if (ValueCheck(commandTab[2]))
                        {
                            Move(ax, commandTab[2]);
                        }
                        else
                            commandInput.Text = "Niepoprawne dane";
                    }
                    if (commandTab[1] == "BX" || commandTab[1] == "bx")
                    {
                        if (ValueToMove(commandTab[2]))
                        {
                            MoveR(bx, commandTab[2]);
                        }
                        else if (ValueCheck(commandTab[2]))
                        {
                            Move(bx, commandTab[2]);
                        }
                        else
                            commandInput.Text = "Niepoprawne dane";
                    }
                    if (commandTab[1] == "CX" || commandTab[1] == "cx")
                    {
                        if (ValueToMove(commandTab[2]))
                        {
                            MoveR(cx, commandTab[2]);
                        }
                        else if (ValueCheck(commandTab[2]))
                        {
                            Move(cx, commandTab[2]);
                        }
                        else
                            commandInput.Text = "Niepoprawne dane";
                    }
                    if (commandTab[1] == "DX" || commandTab[1] == "dx")
                    {
                        if (ValueToMove(commandTab[2]))
                        {
                            MoveR(dx, commandTab[2]);
                        }
                        else if (ValueCheck(commandTab[2]))
                        {
                            Move(dx, commandTab[2]);
                        }
                        else
                            commandInput.Text = "Niepoprawne dane";
                    }
                }
                else if (commandTab[0] == "SWAP" || commandTab[0] == "swap")
                {
                    axLab.Content = "dziala swap";
                }
                else
                {
                    commandInput.Text = "Niepoprawna komenda";
                }

            }
            bool ValueToMove(string val)
            {
                int flag = 0;
                string[] dic = new string[] { "AX", "BX", "CX", "DX", "ax", "bx", "cx", "dx", "AH", "ah", "AL", "al", "BH", "bh", "BL", "bl", "CH", "ch", "CL", "cl", "DH", "dh", "DL", "dl" };
                foreach (string x in dic)
                {
                    if (val.Contains(x))
                    {
                        flag = 1;
                        break;
                    }
                }
                return flag == 1 ? true : false;
            }
            bool Check(string x)
            {
                bool a = x.Contains(' ');
                bool b = x.Contains(',');
                if (a && b && input.IndexOf(' ') < input.IndexOf(',')) return true;
                else return false;
            }
            bool ValueCheck(string x)
            {
                int y = Int32.Parse(x, System.Globalization.NumberStyles.HexNumber);
                if ((y < 65536) && (y > 0))
                    return true;
                else
                    commandInput.Text = "Liczba spoza zakresu";
                return false;
            }
            void Move(Label x, string val)
            {
                x.Content = val;
            }
            void MoveR(Label x, string val)
            {
                switch (val)
                {
                    case "AX":
                        x.Content = axLab.Content;
                        break;
                    case "ax":
                        x.Content = axLab.Content;
                        break;
                    case "AH":
                        x.Content = ahLab.Content;
                        break;
                    case "ah":
                        x.Content = ahLab.Content;
                        break;
                    case "AL":
                        x.Content = alLab.Content;
                        break;
                    case "al":
                        x.Content = alLab.Content;
                        break;
                    case "BX":
                        x.Content = bxLab.Content;
                        break;
                    case "bx":
                        x.Content = bxLab.Content;
                        break;
                    case "BH":
                        x.Content = bhLab.Content;
                        break;
                    case "bh":
                        x.Content = bhLab.Content;
                        break;
                    case "BL":
                        x.Content = blLab.Content;
                        break;
                    case "bl":
                        x.Content = blLab.Content;
                        break;
                    case "CX":
                        x.Content = cxLab.Content;
                        break;
                    case "cx":
                        x.Content = cxLab.Content;
                        break;
                    case "CH":
                        x.Content = chLab.Content;
                        break;
                    case "ch":
                        x.Content = chLab.Content;
                        break;
                    case "CL":
                        x.Content = clLab.Content;
                        break;
                    case "cl":
                        x.Content = clLab.Content;
                        break;
                    case "DX":
                        x.Content = dxLab.Content;
                        break;
                    case "dx":
                        x.Content = dxLab.Content;
                        break;
                    case "DH":
                        x.Content = dhLab.Content;
                        break;
                    case "dh":
                        x.Content = dhLab.Content;
                        break;
                    case "DL":
                        x.Content = dlLab.Content;
                        break;
                    case "dl":
                        x.Content = dlLab.Content;
                        break;
                    default:
                        commandInput.Text = val+"wtf";
                        break;
                }
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
            for (int i = 0; i < tab.Length; i++)
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

            alLab.Content = ax2.Substring(ax2.Length - 8);
            blLab.Content = bx2.Substring(bx2.Length - 8);
            clLab.Content = cx2.Substring(cx2.Length - 8);
            dlLab.Content = dx2.Substring(dx2.Length - 8);
        }
    }
}
