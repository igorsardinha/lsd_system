using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lsd_system
{
    public partial class frmOrdem : Form
    {
        public frmOrdem()
        {
            InitializeComponent();
        }


        void pesquisar()
        {
            string stringConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=oficina;User ID=sa;Password=sa";

            string query = "SELECT codigo, cod_ferramenta, desc_ferramenta, funcionario, situacao, data_abertura, data_fechamento,observacao From ordens where situacao ='Aberto' order by desc_ferramenta";

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvOrdem.DataSource = dt;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow linha in dgvOrdem.Rows)
            {
                if (Convert.ToString(linha.Cells["situacao"].Value) == "Aberto")
                {
                    linha.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                if (Convert.ToString(linha.Cells["situacao"].Value) == "Fechado")
                {
                    linha.DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
        }

        public void pesquisarBox(string pesquisa)
        {
            string query;
            string stringConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=oficina;User ID=sa;Password=sa";

            if (checkFechadas.Checked)
            {
                query = "SELECT codigo, cod_ferramenta, desc_ferramenta, funcionario, situacao, data_abertura, data_fechamento,observacao From ordens where desc_ferramenta like '%" + pesquisa + "%' order by desc_ferramenta ";
            }
            else
            {
                query = "SELECT codigo, cod_ferramenta, desc_ferramenta, funcionario, situacao, data_abertura, data_fechamento,observacao From ordens where desc_ferramenta like '%" + pesquisa + "%' and situacao ='Aberto' order by desc_ferramenta";
            }

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvOrdem.DataSource = dt;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void frmOrdem_Load(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            frmCadastrarOrdem frmCadastrarOrdem = new frmCadastrarOrdem();
            FrmHome frmHome = new FrmHome();

            frmCadastrarOrdem.MdiParent = this.MdiParent;
            frmCadastrarOrdem.Show();



        }

        public void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisarBox(txtPesquisar.Text);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {

            int id = 0;
            int codFerrementa = 0;
            if (dgvOrdem.SelectedRows.Count > 0)
            {
                id = Convert.ToInt32(dgvOrdem.CurrentRow.Cells["codigo"].Value);
                codFerrementa = Convert.ToInt32(dgvOrdem.CurrentRow.Cells["cod_ferramenta"].Value);
            }

            DialogResult dialogResult = MessageBox.Show("Deseja realmente fechar a ordem selecionada?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {

                string stringConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=oficina;User ID=sa;Password=sa";

                string sql = "UPDATE ordens set situacao = 'Fechado', data_fechamento = GETDATE() where codigo = @id and situacao = 'Aberto'";

                SqlConnection conexao = new(stringConexao);
                SqlCommand comando = new(sql, conexao);
                comando.Parameters.AddWithValue("@id", id);


                try
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Ordem fechada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmCadastrarOrdem frmCadastrarOrdem = new frmCadastrarOrdem();
                    frmCadastrarOrdem.alterarStatusFerramenta(codFerrementa, "Livre");
                    pesquisarBox(txtPesquisar.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao fechar ordem: " + ex.Message, "Informação");
                }
                finally
                {
                    conexao.Close();
                }
            }



        }

        private void editarOrdemDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditarOS frmEditarOS = new FrmEditarOS();


            if (dgvOrdem.SelectedRows.Count > 0)
            {
                frmEditarOS.idOrdem = Convert.ToInt32(dgvOrdem.CurrentRow.Cells["codigo"].Value);

            }
            frmEditarOS.ShowDialog();
        }

    }
}
