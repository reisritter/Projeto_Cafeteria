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

namespace WPFBolado.Windows.Cadastrar
{
    
    public partial class frmCadastroFuncionario : Window
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
        string msgErro = "";

        public frmCadastroFuncionario(frmFuncionario f)
        {
            InitializeComponent();
            funcionario = f;
            cargoBLL.SelecionarNome(cmbCargo);
            cmbCargo.SelectedIndex = -1;
            grpLogin.IsEnabled = false;
            
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            funcionarioDTO.Nome = txtNome.Text;
            funcionarioDTO.Email = txtEmail.Text;
            funcionarioDTO.Cpf = txtCPF.Text;
            funcionarioDTO.Telefone = txtTelefone.Text;
            funcionarioDTO.Endereco = txtEndereco.Text;
            funcionarioDTO.Cidade = txtCidade.Text;
            funcionarioDTO.Bairro = txtBairro.Text;            
            funcionarioDTO.Cep = txtCEP.Text;
            funcionarioDTO.Uf = cmbUF.Text;
            funcionarioDTO.Numero = txtNumero.Text;            

            if (chbLogin.IsChecked == true)
            {
                
                if (validacaoLogin() > 0)
                {
                    MessageBox.Show("Erro na gravação!");
                }
                else
                {
                    loginDTO.Usuario = txtUsuario.Text;
                    loginDTO.Senha = txtSenha.Text;
                    loginDTO.Lembrete = txtLembrete.Text;
                    loginBLL.Inserir(loginDTO);
                    loginDTO.Id = loginBLL.SelecionarId();
                    funcionarioBLL.Inserir(funcionarioDTO, cmbCargo, loginDTO);
                    MessageBox.Show("Cadastro realizado com sucesso!");

                    if (MessageBox.Show("Deseja realizar outro cadastro?", "Funcionário", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        limpar();
                        txtNome.Focus();
                    }
                    else
                    {
                        this.Close();
                        funcionario.dtgFuncionario.DataContext = funcionarioBLL.SelecionarTudo();
                    }
                }
               
            }
            else
            {
                lblUsuario.Visibility = Visibility.Hidden;
                lblSenha.Visibility = Visibility.Hidden;
                lblConfirmaSenha.Visibility = Visibility.Hidden;
                lblLembrete.Visibility = Visibility.Hidden;

                if (validacaoDados() > 0)
                {
                    MessageBox.Show("Erro na gravação!");
                }
                else
                {
                    loginDTO.Usuario = txtUsuario.Text;
                    loginDTO.Senha = txtSenha.Text;
                    loginDTO.Lembrete = txtLembrete.Text;
                    loginBLL.Inserir(loginDTO);
                    loginDTO.Id = loginBLL.SelecionarId();
                    funcionarioBLL.Inserir(funcionarioDTO, cmbCargo, loginDTO);
                    MessageBox.Show("Cadastro realizado com sucesso!");

                    if (MessageBox.Show("", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        limpar();
                        txtNome.Focus();
                    }
                    else
                    {
                        this.Close();
                        funcionario.dtgFuncionario.DataContext = funcionarioBLL.SelecionarTudo();
                    }
                }
            }
        }

        public void limpar()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtCPF.Clear();
            txtTelefone.Clear();
            cmbCargo.SelectedIndex = -1;
            cmbUF.SelectedIndex = -1;
            txtEndereco.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            txtCEP.Clear();
            txtNumero.Clear();
            txtLembrete.Clear();
            txtSenha.Clear();
            txtConfirmarSenha.Clear();
            txtUsuario.Clear();            
        }

        public int validacaoLogin()
        {
            int ret = 0;            

            if (string.IsNullOrWhiteSpace(txtUsuario.Text)) { ret++; lblUsuario.Visibility = Visibility.Visible; }
            else
            {
                if (loginBLL.ProcurarLogin(txtUsuario, "usuario") > 0)
                {
                    ret++;
                    lblUsuario.Visibility = Visibility.Visible;
                    MessageBox.Show("Login já existe!");
                }
                else { lblUsuario.Visibility = Visibility.Hidden;}                
            }

            if (txtSenha.Text == txtConfirmarSenha.Text)
            {
                lblSenha.Visibility = Visibility.Hidden;
                lblConfirmaSenha.Visibility = Visibility.Hidden;
            }
            else
            {
                ret++;
                lblSenha.Visibility = Visibility.Visible;
                lblConfirmaSenha.Visibility = Visibility.Visible;
            }

            if (string.IsNullOrWhiteSpace(txtSenha.Text)) { ret++; lblSenha.Visibility = Visibility.Visible; }
            else { lblSenha.Visibility = Visibility.Hidden; }
            if (string.IsNullOrWhiteSpace(txtConfirmarSenha.Text)) { ret++; lblConfirmaSenha.Visibility = Visibility.Visible; }
            else { lblConfirmaSenha.Visibility = Visibility.Hidden; }
            if (string.IsNullOrWhiteSpace(txtLembrete.Text)) { ret++; lblLembrete.Visibility = Visibility.Visible; }
            else { lblLembrete.Visibility = Visibility.Hidden; }

            ret += validacaoDados();

            return ret;
        }

        public int validacaoDados()
        {
            int ret = 0;

            if (string.IsNullOrWhiteSpace(txtNome.Text)) { ret += 1; lblNome.Visibility = Visibility.Visible; }
            else lblNome.Visibility = Visibility.Hidden;
            if (string.IsNullOrWhiteSpace(txtCPF.Text)) { ret += 1; lblCPF.Visibility = Visibility.Visible; }
            else
            {
                if (txtCPF.Text.Length < 11)
                {
                    //MessageBox.Show("Cpf não tem 11 digitos!");
                    lblCPF.Visibility = Visibility.Visible;
                    ret++;
                }
                else
                {
                    //MessageBox.Show("Opa");
                    if (valCpf.ValidaCPF(txtCPF.Text) == false)
                    {
                        ret += 1;
                        //MessageBox.Show("CPF não é valido");
                        lblCPF.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        if (funcionarioBLL.ProcurarMasked(txtCPF, "cpf") > 0)
                        {
                            MessageBox.Show("CPF igual!!");
                            ret += 1;
                            lblCPF.Visibility = Visibility.Visible;
                        }
                        else lblCPF.Visibility = Visibility.Hidden;
                    }
                }
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text)) { ret += 1; lblEmail.Visibility = Visibility.Visible; }
            else
            {
                if (!(txtEmail.Text.IndexOf("@") >= 2 && txtEmail.Text.IndexOf(".") >= 5 && txtEmail.Text.Length >= 8))
                {
                    
                    ret += 1;
                    lblEmail.Visibility = Visibility.Visible;
                }

                else
                {
                    if (funcionarioBLL.Procurar(txtEmail, "email") > 0)
                    {
                    
                        ret += 1;
                        lblEmail.Visibility = Visibility.Visible;
                    }
                    else
                        lblEmail.Visibility = Visibility.Hidden;
                }
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

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void chbLogin_Checked(object sender, RoutedEventArgs e)
        {
            grpLogin.IsEnabled = true;
        }

        private void chbLogin_Unchecked(object sender, RoutedEventArgs e)
        {
            grpLogin.IsEnabled = false;
        }        

        private void txtCPF_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            m.soNumeros(sender,e,txtCPF);
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
