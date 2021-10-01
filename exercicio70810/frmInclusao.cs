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

namespace exercicio70810
{
    public partial class frmInclusao : Form
    {
        SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Source\Repos\exercicio70810\exercicio70810\clientes.mdf;Integrated Security=True");
        SqlCommand cmd;

        public frmInclusao()
        {
            InitializeComponent();
        }

        private void frmInclusao_Load(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                //MessageBox.Show("Conexão Realizada", "Conexão com Banco");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString(), "Conexão com Banco");
            }
        }

        private void Limpar()
        {
            mskCpf.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtCidade.Text = "";
            mskTelefone.Text = "";
            mskDdd.Text = "";
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            int retorno;
            String cmd_sql;
            cmd_sql = "INSERT INTO CADASTRO (CPF, NOME, ENDERECO, CIDADE, TELEFONE, DDD) VALUES ('" + mskCpf.Text + "','" + txtNome.Text + "','" + txtEndereco.Text + "','" + txtCidade.Text + "','" + mskTelefone.Text + "','" + mskDdd.Text + "')";
            cmd = new SqlCommand(cmd_sql, conexao);
            retorno = cmd.ExecuteNonQuery();

            if (retorno > 0)
            {
                MessageBox.Show("Cliente Inserido!", "Cadastro");
                Limpar();
            }
            else
            {
                MessageBox.Show("Cadastro não realizado!", "Cadastro");
            }

            cmd.Dispose();

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.MaxLength = 100;
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {
            txtEndereco.MaxLength = 100;
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            txtCidade.MaxLength = 50;
        }

        private void mskTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
