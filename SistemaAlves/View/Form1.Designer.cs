namespace SistemaAlves
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox1 = new PictureBox();
            btnSair_login = new Button();
            btnEntrar_login = new Button();
            label2 = new Label();
            label1 = new Label();
            txtSenha_login = new TextBox();
            txtNome_login = new TextBox();
            tabPage2 = new TabPage();
            pictureBox2 = new PictureBox();
            btnSalvar = new Button();
            label5 = new Label();
            txtConfSenha_cadastro = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtSenha_cadastro = new TextBox();
            txtNome_cadastro = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(307, 493);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(btnSair_login);
            tabPage1.Controls.Add(btnEntrar_login);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtSenha_login);
            tabPage1.Controls.Add(txtNome_login);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(299, 465);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Login";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(7, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 206);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnSair_login
            // 
            btnSair_login.Location = new Point(149, 370);
            btnSair_login.Name = "btnSair_login";
            btnSair_login.Size = new Size(110, 41);
            btnSair_login.TabIndex = 5;
            btnSair_login.Text = "Sair";
            btnSair_login.UseVisualStyleBackColor = true;
            btnSair_login.Click += btnSair_login_Click;
            // 
            // btnEntrar_login
            // 
            btnEntrar_login.Location = new Point(35, 370);
            btnEntrar_login.Name = "btnEntrar_login";
            btnEntrar_login.Size = new Size(110, 41);
            btnEntrar_login.TabIndex = 4;
            btnEntrar_login.Text = "Entrar";
            btnEntrar_login.UseVisualStyleBackColor = true;
            btnEntrar_login.Click += btnEntrar_login_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 311);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Senha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 251);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Login:";
            // 
            // txtSenha_login
            // 
            txtSenha_login.BorderStyle = BorderStyle.FixedSingle;
            txtSenha_login.Location = new Point(35, 329);
            txtSenha_login.Name = "txtSenha_login";
            txtSenha_login.Size = new Size(224, 23);
            txtSenha_login.TabIndex = 1;
            txtSenha_login.UseSystemPasswordChar = true;
            // 
            // txtNome_login
            // 
            txtNome_login.BorderStyle = BorderStyle.FixedSingle;
            txtNome_login.Location = new Point(35, 269);
            txtNome_login.Name = "txtNome_login";
            txtNome_login.Size = new Size(224, 23);
            txtNome_login.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(btnSalvar);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(txtConfSenha_cadastro);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(txtSenha_cadastro);
            tabPage2.Controls.Add(txtNome_cadastro);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(299, 465);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cadastrar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(9, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(282, 201);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(91, 402);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(110, 41);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 341);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 9;
            label5.Text = "Confirmar senha:";
            // 
            // txtConfSenha_cadastro
            // 
            txtConfSenha_cadastro.BorderStyle = BorderStyle.FixedSingle;
            txtConfSenha_cadastro.Location = new Point(38, 359);
            txtConfSenha_cadastro.Name = "txtConfSenha_cadastro";
            txtConfSenha_cadastro.Size = new Size(224, 23);
            txtConfSenha_cadastro.TabIndex = 8;
            txtConfSenha_cadastro.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 283);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 7;
            label3.Text = "Senha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 223);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 6;
            label4.Text = "Login:";
            // 
            // txtSenha_cadastro
            // 
            txtSenha_cadastro.BorderStyle = BorderStyle.FixedSingle;
            txtSenha_cadastro.Location = new Point(38, 301);
            txtSenha_cadastro.Name = "txtSenha_cadastro";
            txtSenha_cadastro.Size = new Size(224, 23);
            txtSenha_cadastro.TabIndex = 5;
            txtSenha_cadastro.UseSystemPasswordChar = true;
            // 
            // txtNome_cadastro
            // 
            txtNome_cadastro.BorderStyle = BorderStyle.FixedSingle;
            txtNome_cadastro.Location = new Point(38, 241);
            txtNome_cadastro.Name = "txtNome_cadastro";
            txtNome_cadastro.Size = new Size(224, 23);
            txtNome_cadastro.TabIndex = 4;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 496);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnSair_login;
        private Button btnEntrar_login;
        private Label label2;
        private Label label1;
        private TextBox txtSenha_login;
        private TextBox txtNome_login;
        private TabPage tabPage2;
        private PictureBox pictureBox1;
        private Label label5;
        private TextBox txtConfSenha_cadastro;
        private Label label3;
        private Label label4;
        private TextBox txtSenha_cadastro;
        private TextBox txtNome_cadastro;
        private PictureBox pictureBox2;
        private Button button1;
        private Button btnSalvar;
    }
}