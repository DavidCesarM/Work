using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlves.Model
{
    internal class Registro
    {
        //Propriedades da classe.
        private string dataEmissao, grupo, vencimento, conta;
        private double valor, entrada;
        private int parcelas;



        //Getters e Setters
        public string DataEmissao
        {
            get { return dataEmissao;}
            set { dataEmissao = value; }     
        }

        public string Grupo
        {
            get { return grupo;}    
            set { grupo = value; }  
        }

        public string Vencimento
        {
            get { return vencimento;}   
            set { vencimento = value; } 
        }

        public string Conta
        {
            get { return conta;}
            set { conta = value; }   
        }

        public int Parcelas
        {
            get { return parcelas;} 
            set { parcelas = value; }   
        }

        public double Valor
        {
            get { return valor; }
            set{ valor = value; }
        }

        public double Entrada
        {
            get { return entrada; }
            set { entrada = value; }
        }

    }
}
