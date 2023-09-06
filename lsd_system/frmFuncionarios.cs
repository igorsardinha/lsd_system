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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lsd_system
{
    public partial class frmFuncionarios : Form
    {
        public string nomeFuncionario;
        public string funcaoFuncionario;
        public int idFunc = 0;
        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtFuncionario.Text.Trim().Length == 0 || txtFuncao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha todos os dados", "Alerta!");
            }
            else
            {
                if (idFunc > 0)
                {
                    string stringConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=oficina;User ID=sa;Password=sa";

                    string sql = "update funcionarios set funcionario = @funcionario, funcao = @funcao where codigo = @id";

                    SqlConnection conexao = new(stringConexao);
                    SqlCommand comando = new(sql, conexao);
                    comando.Parameters.AddWithValue("@funcionario", txtFuncionario.Text);
                    comando.Parameters.AddWithValue("@funcao", txtFuncao.Text);
                    comando.Parameters.AddWithValue("@id", idFunc);

                    try
                    {
                        conexao.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Funcionário atualizado com sucesso!", "Informação");
                        pesquisarAtualizar();
                        txtFuncao.Clear();
                        txtFuncionario.Clear();
                        idFunc = 0;
                        btnCadastrar.Text = "Cadastrar";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao atualizar Funcionário: " + ex.Message, "Informação");
                    }
                    finally
                    {
                        conexao.Close();
                    }
                }
                else
                {
                    string stringConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=oficina;User ID=sa;Password=sa";

                    string sql = "INSERT INTO funcionarios (funcionario,funcao) VALUES (@funcionario,@funcao)";

                    SqlConnection conexao = new(stringConexao);
                    SqlCommand comando = new(sql, conexao);
                    comando.Parameters.AddWithValue("@funcionario", txtFuncionario.Text);
                    comando.Parameters.AddWithValue("@funcao", txtFuncao.Text);

                    try
                    {
                        conexao.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Funcionário cadastrado com sucesso!", "Informação");
                        pesquisarAtualizar();
                        txtFuncao.Clear();
                        txtFuncionario.Clear();
                        idFunc = 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar Funcionário: " + ex.Message, "Informação");
                    }
                    finally
                    {
                        conexao.Close();
                    }
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
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

                dgvFuncionario.DataSource = dt;
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

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            pesquisarAtualizar();
        }

        public void pesquisarAtualizar()
        {
            string stringConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=oficina;User ID=sa;Password=sa";

            string query = "SELECT top 100 codigo, funcionario, funcao From funcionarios order by codigo";

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvFuncionario.DataSource = dt;
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

        private void dgvFuncionario_DoubleClick(object sender, EventArgs e)
        {
            if (dgvFuncionario.SelectedRows.Count > 0)
            {
                nomeFuncionario = dgvFuncionario.CurrentRow.Cells["funcionario"].Value.ToString();
                idFunc = Convert.ToInt32(dgvFuncionario.CurrentRow.Cells["codigo"].Value);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void dgvFuncionario_Click(object sender, EventArgs e)
        {
            if (dgvFuncionario.SelectedRows.Count > 0)
            {
                nomeFuncionario = dgvFuncionario.CurrentRow.Cells["funcionario"].Value.ToString();
                funcaoFuncionario = dgvFuncionario.CurrentRow.Cells["funcao"].Value.ToString();
                idFunc = Convert.ToInt32(dgvFuncionario.CurrentRow.Cells["codigo"].Value);
                txtFuncionario.Text = nomeFuncionario;
                txtFuncao.Text = funcaoFuncionario;

                btnCadastrar.Text = "Salvar";
            }
        }

        /*
        public static Boolean VerificaExiste(int id)
        {
            string stringConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=oficina;User ID=sa;Password=sa";

            string query = "SELECT codigo from funcionarios where codigo = @id";

            SqlConnection conexao = new(stringConexao);
            SqlCommand comando = new(query, conexao);
            comando.Parameters.AddWithValue("@id", id);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Alerta");
            }
            finally
            {
                conexao.Close();
            }
            return false;
        }
        */

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (idFunc > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Deseja realmente excluir o funcionario selecionado?", "Atenção", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string stringConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=oficina;User ID=sa;Password=sa";

                    string sql = "delete from funcionarios where codigo = @id";

                    SqlConnection conexao = new(stringConexao);
                    SqlCommand comando = new(sql, conexao);
                    comando.Parameters.AddWithValue("@id", idFunc);

                    try
                    {
                        conexao.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Funcionário excluido com sucesso!", "Informação");
                        txtFuncao.Clear();
                        txtFuncionario.Clear();
                        idFunc = 0;
                        pesquisarAtualizar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluido Funcionário: " + ex.Message, "Informação");
                    }
                    finally
                    {
                        conexao.Close();
                    }
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtFuncao.Clear();
            txtFuncionario.Clear();
            idFunc = 0;
            btnCadastrar.Text = "Cadastrar";
        }
    }
}
