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
using WPFBolado.DTO;
using WPFBolado.BLL;
using WPFBolado.Codigos;

namespace WPFBolado.Windows
{    
    public partial class frmPagamento : Window
    {
        frmPedidos frmPed = new frmPedidos();
        List<PagamentoDTO> dto = new List<PagamentoDTO>();        
        Money m = new Money();
        Money m1 = new Money();
        Money m2 = new Money();
        PedidoBLL peBLL = new PedidoBLL();
        ProdPedidoBLL prodPedBLL = new ProdPedidoBLL();
        PagamentoBLL paBLL = new PagamentoBLL();
        PedidoDTO peDTO = new PedidoDTO();
        ProdPedido proPedDTO = new ProdPedido();
        PagamentoDTO paDTO = new PagamentoDTO();
        ProdutoDTO prodDTO = new ProdutoDTO();
        ProdutoBLL prodBLL = new ProdutoBLL();
        CaixaBLL caixaBLL = new CaixaBLL();
        CaixaDTO caixaDTO = new CaixaDTO();
        Movimentacao_PagamentoBLL mpBLL = new Movimentacao_PagamentoBLL();
        MovimentacaoDTO mDTO = new MovimentacaoDTO();
        MovimentacaoBLL mBLL = new MovimentacaoBLL();
        decimal valor, total = 0,falta,valorDinheiro = 0,troco = 0;
        string nome; 

        public frmPagamento(frmPedidos p)
        {
            InitializeComponent();
            frmPed = p;            
                                    
            txtbTotal.Text = p.txtTotal.Text;
            falta = Convert.ToDecimal(txtbTotal.Text);
            txtbFalta.Text = falta.ToString();

            p.ColocarArray();         
        }

        public void addMon(System.Windows.Controls.TextBox txt, string nome)
        {
            if (!string.IsNullOrWhiteSpace(txt.Text))
            {
                valor = Convert.ToDecimal(txt.Text);

                int v = 0;

                if ((falta - valor) >= 0)
                {
                    foreach (PagamentoDTO a in dto)
                    {
                        if (a.Nome == nome)
                        {
                            v++;
                            a.Valor += valor;
                            dtgPag.DataContext = null;
                            dtgPag.DataContext = dto;
                            total += valor;
                            txtbRecebido.Text = total.ToString();
                            falta -= valor;
                            txtbFalta.Text = falta.ToString();

                            txt.Clear();

                            if (falta == 0)
                                grbPag.IsEnabled = false;

                            break;
                        }
                    }

                    if (v == 0)
                    {
                        dto.Add(new PagamentoDTO { Nome = nome, Valor = valor });

                        dtgPag.DataContext = null;
                        dtgPag.DataContext = dto;

                        total += valor;
                        txtbRecebido.Text = total.ToString();
                        falta -= valor;
                        txtbFalta.Text = falta.ToString();

                        txt.Clear();

                        if (falta == 0)                        
                            grbPag.IsEnabled = false;                        
                    }
                }
                else
                {
                    MessageBox.Show("Ultrapassou o valor!");
                }
            }
            else { MessageBox.Show("Coloque um valor"); }
        }


        private void btnAddDin_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDinheiro.Text))
            {
                valor = Convert.ToDecimal(txtDinheiro.Text);

                int v = 0;
                     
                if ((falta - valor) >= 0)
                {

                    foreach (PagamentoDTO a in dto)
                    {

                        if (a.Nome == "Dinheiro")
                        {
                            v++;
                            a.Valor += valor;

                            dtgPag.DataContext = null;
                            dtgPag.DataContext = dto;
                            total += valor;
                            txtbRecebido.Text = total.ToString();
                            falta -= valor;
                            txtbFalta.Text = falta.ToString();

                            valorDinheiro += valor;
                            txtbDinheiro.Text = valorDinheiro.ToString();
                            
                            txtDinheiro.Clear();

                            if (falta == 0)
                            {
                                grbPag.IsEnabled = false;                                
                            }

                            break;
                        }
                    }

                    if (v == 0)
                    {
                        dto.Add(new PagamentoDTO { Nome = "Dinheiro", Valor = valor });

                        dtgPag.DataContext = null;
                        dtgPag.DataContext = dto;

                        total += valor;
                        txtbRecebido.Text = total.ToString();
                        falta -= valor;
                        txtbFalta.Text = falta.ToString();

                        valorDinheiro += valor;
                        txtbDinheiro.Text = valorDinheiro.ToString();

                        txtDinheiro.Clear();

                        if (falta == 0)
                        {
                            grbPag.IsEnabled = false;                            
                        }
                    }
                }
                else
                {

                    foreach (PagamentoDTO a in dto)
                    {
                        if (a.Nome == "Dinheiro")
                        {
                            v++;
                            a.Valor += valor;
                            dtgPag.DataContext = null;
                            dtgPag.DataContext = dto;

                            total += valor;
                            txtbRecebido.Text = total.ToString();

                            falta = 0;
                            txtbFalta.Text = falta.ToString();

                            valorDinheiro += valor;
                            txtbDinheiro.Text = valorDinheiro.ToString();

                            troco = total - Convert.ToDecimal(txtbTotal.Text);
                            txtbTroco.Text = troco.ToString();

                            txtDinheiro.Clear();

                            if (falta == 0)
                                grbPag.IsEnabled = false;

                            break;
                        }
                    }

                    if (v == 0)
                    {
                        dto.Add(new PagamentoDTO { Nome = "Dinheiro", Valor = valor });

                        dtgPag.DataContext = null;
                        dtgPag.DataContext = dto;

                        total += valor;
                        txtbRecebido.Text = total.ToString();

                        falta = 0;
                        txtbFalta.Text = falta.ToString();

                        valorDinheiro += valor;
                        txtbDinheiro.Text = valorDinheiro.ToString();

                        troco = total - Convert.ToDecimal(txtbTotal.Text);
                        txtbTroco.Text = troco.ToString();

                        grbPag.IsEnabled = false;
                    }
                }
            }
            else { MessageBox.Show("Coloque um valor");}

            txtDinheiro.Clear();
            m.limpaStr();
        }

        
        private void btnAddDeb_Click(object sender, RoutedEventArgs e)
        {
            addMon(txtDebito,"Débito");
            m1.limpaStr();
        }

        private void btnConcluir_Click(object sender, RoutedEventArgs e)
        {
            int j;
            if (falta == 0)
            {
                peDTO.Id_caixa = caixaBLL.SelecionarId();
                peDTO.Id_func = 1;
                peBLL.Inserir(peDTO);

                mDTO.Tipo = "Pedido";
                mDTO.Valor = Convert.ToDecimal(txtbTotal.Text);
                mDTO.Descricao = "Pedido " + peBLL.selecionarId().ToString();
                caixaDTO.Id = caixaBLL.SelecionarId();
                mBLL.Inserir(mDTO, caixaDTO);

                j = frmPed.ColocarArray();

                for (int i = 0; i < j; i++)
                {
                    prodDTO.Nome = frmPed.testeNome[i];
                    prodDTO.Id = prodBLL.SelecionarId(prodDTO);
                    proPedDTO.Preco = frmPed.testePreco[i];
                    proPedDTO.Qtd = frmPed.testeQuantidade[i];
                    peDTO.Id = peBLL.selecionarId();
                    prodPedBLL.Inserir(proPedDTO, peDTO, prodDTO);
                }

                foreach (PagamentoDTO a in dto)
                {
                    paDTO.Id = escolherPagamento(a.Nome);
                    mDTO.Id = mBLL.selecionarId();
                    peDTO.Id = peBLL.selecionarId();
                    paDTO.Valor = a.Valor;
                    paBLL.inserir(peDTO, paDTO);
                    mpBLL.inserir(mDTO, paDTO);
                }

                MessageBox.Show("Pedido realizado com sucesso!");
                this.Visibility = Visibility.Hidden;
                frmPed.Close();
                this.Close();
            }
            else {MessageBox.Show("Falta > 0");}
        }

        private int escolherPagamento(string nome)
        {
            int ret = 0;

            if (nome == "Dinheiro")
                ret = 1;
            else if (nome == "Débito")
                ret = 2;
            else if (nome == "Crédito")
                ret = 3;

            return ret;
        }
        
        private void txtDinheiro_PreviewKeyDown(object sender, KeyEventArgs e)
        {            
            m.txtPreco_PreviewKeyDown(sender,e,txtDinheiro);
        }

        private void txtDebito_PreviewKeyDown(object sender, KeyEventArgs e)
        {            
            m1.txtPreco_PreviewKeyDown(sender, e, txtDebito);
        }

        private void txtCredito_PreviewKeyDown(object sender, KeyEventArgs e)
        {            
            m2.txtPreco_PreviewKeyDown(sender, e, txtCredito);
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            object item = dtgPag.SelectedItem;

            try
            {                
                nome = (dtgPag.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;

                foreach (PagamentoDTO a in dto)
                {
                    if (a.Nome == nome)
                    {
                        dto.Remove(a);
                        dtgPag.DataContext = null;
                        dtgPag.DataContext = dto;

                        if (nome == "Dinheiro")
                        {                            

                            troco = 0;
                            txtbTroco.Text = troco.ToString();                            

                            valorDinheiro = 0;
                            txtbDinheiro.Text = valorDinheiro.ToString();                            

                            total -= a.Valor;
                            txtbRecebido.Text = total.ToString();

                            if ((Convert.ToDecimal(txtbTotal.Text) - total) <= 0)
                            {
                                falta = 0;
                                txtbFalta.Text = falta.ToString();
                            }
                            else
                            {
                                falta = Convert.ToDecimal(txtbTotal.Text) - total;
                                txtbFalta.Text = falta.ToString();
                            }

                        }
                        else
                        {
                            total -= a.Valor;
                            txtbRecebido.Text = total.ToString();

                            if ((Convert.ToDecimal(txtbTotal.Text) - total) <= 0)
                            {
                                falta = 0;
                                txtbFalta.Text = falta.ToString();
                            }
                            else
                            {
                                falta = Convert.ToDecimal(txtbTotal.Text) - total;
                                txtbFalta.Text = falta.ToString();
                            }
                        }
                        break;
                    }                
                }
                if (falta > 0)
                    grbPag.IsEnabled = true;
                else grbPag.IsEnabled = false;
            }

            catch (Exception ex){MessageBox.Show("Selecionar pagamento!");}        
        }

        private void btnAddCre_Click(object sender, RoutedEventArgs e)
        {
            addMon(txtCredito, "Crédito");
            m2.limpaStr();
        }

        public int valorFaltando()
        {
            int ret = 0;

            if (falta == 0)
            {
                grbPag.IsEnabled = false;
                ret++;
            }

            else
            {
                grbPag.IsEnabled = true;                
            }

            return ret;
        }
    }
}
