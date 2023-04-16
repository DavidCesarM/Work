using SistemaAlves.Controler;
using SistemaAlves.Model;
using SistemaAlves.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAlves
{
    public partial class Sistema : Form
    {
        SystemControler sc = new SystemControler();
        telaConfigDespesas tlConfigDespesas = new telaConfigDespesas();
        Usuario u = new Usuario();
        private string nome;
        public Sistema()
        {
            InitializeComponent();
        }

        public Sistema(string nome)
        {
            this.nome = nome;
            InitializeComponent();
        }
        private void btnLancar_despesa_Click(object sender, EventArgs e)
        {

            sc.Lançar(dgTabelaDespesa, txtValorParcelas_despesas, txtDataAtual_despesa.Text, txtValor_despesa.Text, txtParcelas_despesa.Text, txtEntrada_despesa.Text, txtGrupo_despesa.Text, txtVencimento_despesa, txtConta_despesa.Text, txtId_despesas);


            if (sc.clear)
            {
                txtParcelas_despesa.SelectedIndex = -1;
                txtEntrada_despesa.Text = "";
                txtGrupo_despesa.SelectedIndex = -1;
                txtVencimento_despesa.Text = "";
                txtConta_despesa.SelectedIndex = -1;
                txtValor_despesa.Text = "";
                txtId_despesas.Text = "";

            }
        }

        private void btnEditar_despesa_Click(object sender, EventArgs e)
        {
            //txtVencimento_despesa.TextMaskFormat = MaskFormat.IncludeLiterals;
            sc.Editar(dgTabelaDespesa, txtDataAtual_despesa.Text, txtValor_despesa.Text, txtParcelas_despesa.Text, txtEntrada_despesa.Text, txtGrupo_despesa.Text, txtVencimento_despesa, txtConta_despesa.Text);


            txtVencimento_despesa.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }
        private void btnExcluir_despesa_Click(object sender, EventArgs e)
        {
            sc.Excluir(dgTabelaDespesa);
            if (sc.clear)
            {
                txtParcelas_despesa.SelectedIndex = -1;
                txtEntrada_despesa.Text = "";
                txtGrupo_despesa.SelectedIndex = -1;
                txtVencimento_despesa.Text = "";
                txtConta_despesa.SelectedIndex = -1;
                txtValor_despesa.Text = "";
                txtId_despesas.Text = "";

            }

        }
        private void btnSalvar_despesa_Click(object sender, EventArgs e)
        {
            sc.Salvar(dgTabelaDespesa, pbCarregar_despesas, lblSalvando_despesas, nome);
            sc.exibirBancoDgBaixas(dgBaixas);

            if (sc.clear)
            {
                txtParcelas_despesa.SelectedIndex = -1;
                txtEntrada_despesa.Text = "";
                txtGrupo_despesa.SelectedIndex = -1;
                txtVencimento_despesa.Text = "";
                txtConta_despesa.SelectedIndex = -1;
                txtValor_despesa.Text = "";
                txtId_despesas.Text = "";


            }

        }
        private void btnConfiguração_despesas_Click(object sender, EventArgs e)
        {
            telaConfigDespesas tlConfig = new telaConfigDespesas(txtConta_despesa, txtParcelas_despesa, txtGrupo_despesa);
            tlConfig.ShowDialog();
        }
        private void Sistema_Load(object sender, EventArgs e)
        {
            sc.PreencheComboBoxesDespesa(txtConta_despesa, txtGrupo_despesa, txtParcelas_despesa);
            lblUser.Text = this.nome;
            sc.exibirBancoDgBaixas(dgBaixas);
        }

        private void txtValor_despesa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.decNumber(sender, e);

        }

        private void txtEntrada_despesa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.decNumber(sender, e);
        }

        private void btnExcluirTudo_despesas_Click(object sender, EventArgs e)
        {
            sc.ExcluirTudo(dgTabelaDespesa);
            if (sc.clear)
            {
                txtParcelas_despesa.SelectedIndex = -1;
                txtEntrada_despesa.Text = "";
                txtGrupo_despesa.SelectedIndex = -1;
                txtVencimento_despesa.Text = "";
                txtConta_despesa.SelectedIndex = -1;
                txtValor_despesa.Text = "";
                txtId_despesas.Text = "";
                txtValorParcelas_despesas.Text = "";
            }

        }

        private void dgTabelaDespesa_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            sc.PuxarInfoAoClicar(txtId_despesas, dgTabelaDespesa, txtDataAtual_despesa, txtValor_despesa, txtParcelas_despesa, txtEntrada_despesa, txtGrupo_despesa, txtVencimento_despesa, txtConta_despesa, txtValorParcelas_despesas);
        }

        private void btnBaixa_Click(object sender, EventArgs e)
        {

        }
    }
}

