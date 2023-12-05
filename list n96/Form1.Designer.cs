namespace list_n96
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
            this.lbKisiler = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnSira = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAzalan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnArtan = new System.Windows.Forms.Button();
            this.btnBesHarf = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnBosalt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbKisiler
            // 
            this.lbKisiler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbKisiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbKisiler.FormattingEnabled = true;
            this.lbKisiler.ItemHeight = 16;
            this.lbKisiler.Location = new System.Drawing.Point(197, 12);
            this.lbKisiler.Name = "lbKisiler";
            this.lbKisiler.Size = new System.Drawing.Size(185, 420);
            this.lbKisiler.TabIndex = 0;
            this.lbKisiler.SelectedIndexChanged += new System.EventHandler(this.lbKisiler_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEkle.Location = new System.Drawing.Point(12, 64);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(91, 43);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "KİŞİ EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(12, 12);
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(179, 30);
            this.txtAd.TabIndex = 2;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAra.Location = new System.Drawing.Point(100, 64);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(91, 43);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnSira
            // 
            this.btnSira.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSira.Location = new System.Drawing.Point(12, 113);
            this.btnSira.Name = "btnSira";
            this.btnSira.Size = new System.Drawing.Size(91, 43);
            this.btnSira.TabIndex = 4;
            this.btnSira.Text = "SIRA";
            this.btnSira.UseVisualStyleBackColor = false;
            this.btnSira.Click += new System.EventHandler(this.btnSira_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSil.Location = new System.Drawing.Point(100, 113);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(91, 43);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "REMOVEAT İLE SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRemove.Location = new System.Drawing.Point(12, 162);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(91, 43);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "REMOVE İLE SİL";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAzalan
            // 
            this.btnAzalan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAzalan.Location = new System.Drawing.Point(100, 162);
            this.btnAzalan.Name = "btnAzalan";
            this.btnAzalan.Size = new System.Drawing.Size(91, 43);
            this.btnAzalan.TabIndex = 7;
            this.btnAzalan.Text = "KAYDET";
            this.btnAzalan.UseVisualStyleBackColor = false;
            this.btnAzalan.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(100, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "AZALAN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnArtan
            // 
            this.btnArtan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnArtan.Location = new System.Drawing.Point(12, 211);
            this.btnArtan.Name = "btnArtan";
            this.btnArtan.Size = new System.Drawing.Size(91, 43);
            this.btnArtan.TabIndex = 9;
            this.btnArtan.Text = "ARTAN";
            this.btnArtan.UseVisualStyleBackColor = false;
            this.btnArtan.Click += new System.EventHandler(this.btnArtan_Click);
            // 
            // btnBesHarf
            // 
            this.btnBesHarf.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBesHarf.Location = new System.Drawing.Point(12, 260);
            this.btnBesHarf.Name = "btnBesHarf";
            this.btnBesHarf.Size = new System.Drawing.Size(91, 43);
            this.btnBesHarf.TabIndex = 10;
            this.btnBesHarf.Text = "5 HARFLİ KİŞİ";
            this.btnBesHarf.UseVisualStyleBackColor = false;
            this.btnBesHarf.Click += new System.EventHandler(this.btnBesHarf_Click);
            // 
            // btnM
            // 
            this.btnM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnM.Location = new System.Drawing.Point(100, 260);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(91, 43);
            this.btnM.TabIndex = 11;
            this.btnM.Text = "\"M\" HARFİ İLE BAŞLAYAN KİŞİ";
            this.btnM.UseVisualStyleBackColor = false;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnBosalt
            // 
            this.btnBosalt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBosalt.Location = new System.Drawing.Point(12, 309);
            this.btnBosalt.Name = "btnBosalt";
            this.btnBosalt.Size = new System.Drawing.Size(91, 43);
            this.btnBosalt.TabIndex = 12;
            this.btnBosalt.Text = "LİSTEYİ BOŞALT";
            this.btnBosalt.UseVisualStyleBackColor = false;
            this.btnBosalt.Click += new System.EventHandler(this.btnBosalt_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(100, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 43);
            this.button2.TabIndex = 13;
            this.button2.Text = "SONU \"A\" İLE BİTEN KİŞİ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(398, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBosalt);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnBesHarf);
            this.Controls.Add(this.btnArtan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAzalan);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnSira);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lbKisiler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbKisiler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnSira;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAzalan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnArtan;
        private System.Windows.Forms.Button btnBesHarf;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnBosalt;
        private System.Windows.Forms.Button button2;
    }
}

