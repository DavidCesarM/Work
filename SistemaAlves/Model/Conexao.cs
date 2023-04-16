using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlves.Model
{
    //Classe de conexão.
    internal class Conexao
    {
        private SqlConnection con = new SqlConnection(); 

        //Construtor onde inicia a variável con.
        public Conexao() {
            con.ConnectionString = "Data Source=LAPTOP-7SOAL7K7\\SQLSERVER2022;Initial Catalog=db_user;Integrated Security=True";
        }   
        
        //Método que conecta com o banco.
        public SqlConnection Conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open(); 
            }
            return con; 
        }

        //Método que desconecta do banco.
        public void Desconectar() { 

            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();    
            }
        }
    }
}
