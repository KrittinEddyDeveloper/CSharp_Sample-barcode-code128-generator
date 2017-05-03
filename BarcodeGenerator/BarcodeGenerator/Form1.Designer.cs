namespace BarcodeGenerator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.pbBarcode = new System.Windows.Forms.PictureBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("supermarket", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(98, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barcode Generator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("supermarket", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(18, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Text for Create Barcode";
            // 
            // txtText
            // 
            this.txtText.Font = new System.Drawing.Font("supermarket", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtText.Location = new System.Drawing.Point(22, 90);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(236, 35);
            this.txtText.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnGenerate.Location = new System.Drawing.Point(272, 90);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(91, 35);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // pbBarcode
            // 
            this.pbBarcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBarcode.Location = new System.Drawing.Point(22, 139);
            this.pbBarcode.Name = "pbBarcode";
            this.pbBarcode.Size = new System.Drawing.Size(341, 102);
            this.pbBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBarcode.TabIndex = 3;
            this.pbBarcode.TabStop = false;
            // 
            // lblBarcode
            // 
            this.lblBarcode.Font = new System.Drawing.Font("supermarket", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblBarcode.Location = new System.Drawing.Point(23, 217);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(339, 20);
            this.lblBarcode.TabIndex = 4;
            this.lblBarcode.Text = "-";
            this.lblBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.pbBarcode);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Barcode Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pbBarcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.PictureBox pbBarcode;
        private System.Windows.Forms.Label lblBarcode;
    }
}

