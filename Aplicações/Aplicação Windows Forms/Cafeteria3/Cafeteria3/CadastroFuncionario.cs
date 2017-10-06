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
using Cafeteria3.Codigo.Validacao;
using System.Globalization;

namespace Cafeteria3
{
    public partial class frmCadastroFuncionario : Form
    {
        
        FuncionarioDTO funcionarioDTO = new FuncionarioDTO();
        FuncionarioBLL funcionarioBLL = new FuncionarioBLL();
        CargoDTO cargoDTO = new CargoDTO();
        CargoBLL cargoBLL = new CargoBLL();
        LoginDTO loginDTO = new LoginDTO();
        frmFuncionario funcionario = new frmFuncionario();
        ValCpf valCpf = new ValCpf();
        bool valData = false;
        

        public frmCadastroFuncionario(frmFuncionario f)
        {
            funcionario = f;
            InitializeComponent();
            cargoBLL.SelecionarNome(cmbCargo);
            cmbCargo.SelectedIndex = -1;
            grpLogin.Enabled = false;
            
        }

        private void btmSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {                        
            if (Validacao() == 0)
            {
                
                funcionarioDTO.Nome = txtNome.Text;
                funcionarioDTO.Cpf = mskCPF.Text;
                funcionarioDTO.Email = txtEmail.Text;
                funcionarioDTO.Telefone = mskTel.Text;
                funcionarioDTO.Dt_Nascimento = Convert.ToDateTime(mskData.Text);
                funcionarioDTO.Endereco = txtEndereco.Text;
                funcionarioDTO.Bairro = txtBairro.Text;
                funcionarioDTO.Cidade = txtCidade.Text;
                funcionarioDTO.Uf = cmbUF.SelectedItem.ToString();
                funcionarioDTO.Complemento = txtComplemento.Text;
                funcionarioDTO.Numero = txtNumero.Text;
                funcionarioDTO.Cep = txtCEP.Text;                
                loginDTO.Id = 1;
                funcionarioBLL.Inserir(funcionarioDTO, cmbCargo, loginDTO);
                MessageBox.Show("Cadastro realizado com sucesso!");
                Limpar();
            }

            else 
            {
                MessageBox.Show("Erro na gravação!");
            }
        }

        public int Validacao() 
        {
            int ret = 0; 
            var data = mskData.Text.Replace("/","").Trim();            

            if (string.IsNullOrWhiteSpace(txtNome.Text)) { ret += 1; lblNome.Visible = true; }
            else lblNome.Visible = false;
            if (string.IsNullOrWhiteSpace(mskCPF.Text)) { ret += 1; lblCPF.Visible = true;}
            else
            {
                if (mskCPF.Text.Length < 11)
                {
                    //MessageBox.Show("Cpf não tem 11 digitos!");
                    lblCPF.Visible = true;
                }
                else
                {
                    //MessageBox.Show("Opa");
                    if (valCpf.ValidaCPF(mskCPF.Text) == false)
                    {
                        ret += 1;
                        //MessageBox.Show("CPF não é valido");
                        lblCPF.Visible = true;                        
                    }
                    else
                    {
                        if (funcionarioBLL.ProcurarMasked(mskCPF, "cpf") > 0)
                        {
                            //MessageBox.Show("CPF igual!!");
                            ret += 1;
                            lblCPF.Visible = true;
                        }
                        else lblCPF.Visible = false;
                    }                        
                }
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text)) { ret += 1; lblEmail.Visible = true; }
            else
            {
                if (!(txtEmail.Text.IndexOf("@") >= 2 && txtEmail.Text.IndexOf(".") >= 5 && txtEmail.Text.Length >= 8))
                {
                    //MessageBox.Show("Email inválido!!");
                    ret += 1;
                    lblEmail.Visible = true;
                }

                else
                {
                    if (funcionarioBLL.Procurar(txtEmail, "email") > 0)
                    {
                        //MessageBox.Show("Email igual!");
                        ret += 1;
                        lblEmail.Visible = true;
                    }
                    else
                        lblEmail.Visible = false;
                }
            }
            if (string.IsNullOrWhiteSpace(mskTel.Text)) { ret += 1; lblTel.Visible = true; }
            else lblTel.Visible = false;
            if (string.IsNullOrWhiteSpace(txtEndereco.Text)) { ret += 1; lblEnd.Visible = true; }
            else lblEnd.Visible = false;
            if (string.IsNullOrWhiteSpace(txtBairro.Text)) { ret += 1; lblBairro.Visible = true; }
            else lblBairro.Visible = false;
            if (string.IsNullOrWhiteSpace(txtCidade.Text)) { ret += 1; lblCidade.Visible = true; }
            else lblCidade.Visible = false;
            //if (string.IsNullOrWhiteSpace(txtComplemento.Text)) { ret += 1; lblComplemento.Visible = true; }
            //else lblComplemento.Visible = false;
            if (string.IsNullOrWhiteSpace(txtNumero.Text)) { ret += 1; lblNumero.Visible = true; }
            else lblNumero.Visible = false;
            if (string.IsNullOrWhiteSpace(txtCEP.Text)) { ret += 1; lblCep.Visible = true; }
            else lblCep.Visible = false;
            if (data.Length == 0 || valData == true) { ret += 1; lblData.Visible = true;}
            else
            {                
                if (mskData.Text.Replace("/","").Length == 8)
                {
                    if (Convert.ToInt32(data.Substring(4, 4)) >= 1900)
                    {
                        //MessageBox.Show("Data Válida!");
                        lblData.Visible = false;
                    }
                    else
                    {
                        //MessageBox.Show("Data inválida!"); 
                        lblData.Visible = true;
                        ret += 1;
                    }
                }
                else
                {
                    //MessageBox.Show("Data inválida!"); 
                    lblData.Visible = true;
                    ret += 1;
                }              
            }
            if (cmbCargo.SelectedIndex < 0) { ret += 1; lblCargo.Visible = true; }
            else lblCargo.Visible = false;
            if (cmbUF.SelectedIndex < 0) { ret += 1; lblUf.Visible = true; }
            else lblUf.Visible = false;

            return ret;
        }

        public void Limpar() 
        {
            txtNome.Clear();
            txtNumero.Clear();
            mskTel.Clear();
            txtEndereco.Clear();
            txtEmail.Clear();
            mskCPF.Clear();
            mskData.Clear();
            txtComplemento.Clear();
            txtCidade.Clear();
            txtCEP.Clear();
            txtBairro.Clear();
            cmbCargo.SelectedIndex = -1;
            cmbUF.SelectedIndex = -1;
        }

        private void frmCadastroFuncionario_FormClosed(object sender, FormClosedEventArgs e)
        {
            funcionario.dtgFuncionario.DataSource = funcionarioBLL.SelecionarTudo();
        }

        private void mskData_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void mskData_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
                valData = true;
            else
                valData = false;            
        }

        public void CheckLogin() 
        {            
            if (chbLogin.Checked)
            {
                grpLogin.Enabled = true;
            }
            else
            {
                grpLogin.Enabled = false;
                txtUsuario.Clear();
                txtSenha.Clear();
                txtConfirmaSenha.Clear();
                cmbPermissao.SelectedIndex = -1;
            }
        }

        private void frmCadastroFuncionario_Load(object sender, EventArgs e)
        {
            
        }

        private void chbLogin_Click(object sender, EventArgs e)
        {
            CheckLogin();
        }

        //string numero = "";

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == Convert.ToChar(8))) 
            {
                e.Handled = true;
            }            
        }

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == Convert.ToChar(8))) 
            {
                e.Handled = true;
            }
        }
    }
}
