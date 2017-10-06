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
using System.Windows.Shapes;

namespace WPFBolado.Windows
{
    
    public partial class PrincipalAtendente : Window
    {
        public PrincipalAtendente()
        {
            InitializeComponent();
        }

        private void btnFunc_Click(object sender, RoutedEventArgs e)
        {
            frmInformacaoFunc frm = new frmInformacaoFunc();
            frm.ShowDialog();
        }

        private void btnPedidos_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnComp_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCaixa_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
