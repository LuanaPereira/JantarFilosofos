namespace JantarFilosofo
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
            this.iniciar = new System.Windows.Forms.Button();
            this.Contador1 = new System.Windows.Forms.Label();
            this.Contador2 = new System.Windows.Forms.Label();
            this.Contador3 = new System.Windows.Forms.Label();
            this.Contador4 = new System.Windows.Forms.Label();
            this.Contador5 = new System.Windows.Forms.Label();
            this.ListaTela = new System.Windows.Forms.ListBox();
            this.LFilosofo1 = new System.Windows.Forms.Label();
            this.LFilosofo2 = new System.Windows.Forms.Label();
            this.LFilosofo3 = new System.Windows.Forms.Label();
            this.LFilosofo4 = new System.Windows.Forms.Label();
            this.LFilosofo5 = new System.Windows.Forms.Label();
            this.Status1 = new System.Windows.Forms.Label();
            this.Status2 = new System.Windows.Forms.Label();
            this.Status3 = new System.Windows.Forms.Label();
            this.Status4 = new System.Windows.Forms.Label();
            this.Status5 = new System.Windows.Forms.Label();
            this.Finalizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // iniciar
            // 
            this.iniciar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciar.Location = new System.Drawing.Point(43, 22);
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(106, 46);
            this.iniciar.TabIndex = 0;
            this.iniciar.Text = "INICIAR";
            this.iniciar.UseVisualStyleBackColor = false;
            this.iniciar.Click += new System.EventHandler(this.IniciarBotao);
            // 
            // Contador1
            // 
            this.Contador1.AutoSize = true;
            this.Contador1.Location = new System.Drawing.Point(40, 190);
            this.Contador1.Name = "Contador1";
            this.Contador1.Size = new System.Drawing.Size(35, 13);
            this.Contador1.TabIndex = 1;
            this.Contador1.Text = "Cont1";
            this.Contador1.Click += new System.EventHandler(this.IniciarBotao);
            // 
            // Contador2
            // 
            this.Contador2.AutoSize = true;
            this.Contador2.BackColor = System.Drawing.Color.Azure;
            this.Contador2.Location = new System.Drawing.Point(40, 213);
            this.Contador2.Name = "Contador2";
            this.Contador2.Size = new System.Drawing.Size(35, 13);
            this.Contador2.TabIndex = 2;
            this.Contador2.Text = "Cont2";
            this.Contador2.Click += new System.EventHandler(this.IniciarBotao);
            // 
            // Contador3
            // 
            this.Contador3.AutoSize = true;
            this.Contador3.Location = new System.Drawing.Point(40, 236);
            this.Contador3.Name = "Contador3";
            this.Contador3.Size = new System.Drawing.Size(35, 13);
            this.Contador3.TabIndex = 3;
            this.Contador3.Text = "Cont3";
            // 
            // Contador4
            // 
            this.Contador4.AutoSize = true;
            this.Contador4.Location = new System.Drawing.Point(40, 258);
            this.Contador4.Name = "Contador4";
            this.Contador4.Size = new System.Drawing.Size(35, 13);
            this.Contador4.TabIndex = 4;
            this.Contador4.Text = "Cont4";
            this.Contador4.Click += new System.EventHandler(this.IniciarBotao);
            // 
            // Contador5
            // 
            this.Contador5.AutoSize = true;
            this.Contador5.Location = new System.Drawing.Point(37, 282);
            this.Contador5.Name = "Contador5";
            this.Contador5.Size = new System.Drawing.Size(38, 13);
            this.Contador5.TabIndex = 5;
            this.Contador5.Text = " Cont5";
            // 
            // ListaTela
            // 
            this.ListaTela.FormattingEnabled = true;
            this.ListaTela.Location = new System.Drawing.Point(340, 22);
            this.ListaTela.Name = "ListaTela";
            this.ListaTela.Size = new System.Drawing.Size(437, 407);
            this.ListaTela.TabIndex = 6;
            this.ListaTela.SelectedIndexChanged += new System.EventHandler(this.ListaTela_SelectedIndexChanged);
            // 
            // LFilosofo1
            // 
            this.LFilosofo1.AutoSize = true;
            this.LFilosofo1.Location = new System.Drawing.Point(81, 190);
            this.LFilosofo1.Name = "LFilosofo1";
            this.LFilosofo1.Size = new System.Drawing.Size(52, 13);
            this.LFilosofo1.TabIndex = 7;
            this.LFilosofo1.Text = "Filosofo 1";
            // 
            // LFilosofo2
            // 
            this.LFilosofo2.AutoSize = true;
            this.LFilosofo2.Location = new System.Drawing.Point(81, 213);
            this.LFilosofo2.Name = "LFilosofo2";
            this.LFilosofo2.Size = new System.Drawing.Size(52, 13);
            this.LFilosofo2.TabIndex = 8;
            this.LFilosofo2.Text = "Filosofo 2";
            // 
            // LFilosofo3
            // 
            this.LFilosofo3.AutoSize = true;
            this.LFilosofo3.Location = new System.Drawing.Point(81, 236);
            this.LFilosofo3.Name = "LFilosofo3";
            this.LFilosofo3.Size = new System.Drawing.Size(52, 13);
            this.LFilosofo3.TabIndex = 9;
            this.LFilosofo3.Text = "Filosofo 3";
            // 
            // LFilosofo4
            // 
            this.LFilosofo4.AutoSize = true;
            this.LFilosofo4.Location = new System.Drawing.Point(81, 258);
            this.LFilosofo4.Name = "LFilosofo4";
            this.LFilosofo4.Size = new System.Drawing.Size(52, 13);
            this.LFilosofo4.TabIndex = 10;
            this.LFilosofo4.Text = "Filosofo 4";
            // 
            // LFilosofo5
            // 
            this.LFilosofo5.AutoSize = true;
            this.LFilosofo5.Location = new System.Drawing.Point(81, 282);
            this.LFilosofo5.Name = "LFilosofo5";
            this.LFilosofo5.Size = new System.Drawing.Size(52, 13);
            this.LFilosofo5.TabIndex = 11;
            this.LFilosofo5.Text = "Filosofo 5";
            // 
            // Status1
            // 
            this.Status1.AutoSize = true;
            this.Status1.Location = new System.Drawing.Point(140, 190);
            this.Status1.Name = "Status1";
            this.Status1.Size = new System.Drawing.Size(46, 13);
            this.Status1.TabIndex = 12;
            this.Status1.Text = "Status 1";
            // 
            // Status2
            // 
            this.Status2.AutoSize = true;
            this.Status2.Location = new System.Drawing.Point(139, 213);
            this.Status2.Name = "Status2";
            this.Status2.Size = new System.Drawing.Size(46, 13);
            this.Status2.TabIndex = 13;
            this.Status2.Text = "Status 2";
            // 
            // Status3
            // 
            this.Status3.AutoSize = true;
            this.Status3.Location = new System.Drawing.Point(140, 236);
            this.Status3.Name = "Status3";
            this.Status3.Size = new System.Drawing.Size(46, 13);
            this.Status3.TabIndex = 14;
            this.Status3.Text = "Status 3";
            // 
            // Status4
            // 
            this.Status4.AutoSize = true;
            this.Status4.Location = new System.Drawing.Point(140, 258);
            this.Status4.Name = "Status4";
            this.Status4.Size = new System.Drawing.Size(46, 13);
            this.Status4.TabIndex = 15;
            this.Status4.Text = "Status 4";
            // 
            // Status5
            // 
            this.Status5.AutoSize = true;
            this.Status5.Location = new System.Drawing.Point(140, 282);
            this.Status5.Name = "Status5";
            this.Status5.Size = new System.Drawing.Size(46, 13);
            this.Status5.TabIndex = 16;
            this.Status5.Text = "Status 5";
            // 
            // Finalizar
            // 
            this.Finalizar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Finalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Finalizar.Location = new System.Drawing.Point(43, 75);
            this.Finalizar.Name = "Finalizar";
            this.Finalizar.Size = new System.Drawing.Size(106, 41);
            this.Finalizar.TabIndex = 17;
            this.Finalizar.Text = "FINALIZAR";
            this.Finalizar.UseVisualStyleBackColor = false;
            this.Finalizar.Click += new System.EventHandler(this.Finalizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Finalizar);
            this.Controls.Add(this.Status5);
            this.Controls.Add(this.Status4);
            this.Controls.Add(this.Status3);
            this.Controls.Add(this.Status2);
            this.Controls.Add(this.Status1);
            this.Controls.Add(this.LFilosofo5);
            this.Controls.Add(this.LFilosofo4);
            this.Controls.Add(this.LFilosofo3);
            this.Controls.Add(this.LFilosofo2);
            this.Controls.Add(this.LFilosofo1);
            this.Controls.Add(this.ListaTela);
            this.Controls.Add(this.Contador5);
            this.Controls.Add(this.Contador4);
            this.Controls.Add(this.Contador3);
            this.Controls.Add(this.Contador2);
            this.Controls.Add(this.Contador1);
            this.Controls.Add(this.iniciar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button iniciar;
        private System.Windows.Forms.Label Contador1;
        private System.Windows.Forms.Label Contador2;
        private System.Windows.Forms.Label Contador3;
        private System.Windows.Forms.Label Contador4;
        private System.Windows.Forms.Label Contador5;
        private System.Windows.Forms.ListBox ListaTela;
        private System.Windows.Forms.Label LFilosofo1;
        private System.Windows.Forms.Label LFilosofo2;
        private System.Windows.Forms.Label LFilosofo3;
        private System.Windows.Forms.Label LFilosofo4;
        private System.Windows.Forms.Label LFilosofo5;
        private System.Windows.Forms.Label Status1;
        private System.Windows.Forms.Label Status2;
        private System.Windows.Forms.Label Status3;
        private System.Windows.Forms.Label Status4;
        private System.Windows.Forms.Label Status5;
        private System.Windows.Forms.Button Finalizar;
    }
}

