namespace FinestraArticoli
{
    partial class window
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.visualButton = new System.Windows.Forms.Button();
            this.provisionButton = new System.Windows.Forms.Button();
            this.sellingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 73);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1115, 140);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "GESTIONALE NEGOZIO DA MI, TI E TONI";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.Click += new System.EventHandler(this.TitleLabel_Click);
            // 
            // visualButton
            // 
            this.visualButton.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualButton.Location = new System.Drawing.Point(41, 331);
            this.visualButton.Name = "visualButton";
            this.visualButton.Size = new System.Drawing.Size(299, 145);
            this.visualButton.TabIndex = 1;
            this.visualButton.Text = "Visualizza Articoli";
            this.visualButton.UseVisualStyleBackColor = true;
            this.visualButton.Click += new System.EventHandler(this.VisualButton_Click);
            // 
            // provisionButton
            // 
            this.provisionButton.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provisionButton.Location = new System.Drawing.Point(422, 331);
            this.provisionButton.Name = "provisionButton";
            this.provisionButton.Size = new System.Drawing.Size(299, 145);
            this.provisionButton.TabIndex = 2;
            this.provisionButton.Text = "Rifornimento";
            this.provisionButton.UseVisualStyleBackColor = true;
            this.provisionButton.Click += new System.EventHandler(this.ProvisionButton_Click);
            // 
            // sellingButton
            // 
            this.sellingButton.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellingButton.Location = new System.Drawing.Point(808, 331);
            this.sellingButton.Name = "sellingButton";
            this.sellingButton.Size = new System.Drawing.Size(299, 145);
            this.sellingButton.TabIndex = 3;
            this.sellingButton.Text = "Vendita";
            this.sellingButton.UseVisualStyleBackColor = true;
            this.sellingButton.Click += new System.EventHandler(this.SellingButton_Click);
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1139, 609);
            this.Controls.Add(this.sellingButton);
            this.Controls.Add(this.provisionButton);
            this.Controls.Add(this.visualButton);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "window";
            this.Text = "Gestionale Negozio da Mi, Ti & Toni";
            this.Load += new System.EventHandler(this.Window_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button visualButton;
        private System.Windows.Forms.Button provisionButton;
        private System.Windows.Forms.Button sellingButton;
    }
}

