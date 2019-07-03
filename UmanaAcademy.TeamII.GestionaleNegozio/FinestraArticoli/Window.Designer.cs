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
            this.visualButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageVisual = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabPageInitial.SuspendLayout();
            this.tabPageVisual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageInitial);
            this.tabControl.Controls.Add(this.tabPageVisual);
            this.tabControl.Location = new System.Drawing.Point(-1, -1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1458, 744);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageInitial
            // 
            this.tabPageInitial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPageInitial.Controls.Add(this.visualButton);
            this.tabPageInitial.Controls.Add(this.label1);
            this.tabPageInitial.Location = new System.Drawing.Point(4, 22);
            this.tabPageInitial.Name = "tabPageInitial";
            this.tabPageInitial.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInitial.Size = new System.Drawing.Size(1450, 718);
            this.tabPageInitial.TabIndex = 0;
            this.tabPageInitial.Text = "Pagina Iniziale";
            this.tabPageInitial.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // visualButton
            // 
            this.visualButton.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualButton.Location = new System.Drawing.Point(154, 363);
            this.visualButton.Name = "visualButton";
            this.visualButton.Size = new System.Drawing.Size(1148, 145);
            this.visualButton.TabIndex = 1;
            this.visualButton.Text = "Visualizza Articoli";
            this.visualButton.UseVisualStyleBackColor = true;
            this.visualButton.Click += new System.EventHandler(this.VisualButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(462, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 140);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTIONALE NEGOZIO DA MI, TI E TONI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageVisual
            // 
            this.tabPageVisual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPageVisual.Controls.Add(this.dataGridView1);
            this.tabPageVisual.Location = new System.Drawing.Point(4, 22);
            this.tabPageVisual.Name = "tabPageVisual";
            this.tabPageVisual.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVisual.Size = new System.Drawing.Size(1450, 718);
            this.tabPageVisual.TabIndex = 1;
            this.tabPageVisual.Text = "Visualizza Articoli";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1444, 712);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
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
            this.tabControl.ResumeLayout(false);
            this.tabPageInitial.ResumeLayout(false);
            this.tabPageVisual.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageInitial;
        private System.Windows.Forms.TabPage tabPageVisual;
        private System.Windows.Forms.Button visualButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

