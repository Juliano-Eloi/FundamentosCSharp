namespace CalculadoraGrafica
{
    partial class Form1
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
            this.textPrimeiroNumero = new System.Windows.Forms.TextBox();
            this.textSegundoNumero = new System.Windows.Forms.TextBox();
            this.btnAdicao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultAdicao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textPrimeiroNumero
            // 
            this.textPrimeiroNumero.Location = new System.Drawing.Point(81, 49);
            this.textPrimeiroNumero.Multiline = true;
            this.textPrimeiroNumero.Name = "textPrimeiroNumero";
            this.textPrimeiroNumero.Size = new System.Drawing.Size(612, 95);
            this.textPrimeiroNumero.TabIndex = 0;
            this.textPrimeiroNumero.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textSegundoNumero
            // 
            this.textSegundoNumero.Location = new System.Drawing.Point(81, 213);
            this.textSegundoNumero.Multiline = true;
            this.textSegundoNumero.Name = "textSegundoNumero";
            this.textSegundoNumero.Size = new System.Drawing.Size(612, 95);
            this.textSegundoNumero.TabIndex = 1;
            // 
            // btnAdicao
            // 
            this.btnAdicao.Location = new System.Drawing.Point(81, 334);
            this.btnAdicao.Name = "btnAdicao";
            this.btnAdicao.Size = new System.Drawing.Size(75, 23);
            this.btnAdicao.TabIndex = 2;
            this.btnAdicao.Text = "Adicao";
            this.btnAdicao.UseVisualStyleBackColor = true;
            this.btnAdicao.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Informe o Primeiro Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Informe o Segundo Numero";
            // 
            // lblResultAdicao
            // 
            this.lblResultAdicao.AutoSize = true;
            this.lblResultAdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultAdicao.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblResultAdicao.Location = new System.Drawing.Point(81, 382);
            this.lblResultAdicao.Name = "lblResultAdicao";
            this.lblResultAdicao.Size = new System.Drawing.Size(0, 29);
            this.lblResultAdicao.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 439);
            this.Controls.Add(this.lblResultAdicao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdicao);
            this.Controls.Add(this.textSegundoNumero);
            this.Controls.Add(this.textPrimeiroNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPrimeiroNumero;
        private System.Windows.Forms.TextBox textSegundoNumero;
        private System.Windows.Forms.Button btnAdicao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultAdicao;
    }
}

