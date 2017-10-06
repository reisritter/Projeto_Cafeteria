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
using System.Windows.Forms;
using WPFBolado.BLL;
using WPFBolado.DTO;
using WPFBolado.Codigos;
using Microsoft.Win32;

namespace WPFBolado.Windows
{
    
    public partial class Produto : Window
    {
        ProdutoBLL produtoBll = new ProdutoBLL();
        ProdutoDTO produtoDTO = new ProdutoDTO();
        CategoriaDTO categoriaDTO = new CategoriaDTO();
        CategoriaBLL categoriaBLL = new CategoriaBLL();
        frmProduto produto = new frmProduto();
        Money m = new Money();
        string status = "";
        string tipo = "";
        string str = "";


        public Produto(frmProduto p)
        {
            InitializeComponent();
            produto = p;
           
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
             if (ValidarTexto() == 0)
            {
                produtoDTO.Nome = txtNome.Text;
                produtoDTO.Preco = Convert.ToDecimal(txtPreco.Text);
                produtoDTO.Tipo = tipo;
                produtoDTO.Foto = txtFoto.Text;
                produtoBll.Inserir(produtoDTO,cmbCategoria);
                System.Windows.Forms.MessageBox.Show("Cadastro realizado com sucesso!");                
                DialogResult resultado = System.Windows.Forms.MessageBox.Show("Deseja fazer um novo cadastro?","",MessageBoxButtons.YesNo);
                if (resultado.ToString().ToUpper() == "YES")
                {
                    Limpar();
                    txtNome.Focus();
                }
                else { this.Close(); produto.dtgProduto.DataContext = produtoBll.SelecionarTudo(); }
            }
            else System.Windows.Forms.MessageBox.Show("Erro na gravação!");   
        }

        public void Limpar()
        {
            txtNome.Clear();
            txtPreco.Clear();
            str = "";
            cmbCategoria.SelectedIndex = -1;
            rdbMateria.IsChecked = false;
            rdbProduzido.IsChecked = false;
            rdbPronto.IsChecked = false;
        }


        public int ValidarTexto()
        {
            int ret = 0;

            if (string.IsNullOrWhiteSpace(txtNome.Text.Trim())) { ret += 1; lblNome.Visibility = Visibility.Visible; }
            else { lblNome.Visibility = Visibility.Hidden; }
            
            if (string.IsNullOrWhiteSpace(txtPreco.Text.Trim())) { ret += 1; lblPreco.Visibility = Visibility.Visible; }
            else { lblPreco.Visibility = Visibility.Hidden; }

            if (rdbMateria.IsChecked == false && rdbProduzido.IsChecked == false && rdbPronto.IsChecked == false) { ret += 1; lblTipo.Visibility = Visibility.Visible; }
            else { lblTipo.Visibility = Visibility.Hidden; }

            if (cmbCategoria.SelectedIndex < 0) { ret += 1; lblCategoria.Visibility = Visibility.Visible;}
            else { lblCategoria.Visibility = Visibility.Hidden; }

            return ret;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void CadastroProduto_Loaded(object sender, RoutedEventArgs e)
        {
            categoriaBLL.Carregar(cmbCategoria);
        }        

        private void txtPreco_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            

        }        

        private void txtPreco_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            m.txtPreco_PreviewKeyDown(sender,e,txtPreco);    
        }

        private void rdbPronto_Checked(object sender, RoutedEventArgs e)
        {
            tipo = "Pronto";
        }

        private void rdbProduzido_Checked(object sender, RoutedEventArgs e)
        {
            tipo = "Produzido";
        }

        private void rdbMateria_Checked(object sender, RoutedEventArgs e)
        {
            tipo = "Matéria";
        }

        private void CadastroProduto_Closed(object sender, EventArgs e)
        {
            
        }

        private void btnFoto_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog o = new Microsoft.Win32.OpenFileDialog();
            o.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            //o.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (o.ShowDialog() == true)
            {
                txtFoto.Text =  o.FileName;
            }
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
