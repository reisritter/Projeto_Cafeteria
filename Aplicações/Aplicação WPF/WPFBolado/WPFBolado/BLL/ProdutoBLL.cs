using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using WPFBolado.DTO;
using System.Windows.Controls;

namespace WPFBolado.BLL
{
    class ProdutoBLL
    {
        Acesso bd = new Acesso();
        DataTable dt;
        SqlDataAdapter da;

        public string SelecionarFoto(ProdutoDTO dto)
        {
            string a = "";
            try
            {
                bd.Conectar();
                bd.comm.CommandText = "Select id_produto,imagem from Produto where id_produto = @id";
                bd.comm.Parameters.AddWithValue("@id", dto.Id);
                dt = new DataTable();
                da = new SqlDataAdapter(bd.comm);
                da.Fill(dt);
                a = dt.Rows[0]["imagem"].ToString();

            }

            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            finally
            {
                bd.Fechar();
            }

            return a;
        }

        public decimal SelecionarPedPreco(ProdutoDTO dto)
        {
            decimal a;

            try
            {
                bd.Conectar();
                bd.comm.CommandText = "Select descricao,preco from Produto where id_produto = @id";
                bd.comm.Parameters.AddWithValue("@id", dto.Id);
                dt = new DataTable();
                da = new SqlDataAdapter(bd.comm);
                da.Fill(dt);
                a = Convert.ToDecimal(dt.Rows[0]["preco"].ToString());

            }

            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            finally
            {
                bd.Fechar();
            }

            return a;
        }

        public string SelecionarPed(ProdutoDTO dto)
        {
            string a;

            try
            {
                bd.Conectar();
                bd.comm.CommandText = "Select descricao,preco from Produto where id_produto = @id";
                bd.comm.Parameters.AddWithValue("@id",dto.Id);
                dt = new DataTable();
                da = new SqlDataAdapter(bd.comm);
                da.Fill(dt);
                a = dt.Rows[0]["descricao"].ToString();
                
            }

            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            finally
            {
                bd.Fechar();
            }

            return a;
        }

        public void Inserir(ProdutoDTO dto, ComboBox cb)
        {
            try
            {
                bd.Conectar();
                bd.comm.CommandText = "insert into produto values(@preco,@tipo,'Disponível',@nome,@foto,@id_categoria)";
                bd.comm.Parameters.AddWithValue("@nome", dto.Nome);
                bd.comm.Parameters.AddWithValue("@preco", dto.Preco);
                bd.comm.Parameters.AddWithValue("@tipo", dto.Tipo);
                bd.comm.Parameters.AddWithValue("@foto", dto.Foto);
                bd.comm.Parameters.AddWithValue("@id_categoria", cb.SelectedValue.ToString());
                bd.comm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Problema no cadastro de produto : " + ex.Message);
            }
            finally
            {
                bd.Fechar();
            }
        }


        public DataTable SelecionarTudoP()
        {
            try
            {
                bd.Conectar();
                bd.comm.CommandText = "selecionarProd";
                bd.comm.CommandType = CommandType.StoredProcedure;
                dt = new DataTable();
                da = new SqlDataAdapter(bd.comm);
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro na seleção de produto : " + ex.Message);
            }
            finally
            {
                bd.Fechar();
            }

            return dt;
        }


        public DataTable SelecionarTudo()
        {
            try
            {                
                bd.Conectar();
                bd.comm.CommandText = "Select p.descricao as Nome,p.preco as Preço,p.tipo as Tipo,p.status_ as Disponibilidade,c.descricao as Categoria from Produto p inner join Categoria c on p.id_categoria = c.id_categoria order by nome";
                dt = new DataTable();
                da = new SqlDataAdapter(bd.comm);
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                    throw new Exception("Erro na seleção de produto : " + ex.Message);
            }
            finally
            {
                bd.Fechar();
            }

            return dt;
        }

        public DataTable SelecionarNome(ProdutoDTO dto)
        {
            try
            {
                string nome = "%" + dto.Nome + "%";
                bd.Conectar();
                bd.comm.CommandText = "Select p.descricao as Nome,p.preco as Preço,p.tipo as Tipo,p.status_ as Disponibilidade,c.descricao as Categoria from Produto p inner join Categoria c on p.id_categoria = c.id_categoria where p.descricao like @nome order by nome";
                bd.comm.Parameters.AddWithValue("@nome", nome);
                dt = new DataTable();
                da = new SqlDataAdapter(bd.comm);
                da.Fill(dt);

            }
            catch (SqlException ex)
            {
                throw new Exception("Erro na seleção do Id : " + ex.Message);
            }
            finally
            {
                bd.Fechar();
            }

            return dt;
        }

        public int SelecionarId(ProdutoDTO dto)
        {
            int ret = 0;

            try
            {
                bd.Conectar();
                bd.comm.CommandText = "Select id_produto from Produto where descricao = @descricao";
                bd.comm.Parameters.AddWithValue("@descricao", dto.Nome);
                ret = Convert.ToInt32(bd.comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro na selecão por id no produto : " + ex.Message);
            }
            finally
            {
                bd.Fechar();
            }

            return ret;
        }

        public void Atualizar(ProdutoDTO dto, ComboBox cb)
        {
            try
            {
                bd.Conectar();
                bd.comm.CommandText = "Update Produto set descricao=@nome,preco=@preco,tipo=@tipo,status_=@status,id_categoria=@id_categoria , imagem = @foto where id_produto = @id";
                bd.comm.Parameters.AddWithValue("@id", dto.Id);
                bd.comm.Parameters.AddWithValue("@nome", dto.Nome);
                bd.comm.Parameters.AddWithValue("@preco", dto.Preco);
                bd.comm.Parameters.AddWithValue("@tipo", dto.Tipo);
                bd.comm.Parameters.AddWithValue("@status", dto.Status);
                bd.comm.Parameters.AddWithValue("@foto",dto.Foto);
                bd.comm.Parameters.AddWithValue("@id_categoria", cb.SelectedValue.ToString());
                bd.comm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro a atualização dos dados do produto : " + ex.Message);
            }
            finally
            {
                bd.Fechar();
            }
        }

        public int Deletar(ProdutoDTO dto)
        {
            int ret = 0;
            try
            {
                bd.Conectar();
                bd.comm.CommandText = "Delete from produto where id_produto = @id";
                bd.comm.Parameters.AddWithValue("id", dto.Id);
                ret = (int)bd.comm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Deu ruim na exclusão do produto : " + ex.Message);
            }
            finally
            {
                bd.Fechar();
            }
            return ret;
        }


        public void CarregarProdPed(ComboBox cb)
        {
            try
            {
                bd.Conectar();
                bd.comm.CommandText = "Select * from Produto where (tipo = 'Pronto' or tipo = 'Produzido') and status_ = 'Disponível' order by descricao";
                dt = new DataTable();
                da = new SqlDataAdapter(bd.comm);
                da.Fill(dt);
                cb.DataContext = dt;
                cb.SelectedValuePath = "id_produto";
                cb.DisplayMemberPath = "descricao";

            }
            catch (SqlException ex)
            {
                throw new Exception("Erro no carregamento de dados de categoria : " + ex.Message);
            }
            finally
            {
                bd.Fechar();
                cb.SelectedIndex = -1;
            }
        }


        public void Carregar(ComboBox cb)
        {
            try
            {
                bd.Conectar();
                bd.comm.CommandText = "Select * from Produto";
                dt = new DataTable();
                da = new SqlDataAdapter(bd.comm);
                da.Fill(dt);
                cb.DataContext = dt;
                cb.SelectedValuePath = "id_produto";
                cb.DisplayMemberPath = "descricao";

            }
            catch (SqlException ex)
            {
                throw new Exception("Erro no carregamento de dados de categoria : " + ex.Message);
            }
            finally
            {
                bd.Fechar();
                cb.SelectedIndex = -1;
            }
        }

    }
}
