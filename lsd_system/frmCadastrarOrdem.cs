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
    public partial class frmCadastrarOrdem : Form
    {
        public frmCadastrarOrdem()
        {
            InitializeComponent();
        }
        public int codigoFerramenta;

        private void frmCadastrarOrdem_Load(object sender, EventArgs e)
        {
            frmPesquisaDinamica frmPesquisa = new frmPesquisaDinamica();
            textBox1.Text = frmPesquisa.nomeFuncionario;
            txtFerramentas.Text = frmPesquisa.nomeFerramenta;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPesquisaDinamica frmPesquisa = new frmPesquisaDinamica();
            frmPesquisa.tipoPesquisa = 1;

            if (frmPesquisa.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = frmPesquisa.nomeFuncionario;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPesquisaDinamica frmPesquisa = new frmPesquisaDinamica();
            frmPesquisa.tipoPesquisa = 2;

            if (frmPesquisa.ShowDialog() == DialogResult.OK)
            {
                txtFerramentas.Text = frmPesquisa.nomeFerramenta;
                codigoFerramenta = frmPesquisa.codigoFerramenta;

            }




            /*FrmCadastrarFerramenta frmCadastrarFerramenta = new FrmCadastrarFerramenta();

            if (frmCadastrarFerramenta.ShowDialog() == DialogResult.OK)
            {
                txtFerramentas.Text = frmCadastrarFerramenta.nomeFerramenta;
            }*/
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim().Length == 0 || txtFerramentas.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha todos os dados", "Alerta!");
            }
            else
            {
                string stringConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=oficina;User ID=sa;Password=sa";

                string sql = "INSERT INTO ordens (data_hora,situacao,cod_ferramenta,desc_ferramenta,funcionario,data_abertura,observacao) VALUES (GETDATE(),'Aberto',@codigo_ferramenta, @ferramenta,@funcionario,GETDATE(),@obs)";

                SqlConnection conexao = new(stringConexao);
                SqlCommand comando = new(sql, conexao);
                comando.Parameters.AddWithValue("@funcionario", textBox1.Text);
                comando.Parameters.AddWithValue("@codigo_ferramenta", codigoFerramenta);
                comando.Parameters.AddWithValue("@ferramenta", txtFerramentas.Text);
                comando.Parameters.AddWithValue("@obs", txtObs.Text);

                try
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Ordem cadastrada com sucesso!");
                    this.DialogResult = DialogResult.OK;
                    alterarStatusFerramenta(codigoFerramenta, "Em Uso");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar Ordem: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        public void alterarStatusFerramenta(int id, string situacao)
        {
            string stringConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=oficina;User ID=sa;Password=sa";
            string sql = "update ferramentas set situacao = @situacao where codigo = @id";

            SqlConnection conexao = new(stringConexao);
            SqlCommand comando = new(sql, conexao);
            comando.Parameters.AddWithValue("@situacao", situacao);
            comando.Parameters.AddWithValue("@id", id);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
