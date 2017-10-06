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
using WPFBolado.Codigos;
using WPFBolado.DTO;
using WPFBolado.BLL;

namespace WPFBolado.Windows
{
    
    public partial class frmCaixa : Window
    {
        Money m = new Money();
        CaixaBLL caixaBLL = new CaixaBLL();
        CaixaDTO caixaDTO = new CaixaDTO();
        FuncionarioDTO fDTO = new FuncionarioDTO();
        FuncionarioBLL fBLL = new FuncionarioBLL();
        PedidoBLL peBLL = new PedidoBLL();
        MovimentacaoDTO mDTO = new MovimentacaoDTO();
        MovimentacaoBLL mBLL = new MovimentacaoBLL();
        LoginBLL loginBLL = new LoginBLL();
        LoginDTO loginDTO = new LoginDTO();
        static int teste = 0;

        public frmCaixa()
        {
            InitializeComponent();
            txtbCaixa.FontSize = 25;            
        }

        private void txtCaixa_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void txtCaixa_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            m.txtPreco_PreviewKeyDown(sender, e,txtCaixa);            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {            

            if (txtbCaixa.Text == "Fechado")
            {
                if (MessageBox.Show("Deseja abrir o caixa?", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                                                                               
                    caixaDTO.SaldoInicial = Convert.ToDecimal(txtCaixa.Text);

                    loginDTO.Usuario = frmLogin.user;
                    loginDTO.Senha = frmLogin.senha;
                    loginDTO.Id = loginBLL.SelecionarIdporNome(loginDTO);

                    fDTO.Id = fBLL.SelecionarIdPorLogin(loginDTO);                    
                    caixaBLL.Inserir(caixaDTO, fDTO);

                    mDTO.Descricao = "Saldo Inicial";
                    mDTO.Valor = Convert.ToDecimal(txtCaixa.Text);
                    mDTO.Tipo = "Entrada";
                    caixaDTO.Id = caixaBLL.SelecionarId();
                    mBLL.Inserir(mDTO, caixaDTO);                    

                    CaixaDTO.StatusCaixa = 1;
                    MessageBox.Show("Caixa aberto com sucesso!");                    
                    txtbCaixa.Foreground = Brushes.Green;
                    txtbCaixa.Text = "Aberto";
                    txtbAbrirFechar.Text = "Fechar";
                    txtCaixa.IsEnabled = false;
                    txtCaixa.Text = "0,00";
                    txtbInformacao.Text = caixaBLL.SelecionarFunc(loginDTO);
                    dataGrid.DataContext = mBLL.selecionarMov(caixaDTO);
                    teste++;
                }
                else
                {
                    txtCaixa.Clear();
                    m.limpaStr();
                }
            }
            else if (txtbCaixa.Text == "Aberto")
            {
                if (MessageBox.Show("Deseja fechar o caixa?", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    caixaDTO.Id = caixaBLL.SelecionarId();
                    caixaBLL.UpdateData(caixaDTO);

                    CaixaDTO.StatusCaixa = 0;
                    MessageBox.Show("Caixa Fechado com sucesso!");                    
                    txtbCaixa.Foreground = Brushes.Red;
                    txtbCaixa.Text = "Fechado";
                    txtbAbrirFechar.Text = "Abrir";
                    txtCaixa.IsEnabled = true;
                    teste = 0;
                    dataGrid.ItemsSource = null;
                    txtbInformacao.Text = "-";
                }
            }


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (CaixaDTO.StatusCaixa == 0)
            {
                txtbCaixa.Foreground = Brushes.Red;
                txtbCaixa.Text = "Fechado";
                txtbAbrirFechar.Text = "Abrir";
                txtCaixa.IsEnabled = true;
                txtbInformacao.Text = "-";
            }
            else if (CaixaDTO.StatusCaixa == 1)
            {
                txtbCaixa.Foreground = Brushes.Green;
                txtbCaixa.Text = "Aberto";
                btnAbrirFechar.Content = "Fechar";
                txtCaixa.IsEnabled = false;
                loginDTO.Usuario = frmLogin.user;
                loginDTO.Senha = frmLogin.senha;
                loginDTO.Id = loginBLL.SelecionarIdporNome(loginDTO);
                txtbInformacao.Text = caixaBLL.SelecionarFunc(loginDTO);
            }

            if (teste > 0)
            {
                caixaDTO.Id = caixaBLL.SelecionarId();
                dataGrid.DataContext = mBLL.selecionarMov(caixaDTO);
            }
            
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
