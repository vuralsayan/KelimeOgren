namespace KelimeOgren
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
            this.components = new System.ComponentModel.Container();
            this.TxtTurkce = new System.Windows.Forms.TextBox();
            this.LblSure = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblKelime = new System.Windows.Forms.Label();
            this.LblCevap = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LblKullanıcıAd = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.Txtİngilizce = new System.Windows.Forms.TextBox();
            this.BtnBilmiyorum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtTurkce
            // 
            this.TxtTurkce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(157)))), ((int)(((byte)(176)))));
            this.TxtTurkce.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTurkce.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTurkce.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TxtTurkce.Location = new System.Drawing.Point(2, 145);
            this.TxtTurkce.Name = "TxtTurkce";
            this.TxtTurkce.Size = new System.Drawing.Size(684, 31);
            this.TxtTurkce.TabIndex = 1;
            this.TxtTurkce.TextChanged += new System.EventHandler(this.TxtTurkce_TextChanged);
            // 
            // LblSure
            // 
            this.LblSure.AutoSize = true;
            this.LblSure.BackColor = System.Drawing.Color.Transparent;
            this.LblSure.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LblSure.Location = new System.Drawing.Point(639, 9);
            this.LblSure.Name = "LblSure";
            this.LblSure.Size = new System.Drawing.Size(47, 32);
            this.LblSure.TabIndex = 5;
            this.LblSure.Text = "90";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(424, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Puan:";
            // 
            // LblKelime
            // 
            this.LblKelime.AutoSize = true;
            this.LblKelime.BackColor = System.Drawing.Color.Transparent;
            this.LblKelime.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKelime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LblKelime.Location = new System.Drawing.Point(506, 197);
            this.LblKelime.Name = "LblKelime";
            this.LblKelime.Size = new System.Drawing.Size(31, 32);
            this.LblKelime.TabIndex = 7;
            this.LblKelime.Text = "0";
            // 
            // LblCevap
            // 
            this.LblCevap.AutoSize = true;
            this.LblCevap.Location = new System.Drawing.Point(26, 197);
            this.LblCevap.Name = "LblCevap";
            this.LblCevap.Size = new System.Drawing.Size(60, 24);
            this.LblCevap.TabIndex = 8;
            this.LblCevap.Text = "cevap";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LblKullanıcıAd
            // 
            this.LblKullanıcıAd.AutoSize = true;
            this.LblKullanıcıAd.BackColor = System.Drawing.Color.Transparent;
            this.LblKullanıcıAd.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKullanıcıAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LblKullanıcıAd.Location = new System.Drawing.Point(12, 9);
            this.LblKullanıcıAd.Name = "LblKullanıcıAd";
            this.LblKullanıcıAd.Size = new System.Drawing.Size(91, 32);
            this.LblKullanıcıAd.TabIndex = 11;
            this.LblKullanıcıAd.Text = "label4";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(1)))), ((int)(((byte)(200)))));
            this.BtnKaydet.FlatAppearance.BorderSize = 0;
            this.BtnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKaydet.ForeColor = System.Drawing.Color.White;
            this.BtnKaydet.Location = new System.Drawing.Point(309, 242);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(162, 44);
            this.BtnKaydet.TabIndex = 12;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // Txtİngilizce
            // 
            this.Txtİngilizce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(157)))), ((int)(((byte)(176)))));
            this.Txtİngilizce.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txtİngilizce.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtİngilizce.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Txtİngilizce.Location = new System.Drawing.Point(2, 90);
            this.Txtİngilizce.Name = "Txtİngilizce";
            this.Txtİngilizce.Size = new System.Drawing.Size(684, 31);
            this.Txtİngilizce.TabIndex = 10;
            // 
            // BtnBilmiyorum
            // 
            this.BtnBilmiyorum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(1)))), ((int)(((byte)(200)))));
            this.BtnBilmiyorum.FlatAppearance.BorderSize = 0;
            this.BtnBilmiyorum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBilmiyorum.ForeColor = System.Drawing.Color.White;
            this.BtnBilmiyorum.Location = new System.Drawing.Point(477, 242);
            this.BtnBilmiyorum.Name = "BtnBilmiyorum";
            this.BtnBilmiyorum.Size = new System.Drawing.Size(162, 44);
            this.BtnBilmiyorum.TabIndex = 14;
            this.BtnBilmiyorum.Text = "Bilmiyorum";
            this.BtnBilmiyorum.UseVisualStyleBackColor = false;
            this.BtnBilmiyorum.Click += new System.EventHandler(this.BtnBilmiyorum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(109)))), ((int)(((byte)(182)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(689, 312);
            this.Controls.Add(this.BtnBilmiyorum);
            this.Controls.Add(this.TxtTurkce);
            this.Controls.Add(this.Txtİngilizce);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.LblKullanıcıAd);
            this.Controls.Add(this.LblCevap);
            this.Controls.Add(this.LblKelime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblSure);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelime Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtTurkce;
        private System.Windows.Forms.Label LblSure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblKelime;
        private System.Windows.Forms.Label LblCevap;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LblKullanıcıAd;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.TextBox Txtİngilizce;
        private System.Windows.Forms.Button BtnBilmiyorum;
    }
}

