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
using WPFBolado.Windows.Alterar;
using WPFBolado.Windows.Cadastrar;
using WPFBolado.BLL;
using WPFBolado.DTO;

namespace WPFBolado.Windows
{
    
    public partial class frmFornecedor : Window
    {
        FornecedorBLL fBLL = new FornecedorBLL();
        FornecedorDTO fDTO = new FornecedorDTO();

        public frmFornecedor()
        {
            InitializeComponent();
        }

        private void btnCadastra_Click(object sender, RoutedEventArgs e)
        {
            frmCadastrarFornecedor frm = new frmCadastrarFornecedor(this);
            frm.ShowDialog();
        }

        private void btnUpd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                frmAlterarFornecedor frm = new frmAlterarFornecedor(this);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecionar fornecedor!");
            }
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnPesquisa_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dtgFornecedor.DataContext = fBLL.SelecionarTudo();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
