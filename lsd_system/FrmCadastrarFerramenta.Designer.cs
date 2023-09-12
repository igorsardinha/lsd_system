namespace lsd_system
{
    partial class FrmCadastrarFerramenta
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            txtPesquisar = new TextBox();
            btnPesquisar = new Button();
            dgvferramentas = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            descricao = new DataGridViewTextBoxColumn();
            local = new DataGridViewTextBoxColumn();
            situacao = new DataGridViewTextBoxColumn();
            lblDescricao = new Label();
            lblLocal = new Label();
            label1 = new Label();
            btnExcluir = new Button();
            btnLimpar = new Button();
            btnCadastrar = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dgvferramentas).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 382);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(313, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(348, 382);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(299, 23);
            textBox2.TabIndex = 3;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(12, 23);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Digite o nome da ferramenta";
            txtPesquisar.Size = new Size(586, 23);
            txtPesquisar.TabIndex = 4;
            txtPesquisar.TextChanged += btnPesquisar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = SystemColors.Control;
            btnPesquisar.Cursor = Cursors.Hand;
            btnPesquisar.ForeColor = SystemColors.Window;
            btnPesquisar.Image = Properties.Resources.magnifying_glass;
            btnPesquisar.Location = new Point(614, 19);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(33, 30);
            btnPesquisar.TabIndex = 5;
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // dgvferramentas
            // 
            dgvferramentas.AllowUserToAddRows = false;
            dgvferramentas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = SystemColors.GradientActiveCaption;
            dgvferramentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvferramentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvferramentas.BackgroundColor = SystemColors.Control;
            dgvferramentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvferramentas.Columns.AddRange(new DataGridViewColumn[] { codigo, descricao, local, situacao });
            dgvferramentas.Location = new Point(12, 57);
            dgvferramentas.Name = "dgvferramentas";
            dgvferramentas.ReadOnly = true;
            dgvferramentas.RowHeadersVisible = false;
            dgvferramentas.RowTemplate.Height = 25;
            dgvferramentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvferramentas.Size = new Size(635, 254);
            dgvferramentas.TabIndex = 6;
            dgvferramentas.DoubleClick += dgvferramentas_Click;
            // 
            // codigo
            // 
            codigo.DataPropertyName = "codigo";
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            // 
            // descricao
            // 
            descricao.DataPropertyName = "descricao";
            descricao.HeaderText = "Descrição";
            descricao.Name = "descricao";
            descricao.ReadOnly = true;
            // 
            // local
            // 
            local.DataPropertyName = "local";
            local.HeaderText = "Local";
            local.Name = "local";
            local.ReadOnly = true;
            // 
            // situacao
            // 
            situacao.DataPropertyName = "situacao";
            situacao.HeaderText = "Situação";
            situacao.Name = "situacao";
            situacao.ReadOnly = true;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(12, 359);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 7;
            lblDescricao.Text = "Descrição";
            // 
            // lblLocal
            // 
            lblLocal.AutoSize = true;
            lblLocal.Location = new Point(348, 359);
            lblLocal.Name = "lblLocal";
            lblLocal.Size = new Size(35, 15);
            lblLocal.TabIndex = 8;
            lblLocal.Text = "Local";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(12, 314);
            label1.Name = "label1";
            label1.Size = new Size(197, 12);
            label1.TabIndex = 22;
            label1.Text = "* Clique duas vezes para editar a ferramenta";
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = SystemColors.Control;
            btnExcluir.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnExcluir.ForeColor = SystemColors.ControlText;
            btnExcluir.Image = Properties.Resources.trash_bin;
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.Location = new Point(401, 435);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(8, 0, 0, 0);
            btnExcluir.Size = new Size(120, 45);
            btnExcluir.TabIndex = 20;
            btnExcluir.Text = "Excluir";
            toolTip1.SetToolTip(btnExcluir, "Excluir ferramenta selecionada");
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = SystemColors.Control;
            btnLimpar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpar.ForeColor = SystemColors.ControlText;
            btnLimpar.Image = Properties.Resources.cleaning;
            btnLimpar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpar.Location = new Point(263, 435);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Padding = new Padding(8, 0, 8, 0);
            btnLimpar.Size = new Size(120, 45);
            btnLimpar.TabIndex = 21;
            btnLimpar.Text = "Limpar";
            toolTip1.SetToolTip(btnLimpar, "Limpar tela");
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = SystemColors.Control;
            btnCadastrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrar.ForeColor = SystemColors.ControlText;
            btnCadastrar.Image = Properties.Resources.accept2;
            btnCadastrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastrar.Location = new Point(125, 435);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Padding = new Padding(8, 0, 8, 0);
            btnCadastrar.Size = new Size(120, 45);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.TextAlign = ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnCadastrar, "Cadastrar / Salvar Ferramenta");
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // FrmCadastrarFerramenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 502);
            Controls.Add(label1);
            Controls.Add(btnLimpar);
            Controls.Add(btnExcluir);
            Controls.Add(lblLocal);
            Controls.Add(lblDescricao);
            Controls.Add(dgvferramentas);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(textBox2);
            Controls.Add(btnCadastrar);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmCadastrarFerramenta";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ferramentas";
            TopMost = true;
            Load += FrmCadastrarFerramenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvferramentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox txtPesquisar;
        private Button btnPesquisar;
        private DataGridView dgvferramentas;
        private Label lblDescricao;
        private Label lblLocal;
        private Label label1;
        private Button btnExcluir;
        private Button btnLimpar;
        private Button btnCadastrar;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewTextBoxColumn local;
        private DataGridViewTextBoxColumn situacao;
        private ToolTip toolTip1;
    }
}