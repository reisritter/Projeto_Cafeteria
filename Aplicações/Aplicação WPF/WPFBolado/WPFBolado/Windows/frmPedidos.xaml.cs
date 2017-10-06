using System;
using System.Collections.Generic;
using System.Data;
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
using WPFBolado.Windows.Alterar;

namespace WPFBolado.Windows
{
    
    public partial class frmPedidos : Window
    {
               
        ProdutoBLL prodBLL = new ProdutoBLL();
        ProdutoDTO prodDTO = new ProdutoDTO();

        List<ProdPedido> dto = new List<ProdPedido>();

        public string[] testeNome = new string[20];
        public decimal[] testePreco = new decimal[20];
        public int[] testeQuantidade = new int[20];
        
        string nome;
        decimal preco;
        decimal total;
        int qtde = 1;
        string n;

        public frmPedidos()
        {
            InitializeComponent();
            prodBLL.CarregarProdPed(cmbProd);
            txtQtd.Text = qtde.ToString();                        
        }

        public void teste(int qtde, string preco,string nome)
        {
            
            foreach (ProdPedido a in dto)
            {
                if (nome == a.Nome)
                {                    
                    a.Qtd = qtde;                       
                    a.Preco = Convert.ToDecimal(preco);                    
                    a.Subtotal = Convert.ToDecimal(preco) * qtde;                             
                    
                    dataGrid.DataContext = null;
                    dataGrid.DataContext = dto;
                    qtde = 1;
                    txtQtd.Text = qtde.ToString();
                    cmbProd.SelectedIndex = -1;
                    break;
                }
            }

            total = 0;

            foreach (ProdPedido a in dto)
            {
                total += a.Subtotal;
                txtTotal.Text = total.ToString();
            }
        }

        private void btnAdicionar_Click(object sender, RoutedEventArgs e)
        {            

            int v = validacao();
            int v2 = 0;

            if (v == 0)
            {
                prodDTO.Id = Convert.ToInt32(cmbProd.SelectedValue.ToString());
                nome = prodBLL.SelecionarPed(prodDTO);
                preco = prodBLL.SelecionarPedPreco(prodDTO);                    

                foreach (ProdPedido a in dto)
                {
                    if (nome == a.Nome)
                    {                        
                        v2 += 1;
                        a.Qtd += Convert.ToInt32(txtQtd.Text);
                        for (int i = 0; i < Convert.ToInt32(txtQtd.Text); i++)
                        {
                            a.Subtotal += a.Preco;
                            total += a.Preco;
                        }
                        txtTotal.Text = total.ToString();
                        dataGrid.DataContext = null;
                        dataGrid.DataContext = dto;
                        qtde = 1;
                        txtQtd.Text = qtde.ToString();
                        cmbProd.SelectedIndex = -1;
                        break;
                    }
                }


                if (v2 == 0)
                {
                    dto.Add(new ProdPedido { Nome = nome, Preco = preco, Qtd = Convert.ToInt32(txtQtd.Text), Subtotal = Convert.ToDecimal(txtQtd.Text) * preco });                   

                    dataGrid.DataContext = null;
                    dataGrid.DataContext = dto;

                    total += preco * Convert.ToDecimal(txtQtd.Text);
                    txtTotal.Text = total.ToString();
                    qtde = 1;

                    cmbProd.SelectedIndex = -1;
                    txtQtd.Text = qtde.ToString();
                }
            }
            else
            {
                MessageBox.Show("Deu ruim!");
            }
        }

        public int validacao()
        {
            int ret = 0;

            if (string.IsNullOrWhiteSpace(txtQtd.Text))
            {
                ret += 1;
            }
            if (cmbProd.SelectedIndex < 0)
            {
                ret += 1;
            }

            return ret;
        }

        private void btnSair_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            object item = dataGrid.SelectedItem;

            try
            {
                n = (dataGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                foreach (ProdPedido a in dto)
                {
                    if (n == a.Nome)
                    {
                        dto.Remove(a);
                        dataGrid.DataContext = null;
                        dataGrid.DataContext = dto;
                        total -= a.Subtotal;
                        txtTotal.Text = total.ToString();
                        break;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Selecione um produto!"); }           
            
        }

        private void dataGrid_GotFocus(object sender, RoutedEventArgs e)
        {
            
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
               

        private void button_Click(object sender, RoutedEventArgs e)
        {
            qtde++;
            txtQtd.Text = qtde.ToString();
        }

        private void btnDadd_Click(object sender, RoutedEventArgs e)
        {
            if (qtde > 1)
            {
                qtde--;
                txtQtd.Text = qtde.ToString();
            }
        }

        private void btnUpd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                frmAlterarProdPed ped = new frmAlterarProdPed(this);
                ped.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Selecione um produto!");
            }
        }

        private void dataGrid_LostFocus(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnPagamento_Click(object sender, RoutedEventArgs e)
        {
            if (total > 0)
            {
                frmPagamento frmPag = new frmPagamento(this);
                frmPag.ShowDialog();
            }
            else { MessageBox.Show("Pedido sem produtos!");}
        }

        public int ColocarArray()
        {
            int i = 0;
            foreach (ProdPedido a in dto)
            {
                testeNome[i] = a.Nome;
                testePreco[i] = a.Preco;
                testeQuantidade[i] = a.Qtd;
                i++;
            }
            return i;       
        }    
    }
}
