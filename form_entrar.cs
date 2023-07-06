using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Locadora_de_carros.mysqlCmd;






namespace Locadora_de_carros
{
    public partial class form_entrar : Form
    {

        string nome = "";
        public form_entrar()
        {
            
            InitializeComponent();
        }


        string categoria;


        private bool entrar(string cpf, string senha)
        {
            MySqlConnection conexao = null;
            try
            {
                string strConn = "server=localhost; user=root; database=carros;";
                conexao = new MySqlConnection(strConn);
                conexao.Open();

                string comando = "SELECT `categoria`, `nome` FROM `cadastros` WHERE `senha`= '" + senha + "' and `cpf`= '" + cpf + "';";
                MySqlCommand comandoSQL = new MySqlCommand(comando, conexao);
                MySqlDataReader logado = comandoSQL.ExecuteReader();
                while (logado.Read())
                {
                    categoria = logado["categoria"].ToString();
                    nome = logado["nome"].ToString();
                }
                if (logado.HasRows)
                {
                    conexao.Close();
                    return true;
                }
                else
                {
                    conexao.Close();
                    return false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if ((texb_cpf.Text == "") || (texb_senha.Text == ""))
            {
                lab_avisos.Text = "É preciso prencher";

            }
            else
            {
                lab_avisos.Text = "";
                if (entrar(texb_cpf.Text, texb_senha.Text))
                {
                    lab_avisos.Text = "logado";
                   
                        texb_cpf.Text = "";
                        texb_senha.Text = "";
                        var verificar = new form_cadastro(categoria,nome);
                        verificar.Show();
                        this.Hide();

                }
                else
                {
                    lab_avisos.Text = "Não encontrado";
                }
            }
        }

      
    }
}
