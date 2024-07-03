namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.maskedTextBoxbaslangic = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxbitis = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxgiris = new System.Windows.Forms.GroupBox();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCift = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listViewcift = new System.Windows.Forms.ListView();
            this.tabPageTek = new System.Windows.Forms.TabPage();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listViewtek = new System.Windows.Forms.ListView();
            this.tabPageAsal = new System.Windows.Forms.TabPage();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.listViewasal = new System.Windows.Forms.ListView();
            this.tabPageMukemmel = new System.Windows.Forms.TabPage();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.listBox8 = new System.Windows.Forms.ListBox();
            this.listViewmukemmel = new System.Windows.Forms.ListView();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxgiris.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageCift.SuspendLayout();
            this.tabPageTek.SuspendLayout();
            this.tabPageAsal.SuspendLayout();
            this.tabPageMukemmel.SuspendLayout();
            this.SuspendLayout();
            // 
            // maskedTextBoxbaslangic
            // 
            this.maskedTextBoxbaslangic.Location = new System.Drawing.Point(212, 29);
            this.maskedTextBoxbaslangic.Name = "maskedTextBoxbaslangic";
            this.maskedTextBoxbaslangic.Size = new System.Drawing.Size(119, 22);
            this.maskedTextBoxbaslangic.TabIndex = 0;
            // 
            // maskedTextBoxbitis
            // 
            this.maskedTextBoxbitis.Location = new System.Drawing.Point(212, 95);
            this.maskedTextBoxbitis.Name = "maskedTextBoxbitis";
            this.maskedTextBoxbitis.Size = new System.Drawing.Size(119, 22);
            this.maskedTextBoxbitis.TabIndex = 1;
            // 
            // groupBoxgiris
            // 
            this.groupBoxgiris.BackColor = System.Drawing.Color.Linen;
            this.groupBoxgiris.Controls.Add(this.BtnHesapla);
            this.groupBoxgiris.Controls.Add(this.label2);
            this.groupBoxgiris.Controls.Add(this.label1);
            this.groupBoxgiris.Controls.Add(this.maskedTextBoxbaslangic);
            this.groupBoxgiris.Controls.Add(this.maskedTextBoxbitis);
            this.groupBoxgiris.Location = new System.Drawing.Point(67, 12);
            this.groupBoxgiris.Name = "groupBoxgiris";
            this.groupBoxgiris.Size = new System.Drawing.Size(475, 188);
            this.groupBoxgiris.TabIndex = 2;
            this.groupBoxgiris.TabStop = false;
            this.groupBoxgiris.Text = "Giriş Bilgileri";
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.BackColor = System.Drawing.Color.BurlyWood;
            this.BtnHesapla.Location = new System.Drawing.Point(362, 129);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(95, 40);
            this.BtnHesapla.TabIndex = 4;
            this.BtnHesapla.Text = "Hesapla";
            this.BtnHesapla.UseVisualStyleBackColor = false;
            this.BtnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bitiş";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Başlangıç";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCift);
            this.tabControl1.Controls.Add(this.tabPageTek);
            this.tabControl1.Controls.Add(this.tabPageAsal);
            this.tabControl1.Controls.Add(this.tabPageMukemmel);
            this.tabControl1.Location = new System.Drawing.Point(67, 249);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(475, 217);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPageCift
            // 
            this.tabPageCift.BackColor = System.Drawing.Color.Linen;
            this.tabPageCift.Controls.Add(this.label4);
            this.tabPageCift.Controls.Add(this.label3);
            this.tabPageCift.Controls.Add(this.listBox2);
            this.tabPageCift.Controls.Add(this.listBox1);
            this.tabPageCift.Controls.Add(this.listViewcift);
            this.tabPageCift.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageCift.Location = new System.Drawing.Point(4, 25);
            this.tabPageCift.Name = "tabPageCift";
            this.tabPageCift.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCift.Size = new System.Drawing.Size(467, 188);
            this.tabPageCift.TabIndex = 0;
            this.tabPageCift.Text = "Çift Sayılar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Çift Sayıların Toplamı";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(288, 37);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(129, 36);
            this.listBox2.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(288, 104);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(129, 36);
            this.listBox1.TabIndex = 7;
            // 
            // listViewcift
            // 
            this.listViewcift.HideSelection = false;
            this.listViewcift.Location = new System.Drawing.Point(19, 16);
            this.listViewcift.Name = "listViewcift";
            this.listViewcift.Size = new System.Drawing.Size(238, 135);
            this.listViewcift.TabIndex = 6;
            this.listViewcift.UseCompatibleStateImageBehavior = false;
            // 
            // tabPageTek
            // 
            this.tabPageTek.BackColor = System.Drawing.Color.Linen;
            this.tabPageTek.Controls.Add(this.listBox3);
            this.tabPageTek.Controls.Add(this.listBox4);
            this.tabPageTek.Controls.Add(this.listViewtek);
            this.tabPageTek.Location = new System.Drawing.Point(4, 25);
            this.tabPageTek.Name = "tabPageTek";
            this.tabPageTek.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTek.Size = new System.Drawing.Size(467, 188);
            this.tabPageTek.TabIndex = 1;
            this.tabPageTek.Text = "Tek Sayılar";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(294, 44);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(116, 36);
            this.listBox3.TabIndex = 10;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Location = new System.Drawing.Point(294, 98);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(116, 36);
            this.listBox4.TabIndex = 9;
            // 
            // listViewtek
            // 
            this.listViewtek.HideSelection = false;
            this.listViewtek.Location = new System.Drawing.Point(19, 22);
            this.listViewtek.Name = "listViewtek";
            this.listViewtek.Size = new System.Drawing.Size(239, 138);
            this.listViewtek.TabIndex = 0;
            this.listViewtek.UseCompatibleStateImageBehavior = false;
            // 
            // tabPageAsal
            // 
            this.tabPageAsal.BackColor = System.Drawing.Color.Linen;
            this.tabPageAsal.Controls.Add(this.listBox5);
            this.tabPageAsal.Controls.Add(this.listBox6);
            this.tabPageAsal.Controls.Add(this.listViewasal);
            this.tabPageAsal.Location = new System.Drawing.Point(4, 25);
            this.tabPageAsal.Name = "tabPageAsal";
            this.tabPageAsal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAsal.Size = new System.Drawing.Size(467, 188);
            this.tabPageAsal.TabIndex = 2;
            this.tabPageAsal.Text = "Asal Sayılar";
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 16;
            this.listBox5.Location = new System.Drawing.Point(297, 40);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(116, 36);
            this.listBox5.TabIndex = 10;
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.ItemHeight = 16;
            this.listBox6.Location = new System.Drawing.Point(297, 93);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(116, 36);
            this.listBox6.TabIndex = 9;
            // 
            // listViewasal
            // 
            this.listViewasal.HideSelection = false;
            this.listViewasal.Location = new System.Drawing.Point(31, 25);
            this.listViewasal.Name = "listViewasal";
            this.listViewasal.Size = new System.Drawing.Size(226, 127);
            this.listViewasal.TabIndex = 0;
            this.listViewasal.UseCompatibleStateImageBehavior = false;
            // 
            // tabPageMukemmel
            // 
            this.tabPageMukemmel.BackColor = System.Drawing.Color.Linen;
            this.tabPageMukemmel.Controls.Add(this.listBox7);
            this.tabPageMukemmel.Controls.Add(this.listBox8);
            this.tabPageMukemmel.Controls.Add(this.listViewmukemmel);
            this.tabPageMukemmel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageMukemmel.Location = new System.Drawing.Point(4, 25);
            this.tabPageMukemmel.Name = "tabPageMukemmel";
            this.tabPageMukemmel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMukemmel.Size = new System.Drawing.Size(467, 188);
            this.tabPageMukemmel.TabIndex = 3;
            this.tabPageMukemmel.Text = "Mükemmel Sayılar";
            // 
            // listBox7
            // 
            this.listBox7.FormattingEnabled = true;
            this.listBox7.ItemHeight = 16;
            this.listBox7.Location = new System.Drawing.Point(312, 42);
            this.listBox7.Name = "listBox7";
            this.listBox7.Size = new System.Drawing.Size(116, 36);
            this.listBox7.TabIndex = 10;
            // 
            // listBox8
            // 
            this.listBox8.FormattingEnabled = true;
            this.listBox8.ItemHeight = 16;
            this.listBox8.Location = new System.Drawing.Point(312, 101);
            this.listBox8.Name = "listBox8";
            this.listBox8.Size = new System.Drawing.Size(116, 36);
            this.listBox8.TabIndex = 9;
            // 
            // listViewmukemmel
            // 
            this.listViewmukemmel.HideSelection = false;
            this.listViewmukemmel.Location = new System.Drawing.Point(31, 25);
            this.listViewmukemmel.Name = "listViewmukemmel";
            this.listViewmukemmel.Size = new System.Drawing.Size(227, 145);
            this.listViewmukemmel.TabIndex = 0;
            this.listViewmukemmel.UseCompatibleStateImageBehavior = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Çift Sayıların Çarpımı ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBoxgiris);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxgiris.ResumeLayout(false);
            this.groupBoxgiris.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageCift.ResumeLayout(false);
            this.tabPageCift.PerformLayout();
            this.tabPageTek.ResumeLayout(false);
            this.tabPageAsal.ResumeLayout(false);
            this.tabPageMukemmel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxbaslangic;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxbitis;
        private System.Windows.Forms.GroupBox groupBoxgiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnHesapla;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCift;
        private System.Windows.Forms.ListView listViewcift;
        private System.Windows.Forms.TabPage tabPageTek;
        private System.Windows.Forms.ListView listViewtek;
        private System.Windows.Forms.TabPage tabPageAsal;
        private System.Windows.Forms.ListView listViewasal;
        private System.Windows.Forms.TabPage tabPageMukemmel;
        private System.Windows.Forms.ListView listViewmukemmel;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.ListBox listBox7;
        private System.Windows.Forms.ListBox listBox8;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

