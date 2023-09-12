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
    public partial class FrmEditarOS : Form
    {
        public FrmEditarOS()
        {
            InitializeComponent();
        }


        public int idOrdem;
        public int codFerrementa;


        void carregaDados(string codigoOs)
        {
            string stringConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=oficina;User ID=sa;Password=sa";

            string query = "SELECT desc_ferramenta,funcionario,observacao,cod_ferramenta from ordens where codigo = @codigo;";

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@codigo", codigoOs);

            try
            {
                connection.Open();
                SqlDataReader da = command.ExecuteReader();

                while (da.Read())
                {
                    txtFunc.Text = da.GetValue(1).ToString();
                    txtFerramenta.Text = da.GetValue(0).ToString();
                    txtObs.Text = da.GetValue(2).ToString();
                    codFerrementa = Convert.ToInt32(da.GetValue(3));
                }

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

        private void FrmEditarOS_Load(object sender, EventArgs e)
        {
            txtCodOS.Text = idOrdem.ToString();
            carregaDados(txtCodOS.Text);
        }

        private void txtCodOS_TextChanged(object sender, EventArgs e)
        {
            carregaDados(txtCodOS.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void atualizarObs(int id, string obs)
        {
            string stringConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=oficina;User ID=sa;Password=sa";
            string sql = "update ordens set observacao = @obs where codigo = @id";

            SqlConnection conexao = new(stringConexao);
            SqlCommand comando = new(sql, conexao);
            comando.Parameters.AddWithValue("@obs", obs);
            comando.Parameters.AddWithValue("@id", id);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Ordem editada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmOrdem frmOrdem = new frmOrdem();
                frmOrdem.pesquisarBox("");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public void reabrirOrdem(int id)
        {
            string stringConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=oficina;User ID=sa;Password=sa";
            string sql = "update ordens set situacao = 'Aberto', data_fechamento = NULL where codigo = @id";

            SqlConnection conexao = new(stringConexao);
            SqlCommand comando = new(sql, conexao);
            comando.Parameters.AddWithValue("@id", id);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                frmCadastrarOrdem frmCadastrarOrdem = new frmCadastrarOrdem();
                frmCadastrarOrdem.alterarStatusFerramenta(codFerrementa, "Em uso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (chkReabrir.Checked)
            {
                if (MessageBox.Show("Deseja reabrir ordem editada?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    reabrirOrdem(Convert.ToInt32(txtCodOS.Text));
                    atualizarObs(Convert.ToInt32(txtCodOS.Text), txtObs.Text);
                }
            }
            else
            {
                atualizarObs(Convert.ToInt32(txtCodOS.Text), txtObs.Text);
            }
        }

        private void FrmEditarOS_FormClosed(object sender, FormClosedEventArgs e)
        {


        }
    }
}
