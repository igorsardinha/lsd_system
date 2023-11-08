namespace lsd_system
{
    partial class frmCadastrarFuncionarios
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pageSetupDialog1 = new PageSetupDialog();
            lblFuncao = new Label();
            lblFuncionario = new Label();
            dgvFuncionario = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            funcionario = new DataGridViewTextBoxColumn();
            funcao = new DataGridViewTextBoxColumn();
            btnPesquisar = new Button();
            txtPesquisar = new TextBox();
            txtFuncao = new TextBox();
            btnCadastrar = new Button();
            txtFuncionario = new TextBox();
            btnExcluir = new Button();
            btnLimpar = new Button();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dgvFuncionario).BeginInit();
            SuspendLayout();
            // 
            // lblFuncao
            // 
            lblFuncao.AutoSize = true;
            lblFuncao.Location = new Point(342, 362);
            lblFuncao.Name = "lblFuncao";
            lblFuncao.Size = new Size(46, 15);
            lblFuncao.TabIndex = 17;
            lblFuncao.Text = "Função";
            // 
            // lblFuncionario
            // 
            lblFuncionario.AutoSize = true;
            lblFuncionario.Location = new Point(11, 362);
            lblFuncionario.Name = "lblFuncionario";
            lblFuncionario.Size = new Size(123, 15);
            lblFuncionario.TabIndex = 16;
            lblFuncionario.Text = "Nome do Funcionário";
            // 
            // dgvFuncionario
            // 
            dgvFuncionario.AllowUserToAddRows = false;
            dgvFuncionario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.GradientActiveCaption;
            dgvFuncionario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvFuncionario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFuncionario.BackgroundColor = SystemColors.Control;
            dgvFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncionario.Columns.AddRange(new DataGridViewColumn[] { codigo, funcionario, funcao });
            dgvFuncionario.Location = new Point(11, 57);
            dgvFuncionario.Name = "dgvFuncionario";
            dgvFuncionario.ReadOnly = true;
            dgvFuncionario.RowHeadersVisible = false;
            dgvFuncionario.RowTemplate.Height = 25;
            dgvFuncionario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFuncionario.Size = new Size(630, 258);
            dgvFuncionario.TabIndex = 15;
            dgvFuncionario.DoubleClick += dgvFuncionario_Click;
            // 
            // codigo
            // 
            codigo.DataPropertyName = "codigo";
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            // 
            // funcionario
            // 
            funcionario.DataPropertyName = "funcionario";
            funcionario.HeaderText = "Funcionário";
            funcionario.Name = "funcionario";
            funcionario.ReadOnly = true;
            // 
            // funcao
            // 
            funcao.DataPropertyName = "funcao";
            funcao.HeaderText = "Função";
            funcao.Name = "funcao";
            funcao.ReadOnly = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = SystemColors.Control;
            btnPesquisar.Cursor = Cursors.Hand;
            btnPesquisar.ForeColor = SystemColors.ControlText;
            btnPesquisar.Image = Properties.Resources.magnifying_glass;
            btnPesquisar.Location = new Point(608, 16);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(33, 30);
            btnPesquisar.TabIndex = 14;
            btnPesquisar.TabStop = false;
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(11, 20);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Digite o nome do funcionário";
            txtPesquisar.Size = new Size(579, 23);
            txtPesquisar.TabIndex = 13;
            txtPesquisar.TextChanged += btnPesquisar_Click;
            // 
            // txtFuncao
            // 
            txtFuncao.Location = new Point(342, 382);
            txtFuncao.Name = "txtFuncao";
            txtFuncao.Size = new Size(299, 23);
            txtFuncao.TabIndex = 12;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = SystemColors.Control;
            btnCadastrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrar.ForeColor = SystemColors.ControlText;
            btnCadastrar.Image = Properties.Resources.accept2;
            btnCadastrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastrar.Location = new Point(119, 423);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Padding = new Padding(8, 0, 8, 0);
            btnCadastrar.Size = new Size(120, 45);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.TextAlign = ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnCadastrar, "Cadastrar / Salvar Funcionário");
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtFuncionario
            // 
            txtFuncionario.Location = new Point(11, 382);
            txtFuncionario.Name = "txtFuncionario";
            txtFuncionario.Size = new Size(313, 23);
            txtFuncionario.TabIndex = 10;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = SystemColors.Control;
            btnExcluir.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnExcluir.ForeColor = SystemColors.ControlText;
            btnExcluir.Image = Properties.Resources.trash_bin;
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.Location = new Point(397, 423);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(8, 0, 0, 0);
            btnExcluir.Size = new Size(120, 45);
            btnExcluir.TabIndex = 18;
            btnExcluir.Text = "Excluir";
            toolTip1.SetToolTip(btnExcluir, "Excluir ferramenta");
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
            btnLimpar.Location = new Point(258, 423);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Padding = new Padding(8, 0, 0, 0);
            btnLimpar.Size = new Size(120, 45);
            btnLimpar.TabIndex = 19;
            btnLimpar.Text = "Limpar";
            toolTip1.SetToolTip(btnLimpar, "Limpar Tela");
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(12, 318);
            label1.Name = "label1";
            label1.Size = new Size(201, 12);
            label1.TabIndex = 20;
            label1.Text = "* Clique duas vezes para editar o funcionário";
            // 
            // frmCadastrarFuncionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 490);
            Controls.Add(label1);
            Controls.Add(btnLimpar);
            Controls.Add(btnExcluir);
            Controls.Add(lblFuncao);
            Controls.Add(lblFuncionario);
            Controls.Add(dgvFuncionario);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(txtFuncao);
            Controls.Add(btnCadastrar);
            Controls.Add(txtFuncionario);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmCadastrarFuncionarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Funcionários";
            TopMost = true;
            Load += frmFuncionarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFuncionario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PageSetupDialog pageSetupDialog1;
        private Label lblFuncao;
        private Label lblFuncionario;
        private DataGridView dgvFuncionario;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn funcionario;
        private DataGridViewTextBoxColumn funcao;
        private Button btnPesquisar;
        private TextBox txtPesquisar;
        private TextBox txtFuncao;
        private Button btnCadastrar;
        private TextBox txtFuncionario;
        private Button btnExcluir;
        private CheckBox checkEditar;
        private Button btnLimpar;
        private Label label1;
        private ToolTip toolTip1;
    }
}