using SistemaAlves.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SistemaAlves.Controler
{
    internal class SystemControler
    {

        //Instância da classe conexão
        private Conexao con = new Conexao();

        //Proprieade que receberá os comando sql
        private SqlCommand sqlQuery = new SqlCommand();

        //Variáveis 
        private int id = 0;
        public bool clear = false;

        Registro rg = new Registro();
        SqlDataReader dr;


        private string tb_conta = "tb_itemsConta";
        private string tb_parcelas = "tb_itemsParcelas01";
        private string tb_grupo = "tb_itemsGrupo";
        private string tb_despesas = "tb_despesas03";

        private string col_conta = "conta";
        private string col_parcelas = "parcelas";
        private string col_grupo = "grupo";

        public SystemControler() {
            this.IniciaVarId();
        }

 //**********************************************************************************************************************************
     
        
        //Inicia variável Id, que será lançada no banco.
        private void IniciaVarId()
        {
            try
            {
               //Pega o primero registro na tabela e inverte retornando o último.
                sqlQuery.CommandText = "select top 1 id from "+this.tb_despesas+" order by id desc";

                sqlQuery.Connection = con.Conectar();

               //Executa leitura no banco.
                dr = sqlQuery.ExecuteReader();
                
               //Inicia a variável id com o id do último registro do banco.
                if(dr.Read())
                {
                    id = Convert.ToInt32(dr["ID"]);
                }            

            }
            catch (SqlException ex)
            {
                //Exibe msg de erro.
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            { 
                //Desconecta do banco.
                con.Desconectar();

            }
        }

        //*****************************************TELA LANÇAR DESPESAS************************************************************
        //***************************************************************************************************************************
        //**************************************************************************************************************************

//**********************************************************************************************************************************
     
        //Método responsável por preencher os combobox da tela despesa
        public void PreencheComboBoxesDespesa(ComboBox cbConta, ComboBox cbGrupo, ComboBox cbParcelas)
        {
            
            try
            {
                //Instancia array
                ArrayList arrConta = new ArrayList();

               //Seleciona os registros que não se repetem.
                sqlQuery.CommandText = "select distinct "+ this.col_conta +" from " + this.tb_conta;
                 
                //Inicia conexão com o banco.
                sqlQuery.Connection = con.Conectar();


                //Executa leitura no banco.
                dr = sqlQuery.ExecuteReader();

                //Preenche o combobox Conta
                while (dr.Read())
                {
                    //Adiciona items no array
                    arrConta.Add(dr.GetString(this.col_conta));
                   // cbConta.Items.Add(dr.GetString(this.col_conta));
                }

                //Adiciona items do array no combobox
                cbConta.DataSource = arrConta;

                //Configura index do combobox para -1
                cbConta.SelectedIndex = -1;

            }
            catch (SqlException ex)
            {

                //Exibe msg de erro.
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {

                //Finaliza conexão com o banco.
                con.Desconectar();
            }

            try
            {
                //Instancia array
                ArrayList arrGrupo = new ArrayList();

                //Seleciona os registros que não se repetem.
                sqlQuery.CommandText = "select distinct "+ this.col_grupo + " from " + this.tb_grupo;

                //Inicia conexão com o banco.
                sqlQuery.Connection = con.Conectar();

                //Executa leitura no banco.
                dr = sqlQuery.ExecuteReader();

                //Preenche o combobox Grupo
                while (dr.Read())
                {
                    //Adiciona items no array
                    arrGrupo.Add(dr.GetString(this.col_grupo));

                }

                //Adiciona items do array no combobox
                cbGrupo.DataSource = arrGrupo;

                //Configura index do combobox para -1
                cbGrupo.SelectedIndex = -1;

            }
            catch (SqlException ex)
            {
                //Exibe msg de erro.
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Finaliza conexão com o banco.
                con.Desconectar();
            }

            try
            {
                //Instancia array
                ArrayList arrParcelas = new ArrayList();

                //Seleciona os registros que não se repetem.
                sqlQuery.CommandText = "select distinct "+ this.col_parcelas + " from " + this.tb_parcelas;

                //Inicia conexão com o banco.
                sqlQuery.Connection = con.Conectar();

                //Executa leitura no banco.
                dr = sqlQuery.ExecuteReader();

                //Preenche o combobox Parcelas
                while (dr.Read())
                {
                    //Adiciona items no array
                    arrParcelas.Add(dr[this.col_parcelas]);
                }

                //Adiciona items do array no combobox
                cbParcelas.DataSource = arrParcelas;

                //Configura index do combobox para -1
                cbParcelas.SelectedIndex = -1;

                //Código funcional(teste)
                /*List<int> list = new List<int>();

                 while (dr.Read())
                 {
                     list.Add(Convert.ToInt32(dr[this.col_parcelas]));
                 }

                 list.Sort();

                 for (int i = 0; i < list.Count; i++)
                 {       
                     cbParcelas.Items.Add(list[i]);
                 }*/
            }
            catch (SqlException ex)
            {
                //Exibe msg de erro.
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Finaliza conexão com o banco.
                con.Desconectar();
            }

        }

//**********************************************************************************************************************************

        //Método referente ao laçamento de despesas.
        public void Lançar(DataGridView dgDespesa, TextBox txtValorParcelas, string emissao, string valor, string parcelas, string entrada, string grupo, MaskedTextBox txtVencimento, string conta, TextBox txtId)
        {
          
          //Verifica  se campos estão vazios ou incompletos.
            if (string.IsNullOrWhiteSpace(emissao)  || string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(parcelas) || string.IsNullOrWhiteSpace(entrada) || string.IsNullOrWhiteSpace(grupo) || txtVencimento.Text.Length != 8 || string.IsNullOrWhiteSpace(conta)) {
                MessageBox.Show("Campo(s) Vazio(s)!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear = false;    
            }
            else
            {
                //Verifica se o primeiro valor, nos campos valor e entrada, é uma vírgula.
                if (valor[0].ToString() == "," || entrada[0].ToString() == "," || valor == "0")
                {
                    MessageBox.Show("Campo(s) possui(em) valores incorretos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear = false;
                }
                else
                {
                    //verifica se o valor inicial é menor do que o de entrada.
                    if (Convert.ToDouble(valor) < Convert.ToDouble(entrada))
                    {
                        MessageBox.Show("Valor de entrada não pode ser maior que valor inicial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clear = false;
                    }
                    else
                    {
                        try
                        {

                            //Valor literal do MaskedTextBox incluindo __/__/____, para posterior verificação.
                            txtVencimento.TextMaskFormat = MaskFormat.IncludeLiterals;
                            
                            //Pega a data atual.
                            var dataAtual = DateTime.Today;

                            //Pega a data do MaskedtextBox vencimento e o converte para Datatime que equivalendo o à máscara passada dd/MM/yyyy
                            var dateTxtVencimento = DateTime.ParseExact(txtVencimento.Text, "dd/MM/yyyy", null);

                            //Compara as duas datas.
                            int compararDatas = DateTime.Compare(dateTxtVencimento, dataAtual);

                            //Se for uma data anterior a de hoje é retornado -1.
                            if (compararDatas == -1)
                            {
                                MessageBox.Show("A data de vencimento não pode ser menor do que a de hoje", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                clear = false;
                            }
                            else
                            {

                              
                                //Incrementa a var. id
                                    id++;

                                //Caso a qntd. de parcelas seja maior do que 1.
                                    if (Convert.ToInt32(parcelas) > 1)
                                    {

                                    //cria uma var. que recebera uma instância da classe DateTime no seguinte formato dd/MM/DD
                                        var data = new DateTime(dateTxtVencimento.Year, dateTxtVencimento.Month, dateTxtVencimento.Day);

                                    //Cria uma var. que recebe a var. data, e será responsável por adicionar os dias sob a data atual.
                                        DateTime addDias = data;

                                    //Valores passados para as propriedades da classe   Registro.
                                        rg.Valor = Convert.ToDouble(valor);
                                        rg.Parcelas = Convert.ToInt32(parcelas);
                                        rg.Entrada = Convert.ToDouble(entrada);
                                        rg.Grupo = Convert.ToString(grupo);
                                        rg.DataEmissao = Convert.ToString(emissao);
                                        rg.Vencimento = Convert.ToString(txtVencimento.Text);
                                        rg.Conta = Convert.ToString(conta);

                                    //laço que se repetirá de acordo com a qntd. de parcela.
                                        for (int i = 0; i < rg.Parcelas; i++)
                                        {
                                           //Adiciona as linhas ao datagrid da tela lançar despesas.
                                            dgDespesa.Rows.Add(Convert.ToString(id), rg.DataEmissao, rg.Valor, Convert.ToString(i + 1) + "/" + rg.Parcelas, CalculaValorParcelas(rg.Valor, rg.Entrada, rg.Parcelas).ToString(), rg.Entrada, rg.Grupo, addDias.ToString("dd/MM/yyyy"), rg.Conta);
                                           
                                            //Cálculo responsável por adicionar dias a data atual.
                                            addDias = data.AddDays(30*(i+1));
                                        
                                        }


                                        clear = true;
                                        
                                    }
                                    else //Caso a qntd. de parcelas seja igual a 1.
                                    {
                                        //Valor literal do MaskedTextBox incluindo __/__/____, para posterior verificação.
                                        txtVencimento.TextMaskFormat = MaskFormat.IncludeLiterals;

                                        //Valores passados para as propriedades da classe   Registro.
                                        rg.Valor = Convert.ToDouble(valor);
                                        rg.Parcelas = Convert.ToInt32(parcelas);
                                        rg.Entrada = Convert.ToDouble(entrada);
                                        rg.Grupo = Convert.ToString(grupo);
                                        rg.DataEmissao = Convert.ToString(emissao);
                                        rg.Vencimento = Convert.ToString(txtVencimento.Text);
                                        rg.Conta = Convert.ToString(conta);

                                        clear = true;

                                         //Adiciona a linha ao datagrid da tela lançar despesas.
                                         dgDespesa.Rows.Add(Convert.ToString(id), rg.DataEmissao, rg.Valor, rg.Parcelas, "1", rg.Entrada, rg.Grupo, rg.Vencimento, rg.Conta);
                                      

                                    }


                                
                            }
                        }
                        catch (Exception ex)
                        {
                            //Exibe msg de erro.
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            //Retira a máscara do MaskedTextBox vencimento para eventuais verificações.
                            txtVencimento.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                        }        

                    }

                }

            }        
            
        }

//**********************************************************************************************************************************
    
        //Método responsável por preencher textboxes da tela despesas ao clicar em um item do datagridview
        public void PuxarInfoAoClicar(TextBox txtId, DataGridView dgDespesa, DateTimePicker txtEmissao, TextBox txtValor, ComboBox txtParcelas, TextBox txtEntrada, ComboBox txtGrupo, MaskedTextBox txtVencimento, ComboBox txtConta, TextBox txtValorParcelas )
        {

            //Pega o id atual da linha selecionada no datagridview da tela de lançamento de despesas.
              int pegarId = dgDespesa.CurrentRow.Index;
              
            //Preenche os campos da tela despesas.
              txtId.Text = dgDespesa.Rows[pegarId].Cells[0].Value.ToString();  
              txtEmissao.Text = dgDespesa.Rows[pegarId].Cells[1].Value.ToString();
              txtValor.Text = dgDespesa.Rows[pegarId].Cells[2].Value.ToString();
              txtParcelas.Text = dgDespesa.Rows[pegarId].Cells[3].Value.ToString();
              txtValorParcelas.Text = dgDespesa.Rows[pegarId].Cells[4].Value.ToString();
              txtEntrada.Text = dgDespesa.Rows[pegarId].Cells[5].Value.ToString();
 
              txtGrupo.Text = dgDespesa.Rows[pegarId].Cells[6].Value.ToString();
              txtVencimento.Text = dgDespesa.Rows[pegarId].Cells[7].Value.ToString();
              txtConta.Text = dgDespesa.Rows[pegarId].Cells[8].Value.ToString();

        }


//**********************************************************************************************************************************
  
        
        //Método responsável por editar o conteúdo dos registros lançados.
        public void Editar(DataGridView dgDespesa, string emissao, string valor, string parcelas, string entrada, string grupo, MaskedTextBox vencimento, string conta)
        {
            //Caso datagridview esteja vazio( sem nenhum registro lançado)
            if (dgDespesa.RowCount == 0)
            {
                MessageBox.Show("Nenhum registro foi lançado ainda", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Verifica se os campos estão vazios ou incompletos.

                if (string.IsNullOrWhiteSpace(emissao) || string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(parcelas) || string.IsNullOrWhiteSpace(entrada) || string.IsNullOrWhiteSpace(grupo) || vencimento.Text.Length < 8 || string.IsNullOrWhiteSpace(conta))
                {
                    MessageBox.Show("Campo(s) Vazio(s)!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Verifica se o primeiro valor dos campos valor e entrada começam com ',' ou valor == 0;
                    if (valor[0].ToString() == "," || entrada[0].ToString() == "," || valor == "0")
                    {
                        MessageBox.Show("Campo(s) possui(em) valores incorretos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      
                    }
                    else
                    {
                        //Verifica se valor de entrada é maior do que o valor inicial.
                        if(Convert.ToDouble(valor) < Convert.ToDouble(entrada))
                        {
                            MessageBox.Show("Valor de entrada não pode ser maior que valor inicial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            //Valor literal do MaskedTextBox incluindo __/__/____, para posterior verificação.
                            vencimento.TextMaskFormat = MaskFormat.IncludeLiterals;

                            //Valores passados para as propriedades da classe   Registro.
                            rg.Valor = Convert.ToDouble(valor);
                            rg.Parcelas = Convert.ToInt32(parcelas);
                            rg.Entrada = Convert.ToDouble(entrada);
                            rg.Grupo = grupo;
                            rg.DataEmissao = emissao;
                            rg.Vencimento = vencimento.Text;
                            rg.Conta = conta;

                            //Pega o id atual da linha selecionada no datagridview da tela de lançamento de despesas.
                            int pegarId = dgDespesa.CurrentRow.Index;

                            //Edita o conteúdo das colunas.
                            dgDespesa.Rows[pegarId].Cells[1].Value = rg.DataEmissao;
                            dgDespesa.Rows[pegarId].Cells[2].Value = rg.Valor;
                            dgDespesa.Rows[pegarId].Cells[3].Value = rg.Parcelas;
                            dgDespesa.Rows[pegarId].Cells[4].Value = rg.Entrada;
                       
                            dgDespesa.Rows[pegarId].Cells[6].Value = rg.Grupo;
                            dgDespesa.Rows[pegarId].Cells[7].Value = rg.Vencimento;
                            dgDespesa.Rows[pegarId].Cells[8].Value = rg.Conta;

                            //Msg de sucesso.
                            MessageBox.Show("Registro editado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
                
            }


        }

//**********************************************************************************************************************************

        //Método de exclusão dos registros.
        public void Excluir(DataGridView dgDespesa)
        {
            //Verifia se existe registo lançado no datagridview.
            if (dgDespesa.RowCount == 0)
            {
                MessageBox.Show("Nenhum registro foi lançado!", "Erro ao excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.clear = false;
            }
            else
            {
                //Exibe caixa de diálogo para confirmar exclusão.
                DialogResult YesOrNo = MessageBox.Show("Tem certeza que deseja apagar registro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (YesOrNo == DialogResult.Yes)
                {
                   //Remove registro.
                    dgDespesa.Rows.Remove(dgDespesa.CurrentRow);
                    this.clear = true;     
                }
                else{
                    this.clear = false;
                }        
            }
        }


//**********************************************************************************************************************************
        //Excluir todos os registros.
        public void ExcluirTudo(DataGridView dgDespesa)
        {
            //Verifia se existe registo lançado no datagridview.
            if (dgDespesa.RowCount == 0)
            {
                MessageBox.Show("Nenhum registro foi lançado!", "Erro ao excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.clear = false;
            }
            else
            {
                //Exibe caixa de diálogo para confirmar exclusão.
                DialogResult YesOrNo = MessageBox.Show("Tem certeza que deseja apagar  todos os registros?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (YesOrNo == DialogResult.Yes)
                {
                    //Remove todos os registros.
                    dgDespesa.Rows.Clear();
                    this.clear = true;
                }
                else
                {
                    this.clear = false;
                }
            }
        }


//**********************************************************************************************************************************
       
        //Método responsável por salvar no banco os registros.
        public void Salvar(DataGridView dgDespesa, ProgressBar pbCarregar, Label lblSalvando_despesas, string usuario)
        {
            //Verifia se existe algum registo lançado no datagridview.
            if (dgDespesa.RowCount == 0)
            {
                MessageBox.Show("Nenhum registro foi lançado!", "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear= false;
            }
            else
            {
                //Caso tenha registro na tela exibe uma msg.
                lblSalvando_despesas.Text = "Registrando...";

                //Comando de insersão no banco.
                sqlQuery.CommandText = "insert into "+ this.tb_despesas +" (id, emissao, valor, parcelas, valorParcelas, entrada, grupo, vencimento, conta, usuario) values (@id, @emissao, @valor, @parcelas, @valorParcelas, @entrada, @grupo, @vencimento, @conta, @usuario)";
               
                //Inicia conexão.
                sqlQuery.Connection = con.Conectar();

                //configura a qntd. max. do ProgressBar Carregar e o adiciona a uma escala de 10.
                pbCarregar.Maximum = dgDespesa.RowCount * 10;
                clear = true;

                try
                {
                    //Laço que será repetido de acordo com a qntd. de linhas exibidas no datagridview despesas.
                    for (int j = 0; j < dgDespesa.RowCount; j++)
                    {

                        //Parâmetros.
                        sqlQuery.Parameters.AddWithValue("@id", Convert.ToInt64(dgDespesa.Rows[j].Cells[0].Value));
                        sqlQuery.Parameters.AddWithValue("@emissao", dgDespesa.Rows[j].Cells[1].Value.ToString());
                        sqlQuery.Parameters.AddWithValue("@valor", Convert.ToDouble(dgDespesa.Rows[j].Cells[2].Value));
                        sqlQuery.Parameters.AddWithValue("@parcelas", dgDespesa.Rows[j].Cells[3].Value.ToString());
                        sqlQuery.Parameters.AddWithValue("@valorParcelas", Convert.ToDouble(dgDespesa.Rows[j].Cells[4].Value));
                        sqlQuery.Parameters.AddWithValue("@entrada", Convert.ToDouble(dgDespesa.Rows[j].Cells[5].Value));
                        sqlQuery.Parameters.AddWithValue("@grupo", dgDespesa.Rows[j].Cells[6].Value.ToString());
                        sqlQuery.Parameters.AddWithValue("@vencimento", Convert.ToDateTime(dgDespesa.Rows[j].Cells[7].Value.ToString()));
                        sqlQuery.Parameters.AddWithValue("@conta", dgDespesa.Rows[j].Cells[8].Value.ToString());
                        sqlQuery.Parameters.AddWithValue("@usuario", usuario);

                        //Modifica o valor da ProgressBar Carregar construindo assim uma anim~ção de carregamento.
                        pbCarregar.Value = (j + 1) * 10;
                        sqlQuery.ExecuteNonQuery();

                        //Limpa o valor dos parâmetros.
                        sqlQuery.Parameters.Clear();
                    }

                    //Exibe msg de sucesso.
                    MessageBox.Show("Registro(s) salvo(s) com sucesso!!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpa texto da lblSalvando.
                    lblSalvando_despesas.Text = "";

                    //Limpa do datagridview
                    dgDespesa.Rows.Clear();

                    //Reseta o valor da ProgressBar para 0;
                    pbCarregar.Maximum = 0;

                }

                catch (SqlException ex)
                {
                    //Exibe msg de erro.
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    //Desconecta do banco.
                    con.Desconectar();
                }
               
                   
            }
           
        }


//**********************************************************************************************************************************
 
        
        //Método responsável por cálcular o valor das parcelas.
        private double CalculaValorParcelas(double valor, double entrada, int parcelas)
        {
            double valorDaParcela = 0;
           
            valorDaParcela = (valor - entrada) / parcelas;
            return valorDaParcela;            
           
        }
//**********************************************************************************************************************************
               
        /*********************** TELA CONFIGURAR COMBOBOXES DA TELA DE DESPESAS. ************************************
         * ************************************************************************************************
         * *******************************************************************************************************/

        //Método responsável por adicionar itens aos comboboxes da tela despesas.
        public void addItemsAosComboBoxDespesas(TextBox valor, ComboBox cbItens)
        {
            //Verifica se campos estão vazios.
            if (cbItens.Text.Equals("") || string.IsNullOrWhiteSpace(valor.Text))
            {
                MessageBox.Show("Campo vazio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Caso combobox da tela configuração despesas seja Grupo.
                if (cbItens.Text == "Grupo")
                {
                    try
                    {
                        //Comando de insersão no banco Grupo.
                        sqlQuery.CommandText = "insert into "+ this.tb_grupo +" ("+ this.col_grupo +") values (@"+col_grupo+")";
                        sqlQuery.Parameters.AddWithValue("@"+this.col_grupo, valor.Text);

                        //Conecta com o banco.
                        sqlQuery.Connection = con.Conectar();

                        sqlQuery.ExecuteNonQuery();

                        //Limpa parâmetros.
                        sqlQuery.Parameters.Clear();
                          
                        //Exibe msg de sucesso.
                        MessageBox.Show("Item adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Limpa combobox.
                        valor.Clear();
                    }
                    catch (SqlException ex)
                    {
                        //exibe msg de erro.
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        //Finaliza conexão.
                        con.Desconectar();
                    }

                    
                }
                //Caso combobox da tela configuração despesas seja Parcelas.
                else if (cbItens.Text == "Parcelas")
                {        
                    //Verifica se o valor é número.
                    if (valor.Text.All(char.IsDigit))
                    {
                        try
                        {
                            //Comando de insersão no banco Parcelas.
                            sqlQuery.CommandText = "insert into "+this.tb_parcelas+" ("+this.col_parcelas+") values (@"+this.col_parcelas+") ";
                            sqlQuery.Parameters.AddWithValue("@"+this.col_parcelas, Convert.ToInt32(valor.Text));

                            //Conecta com o banco.
                            sqlQuery.Connection = con.Conectar();

                            sqlQuery.ExecuteNonQuery();

                            //Limpa parâmetros.
                            sqlQuery.Parameters.Clear();

                            //Exibe msg de sucesso.
                            MessageBox.Show("Item adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            //Limpa combobox.
                            valor.Clear();
                        }
                        catch (SqlException ex)
                        {
                            //Exibe msg derro.
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            //Desconecta.
                            con.Desconectar();
                        }
                       
                    }
                    else
                    {
                        //Exibe msg caso campo do TextBox seja letras ou contenha letras ou caracteres espesiais.
                        MessageBox.Show("Este item não aceita letras ou carateres especiais!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                //Caso combobox da tela configuração despesas seja Conta.
                else if (cbItens.Text == "Conta")
                {
                    try
                    {
                        //Comando de insersão no banco Conta.
                        sqlQuery.CommandText = "insert into "+this.tb_conta+" ("+this.col_conta+") values (@"+this.col_conta+") ";
                        sqlQuery.Parameters.AddWithValue("@"+this.col_conta, valor.Text);

                        //Conecta com o banco.
                        sqlQuery.Connection = con.Conectar();

                        sqlQuery.ExecuteNonQuery();

                        //Limpa parâmetros.
                        sqlQuery.Parameters.Clear();

                        //Exibe msg de sucesso.
                        MessageBox.Show("Item adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Limpa combobox.
                        valor.Clear();
                    }
                    catch (SqlException ex)
                    {
                        //Exibe msg derro.
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        //Desconecta.
                        con.Desconectar();
                    }
                    
                }
            }

        }


//**********************************************************************************************************************************
        
        
        //Método responsável por vizualizar itens do banco.
        public void visualizarItems(DataGridView data, ComboBox cbItens)
        {
               string up = "";
               
            //Caso seja Grupo.
                if (cbItens.Text == "Grupo")
                {
                    try
                    {
                       //Comando de insersão no banco.
                        sqlQuery.CommandText = "select * from "+this.tb_grupo+" order by "+this.col_grupo+" asc";
    
                         //Inicia conexão.
                        sqlQuery.Connection = con.Conectar();

                         //Cria um dataset.
                        DataSet ds = new DataSet();
                        
                        //Cria um objeto da classe SqlDataAdapter onde é passado um comando sql e inicia a conexão.
                        SqlDataAdapter da = new SqlDataAdapter(sqlQuery.CommandText, con.Conectar());

                        //Preenche o dataSet ds
                        da.Fill(ds);

                        //Escolhe no banco qual tabela será apresentada.
                        data.DataSource = ds.Tables[0];

                        up = data.Columns[0].HeaderText.ToString().ToUpper();
                        data.Columns[0].HeaderText = up;

                    }
                    catch (SqlException ex)
                    {
                    //exibe msg de erro.
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                    //Desconecta.
                        con.Desconectar();
                    }
                }
                 //Caso seja Conta.
                else if (cbItens.Text == "Conta")
                {
                    try
                    {
                        //Comando de insersão no banco.
                        sqlQuery.CommandText = "select * from "+this.tb_conta;
                        
                        //Inicia conexão com o banco.
                        sqlQuery.Connection = con.Conectar();
                        
                        //Cria um dataset
                        DataSet ds = new DataSet();

                        //Cria um objeto da classe SqlDataAdapter onde é passado um comando sql e inicia a conexão.
                        SqlDataAdapter da = new SqlDataAdapter(sqlQuery.CommandText, con.Conectar());

                        //Preenche o dataSet ds
                        da.Fill(ds);

                        //Escolhe no banco qual tabela será apresentada.
                        data.DataSource = ds.Tables[0];

                        up = data.Columns[0].HeaderText.ToString().ToUpper();
                        data.Columns[0].HeaderText = up;

                    }
                    catch (SqlException ex)
                    {
                        //Exibe msg de erro.
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        //Desconectar.
                        con.Desconectar();
                    }
                }
                 //Caso seja Parcelas.
                else if (cbItens.Text == "Parcelas")
                {
                    try
                    {
                        //Comando de insersão no banco.
                        sqlQuery.CommandText = "select * from "+this.tb_parcelas+" order by "+this.col_parcelas+" asc";
                        
                        //Inicia conexão com o banco.
                        sqlQuery.Connection = con.Conectar();

                        DataSet ds = new DataSet();

                        //Cria um objeto da classe SqlDataAdapter onde é passado um comando sql e inicia a conexão.
                        SqlDataAdapter da = new SqlDataAdapter(sqlQuery.CommandText, con.Conectar());

                        //Preenche o dataSet ds
                        da.Fill(ds);

                        //Escolhe no banco qual tabela será apresentada.
                        data.DataSource = ds.Tables[0];

                        up = data.Columns[0].HeaderText.ToString().ToUpper();
                        data.Columns[0].HeaderText = up;
                    }
                    catch (SqlException ex)
                    {
                        //Msg de erro.
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        //Desconecta.
                        con.Desconectar();
                    }
                }
            

        }


//**********************************************************************************************************************************
     
        
        //Método responsável por puxar informações no duplo clique.
        public void puxarInfoNoClique(DataGridView dgData, TextBox txtAdd)
        {
            //Pega index atual da linha.
            int currentRow  = dgData.CurrentRow.Index;
            //Adiciona texto gerado ao TextBox txtAdd.
            txtAdd.Text = dgData.Rows[currentRow].Cells[1].Value.ToString();

        }


//**********************************************************************************************************************************
     
        
        //Método responsável por excluir itens do banco.
        public void ExcluirItemDoComboBox(TextBox txtAdd, ComboBox cbItens, DataGridView dgItens)
        {
            //Verifca se campo ou o datagridview estão vazios.
            if (cbItens.Text != "" && dgItens.RowCount != 0)
            {
                //Exibe diálogo de confirmação.
                DialogResult YesNo = MessageBox.Show("Tem certeza que deseja excluir item?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Caso resultado da interação seja 'Yes' = 'Sim';
                if (YesNo == DialogResult.Yes)
                {
                    //Pega índex atual da linha.
                    string id = dgItens.Rows[dgItens.CurrentRow.Index].Cells[0].Value.ToString();

                    if (cbItens.Text.Equals("Grupo"))
                    {
                        try
                        {
                            //Comando sql   que será enviado para o banco.
                            sqlQuery.CommandText = "delete from "+this.tb_grupo+" where id=@id";
                            sqlQuery.Parameters.AddWithValue("@id", Convert.ToInt32(id));
                            
                            //Inicia conexão com o banco.
                            sqlQuery.Connection = con.Conectar();

                            sqlQuery.ExecuteNonQuery();

                            //Limpa Parâmetros.
                            sqlQuery.Parameters.Clear();

                            //Limpa TextBox txtAdd
                            txtAdd.Clear();



                        }
                        catch (SqlException ex)
                        {
                            //Exibe msg de erro.
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            //Desconecta com o banco.
                            con.Desconectar();
                        }
                    }
                    else if (cbItens.Text.Equals("Parcelas"))
                    {
                        try
                        {
                            //Comando sql   que será enviado para o banco.
                            sqlQuery.CommandText = "delete from "+this.tb_parcelas+" where id=@id";
                            sqlQuery.Parameters.AddWithValue("@id", Convert.ToInt32(id));

                            //Inicia conexão com o banco.
                            sqlQuery.Connection = con.Conectar();

                           //Não executa nenhuma query no banco.
                            sqlQuery.ExecuteNonQuery();

                            //Limpa Parâmetros.
                            sqlQuery.Parameters.Clear();

                            //Limpa TextBox txtAdd
                            txtAdd.Clear();

                     


                        }
                        catch (SqlException ex)
                        {
                            //Exibe msg de erro.
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            //Finaliza conexão com  o banco.
                            con.Desconectar();
                        }
                    }
                    else if (cbItens.Text.Equals("Conta"))
                    {
                        try
                        {
                            //Comando sql   que será enviado para o banco.
                            sqlQuery.CommandText = "delete from "+this.tb_conta+" where id=@id";
                            sqlQuery.Parameters.AddWithValue("@id", Convert.ToInt32(id));

                            //Inicia conexão com o banco.
                            sqlQuery.Connection = con.Conectar();

                            sqlQuery.ExecuteNonQuery();

                            //Limpa Parâmetros.
                            sqlQuery.Parameters.Clear();

                            //Limpa TextBox txtAdd
                            txtAdd.Clear();


                        }
                        catch (SqlException ex)
                        {
                            //Exibe msg de erro.
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            //Encerra conexão com  o banco.
                            con.Desconectar();
                        }
                    }
                }             
            }
            else
            {
                //Exibe msg de erro caso campos estejam vazios.
                MessageBox.Show("Campo vazio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


//**********************************************************************************************************************************

        //Método responsável por editar os itens do combobox despesas.
        public void EditarItensDoComboBox(TextBox txtAdd, ComboBox cbItens, DataGridView dgItens)
        {

            //Verifca se campo ou o datagridview estão vazios.
            if (txtAdd.Text != "" && dgItens.RowCount != 0)
            {
                //Exibe diálogo de confirmação.
                DialogResult YesNo = MessageBox.Show("Tem certeza que deseja editar item?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                //Caso resultado da interação seja 'Yes' = 'Sim';
                if (YesNo == DialogResult.Yes)
                {
                    //Pega índex atual da linha.
                    string id = dgItens.Rows[dgItens.CurrentRow.Index].Cells[0].Value.ToString();

                    if (cbItens.Text.Equals("Grupo"))
                    {
                        try
                        {
                            //Comando sql   que será enviado para o banco.
                            sqlQuery.CommandText = "update "+this.tb_grupo+" set "+this.col_grupo+"=@"+this.col_grupo+" where id=@id";
                            sqlQuery.Parameters.AddWithValue("@id", Convert.ToInt32(id));
                            sqlQuery.Parameters.AddWithValue("@"+this.col_grupo, txtAdd.Text);

                            //Inicia conexão com o banco.
                            sqlQuery.Connection = con.Conectar();
                            sqlQuery.ExecuteNonQuery();

                            //Limpa Parâmetros.
                            sqlQuery.Parameters.Clear();

                            //Limpa TextBox txtAdd
                            txtAdd.Clear();
                        }
                        catch (SqlException ex)
                        {
                            //Exibe msg de erro.
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }finally
                        {
                            //Desconecta.
                            con.Desconectar();
                        }

                       

                    }
                    else if (cbItens.Text.Equals("Parcelas"))
                    {
                        try
                        {
                            if (txtAdd.Text.All(char.IsDigit))
                            {
                                //Comando sql   que será enviado para o banco.
                                sqlQuery.CommandText = "update "+this.tb_parcelas+" set "+this.col_parcelas+"=@"+this.col_parcelas+" where id=@id";
                                sqlQuery.Parameters.AddWithValue("@id", Convert.ToInt32(id));
                                sqlQuery.Parameters.AddWithValue("@"+this.col_parcelas, txtAdd.Text);

                                //Inicia conexão com o banco.
                                sqlQuery.Connection = con.Conectar();
                                sqlQuery.ExecuteNonQuery();

                                //Limpa Parâmetros.
                                sqlQuery.Parameters.Clear();

                                //Limpa TextBox txtAdd
                                txtAdd.Clear();
                            }
                            else
                            {
                                //Exibe msg de erro caso campo contenha letras ou caracteres especiais.
                                MessageBox.Show("Este item não aceita letras ou carateres especiais!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (SqlException ex)
                        {
                            //Exibe msg de erro.
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            //Desconecta.
                            con.Desconectar();
                        }
                    }
                    else if (cbItens.Text.Equals("Conta"))
                    {
                        try
                        {
                            //Comando sql   que será enviado para o banco.
                            sqlQuery.CommandText = "update "+this.tb_conta+" set "+this.col_conta+"=@"+this.col_conta+" where id=@id";
                            sqlQuery.Parameters.AddWithValue("@id", Convert.ToInt32(id));
                            sqlQuery.Parameters.AddWithValue("@conta", txtAdd.Text);

                            //Inicia conexão com o banco.
                            sqlQuery.Connection = con.Conectar();
                            sqlQuery.ExecuteNonQuery();

                            //Limpa Parâmetros.
                            sqlQuery.Parameters.Clear();
                            txtAdd.Clear();
                        }
                        catch (SqlException ex)
                        {
                            //Exibe msg de erro.
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            //Desconecta.
                            con.Desconectar();
                        }
                    }
                }
            }
            else
            {
                //Exibe msg de erro caso campos estejam vazios.
                MessageBox.Show("Campo vazio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //********************************* TELA BAIXAS *************************************************************
        //*************************************************************************************************************
        //************************************************************************************************************


        //Método responsável por exibir registros do banco depesas.
        public void exibirBancoDgBaixas(DataGridView dgBaixas)
        {

            //Comando sql.
            sqlQuery.CommandText = "select * from " + this.tb_despesas ;

            //Cria um dataset
            DataSet ds = new DataSet();

            //Cria um objeto da classe SqlDataAdapter onde é passado um comando sql e inicia a conexão.
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery.CommandText, con.Conectar());

            //Preenche o dataSet ds
            da.Fill(ds);

            //Exibe no datagridview baixas.
            dgBaixas.DataSource = ds.Tables[0];

            this.SubstituirAbvs(dgBaixas);

            // CultureInfo ci = new CultureInfo("pt-BR");
            //  DateTimeFormatInfo dtfi = ci.DateTimeFormat;
            // Fev 29 2024 12:00AM
            //MessageBox.Show(DateTime.Parse(dgBaixas.Rows[3].Cells[7].Value.ToString()).ToString());

            //DateTime.ParseExact(dgBaixas.Rows[1].Cells[7].Value.ToString(), "dd/MM/yyyy", ci);
            ///var d = Convert.ToDateTime("Fevereiro 29 2024 12:00AM");
           // MessageBox.Show(d.ToString());

            
        }



        public  void SubstituirAbvs(DataGridView dgBaixas)
        {
            string txtData = "";

            for (int i = 0; i < dgBaixas.RowCount; i++)
            {
                txtData = dgBaixas.Rows[i].Cells[7].Value.ToString();

                string dd = txtData[0].ToString() + txtData[1].ToString() + txtData[2].ToString();
              
                    if ("Jan" == dd)
                    {
                        dgBaixas.Rows[i].Cells[7].Value = txtData.Replace("Jan", "Janeiro");

                    }
                    else if ("Fev" == dd)
                    {
                        dgBaixas.Rows[i].Cells[7].Value = txtData.Replace("Fev", "Fevereiro");
                    }
                    else if ("Mar" == dd)
                    {
                        dgBaixas.Rows[i].Cells[7].Value = txtData.Replace("Mar", "Março");
                    }
                    else if ("Abr" == dd)
                    {
                        dgBaixas.Rows[i].Cells[7].Value = txtData.Replace("Abr", "Abril");
                    }
                    else if ("Mai" == dd)
                    {
                        dgBaixas.Rows[i].Cells[7].Value = txtData.Replace("Mai", "Maio");
                    }
                    else if ("Jun" == dd)
                    {
                        dgBaixas.Rows[i].Cells[7].Value = txtData.Replace("Jun", "Junho");
                    }
                    else if ("Jul" == dd)
                    {
                        dgBaixas.Rows[i].Cells[7].Value = txtData.Replace("Jul", "Julho");
                    }
                    else if ("Ago" == dd)
                    {
                        dgBaixas.Rows[i].Cells[7].Value = txtData.Replace("Ago", "Agosto");
                    }
                    else if ("Set" == dd)
                    {
                        dgBaixas.Rows[i].Cells[7].Value = txtData.Replace("Set", "Setembro");
                    }
                    else if ("Out" == dd)
                    {
                        dgBaixas.Rows[i].Cells[7].Value = txtData.Replace("Out", "Outubro");
                    }
                    else if ("Nov" == dd)
                    {
                        dgBaixas.Rows[i].Cells[7].Value = txtData.Replace("Nov", "Novembro");
                    }
                    else if ("Dez" == dd)
                    {
                        dgBaixas.Rows[i].Cells[7].Value = txtData.Replace("Dez", "Dezembro");
                    }
                }
               
        }
        //**********************************************************************************************************************************

    }
}


                                