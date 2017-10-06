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
    public partial class frmFuncionario : Form
    {
        FuncionarioBLL funcionarioBLL = new FuncionarioBLL();
        FuncionarioDTO funcionarioDTO = new FuncionarioDTO();

        public frmFuncionario()
        {
            InitializeComponent();
            dtgFuncionario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btmSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario func = new frmCadastroFuncionario(this);
            func.ShowDialog();
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            dtgFuncionario.DataSource =  funcionarioBLL.SelecionarTudo();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            funcionarioDTO.Nome = txtPesquisa.Text;
            dtgFuncionario.DataSource = funcionarioBLL.SelecionarNome(funcionarioDTO);
        }

        private void dtgFuncionario_CellClick(object sender, DataGridViewCellEventArgs e){PegarValor();}

        private void dtgFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e){PegarValor();}        

        private void dtgFuncionario_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            funcionarioDTO.Nome = dtgFuncionario.CurrentRow.Cells[0].Value.ToString();
            funcionarioDTO.Id = funcionarioBLL.SelecionarId(funcionarioDTO);
        }

        private void dtgFuncionario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e){PegarValor();}

        private void dtgFuncionario_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e){PegarValor();}

        private void dtgFuncionario_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e){PegarValor();}

        public void PegarValor()
        {
            try
            {
                funcionarioDTO.Nome = dtgFuncionario.CurrentRow.Cells[0].Value.ToString();
                funcionarioDTO.Id = funcionarioBLL.SelecionarId(funcionarioDTO);                
                if (funcionarioDTO.Id < 1)
                {
                    dtgFuncionario.CurrentCell = dtgFuncionario.Rows[0].Cells[0];
                }
            }
            catch
            {
                dtgFuncionario.CurrentCell = dtgFuncionario.Rows[0].Cells[0];
            }
        }        

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
