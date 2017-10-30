namespace AltyaziProgrami
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
            this.btnAltyaziSec = new System.Windows.Forms.Button();
            this.btn25 = new System.Windows.Forms.Button();
            this.btn50 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btneksi25 = new System.Windows.Forms.Button();
            this.btneksi50 = new System.Windows.Forms.Button();
            this.btneksi1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLoading = new System.Windows.Forms.Label();
            this.txtIcerik = new System.Windows.Forms.RichTextBox();
            this.lblSure = new System.Windows.Forms.Label();
            this.lblAltyaziAdi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAltyaziSec
            // 
            this.btnAltyaziSec.Location = new System.Drawing.Point(13, 13);
            this.btnAltyaziSec.Name = "btnAltyaziSec";
            this.btnAltyaziSec.Size = new System.Drawing.Size(79, 52);
            this.btnAltyaziSec.TabIndex = 0;
            this.btnAltyaziSec.Text = "altyazı seç";
            this.btnAltyaziSec.UseVisualStyleBackColor = true;
            this.btnAltyaziSec.Click += new System.EventHandler(this.btnAltyaziSec_Click);
            // 
            // btn25
            // 
            this.btn25.Location = new System.Drawing.Point(98, 13);
            this.btn25.Name = "btn25";
            this.btn25.Size = new System.Drawing.Size(75, 23);
            this.btn25.TabIndex = 1;
            this.btn25.Text = "0.25 sn";
            this.btn25.UseVisualStyleBackColor = true;
            this.btn25.Click += new System.EventHandler(this.btn25_Click);
            // 
            // btn50
            // 
            this.btn50.Location = new System.Drawing.Point(179, 13);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(75, 23);
            this.btn50.TabIndex = 1;
            this.btn50.Text = "0.50 sn";
            this.btn50.UseVisualStyleBackColor = true;
            this.btn50.Click += new System.EventHandler(this.btn50_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(260, 13);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1 sn";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btneksi25
            // 
            this.btneksi25.Location = new System.Drawing.Point(98, 42);
            this.btneksi25.Name = "btneksi25";
            this.btneksi25.Size = new System.Drawing.Size(75, 23);
            this.btneksi25.TabIndex = 1;
            this.btneksi25.Text = "-0.25 sn";
            this.btneksi25.UseVisualStyleBackColor = true;
            this.btneksi25.Click += new System.EventHandler(this.btneksi25_Click);
            // 
            // btneksi50
            // 
            this.btneksi50.Location = new System.Drawing.Point(179, 42);
            this.btneksi50.Name = "btneksi50";
            this.btneksi50.Size = new System.Drawing.Size(75, 23);
            this.btneksi50.TabIndex = 1;
            this.btneksi50.Text = "-0.50 sn";
            this.btneksi50.UseVisualStyleBackColor = true;
            this.btneksi50.Click += new System.EventHandler(this.btneksi50_Click);
            // 
            // btneksi1
            // 
            this.btneksi1.Location = new System.Drawing.Point(260, 42);
            this.btneksi1.Name = "btneksi1";
            this.btneksi1.Size = new System.Drawing.Size(75, 23);
            this.btneksi1.TabIndex = 1;
            this.btneksi1.Text = "-1 sn";
            this.btneksi1.UseVisualStyleBackColor = true;
            this.btneksi1.Click += new System.EventHandler(this.btneksi1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLoading);
            this.groupBox1.Controls.Add(this.txtIcerik);
            this.groupBox1.Controls.Add(this.lblSure);
            this.groupBox1.Controls.Add(this.lblAltyaziAdi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 206);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "altyazı bilgileri";
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.ForeColor = System.Drawing.Color.Red;
            this.lblLoading.Location = new System.Drawing.Point(115, 30);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(135, 13);
            this.lblLoading.TabIndex = 3;
            this.lblLoading.Text = "ALTYAZI YÜKLENİYOR ...";
            this.lblLoading.Visible = false;
            // 
            // txtIcerik
            // 
            this.txtIcerik.Location = new System.Drawing.Point(57, 85);
            this.txtIcerik.Name = "txtIcerik";
            this.txtIcerik.Size = new System.Drawing.Size(242, 111);
            this.txtIcerik.TabIndex = 2;
            this.txtIcerik.Text = "";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(54, 59);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(16, 13);
            this.lblSure.TabIndex = 1;
            this.lblSure.Text = "...";
            // 
            // lblAltyaziAdi
            // 
            this.lblAltyaziAdi.AutoSize = true;
            this.lblAltyaziAdi.Location = new System.Drawing.Point(54, 31);
            this.lblAltyaziAdi.Name = "lblAltyaziAdi";
            this.lblAltyaziAdi.Size = new System.Drawing.Size(16, 13);
            this.lblAltyaziAdi.TabIndex = 1;
            this.lblAltyaziAdi.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "içerik :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "süre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "adı :";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(179, 286);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(263, 286);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.btnAltyaziSec);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.btn25);
            this.panel1.Controls.Add(this.btnTemizle);
            this.panel1.Controls.Add(this.btn50);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btneksi25);
            this.panel1.Controls.Add(this.btneksi1);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btneksi50);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 318);
            this.panel1.TabIndex = 4;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(98, 286);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 328);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Altyazi Programı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltyaziSec;
        private System.Windows.Forms.Button btn25;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btneksi25;
        private System.Windows.Forms.Button btneksi50;
        private System.Windows.Forms.Button btneksi1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAltyaziAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtIcerik;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Button btnKaydet;
    }
}

