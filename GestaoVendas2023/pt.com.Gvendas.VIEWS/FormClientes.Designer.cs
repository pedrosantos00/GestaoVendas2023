namespace GestaoVendas2023.pt.com.Gvendas.VIEWS
{
    partial class FormClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            panel1 = new Panel();
            btnRegistrar = new Button();
            txtCod = new MaskedTextBox();
            labelPostal = new Label();
            txtPais = new MaskedTextBox();
            labelPais = new Label();
            txtCidade = new MaskedTextBox();
            labelCidade = new Label();
            txtEndereco = new MaskedTextBox();
            labelEndereco = new Label();
            txtTelm = new MaskedTextBox();
            labelTelemovel = new Label();
            txtEmail = new MaskedTextBox();
            labelEmail = new Label();
            txtProfissao = new MaskedTextBox();
            labelProfissao = new Label();
            txtNIF = new MaskedTextBox();
            labelNif = new Label();
            txtNome = new MaskedTextBox();
            labelNome = new Label();
            tabControl1 = new TabControl();
            tabClientes = new TabPage();
            tabConsulta = new TabPage();
            btnAtualizar = new Button();
            btnPesquisar = new Button();
            txtPesquisa = new MaskedTextBox();
            labelPesquisar = new Label();
            datClientes = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            labelTitle = new Label();
            pictureBox1 = new PictureBox();
            txtTitle = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabClientes.SuspendLayout();
            tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datClientes).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(txtCod);
            panel1.Controls.Add(labelPostal);
            panel1.Controls.Add(txtPais);
            panel1.Controls.Add(labelPais);
            panel1.Controls.Add(txtCidade);
            panel1.Controls.Add(labelCidade);
            panel1.Controls.Add(txtEndereco);
            panel1.Controls.Add(labelEndereco);
            panel1.Controls.Add(txtTelm);
            panel1.Controls.Add(labelTelemovel);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(labelEmail);
            panel1.Controls.Add(txtProfissao);
            panel1.Controls.Add(labelProfissao);
            panel1.Controls.Add(txtNIF);
            panel1.Controls.Add(labelNif);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(labelNome);
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(756, 306);
            panel1.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(324, 261);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(158, 23);
            btnRegistrar.TabIndex = 20;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtCod
            // 
            txtCod.Location = new Point(324, 207);
            txtCod.Mask = "0000-999";
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(158, 23);
            txtCod.TabIndex = 19;
            // 
            // labelPostal
            // 
            labelPostal.AutoSize = true;
            labelPostal.Location = new Point(324, 189);
            labelPostal.Name = "labelPostal";
            labelPostal.Size = new Size(83, 15);
            labelPostal.TabIndex = 18;
            labelPostal.Text = "Codigo-Postal";
            // 
            // txtPais
            // 
            txtPais.Location = new Point(324, 152);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(158, 23);
            txtPais.TabIndex = 17;
            // 
            // labelPais
            // 
            labelPais.AutoSize = true;
            labelPais.Location = new Point(324, 134);
            labelPais.Name = "labelPais";
            labelPais.Size = new Size(28, 15);
            labelPais.TabIndex = 16;
            labelPais.Text = "País";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(324, 88);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(158, 23);
            txtCidade.TabIndex = 13;
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.Location = new Point(324, 70);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(44, 15);
            labelCidade.TabIndex = 12;
            labelCidade.Text = "Cidade";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(324, 29);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(158, 23);
            txtEndereco.TabIndex = 11;
            // 
            // labelEndereco
            // 
            labelEndereco.AutoSize = true;
            labelEndereco.Location = new Point(324, 11);
            labelEndereco.Name = "labelEndereco";
            labelEndereco.Size = new Size(56, 15);
            labelEndereco.TabIndex = 10;
            labelEndereco.Text = "Endereco";
            // 
            // txtTelm
            // 
            txtTelm.Location = new Point(10, 207);
            txtTelm.Name = "txtTelm";
            txtTelm.Size = new Size(158, 23);
            txtTelm.TabIndex = 9;
            // 
            // labelTelemovel
            // 
            labelTelemovel.AutoSize = true;
            labelTelemovel.Location = new Point(10, 189);
            labelTelemovel.Name = "labelTelemovel";
            labelTelemovel.Size = new Size(60, 15);
            labelTelemovel.TabIndex = 8;
            labelTelemovel.Text = "Telemovel";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(10, 152);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(158, 23);
            txtEmail.TabIndex = 7;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(10, 134);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 6;
            labelEmail.Text = "Email";
            // 
            // txtProfissao
            // 
            txtProfissao.Location = new Point(10, 262);
            txtProfissao.Name = "txtProfissao";
            txtProfissao.Size = new Size(158, 23);
            txtProfissao.TabIndex = 5;
            // 
            // labelProfissao
            // 
            labelProfissao.AutoSize = true;
            labelProfissao.Location = new Point(10, 244);
            labelProfissao.Name = "labelProfissao";
            labelProfissao.Size = new Size(55, 15);
            labelProfissao.TabIndex = 4;
            labelProfissao.Text = "Profissao";
            // 
            // txtNIF
            // 
            txtNIF.Location = new Point(10, 88);
            txtNIF.Name = "txtNIF";
            txtNIF.Size = new Size(158, 23);
            txtNIF.TabIndex = 3;
            // 
            // labelNif
            // 
            labelNif.AutoSize = true;
            labelNif.Location = new Point(10, 70);
            labelNif.Name = "labelNif";
            labelNif.Size = new Size(25, 15);
            labelNif.TabIndex = 2;
            labelNif.Text = "NIF";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(10, 29);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(158, 23);
            txtNome.TabIndex = 1;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(10, 11);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabClientes);
            tabControl1.Controls.Add(tabConsulta);
            tabControl1.Location = new Point(12, 98);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 414);
            tabControl1.TabIndex = 1;
            // 
            // tabClientes
            // 
            tabClientes.Controls.Add(panel1);
            tabClientes.Location = new Point(4, 24);
            tabClientes.Name = "tabClientes";
            tabClientes.Padding = new Padding(3);
            tabClientes.Size = new Size(768, 386);
            tabClientes.TabIndex = 0;
            tabClientes.Text = "Ficha Cliente";
            tabClientes.UseVisualStyleBackColor = true;
            // 
            // tabConsulta
            // 
            tabConsulta.Controls.Add(btnAtualizar);
            tabConsulta.Controls.Add(btnPesquisar);
            tabConsulta.Controls.Add(txtPesquisa);
            tabConsulta.Controls.Add(labelPesquisar);
            tabConsulta.Controls.Add(datClientes);
            tabConsulta.Location = new Point(4, 24);
            tabConsulta.Name = "tabConsulta";
            tabConsulta.Padding = new Padding(3);
            tabConsulta.Size = new Size(768, 386);
            tabConsulta.TabIndex = 1;
            tabConsulta.Text = "Consulta";
            tabConsulta.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(684, 13);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(78, 26);
            btnAtualizar.TabIndex = 5;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(481, 13);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 26);
            btnPesquisar.TabIndex = 4;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(64, 13);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(411, 23);
            txtPesquisa.TabIndex = 3;
            txtPesquisa.TextMaskFormat = MaskFormat.IncludePrompt;
            // 
            // labelPesquisar
            // 
            labelPesquisar.AutoSize = true;
            labelPesquisar.Location = new Point(6, 16);
            labelPesquisar.Name = "labelPesquisar";
            labelPesquisar.Size = new Size(57, 15);
            labelPesquisar.TabIndex = 2;
            labelPesquisar.Text = "Pesquisar";
            // 
            // datClientes
            // 
            datClientes.AllowUserToAddRows = false;
            datClientes.AllowUserToDeleteRows = false;
            datClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datClientes.Location = new Point(6, 42);
            datClientes.Name = "datClientes";
            datClientes.ReadOnly = true;
            datClientes.Size = new Size(756, 338);
            datClientes.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(labelTitle);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(txtTitle);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 89);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(652, 3);
            label1.Name = "label1";
            label1.Size = new Size(124, 45);
            label1.TabIndex = 3;
            label1.Text = "Desenv. Software\r\n2. semestre 2024\r\nLuísa Sampaio Correia";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(390, 3);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(115, 45);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "PROGRAMAÇÃO C#\r\nexercício Sistema\r\nde Gestão de vendas\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(380, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // txtTitle
            // 
            txtTitle.AutoSize = true;
            txtTitle.Location = new Point(629, 68);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(143, 15);
            txtTitle.TabIndex = 0;
            txtTitle.Text = "PEDRO SANTOS - 2023010";
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 515);
            Controls.Add(panel2);
            Controls.Add(tabControl1);
            Name = "FormClientes";
            Text = "Gestao Vendas 2023";
            Load += FormClientes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabClientes.ResumeLayout(false);
            tabConsulta.ResumeLayout(false);
            tabConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datClientes).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelNome;
        private TabControl tabControl1;
        private TabPage tabClientes;
        private TabPage tabConsulta;
        private Panel panel2;
        private Label txtTitle;
        private MaskedTextBox txtNome;
        private Button btnPesquisar;
        private MaskedTextBox txtPesquisa;
        private Label labelPesquisar;
        private DataGridView datClientes;
        private Label label5;
        private MaskedTextBox txtTelm;
        private Label label4;
        private MaskedTextBox txtEmail;
        private MaskedTextBox txtProfissao;
        private Label label2;
        private MaskedTextBox txtNIF;
        private Label labelNif;
        private MaskedTextBox txtCod;
        private Label labelPostal;
        private MaskedTextBox txtPais;
        private Label labelPais;
        private MaskedTextBox txtCidade;
        private Label labelCidade;
        private MaskedTextBox txtEndereco;
        private Label labelProfissao;
        private Label labelTelemovel;
        private Label labelEmail;
        private Label labelEndereco;
        private Button btnRegistrar;
        private PictureBox pictureBox1;
        private Label label1;
        private Label labelTitle;
        private Button btnAtualizar;
    }
}