namespace Locadora_de_carros
{
    partial class form_entrar
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.texb_senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lab_avisos = new System.Windows.Forms.Label();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.texb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // texb_senha
            // 
            this.texb_senha.Location = new System.Drawing.Point(347, 240);
            this.texb_senha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.texb_senha.Name = "texb_senha";
            this.texb_senha.PasswordChar = '*';
            this.texb_senha.Size = new System.Drawing.Size(169, 22);
            this.texb_senha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 240);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cpf";
            // 
            // lab_avisos
            // 
            this.lab_avisos.AutoSize = true;
            this.lab_avisos.Location = new System.Drawing.Point(347, 380);
            this.lab_avisos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_avisos.Name = "lab_avisos";
            this.lab_avisos.Size = new System.Drawing.Size(0, 16);
            this.lab_avisos.TabIndex = 5;
            // 
            // btn_entrar
            // 
            this.btn_entrar.Location = new System.Drawing.Point(387, 292);
            this.btn_entrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(100, 28);
            this.btn_entrar.TabIndex = 6;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // texb_cpf
            // 
            this.texb_cpf.Location = new System.Drawing.Point(347, 203);
            this.texb_cpf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.texb_cpf.Mask = "000.000.000-00";
            this.texb_cpf.Name = "texb_cpf";
            this.texb_cpf.Size = new System.Drawing.Size(169, 22);
            this.texb_cpf.TabIndex = 8;
            // 
            // form_entrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.texb_cpf);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.lab_avisos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texb_senha);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form_entrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texb_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_avisos;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.MaskedTextBox texb_cpf;
    }
}

