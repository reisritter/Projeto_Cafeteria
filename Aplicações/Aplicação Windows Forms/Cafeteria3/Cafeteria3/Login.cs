using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cafeteria3.Codigo.DTO;
using Cafeteria3.Codigo.BLL;

namespace Cafeteria3
{
    public partial class frmLogin : Form
    {
        LoginDTO loginDTO = new LoginDTO();
        LoginBLL loginBLL = new LoginBLL();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {            
            loginDTO.Usuario = txtUsuario.Text;
            loginDTO.Senha = txtSenha.Text;
            int ret = loginBLL.Selecionar(loginDTO);
            
            if (ret > 0)
            {
                try
                {
                    this.Visible = false;
                    frmPrincipal produto = new frmPrincipal();
                    produto.ShowDialog();                    
                }
                finally { this.Close();}
            }
            else { MessageBox.Show("Usuario/Senha inválido!"); Limpar(); }
        }

        public void Limpar() 
        { 
            txtSenha.Clear();
            txtUsuario.Clear();
            txtUsuario.Focus();
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {                                
                e.Handled = true;
                e.SuppressKeyPress = true;
                btnEntrar.Select();
                SendKeys.Send("{ENTER}");
            }

            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
