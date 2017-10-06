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
    public partial class frmAlterarProduto : Form
    {
        ProdutoDTO produtoDTO = new ProdutoDTO();
        ProdutoBLL produtoBLL = new ProdutoBLL();
        CategoriaBLL categoriaBLL = new CategoriaBLL();
        CategoriaDTO categoriaDTO = new CategoriaDTO();
        frmProduto produto;        
        string tipo = "";
        string status = "";
        string str = "";

        public frmAlterarProduto(frmProduto p)
        {
            InitializeComponent();
            
            produto = p;            
            categoriaBLL.Carregar(cmbCategoria);
            txtNome.Text = produto.dtgProduto.CurrentRow.Cells[0].Value.ToString();
            txtPreco.Text = produto.dtgProduto.CurrentRow.Cells[1].Value.ToString();            
            Combo();
            categoriaDTO.Nome = produto.dtgProduto.CurrentRow.Cells[4].Value.ToString();            
            cmbCategoria.SelectedValue = categoriaBLL.SelecionarId(categoriaDTO);
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {            
            if (ValidarTexto() == 0)
            {
                produtoDTO.Nome = produto.dtgProduto.CurrentRow.Cells[0].Value.ToString();
                produtoDTO.Id = produtoBLL.SelecionarId(produtoDTO);
                produtoDTO.Nome = txtNome.Text;
                produtoDTO.Preco = Convert.ToDecimal(txtPreco.Text);
                produtoDTO.Tipo = tipo;
                produtoDTO.Status = status;
                produtoBLL.Atualizar(produtoDTO, cmbCategoria);
                MessageBox.Show("Alteração feita com sucesso!");
                this.Close();
            }
            else MessageBox.Show("Erro na alteração!");
        }

        private void frmAlterarProduto_Load(object sender, EventArgs e)
        {
            
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
            if (rdbDisponivel.Checked == false && rdbNaoDisponivel.Checked == false) { ret += 1; lblDisponivel.Visible = true; }

            return ret;
        }

        private void Combo() 
        {
            if (produto.dtgProduto.CurrentRow.Cells[2].Value.ToString() == "Produzido") { rdbProduzido.Checked = true; }
            else if (produto.dtgProduto.CurrentRow.Cells[2].Value.ToString() == "Pronto") { rdbPronto.Checked = true; }
            else rdbMateria.Checked = true;

            if (produto.dtgProduto.CurrentRow.Cells[3].Value.ToString() == "S") { rdbDisponivel.Checked = true; }
            else rdbNaoDisponivel.Checked = true;
        }

        private void rdbDisponivel_CheckedChanged(object sender, EventArgs e)
        {
            status = "S";
        }

        private void rdbNaoDisponivel_CheckedChanged(object sender, EventArgs e)
        {
            status = "N";
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
            else if ((str.Length < 10)&&(!((KeyCode == 8) || (KeyCode == 44))))
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

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAlterarProduto_FormClosed(object sender, FormClosedEventArgs e)
        {
            produto.dtgProduto.DataSource = produtoBLL.SelecionarTudo();
        }
    }
}
