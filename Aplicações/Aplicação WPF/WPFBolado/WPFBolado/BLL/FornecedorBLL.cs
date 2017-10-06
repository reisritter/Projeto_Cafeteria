using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using WPFBolado.DTO;
using System.Windows.Controls;

namespace WPFBolado.BLL
{
    class FornecedorBLL
    {
        Acesso bd = new Acesso();
        SqlDataAdapter da;
        DataTable dt;

        public int Procurar(TextBox txt, string nome)
        {
            int ret = 0;
            try
            {
                bd.Conectar();
                bd.comm.CommandText = "Select id_fornecedor from fornecedor where " + nome + " like @nome";
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

        public DataTable SelecionarTudo()
        {
            try
            {
                bd.Conectar();
                bd.comm.CommandText = "Select razao_social as Nome,cnpj as CNPJ, email as Email,telefone as Telefone,gerente as Gerente, endereco as Endereço,bairro as Bairro,cidade as Cidade,uf as UF,cep as CEP,complemento as Complemento,numero as Número from Fornecedor order by razao_social";
                dt = new DataTable();
                da = new SqlDataAdapter(bd.comm);
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                throw new Exception("" + ex.Message);
            }
            finally
            {
                bd.Fechar();
            }

            return dt;
        }

        public DataTable SelecionarNome(FornecedorDTO dto)
        {
            try
            {
                string nome = "%" + dto.Razao_social + "%";
                bd.Conectar();
                bd.comm.CommandText = "Select razao_social as Nome,cnpj as CNPJ, email as Email,telefone as Telefone,gerente as Gerente, endereco as Endereço,bairro as Bairro,cidade as Cidade,uf as UF,cep as CEP,complemento as Complemento,numero as Número where razao_social like @nome order by razao_social";
                bd.comm.Parameters.AddWithValue("@nome", nome);
                dt = new DataTable();
                da = new SqlDataAdapter(bd.comm);
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                throw new Exception("" + ex.Message);
            }
            finally
            {
                bd.Fechar();
            }

            return dt;
        }

        public void updateSemEmail(FornecedorDTO dto)
        {
            try
            {
                bd.Conectar();
                bd.comm.CommandText = "update fornecedor set razao_social = @razao,telefone = @telefone,gerente=@gerente,endereco=@endereco,bairro=@bairro,cidade=@cidade,uf=@uf,cep=@cep,complemento=@complemento,numero=@numero where id_fornecedor = @id";
                bd.comm.Parameters.AddWithValue("@razao", dto.Razao_social);
                bd.comm.Parameters.AddWithValue("@gerente", dto.Gerente);
                bd.comm.Parameters.AddWithValue("@id", dto.Id);
                bd.comm.Parameters.AddWithValue("@telefone", dto.Telefone);                
                bd.comm.Parameters.AddWithValue("@endereco", dto.Endereco);
                bd.comm.Parameters.AddWithValue("@cep", dto.Cep);
                bd.comm.Parameters.AddWithValue("@cidade", dto.Cidade);
                bd.comm.Parameters.AddWithValue("@bairro", dto.Bairro);
                bd.comm.Parameters.AddWithValue("@uf", dto.Uf);
                bd.comm.Parameters.AddWithValue("@complemento", dto.Complemento);
                bd.comm.Parameters.AddWithValue("@numero", dto.Numero);
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

        public void update(FornecedorDTO dto)
        {
            try
            {
                bd.Conectar();
                bd.comm.CommandText = "update fornecedor set razao_social = @razao, email = @email,telefone = @telefone,gerente=@gerente,endereco=@endereco,bairro=@bairro,cidade=@cidade,uf=@uf,cep=@cep,complemento=@complemento,numero=@numero where id_fornecedor = @id";
                bd.comm.Parameters.AddWithValue("@razao", dto.Razao_social);
                bd.comm.Parameters.AddWithValue("@gerente", dto.Gerente);
                bd.comm.Parameters.AddWithValue("@id", dto.Id);
                bd.comm.Parameters.AddWithValue("@telefone", dto.Telefone);
                bd.comm.Parameters.AddWithValue("@email", dto.Email);
                bd.comm.Parameters.AddWithValue("@endereco", dto.Endereco);
                bd.comm.Parameters.AddWithValue("@cep", dto.Cep);
                bd.comm.Parameters.AddWithValue("@cidade", dto.Cidade);
                bd.comm.Parameters.AddWithValue("@bairro", dto.Bairro);
                bd.comm.Parameters.AddWithValue("@uf", dto.Uf);
                bd.comm.Parameters.AddWithValue("@complemento", dto.Complemento);
                bd.comm.Parameters.AddWithValue("@numero", dto.Numero);
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

        public void Inserir(FornecedorDTO dto)
        {
            try
            {
                bd.Conectar();                
                bd.comm.CommandText = "insert into Fornecedor(razao_social,cnpj,email,telefone,gerente,endereco,bairro,cidade,uf,cep,complemento,numero)values(@razao,@cnpj,@email,@telefone,@gerente,@endereco,@bairro,@cidade,@uf,@cep,@complemento,@numero)";
                bd.comm.Parameters.AddWithValue("@razao", dto.Razao_social);
                bd.comm.Parameters.AddWithValue("@gerente", dto.Gerente);
                bd.comm.Parameters.AddWithValue("@cnpj", dto.Cnpj);
                bd.comm.Parameters.AddWithValue("@telefone", dto.Telefone);
                bd.comm.Parameters.AddWithValue("@email", dto.Email);
                bd.comm.Parameters.AddWithValue("@endereco", dto.Endereco);
                bd.comm.Parameters.AddWithValue("@cep", dto.Cep);
                bd.comm.Parameters.AddWithValue("@cidade", dto.Cidade);
                bd.comm.Parameters.AddWithValue("@bairro", dto.Bairro);
                bd.comm.Parameters.AddWithValue("@uf", dto.Uf);
                bd.comm.Parameters.AddWithValue("@complemento", dto.Complemento);
                bd.comm.Parameters.AddWithValue("@numero", dto.Numero);
                bd.comm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("" + ex.Message);
            }
            finally
            {
                bd.Fechar();
            }
        }
    }
}
