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
using WPFBolado.DTO;

namespace WPFBolado.Windows
{
    
    public partial class Principal : Window
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnProduto_Click(object sender, RoutedEventArgs e)
        {
            frmProduto p = new frmProduto();
            p.ShowDialog();
        }

        private void btnPedidos_Click(object sender, RoutedEventArgs e)
        {
            if (CaixaDTO.StatusCaixa == 1)
            {
                frmPedidos pe = new frmPedidos();
                pe.ShowDialog();
            }
            else if (CaixaDTO.StatusCaixa == 0)
            {                
                if (MessageBox.Show("Caixa Fechado!\nGostaria de abrir?","Caixa Fechado",MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    frmCaixa c = new frmCaixa();
                    c.ShowDialog();
                }
                else{}
            }
            else
            {
                MessageBox.Show("Erro! status diferente!");
            }
        }

        private void btnCaixa_Click(object sender, RoutedEventArgs e)
        {
            frmCaixa c = new frmCaixa();
            c.ShowDialog();
        }

        private void btnFunc_Click(object sender, RoutedEventArgs e)
        {
            frmFuncionario f = new frmFuncionario();
            f.ShowDialog();
        }

        private void btnForn_Click(object sender, RoutedEventArgs e)
        {
            frmFornecedor frm = new frmFornecedor();
            frm.ShowDialog();
        }

        private void btnConfig_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
