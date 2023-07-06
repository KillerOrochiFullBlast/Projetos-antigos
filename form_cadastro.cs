using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora_de_carros
{
    public partial class form_cadastro : Form
    {
        string nome = "";
        public form_cadastro(string cargo,string Nome)
        {
            InitializeComponent();
            nome = Nome;
            if (cargo== "ADM")
            {
                tabControl.TabPages.RemoveAt(2);

            }
            else if (cargo== "FCO")
            {
                tabControl.TabPages.RemoveAt(0);
                tabControl.TabPages.RemoveAt(0);
                tabControl.TabPages.RemoveAt(3);
            }
            atualizar_lista();
            programa.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var verificar = new form_entrar();
            verificar.Show();
            this.Hide();
        }

        private void limpar()
        {
            texb_cpf.Text = "";
            texb_categoria.Text = "";
            texb_cep.Text = "";
            texb_cnh.Text = "";
            texb_email.Text = "";
            texb_endereço.Text = "";
            texb_nome.Text = "";
            texb_senha.Text = "";
            texb_sobrenome.Text = "";
            texb_telefone.Text = "";
            texb_pesquisar.Text = "";
        }
        private void aparecer_f()
        {
            btn_salvarA_f.Visible = true;
            texb_cpf_f.Visible = true;
           // texb_categoria_f.Visible = true;
            texb_cep_f.Visible = true;
            texb_cnh_f.Visible = true;
            texb_email_f.Visible = true;
            texb_endereço_f.Visible = true;
            texb_nome_f.Visible = true;
            texb_senha_f.Visible = true;
            texb_sobrenome_f.Visible = true;
            texb_telefone_f.Visible = true;
            label_cpf.Visible = true;
            label29.Visible = true;
            label30.Visible = true;
            label31.Visible = true;
            label33.Visible = true;
            label34.Visible = true;
            label35.Visible = true;
            label36.Visible = true;
            label37.Visible = true;
            label38.Visible = true;
            label39.Visible = true;
            label40.Visible = true;
            label41.Visible = true;
        }
        private void desaparecer_f()
        {
            btn_salvarA_f.Visible = false;
            texb_cpf_f.Visible = false;
            //texb_categoria_f.Visible = false;
            texb_cep_f.Visible = false;
            texb_cnh_f.Visible = false;
            texb_email_f.Visible = false;
            texb_endereço_f.Visible = false;
            texb_nome_f.Visible = false;
            texb_senha_f.Visible = false;
            texb_sobrenome_f.Visible = false;
            texb_telefone_f.Visible = false;
            label_cpf.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
            label35.Visible = false;
            label36.Visible = false;
            label37.Visible = false;
            label38.Visible = false;
            label39.Visible = false;
            label40.Visible = false;
            label41.Visible = false;    

        }

            private void aparecer()
        {
            texb_cpf.Visible = true;
            texb_categoria.Visible = true;  
            texb_cep.Visible = true;    
            texb_cnh.Visible = true;    
            texb_email.Visible = true;  
            texb_endereço.Visible = true;
            texb_nome.Visible = true;   
            texb_senha.Visible = true;
            texb_sobrenome.Visible = true;
            texb_telefone.Visible = true;
            label10.Visible = true;
            label1.Visible=true;
            label2.Visible = true;
            label3.Visible = true;  
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;




        }
        private void desaparecer()
        {
            texb_cpf.Visible = false;
            texb_categoria.Visible = false;
            texb_cep.Visible = false;
            texb_cnh.Visible = false;
            texb_email.Visible = false;
            texb_endereço.Visible = false;
            texb_nome.Visible = false;
            texb_senha.Visible = false;
            texb_sobrenome.Visible = false;
            texb_telefone.Visible = false;
            label10.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            btn_salvar.Visible = false;
            btn_salvarA.Visible = false;


        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            limpar();
            btn_salvarA.Visible = true;
            texb_pesquisar.Visible = false;
            btn_pesquisar.Visible = false;
            lab_pesquisa.Visible = false;
            btn_apagar.Visible = false;
            btn_salvar.Visible = false;
            aparecer();


        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            desaparecer();
            limpar();
            lab_pesquisa.Visible=false;
            texb_pesquisar.Visible = true;
            btn_pesquisar.Visible = true;
            lab_pesquisa.Visible = true;
            btn_apagar.Visible=false;
          


            
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            if (texb_pesquisar.Text!="") {
                MySqlConnection conexao = null;
                try
                {
                    string strConn = "server=localhost; user=root; database=carros;";
                    conexao = new MySqlConnection(strConn);
                    conexao.Open();

                    string comando = "SELECT  `cpf`, `senha`, `nome`, `sobrenome`, `endereco`, `telefone`, `email`, `cnh`, `cep`, `categoria` FROM `cadastros` WHERE `cpf`= '" + texb_pesquisar.Text + "';";
                    MySqlCommand comandoSQL = new MySqlCommand(comando, conexao);
                    MySqlDataReader logado = comandoSQL.ExecuteReader();
                    while (logado.Read())
                    {

                        texb_cpf.Text = logado["cpf"].ToString();
                        texb_categoria.Text = logado["categoria"].ToString();
                        texb_cep.Text = logado["cep"].ToString();
                        texb_cnh.Text = logado["cnh"].ToString();
                        texb_email.Text = logado["email"].ToString();
                        texb_endereço.Text = logado["endereco"].ToString();
                        texb_nome.Text = logado["nome"].ToString();
                        texb_senha.Text = logado["senha"].ToString();
                        texb_sobrenome.Text = logado["sobrenome"].ToString();
                        texb_telefone.Text = logado["telefone"].ToString();

                    }

                    conexao.Close();
                    if (texb_cpf.Text != "")
                    {
                        aparecer();
                        btn_apagar.Visible = true;
                        btn_salvar.Visible = true;
                        btn_salvarA.Visible = false;
                    }
                    else
                    {
                        lab_erro.Text = "não foi encontrado";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else
            {
                lab_erro.Text = "prencha algum cpf";
            }
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            if (texb_categoria.Text!="ADM") {
                MySqlConnection conexao = null;
                try
                {
                    string strConn = "server=localhost; user=root; database=carros;";
                    conexao = new MySqlConnection(strConn);
                    conexao.Open();

                    string comando = "DELETE FROM `cadastros` WHERE `cpf`= '" + texb_pesquisar.Text + "';";
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
                lab_erro.Text = "Não pode apagar conta de ADM";
            }
            desaparecer();
            limpar();
            btn_salvarA.Visible = false;
            texb_pesquisar.Visible = false;
            btn_pesquisar.Visible = false;
            lab_pesquisa.Visible = false;
            btn_apagar.Visible = false;
            btn_salvar.Visible = false;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (texb_cpf.Text != "" && texb_cnh.Text != "" && texb_telefone.Text != "" && texb_cpf.MaskFull == true && texb_cnh.MaskFull == true && texb_telefone.MaskFull == true)
            {

                MySqlConnection conexao = null;
                try
                {
                    string strConn = "server=localhost; user=root; database=carros;";
                    conexao = new MySqlConnection(strConn);
                    conexao.Open();

                    string comando = "UPDATE `cadastros` SET `cpf`= '" + texb_cpf.Text + "',`senha`= '" + texb_senha.Text + "',`nome`= '" + texb_nome.Text + "',`sobrenome`= '" + texb_sobrenome.Text + "',`endereco`= '" + texb_endereço.Text + "',`telefone`= '" + texb_telefone.Text + "',`email`= '" + texb_email.Text + "',`cnh`= '" + texb_cnh.Text + "',`cep`= '" + texb_cep.Text + "',`categoria`= '" + texb_categoria.Text + "' WHERE `cpf`= '" + texb_pesquisar.Text + "';";
                    MySqlCommand comandoSQL = new MySqlCommand(comando, conexao);
                    MySqlDataReader logado = comandoSQL.ExecuteReader();


                    conexao.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            
            desaparecer();
            limpar();
            btn_salvarA.Visible = false;
            texb_pesquisar.Visible = false;
            btn_pesquisar.Visible = false;
            lab_pesquisa.Visible = false;
            btn_apagar.Visible = false;
            btn_salvar.Visible = false;
            }
            else
            {
                MessageBox.Show("precisa preencher completamente todos os itens obrigatorios");
            }
        }

        private void btn_salvarA_Click(object sender, EventArgs e)
        {
            if (texb_cpf.Text!=""&&texb_cnh.Text!=""&&texb_telefone.Text!=""&&texb_cpf.MaskFull==true&&texb_cnh.MaskFull == true &&texb_telefone.MaskFull == true) {
                MySqlConnection conexao = null;
                try
                {
                    string strConn = "server=localhost; user=root; database=carros;";
                    conexao = new MySqlConnection(strConn);
                    conexao.Open();

                    string comando = "INSERT INTO `cadastros`( `cpf`, `senha`, `nome`, `sobrenome`, `endereco`, `telefone`, `email`, `cnh`, `cep`, `categoria`) VALUES('" + texb_cpf.Text + "', '" + texb_senha.Text + "', '" + texb_nome.Text + "', '" + texb_sobrenome.Text + "', '" + texb_endereço.Text + "', '" + texb_telefone.Text + "', '" + texb_email.Text + "', '" + texb_cnh.Text + "', '" + texb_cep.Text + "', '" + texb_categoria.Text + "');";
                    MySqlCommand comandoSQL = new MySqlCommand(comando, conexao);
                    MySqlDataReader logado = comandoSQL.ExecuteReader();


                    conexao.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                desaparecer();
                limpar();
                btn_salvarA.Visible = false;
                texb_pesquisar.Visible = false;
                btn_pesquisar.Visible = false;
                lab_pesquisa.Visible = false;
                btn_apagar.Visible = false;
                btn_salvar.Visible = false;
            }
            else
            {
                MessageBox.Show("precisa preencher completamente todos os itens obrigatorios");
            }
        }

        /// /////////////////////////////////////////////////tabPage_adicionar_carros
        private OpenFileDialog programa = new OpenFileDialog();
        string Caminho_imag="";
        private void imagem_car_Click(object sender, EventArgs e)
        {
            if (programa.ShowDialog() == DialogResult.OK)
            {
                Caminho_imag=programa.FileName;
                Image Imagem = Image.FromFile(Caminho_imag);
                imagem_car.Image = Imagem;
            }
        }

        private void btn_salvar_c_Click(object sender, EventArgs e)
        {
            string diretorio = @"C:\carros\imagens\" + texb_placa_c.Text; //nome do diretorio a ser criado
            string d1="";
            //Se o diretório não existir...

            //if (Caminho_imag !=""&&comb_cambioAutomatico_c.SelectedIndex!=-1&&comb_categoria_c.SelectedIndex != -1 && comb_combustivel_c.SelectedIndex != -1 && comb_gps_c.SelectedIndex != -1 && comb_painelDigital_c.SelectedIndex != -1 && comb_tamanho_c.SelectedIndex != -1 && comb_telaIdc_c.SelectedIndex != -1&&texb_ano_c.Text!=""&& texb_cilindradas_c.Text!=""&&texb_dataCompra_c.Text!=""&&texb_fabricante_c.Text!=""&&texb_modelo_c.Text != "" &&texb_placa_c.TextLength==7&&texb_renavam_c.Text!=""&&texb_valorCompra_c.Text!="") { 
            if (Caminho_imag != "") { 
           
            for (int i = Caminho_imag.Length -1; Caminho_imag[i] != '.'; i--)
            {
                d1 += Caminho_imag[i];
            }
                string ditotoriaS="";
                System.IO.Directory.CreateDirectory(diretorio);
                diretorio += @"\imagemPlaca_"+ texb_placa_c.Text +"."+ new string(d1.Reverse().ToArray());
                for (int o=0;o<diretorio.Length;o++)
                {
                    if (@diretorio[o]!='\\') {
                        ditotoriaS += diretorio[o];
                    }
                    else
                    {
                        ditotoriaS += '?';
                    }
                    }
                File.Copy(Caminho_imag, diretorio, true);
                MySqlConnection conexao = null;
                try
                {
                    string strConn = "server=localhost; user=root; database=carros;";
                    conexao = new MySqlConnection(strConn);
                    conexao.Open();
                    string comando = "INSERT INTO `carro`(`KMInicial`,`TeladeIDC`, `PainelDigitado`, `CambioAutomatico`, `Ano`, `DatadeCompra`, `ValordeCompra`, `Fabricante`, `Modelo`, `Tamanho`, `Combustivel`, `GPS`, `Categoria`, `Renavam`, `Cilindradas`, `Placa`, `Imagem`,`situacao`,`valorDiario`) VALUES ('"+ KMInicial.Text + "','" + comb_telaIdc_c.SelectedItem + "','" + comb_painelDigital_c.SelectedItem + "','" + comb_cambioAutomatico_c.SelectedItem + "','" + texb_ano_c.Text + "','" + texb_dataCompra_c.Text + "','" + texb_valorCompra_c.Text + "','" + texb_fabricante_c.Text + "','" + texb_modelo_c.Text + "','" + comb_tamanho_c.SelectedItem + "','" + comb_combustivel_c.SelectedItem + "','" + comb_gps_c.SelectedItem + "','" + comb_categoria_c.SelectedItem + "','" + texb_renavam_c.Text + "','" + texb_cilindradas_c.Text + "','" + texb_placa_c.Text + "','" + ditotoriaS + "','"+'0'+"','"+ texb_valordiario.Text + "');";
                    MySqlCommand comandoSQL = new MySqlCommand(comando, conexao);
                    MySqlDataReader logado = comandoSQL.ExecuteReader();
                    conexao.Close();
                    atualizar_lista();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                Caminho_imag = "";
            }
            else
            {
                MessageBox.Show("Por favor preencha tudo corretamente");
            }
        }

        //////////////////////////////////////////////////////tabPage_cadastrar_pessoas_fco

        private void btn_salvarA_f_Click(object sender, EventArgs e)
        {
            if (texb_cpf_f.Text != "" && texb_cnh_f.Text != "" && texb_telefone_f.Text != "" && texb_cpf_f.MaskFull == true && texb_cnh_f.MaskFull == true && texb_telefone_f.MaskFull == true)
            {
                MySqlConnection conexao = null;
                try
                {
                    string strConn = "server=localhost; user=root; database=carros;";
                    conexao = new MySqlConnection(strConn);
                    conexao.Open();
                    string comando = "INSERT INTO `cadastros`( `cpf`, `senha`, `nome`, `sobrenome`, `endereco`, `telefone`, `email`, `cnh`, `cep`) VALUES('" + texb_cpf_f.Text + "', '" + texb_senha_f.Text + "', '" + texb_nome_f.Text + "', '" + texb_sobrenome_f.Text + "', '" + texb_endereço_f.Text + "', '" + texb_telefone_f.Text + "', '" + texb_email_f.Text + "', '" + texb_cnh_f.Text + "', '" + texb_cep_f.Text + "');";
                    MySqlCommand comandoSQL = new MySqlCommand(comando, conexao);
                    MySqlDataReader logado = comandoSQL.ExecuteReader();
                    conexao.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                desaparecer();
                limpar();
                btn_salvarA_f.Visible = false;
                texb_pesquisar_f.Visible = false;
                btn_pesquisar_f.Visible = false;
                lab_pesquisa.Visible = false;
                btn_salvar.Visible = false;
            }
            else
            {
                MessageBox.Show("precisa preencher completamente todos os itens obrigatorios");
            }
        }

        private void btn_pesquisar_f_Click(object sender, EventArgs e)
        {
            if (texb_pesquisar_f.Text != "")
            {
                MySqlConnection conexao = null;
                try
                {
                    string strConn = "server=localhost; user=root; database=carros;";
                    conexao = new MySqlConnection(strConn);
                    conexao.Open();

                    string comando = "SELECT  `cpf`, `senha`, `nome`, `sobrenome`, `endereco`, `telefone`, `email`, `cnh`, `cep`, `categoria` FROM `cadastros` WHERE `cpf`= '" + texb_pesquisar_f.Text + "';";
                    MySqlCommand comandoSQL = new MySqlCommand(comando, conexao);
                    MySqlDataReader logado = comandoSQL.ExecuteReader();
                    while (logado.Read())
                    {

                        texb_cpf_f.Text = logado["cpf"].ToString();
                        texb_cep_f.Text = logado["cep"].ToString();
                        texb_cnh_f.Text = logado["cnh"].ToString();
                        texb_email_f.Text = logado["email"].ToString();
                        texb_endereço_f.Text = logado["endereco"].ToString();
                        texb_nome_f.Text = logado["nome"].ToString();
                        texb_senha_f.Text = logado["senha"].ToString();
                        texb_sobrenome_f.Text = logado["sobrenome"].ToString();
                        texb_telefone_f.Text = logado["telefone"].ToString();

                    }

                    conexao.Close();
                    if (texb_cpf_f.Text != "")
                    {
                        aparecer_f();
                        btn_salvar.Visible = true;
                        btn_salvarA_f.Visible = false;
                    }
                    else
                    {
                        lab_erro.Text = "não foi encontrado";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else
            {
                lab_erro.Text = "prencha algum cpf";
            }
        }

        private void btn_editar_f_Click(object sender, EventArgs e)
        {
            desaparecer_f();
            limpar();
            btn_salvarA_f.Visible=false;
            label_cpf.Visible = true;
            texb_pesquisar_f.Visible = true;
            btn_pesquisar_f.Visible = true;
            lab_pesquisa.Visible = true;
        }

        private void btn_adicionar_f_Click(object sender, EventArgs e)
        {
            limpar();
            aparecer_f();
            //btn_
            label_cpf.Visible = false;
            btn_salvarA_f.Visible = true;
            texb_pesquisar_f.Visible = false;
            btn_pesquisar_f.Visible = false;
            lab_pesquisa.Visible = false;
            btn_salvar.Visible = false;
            
        }

        private void btn_voltar_f_Click(object sender, EventArgs e)
        {
            var verificar = new form_entrar();
            verificar.Show();
            this.Hide();
        }

        private void tabPage_cadastrar_pessoas_adm_Click(object sender, EventArgs e)
        {

        }

        private void btn_salvar_f_Click(object sender, EventArgs e)
        {
            if (texb_cpf_f.Text != "" && texb_cnh_f.Text != "" && texb_telefone_f.Text != "" && texb_cpf_f.MaskFull == true && texb_cnh_f.MaskFull == true && texb_telefone_f.MaskFull == true)
            {
                MySqlConnection conexao = null;
                try
                {
                    string strConn = "server=localhost; user=root; database=carros;";
                    conexao = new MySqlConnection(strConn);
                    conexao.Open();

                    string comando = "UPDATE `cadastros` SET `cpf`= '" + texb_cpf_f.Text + "',`senha`= '" + texb_senha_f.Text + "',`nome`= '" + texb_nome_f.Text + "',`sobrenome`= '" + texb_sobrenome_f.Text + "',`endereco`= '" + texb_endereço_f.Text + "',`telefone`= '" + texb_telefone_f.Text + "',`email`= '" + texb_email_f.Text + "',`cnh`= '" + texb_cnh_f.Text + "',`cep`= '" + texb_cep_f.Text + "',`categoria`= 'CLM' WHERE `cpf`= '" + texb_pesquisar_f.Text + "';";
                    MySqlCommand comandoSQL = new MySqlCommand(comando, conexao);
                    MySqlDataReader logado = comandoSQL.ExecuteReader();


                    conexao.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                desaparecer();
                limpar();
                btn_salvarA.Visible = false;
                texb_pesquisar.Visible = false;
                btn_pesquisar.Visible = false;
                lab_pesquisa.Visible = false;
                btn_apagar.Visible = false;
                btn_salvar.Visible = false;
            }
            else
            {
                MessageBox.Show("precisa preencher completamente todos os itens obrigatorios");
            }
        }
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////
       private void atualizar_lista()
        {
            int ultima = 0;

            MySqlConnection conexao = null;
            try
            {
                string strConn = "server=localhost; user=root; database=carros;";
                conexao = new MySqlConnection(strConn);
                conexao.Open();

                string comando = "SELECT MAX(id) as id FROM carro;";
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
            string imagem = "";

            String[] dados = new string[20];
            for (int i = 0; i <= ultima; i++)//lista todos os dados do banco de dados
            {
                string imagemS = "";

                if (procurar_db("carro", "situacao", i) == "0")
                {

                    dados[0] = procurar_db("carro", "id", i);
                    dados[1] = procurar_db("carro", "TeladeIDC", i);
                    dados[2] = procurar_db("carro", "PainelDigitado", i);
                    dados[3] = procurar_db("carro", "CambioAutomatico", i);
                    dados[4] = procurar_db("carro", "Ano", i);
                    dados[5] = procurar_db("carro", "DatadeCompra", i);
                    dados[6] = procurar_db("carro", "ValordeCompra", i);
                    dados[7] = procurar_db("carro", "Fabricante", i);
                    dados[8] = procurar_db("carro", "Modelo", i);
                    dados[9] = procurar_db("carro", "Tamanho", i);
                    dados[10] = procurar_db("carro", "Combustivel", i);
                    dados[11] = procurar_db("carro", "GPS", i);
                    dados[12] = procurar_db("carro", "Categoria", i);
                    dados[13] = procurar_db("carro", "Renavam", i);
                    dados[14] = procurar_db("carro", "Cilindradas", i);
                    dados[15] = procurar_db("carro", "Placa", i);
                    dados[16] = procurar_db("carro", "situacao", i);
                    dados[17] = procurar_db("carro", "valorDiario", i);
                    dados[18] = "Alugar";
                    imagem = procurar_db("carro", "imagem", i);


                    for (int o = 0; o < imagem.Length; o++)
                    {
                        if (imagem[o] != '?')
                        {
                            imagemS += imagem[o];
                        }
                        else
                        {
                            imagemS += '\\';
                        }


                    }
                    dados[19] = imagemS;

                    dataGridView_carrod.Rows.Add(dados);



                }
            }
            dataGridView_carros.Rows.Clear();
            conexao = null;
            try
            {
                string strConn = "server=localhost; user=root; database=carros;";
                conexao = new MySqlConnection(strConn);
                conexao.Open();

                string comando = "SELECT MAX(id) as id FROM carro;";
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
             imagem="";
            
             dados = new string[20];
            for (int i = 0; i <= ultima; i++)//lista todos os dados do banco de dados
            {
                string imagemS = "";

                if (procurar_db("carro", "situacao", i)=="0") {
                    
                    dados[0] = procurar_db("carro", "id",i);
                    dados[1] = procurar_db("carro", "TeladeIDC", i);
                    dados[2] = procurar_db("carro", "PainelDigitado", i);
                    dados[3] = procurar_db("carro", "CambioAutomatico", i);
                    dados[4] = procurar_db("carro", "Ano", i);
                    dados[5] = procurar_db("carro", "DatadeCompra", i);
                    dados[6] = procurar_db("carro", "ValordeCompra", i);
                    dados[7] = procurar_db("carro", "Fabricante", i);
                    dados[8] = procurar_db("carro", "Modelo", i);
                    dados[9] = procurar_db("carro", "Tamanho", i);
                    dados[10] = procurar_db("carro", "Combustivel", i);
                    dados[11] = procurar_db("carro", "GPS", i);
                    dados[12] = procurar_db("carro", "Categoria", i);
                    dados[13] = procurar_db("carro", "Renavam", i);
                    dados[14] = procurar_db("carro", "Cilindradas", i);
                    dados[15] = procurar_db("carro", "Placa", i);
                    dados[16] = procurar_db("carro", "situacao", i);
                    dados[17] = procurar_db("carro", "valorDiario", i);
                    dados[18] = "Alugar";
                    imagem = procurar_db("carro", "imagem", i);


                    for (int o = 0; o < imagem.Length; o++)
                    {
                        if (imagem[o] != '?')
                        {
                            imagemS += imagem[o];
                        }
                        else
                        {
                            imagemS += '\\';
                        }
                        

                    }
                    dados[19] = imagemS;
                    
                    dataGridView_carros.Rows.Add(dados);
                   
                    
                    
                }
            }
            ultima = 0;


            dataGridView_baixa.Rows.Clear();
            conexao = null;
            try
            {
                string strConn = "server=localhost; user=root; database=carros;";
                conexao = new MySqlConnection(strConn);
                conexao.Open();

                string comando = "SELECT MAX(id) as id FROM historico;";
                MySqlCommand comandoSQL = new MySqlCommand(comando, conexao);
                MySqlDataReader logado = comandoSQL.ExecuteReader();
                logado.Read();
                ultima = logado.GetInt32("id");
                conexao.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexao.Close();
            }


            dados = new string[18];
            for (int i = 0; i <= ultima; i++)//lista todos os dados do banco de dados
            {

                if (procurar_db("historico", "estado", i) == "1")
                {

                    dados[0] = procurar_db("historico", "placa", i);
                    dados[1] = procurar_db("historico", "cpf", i);
                    dados[2] = procurar_db("historico", "dataI", i);
                    dados[3] = procurar_db("historico", "dataF", i);
                    dados[4] = procurar_db("historico", "valor", i);
                    dados[5] = procurar_db("historico", "estado", i);
                    dados[6] = procurar_db("historico", "dataB", i);
                    dados[7] = procurar_db("historico", "Fabricante", i);
                    dados[8] = procurar_db("historico", "KMInicial", i);
                    dados[9] = procurar_db("historico", "KMfinal", i);
                    dados[10] = procurar_db("historico", "ano", i);
                    dados[11] = procurar_db("historico", "modelo", i);
                    dados[12] = procurar_db("historico", "diasLocados", i);
                    dados[13] = procurar_db("historico", "cnh", i);
                    dados[14] = procurar_db("historico", "endereco", i);
                    dados[15] = procurar_db("historico", "nomeC", i);
                    dados[16] = procurar_db("historico", "funcionario", i);


                    dados[17] = "Finalizar";

                    dataGridView_baixa.Rows.Add(dados);



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
        private void dataGridView_carros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
           // atualizar_lista();
            if (dataGridView_carros.CurrentRow.Cells[0].Value != null)
            {
                string preco = dataGridView_carros.CurrentRow.Cells[17].Value.ToString();

                string id = dataGridView_carros.CurrentRow.Cells[0].Value.ToString();
                string placa=dataGridView_carros.CurrentRow.Cells[15].Value.ToString();

                if (e.ColumnIndex == 18)
                {
                  var verificar = new form_alugar(dataGridView_carros.CurrentRow.Cells[19].Value.ToString(),id,preco,placa, nome);
                  verificar.Show();
                    atualizar_lista();

                }
            }

        }
    
        /// //////////////////////////////////////////////////////////////////////////////////
     
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
           //atualizar_lista();
            if (dataGridView_baixa.CurrentRow.Cells[0].Value != null)
            {
                string plaCa = dataGridView_baixa.CurrentRow.Cells[0].Value.ToString();

                if (e.ColumnIndex == 9)
                {
                    MessageBox.Show(plaCa);
                   
                    var verificar = new form_kmfinal(plaCa);
                    atualizar_lista();
                    verificar.Show();
                    
                }
                    if (e.ColumnIndex == 17&& dataGridView_baixa.CurrentRow.Cells[9].Value.ToString()!="")
                {
                    MySqlConnection conexao = null;
                    try
                    {
                        string strConn = "server=localhost; user=root; database=carros;";
                        conexao = new MySqlConnection(strConn);
                        conexao.Open();

                        string comando = "UPDATE `historico` SET `estado`='0',`dataB`='" + DateTime.Now.ToString() + "' WHERE `placa`='" + plaCa + "';";

                        MySqlCommand comandoSQL = new MySqlCommand(comando, conexao);
                        MySqlDataReader logado = comandoSQL.ExecuteReader();

                        conexao.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                    conexao = null;
                    try
                    {
                        string strConn = "server=localhost; user=root; database=carros;";
                        conexao = new MySqlConnection(strConn);
                        conexao.Open();

                        string comando = "UPDATE `carro` SET `situacao`='0' WHERE `placa`='" + plaCa + "';";

                        MySqlCommand comandoSQL = new MySqlCommand(comando, conexao);
                        MySqlDataReader logado = comandoSQL.ExecuteReader();

                        conexao.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                    atualizar_lista();
                }
            }
        }

        private void tabControl_Click(object sender, EventArgs e)
        {
            atualizar_lista();
        }

        private void form_cadastro_Click(object sender, EventArgs e)
        {
            atualizar_lista();
        }

        /// //////////////
        string imagem = "";
        private Bitmap image1;
        string placae = "";
        string img = "";
        private void dataGridView_carrod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_carrod.CurrentRow.Cells[0].Value != null)
            {
                string preco = dataGridView_carrod.CurrentRow.Cells[17].Value.ToString();

                string id = dataGridView_carrod.CurrentRow.Cells[0].Value.ToString();
                string placa = dataGridView_carrod.CurrentRow.Cells[15].Value.ToString();

                if (e.ColumnIndex == 18)
                {
                    int ultima = 0;


                    dataGridView_carrod.Rows.Clear();
                    MySqlConnection conexao = null;
                   
                    try
                    {
                        string strConn = "server=localhost; user=root; database=carros;";
                        conexao = new MySqlConnection(strConn);
                        conexao.Open();

                        string comando = "SELECT `id`, `TeladeIDC`, `PainelDigitado`,`KMFinal`, `CambioAutomatico`, `Ano`, `DatadeCompra`, `ValordeCompra`, `Fabricante`, `Modelo`, `Tamanho`, `Combustivel`, `GPS`, `Categoria`, `Renavam`, `Cilindradas`, `Placa`, `Imagem`, `situacao`, `valorDiario`, `KMInicial` FROM `carro` WHERE`Placa`='" + placa + "';";

                        MySqlCommand comandoSQL = new MySqlCommand(comando, conexao);
                        MySqlDataReader logado = comandoSQL.ExecuteReader();
                        while (logado.Read())
                        {


                            ano_e.Text = logado["Ano"].ToString();
                            teladeidc_e.Text = logado["TeladeIDC"].ToString();
                            cambioauto_e.Text = logado["CambioAutomatico"].ToString();
                            datacompra_e.Text = logado["DatadeCompra"].ToString();
                            valordecompra_e.Text = logado["ValordeCompra"].ToString();
                            fabricante_e.Text = logado["Fabricante"].ToString();
                            modelo_e.Text = logado["Modelo"].ToString();
                            renavam_e.Text = logado["Renavam"].ToString();
                            cilindradas_e.Text = logado["Cilindradas"].ToString();
                            placa_e.Text = logado["Placa"].ToString();
                            precodemensal_e.Text = logado["valorDiario"].ToString();
                            kminicial_e.Text = logado["KMInicial"].ToString();
                            KMFinal_e.Text = logado["KMFinal"].ToString();
                            imagem= logado["Imagem"].ToString();
                            placae= logado["Placa"].ToString();

                            
                        }
                        
                            for (int i = 0; i < imagem.Length; i++)
                            {
                                if (imagem[i] == '?')
                                {
                                img += '\\';
                                }
                                else
                                {
                                img += imagem[i];
                                }
                            }
                        Caminho_imag = img;
                         image1 = new Bitmap(img, true);
                        pictureBoxC_E.Image = image1;
                        conexao.Close();
                        atualizar_lista();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }

                }
            }
        }
        string ditotoriaS = "";
        private void salvar_e_Click(object sender, EventArgs e)
        {
            string diretorio = @"C:\carros\imagens\" + placa_e.Text; //nome do diretorio a ser criado
            string d1 = "";
            //Se o diretório não existir...

            //if (Caminho_imag !=""&&comb_cambioAutomatico_c.SelectedIndex!=-1&&comb_categoria_c.SelectedIndex != -1 && comb_combustivel_c.SelectedIndex != -1 && comb_gps_c.SelectedIndex != -1 && comb_painelDigital_c.SelectedIndex != -1 && comb_tamanho_c.SelectedIndex != -1 && comb_telaIdc_c.SelectedIndex != -1&&texb_ano_c.Text!=""&& texb_cilindradas_c.Text!=""&&texb_dataCompra_c.Text!=""&&texb_fabricante_c.Text!=""&&texb_modelo_c.Text != "" &&texb_placa_c.TextLength==7&&texb_renavam_c.Text!=""&&texb_valorCompra_c.Text!="") { 
            if (Caminho_imag != "")
            {
                if (img!=Caminho_imag) {
                    for (int i = Caminho_imag.Length - 1; Caminho_imag[i] != '.'; i--)
                    {
                        d1 += Caminho_imag[i];
                    }
                     ditotoriaS = "";
                    System.IO.Directory.CreateDirectory(diretorio);
                    diretorio += @"\imagemPlaca_" + placa_e.Text + "." + new string(d1.Reverse().ToArray());
                    for (int o = 0; o < diretorio.Length; o++)
                    {
                        if (@diretorio[o] != '\\')
                        {
                            ditotoriaS += diretorio[o];
                        }
                        else
                        {
                            ditotoriaS += '?';
                        }
                    }
                    string oi = Caminho_imag;
                    File.Copy(oi, diretorio, true);
                }
                else
                {
                    ditotoriaS = img;
                }
                MySqlConnection conexao = null;
                try
                {
                    string strConn = "server=localhost; user=root; database=carros;";
                    conexao = new MySqlConnection(strConn);
                    conexao.Open();
                    string comando = "UPDATE `carro` SET `TeladeIDC`= '" + teladeidc_e.Text + "',`PainelDigitado`= '"+paineldigital_e.SelectedItem+"',`CambioAutomatico`= '" + cambioauto_e.Text + "',`Ano`= '" + ano_e.Text + "',`DatadeCompra`= '" + datacompra_e.Text + "',`ValordeCompra`= '" + valordecompra_e.Text + "',`Fabricante`= '" + fabricante_e.Text + "',`Modelo`= '" + modelo_e.Text + "',`Tamanho`= '"+tamanho_e.SelectedItem+"',`Combustivel`= '"+combustivel_e.SelectedItem+"',`GPS`= '"+gps_e.SelectedItem+"',`Categoria`= '"+categoria_e.SelectedItem+"',`Renavam`= '" + renavam_e.Text + "',`Cilindradas`= '"+cilindradas_e.Text + "',`Placa`= '" + placa_e.Text + "',`Imagem`= '"+ ditotoriaS + "',`valorDiario`= '" + precodemensal_e.Text + "',`KMInicial`= '" + kminicial_e.Text + "',`KMFinal`= '" + KMFinal_e.Text + "' WHERE `Placa`= '" + placae + "';";
                    MySqlCommand comandoSQL = new MySqlCommand(comando, conexao);
                    MySqlDataReader logado = comandoSQL.ExecuteReader();
                    conexao.Close();
                    atualizar_lista();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                Caminho_imag = "";
                atualizar_lista();
            }
            else
            {
                MessageBox.Show("Por favor preencha tudo corretamente");
            }
        }

        private void pictureBoxC_E_Click(object sender, EventArgs e)
        {
            if (programa.ShowDialog() == DialogResult.OK)
            {
                Caminho_imag = programa.FileName;
                Image Imagem = Image.FromFile(Caminho_imag);
                pictureBoxC_E.Image = Imagem;
            }
        }
    }
}
