using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lsd_system
{

    public partial class FrmHome : Form
    {
        private FrmCadastrarFerramenta frmCadastrarFerramenta;

        public FrmHome()
        {
            InitializeComponent();

        }


        private void FrmHome_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;

            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {
                    //control.BackgroundImage = 
                    break;
                }
            }

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre frmSobre = new frmSobre();
            frmSobre.MdiParent = this;
            frmSobre.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarFuncionarios frmFuncions = new frmCadastrarFuncionarios();

            if (verificaSeTelaAberta("frmFuncionarios"))
            {
                frmFuncions.BringToFront();
            }
            else
            {
                frmFuncions.MdiParent = this;
                frmFuncions.Show();
            }

        }

        private void ferramentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastrarFerramenta frmCadastrarFerramenta = new FrmCadastrarFerramenta();

            if (verificaSeTelaAberta("FrmCadastrarFerramenta"))
            {
                frmCadastrarFerramenta.BringToFront();
            }
            else
            {
                frmCadastrarFerramenta.MdiParent = this;
                frmCadastrarFerramenta.Show();
            }
        }

        Boolean verificaSeTelaAberta(string nomeTela)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {

                if (frm.Name == nomeTela)
                {
                    return true;
                }
            }

            return false;
        }

        private void ordemDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrdem frmOrdem = new frmOrdem();

            if (verificaSeTelaAberta("frmOrdem"))
            {
                frmOrdem.BringToFront();
            }
            else
            {
                frmOrdem.MdiParent = this;
                frmOrdem.Show();

            }
        }

        private void fechaAppEvento(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            txtHora.Text = DateTime.Now.ToString(@"hh\:mm\:ss");

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            txtData.Text = DateTime.Today.ToString(@"dd  MMMM  yyyy");

        }

        private void FrmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
