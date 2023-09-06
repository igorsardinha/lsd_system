namespace lsd_system
{
    partial class frmOrdem
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            txtPesquisar = new TextBox();
            btnPesquisar = new Button();
            btnAbrir = new Button();
            btnFechar = new Button();
            dgvOrdem = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            cod_ferramenta = new DataGridViewTextBoxColumn();
            desc_ferramenta = new DataGridViewTextBoxColumn();
            funcionario = new DataGridViewTextBoxColumn();
            situacao = new DataGridViewTextBoxColumn();
            data_abertura = new DataGridViewTextBoxColumn();
            data_fechamento = new DataGridViewTextBoxColumn();
            observacao = new DataGridViewTextBoxColumn();
            menuOrdem = new ContextMenuStrip(components);
            editarOrdemDeServiçoToolStripMenuItem = new ToolStripMenuItem();
            checkFechadas = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrdem).BeginInit();
            menuOrdem.SuspendLayout();
            SuspendLayout();
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(12, 16);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pequisar ferramenta por ordem";
            txtPesquisar.Size = new Size(519, 23);
            txtPesquisar.TabIndex = 0;
            txtPesquisar.TextChanged += btnPesquisar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Image = Properties.Resources.magnifying_glass;
            btnPesquisar.Location = new Point(537, 13);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(33, 30);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnAbrir
            // 
            btnAbrir.Image = Properties.Resources.new_document1;
            btnAbrir.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbrir.Location = new Point(780, 13);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Padding = new Padding(5, 0, 0, 0);
            btnAbrir.Size = new Size(120, 33);
            btnAbrir.TabIndex = 2;
            btnAbrir.Text = "Nova OS";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // btnFechar
            // 
            btnFechar.Image = Properties.Resources.close;
            btnFechar.ImageAlign = ContentAlignment.MiddleLeft;
            btnFechar.Location = new Point(917, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Padding = new Padding(5, 0, 0, 0);
            btnFechar.Size = new Size(127, 34);
            btnFechar.TabIndex = 3;
            btnFechar.Text = "Fechar OS";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // dgvOrdem
            // 
            dgvOrdem.AllowUserToAddRows = false;
            dgvOrdem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvOrdem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvOrdem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrdem.BackgroundColor = SystemColors.Control;
            dgvOrdem.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.InfoText;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvOrdem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvOrdem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdem.Columns.AddRange(new DataGridViewColumn[] { codigo, cod_ferramenta, desc_ferramenta, funcionario, situacao, data_abertura, data_fechamento, observacao });
            dgvOrdem.ContextMenuStrip = menuOrdem;
            dgvOrdem.Cursor = Cursors.Hand;
            dgvOrdem.GridColor = SystemColors.ControlText;
            dgvOrdem.Location = new Point(12, 70);
            dgvOrdem.MultiSelect = false;
            dgvOrdem.Name = "dgvOrdem";
            dgvOrdem.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvOrdem.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvOrdem.RowHeadersVisible = false;
            dgvOrdem.RowHeadersWidth = 20;
            dgvOrdem.RowTemplate.Height = 25;
            dgvOrdem.ScrollBars = ScrollBars.Vertical;
            dgvOrdem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrdem.ShowEditingIcon = false;
            dgvOrdem.Size = new Size(1032, 324);
            dgvOrdem.TabIndex = 4;
            dgvOrdem.CellFormatting += dataGridView1_CellFormatting;
            dgvOrdem.DoubleClick += dgvOrdem_DoubleClick;
            // 
            // codigo
            // 
            codigo.DataPropertyName = "codigo";
            dataGridViewCellStyle3.BackColor = Color.Silver;
            codigo.DefaultCellStyle = dataGridViewCellStyle3;
            codigo.HeaderText = "Ordem de Serviço";
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            // 
            // cod_ferramenta
            // 
            cod_ferramenta.DataPropertyName = "cod_ferramenta";
            cod_ferramenta.HeaderText = "Código da Ferramenta";
            cod_ferramenta.Name = "cod_ferramenta";
            cod_ferramenta.ReadOnly = true;
            cod_ferramenta.Visible = false;
            // 
            // desc_ferramenta
            // 
            desc_ferramenta.DataPropertyName = "desc_ferramenta";
            desc_ferramenta.HeaderText = "Ferramenta";
            desc_ferramenta.Name = "desc_ferramenta";
            desc_ferramenta.ReadOnly = true;
            // 
            // funcionario
            // 
            funcionario.DataPropertyName = "funcionario";
            funcionario.HeaderText = "Funcionário";
            funcionario.Name = "funcionario";
            funcionario.ReadOnly = true;
            // 
            // situacao
            // 
            situacao.DataPropertyName = "situacao";
            situacao.HeaderText = "Situação";
            situacao.Name = "situacao";
            situacao.ReadOnly = true;
            // 
            // data_abertura
            // 
            data_abertura.DataPropertyName = "data_abertura";
            data_abertura.HeaderText = "Data/Hora Abertura";
            data_abertura.Name = "data_abertura";
            data_abertura.ReadOnly = true;
            // 
            // data_fechamento
            // 
            data_fechamento.DataPropertyName = "data_fechamento";
            data_fechamento.HeaderText = "Data/Hora Fechamento";
            data_fechamento.Name = "data_fechamento";
            data_fechamento.ReadOnly = true;
            // 
            // observacao
            // 
            observacao.DataPropertyName = "observacao";
            observacao.HeaderText = "Observações";
            observacao.Name = "observacao";
            observacao.ReadOnly = true;
            // 
            // menuOrdem
            // 
            menuOrdem.Items.AddRange(new ToolStripItem[] { editarOrdemDeServiçoToolStripMenuItem });
            menuOrdem.Name = "menuOrdem";
            menuOrdem.RenderMode = ToolStripRenderMode.Professional;
            menuOrdem.Size = new Size(202, 48);
            // 
            // editarOrdemDeServiçoToolStripMenuItem
            // 
            editarOrdemDeServiçoToolStripMenuItem.Name = "editarOrdemDeServiçoToolStripMenuItem";
            editarOrdemDeServiçoToolStripMenuItem.Size = new Size(201, 22);
            editarOrdemDeServiçoToolStripMenuItem.Text = "Editar Ordem de Serviço";
            editarOrdemDeServiçoToolStripMenuItem.Click += editarOrdemDeServiçoToolStripMenuItem_Click;
            // 
            // checkFechadas
            // 
            checkFechadas.AutoSize = true;
            checkFechadas.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            checkFechadas.Location = new Point(12, 45);
            checkFechadas.Name = "checkFechadas";
            checkFechadas.Size = new Size(181, 16);
            checkFechadas.TabIndex = 5;
            checkFechadas.Text = "Incluir ordens fechadas na pesquisa";
            checkFechadas.UseVisualStyleBackColor = true;
            // 
            // frmOrdem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 407);
            Controls.Add(checkFechadas);
            Controls.Add(dgvOrdem);
            Controls.Add(btnFechar);
            Controls.Add(btnAbrir);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmOrdem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ordens de Serviço";
            TopMost = true;
            Activated += frmOrdem_Load;
            Load += frmOrdem_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrdem).EndInit();
            menuOrdem.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPesquisar;
        private Button btnPesquisar;
        private Button btnAbrir;
        private Button btnFechar;
        private DataGridView dgvOrdem;
        private CheckBox checkFechadas;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn cod_ferramenta;
        private DataGridViewTextBoxColumn desc_ferramenta;
        private DataGridViewTextBoxColumn funcionario;
        private DataGridViewTextBoxColumn situacao;
        private DataGridViewTextBoxColumn data_abertura;
        private DataGridViewTextBoxColumn data_fechamento;
        private DataGridViewTextBoxColumn observacao;
        private ContextMenuStrip menuOrdem;
        private ToolStripMenuItem editarOrdemDeServiçoToolStripMenuItem;
    }
}