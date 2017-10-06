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
    public partial class frmCadastrarFornecedor : Window
    {
        Money m = new Money();
        FornecedorBLL Fbll = new FornecedorBLL();
        FornecedorDTO Fdto = new FornecedorDTO();
        frmFornecedor fornecedor = new frmFornecedor();
        string msgErro = "";

        public frmCadastrarFornecedor(frmFornecedor f)
        {
            fornecedor = f; 
            InitializeComponent();
        }

        private void txtCNPJ_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            m.soNumeros(sender, e, txtCNPJ);
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

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            if (validacaoDados() == 0)
            {
                Fdto.Uf = cmbUF.Text;
                Fdto.Numero = txtNumero.Text;
                Fdto.Razao_social = txtNome.Text;
                Fdto.Cnpj = txtCNPJ.Text;
                Fdto.Cidade = txtCidade.Text;
                Fdto.Complemento = txtComplemento.Text;
                Fdto.Email = txtEmail.Text;
                Fdto.Cep = txtCEP.Text;
                Fdto.Endereco = txtEndereco.Text;
                Fdto.Gerente = txtGerente.Text;
                Fdto.Bairro = txtBairro.Text;
                Fdto.Telefone = txtTelefone.Text;
                Fbll.Inserir(Fdto);
                MessageBox.Show("Cadastro realizado com sucesso!");

                if (MessageBox.Show("Deseja realizar outro cadastro?", "Forncedor", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    limpar();
                    txtNome.Focus();
                }
                else
                {
                    fornecedor.dtgFornecedor.DataContext = Fbll.SelecionarTudo();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(msgErro);
                msgErro = "";
            }
            
        }

        public void limpar()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtCNPJ.Clear();
            txtTelefone.Clear();
            txtGerente.Clear();
            cmbUF.SelectedIndex = -1;
            txtEndereco.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            txtCEP.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();           
        }

        public int validacaoDados()
        {
            int ret = 0;

            if (string.IsNullOrWhiteSpace(txtCNPJ.Text))
            {
                ret++;
                lblCNPJ.Visibility = Visibility.Visible;
                msgErro += "Campo CNPJ vazio.\n";
            }
            else
            {
                lblCNPJ.Visibility = Visibility.Hidden;
            }

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                ret += 1;
                lblNome.Visibility = Visibility.Visible;
                msgErro += "Campo Nome vazio.\n";
            }
            else lblNome.Visibility = Visibility.Hidden;           

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                ret += 1;
                lblEmail.Visibility = Visibility.Visible;
                msgErro += "Campo Email vazio.\n";
            }
            else
            {
                if (!(txtEmail.Text.IndexOf("@") >= 2 && txtEmail.Text.IndexOf(".") >= 5 && txtEmail.Text.Length >= 8))
                {
                    ret += 1;
                    lblEmail.Visibility = Visibility.Visible;
                    msgErro += "Email inválido.\n";
                }

                else
                {
                    if (Fbll.Procurar(txtEmail, "email") > 0)
                    {
                        ret += 1;
                        lblEmail.Visibility = Visibility.Visible;
                        msgErro += "Email já usado vazio.\n";
                    }
                    else
                        lblEmail.Visibility = Visibility.Hidden;
                }
            }
            if (string.IsNullOrWhiteSpace(txtTelefone.Text))
            {
                ret += 1;
                lblTelefone.Visibility = Visibility.Visible;
                msgErro += "Campo Telefone vazio.\n";
            }
            else lblTelefone.Visibility = Visibility.Hidden;

            if (string.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                ret += 1;
                lblEndereco.Visibility = Visibility.Visible;
                msgErro += "Campo Endereço vazio.\n";
            }
            else lblEndereco.Visibility = Visibility.Hidden;

            if (string.IsNullOrWhiteSpace(txtBairro.Text))
            {
                ret += 1;
                lblBairro.Visibility = Visibility.Visible;
                msgErro += "Campo Bairro vazio.\n";
            }
            else lblBairro.Visibility = Visibility.Hidden;

            if (string.IsNullOrWhiteSpace(txtCidade.Text))
            {
                ret += 1;
                lblCidade.Visibility = Visibility.Visible;
                msgErro += "Campo Cidade vazio.\n";
            }
            else lblCidade.Visibility = Visibility.Hidden;

            if (string.IsNullOrWhiteSpace(txtGerente.Text))
            {
                ret += 1;
                lblGerente.Visibility = Visibility.Visible;
                msgErro += "Campo Gerente vazio.\n";
            }
            else lblGerente.Visibility = Visibility.Hidden;

            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                ret += 1;
                lblNumero.Visibility = Visibility.Visible;
                msgErro += "Campo Número vazio.\n";
            }
            else lblNumero.Visibility = Visibility.Hidden;

            if (string.IsNullOrWhiteSpace(txtCEP.Text))
            {
                ret += 1;
                lblCEP.Visibility = Visibility.Visible;
                msgErro += "Campo CEP vazio.\n";
            }
            else lblCEP.Visibility = Visibility.Hidden;
           
            if (cmbUF.SelectedIndex < 0)
            {
                ret += 1;
                lblUF.Visibility = Visibility.Visible;
                msgErro += "Campo UF vazio.\n";
            }
            else lblUF.Visibility = Visibility.Hidden;


            return ret;
        }
    }
}
