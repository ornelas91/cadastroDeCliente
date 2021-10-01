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
    public partial class frmConsulta : Form
    {
        SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Source\Repos\exercicio70810\exercicio70810\clientes.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        public frmConsulta()
        {
            InitializeComponent();
        }

        private void frmConsulta_Load(object sender, EventArgs e)
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            String cmd_sql;
            cmd_sql = "SELECT CPF, NOME, ENDERECO, CIDADE, TELEFONE, DDD FROM CADASTRO WHERE CPF LIKE '%" + mskCpfConsulta.Text + "%'";
            cmd = new SqlCommand(cmd_sql, conexao);
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                lstClientes.Items.Clear();
                while (dr.Read())
                {
                    lstClientes.Items.Add("Cpf: " + dr["cpf"].ToString());
                    lstClientes.Items.Add("Nome: " + dr["nome"].ToString());
                    lstClientes.Items.Add("Endereço: " + dr["endereco"].ToString());
                    lstClientes.Items.Add("Cidade: " + dr["cidade"].ToString());
                    lstClientes.Items.Add("Telefone: " + dr["ddd"].ToString() + " " + dr["telefone"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Cadastro não localizado!!!", "Consulta Cliente");
            }

            dr.Close();
            cmd.Dispose();
        }

        private void lblRegiao_Leave(object sender, EventArgs e)
        {
            
        }

        private void Limpar()
        {
            lstClientes.Text = "";
 
        }

        private void mskCpfConsulta_Leave(object sender, EventArgs e)
        {

            String digito = mskCpfConsulta.Text;

            String cpf = digito.Substring(10, 1);

            if (cpf == "0")
            {
                lblRegiao.Text = "Rio Grande Do Sul";
            }
            else
            {
                if (cpf == "1")
                {
                    lblRegiao.Text = "Distrito Federal, Goiás, Mato Grosso, Mato Grosso do Sul e Tocantins";
                }
                else
                {
                    if (cpf == "2")
                    {
                        lblRegiao.Text = "Amazonas, Pará, Roraima, Amapá e Rondânia";
                    }
                    else
                    {
                        if (cpf == "3")
                        {
                            lblRegiao.Text = "Ceará, Maranhão, Alagoas e Rio Grande do Sul";
                        }
                        else
                        {
                            if (cpf == "4")
                            {
                                lblRegiao.Text = "Paraíba, Pernambuco, Alagoas e Rio Grande do Norte";
                            }
                            else
                            {
                                if (cpf == "5")
                                {
                                    lblRegiao.Text = "Bahia e Sergipe";
                                }
                                else
                                {
                                    if (cpf == "6")
                                    {
                                        lblRegiao.Text = "Minas Gerais";
                                    }
                                    else
                                    {
                                        if (cpf == "7")
                                        {
                                            lblRegiao.Text = "Rio de Janeiro e Espírito Santo";
                                        }
                                        else
                                        {
                                            if (cpf == "8")
                                            {
                                                lblRegiao.Text = "São Paulo";
                                            }
                                            else
                                            {
                                                if (cpf == "9")
                                                {
                                                    lblRegiao.Text = "Paraná e Santa Catarina";
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                    }
                }
            }

            
        }

        private bool LastIndexOf(MaskedTextBox mskCpfConsulta, int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}
