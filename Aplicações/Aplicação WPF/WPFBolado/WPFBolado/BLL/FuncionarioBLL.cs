using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using WPFBolado.DTO;
using System.Windows.Controls;
using AC.AvalonControlsLibrary.Controls;

namespace WPFBolado.BLL
{
    class FuncionarioBLL
    {
        Acesso bd = new Acesso();
        DataTable dt;
        SqlDataAdapter da;

        public void Inserir(FuncionarioDTO dto, ComboBox cmb, LoginDTO loginDTO)
        {
            try
            {
                bd.Conectar();
                bd.comm.CommandText = "insert into Funcionario(nome,email,endereco,bairro,cidade,uf,numero,telefone,cpf,cep,id_cargo,id_login) values(@nome,@email,@endereco,@bairro,@cidade,@uf,@numero,@tel,@cpf,@cep,@id_cargo,@id_login)";
                bd.comm.Parameters.AddWithValue("@nome ", dto.Nome);
                bd.comm.Parameters.AddWithValue("@cpf", dto.Cpf);
                bd.comm.Parameters.AddWithValue("@tel", dto.Telefone);
                bd.comm.Parameters.AddWithValue("@email", dto.Email);
                bd.comm.Parameters.AddWithValue("@endereco", dto.Endereco);
                bd.comm.Parameters.AddWithValue("@cidade", dto.Cidade);
                bd.comm.Parameters.AddWithValue("@bairro", dto.Bairro);
                bd.comm.Parameters.AddWithValue("@uf", dto.Uf);               
                bd.comm.Parameters.AddWithValue("@numero", dto.Numero);
                bd.comm.Parameters.AddWithValue("@cep", dto.Cep);                
                bd.comm.Parameters.AddWithValue("@id_cargo", cmb.SelectedValue.ToString());
                bd.comm.Parameters.AddWithValue("@id_login", loginDTO.Id);                
                bd.comm.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Exception("Erro no cadastro de funcionario : " + ex.Message);
            }
            finally
            {
                bd.Fechar();
            }
        }

        public void updateSemEmail(FuncionarioDTO dto, ComboBox cb)
        {
            try
            {
                bd.Conectar();
                bd.comm.CommandText = "Update funcionario set nome = @nome,telefone = @tel,cidade=@cidade,bairro=@bairro,uf=@uf,numero=@numero,cep=@cep,id_cargo=@id_cargo where id_funcionario = @id";
                bd.comm.Parameters.AddWithValue("@nome ", dto.Nome);
                bd.comm.Parameters.AddWithValue("@tel", dto.Telefone);                
                bd.comm.Parameters.AddWithValue("@endereco", dto.Endereco);
                bd.comm.Parameters.AddWithValue("@cidade", dto.Cidade);
                bd.comm.Parameters.AddWithValue("@bairro", dto.Bairro);
                bd.comm.Parameters.AddWithValue("@uf", dto.Uf);
                bd.comm.Parameters.AddWithValue("@numero", dto.Numero);
                bd.comm.Parameters.AddWithValue("@cep", dto.Cep);
                bd.comm.Parameters.AddWithValue("@id_cargo", cb.SelectedValue.ToString());
                bd.comm.Parameters.AddWithValue("@id", dto.Id);
                bd.comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                bd.Fechar();
            }
        }

        public void update(FuncionarioDTO dto,ComboBox cb)
        {
            try
            {
                bd.Conectar();
                bd.comm.CommandText = "Update funcionario set nome = @nome,telefone = @tel,email=@email,cidade=@cidade,bairro=@bairro,uf=@uf,numero=@numero,cep=@cep,id_cargo=@id_cargo where id_funcionario = @id";
                bd.comm.Parameters.AddWithValue("@nome ", dto.Nome);                
                bd.comm.Parameters.AddWithValue("@tel", dto.Telefone);
                bd.comm.Parameters.AddWithValue("@email", dto.Email);
                bd.comm.Parameters.AddWithValue("@endereco", dto.Endereco);
                bd.comm.Parameters.AddWithValue("@cidade", dto.Cidade);
                bd.comm.Parameters.AddWithValue("@bairro", dto.Bairro);
                bd.comm.Parameters.AddWithValue("@uf", dto.Uf);
                bd.comm.Parameters.AddWithValue("@numero", dto.Numero);
                bd.comm.Parameters.AddWithValue("@cep", dto.Cep);
                bd.comm.Parameters.AddWithValue("@id_cargo", cb.SelectedValue.ToString());
                bd.comm.Parameters.AddWithValue("@id", dto.Id);                                       
                bd.comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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
                string f = "%" + dto.Nome + "%";
                bd.Conectar();
                bd.comm.CommandText = "Select funcionario.nome as Nome,funcionario.email as Email,funcionario.cpf as CPF,funcionario.telefone as Telefone, funcionario.endereco as Endereço,funcionario.cidade as Cidade,funcionario.bairro as Bairro,funcionario.cep as CEP,funcionario.numero as Numero,funcionario.UF as UF,Cargo.descricao as Cargo,lo.usuario as Usuario,lo.lembrete as Lembrete from Funcionario inner join Cargo on funcionario.id_cargo = Cargo.id_cargo inner join login_ lo on lo.id_login = funcionario.id_login where funcionario.nome like @nome order by nome";
                bd.comm.Parameters.AddWithValue("@nome", f);
                dt = new DataTable();
                da = new SqlDataAdapter(bd.comm);
                da.Fill(dt);
            }

            catch (SqlException ex)
            {
                throw new Exception("Erro no seleção do nome de funcionario : " + ex.Message);
            }

            finally
            {
                bd.Fechar();
            }

            return dt;
        }

        public DataTable SelecionarTudoPorId(LoginDTO dto)
        {
            try
            {
                bd.Conectar();
                bd.comm.CommandText = "Select funcionario.nome as Nome,funcionario.email as Email,funcionario.cpf as CPF,funcionario.telefone as Telefone, funcionario.endereco as Endereço,funcionario.cidade as Cidade,funcionario.bairro as Bairro,funcionario.cep as CEP,funcionario.numero as Numero,funcionario.UF as UF,Cargo.descricao as Cargo,lo.usuario as Usuario,lo.lembrete as Lembrete from Funcionario inner join Cargo on funcionario.id_cargo = Cargo.id_cargo inner join login_ lo on lo.id_login = funcionario.id_login where lo.id_login = @id order by nome";
                bd.comm.Parameters.AddWithValue("@id",dto.Id);
                dt = new DataTable();
                da = new SqlDataAdapter(bd.comm);
                da.Fill(dt);

            }
            catch (SqlException ex)
            {
                throw new Exception("Erro na seleção dos funcionários : " + ex.Message);
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
                bd.comm.CommandText = "Select funcionario.nome as Nome,funcionario.email as Email,funcionario.cpf as CPF,funcionario.telefone as Telefone, funcionario.endereco as Endereço,funcionario.cidade as Cidade,funcionario.bairro as Bairro,funcionario.cep as CEP,funcionario.numero as Numero,funcionario.UF as UF,Cargo.descricao as Cargo,lo.usuario as Usuario,lo.lembrete as Lembrete from Funcionario inner join Cargo on funcionario.id_cargo = Cargo.id_cargo inner join login_ lo on lo.id_login = funcionario.id_login order by nome";
                dt = new DataTable();
                da = new SqlDataAdapter(bd.comm);
                da.Fill(dt);

            }
            catch (SqlException ex)
            {
                throw new Exception("Erro na seleção dos funcionários : " + ex.Message);
            }
            finally
            {
                bd.Fechar();
            }

            return dt;
        }

        public int SelecionarIdPorLogin(LoginDTO dto)
        {
            int ret = 0;

            try
            {
                bd.Conectar();
                bd.comm.CommandText = "select id_funcionario from funcionario where id_login = @id";
                bd.comm.Parameters.AddWithValue("@id",dto.Id);
                dt = new DataTable();
                da = new SqlDataAdapter(bd.comm);
                da.Fill(dt);

                ret = Convert.ToInt16(dt.Rows[0]["id_funcionario"].ToString());
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }

            return ret;
        }

        public int SelecionarId(FuncionarioDTO dto)
        {
            int ret = 0;

            try
            {
                bd.Conectar();
                bd.comm.CommandText = "Select id_funcionario from Funcionario where cpf = @cpf";
                bd.comm.Parameters.AddWithValue("@cpf", dto.Cpf);
                dt = new DataTable();
                da = new SqlDataAdapter(bd.comm);
                da.Fill(dt);
                ret = Convert.ToInt16(dt.Rows[0]["id_funcionario"].ToString());
                
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro na seleção do id do funcionario : " + ex.Message);
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
                bd.comm.Parameters.AddWithValue("@id_funcionario", dto.Id);
                ret = Convert.ToInt32(bd.comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro na exclusão de funcionarios : " + ex.Message);
            }
            finally
            {
                bd.Fechar();
            }

            return ret;
        }

        public int Procurar(TextBox txt, string nome)
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

        public int SelecionarIdLogin(FuncionarioDTO dto)
        {
            int ret = 0;

            try
            {
                bd.Conectar();
                bd.comm.CommandText = "select id_login from funcionario where cpf = @cpf";
                bd.comm.Parameters.AddWithValue("@cpf",dto.Cpf);
                dt = new DataTable();
                da = new SqlDataAdapter(bd.comm);
                da.Fill(dt);
                ret = Convert.ToInt16(dt.Rows[0]["id_login"].ToString());

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                bd.Fechar();
            }

            return ret;
        }

        public int ProcurarMasked(TextBox txt, string nome)
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
