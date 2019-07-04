namespace FinestraArticoli
{
    partial class VisualWindow
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
            this.saveProductsButton = new System.Windows.Forms.Button();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.visualLabel = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // saveProductsButton
            // 
            this.saveProductsButton.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveProductsButton.Location = new System.Drawing.Point(365, 688);
            this.saveProductsButton.Name = "saveProductsButton";
            this.saveProductsButton.Size = new System.Drawing.Size(299, 91);
            this.saveProductsButton.TabIndex = 5;
            this.saveProductsButton.Text = "Salva";
            this.saveProductsButton.UseVisualStyleBackColor = true;
            this.saveProductsButton.Click += new System.EventHandler(this.SaveProductsButton_Click);
            // 
            // dataGV
            // 
            this.dataGV.BackgroundColor = System.Drawing.Color.White;
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Location = new System.Drawing.Point(12, 79);
            this.dataGV.Name = "dataGV";
            this.dataGV.Size = new System.Drawing.Size(1001, 603);
            this.dataGV.TabIndex = 4;
            // 
            // visualLabel
            // 
            this.visualLabel.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualLabel.Location = new System.Drawing.Point(360, 18);
            this.visualLabel.Name = "visualLabel";
            this.visualLabel.Size = new System.Drawing.Size(304, 35);
            this.visualLabel.TabIndex = 6;
            this.visualLabel.Text = "Visualizza e Modifica Articoli";
            this.visualLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.visualLabel.Click += new System.EventHandler(this.VisualLabel_Click);
            // 
            // VisualWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1025, 791);
            this.Controls.Add(this.visualLabel);
            this.Controls.Add(this.saveProductsButton);
            this.Controls.Add(this.dataGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VisualWindow";
            this.Text = "Visualizzazione Articoli";
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveProductsButton;
        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.Label visualLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}