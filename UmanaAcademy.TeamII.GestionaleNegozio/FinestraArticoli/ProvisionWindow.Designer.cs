﻿namespace FinestraArticoli
{
    partial class ProvisionWindow
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
            this.provisionDataGV = new System.Windows.Forms.DataGridView();
            this.provisionLabel = new System.Windows.Forms.Label();
            this.provisionButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.provisionDataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // provisionDataGV
            // 
            this.provisionDataGV.BackgroundColor = System.Drawing.Color.White;
            this.provisionDataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.provisionDataGV.Location = new System.Drawing.Point(12, 75);
            this.provisionDataGV.Name = "provisionDataGV";
            this.provisionDataGV.Size = new System.Drawing.Size(1001, 603);
            this.provisionDataGV.TabIndex = 0;
            // 
            // provisionLabel
            // 
            this.provisionLabel.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provisionLabel.Location = new System.Drawing.Point(12, 22);
            this.provisionLabel.Name = "provisionLabel";
            this.provisionLabel.Size = new System.Drawing.Size(1001, 35);
            this.provisionLabel.TabIndex = 7;
            this.provisionLabel.Text = "Rifornimento";
            this.provisionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.provisionLabel.Click += new System.EventHandler(this.ProvisionLabel_Click);
            // 
            // provisionButton
            // 
            this.provisionButton.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provisionButton.Location = new System.Drawing.Point(363, 684);
            this.provisionButton.Name = "provisionButton";
            this.provisionButton.Size = new System.Drawing.Size(299, 91);
            this.provisionButton.TabIndex = 8;
            this.provisionButton.Text = "Compra";
            this.provisionButton.UseVisualStyleBackColor = true;
            this.provisionButton.Click += new System.EventHandler(this.ProvisionButton_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "products.csv";
            // 
            // ProvisionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1025, 791);
            this.Controls.Add(this.provisionButton);
            this.Controls.Add(this.provisionLabel);
            this.Controls.Add(this.provisionDataGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProvisionWindow";
            this.Text = "Rifornimento";
            this.Load += new System.EventHandler(this.ProvisionWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.provisionDataGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView provisionDataGV;
        private System.Windows.Forms.Label provisionLabel;
        private System.Windows.Forms.Button provisionButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}