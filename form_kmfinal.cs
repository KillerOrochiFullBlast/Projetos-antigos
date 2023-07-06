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

namespace Locadora_de_carros
{
    public partial class form_kmfinal : Form
    {
        string plaCa = "";
        public form_kmfinal(string placa)
        {
            InitializeComponent();
            plaCa= placa;
        }

        private void btn_salva_Click(object sender, EventArgs e)
        {
            if (txb_kmfinal.Text != "")
            {
                MySqlConnection conexao = null;
                try
                {
                    string strConn = "server=localhost; user=root; database=carros;";
                    conexao = new MySqlConnection(strConn);
                    conexao.Open();

                    string comando = "UPDATE `historico` SET `KMfinal`='" + txb_kmfinal.Text + "' WHERE `placa`='" + plaCa + "';";

                    MySqlCommand comandoSQL = new MySqlCommand(comando, conexao);
                    MySqlDataReader logado = comandoSQL.ExecuteReader();

                    conexao.Close();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }
    }
}
