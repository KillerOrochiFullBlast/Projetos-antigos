namespace Locadora_de_carros
{
    partial class form_alugar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox_carro = new System.Windows.Forms.PictureBox();
            this.btn_alugar = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.sobrenome = new System.Windows.Forms.Label();
            this.endereco = new System.Windows.Forms.Label();
            this.telefone = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.cnh = new System.Windows.Forms.Label();
            this.cep = new System.Windows.Forms.Label();
            this.tex_cpf = new System.Windows.Forms.MaskedTextBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.btn_calculo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.preco = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.valor = new System.Windows.Forms.Label();
            this.data_fina = new System.Windows.Forms.Button();
            this.valor_ini = new System.Windows.Forms.Button();
            this.lab_dataI = new System.Windows.Forms.Label();
            this.lab_dataF = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.clientenome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesobrenome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientecnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientecep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.escolher = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_carro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_carro
            // 
            this.pictureBox_carro.BackColor = System.Drawing.Color.Gray;
            this.pictureBox_carro.Location = new System.Drawing.Point(758, 26);
            this.pictureBox_carro.Name = "pictureBox_carro";
            this.pictureBox_carro.Size = new System.Drawing.Size(295, 280);
            this.pictureBox_carro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_carro.TabIndex = 30;
            this.pictureBox_carro.TabStop = false;
            // 
            // btn_alugar
            // 
            this.btn_alugar.Location = new System.Drawing.Point(603, 319);
            this.btn_alugar.Name = "btn_alugar";
            this.btn_alugar.Size = new System.Drawing.Size(75, 23);
            this.btn_alugar.TabIndex = 32;
            this.btn_alugar.Text = "Alugar";
            this.btn_alugar.UseVisualStyleBackColor = true;
            this.btn_alugar.Click += new System.EventHandler(this.btn_alugar_Click);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(151, 206);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(31, 23);
            this.btn_pesquisar.TabIndex = 33;
            this.btn_pesquisar.Text = "button1";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Sobrenome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Cnh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Cep";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(79, 234);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(0, 13);
            this.nome.TabIndex = 41;
            // 
            // sobrenome
            // 
            this.sobrenome.AutoSize = true;
            this.sobrenome.Location = new System.Drawing.Point(79, 264);
            this.sobrenome.Name = "sobrenome";
            this.sobrenome.Size = new System.Drawing.Size(0, 13);
            this.sobrenome.TabIndex = 42;
            // 
            // endereco
            // 
            this.endereco.AutoSize = true;
            this.endereco.Location = new System.Drawing.Point(79, 293);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(0, 13);
            this.endereco.TabIndex = 43;
            // 
            // telefone
            // 
            this.telefone.AutoSize = true;
            this.telefone.Location = new System.Drawing.Point(79, 326);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(0, 13);
            this.telefone.TabIndex = 44;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(79, 359);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(0, 13);
            this.email.TabIndex = 45;
            // 
            // cnh
            // 
            this.cnh.AutoSize = true;
            this.cnh.Location = new System.Drawing.Point(79, 393);
            this.cnh.Name = "cnh";
            this.cnh.Size = new System.Drawing.Size(0, 13);
            this.cnh.TabIndex = 46;
            // 
            // cep
            // 
            this.cep.AutoSize = true;
            this.cep.Location = new System.Drawing.Point(79, 419);
            this.cep.Name = "cep";
            this.cep.Size = new System.Drawing.Size(0, 13);
            this.cep.TabIndex = 47;
            // 
            // tex_cpf
            // 
            this.tex_cpf.Location = new System.Drawing.Point(45, 206);
            this.tex_cpf.Mask = "000.000.000-00";
            this.tex_cpf.Name = "tex_cpf";
            this.tex_cpf.Size = new System.Drawing.Size(100, 20);
            this.tex_cpf.TabIndex = 48;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(519, 26);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 49;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // btn_calculo
            // 
            this.btn_calculo.Location = new System.Drawing.Point(519, 258);
            this.btn_calculo.Name = "btn_calculo";
            this.btn_calculo.Size = new System.Drawing.Size(75, 23);
            this.btn_calculo.TabIndex = 50;
            this.btn_calculo.Text = "Calcular";
            this.btn_calculo.UseVisualStyleBackColor = true;
            this.btn_calculo.Click += new System.EventHandler(this.btn_calculo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(600, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "R$:";
            // 
            // preco
            // 
            this.preco.AutoSize = true;
            this.preco.Location = new System.Drawing.Point(630, 263);
            this.preco.Name = "preco";
            this.preco.Size = new System.Drawing.Size(0, 13);
            this.preco.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(600, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "R$:";
            // 
            // valor
            // 
            this.valor.AutoSize = true;
            this.valor.Location = new System.Drawing.Point(630, 284);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(0, 13);
            this.valor.TabIndex = 54;
            // 
            // data_fina
            // 
            this.data_fina.Location = new System.Drawing.Point(519, 229);
            this.data_fina.Name = "data_fina";
            this.data_fina.Size = new System.Drawing.Size(75, 23);
            this.data_fina.TabIndex = 55;
            this.data_fina.Text = "Data final";
            this.data_fina.UseVisualStyleBackColor = true;
            this.data_fina.Click += new System.EventHandler(this.data_fina_Click);
            // 
            // valor_ini
            // 
            this.valor_ini.Location = new System.Drawing.Point(519, 200);
            this.valor_ini.Name = "valor_ini";
            this.valor_ini.Size = new System.Drawing.Size(75, 23);
            this.valor_ini.TabIndex = 56;
            this.valor_ini.Text = "Data inicial";
            this.valor_ini.UseVisualStyleBackColor = true;
            this.valor_ini.Click += new System.EventHandler(this.valor_ini_Click);
            // 
            // lab_dataI
            // 
            this.lab_dataI.AutoSize = true;
            this.lab_dataI.Location = new System.Drawing.Point(601, 206);
            this.lab_dataI.Name = "lab_dataI";
            this.lab_dataI.Size = new System.Drawing.Size(0, 13);
            this.lab_dataI.TabIndex = 57;
            // 
            // lab_dataF
            // 
            this.lab_dataF.AutoSize = true;
            this.lab_dataF.Location = new System.Drawing.Point(600, 234);
            this.lab_dataF.Name = "lab_dataF";
            this.lab_dataF.Size = new System.Drawing.Size(0, 13);
            this.lab_dataF.TabIndex = 58;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientenome,
            this.clientesobrenome,
            this.clienteEndereco,
            this.clienteTelefone,
            this.cliente,
            this.clientecnh,
            this.clientecep,
            this.escolher,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(495, 150);
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 60;
            this.label10.Text = "CPF";
            // 
            // clientenome
            // 
            this.clientenome.HeaderText = "Nome";
            this.clientenome.Name = "clientenome";
            // 
            // clientesobrenome
            // 
            this.clientesobrenome.HeaderText = "Sobrenome";
            this.clientesobrenome.Name = "clientesobrenome";
            // 
            // clienteEndereco
            // 
            this.clienteEndereco.HeaderText = "Endereço";
            this.clienteEndereco.Name = "clienteEndereco";
            // 
            // clienteTelefone
            // 
            this.clienteTelefone.HeaderText = "Telefone";
            this.clienteTelefone.Name = "clienteTelefone";
            // 
            // cliente
            // 
            this.cliente.HeaderText = "Email";
            this.cliente.Name = "cliente";
            // 
            // clientecnh
            // 
            this.clientecnh.HeaderText = "Cnh";
            this.clientecnh.Name = "clientecnh";
            // 
            // clientecep
            // 
            this.clientecep.HeaderText = "Cep";
            this.clientecep.Name = "clientecep";
            // 
            // escolher
            // 
            this.escolher.HeaderText = "Escolher";
            this.escolher.Name = "escolher";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // form_alugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 459);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lab_dataF);
            this.Controls.Add(this.lab_dataI);
            this.Controls.Add(this.valor_ini);
            this.Controls.Add(this.data_fina);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.preco);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_calculo);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.tex_cpf);
            this.Controls.Add(this.cep);
            this.Controls.Add(this.cnh);
            this.Controls.Add(this.email);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.endereco);
            this.Controls.Add(this.sobrenome);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.btn_alugar);
            this.Controls.Add(this.pictureBox_carro);
            this.Name = "form_alugar";
            this.Text = "form_alugar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_carro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_carro;
        private System.Windows.Forms.Button btn_alugar;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label sobrenome;
        private System.Windows.Forms.Label endereco;
        private System.Windows.Forms.Label telefone;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label cnh;
        private System.Windows.Forms.Label cep;
        private System.Windows.Forms.MaskedTextBox tex_cpf;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button btn_calculo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label preco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label valor;
        private System.Windows.Forms.Button data_fina;
        private System.Windows.Forms.Button valor_ini;
        private System.Windows.Forms.Label lab_dataI;
        private System.Windows.Forms.Label lab_dataF;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientenome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientesobrenome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientecnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientecep;
        private System.Windows.Forms.DataGridViewButtonColumn escolher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}