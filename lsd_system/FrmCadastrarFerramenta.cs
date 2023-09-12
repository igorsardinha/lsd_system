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
    public partial class FrmCadastrarFerramenta : Form
    {
        public string nomeFerramenta;
        public string localFerramenta;
        public int idFerramenta = 0;
        public FrmCadastrarFerramenta()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim().Length == 0 || textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha todos os dados", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (idFerramenta > 0)
                {
                    string stringConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=oficina;User ID=sa;Password=sa";

                    string sql = "update ferramentas set descricao = @descricao, local = @local where codigo = @id";

                    SqlConnection conexao = new(stringConexao);
                    SqlCommand comando = new(sql, conexao);
                    comando.Parameters.AddWithValue("@descricao", textBox1.Text);
                    comando.Parameters.AddWithValue("@local", textBox2.Text);
                    comando.Parameters.AddWithValue("@id", idFerramenta);

                    try
                    {
                        conexao.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Ferramenta atualizada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pesquisarAtualizar();
                        textBox1.Clear();
                        textBox2.Clear();
                        btnCadastrar.Text = "Cadastrar";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao atualizar ferramenta: " + ex.Message);
                    }
                    finally
                    {
                        conexao.Close();
                    }
                }

                else
                {
                    string stringConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=oficina;User ID=sa;Password=sa";

                    string sql = "INSERT INTO ferramentas (descricao,local,situacao) VALUES (@descricao,@local,'Livre')";

                    SqlConnection conexao = new(stringConexao);
                    SqlCommand comando = new(sql, conexao);
                    comando.Parameters.AddWithValue("@descricao", textBox1.Text);
                    comando.Parameters.AddWithValue("@local", textBox2.Text);

                    try
                    {
                        conexao.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Ferramenta cadastrada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pesquisarAtualizar();
                        textBox1.Clear();
                        textBox2.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar ferramenta: " + ex.Message);
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

            string query = "SELECT codigo, descricao, local,situacao From ferramentas WHERE descricao LIKE '%" + txtPesquisar.Text + "%'";

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvferramentas.DataSource = dt;
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

        private void FrmCadastrarFerramenta_Load(object sender, EventArgs e)
        {
            pesquisarAtualizar();
        }



        public void pesquisarAtualizar()
        {
            string stringConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=oficina;User ID=sa;Password=sa";

            string query = "SELECT top 100 codigo, descricao, local, situacao From ferramentas order by codigo";

            SqlConnection connection = new SqlConnection(stringConexao);
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvferramentas.DataSource = dt;
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
        private void dgvferramentas_DoubleClick(object sender, EventArgs e)
        {
            if (dgvferramentas.SelectedRows.Count > 0)
            {
                nomeFerramenta = dgvferramentas.CurrentRow.Cells["descricao"].Value.ToString();
                this.DialogResult = DialogResult.OK;
            }
        }
        private void dgvferramentas_Click(object sender, EventArgs e)
        {

            if (dgvferramentas.SelectedRows.Count > 0)
            {
                string situacaoFerramenta = dgvferramentas.CurrentRow.Cells["situacao"].Value.ToString();

                if (situacaoFerramenta != "Livre")
                {
                    MessageBox.Show("Não é possível editar ferrementa em uso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();
                    idFerramenta = 0;
                }
                else
                {
                    nomeFerramenta = dgvferramentas.CurrentRow.Cells["descricao"].Value.ToString();
                    localFerramenta = dgvferramentas.CurrentRow.Cells["local"].Value.ToString();
                    idFerramenta = Convert.ToInt32(dgvferramentas.CurrentRow.Cells["codigo"].Value);
                    textBox1.Text = nomeFerramenta;
                    textBox2.Text = localFerramenta;

                    btnCadastrar.Text = "Salvar";
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            idFerramenta = 0;
            btnCadastrar.Text = "Cadastrar";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string situacaoFerramenta = dgvferramentas.CurrentRow.Cells["situacao"].Value.ToString();
            if (idFerramenta > 0)
            {
                if (situacaoFerramenta != "Livre")
                {
                    MessageBox.Show("Não é possível excluir ferrementa em uso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();
                    idFerramenta = 0;
                }
                else
                {

                    DialogResult dialogResult = MessageBox.Show("Deseja realmente excluir a ferramenta selecionada?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string stringConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=oficina;User ID=sa;Password=sa";

                        string sql = "delete from ferramentas where codigo = @id";

                        SqlConnection conexao = new(stringConexao);
                        SqlCommand comando = new(sql, conexao);
                        comando.Parameters.AddWithValue("@id", idFerramenta);

                        try
                        {
                            conexao.Open();
                            comando.ExecuteNonQuery();
                            MessageBox.Show("Ferramenta excluida com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox1.Clear();
                            textBox2.Clear();
                            idFerramenta = 0;
                            pesquisarAtualizar();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao excluir ferramenta: " + ex.Message);
                        }
                        finally
                        {
                            conexao.Close();
                        }
                    }
                }


            }
        }
    }
}
