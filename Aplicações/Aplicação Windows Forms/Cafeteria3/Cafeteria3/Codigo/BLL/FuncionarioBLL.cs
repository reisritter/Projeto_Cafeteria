using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Cafeteria3.Codigo.DTO;
using Cafeteria3.Codigo.DAL;
using System.Windows.Forms;

namespace Cafeteria3.Codigo.BLL
{
    class FuncionarioBLL
    {
        AcessoBancoDados bd = new AcessoBancoDados();
        DataTable dt;
        SqlDataAdapter da;

        public void Inserir(FuncionarioDTO dto,ComboBox cmb,LoginDTO loginDTO) 
        {
            try 
            {
                bd.Conectar();
                bd.comm.CommandText = "insert into Funcionario values(@nome,@cpf,@tel,@email,@endereco,@cidade,@bairro,@uf,@complemento,@numero,@cep,@id_cargo,@id_login,@data)";
                bd.comm.Parameters.AddWithValue("@nome ",dto.Nome);
                bd.comm.Parameters.AddWithValue("@cpf",dto.Cpf);
                bd.comm.Parameters.AddWithValue("@tel",dto.Telefone);
                bd.comm.Parameters.AddWithValue("@email",dto.Email);
                bd.comm.Parameters.AddWithValue("@endereco",dto.Endereco);
                bd.comm.Parameters.AddWithValue("@cidade",dto.Cidade);
                bd.comm.Parameters.AddWithValue("@bairro",dto.Bairro);
                bd.comm.Parameters.AddWithValue("@uf",dto.Uf);
                bd.comm.Parameters.AddWithValue("@complemento",dto.Complemento);
                bd.comm.Parameters.AddWithValue("@numero",dto.Numero);
                bd.comm.Parameters.AddWithValue("@cep",dto.Cep);
                bd.comm.Parameters.AddWithValue("@id_cargo",cmb.SelectedValue.ToString());
                bd.comm.Parameters.AddWithValue("@id_login",loginDTO.Id);
                bd.comm.Parameters.AddWithValue("@data",dto.Dt_Nascimento);
                bd.comm.ExecuteNonQuery();

            }
            catch(SqlException ex)
            {
                throw new Exception("Erro no cadastro de funcionario : "+ex.Message);
            }
            finally
            {
                bd.Fechar();
            }
        }

        public DataTable SelecionarNome(FuncionarioDTO dto) 
        {
            try 
            {
                string f = "%"+dto.Nome+"%";
                bd.Conectar();
                bd.comm.CommandText = "Select funcionario.nome as Nome,funcionario.email as Email,funcionario.dt_nascimento as 'Data de nascimento',funcionario.cpf as CPF,funcionario.telefone as Telefone, funcionario.endereco as Endereço,funcionario.UF as UF,funcionario.CPF as CPF, Cargo.descricao as Cargo from Funcionario inner join Cargo on funcionario.id_cargo = Cargo.id_cargo where funcionario.nome like @nome order by nome";
                bd.comm.Parameters.AddWithValue("@nome",f);
                dt = new DataTable();
                da = new SqlDataAdapter(bd.comm);
                da.Fill(dt);
            }

            catch (SqlException ex) 
            {
                throw new Exception("Erro no seleção do nome de funcionario : "+ex.Message);
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
                bd.comm.CommandText = "Select funcionario.nome as Nome,funcionario.email as Email,funcionario.dt_nascimento as 'Data de Nascimento',funcionario.cpf as CPF,funcionario.telefone as Telefone, funcionario.endereco as Endereço,funcionario.UF as UF,funcionario.CPF as CPF, Cargo.descricao as Cargo from Funcionario inner join Cargo on funcionario.id_cargo = Cargo.id_cargo order by nome";
                dt = new DataTable();
                da = new SqlDataAdapter(bd.comm);
                da.Fill(dt);

            }   
            catch(SqlException ex)
            {
                throw new Exception("Erro na seleção dos funcionários : "+ex.Message);
            }
            finally
            {
                bd.Fechar();
            }

            return dt;
        }

        public int SelecionarId(FuncionarioDTO dto) 
        {
            int ret = 0;

            try 
            {
                bd.Conectar();
                bd.comm.CommandText = "Select id_funcionario from Funcionario where nome = @nome";
                bd.comm.Parameters.AddWithValue("@nome",dto.Nome);
                ret = Convert.ToInt32(bd.comm.ExecuteScalar());
            }
            catch(SqlException ex)
            {
                throw new Exception("Erro na seleção do id do funcionario : "+ex.Message);
            }
            finally
            {
                bd.Fechar();
            }

            return ret;
        }

        public int Deletar(FuncionarioDTO dto) 
        {         
            int ret = 0;
            try 
            {
                bd.Conectar();
                bd.comm.CommandText = "Delete from funcionario where id_funcionario = @id_funcionario";
                bd.comm.Parameters.AddWithValue("@id_funcionario",dto.Id);
                ret = Convert.ToInt32(bd.comm.ExecuteNonQuery());
            }
            catch(SqlException ex)
            {
                throw new Exception("Erro na exclusão de funcionarios : "+ex.Message);
            }
            finally
            {
                bd.Fechar();
            }

            return ret;
        }

        public int Procurar(TextBox txt,string nome) 
        {
            int ret = 0;
            try 
            {
                bd.Conectar();
                bd.comm.CommandText = "Select id_funcionario from funcionario where "+nome+" like @nome";
                bd.comm.Parameters.AddWithValue("@nome",txt.Text);
                ret = Convert.ToInt32(bd.comm.ExecuteScalar());
            }
            catch(SqlException ex)
            {
                throw new Exception("Erro na procura : "+ex.Message);
            }
            finally
            {
                bd.Fechar();
            }

            return ret;
        }

        public int ProcurarMasked(MaskedTextBox txt, string nome)
        {
            int ret = 0;
            try
            {
                bd.Conectar();
                bd.comm.CommandText = "Select id_funcionario from funcionario where " + nome + " like @nome";
                bd.comm.Parameters.AddWithValue("@nome", txt.Text);
                ret = Convert.ToInt32(bd.comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro na procura : " + ex.Message);
            }
            finally
            {
                bd.Fechar();
            }

            return ret;
        }
    }
}
