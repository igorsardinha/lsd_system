namespace lsd_system
{
    partial class frmPesquisaDinamica
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
            btnPesquisar = new Button();
            txtPesquisar = new TextBox();
            dgResultado = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgResultado).BeginInit();
            SuspendLayout();
            // 
            // btnPesquisar
            // 
            btnPesquisar.Image = Properties.Resources.magnifying_glass;
            btnPesquisar.Location = new Point(598, 8);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(33, 30);
            btnPesquisar.TabIndex = 0;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(12, 12);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Digite o nome do funcionário ou ferramenta";
            txtPesquisar.Size = new Size(580, 23);
            txtPesquisar.TabIndex = 1;
            txtPesquisar.TextChanged += btnPesquisar_Click;
            // 
            // dgResultado
            // 
            dgResultado.AllowUserToAddRows = false;
            dgResultado.AllowUserToDeleteRows = false;
            dgResultado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgResultado.BackgroundColor = SystemColors.Control;
            dgResultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgResultado.Location = new Point(12, 53);
            dgResultado.Name = "dgResultado";
            dgResultado.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgResultado.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgResultado.RowHeadersVisible = false;
            dgResultado.RowTemplate.Height = 25;
            dgResultado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgResultado.ShowEditingIcon = false;
            dgResultado.Size = new Size(619, 150);
            dgResultado.TabIndex = 2;
            dgResultado.DoubleClick += dgResultado_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(12, 206);
            label1.Name = "label1";
            label1.Size = new Size(200, 12);
            label1.TabIndex = 23;
            label1.Text = "* Clique duas vezes para confirmar a seleção";
            // 
            // frmPesquisaDinamica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 237);
            Controls.Add(label1);
            Controls.Add(dgResultado);
            Controls.Add(txtPesquisar);
            Controls.Add(btnPesquisar);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "frmPesquisaDinamica";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Pesquisar";
            Load += frmPesquisaDinamica_Load;
            ((System.ComponentModel.ISupportInitialize)dgResultado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPesquisar;
        private TextBox txtPesquisar;
        private DataGridView dgResultado;
        private Label label1;
    }
}