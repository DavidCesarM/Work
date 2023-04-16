namespace SistemaAlves.View
{
    partial class telaConfigDespesas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaConfigDespesas));
            btnAdicionar_combobox = new Button();
            btnExcluir_combobox = new Button();
            btnEditar_combobox = new Button();
            txtAdd_combobox = new TextBox();
            dgVizualizarItens_combobox = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            cbItems_combobox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgVizualizarItens_combobox).BeginInit();
            SuspendLayout();
            // 
            // btnAdicionar_combobox
            // 
            btnAdicionar_combobox.BackgroundImage = (Image)resources.GetObject("btnAdicionar_combobox.BackgroundImage");
            btnAdicionar_combobox.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdicionar_combobox.Location = new Point(139, 25);
            btnAdicionar_combobox.Name = "btnAdicionar_combobox";
            btnAdicionar_combobox.Size = new Size(35, 35);
            btnAdicionar_combobox.TabIndex = 1;
            btnAdicionar_combobox.UseVisualStyleBackColor = true;
            btnAdicionar_combobox.Click += btnAdicionar_despesas_Click;
            // 
            // btnExcluir_combobox
            // 
            btnExcluir_combobox.BackgroundImage = (Image)resources.GetObject("btnExcluir_combobox.BackgroundImage");
            btnExcluir_combobox.BackgroundImageLayout = ImageLayout.Stretch;
            btnExcluir_combobox.Location = new Point(12, 477);
            btnExcluir_combobox.Name = "btnExcluir_combobox";
            btnExcluir_combobox.Size = new Size(35, 35);
            btnExcluir_combobox.TabIndex = 7;
            btnExcluir_combobox.UseVisualStyleBackColor = true;
            btnExcluir_combobox.Click += btnExcluir_combobox_Click;
            // 
            // btnEditar_combobox
            // 
            btnEditar_combobox.BackgroundImage = (Image)resources.GetObject("btnEditar_combobox.BackgroundImage");
            btnEditar_combobox.BackgroundImageLayout = ImageLayout.Stretch;
            btnEditar_combobox.Location = new Point(49, 477);
            btnEditar_combobox.Name = "btnEditar_combobox";
            btnEditar_combobox.Size = new Size(35, 35);
            btnEditar_combobox.TabIndex = 10;
            btnEditar_combobox.UseVisualStyleBackColor = true;
            btnEditar_combobox.Click += btnEditar_combobox_Click;
            // 
            // txtAdd_combobox
            // 
            txtAdd_combobox.BorderStyle = BorderStyle.FixedSingle;
            txtAdd_combobox.Location = new Point(12, 66);
            txtAdd_combobox.MaxLength = 49;
            txtAdd_combobox.Multiline = true;
            txtAdd_combobox.Name = "txtAdd_combobox";
            txtAdd_combobox.Size = new Size(584, 30);
            txtAdd_combobox.TabIndex = 12;
            // 
            // dgVizualizarItens_combobox
            // 
            dgVizualizarItens_combobox.AllowUserToAddRows = false;
            dgVizualizarItens_combobox.AllowUserToDeleteRows = false;
            dgVizualizarItens_combobox.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgVizualizarItens_combobox.BackgroundColor = SystemColors.ControlLightLight;
            dgVizualizarItens_combobox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVizualizarItens_combobox.Location = new Point(8, 186);
            dgVizualizarItens_combobox.Name = "dgVizualizarItens_combobox";
            dgVizualizarItens_combobox.ReadOnly = true;
            dgVizualizarItens_combobox.RowTemplate.Height = 25;
            dgVizualizarItens_combobox.Size = new Size(588, 285);
            dgVizualizarItens_combobox.TabIndex = 13;
            dgVizualizarItens_combobox.CellDoubleClick += dgVizualizarItens_combobox_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 14;
            label1.Text = "Adicionar Items";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 165);
            label2.Name = "label2";
            label2.Size = new Size(167, 15);
            label2.TabIndex = 15;
            label2.Text = "Visualizar items já adicionados";
            // 
            // cbItems_combobox
            // 
            cbItems_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            cbItems_combobox.FormattingEnabled = true;
            cbItems_combobox.Items.AddRange(new object[] { "Grupo", "Parcelas", "Conta" });
            cbItems_combobox.Location = new Point(13, 37);
            cbItems_combobox.MaxLength = 9;
            cbItems_combobox.Name = "cbItems_combobox";
            cbItems_combobox.Size = new Size(120, 23);
            cbItems_combobox.TabIndex = 16;
            cbItems_combobox.SelectedIndexChanged += cbItems_combobox_SelectedIndexChanged;
            // 
            // telaConfigDespesas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 522);
            Controls.Add(cbItems_combobox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgVizualizarItens_combobox);
            Controls.Add(txtAdd_combobox);
            Controls.Add(btnEditar_combobox);
            Controls.Add(btnExcluir_combobox);
            Controls.Add(btnAdicionar_combobox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "telaConfigDespesas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configurações";
            ((System.ComponentModel.ISupportInitialize)dgVizualizarItens_combobox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdicionar_combobox;
        private Button btnExcluir_combobox;
        private PictureBox pictureBox1;
        private Button btnEditar_combobox;
        private TextBox txtAdd_combobox;
        private DataGridView dgVizualizarItens_combobox;
        private Label label1;
        private Label label2;
        private ComboBox cbItems_combobox;
    }
}