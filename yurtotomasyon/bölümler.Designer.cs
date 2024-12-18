namespace yurtotomasyon
{
    partial class bölümler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bölümler));
            this.btnIDR = new System.Windows.Forms.Button();
            this.gvnlk = new System.Windows.Forms.Button();
            this.btnTMZ = new System.Windows.Forms.Button();
            this.btnYMK = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnPDZN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIDR
            // 
            this.btnIDR.BackColor = System.Drawing.Color.Silver;
            this.btnIDR.Location = new System.Drawing.Point(42, 203);
            this.btnIDR.Name = "btnIDR";
            this.btnIDR.Size = new System.Drawing.Size(170, 127);
            this.btnIDR.TabIndex = 0;
            this.btnIDR.Text = "İdare";
            this.btnIDR.UseVisualStyleBackColor = false;
            this.btnIDR.Click += new System.EventHandler(this.btnIDR_Click);
            // 
            // gvnlk
            // 
            this.gvnlk.BackColor = System.Drawing.Color.Silver;
            this.gvnlk.Location = new System.Drawing.Point(648, 203);
            this.gvnlk.Name = "gvnlk";
            this.gvnlk.Size = new System.Drawing.Size(170, 127);
            this.gvnlk.TabIndex = 1;
            this.gvnlk.Text = "Güvenlik";
            this.gvnlk.UseVisualStyleBackColor = false;
            this.gvnlk.Click += new System.EventHandler(this.gvnlk_Click);
            // 
            // btnTMZ
            // 
            this.btnTMZ.BackColor = System.Drawing.Color.Silver;
            this.btnTMZ.Location = new System.Drawing.Point(867, 203);
            this.btnTMZ.Name = "btnTMZ";
            this.btnTMZ.Size = new System.Drawing.Size(170, 127);
            this.btnTMZ.TabIndex = 2;
            this.btnTMZ.Text = "Temizlik";
            this.btnTMZ.UseVisualStyleBackColor = false;
            this.btnTMZ.Click += new System.EventHandler(this.btnTMZ_Click);
            // 
            // btnYMK
            // 
            this.btnYMK.BackColor = System.Drawing.Color.Silver;
            this.btnYMK.Location = new System.Drawing.Point(249, 203);
            this.btnYMK.Name = "btnYMK";
            this.btnYMK.Size = new System.Drawing.Size(170, 127);
            this.btnYMK.TabIndex = 3;
            this.btnYMK.Text = "Yemekhane";
            this.btnYMK.UseVisualStyleBackColor = false;
            this.btnYMK.Click += new System.EventHandler(this.btnYMK_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Silver;
            this.button5.Location = new System.Drawing.Point(448, 203);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(170, 127);
            this.button5.TabIndex = 4;
            this.button5.Text = "Çamaşırhane";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnPDZN
            // 
            this.btnPDZN.BackColor = System.Drawing.Color.Silver;
            this.btnPDZN.Location = new System.Drawing.Point(42, 389);
            this.btnPDZN.Name = "btnPDZN";
            this.btnPDZN.Size = new System.Drawing.Size(995, 118);
            this.btnPDZN.TabIndex = 5;
            this.btnPDZN.Text = "Personelleri Düzenle";
            this.btnPDZN.UseVisualStyleBackColor = false;
            this.btnPDZN.Click += new System.EventHandler(this.btnPDZN_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(42, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(347, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // bölümler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1086, 575);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPDZN);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnYMK);
            this.Controls.Add(this.btnTMZ);
            this.Controls.Add(this.gvnlk);
            this.Controls.Add(this.btnIDR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bölümler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bölümler";
            this.Load += new System.EventHandler(this.bölümler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIDR;
        private System.Windows.Forms.Button gvnlk;
        private System.Windows.Forms.Button btnTMZ;
        private System.Windows.Forms.Button btnYMK;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnPDZN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}