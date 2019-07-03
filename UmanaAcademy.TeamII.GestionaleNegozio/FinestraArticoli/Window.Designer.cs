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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageInitial = new System.Windows.Forms.TabPage();
            this.sellingButton = new System.Windows.Forms.Button();
            this.provisionButton = new System.Windows.Forms.Button();
            this.visualButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.tabPageVisual = new System.Windows.Forms.TabPage();
            this.saveProductsButton = new System.Windows.Forms.Button();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.tabPageProvision = new System.Windows.Forms.TabPage();
            this.tabPageSelling = new System.Windows.Forms.TabPage();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageInitial.SuspendLayout();
            this.tabPageVisual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageInitial);
            this.tabControl.Controls.Add(this.tabPageVisual);
            this.tabControl.Controls.Add(this.tabPageProvision);
            this.tabControl.Controls.Add(this.tabPageSelling);
            this.tabControl.Location = new System.Drawing.Point(-1, -1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1458, 744);
            this.tabControl.TabIndex = 0;
            this.tabControl.Click += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPageInitial
            // 
            this.tabPageInitial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPageInitial.Controls.Add(this.button1);
            this.tabPageInitial.Controls.Add(this.sellingButton);
            this.tabPageInitial.Controls.Add(this.provisionButton);
            this.tabPageInitial.Controls.Add(this.visualButton);
            this.tabPageInitial.Controls.Add(this.titleLabel);
            this.tabPageInitial.Location = new System.Drawing.Point(4, 22);
            this.tabPageInitial.Name = "tabPageInitial";
            this.tabPageInitial.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInitial.Size = new System.Drawing.Size(1450, 718);
            this.tabPageInitial.TabIndex = 0;
            this.tabPageInitial.Text = "Pagina Iniziale";
            this.tabPageInitial.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // sellingButton
            // 
            this.sellingButton.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellingButton.Location = new System.Drawing.Point(1035, 363);
            this.sellingButton.Name = "sellingButton";
            this.sellingButton.Size = new System.Drawing.Size(299, 145);
            this.sellingButton.TabIndex = 3;
            this.sellingButton.Text = "Vendita";
            this.sellingButton.UseVisualStyleBackColor = true;
            // 
            // provisionButton
            // 
            this.provisionButton.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provisionButton.Location = new System.Drawing.Point(589, 363);
            this.provisionButton.Name = "provisionButton";
            this.provisionButton.Size = new System.Drawing.Size(299, 145);
            this.provisionButton.TabIndex = 2;
            this.provisionButton.Text = "Rifornimento";
            this.provisionButton.UseVisualStyleBackColor = true;
            this.provisionButton.Click += new System.EventHandler(this.ProvisionButton_Click);
            // 
            // visualButton
            // 
            this.visualButton.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualButton.Location = new System.Drawing.Point(154, 363);
            this.visualButton.Name = "visualButton";
            this.visualButton.Size = new System.Drawing.Size(299, 145);
            this.visualButton.TabIndex = 1;
            this.visualButton.Text = "Visualizza Articoli";
            this.visualButton.UseVisualStyleBackColor = true;
            this.visualButton.Click += new System.EventHandler(this.VisualButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(462, 59);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(481, 140);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "GESTIONALE NEGOZIO DA MI, TI E TONI";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageVisual
            // 
            this.tabPageVisual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPageVisual.Controls.Add(this.saveProductsButton);
            this.tabPageVisual.Controls.Add(this.dataGV);
            this.tabPageVisual.Location = new System.Drawing.Point(4, 22);
            this.tabPageVisual.Name = "tabPageVisual";
            this.tabPageVisual.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVisual.Size = new System.Drawing.Size(1450, 718);
            this.tabPageVisual.TabIndex = 1;
            this.tabPageVisual.Text = "Visualizza Articoli";
            // 
            // saveProductsButton
            // 
            this.saveProductsButton.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveProductsButton.Location = new System.Drawing.Point(589, 612);
            this.saveProductsButton.Name = "saveProductsButton";
            this.saveProductsButton.Size = new System.Drawing.Size(299, 91);
            this.saveProductsButton.TabIndex = 3;
            this.saveProductsButton.Text = "Salva";
            this.saveProductsButton.UseVisualStyleBackColor = true;
            // 
            // dataGV
            // 
            this.dataGV.BackgroundColor = System.Drawing.Color.White;
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Location = new System.Drawing.Point(3, 3);
            this.dataGV.Name = "dataGV";
            this.dataGV.Size = new System.Drawing.Size(1444, 603);
            this.dataGV.TabIndex = 0;
            this.dataGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // tabPageProvision
            // 
            this.tabPageProvision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPageProvision.Location = new System.Drawing.Point(4, 22);
            this.tabPageProvision.Name = "tabPageProvision";
            this.tabPageProvision.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProvision.Size = new System.Drawing.Size(1450, 718);
            this.tabPageProvision.TabIndex = 2;
            this.tabPageProvision.Text = "Rifornimento";
            // 
            // tabPageSelling
            // 
            this.tabPageSelling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPageSelling.Location = new System.Drawing.Point(4, 22);
            this.tabPageSelling.Name = "tabPageSelling";
            this.tabPageSelling.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelling.Size = new System.Drawing.Size(1450, 718);
            this.tabPageSelling.TabIndex = 3;
            this.tabPageSelling.Text = "Vendita";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 738);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "window";
            this.Text = "Gestionale Negozio da Mi, Ti & Toni";
            this.Load += new System.EventHandler(this.Window_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageInitial.ResumeLayout(false);
            this.tabPageVisual.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageInitial;
        private System.Windows.Forms.TabPage tabPageVisual;
        private System.Windows.Forms.Button visualButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.Button sellingButton;
        private System.Windows.Forms.Button provisionButton;
        private System.Windows.Forms.TabPage tabPageProvision;
        private System.Windows.Forms.TabPage tabPageSelling;
        private System.Windows.Forms.Button saveProductsButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button button1;
    }
}

