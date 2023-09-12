namespace lsd_system
{
    partial class frmCadastrarOrdem
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
            components = new System.ComponentModel.Container();
            btnCancelar = new Button();
            btnSalvar = new Button();
            lblFerramentas = new Label();
            lblFuncionario = new Label();
            txtFerramentas = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            txtObs = new RichTextBox();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.prohibition;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(539, 328);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Padding = new Padding(5, 0, 0, 0);
            btnCancelar.Size = new Size(100, 33);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = Properties.Resources.disquete;
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(433, 328);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Padding = new Padding(5, 0, 0, 0);
            btnSalvar.Size = new Size(100, 33);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            toolTip1.SetToolTip(btnSalvar, "Salvar Ordem de Serviço");
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblFerramentas
            // 
            lblFerramentas.AutoSize = true;
            lblFerramentas.Location = new Point(19, 107);
            lblFerramentas.Name = "lblFerramentas";
            lblFerramentas.Size = new Size(72, 15);
            lblFerramentas.TabIndex = 10;
            lblFerramentas.Text = "Ferramentas";
            // 
            // lblFuncionario
            // 
            lblFuncionario.AutoSize = true;
            lblFuncionario.Location = new Point(19, 22);
            lblFuncionario.Name = "lblFuncionario";
            lblFuncionario.Size = new Size(70, 15);
            lblFuncionario.TabIndex = 9;
            lblFuncionario.Text = "Funcionário";
            // 
            // txtFerramentas
            // 
            txtFerramentas.Location = new Point(19, 129);
            txtFerramentas.Name = "txtFerramentas";
            txtFerramentas.PlaceholderText = "Clique na lupa para pesquisar uma ferramenta";
            txtFerramentas.Size = new Size(573, 23);
            txtFerramentas.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 43);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Clique na lupa para pesquisar um funcionário";
            textBox1.Size = new Size(573, 23);
            textBox1.TabIndex = 7;
            textBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.magnifying_glass;
            button1.Location = new Point(598, 39);
            button1.Name = "button1";
            button1.Size = new Size(33, 30);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.magnifying_glass;
            button2.Location = new Point(598, 125);
            button2.Name = "button2";
            button2.Size = new Size(33, 30);
            button2.TabIndex = 15;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtObs
            // 
            txtObs.AcceptsTab = true;
            txtObs.BorderStyle = BorderStyle.FixedSingle;
            txtObs.Location = new Point(19, 199);
            txtObs.Name = "txtObs";
            txtObs.Size = new Size(612, 96);
            txtObs.TabIndex = 16;
            txtObs.Text = "";
            toolTip1.SetToolTip(txtObs, "Adicionar observações da ordem de serviço");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 179);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 17;
            label1.Text = "Observações";
            // 
            // frmCadastrarOrdem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 392);
            Controls.Add(label1);
            Controls.Add(txtObs);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(lblFerramentas);
            Controls.Add(lblFuncionario);
            Controls.Add(txtFerramentas);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmCadastrarOrdem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nova Ordem de Serviço";
            Load += frmCadastrarOrdem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnSalvar;
        private Label lblFerramentas;
        private Label lblFuncionario;
        private TextBox txtFerramentas;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private RichTextBox txtObs;
        private Label label1;
        private ToolTip toolTip1;
    }
}