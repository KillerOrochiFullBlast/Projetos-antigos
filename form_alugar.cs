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
    public partial class form_alugar : Form
    {
        string Id;
        string precod = "";
        string placa;
        DateTime final= DateTime.MaxValue;
        DateTime inicio;
        DateTime data;
        private Bitmap image1;
        string pessoa = "";
        public form_alugar(string imagem,string id,string precoD,string Placa,string Nome)
        {
            InitializeComponent();
            // pictureBox_carro.Image= Image.FromFile(imagem);
            pessoa = Nome;
            Id = id;
            precod = precoD;
            valor.Text = precoD;
            placa = Placa;
            atualizar_lista();

            image1 = new Bitmap(imagem, true);

            pictureBox_carro.Image = image1;
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            if (tex_cpf.Text != "")
            {
                MySqlConnection conexao = null;
                try
                {
                    string strConn = "server=localhost; user=root; database=carros;";
                    conexao = new MySqlConnection(strConn);
                    conexao.Open();
                   
                    string comando = "SELECT  `nome`, `sobrenome`, `endereco`, `telefone`, `email`, `cnh`, `cep`, `categoria` FROM `cadastros` WHERE `cpf`= '" + tex_cpf.Text + "';";
                  
                    MySqlCommand comandoSQL = new MySqlCommand(comando, conexao);
                    MySqlDataReader logado = comandoSQL.ExecuteReader();
                    while (logado.Read())
                    {
                        cep.Text = logado["cep"].ToString();
                        cnh.Text = logado["cnh"].ToString();
                        email.Text = logado["email"].ToString();
                        endereco.Text = logado["endereco"].ToString();
                        nome.Text = logado["nome"].ToString();
                        sobrenome.Text = logado["sobrenome"].ToString();
                        telefone.Text = logado["telefone"].ToString();

                    }
                    
                    conexao.Close();
  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void btn_alugar_Click(object sender, EventArgs e)
        {
            if (lab_dataF.Text != "" && lab_dataI.Text != ""&& tex_cpf.Text != ""&&nome.Text!="")
            {
                string Dias = (final - inicio).ToString();
                string dias = "";
                for (int i = 0; Dias[i] != '.'; i++)
                {
                    dias += Dias[i].ToString();
                }
                float diasf = global::System.Single.Parse(dias.ToString());
                float precodA = global::System.Single.Parse(precod.ToString());
                preco.Text = (diasf * precodA).ToString();
            
            MySqlConnection conexao = null;
            try
            {
                string strConn = "server=localhost; user=root; database=carros;";
                conexao = new MySqlConnection(strConn);
                conexao.Open();

                string comando = "UPDATE `carro` SET `situacao`='1' WHERE `id`='" + Id+"';";

                MySqlCommand comandoSQL = new MySqlCommand(comando, conexao);
                MySqlDataReader logado = comandoSQL.ExecuteReader();
                
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
                string Fabricante="";
                string KMInicial = "";
                string ano = "";
                string modelo = "";
                string diasLocados = "";
                //tring cnh = "";
              //  string endereco = "";
               // string nomeC = "";
                string funcionario = "";
                conexao = null;
                try
                {
                    string strConn = "server=localhost; user=root; database=carros;";
                    conexao = new MySqlConnection(strConn);
                    conexao.Open();

                    string comando = "SELECT `KMInicial`, `TeladeIDC`, `PainelDigitado`, `CambioAutomatico`, `Ano`, `DatadeCompra`, `ValordeCompra`, `Fabricante`, `Modelo`, `Tamanho`, `Combustivel`, `GPS`, `Categoria`, `Renavam`, `Cilindradas`, `Placa`, `Imagem`, `situacao`, `valorDiario` FROM `carro` WHERE `Placa`='" + placa + "';";

                    MySqlCommand comandoSQL = new MySqlCommand(comando, conexao);
                    MySqlDataReader logado = comandoSQL.ExecuteReader();
                    while (logado.Read())
                    {

                        Fabricante = logado["Fabricante"].ToString();
                        KMInicial = logado["KMInicial"].ToString();
                        ano = logado["ano"].ToString();
                        modelo = logado["modelo"].ToString();
                        //cnh = logado["cnh"].ToString();
                       
                       

                    }

                    conexao.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

                
                conexao = null;
                try
                {
                    
                    string lo = (final - inicio).ToString();
                    for (int i = 0; lo[i] != '.'; i++)
                    {
                        diasLocados += lo[i].ToString();
                    }
                    string strConn = "server=localhost; user=root; database=carros;";
                    conexao = new MySqlConnection(strConn);
                    conexao.Open();

                    string comando = "INSERT INTO `historico`(`funcionario`,`placa`, `cpf`, `valor`, `dataI`, `dataF`, `estado`, `Fabricante`, `KMInicial`, `ano`, `modelo`, `diasLocados`, `cnh`, `endereco`, `nomeC`) VALUES('" + pessoa + "','" + placa+"', '" + tex_cpf.Text + "', '" + preco.Text + "', '" + lab_dataI.Text + "', '" + lab_dataF.Text + "','1','" + Fabricante + "','" + KMInicial + "','" + ano + "','" + modelo + "','" + diasLocados + "','" + cnh.Text + "','" + endereco.Text + "','" + nome.Text + "');";
                    MessageBox.Show(comando);
                    MySqlCommand comandoSQL = new MySqlCommand(comando, conexao);
                    MySqlDataReader logado = comandoSQL.ExecuteReader();

                    conexao.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else
            {
                MessageBox.Show("selecione as datas");
            }

        }
        
        private void btn_calculo_Click(object sender, EventArgs e)
        {


            if (lab_dataF.Text!=""&&lab_dataI.Text!="") {
                string Dias = (final - inicio).ToString();
                string dias = "";
                for (int i=0;Dias[i]!='.';i++)
                {
                    dias+=Dias[i].ToString();
                }
                float diasf = global::System.Single.Parse(dias.ToString());
                float precodA = global::System.Single.Parse(precod.ToString());
                preco.Text = (diasf * precodA).ToString();
            }
            else
            {
                MessageBox.Show("selecione as datas");
            }
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
             data = ((MonthCalendar)sender).SelectionStart;
     

        }

        private void valor_ini_Click(object sender, EventArgs e)
        {
            if (DateTime.Today <=data&& data<final) {
                inicio = data;
                lab_dataI.Text = data.ToString();
            }
            else
            {
                MessageBox.Show("data incoreta");
            }
            
        }

        private void data_fina_Click(object sender, EventArgs e)
        {
            
            if (lab_dataI.Text!=""&& inicio< data)
            {
                final = data;
            lab_dataF.Text = data.ToString();
            
            }
            else
            {
                MessageBox.Show("data incoreta");
            }

           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value != null)
            {
                
                if (e.ColumnIndex == 7)
                {
                    cep.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    cnh.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    email.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    endereco.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    nome.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    sobrenome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    telefone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    tex_cpf.Text= dataGridView1.CurrentRow.Cells[8].Value.ToString();

                }


            }
        }
            private string procurar_db(string tabela, string procurar, int id)//procura dados no banco de dados no corte
            {
                MySqlConnection conexao = null;
                try
                {
                    string retorno = "";
                    string retorno1 = "";

                    string strConn = "server=localhost; user=root; database=carros;";
                    conexao = new MySqlConnection(strConn);
                    conexao.Open();
                    string comando = "SELECT `" + procurar + "` FROM `" + tabela + "` WHERE `id`='" + id + "'";
                    MySqlCommand comandoSQL = new MySqlCommand(comando, conexao);
                    comandoSQL.ExecuteNonQuery();
                    MySqlDataReader resultado = comandoSQL.ExecuteReader();

                    while (resultado.Read())
                    {

                        retorno = resultado[procurar].ToString();

                    }
                    if (procurar == "Arquivo")
                    {
                        for (int i = 0; i < retorno.Length; i++)
                        {
                            if (retorno[i] == '\\')
                            {
                                retorno1 += '/';
                            }
                            else
                            {
                                retorno1 += retorno[i];
                            }
                        }
                    }
                    else
                    {
                        retorno1 = retorno;
                    }

                    conexao.Close();
                    return retorno1;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conexao.Close();
                    return "";
                }



            }
        private void atualizar_lista()
        {
            int ultima = 0;


            dataGridView1.Rows.Clear();
            MySqlConnection conexao = null;
            try
            {
                string strConn = "server=localhost; user=root; database=carros;";
                conexao = new MySqlConnection(strConn);
                conexao.Open();

                string comando = "SELECT MAX(id) as id FROM cadastros;";
                MySqlCommand comandoSQL = new MySqlCommand(comando, conexao);
                MySqlDataReader logado = comandoSQL.ExecuteReader();
                logado.Read();
                ultima = logado.GetInt32("id");
                conexao.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


            String[] dados = new string[9];
            for (int i = 1; i <= ultima; i++)//lista todos os dados do banco de dados
            {
                
                if (procurar_db("cadastros", "categoria", i) == "FCO")
                {

                    dados[0] = procurar_db("cadastros", "nome", i);
                    dados[1] = procurar_db("cadastros", "sobrenome", i);
                    dados[2] = procurar_db("cadastros", "endereco", i);
                    dados[3] = procurar_db("cadastros", "telefone", i);
                    dados[4] = procurar_db("cadastros", "email", i);
                    dados[5] = procurar_db("cadastros", "cnh", i);
                    dados[6] = procurar_db("cadastros", "cep", i);
                    dados[7] = "Escolher";
                    dados[8] = procurar_db("cadastros", "cpf", i);


                    dataGridView1.Rows.Add(dados);
                }

            }

        }
    }
            
   }

