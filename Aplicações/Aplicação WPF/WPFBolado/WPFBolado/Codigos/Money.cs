using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace WPFBolado.Codigos
{
    class Money
    {
        string str = "";

        public void limpaStr()
        {
            str = "";
        }

        private bool IsNumeric(int Val)
        {
            return ((Val >= 34 && Val <= 43) || (Val == 2) || (Val >= 74 && Val <= 84));
        }

        public void soNumeros(object sender, System.Windows.Input.KeyEventArgs e, System.Windows.Controls.TextBox txtPreco)
        {
            int a = Convert.ToInt32(e.Key);
            if (!IsNumeric(a))
            {
                e.Handled = true;
                return;
            }
        }

        public void txtPreco_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e, System.Windows.Controls.TextBox txtPreco)
        {
            
            int a = Convert.ToInt32(e.Key);
            
            if (e.Key == Key.Delete)
            {
                SendKeys.SendWait("{BS}");
            }

            if (!IsNumeric(a))
            {
                e.Handled = true;
                return;
            }
            else
            {
                e.Handled = true;
            }

            if (((e.Key == Key.Back) || (e.Key == Key.OemComma)) && (str.Length > 0))
            {
                str = str.Substring(0, str.Length - 1);
            }
            else if (!(a >= 74 && a <= 84) && (str.Length < 6) && (!((e.Key == Key.Back) || (e.Key == Key.OemComma))))
            {
                str = str + Convert.ToChar(a + 14);
            }
            else if ((a >= 74 && a <= 84) && (str.Length < 6) && (!((e.Key == Key.Back) || (e.Key == Key.OemComma))))
            {
                switch (a)
                {
                    case 74:
                        str += Convert.ToChar(34+14);
                        break;
                    case 75:
                        str += Convert.ToChar(35+14);
                        break;
                    case 76:
                        str += Convert.ToChar(36+14);
                        break;
                    case 77:
                        str += Convert.ToChar(37+14);
                        break;
                    case 78:
                        str += Convert.ToChar(38+14);
                        break;
                    case 79:
                        str += Convert.ToChar(39+14);
                        break;
                    case 80:
                        str += Convert.ToChar(40+14);
                        break;
                    case 81:
                        str += Convert.ToChar(41+14);
                        break;
                    case 82:
                        str += Convert.ToChar(42+14);
                        break;
                    case 83:
                        str += Convert.ToChar(43+14);
                        break;
                    case 84:
                        str += Convert.ToChar(44+14);
                        break;
                }
            }            

            if (str.Length == 0)
            {
                txtPreco.Text = "0,00";
            }
            if (str.Length == 1)
            {
                txtPreco.Text = "0,0" + str;
            }
            else if (str.Length == 2)
            {
                txtPreco.Text = "0," + str;
            }
            else if (str.Length > 2 && str.Length <= 6)
            {
                txtPreco.Text = str.Substring(0, str.Length - 2) + "," +
                                str.Substring(str.Length - 2);
            }
        }

    }
}
