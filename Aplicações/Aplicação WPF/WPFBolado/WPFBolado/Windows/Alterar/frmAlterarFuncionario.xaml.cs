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
using WPFBolado.Codigos;

namespace WPFBolado.Windows.Alterar
{
    
    public partial class frmAlterarFuncionario : Window
    {
        FuncionarioDTO funcionarioDTO = new FuncionarioDTO();
        FuncionarioBLL funcionarioBLL = new FuncionarioBLL();
        CargoDTO cargoDTO = new CargoDTO();
        CargoBLL cargoBLL = new CargoBLL();
        LoginDTO loginDTO = new LoginDTO();
        LoginBLL loginBLL = new LoginBLL();
        frmFuncionario funcionario = new frmFuncionario();
        ValCpf valCpf = new ValCpf();
        Money m = new Money();
        int chbLoginVal = 0;

        public frmAlterarFuncionario(frmFuncionario f)
        {
            InitializeComponent();
            funcionario = f;
            cargoBLL.SelecionarNome(cmbCargo);

            object item = f.dtgFuncionario.SelectedItem;
            txtNome.Text = (f.dtgFuncionario.SelectedCells[0].Column.GetCellContent(item)as TextBlock).Text;
            txtEmail.Text = (f.dtgFuncionario.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
            funcionarioDTO.Cpf = (f.dtgFuncionario.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
            txtTelefone.Text = (f.dtgFuncionario.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
            txtEndereco.Text = (f.dtgFuncionario.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text; 
            txtCidade.Text = (f.dtgFuncionario.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text;
            txtBairro.Text = (f.dtgFuncionario.SelectedCells[6].Column.GetCellContent(item) as TextBlock).Text;
            txtCEP.Text = (f.dtgFuncionario.SelectedCells[7].Column.GetCellContent(item) as TextBlock).Text; 
            txtNumero.Text = (f.dtgFuncionario.SelectedCells[8].Column.GetCellContent(item) as TextBlock).Text;
            cmbUF.Text = (f.dtgFuncionario.SelectedCells[9].Column.GetCellContent(item) as TextBlock).Text;
            cargoDTO.Descricao = (f.dtgFuncionario.SelectedCells[10].Column.GetCellContent(item) as TextBlock).Text;
            cmbCargo.SelectedValue = 1;            
        }


        public void limpar()
        {
            txtNome.Clear();
            txtEmail.Clear();            
            txtTelefone.Clear();
            cmbCargo.SelectedIndex = -1;
            cmbUF.SelectedIndex = -1;
            txtEndereco.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            txtCEP.Clear();
            txtNumero.Clear();           
        }       

        public int validacaoDados()
        {
            int ret = 0;

            if (string.IsNullOrWhiteSpace(txtNome.Text)) { ret += 1; lblNome.Visibility = Visibility.Visible; }
            else lblNome.Visibility = Visibility.Hidden;        

            if (string.IsNullOrWhiteSpace(txtEmail.Text)) { ret += 1; lblEmail.Visibility = Visibility.Visible; }
            else
            {
                if (!(txtEmail.Text.IndexOf("@") >= 2 && txtEmail.Text.IndexOf(".") >= 5 && txtEmail.Text.Length >= 8))
                {

                    ret += 1;
                    lblEmail.Visibility = Visibility.Visible;
                    MessageBox.Show("Email inválido!");
                }
                else { lblEmail.Visibility = Visibility.Hidden; }                                   
                
            }
            if (string.IsNullOrWhiteSpace(txtTelefone.Text)) { ret += 1; lblTelefone.Visibility = Visibility.Visible; }
            else lblTelefone.Visibility = Visibility.Hidden;
            if (string.IsNullOrWhiteSpace(txtEndereco.Text)) { ret += 1; lblEndereco.Visibility = Visibility.Visible; }
            else lblEndereco.Visibility = Visibility.Hidden;
            if (string.IsNullOrWhiteSpace(txtBairro.Text)) { ret += 1; lblBairro.Visibility = Visibility.Visible; }
            else lblBairro.Visibility = Visibility.Hidden;
            if (string.IsNullOrWhiteSpace(txtCidade.Text)) { ret += 1; lblCidade.Visibility = Visibility.Visible; }
            else lblCidade.Visibility = Visibility.Hidden;
            //if (string.IsNullOrWhiteSpace(txtComplemento.Text)) { ret += 1; lblComplemento.Visibility = Visibility.Visible; }
            //else lblComplemento.Visibility = Visibility.Hidden;
            if (string.IsNullOrWhiteSpace(txtNumero.Text)) { ret += 1; lblNumero.Visibility = Visibility.Visible; }
            else lblNumero.Visibility = Visibility.Hidden;
            if (string.IsNullOrWhiteSpace(txtCEP.Text)) { ret += 1; lblCEP.Visibility = Visibility.Visible; }
            else lblCEP.Visibility = Visibility.Hidden;
            if (cmbCargo.SelectedIndex < 0) { ret += 1; lblCargo.Visibility = Visibility.Visible; }
            else lblCargo.Visibility = Visibility.Hidden;
            if (cmbUF.SelectedIndex < 0) { ret += 1; lblUF.Visibility = Visibility.Visible; }
            else lblUF.Visibility = Visibility.Hidden;


            return ret;
        }


        private void btnAlterar_Click(object sender, RoutedEventArgs e)
        {
            object item = funcionario.dtgFuncionario.SelectedItem;

            funcionarioDTO.Nome = txtNome.Text;
            funcionarioDTO.Id = funcionarioBLL.SelecionarId(funcionarioDTO);
            funcionarioDTO.Email = txtEmail.Text;            
            funcionarioDTO.Telefone = txtTelefone.Text;
            funcionarioDTO.Endereco = txtEndereco.Text;
            funcionarioDTO.Cidade = txtCidade.Text;
            funcionarioDTO.Bairro = txtBairro.Text;
            funcionarioDTO.Cep = txtCEP.Text;
            funcionarioDTO.Uf = cmbUF.Text;
            funcionarioDTO.Numero = txtNumero.Text;            
            
            if (validacaoDados() > 0)
            {
                MessageBox.Show("Erro na gravação!");
            }
            else
            {
                if (txtEmail.Text == (funcionario.dtgFuncionario.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text)
                {
                    funcionarioBLL.updateSemEmail(funcionarioDTO, cmbCargo);
                    MessageBox.Show("Alteração realizada com sucesso!");

                    funcionario.dtgFuncionario.DataContext = funcionarioBLL.SelecionarTudo();
                    this.Close();
                }
                else
                {
                    funcionarioBLL.update(funcionarioDTO, cmbCargo);
                    MessageBox.Show("Alteração realizada com sucesso!");

                    funcionario.dtgFuncionario.DataContext = funcionarioBLL.SelecionarTudo();
                    this.Close();
                }                                        
            }            
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }              

        private void txtTelefone_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            m.soNumeros(sender, e, txtTelefone);
        }

        private void txtCEP_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            m.soNumeros(sender, e, txtCEP);
        }

        private void txtNumero_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            m.soNumeros(sender, e, txtNumero);
        }
    }
}
