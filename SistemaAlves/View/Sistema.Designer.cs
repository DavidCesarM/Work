namespace SistemaAlves
{
    partial class Sistema
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgTabelaDespesa = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            btnExcluirTudo_despesas = new Button();
            btnConfiguração_despesas = new Button();
            lblSalvando_despesas = new Label();
            pbCarregar_despesas = new ProgressBar();
            btnExcluir_despesa = new Button();
            groupBox2 = new GroupBox();
            lblUser = new Label();
            label9 = new Label();
            txtValorParcelas_despesas = new TextBox();
            label8 = new Label();
            txtId_despesas = new TextBox();
            txtDataAtual_despesa = new DateTimePicker();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtVencimento_despesa = new MaskedTextBox();
            label7 = new Label();
            txtGrupo_despesa = new ComboBox();
            label6 = new Label();
            txtConta_despesa = new ComboBox();
            label5 = new Label();
            txtValor_despesa = new TextBox();
            label4 = new Label();
            txtParcelas_despesa = new ComboBox();
            label3 = new Label();
            txtEntrada_despesa = new TextBox();
            label2 = new Label();
            btnSalvar_despesa = new Button();
            btnEditar_despesa = new Button();
            btnLancar_despesa = new Button();
            pictureBox1 = new PictureBox();
            tabPage2 = new TabPage();
            btnBaixa = new Button();
            dgBaixas = new DataGridView();
            Emissao = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            Parcelas = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgTabelaDespesa).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgBaixas).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1232, 718);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgTabelaDespesa);
            tabPage1.Controls.Add(btnExcluirTudo_despesas);
            tabPage1.Controls.Add(btnConfiguração_despesas);
            tabPage1.Controls.Add(lblSalvando_despesas);
            tabPage1.Controls.Add(pbCarregar_despesas);
            tabPage1.Controls.Add(btnExcluir_despesa);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(btnSalvar_despesa);
            tabPage1.Controls.Add(btnEditar_despesa);
            tabPage1.Controls.Add(btnLancar_despesa);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1224, 690);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Lançar Despesas";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgTabelaDespesa
            // 
            dgTabelaDespesa.AllowUserToAddRows = false;
            dgTabelaDespesa.AllowUserToDeleteRows = false;
            dgTabelaDespesa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgTabelaDespesa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTabelaDespesa.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column9, Column5, Column6, Column7, Column8 });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(128, 255, 128);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgTabelaDespesa.DefaultCellStyle = dataGridViewCellStyle1;
            dgTabelaDespesa.Location = new Point(8, 148);
            dgTabelaDespesa.Name = "dgTabelaDespesa";
            dgTabelaDespesa.ReadOnly = true;
            dgTabelaDespesa.RowTemplate.Height = 25;
            dgTabelaDespesa.Size = new Size(1206, 475);
            dgTabelaDespesa.TabIndex = 26;
            dgTabelaDespesa.CellDoubleClick += dgTabelaDespesa_CellDoubleClick_1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Emissão";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Valor Inicial";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Parcelas";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.HeaderText = "Valor das parcelas";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Entrada";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Grupo";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Vencimento";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Conta";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // btnExcluirTudo_despesas
            // 
            btnExcluirTudo_despesas.FlatStyle = FlatStyle.Flat;
            btnExcluirTudo_despesas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluirTudo_despesas.Location = new Point(302, 634);
            btnExcluirTudo_despesas.Name = "btnExcluirTudo_despesas";
            btnExcluirTudo_despesas.Size = new Size(116, 33);
            btnExcluirTudo_despesas.TabIndex = 25;
            btnExcluirTudo_despesas.Text = "Excluir Tudo";
            btnExcluirTudo_despesas.UseVisualStyleBackColor = true;
            btnExcluirTudo_despesas.Click += btnExcluirTudo_despesas_Click;
            // 
            // btnConfiguração_despesas
            // 
            btnConfiguração_despesas.BackgroundImage = (Image)resources.GetObject("btnConfiguração_despesas.BackgroundImage");
            btnConfiguração_despesas.BackgroundImageLayout = ImageLayout.Stretch;
            btnConfiguração_despesas.FlatStyle = FlatStyle.Flat;
            btnConfiguração_despesas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfiguração_despesas.Location = new Point(424, 634);
            btnConfiguração_despesas.Name = "btnConfiguração_despesas";
            btnConfiguração_despesas.Size = new Size(39, 33);
            btnConfiguração_despesas.TabIndex = 24;
            btnConfiguração_despesas.UseVisualStyleBackColor = true;
            btnConfiguração_despesas.Click += btnConfiguração_despesas_Click;
            // 
            // lblSalvando_despesas
            // 
            lblSalvando_despesas.AutoSize = true;
            lblSalvando_despesas.Location = new Point(990, 626);
            lblSalvando_despesas.Name = "lblSalvando_despesas";
            lblSalvando_despesas.Size = new Size(0, 15);
            lblSalvando_despesas.TabIndex = 23;
            // 
            // pbCarregar_despesas
            // 
            pbCarregar_despesas.Location = new Point(954, 644);
            pbCarregar_despesas.Name = "pbCarregar_despesas";
            pbCarregar_despesas.Size = new Size(151, 23);
            pbCarregar_despesas.TabIndex = 22;
            // 
            // btnExcluir_despesa
            // 
            btnExcluir_despesa.FlatStyle = FlatStyle.Flat;
            btnExcluir_despesa.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir_despesa.Location = new Point(204, 634);
            btnExcluir_despesa.Name = "btnExcluir_despesa";
            btnExcluir_despesa.Size = new Size(92, 33);
            btnExcluir_despesa.TabIndex = 21;
            btnExcluir_despesa.Text = "Excluir";
            btnExcluir_despesa.UseVisualStyleBackColor = true;
            btnExcluir_despesa.Click += btnExcluir_despesa_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblUser);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtValorParcelas_despesas);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtId_despesas);
            groupBox2.Controls.Add(txtDataAtual_despesa);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(8, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(636, 131);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.Location = new Point(18, 40);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(0, 20);
            lblUser.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(482, 79);
            label9.Name = "label9";
            label9.Size = new Size(119, 17);
            label9.TabIndex = 20;
            label9.Text = "Valor das Parcelas";
            // 
            // txtValorParcelas_despesas
            // 
            txtValorParcelas_despesas.BorderStyle = BorderStyle.FixedSingle;
            txtValorParcelas_despesas.Enabled = false;
            txtValorParcelas_despesas.Location = new Point(482, 102);
            txtValorParcelas_despesas.Name = "txtValorParcelas_despesas";
            txtValorParcelas_despesas.Size = new Size(134, 23);
            txtValorParcelas_despesas.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(482, 18);
            label8.Name = "label8";
            label8.Size = new Size(23, 20);
            label8.TabIndex = 21;
            label8.Text = "Id";
            // 
            // txtId_despesas
            // 
            txtId_despesas.BorderStyle = BorderStyle.FixedSingle;
            txtId_despesas.Enabled = false;
            txtId_despesas.Location = new Point(482, 41);
            txtId_despesas.Name = "txtId_despesas";
            txtId_despesas.Size = new Size(107, 23);
            txtId_despesas.TabIndex = 20;
            // 
            // txtDataAtual_despesa
            // 
            txtDataAtual_despesa.CalendarTrailingForeColor = Color.Ivory;
            txtDataAtual_despesa.Enabled = false;
            txtDataAtual_despesa.Location = new Point(18, 102);
            txtDataAtual_despesa.Name = "txtDataAtual_despesa";
            txtDataAtual_despesa.Size = new Size(229, 23);
            txtDataAtual_despesa.TabIndex = 0;
            txtDataAtual_despesa.Value = new DateTime(2023, 3, 29, 18, 53, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 80);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 12;
            label1.Text = "Emissão";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtVencimento_despesa);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtGrupo_despesa);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtConta_despesa);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtValor_despesa);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtParcelas_despesa);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtEntrada_despesa);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(650, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(416, 131);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            // 
            // txtVencimento_despesa
            // 
            txtVencimento_despesa.BorderStyle = BorderStyle.FixedSingle;
            txtVencimento_despesa.InsertKeyMode = InsertKeyMode.Insert;
            txtVencimento_despesa.Location = new Point(138, 102);
            txtVencimento_despesa.Mask = "00/00/0000";
            txtVencimento_despesa.Name = "txtVencimento_despesa";
            txtVencimento_despesa.Size = new Size(117, 23);
            txtVencimento_despesa.TabIndex = 19;
            txtVencimento_despesa.TextAlign = HorizontalAlignment.Center;
            txtVencimento_despesa.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtVencimento_despesa.ValidatingType = typeof(DateTime);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(263, 18);
            label7.Name = "label7";
            label7.Size = new Size(124, 20);
            label7.TabIndex = 18;
            label7.Text = "Valor da entrada";
            // 
            // txtGrupo_despesa
            // 
            txtGrupo_despesa.DropDownStyle = ComboBoxStyle.DropDownList;
            txtGrupo_despesa.FormattingEnabled = true;
            txtGrupo_despesa.Location = new Point(8, 102);
            txtGrupo_despesa.MaxLength = 49;
            txtGrupo_despesa.Name = "txtGrupo_despesa";
            txtGrupo_despesa.Size = new Size(121, 23);
            txtGrupo_despesa.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(135, 18);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 17;
            label6.Text = "Parcelas";
            // 
            // txtConta_despesa
            // 
            txtConta_despesa.DropDownStyle = ComboBoxStyle.DropDownList;
            txtConta_despesa.FormattingEnabled = true;
            txtConta_despesa.Location = new Point(263, 102);
            txtConta_despesa.MaxLength = 49;
            txtConta_despesa.Name = "txtConta_despesa";
            txtConta_despesa.Size = new Size(135, 23);
            txtConta_despesa.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(135, 79);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 16;
            label5.Text = "Vencimento";
            // 
            // txtValor_despesa
            // 
            txtValor_despesa.BorderStyle = BorderStyle.FixedSingle;
            txtValor_despesa.Location = new Point(8, 41);
            txtValor_despesa.MaxLength = 49;
            txtValor_despesa.Name = "txtValor_despesa";
            txtValor_despesa.Size = new Size(121, 23);
            txtValor_despesa.TabIndex = 3;
            txtValor_despesa.KeyPress += txtValor_despesa_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(8, 18);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 15;
            label4.Text = "Valor Inicial";
            // 
            // txtParcelas_despesa
            // 
            txtParcelas_despesa.DropDownStyle = ComboBoxStyle.DropDownList;
            txtParcelas_despesa.FormattingEnabled = true;
            txtParcelas_despesa.Location = new Point(135, 40);
            txtParcelas_despesa.MaxLength = 9;
            txtParcelas_despesa.Name = "txtParcelas_despesa";
            txtParcelas_despesa.Size = new Size(120, 23);
            txtParcelas_despesa.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(261, 78);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 14;
            label3.Text = "Conta";
            // 
            // txtEntrada_despesa
            // 
            txtEntrada_despesa.BorderStyle = BorderStyle.FixedSingle;
            txtEntrada_despesa.Location = new Point(263, 40);
            txtEntrada_despesa.MaxLength = 49;
            txtEntrada_despesa.Name = "txtEntrada_despesa";
            txtEntrada_despesa.Size = new Size(135, 23);
            txtEntrada_despesa.TabIndex = 6;
            txtEntrada_despesa.KeyPress += txtEntrada_despesa_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(8, 79);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 13;
            label2.Text = "Grupo";
            // 
            // btnSalvar_despesa
            // 
            btnSalvar_despesa.FlatStyle = FlatStyle.Flat;
            btnSalvar_despesa.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar_despesa.Location = new Point(1139, 634);
            btnSalvar_despesa.Name = "btnSalvar_despesa";
            btnSalvar_despesa.Size = new Size(75, 33);
            btnSalvar_despesa.TabIndex = 11;
            btnSalvar_despesa.Text = "Salvar";
            btnSalvar_despesa.UseVisualStyleBackColor = true;
            btnSalvar_despesa.Click += btnSalvar_despesa_Click;
            // 
            // btnEditar_despesa
            // 
            btnEditar_despesa.FlatStyle = FlatStyle.Flat;
            btnEditar_despesa.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar_despesa.Location = new Point(106, 634);
            btnEditar_despesa.Name = "btnEditar_despesa";
            btnEditar_despesa.Size = new Size(92, 33);
            btnEditar_despesa.TabIndex = 10;
            btnEditar_despesa.Text = "Editar";
            btnEditar_despesa.UseVisualStyleBackColor = true;
            btnEditar_despesa.Click += btnEditar_despesa_Click;
            // 
            // btnLancar_despesa
            // 
            btnLancar_despesa.FlatStyle = FlatStyle.Flat;
            btnLancar_despesa.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLancar_despesa.Location = new Point(8, 634);
            btnLancar_despesa.Name = "btnLancar_despesa";
            btnLancar_despesa.Size = new Size(92, 33);
            btnLancar_despesa.TabIndex = 9;
            btnLancar_despesa.Text = "Lancçar";
            btnLancar_despesa.UseVisualStyleBackColor = true;
            btnLancar_despesa.Click += btnLancar_despesa_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1072, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 123);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnBaixa);
            tabPage2.Controls.Add(dgBaixas);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1224, 690);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Baixas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBaixa
            // 
            btnBaixa.Location = new Point(28, 640);
            btnBaixa.Name = "btnBaixa";
            btnBaixa.Size = new Size(75, 23);
            btnBaixa.TabIndex = 1;
            btnBaixa.Text = "Dá baixa";
            btnBaixa.UseVisualStyleBackColor = true;
            btnBaixa.Click += btnBaixa_Click;
            // 
            // dgBaixas
            // 
            dgBaixas.AllowUserToAddRows = false;
            dgBaixas.AllowUserToDeleteRows = false;
            dgBaixas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgBaixas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgBaixas.Location = new Point(28, 133);
            dgBaixas.Name = "dgBaixas";
            dgBaixas.ReadOnly = true;
            dgBaixas.RowTemplate.Height = 25;
            dgBaixas.Size = new Size(1156, 501);
            dgBaixas.TabIndex = 0;
            // 
            // Emissao
            // 
            Emissao.HeaderText = "Emissão";
            Emissao.Name = "Emissao";
            // 
            // Valor
            // 
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            // 
            // Parcelas
            // 
            Parcelas.HeaderText = "Parcelas";
            Parcelas.Name = "Parcelas";
            // 
            // id
            // 
            id.HeaderText = "Id";
            id.Name = "id";
            id.Width = 145;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Emissão";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 146;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Valor";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 145;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Parcelas";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 146;
            // 
            // Sistema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 716);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Sistema";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema";
            Load += Sistema_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgTabelaDespesa).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgBaixas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSalvar_despesa;
        private Button btnEditar_despesa;
        private Button btnLancar_despesa;
        private PictureBox pictureBox1;
        private TextBox txtEntrada_despesa;
        private ComboBox txtParcelas_despesa;
        private TextBox txtValor_despesa;
        private ComboBox txtConta_despesa;
        private ComboBox txtGrupo_despesa;
        private DateTimePicker txtDataAtual_despesa;
        private GroupBox groupBox1;
        private Button btnExcluir_despesa;
        private GroupBox groupBox2;
        private DataGridViewTextBoxColumn Emissao;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Parcelas;
        private Label label8;
        private TextBox txtId_despesas;
        private ProgressBar pbCarregar_despesas;
        private Label lblSalvando_despesas;
        private MaskedTextBox txtVencimento_despesa;
        private TextBox txtValorParcelas_despesas;
        private Label label9;
        private Button btnConfiguração_despesas;
        private Button btnExcluirTudo_despesas;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridView dgTabelaDespesa;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Label lblUser;
        private Button btnBaixa;
        private DataGridView dgBaixas;
    }
}