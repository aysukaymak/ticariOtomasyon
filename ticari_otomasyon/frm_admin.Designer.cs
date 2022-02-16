
namespace ticari_otomasyon
{
    partial class frm_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_admin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullanıcı = new DevExpress.XtraEditors.TextEdit();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.btnGiris = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkButton1 = new DevExpress.XtraEditors.CheckButton();
            this.btnHesapOlustur = new System.Windows.Forms.Button();
            this.btnParolamiUnuttum = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanıcı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(47, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Source Sans Pro Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(123, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // txtKullanıcı
            // 
            this.txtKullanıcı.Location = new System.Drawing.Point(192, 294);
            this.txtKullanıcı.Name = "txtKullanıcı";
            this.txtKullanıcı.Properties.Appearance.Font = new System.Drawing.Font("Source Sans Pro Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanıcı.Properties.Appearance.Options.UseFont = true;
            this.txtKullanıcı.Size = new System.Drawing.Size(170, 36);
            this.txtKullanıcı.TabIndex = 2;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(192, 353);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.Appearance.Font = new System.Drawing.Font("Source Sans Pro Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Properties.Appearance.Options.UseFont = true;
            this.txtSifre.Properties.UseSystemPasswordChar = true;
            this.txtSifre.Size = new System.Drawing.Size(170, 36);
            this.txtSifre.TabIndex = 3;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Transparent;
            this.btnGiris.FlatAppearance.BorderSize = 0;
            this.btnGiris.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnGiris.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Source Sans Pro Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnGiris.Location = new System.Drawing.Point(191, 411);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(170, 50);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Source Sans Pro Light", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(40, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 54);
            this.label3.TabIndex = 5;
            this.label3.Text = "GAZİ ELEKTRONİK";
            // 
            // checkButton1
            // 
            this.checkButton1.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.checkButton1.Appearance.Options.UseBorderColor = true;
            this.checkButton1.AppearanceDisabled.BorderColor = System.Drawing.Color.Transparent;
            this.checkButton1.AppearanceDisabled.Options.UseBorderColor = true;
            this.checkButton1.AppearanceHovered.BorderColor = System.Drawing.Color.Transparent;
            this.checkButton1.AppearanceHovered.Options.UseBorderColor = true;
            this.checkButton1.AppearancePressed.BorderColor = System.Drawing.Color.Transparent;
            this.checkButton1.AppearancePressed.Options.UseBorderColor = true;
            this.checkButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("checkButton1.ImageOptions.Image")));
            this.checkButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.checkButton1.Location = new System.Drawing.Point(368, 353);
            this.checkButton1.Name = "checkButton1";
            this.checkButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.checkButton1.Size = new System.Drawing.Size(45, 36);
            this.checkButton1.TabIndex = 7;
            this.checkButton1.CheckedChanged += new System.EventHandler(this.checkButton1_CheckedChanged);
            // 
            // btnHesapOlustur
            // 
            this.btnHesapOlustur.BackColor = System.Drawing.Color.Transparent;
            this.btnHesapOlustur.FlatAppearance.BorderSize = 0;
            this.btnHesapOlustur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnHesapOlustur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnHesapOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapOlustur.Font = new System.Drawing.Font("Source Sans Pro", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapOlustur.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnHesapOlustur.Location = new System.Drawing.Point(56, 477);
            this.btnHesapOlustur.Name = "btnHesapOlustur";
            this.btnHesapOlustur.Size = new System.Drawing.Size(130, 50);
            this.btnHesapOlustur.TabIndex = 8;
            this.btnHesapOlustur.Text = "Hesap Oluştur";
            this.btnHesapOlustur.UseVisualStyleBackColor = false;
            this.btnHesapOlustur.Click += new System.EventHandler(this.btnHesapOlustur_Click);
            // 
            // btnParolamiUnuttum
            // 
            this.btnParolamiUnuttum.BackColor = System.Drawing.Color.Transparent;
            this.btnParolamiUnuttum.FlatAppearance.BorderSize = 0;
            this.btnParolamiUnuttum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnParolamiUnuttum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnParolamiUnuttum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParolamiUnuttum.Font = new System.Drawing.Font("Source Sans Pro", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParolamiUnuttum.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnParolamiUnuttum.Location = new System.Drawing.Point(213, 477);
            this.btnParolamiUnuttum.Name = "btnParolamiUnuttum";
            this.btnParolamiUnuttum.Size = new System.Drawing.Size(160, 50);
            this.btnParolamiUnuttum.TabIndex = 9;
            this.btnParolamiUnuttum.Text = "Parolamı Unuttum";
            this.btnParolamiUnuttum.UseVisualStyleBackColor = false;
            this.btnParolamiUnuttum.Click += new System.EventHandler(this.btnParolamiUnuttum_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Source Sans Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(192, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "|";
            // 
            // frm_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnParolamiUnuttum);
            this.Controls.Add(this.btnHesapOlustur);
            this.Controls.Add(this.checkButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanıcı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Source Sans Pro Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frm_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gazi Elektronik";
            //this.Load += new System.EventHandler(this.frm_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanıcı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtKullanıcı;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.CheckButton checkButton1;
        private System.Windows.Forms.Button btnHesapOlustur;
        private System.Windows.Forms.Button btnParolamiUnuttum;
        private System.Windows.Forms.Label label4;
    }
}