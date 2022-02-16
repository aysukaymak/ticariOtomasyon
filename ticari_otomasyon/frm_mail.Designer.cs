
namespace ticari_otomasyon
{
    partial class frm_mail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mail));
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlici = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKonu = new DevExpress.XtraEditors.TextEdit();
            this.btnGonder = new DevExpress.XtraEditors.SimpleButton();
            this.rchMail = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlici.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKonu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alıcı Mail Adresi:";
            // 
            // txtAlici
            // 
            this.txtAlici.EditValue = "";
            this.txtAlici.Location = new System.Drawing.Point(156, 23);
            this.txtAlici.Name = "txtAlici";
            this.txtAlici.Properties.Appearance.Font = new System.Drawing.Font("Source Sans Pro Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlici.Properties.Appearance.Options.UseFont = true;
            this.txtAlici.Size = new System.Drawing.Size(290, 28);
            this.txtAlici.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Sans Pro Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(100, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Konu:";
            // 
            // txtKonu
            // 
            this.txtKonu.Location = new System.Drawing.Point(156, 66);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Properties.Appearance.Font = new System.Drawing.Font("Source Sans Pro Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKonu.Properties.Appearance.Options.UseFont = true;
            this.txtKonu.Size = new System.Drawing.Size(290, 28);
            this.txtKonu.TabIndex = 2;
            // 
            // btnGonder
            // 
            this.btnGonder.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnGonder.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btnGonder.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnGonder.Appearance.Font = new System.Drawing.Font("Source Sans Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonder.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnGonder.Appearance.Options.UseBackColor = true;
            this.btnGonder.Appearance.Options.UseBorderColor = true;
            this.btnGonder.Appearance.Options.UseFont = true;
            this.btnGonder.Appearance.Options.UseForeColor = true;
            this.btnGonder.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.btnGonder.AppearanceDisabled.BackColor2 = System.Drawing.Color.Transparent;
            this.btnGonder.AppearanceDisabled.BorderColor = System.Drawing.Color.Transparent;
            this.btnGonder.AppearanceDisabled.Font = new System.Drawing.Font("Source Sans Pro Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonder.AppearanceDisabled.Options.UseBackColor = true;
            this.btnGonder.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnGonder.AppearanceDisabled.Options.UseFont = true;
            this.btnGonder.AppearanceHovered.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGonder.AppearanceHovered.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.btnGonder.AppearanceHovered.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnGonder.AppearanceHovered.Font = new System.Drawing.Font("Source Sans Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonder.AppearanceHovered.Options.UseBackColor = true;
            this.btnGonder.AppearanceHovered.Options.UseBorderColor = true;
            this.btnGonder.AppearanceHovered.Options.UseFont = true;
            this.btnGonder.AppearancePressed.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGonder.AppearancePressed.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.btnGonder.AppearancePressed.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnGonder.AppearancePressed.Font = new System.Drawing.Font("Source Sans Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonder.AppearancePressed.Options.UseBackColor = true;
            this.btnGonder.AppearancePressed.Options.UseBorderColor = true;
            this.btnGonder.AppearancePressed.Options.UseFont = true;
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.Location = new System.Drawing.Point(327, 376);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnGonder.Size = new System.Drawing.Size(118, 47);
            this.btnGonder.TabIndex = 4;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // rchMail
            // 
            this.rchMail.Location = new System.Drawing.Point(35, 114);
            this.rchMail.Name = "rchMail";
            this.rchMail.Size = new System.Drawing.Size(410, 256);
            this.rchMail.TabIndex = 3;
            this.rchMail.Text = "";
            // 
            // frm_mail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(472, 433);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.rchMail);
            this.Controls.Add(this.txtKonu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAlici);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Source Sans Pro Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_mail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail";
            this.Load += new System.EventHandler(this.frm_mail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtAlici.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKonu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtAlici;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtKonu;
        private DevExpress.XtraEditors.SimpleButton btnGonder;
        private System.Windows.Forms.RichTextBox rchMail;
    }
}