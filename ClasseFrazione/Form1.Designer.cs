namespace ClasseFrazione
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Num = new System.Windows.Forms.TextBox();
            this.Den = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Somma = new System.Windows.Forms.Button();
            this.Sottrazione = new System.Windows.Forms.Button();
            this.Divisione = new System.Windows.Forms.Button();
            this.Moltiplicazione = new System.Windows.Forms.Button();
            this.Semplifica = new System.Windows.Forms.Button();
            this.Elevamento = new System.Windows.Forms.Button();
            this.Decimale = new System.Windows.Forms.Button();
            this.Frazion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Num
            // 
            this.Num.Location = new System.Drawing.Point(39, 89);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(31, 20);
            this.Num.TabIndex = 1;
            this.Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Num.TextChanged += new System.EventHandler(this.Num_TextChanged);
            // 
            // Den
            // 
            this.Den.Location = new System.Drawing.Point(39, 130);
            this.Den.Name = "Den";
            this.Den.Size = new System.Drawing.Size(31, 20);
            this.Den.TabIndex = 2;
            this.Den.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Den.TextChanged += new System.EventHandler(this.Den_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "----------";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Somma
            // 
            this.Somma.Location = new System.Drawing.Point(107, 48);
            this.Somma.Name = "Somma";
            this.Somma.Size = new System.Drawing.Size(31, 23);
            this.Somma.TabIndex = 5;
            this.Somma.Text = "+";
            this.Somma.UseVisualStyleBackColor = true;
            this.Somma.Click += new System.EventHandler(this.Somma_Click);
            // 
            // Sottrazione
            // 
            this.Sottrazione.Location = new System.Drawing.Point(107, 86);
            this.Sottrazione.Name = "Sottrazione";
            this.Sottrazione.Size = new System.Drawing.Size(31, 23);
            this.Sottrazione.TabIndex = 6;
            this.Sottrazione.Text = "-";
            this.Sottrazione.UseVisualStyleBackColor = true;
            this.Sottrazione.Click += new System.EventHandler(this.Sottrazione_Click);
            // 
            // Divisione
            // 
            this.Divisione.Location = new System.Drawing.Point(144, 86);
            this.Divisione.Name = "Divisione";
            this.Divisione.Size = new System.Drawing.Size(31, 23);
            this.Divisione.TabIndex = 8;
            this.Divisione.Text = ":";
            this.Divisione.UseVisualStyleBackColor = true;
            this.Divisione.Click += new System.EventHandler(this.Divisione_Click);
            // 
            // Moltiplicazione
            // 
            this.Moltiplicazione.Location = new System.Drawing.Point(144, 48);
            this.Moltiplicazione.Name = "Moltiplicazione";
            this.Moltiplicazione.Size = new System.Drawing.Size(31, 23);
            this.Moltiplicazione.TabIndex = 7;
            this.Moltiplicazione.Text = "X";
            this.Moltiplicazione.UseVisualStyleBackColor = true;
            this.Moltiplicazione.Click += new System.EventHandler(this.Moltiplicazione_Click);
            // 
            // Semplifica
            // 
            this.Semplifica.Location = new System.Drawing.Point(107, 115);
            this.Semplifica.Name = "Semplifica";
            this.Semplifica.Size = new System.Drawing.Size(68, 23);
            this.Semplifica.TabIndex = 9;
            this.Semplifica.Text = "Semplifica";
            this.Semplifica.UseVisualStyleBackColor = true;
            this.Semplifica.Click += new System.EventHandler(this.Semplifica_Click);
            // 
            // Elevamento
            // 
            this.Elevamento.Location = new System.Drawing.Point(107, 144);
            this.Elevamento.Name = "Elevamento";
            this.Elevamento.Size = new System.Drawing.Size(68, 23);
            this.Elevamento.TabIndex = 10;
            this.Elevamento.Text = "Eleva";
            this.Elevamento.UseVisualStyleBackColor = true;
            this.Elevamento.Click += new System.EventHandler(this.Elevamento_Click);
            // 
            // Decimale
            // 
            this.Decimale.Location = new System.Drawing.Point(107, 173);
            this.Decimale.Name = "Decimale";
            this.Decimale.Size = new System.Drawing.Size(68, 23);
            this.Decimale.TabIndex = 11;
            this.Decimale.Text = "Decimale";
            this.Decimale.UseVisualStyleBackColor = true;
            this.Decimale.Click += new System.EventHandler(this.Decimale_Click);
            // 
            // Frazion
            // 
            this.Frazion.Location = new System.Drawing.Point(107, 202);
            this.Frazion.Name = "Frazion";
            this.Frazion.Size = new System.Drawing.Size(68, 23);
            this.Frazion.TabIndex = 12;
            this.Frazion.Text = "Frazione";
            this.Frazion.UseVisualStyleBackColor = true;
            this.Frazion.Click += new System.EventHandler(this.Frazion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 252);
            this.Controls.Add(this.Frazion);
            this.Controls.Add(this.Decimale);
            this.Controls.Add(this.Elevamento);
            this.Controls.Add(this.Semplifica);
            this.Controls.Add(this.Divisione);
            this.Controls.Add(this.Moltiplicazione);
            this.Controls.Add(this.Sottrazione);
            this.Controls.Add(this.Somma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Den);
            this.Controls.Add(this.Num);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox Num;
        private System.Windows.Forms.TextBox Den;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Somma;
        private System.Windows.Forms.Button Sottrazione;
        private System.Windows.Forms.Button Divisione;
        private System.Windows.Forms.Button Moltiplicazione;
        private System.Windows.Forms.Button Semplifica;
        private System.Windows.Forms.Button Elevamento;
        private System.Windows.Forms.Button Decimale;
        private System.Windows.Forms.Button Frazion;
    }
}

