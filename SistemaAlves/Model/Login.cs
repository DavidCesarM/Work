using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlves.Model
{
    internal class Login
    {

        private Conexao con = new Conexao();
        private SqlCommand sqlQuery = new SqlCommand();
        private bool tem = false;

        private string tb_login = "tb_login";
        private string col_nome = "nome";
        private string col_senha = "senha";
        
      

        
        public bool Acessar(string nome, string senha)
        {
           
            try
            {
                Usuario usuario = new Usuario();
                usuario.Nome = nome;
                usuario.Senha = senha;
                

                //String que será enviada para o banco.
                sqlQuery.CommandText = "select * from " + tb_login + " where " + col_nome + "=@" + col_nome + " and " + col_senha + "=@" + col_senha;

                //Adiciona parametros.
                sqlQuery.Parameters.AddWithValue("@" + col_nome, usuario.Nome);
                sqlQuery.Parameters.AddWithValue("@" + col_senha, usuario.Senha);


                //Inicia conexão com o banco.
                sqlQuery.Connection = con.Conectar();

                //Variável que faz leitura no banco.
                SqlDataReader dr = sqlQuery.ExecuteReader();


                //Condição que pesquisa por linha dentro do banco.
                if (dr.HasRows)
                {
                    //Se contiver no banco a variável tem se torna verdadeira.
                    tem = true;
                    MessageBox.Show("Logado!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Sistema sys = new Sistema(usuario.Nome);
                    usuario.Logado = true;
                    sys.ShowDialog();

                }
                else
                {
                    //Caso não contiver retorna uma mensagem de erro.
                    MessageBox.Show("Usuário ou Senha Incorreto(s)!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usuario.Logado = false;
                }



            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Desconecta com o banco.
                con.Desconectar();
            }

            return tem;
        }




    }
}
