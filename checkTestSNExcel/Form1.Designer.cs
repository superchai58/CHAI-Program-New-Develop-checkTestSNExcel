namespace checkTestSNExcel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbLoad = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtScanSN = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbReult = new System.Windows.Forms.Label();
            this.ofdExcel = new System.Windows.Forms.OpenFileDialog();
            this.bgwUpload = new System.ComponentModel.BackgroundWorker();
            this.bgwChkSN = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLoad)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(416, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 311);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HOW TO";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pcbLoad);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 146);
            this.panel1.TabIndex = 1;
            // 
            // pcbLoad
            // 
            this.pcbLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbLoad.Image = global::checkTestSNExcel.Properties.Resources.Loading;
            this.pcbLoad.Location = new System.Drawing.Point(0, 0);
            this.pcbLoad.Name = "pcbLoad";
            this.pcbLoad.Size = new System.Drawing.Size(324, 146);
            this.pcbLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbLoad.TabIndex = 0;
            this.pcbLoad.TabStop = false;
            this.pcbLoad.Visible = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 279);
            this.label1.TabIndex = 0;
            this.label1.Text = "\r\n1. Click upload excel(In excel, colum has to be removed, leaving only the colum" +
    " named \"Unit\".)\r\n2. Scan serial number in textbox\r\n3. Reult (OK, SN not found du" +
    "plicate) \r\nand (NG, SN found duplicate)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpload);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Upload Excel";
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnUpload.BackgroundImage = global::checkTestSNExcel.Properties.Resources.upload_icon;
            this.btnUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpload.Location = new System.Drawing.Point(6, 34);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(404, 53);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtScanSN);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 100);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(416, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Scan Serial number";
            // 
            // txtScanSN
            // 
            this.txtScanSN.Location = new System.Drawing.Point(6, 43);
            this.txtScanSN.MaxLength = 23;
            this.txtScanSN.Name = "txtScanSN";
            this.txtScanSN.Size = new System.Drawing.Size(404, 33);
            this.txtScanSN.TabIndex = 1;
            this.txtScanSN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtScanSN_KeyDown);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbReult);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(0, 200);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(416, 111);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Result";
            // 
            // lbReult
            // 
            this.lbReult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbReult.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReult.Location = new System.Drawing.Point(6, 29);
            this.lbReult.Name = "lbReult";
            this.lbReult.Size = new System.Drawing.Size(404, 72);
            this.lbReult.TabIndex = 0;
            this.lbReult.Text = "000000000000000000000000000000000000000000000000000000000000000000000000000000000" +
    "0\r\n";
            // 
            // ofdExcel
            // 
            this.ofdExcel.FileName = "ofdExcel";
            // 
            // bgwUpload
            // 
            this.bgwUpload.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwUpload_DoWork);
            this.bgwUpload.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwUpload_RunWorkerCompleted);
            // 
            // bgwChkSN
            // 
            this.bgwChkSN.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwChkSN_DoWork);
            this.bgwChkSN.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwChkSN_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(746, 311);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckTestSNFromExcel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLoad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtScanSN;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbReult;
        private System.Windows.Forms.OpenFileDialog ofdExcel;
        private System.ComponentModel.BackgroundWorker bgwUpload;
        private System.ComponentModel.BackgroundWorker bgwChkSN;
    }
}

