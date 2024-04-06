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
            panel1 = new Panel();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabClientes = new TabPage();
            tabConsulta = new TabPage();
            panel2 = new Panel();
            txtTitle = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabClientes.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(765, 439);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 25);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
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
            tabConsulta.Location = new Point(4, 24);
            tabConsulta.Name = "tabConsulta";
            tabConsulta.Padding = new Padding(3);
            tabConsulta.Size = new Size(777, 387);
            tabConsulta.TabIndex = 1;
            tabConsulta.Text = "Consulta";
            tabConsulta.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(txtTitle);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 80);
            panel2.TabIndex = 2;
            // 
            // txtTitle
            // 
            txtTitle.AutoSize = true;
            txtTitle.Location = new Point(630, 65);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(143, 15);
            txtTitle.TabIndex = 0;
            txtTitle.Text = "PEDRO SANTOS - 2023010";
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 515);
            Controls.Add(panel2);
            Controls.Add(tabControl1);
            Name = "FormClientes";
            Text = "Gestao Vendas 2023";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabClientes.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabClientes;
        private TabPage tabConsulta;
        private Panel panel2;
        private Label txtTitle;
    }
}