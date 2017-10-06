using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cafeteria3.Codigo.DTO;
using Cafeteria3.Codigo.DAL;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Cafeteria3.Codigo.BLL
{
    class ProdutoBLL
    {
        AcessoBancoDados bd = new AcessoBancoDados();
        DataTable dt;
        SqlDataAdapter da;
        
        public void Inserir(ProdutoDTO dto,ComboBox cb)
        {
            try
            {
                bd.Conectar();
                bd.comm.CommandText = "insert into produto values(@nome,@preco,@tipo,'S',@id_categoria)";
                bd.comm.Parameters.AddWithValue("@nome", dto.Nome);
                bd.comm.Parameters.AddWithValue("@preco", dto.Preco);
                bd.comm.Parameters.AddWithValue("@tipo",dto.Tipo);
                bd.comm.Parameters.AddWithValue("@id_categoria",cb.SelectedValue.ToString());
                bd.comm.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                throw new Exception("Problema no cadastro de produto : "+ex.Message);
            }
            finally
            {
                bd.Fechar();
            }
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
            catch(SqlException ex)
            {
                throw new Exception("Erro na seleção de produto : "+ex.Message);
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
                bd.comm.Parameters.AddWithValue("@nome",nome);
                dt = new DataTable();
                da = new SqlDataAdapter(bd.comm);
                da.Fill(dt);

            }
            catch(SqlException ex)
            {
                throw new Exception("Erro na seleção do Id : "+ex.Message);
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
                bd.comm.Parameters.AddWithValue("@descricao",dto.Nome);
                ret = Convert.ToInt32(bd.comm.ExecuteScalar());
            }
            catch(SqlException ex)
            {
                throw new Exception("Erro na selecão por id no produto : "+ex.Message);
            }
            finally
            {
                bd.Fechar();
            }

            return ret;
        }

        public void Atualizar(ProdutoDTO dto,ComboBox cb)
        {
            try 
            {
                bd.Conectar();
                bd.comm.CommandText = "Update Produto set descricao=@nome,preco=@preco,tipo=@tipo,status_=@status,id_categoria=@id_categoria where id_produto = @id";
                bd.comm.Parameters.AddWithValue("@id",dto.Id);
                bd.comm.Parameters.AddWithValue("@nome", dto.Nome);
                bd.comm.Parameters.AddWithValue("@preco", dto.Preco);
                bd.comm.Parameters.AddWithValue("@tipo",dto.Tipo);
                bd.comm.Parameters.AddWithValue("@status",dto.Status);
                bd.comm.Parameters.AddWithValue("@id_categoria",cb.SelectedValue.ToString());                
                bd.comm.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                throw new Exception("Erro a atualização dos dados do produto : "+ex.Message);
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
                bd.comm.Parameters.AddWithValue("id",dto.Id);
                ret = (int)bd.comm.ExecuteNonQuery();                
            }
            catch (SqlException ex)
            {
                throw new Exception("Deu ruim na exclusão do produto : "+ex.Message);
            }
            finally
            {
                bd.Fechar();                
            }
            return ret;
        }      
    }
}
