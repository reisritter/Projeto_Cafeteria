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
    
    public partial class frmAlterarFornecedor : Window
    {
        Money m = new Money();
        FornecedorBLL Fbll = new FornecedorBLL();
        FornecedorDTO Fdto = new FornecedorDTO();
        frmFornecedor fornecedor = new frmFornecedor();
        string msgErro = "";

        public frmAlterarFornecedor(frmFornecedor f)
        {
            fornecedor = f;
            InitializeComponent();

            object item = f.dtgFornecedor.SelectedItem;
            txtNome.Text = (f.dtgFornecedor.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
            txtEmail.Text = (f.dtgFornecedor.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
            txtTelefone.Text = (f.dtgFornecedor.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
            txtGerente.Text = (f.dtgFornecedor.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;
            txtEndereco.Text = (f.dtgFornecedor.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text;
            txtBairro.Text = (f.dtgFornecedor.SelectedCells[6].Column.GetCellContent(item) as TextBlock).Text;
            txtCidade.Text = (f.dtgFornecedor.SelectedCells[7].Column.GetCellContent(item) as TextBlock).Text;
            cmbUF.Text = (f.dtgFornecedor.SelectedCells[8].Column.GetCellContent(item) as TextBlock).Text;
            txtCEP.Text = (f.dtgFornecedor.SelectedCells[9].Column.GetCellContent(item) as TextBlock).Text;
            txtComplemento.Text = (f.dtgFornecedor.SelectedCells[10].Column.GetCellContent(item) as TextBlock).Text;
            txtNumero.Text = (f.dtgFornecedor.SelectedCells[11].Column.GetCellContent(item) as TextBlock).Text;
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnAlterar_Click(object sender, RoutedEventArgs e)
        {
            object item = fornecedor.dtgFornecedor.SelectedItem;

            if (validacaoDados() == 0)
            {
                Fdto.Uf = cmbUF.Text;
                Fdto.Numero = txtNumero.Text;
                Fdto.Razao_social = txtNome.Text;                
                Fdto.Cidade = txtCidade.Text;
                Fdto.Complemento = txtComplemento.Text;
                Fdto.Email = txtEmail.Text;
                Fdto.Cep = txtCEP.Text;
                Fdto.Endereco = txtEndereco.Text;
                Fdto.Gerente = txtGerente.Text;
                Fdto.Bairro = txtBairro.Text;
                Fdto.Telefone = txtTelefone.Text;

                if (txtEmail.Text == (fornecedor.dtgFornecedor.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text)
                {                    
                    Fbll.updateSemEmail(Fdto);
                    MessageBox.Show("Alteração realizada com sucesso!");
                    fornecedor.dtgFornecedor.DataContext = Fbll.SelecionarTudo();
                    this.Close();                                        
                }
                else
                {
                    if (validacaoDadosEmail() == 0)
                    {
                        Fbll.update(Fdto);
                        MessageBox.Show("Alteração realizada com sucesso!");
                        fornecedor.dtgFornecedor.DataContext = Fbll.SelecionarTudo();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(msgErro);
                        msgErro = "";
                    }
                }                           
            }
            else
            {
                MessageBox.Show(msgErro);
                msgErro = "";
            }
        }

        public int validacaoDadosEmail()
        {
            int ret = 0;
            validacaoDados();
            if (Fbll.Procurar(txtEmail, "email") > 0)
            {
                ret += 1;
                lblEmail.Visibility = Visibility.Visible;
                msgErro += "Email já usado vazio.\n";
            }
            else
                lblEmail.Visibility = Visibility.Hidden;
            return ret;
        }

        public int validacaoDados()
        {
            int ret = 0;           

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
