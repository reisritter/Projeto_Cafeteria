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
using WPFBolado.BLL;
using WPFBolado.DTO;

namespace WPFBolado.Windows
{    
    public partial class frmProduto : Window
    {
        ProdutoDTO produtoDTO = new ProdutoDTO();
        ProdutoBLL produtoBLL = new ProdutoBLL();

        public frmProduto()
        {
            InitializeComponent();            
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dtgProduto.DataContext = produtoBLL.SelecionarTudo();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            
        }        

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnCadastra_Click(object sender, RoutedEventArgs e)
        {
            Produto p = new Produto(this);
            p.ShowDialog();
        }

        private void btnPesquisa_Click(object sender, RoutedEventArgs e)
        {
            produtoDTO.Nome = txtPesquisa.Text;
            dtgProduto.DataContext = produtoBLL.SelecionarNome(produtoDTO);
        }

        private void btnUpd_Click(object sender, RoutedEventArgs e)
        {
            try {
                frmAlterarProd altp = new frmAlterarProd(this);
                altp.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Escolha um produto!");
            }
        }
    }
}
