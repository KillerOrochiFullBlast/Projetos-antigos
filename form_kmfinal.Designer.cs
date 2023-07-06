namespace Locadora_de_carros
{
    partial class form_kmfinal
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
            this.txb_kmfinal = new System.Windows.Forms.TextBox();
            this.btn_salva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txb_kmfinal
            // 
            this.txb_kmfinal.Location = new System.Drawing.Point(310, 116);
            this.txb_kmfinal.Name = "txb_kmfinal";
            this.txb_kmfinal.Size = new System.Drawing.Size(100, 22);
            this.txb_kmfinal.TabIndex = 0;
            // 
            // btn_salva
            // 
            this.btn_salva.Location = new System.Drawing.Point(416, 116);
            this.btn_salva.Name = "btn_salva";
            this.btn_salva.Size = new System.Drawing.Size(75, 23);
            this.btn_salva.TabIndex = 1;
            this.btn_salva.Text = "Salvar";
            this.btn_salva.UseVisualStyleBackColor = true;
            this.btn_salva.Click += new System.EventHandler(this.btn_salva_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "kmfinal";
            // 
            // form_kmfinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_salva);
            this.Controls.Add(this.txb_kmfinal);
            this.Name = "form_kmfinal";
            this.Text = "form_kmfinal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_kmfinal;
        private System.Windows.Forms.Button btn_salva;
        private System.Windows.Forms.Label label1;
    }
}