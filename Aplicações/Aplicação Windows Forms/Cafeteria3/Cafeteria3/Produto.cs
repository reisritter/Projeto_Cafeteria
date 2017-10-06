using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cafeteria3.Codigo.DAL;
using Cafeteria3.Codigo.DTO;
using Cafeteria3.Codigo.BLL;

namespace Cafeteria3
{
    public partial class frmProduto : Form
    {        
        ProdutoDTO produtoDTO = new ProdutoDTO();
        ProdutoBLL produtoBLL = new ProdutoBLL();        

        public frmProduto()
        {            
            InitializeComponent();
            dtgProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        
        private void btmSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            produtoDTO.Nome = txtPesquisa.Text;
            dtgProduto.DataSource =  produtoBLL.SelecionarNome(produtoDTO);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmCadastroProduto cadastro = new frmCadastroProduto(this);
            cadastro.ShowDialog();
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            dtgProduto.DataSource = produtoBLL.SelecionarTudo();
        }        

        private void dtgProduto_CellClick(object sender, DataGridViewCellEventArgs e){PegarValor();}

        private void dtgProduto_CellContentClick(object sender, DataGridViewCellEventArgs e){PegarValor();}        
        
        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmAlterarProduto alterar = new frmAlterarProduto(this);
            alterar.ShowDialog();
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13) 
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                btnPesquisar_Click(sender, e);
            }
        }

        private void dtgProduto_CellEnter(object sender, DataGridViewCellEventArgs e)
        {                       
                produtoDTO.Nome = dtgProduto.CurrentRow.Cells[0].Value.ToString();
                produtoDTO.Id = produtoBLL.SelecionarId(produtoDTO);           
        }

        private void dtgProduto_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e){PegarValor();}

        private void dtgProduto_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e){}

        private void dtgProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e){PegarValor();}

        public void PegarValor() 
        {
            try
            {
                produtoDTO.Nome = dtgProduto.CurrentRow.Cells[0].Value.ToString();
                produtoDTO.Id = produtoBLL.SelecionarId(produtoDTO);
                if (produtoDTO.Id < 1)
                    dtgProduto.CurrentCell = dtgProduto.Rows[0].Cells[0];
            }
            catch
            {
                dtgProduto.CurrentCell = dtgProduto.Rows[0].Cells[0];
            }
        }
    }
}
