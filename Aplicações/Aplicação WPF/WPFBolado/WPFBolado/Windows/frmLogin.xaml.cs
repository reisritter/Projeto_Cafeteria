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
    
    public partial class frmLogin : Window
    {
        LoginDTO loginDTO = new LoginDTO();
        LoginBLL loginBLL = new LoginBLL();
        CargoBLL cargoBLL = new CargoBLL();
        public static int ret;
        public static string user;
        public static string senha;
        string permissao = "";

        public frmLogin()
        {
            InitializeComponent();
            txtUsuario.Focus();
        }

        private void btnLogar_Click(object sender, RoutedEventArgs e)
        {
            loginDTO.Usuario = txtUsuario.Text;
            loginDTO.Senha = txtSenha.Password;            
            ret = loginBLL.Selecionar(loginDTO);
            loginDTO.Id = ret;
            permissao = cargoBLL.SelecionarPermissao(loginDTO);            

            user = txtUsuario.Text;
            senha = txtSenha.Password;

            if (ret > 0 && (!string.IsNullOrWhiteSpace(txtUsuario.Text) || !string.IsNullOrWhiteSpace(txtSenha.Password)))
            {
                if (permissao == "adm")
                {
                    try
                    {
                        this.Visibility = Visibility.Hidden;
                        Principal produto = new Principal();
                        produto.ShowDialog();
                    }
                    finally { this.Close(); }
                }
                else if (permissao == "atendente")
                {
                    try
                    {
                        this.Visibility = Visibility.Hidden;
                        PrincipalAtendente produto = new PrincipalAtendente();
                        produto.ShowDialog();
                    }
                    finally { this.Close(); }
                }
                
            }
            else { MessageBox.Show("Usuario/Senha inválido!"); Limpar(); }
        }

        public void Limpar()
        {
            txtSenha.Clear();
            txtUsuario.Clear();
            txtUsuario.Focus();
        }        

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void txtSenha_KeyDown_1(object sender, KeyEventArgs e)
        {
            RoutedEventArgs a = new RoutedEventArgs();

            if (e.Key == Key.Enter)
            {
                e.Handled = true;
                btnLogar_Click(sender, a);
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {            
            
        }
    }
}
