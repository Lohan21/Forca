namespace LP2_2emia_24_08_18
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbPalavra = new System.Windows.Forms.Label();
            this.tbLetra = new System.Windows.Forms.TextBox();
            this.btJogar = new System.Windows.Forms.Button();
            this.lbChances = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.lbLetrasDigitadas = new System.Windows.Forms.Label();
            this.btReiniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbResultado = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPalavra
            // 
            this.lbPalavra.AutoSize = true;
            this.lbPalavra.Location = new System.Drawing.Point(7, 9);
            this.lbPalavra.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbPalavra.Name = "lbPalavra";
            this.lbPalavra.Size = new System.Drawing.Size(96, 26);
            this.lbPalavra.TabIndex = 0;
            this.lbPalavra.Text = "_ _ _ _ _";
            // 
            // tbLetra
            // 
            this.tbLetra.Location = new System.Drawing.Point(12, 49);
            this.tbLetra.MaxLength = 1;
            this.tbLetra.Name = "tbLetra";
            this.tbLetra.Size = new System.Drawing.Size(132, 32);
            this.tbLetra.TabIndex = 1;
            this.tbLetra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbLetra_KeyDown);
            // 
            // btJogar
            // 
            this.btJogar.Location = new System.Drawing.Point(12, 98);
            this.btJogar.Name = "btJogar";
            this.btJogar.Size = new System.Drawing.Size(132, 41);
            this.btJogar.TabIndex = 2;
            this.btJogar.Text = "Jogar";
            this.btJogar.UseVisualStyleBackColor = true;
            this.btJogar.Click += new System.EventHandler(this.btJogar_Click);
            // 
            // lbChances
            // 
            this.lbChances.AutoSize = true;
            this.lbChances.ForeColor = System.Drawing.Color.Green;
            this.lbChances.Location = new System.Drawing.Point(15, 151);
            this.lbChances.Name = "lbChances";
            this.lbChances.Size = new System.Drawing.Size(122, 26);
            this.lbChances.TabIndex = 4;
            this.lbChances.Text = "Chances: 7";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(15, 553);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(110, 26);
            this.lbResultado.TabIndex = 6;
            this.lbResultado.Text = "Resultado";
            // 
            // lbLetrasDigitadas
            // 
            this.lbLetrasDigitadas.AutoSize = true;
            this.lbLetrasDigitadas.Location = new System.Drawing.Point(15, 579);
            this.lbLetrasDigitadas.Name = "lbLetrasDigitadas";
            this.lbLetrasDigitadas.Size = new System.Drawing.Size(257, 26);
            this.lbLetrasDigitadas.TabIndex = 7;
            this.lbLetrasDigitadas.Text = "Letras Digitadas: A; B; C;";
            // 
            // btReiniciar
            // 
            this.btReiniciar.Location = new System.Drawing.Point(12, 190);
            this.btReiniciar.Name = "btReiniciar";
            this.btReiniciar.Size = new System.Drawing.Size(132, 41);
            this.btReiniciar.TabIndex = 8;
            this.btReiniciar.Text = "Reiniciar";
            this.btReiniciar.UseVisualStyleBackColor = true;
            this.btReiniciar.Click += new System.EventHandler(this.btReiniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dica";
            // 
            // pbResultado
            // 
            this.pbResultado.Location = new System.Drawing.Point(212, 49);
            this.pbResultado.Name = "pbResultado";
            this.pbResultado.Size = new System.Drawing.Size(302, 316);
            this.pbResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbResultado.TabIndex = 3;
            this.pbResultado.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 613);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btReiniciar);
            this.Controls.Add(this.lbLetrasDigitadas);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.lbChances);
            this.Controls.Add(this.pbResultado);
            this.Controls.Add(this.btJogar);
            this.Controls.Add(this.tbLetra);
            this.Controls.Add(this.lbPalavra);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo Da Forca Blazblue";
            ((System.ComponentModel.ISupportInitialize)(this.pbResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPalavra;
        private System.Windows.Forms.TextBox tbLetra;
        private System.Windows.Forms.Button btJogar;
        private System.Windows.Forms.PictureBox pbResultado;
        private System.Windows.Forms.Label lbChances;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Label lbLetrasDigitadas;
        private System.Windows.Forms.Button btReiniciar;
        private System.Windows.Forms.Label label1;
    }
}

