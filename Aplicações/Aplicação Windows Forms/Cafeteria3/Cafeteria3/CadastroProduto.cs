using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cafeteria3.Codigo.BLL;
using Cafeteria3.Codigo.DTO;

namespace Cafeteria3
{
    public partial class frmCadastroProduto : Form
    {
        ProdutoBLL produtoBll = new ProdutoBLL();
        ProdutoDTO produtoDTO = new ProdutoDTO();
        CategoriaDTO categoriaDTO = new CategoriaDTO();
        CategoriaBLL categoriaBLL = new CategoriaBLL();
        frmProduto produto = new frmProduto();
        string tipo = "";
        string str = "";

        public frmCadastroProduto(frmProduto p)
        {
            InitializeComponent();
            produto = p;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
                       
            if (ValidarTexto() == 0)
            {
                produtoDTO.Nome = txtNome.Text;
                produtoDTO.Preco = Convert.ToDecimal(txtPreco.Text);
                produtoDTO.Tipo = tipo;
                produtoBll.Inserir(produtoDTO,cmbCategoria);
                MessageBox.Show("Cadastro realizado com sucesso!");                
                DialogResult resultado = MessageBox.Show("Deseja fazer um novo cadastro?","",MessageBoxButtons.YesNo);
                if (resultado.ToString().ToUpper() == "YES")
                {
                  Limpar();
                  txtNome.Focus();
                }
                else this.Close();
            }
            else MessageBox.Show("Erro na gravação!");            
        }

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            categoriaBLL.Carregar(cmbCategoria);
        }     

        private void btmSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        public int ValidarTexto() 
        {
            int ret = 0;

            if (string.IsNullOrWhiteSpace(txtNome.Text.Trim())) { ret += 1; lblNome.Visible = true; }
            else lblNome.Visible = false;
            if (string.IsNullOrWhiteSpace(txtPreco.Text.Trim())) { ret += 1; lblPreco.Visible = true; }
            else lblPreco.Visible = false;
            if (rdbMateria.Checked == false && rdbProduzido.Checked == false && rdbPronto.Checked == false) { ret += 1; lblTipo.Visible = true; }
            else lblTipo.Visible = false;
            if (cmbCategoria.SelectedIndex < 0) { ret += 1; lblCategoria.Visible = true; }
            else lblCategoria.Visible = false;

            return ret;
        }

        public void Limpar()
        {
            txtNome.Clear();
            txtPreco.Clear();
            str = "";
            cmbCategoria.SelectedIndex = -1;
            rdbMateria.Checked = false;
            rdbProduzido.Checked = false;
            rdbPronto.Checked = false;
        }       

        private bool IsNumeric(int Val)
        {
            return ((Val >= 48 && Val <= 57) || (Val == 8) || (Val == 44));
        }

        private void txtPreco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                SendKeys.Send("{BS}");
            }

            int KeyCode = e.KeyValue;

            if (!IsNumeric(KeyCode))
            {
                e.Handled = true;
                return;
            }
            else
            {
                e.Handled = true;
            }

            if (((KeyCode == 8) || (KeyCode == 44)) && (str.Length > 0))
            {
                str = str.Substring(0, str.Length - 1);
            }
            else if ((str.Length < 10) && (!((KeyCode == 8) || (KeyCode == 44))))
            {
                str = str + Convert.ToChar(KeyCode);
            }

            if (str.Length == 0)
            {
                txtPreco.Text = "";
            }
            if (str.Length == 1)
            {
                txtPreco.Text = "0,0" + str;
            }
            else if (str.Length == 2)
            {
                txtPreco.Text = "0," + str;
            }
            else if (str.Length > 2 && str.Length <= 10)
            {
                txtPreco.Text = str.Substring(0, str.Length - 2) + "," +
                                str.Substring(str.Length - 2);
            }                   
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void rdbPronto_CheckedChanged(object sender, EventArgs e)
        {
            tipo = "Pronto";
        }

        private void rdbProduzido_CheckedChanged(object sender, EventArgs e)
        {
            tipo = "Produzido";
        }

        private void rdbMateria_CheckedChanged(object sender, EventArgs e)
        {
            tipo = "Matéria";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void grpbDados_Enter(object sender, EventArgs e)
        {

        }

        private void frmCadastroProduto_FormClosed(object sender, FormClosedEventArgs e)
        {
            produto.dtgProduto.DataSource = produtoBll.SelecionarTudo();
        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
