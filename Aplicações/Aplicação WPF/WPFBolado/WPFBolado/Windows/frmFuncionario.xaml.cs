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
using WPFBolado.Windows.Cadastrar;
using WPFBolado.Windows.Alterar;

namespace WPFBolado.Windows
{
    
    public partial class frmFuncionario : Window
    {
        FuncionarioBLL fBLL = new FuncionarioBLL();
        FuncionarioDTO fDTO = new FuncionarioDTO();

        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnPesquisa_Click(object sender, RoutedEventArgs e)
        {
            fDTO.Nome = txtPesquisa.Text;
            dtgFuncionario.DataContext = fBLL.SelecionarNome(fDTO);
        }

        private void btnCadastra_Click(object sender, RoutedEventArgs e)
        {
            frmCadastroFuncionario frmCad = new frmCadastroFuncionario(this);
            frmCad.ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dtgFuncionario.DataContext = fBLL.SelecionarTudo();
        }

        private void btnUpd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                frmAlterarFuncionario frmAlt = new frmAlterarFuncionario(this);
                frmAlt.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show("Selecione um funcionário!");}
        }
    }
}
