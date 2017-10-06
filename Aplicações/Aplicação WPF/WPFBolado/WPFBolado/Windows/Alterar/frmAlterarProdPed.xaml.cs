using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPFBolado.DTO;
using WPFBolado.Codigos;

namespace WPFBolado.Windows.Alterar
{       
    public partial class frmAlterarProdPed : Window
    {
        Money m = new Money();
        frmPedidos frmPed = new frmPedidos();        
        int qtde,iPreco = 0;
        string str = "",nome;

        public frmAlterarProdPed(frmPedidos p)
        {
            InitializeComponent();
            frmPed = p;

            object item = p.dataGrid.SelectedItem;

            nome = (p.dataGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
            txtPreco.Text = (p.dataGrid.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
            txtPreco.Text = txtPreco.Text.Replace(".", ",");
            txtQtd.Text = (p.dataGrid.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
            qtde = Convert.ToInt32(txtQtd.Text);
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
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

        private void txtPreco_GotFocus(object sender, RoutedEventArgs e)
        {
            if (iPreco == 0)
            {
                iPreco++;
                txtPreco.Clear();
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                frmPed.teste(qtde, txtPreco.Text, nome);
                this.Close();
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Coloque um valor!");
            }
        }

        private void txtPreco_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {            
            m.txtPreco_PreviewKeyDown(sender,e,txtPreco);
        }
    }
}
