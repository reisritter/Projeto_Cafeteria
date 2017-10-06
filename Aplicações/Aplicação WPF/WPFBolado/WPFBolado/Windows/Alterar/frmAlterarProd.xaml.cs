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

namespace WPFBolado.Windows
{
   
    public partial class frmAlterarProd : Window
    {
        ProdutoBLL produtoBLL = new ProdutoBLL();
        ProdutoDTO produtoDTO = new ProdutoDTO();
        CategoriaDTO categoriaDTO = new CategoriaDTO();
        CategoriaBLL categoriaBLL = new CategoriaBLL();
        frmProduto produto = new frmProduto();
        Money m = new Money();
        
        string tipo = "";
        string status = "";
        string str = "";

        public frmAlterarProd(frmProduto p)
        {
            InitializeComponent();
            produto = p;
                         
            categoriaBLL.Carregar(cmbCategoria);
            object item = produto.dtgProduto.SelectedItem;            
            txtNome.Text = (produto.dtgProduto.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
            txtPreco.Text = (produto.dtgProduto.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
            categoriaDTO.Nome = (produto.dtgProduto.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;
            cmbCategoria.SelectedValue = categoriaBLL.SelecionarId(categoriaDTO);
            combo();
            produtoDTO.Nome = (produto.dtgProduto.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
            produtoDTO.Id = produtoBLL.SelecionarId(produtoDTO);
            txtFoto.Text = produtoBLL.SelecionarFoto(produtoDTO);            

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

        private void combo()
        {
            object item = produto.dtgProduto.SelectedItem;
            string ti = (produto.dtgProduto.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
            string sta = (produto.dtgProduto.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;

            if (ti == "Produzido")
                rdbProduzido.IsChecked = true;
            else if (ti == "Pronto")
                rdbPronto.IsChecked = true;
            else if (ti == "Matéria" || ti == "Materia") rdbMateria.IsChecked = true;

            if (sta == "Disponível")
                rdbDisponivel.IsChecked = true;
            else rdbNaoDisponivel.IsChecked = true;
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

            if (cmbCategoria.SelectedIndex < 0) { ret += 1; lblCategoria.Visibility = Visibility.Visible; }
            else { lblCategoria.Visibility = Visibility.Hidden; }

            return ret;
        }

        private void btnAlterar_Click(object sender, RoutedEventArgs e)
        {
            
            if (ValidarTexto() == 0)
            {
                object item = produto.dtgProduto.SelectedItem;
                produtoDTO.Nome = (produto.dtgProduto.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                produtoDTO.Id = produtoBLL.SelecionarId(produtoDTO);
                produtoDTO.Foto = txtFoto.Text;
                produtoDTO.Nome = txtNome.Text;
                produtoDTO.Preco = Convert.ToDecimal(txtPreco.Text.Replace(".",","));
                produtoDTO.Tipo = tipo;
                produtoDTO.Status = status;                
                produtoBLL.Atualizar(produtoDTO, cmbCategoria);
                System.Windows.MessageBox.Show("Alteração feita com sucesso!");
                this.Close();
                produto.dtgProduto.DataContext = produtoBLL.SelecionarTudo();
            }
            else System.Windows.MessageBox.Show("Erro na alteração!");
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            
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

        private void rdbDisponivel_Checked(object sender, RoutedEventArgs e)
        {
            status = "Disponível";
        }

        private void rdbNaoDisponivel_Checked(object sender, RoutedEventArgs e)
        {
            status = "Indisponível";
        }

        int iNome = 0;
        int iPreco = 0;


        private void txtNome_GotFocus(object sender, RoutedEventArgs e)
        {
            if (iNome == 0)
            {
                iNome++;
                txtNome.Clear();
            }
        }

        private void txtPreco_GotFocus(object sender, RoutedEventArgs e)
        {
            if (iPreco == 0)
            {
                iPreco++;
                txtPreco.Clear();
            }
        }       

        private void txtPreco_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            m.txtPreco_PreviewKeyDown(sender, e, txtPreco);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnFoto_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog o = new Microsoft.Win32.OpenFileDialog();
            o.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            //o.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (o.ShowDialog() == true)
            {
                txtFoto.Text = o.FileName;
            }
        }
    }
}
