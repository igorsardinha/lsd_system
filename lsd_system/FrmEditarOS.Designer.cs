namespace lsd_system
{
    partial class FrmEditarOS
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
            lblCod = new Label();
            txtCodOS = new TextBox();
            txtFunc = new TextBox();
            label2 = new Label();
            txtFerramenta = new TextBox();
            label3 = new Label();
            label1 = new Label();
            txtObs = new RichTextBox();
            btnSalvar = new Button();
            chkReabrir = new CheckBox();
            SuspendLayout();
            // 
            // lblCod
            // 
            lblCod.AutoSize = true;
            lblCod.Location = new Point(21, 9);
            lblCod.Name = "lblCod";
            lblCod.Size = new Size(44, 15);
            lblCod.TabIndex = 0;
            lblCod.Text = "Ordem";
            // 
            // txtCodOS
            // 
            txtCodOS.Location = new Point(21, 27);
            txtCodOS.Name = "txtCodOS";
            txtCodOS.Size = new Size(61, 23);
            txtCodOS.TabIndex = 1;
            txtCodOS.TextChanged += txtCodOS_TextChanged;
            // 
            // txtFunc
            // 
            txtFunc.Location = new Point(107, 27);
            txtFunc.Name = "txtFunc";
            txtFunc.ReadOnly = true;
            txtFunc.Size = new Size(244, 23);
            txtFunc.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 9);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 2;
            label2.Text = "Funcionário";
            // 
            // txtFerramenta
            // 
            txtFerramenta.Location = new Point(369, 27);
            txtFerramenta.Name = "txtFerramenta";
            txtFerramenta.ReadOnly = true;
            txtFerramenta.Size = new Size(244, 23);
            txtFerramenta.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(369, 9);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 4;
            label3.Text = "Ferramenta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 74);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 6;
            label1.Text = "Observações";
            // 
            // txtObs
            // 
            txtObs.Location = new Point(21, 92);
            txtObs.Name = "txtObs";
            txtObs.Size = new Size(592, 96);
            txtObs.TabIndex = 7;
            txtObs.Text = "";
            // 
            // btnSalvar
            // 
            btnSalvar.Image = Properties.Resources.disquete;
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(513, 200);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Padding = new Padding(5, 0, 0, 0);
            btnSalvar.Size = new Size(100, 33);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // chkReabrir
            // 
            chkReabrir.AutoSize = true;
            chkReabrir.Location = new Point(346, 208);
            chkReabrir.Name = "chkReabrir";
            chkReabrir.Size = new Size(161, 19);
            chkReabrir.TabIndex = 15;
            chkReabrir.Text = "Reabrir Ordem Fechada  ?";
            chkReabrir.UseVisualStyleBackColor = true;
            // 
            // FrmEditarOS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 245);
            Controls.Add(chkReabrir);
            Controls.Add(btnSalvar);
            Controls.Add(txtObs);
            Controls.Add(label1);
            Controls.Add(txtFerramenta);
            Controls.Add(label3);
            Controls.Add(txtFunc);
            Controls.Add(label2);
            Controls.Add(txtCodOS);
            Controls.Add(lblCod);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmEditarOS";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Editar Ordem de Serviço";
            FormClosed += FrmEditarOS_FormClosed;
            Load += FrmEditarOS_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCod;
        private TextBox txtCodOS;
        private TextBox txtFunc;
        private Label label2;
        private TextBox txtFerramenta;
        private Label label3;
        private Label label1;
        private RichTextBox txtObs;
        private Button btnSalvar;
        private CheckBox chkReabrir;
    }
}