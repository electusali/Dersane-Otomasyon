namespace Dersane_Otomasyon
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.lblKullaniciAdi = new System.Windows.Forms.Label();
			this.btnGiris = new DevExpress.XtraEditors.SimpleButton();
			this.lblSifre = new System.Windows.Forms.Label();
			this.pnlGiris = new System.Windows.Forms.Panel();
			this.lblGirisBilgi = new DevExpress.XtraEditors.LabelControl();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
			this.tbxKullaniciAdi = new System.Windows.Forms.TextBox();
			this.tbxSifre = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblKullaniciAdi
			// 
			this.lblKullaniciAdi.AutoSize = true;
			this.lblKullaniciAdi.BackColor = System.Drawing.Color.LightGreen;
			this.lblKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(170)), true);
			this.lblKullaniciAdi.ForeColor = System.Drawing.Color.Red;
			this.lblKullaniciAdi.Location = new System.Drawing.Point(12, 237);
			this.lblKullaniciAdi.Name = "lblKullaniciAdi";
			this.lblKullaniciAdi.Size = new System.Drawing.Size(106, 20);
			this.lblKullaniciAdi.TabIndex = 1;
			this.lblKullaniciAdi.Text = "Kullanıcı Adı";
			// 
			// btnGiris
			// 
			this.btnGiris.Appearance.BackColor = System.Drawing.Color.LawnGreen;
			this.btnGiris.Appearance.BackColor2 = System.Drawing.Color.Red;
			this.btnGiris.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.btnGiris.Appearance.ForeColor = System.Drawing.Color.Red;
			this.btnGiris.Appearance.Options.UseBackColor = true;
			this.btnGiris.Appearance.Options.UseFont = true;
			this.btnGiris.Appearance.Options.UseForeColor = true;
			this.btnGiris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGiris.ImageOptions.Image")));
			this.btnGiris.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnGiris.Location = new System.Drawing.Point(193, 379);
			this.btnGiris.Name = "btnGiris";
			this.btnGiris.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnGiris.Size = new System.Drawing.Size(114, 42);
			this.btnGiris.TabIndex = 10;
			this.btnGiris.Text = "GİRİŞ";
			this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
			// 
			// lblSifre
			// 
			this.lblSifre.AutoSize = true;
			this.lblSifre.BackColor = System.Drawing.Color.LightGreen;
			this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(170)), true);
			this.lblSifre.ForeColor = System.Drawing.Color.Red;
			this.lblSifre.Location = new System.Drawing.Point(39, 300);
			this.lblSifre.Name = "lblSifre";
			this.lblSifre.Size = new System.Drawing.Size(47, 20);
			this.lblSifre.TabIndex = 12;
			this.lblSifre.Text = "Şifre";
			// 
			// pnlGiris
			// 
			this.pnlGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlGiris.BackgroundImage")));
			this.pnlGiris.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.pnlGiris.Location = new System.Drawing.Point(2, 0);
			this.pnlGiris.Name = "pnlGiris";
			this.pnlGiris.Size = new System.Drawing.Size(131, 130);
			this.pnlGiris.TabIndex = 13;
			// 
			// lblGirisBilgi
			// 
			this.lblGirisBilgi.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
			this.lblGirisBilgi.Appearance.BackColor = System.Drawing.Color.LawnGreen;
			this.lblGirisBilgi.Appearance.Font = new System.Drawing.Font("Century Schoolbook", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
			this.lblGirisBilgi.Appearance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblGirisBilgi.Appearance.Options.UseBackColor = true;
			this.lblGirisBilgi.Appearance.Options.UseFont = true;
			this.lblGirisBilgi.Appearance.Options.UseForeColor = true;
			this.lblGirisBilgi.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.lblGirisBilgi.AppearancePressed.Options.UseBorderColor = true;
			this.lblGirisBilgi.ImageOptions.Alignment = System.Drawing.ContentAlignment.BottomRight;
			this.lblGirisBilgi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lblGirisBilgi.ImageOptions.Image")));
			this.lblGirisBilgi.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.lblGirisBilgi.Location = new System.Drawing.Point(127, 122);
			this.lblGirisBilgi.Name = "lblGirisBilgi";
			this.lblGirisBilgi.Size = new System.Drawing.Size(244, 60);
			this.lblGirisBilgi.TabIndex = 14;
			this.lblGirisBilgi.Text = "Lütfen Kullanıcı Bilgileri \r\n        Doldurunuz";
			this.lblGirisBilgi.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Error;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(158, 37);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(88, 66);
			this.pictureBox1.TabIndex = 15;
			this.pictureBox1.TabStop = false;
			// 
			// btnCikis
			// 
			this.btnCikis.Appearance.BackColor = System.Drawing.Color.LawnGreen;
			this.btnCikis.Appearance.BackColor2 = System.Drawing.Color.Red;
			this.btnCikis.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.btnCikis.Appearance.ForeColor = System.Drawing.Color.Red;
			this.btnCikis.Appearance.Options.UseBackColor = true;
			this.btnCikis.Appearance.Options.UseFont = true;
			this.btnCikis.Appearance.Options.UseForeColor = true;
			this.btnCikis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.ImageOptions.Image")));
			this.btnCikis.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnCikis.Location = new System.Drawing.Point(43, 379);
			this.btnCikis.Name = "btnCikis";
			this.btnCikis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnCikis.Size = new System.Drawing.Size(114, 42);
			this.btnCikis.TabIndex = 16;
			this.btnCikis.Text = "ÇIKIŞ";
			// 
			// tbxKullaniciAdi
			// 
			this.tbxKullaniciAdi.Location = new System.Drawing.Point(138, 237);
			this.tbxKullaniciAdi.Multiline = true;
			this.tbxKullaniciAdi.Name = "tbxKullaniciAdi";
			this.tbxKullaniciAdi.Size = new System.Drawing.Size(196, 29);
			this.tbxKullaniciAdi.TabIndex = 17;
			// 
			// tbxSifre
			// 
			this.tbxSifre.Location = new System.Drawing.Point(138, 291);
			this.tbxSifre.Multiline = true;
			this.tbxSifre.Name = "tbxSifre";
			this.tbxSifre.Size = new System.Drawing.Size(196, 29);
			this.tbxSifre.TabIndex = 18;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumSpringGreen;
			this.ClientSize = new System.Drawing.Size(383, 490);
			this.Controls.Add(this.tbxSifre);
			this.Controls.Add(this.tbxKullaniciAdi);
			this.Controls.Add(this.btnCikis);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblGirisBilgi);
			this.Controls.Add(this.pnlGiris);
			this.Controls.Add(this.lblSifre);
			this.Controls.Add(this.btnGiris);
			this.Controls.Add(this.lblKullaniciAdi);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblKullaniciAdi;
		private DevExpress.XtraEditors.SimpleButton btnGiris;
		private System.Windows.Forms.Label lblSifre;
		private System.Windows.Forms.Panel pnlGiris;
		private DevExpress.XtraEditors.LabelControl lblGirisBilgi;
		private System.Windows.Forms.PictureBox pictureBox1;
		private DevExpress.XtraEditors.SimpleButton btnCikis;
		private System.Windows.Forms.TextBox tbxKullaniciAdi;
		private System.Windows.Forms.TextBox tbxSifre;
	}
}

