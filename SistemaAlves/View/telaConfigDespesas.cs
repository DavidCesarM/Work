using SistemaAlves.Controler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAlves.View
{
    public partial class telaConfigDespesas : Form
    {
        public telaConfigDespesas()
        {
            InitializeComponent();
        }

        private ComboBox conta, parcela, grupo;
        SystemControler sc = new SystemControler();

        public telaConfigDespesas(ComboBox conta, ComboBox parcelas, ComboBox grupo)
        {

            this.conta = conta;
            this.parcela = parcelas;
            this.grupo = grupo;
            InitializeComponent();

        }

        private void btnAdicionar_despesas_Click(object sender, EventArgs e)
        {
         
            //this.conta.Items.Clear();

            sc.addItemsAosComboBoxDespesas(txtAdd_combobox, cbItems_combobox);
            sc.PreencheComboBoxesDespesa(conta, grupo, parcela);
            sc.visualizarItems(dgVizualizarItens_combobox, cbItems_combobox);

        }

        private void dgVizualizarItens_combobox_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            sc.puxarInfoNoClique(dgVizualizarItens_combobox, txtAdd_combobox);
        }

        private void btnEditar_combobox_Click(object sender, EventArgs e)
        {
     
           // this.conta.Items.Clear();

            sc.EditarItensDoComboBox(txtAdd_combobox, cbItems_combobox, dgVizualizarItens_combobox);
            sc.PreencheComboBoxesDespesa(conta, grupo, parcela);
            sc.visualizarItems(dgVizualizarItens_combobox, cbItems_combobox);
        }

        private void btnExcluir_combobox_Click(object sender, EventArgs e)
        {
            
           // this.conta.Items.Clear();

            sc.ExcluirItemDoComboBox(txtAdd_combobox, cbItems_combobox, dgVizualizarItens_combobox);
            sc.PreencheComboBoxesDespesa(conta, grupo, parcela);
            sc.visualizarItems(dgVizualizarItens_combobox, cbItems_combobox);
        }



        private void cbItems_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sc.visualizarItems(dgVizualizarItens_combobox, cbItems_combobox);
        }
    }
}
