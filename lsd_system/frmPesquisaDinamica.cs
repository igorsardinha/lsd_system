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


    public partial class frmPesquisaDinamica : Form
    {
        public frmPesquisaDinamica()
        {
            InitializeComponent();
        }
        public int tipoPesquisa = 1;
        //1 = Funcionario
        //2 = Ferramenta

        public int codigoFerramenta;
        public string nomeFuncionario;
        public string nomeFerramenta;

        private void frmPesquisaDinamica_Load(object sender, EventArgs e)
        {
            abrirPesquisa(tipoPesquisa);
        }

        public void abrirPesquisa(int tipoPesquisa)
        {
            if (tipoPesquisa == 1)
            {
                dgResultado.Columns.Add("codigo", "Código");
                dgResultado.Columns[0].DataPropertyName = "codigo";
                dgResultado.Columns.Add("funcionario", "Funcionário");
                dgResultado.Columns[1].DataPropertyName = "funcionario";
                dgResultado.Columns.Add("funcao", "Função");
                dgResultado.Columns[2].DataPropertyName = "funcao";

                string stringConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=oficina;User ID=sa;Password=sa";

                string query = "SELECT codigo, funcionario, funcao From funcionarios WHERE funcionario LIKE '%" + txtPesquisar.Text + "%'";

                SqlConnection connection = new SqlConnection(stringConexao);
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgResultado.DataSource = dt;
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
            if (tipoPesquisa == 2)
            {

                dgResultado.Columns.Add("codigo", "Código");
                dgResultado.Columns[0].DataPropertyName = "codigo";
                dgResultado.Columns.Add("descricao", "Descrição");
                dgResultado.Columns[1].DataPropertyName = "descricao";
                dgResultado.Columns.Add("local", "Local");
                dgResultado.Columns[2].DataPropertyName = "local";

                string stringConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=oficina;User ID=sa;Password=sa";

                string query = "SELECT codigo, descricao, local From ferramentas WHERE situacao = 'Livre' and descricao LIKE '%" + txtPesquisar.Text + "%'";

                SqlConnection connection = new SqlConnection(stringConexao);
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgResultado.DataSource = dt;
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
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisarClicando();
        }

        public void pesquisarClicando()
        {
            if (tipoPesquisa == 1)
            {
                string stringConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=oficina;User ID=sa;Password=sa";

                string query = "SELECT codigo, funcionario, funcao From funcionarios WHERE funcionario LIKE '%" + txtPesquisar.Text + "%'";

                SqlConnection connection = new SqlConnection(stringConexao);
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgResultado.DataSource = dt;
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
            if (tipoPesquisa == 2)
            {

                string stringConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=oficina;User ID=sa;Password=sa";

                string query = "SELECT codigo, descricao, local From ferramentas WHERE descricao LIKE '%" + txtPesquisar.Text + "%'";

                SqlConnection connection = new SqlConnection(stringConexao);
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgResultado.DataSource = dt;
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
        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            pesquisarClicando();
        }

        private void dgResultado_DoubleClick(object sender, EventArgs e)
        {
            if (tipoPesquisa == 1)
            {
                if (dgResultado.SelectedRows.Count > 0)
                {
                    
                    nomeFuncionario = dgResultado.CurrentRow.Cells["funcionario"].Value.ToString();
                    this.DialogResult = DialogResult.OK;
                }
            }
            if (tipoPesquisa == 2)
            {
                if (dgResultado.SelectedRows.Count > 0)
                {
                    this.codigoFerramenta = Convert.ToInt32(dgResultado.CurrentRow.Cells["codigo"].Value);
                    this.nomeFerramenta = dgResultado.CurrentRow.Cells["descricao"].Value.ToString();
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
