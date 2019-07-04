namespace FinestraArticoli
{
    partial class SellingWindow
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
            this.sellingButton = new System.Windows.Forms.Button();
            this.sellingLabel = new System.Windows.Forms.Label();
            this.sellingDataGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sellingDataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // sellingButton
            // 
            this.sellingButton.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellingButton.Location = new System.Drawing.Point(363, 684);
            this.sellingButton.Name = "sellingButton";
            this.sellingButton.Size = new System.Drawing.Size(299, 91);
            this.sellingButton.TabIndex = 11;
            this.sellingButton.Text = "Vendi";
            this.sellingButton.UseVisualStyleBackColor = true;
            // 
            // sellingLabel
            // 
            this.sellingLabel.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellingLabel.Location = new System.Drawing.Point(12, 22);
            this.sellingLabel.Name = "sellingLabel";
            this.sellingLabel.Size = new System.Drawing.Size(1001, 35);
            this.sellingLabel.TabIndex = 10;
            this.sellingLabel.Text = "Vendita";
            this.sellingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sellingDataGV
            // 
            this.sellingDataGV.BackgroundColor = System.Drawing.Color.White;
            this.sellingDataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellingDataGV.Location = new System.Drawing.Point(12, 75);
            this.sellingDataGV.Name = "sellingDataGV";
            this.sellingDataGV.Size = new System.Drawing.Size(1001, 603);
            this.sellingDataGV.TabIndex = 9;
            // 
            // SellingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1025, 791);
            this.Controls.Add(this.sellingButton);
            this.Controls.Add(this.sellingLabel);
            this.Controls.Add(this.sellingDataGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SellingWindow";
            this.Text = "Vendita";
            this.Load += new System.EventHandler(this.SellingWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sellingDataGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sellingButton;
        private System.Windows.Forms.Label sellingLabel;
        private System.Windows.Forms.DataGridView sellingDataGV;
    }
}