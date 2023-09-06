namespace lsd_system
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            menuStrip1 = new MenuStrip();
            arquivoMenu = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            cadastroMenu = new ToolStripMenuItem();
            funcionáriosToolStripMenuItem = new ToolStripMenuItem();
            ferramentasToolStripMenuItem = new ToolStripMenuItem();
            OrdemToolStripMenuItem = new ToolStripMenuItem();
            abrirOrdemToolStripMenuItem = new ToolStripMenuItem();
            relatórioToolStripMenuItem = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            txtHora = new Label();
            timer4 = new System.Windows.Forms.Timer(components);
            toolStrip1 = new ToolStrip();
            funcSubMenu = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            ferraSubMenu = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            OSSubMenu = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            txtData = new Label();
            timer5 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoMenu, cadastroMenu, OrdemToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1201, 30);
            menuStrip1.TabIndex = 22;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoMenu
            // 
            arquivoMenu.DropDownItems.AddRange(new ToolStripItem[] { sobreToolStripMenuItem, sairToolStripMenuItem });
            arquivoMenu.Name = "arquivoMenu";
            arquivoMenu.Size = new Size(73, 24);
            arquivoMenu.Text = "Arquivo";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(117, 24);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(117, 24);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // cadastroMenu
            // 
            cadastroMenu.DropDownItems.AddRange(new ToolStripItem[] { funcionáriosToolStripMenuItem, ferramentasToolStripMenuItem });
            cadastroMenu.Name = "cadastroMenu";
            cadastroMenu.Size = new Size(80, 24);
            cadastroMenu.Text = "Cadastro";
            // 
            // funcionáriosToolStripMenuItem
            // 
            funcionáriosToolStripMenuItem.Image = Properties.Resources.businessman;
            funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            funcionáriosToolStripMenuItem.Size = new Size(161, 24);
            funcionáriosToolStripMenuItem.Text = "Funcionários";
            funcionáriosToolStripMenuItem.Click += funcionáriosToolStripMenuItem_Click;
            // 
            // ferramentasToolStripMenuItem
            // 
            ferramentasToolStripMenuItem.Image = Properties.Resources.tool_box;
            ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            ferramentasToolStripMenuItem.Size = new Size(161, 24);
            ferramentasToolStripMenuItem.Text = "Ferramentas";
            ferramentasToolStripMenuItem.Click += ferramentasToolStripMenuItem_Click;
            // 
            // OrdemToolStripMenuItem
            // 
            OrdemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirOrdemToolStripMenuItem, relatórioToolStripMenuItem });
            OrdemToolStripMenuItem.Name = "OrdemToolStripMenuItem";
            OrdemToolStripMenuItem.Size = new Size(140, 24);
            OrdemToolStripMenuItem.Text = "Ordem de Serviço";
            // 
            // abrirOrdemToolStripMenuItem
            // 
            abrirOrdemToolStripMenuItem.Image = Properties.Resources.checklist;
            abrirOrdemToolStripMenuItem.Name = "abrirOrdemToolStripMenuItem";
            abrirOrdemToolStripMenuItem.Size = new Size(161, 24);
            abrirOrdemToolStripMenuItem.Text = "Abrir Ordem";
            abrirOrdemToolStripMenuItem.Click += ordemDeServiçoToolStripMenuItem_Click;
            // 
            // relatórioToolStripMenuItem
            // 
            relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            relatórioToolStripMenuItem.Size = new Size(161, 24);
            relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // txtHora
            // 
            txtHora.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtHora.AutoSize = true;
            txtHora.BackColor = Color.Transparent;
            txtHora.Font = new Font("Segoe UI Semibold", 62F, FontStyle.Bold, GraphicsUnit.Point);
            txtHora.ForeColor = Color.Black;
            txtHora.Location = new Point(24, 486);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(363, 110);
            txtHora.TabIndex = 23;
            txtHora.Text = "00:00:00";
            // 
            // timer4
            // 
            timer4.Enabled = true;
            timer4.Tick += timer4_Tick;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { funcSubMenu, toolStripSeparator1, ferraSubMenu, toolStripSeparator2, OSSubMenu });
            toolStrip1.Location = new Point(0, 30);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1201, 54);
            toolStrip1.TabIndex = 24;
            toolStrip1.Text = "toolStrip1";
            // 
            // funcSubMenu
            // 
            funcSubMenu.BackgroundImageLayout = ImageLayout.Stretch;
            funcSubMenu.Image = Properties.Resources.businessman;
            funcSubMenu.ImageScaling = ToolStripItemImageScaling.None;
            funcSubMenu.ImageTransparentColor = Color.Magenta;
            funcSubMenu.Name = "funcSubMenu";
            funcSubMenu.Size = new Size(74, 51);
            funcSubMenu.Text = "Funcionário";
            funcSubMenu.TextAlign = ContentAlignment.BottomCenter;
            funcSubMenu.TextImageRelation = TextImageRelation.ImageAboveText;
            funcSubMenu.Click += funcionáriosToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 54);
            // 
            // ferraSubMenu
            // 
            ferraSubMenu.Image = Properties.Resources.tool_box;
            ferraSubMenu.ImageScaling = ToolStripItemImageScaling.None;
            ferraSubMenu.ImageTransparentColor = Color.Magenta;
            ferraSubMenu.Name = "ferraSubMenu";
            ferraSubMenu.Size = new Size(71, 51);
            ferraSubMenu.Text = "Ferramenta";
            ferraSubMenu.TextAlign = ContentAlignment.BottomCenter;
            ferraSubMenu.TextImageRelation = TextImageRelation.ImageAboveText;
            ferraSubMenu.Click += ferramentasToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 54);
            // 
            // OSSubMenu
            // 
            OSSubMenu.Image = Properties.Resources.checklist;
            OSSubMenu.ImageScaling = ToolStripItemImageScaling.None;
            OSSubMenu.ImageTransparentColor = Color.Magenta;
            OSSubMenu.Name = "OSSubMenu";
            OSSubMenu.Size = new Size(105, 51);
            OSSubMenu.Text = "Ordem de Serviço";
            OSSubMenu.TextImageRelation = TextImageRelation.ImageAboveText;
            OSSubMenu.Click += ordemDeServiçoToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 651);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1201, 22);
            statusStrip1.TabIndex = 25;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(104, 17);
            toolStripStatusLabel1.Text = "Versão: 1.0 - Alpha";
            // 
            // txtData
            // 
            txtData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtData.AutoSize = true;
            txtData.BackColor = Color.Transparent;
            txtData.Font = new Font("Segoe UI Semibold", 28F, FontStyle.Bold, GraphicsUnit.Point);
            txtData.ForeColor = Color.Black;
            txtData.Location = new Point(48, 588);
            txtData.Name = "txtData";
            txtData.Size = new Size(275, 51);
            txtData.TabIndex = 26;
            txtData.Text = "01 janeiro 1900";
            txtData.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timer5
            // 
            timer5.Enabled = true;
            timer5.Tick += timer5_Tick;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.foiceMartelo_removebg_preview;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1201, 673);
            Controls.Add(txtData);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(txtHora);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LsDSystems - Gerenciamento de Ferramentas";
            WindowState = FormWindowState.Maximized;
            FormClosed += FrmHome_FormClosed;
            Load += FrmHome_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoMenu;
        private ToolStripMenuItem cadastroMenu;
        private ToolStripMenuItem OrdemToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem funcionáriosToolStripMenuItem;
        private ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private ToolStripMenuItem abrirOrdemToolStripMenuItem;
        private ToolStripMenuItem relatórioToolStripMenuItem;
        private Label txtHora;
        private System.Windows.Forms.Timer timer4;
        private ToolStrip toolStrip1;
        private ToolStripButton funcSubMenu;
        private ToolStripButton ferraSubMenu;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton OSSubMenu;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Label txtData;
        private System.Windows.Forms.Timer timer5;
    }
}