namespace OzIMDB
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
            this.btnYeniFilm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFilmId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gboPuan = new System.Windows.Forms.GroupBox();
            this.rbPuanYok = new System.Windows.Forms.RadioButton();
            this.rbPuan3 = new System.Windows.Forms.RadioButton();
            this.rbPuan5 = new System.Windows.Forms.RadioButton();
            this.rbPuan1 = new System.Windows.Forms.RadioButton();
            this.rbPuan4 = new System.Windows.Forms.RadioButton();
            this.rbPuan2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilmAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pboFoto = new System.Windows.Forms.PictureBox();
            this.lstFilmler = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.gboPuan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYeniFilm
            // 
            this.btnYeniFilm.BackColor = System.Drawing.Color.LawnGreen;
            this.btnYeniFilm.Location = new System.Drawing.Point(259, 49);
            this.btnYeniFilm.Margin = new System.Windows.Forms.Padding(4);
            this.btnYeniFilm.Name = "btnYeniFilm";
            this.btnYeniFilm.Size = new System.Drawing.Size(150, 36);
            this.btnYeniFilm.TabIndex = 0;
            this.btnYeniFilm.Text = "Yeni Film Ekle";
            this.btnYeniFilm.UseVisualStyleBackColor = false;
            this.btnYeniFilm.Click += new System.EventHandler(this.btnYeniFilm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.txtFilmId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnYeniFilm);
            this.groupBox1.Controls.Add(this.gboPuan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFilmAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pboFoto);
            this.groupBox1.Location = new System.Drawing.Point(23, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(439, 403);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Film Detayları";
            // 
            // txtFilmId
            // 
            this.txtFilmId.BackColor = System.Drawing.Color.LightCyan;
            this.txtFilmId.Location = new System.Drawing.Point(22, 55);
            this.txtFilmId.Name = "txtFilmId";
            this.txtFilmId.ReadOnly = true;
            this.txtFilmId.Size = new System.Drawing.Size(97, 26);
            this.txtFilmId.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Film No";
            // 
            // gboPuan
            // 
            this.gboPuan.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gboPuan.Controls.Add(this.rbPuanYok);
            this.gboPuan.Controls.Add(this.rbPuan3);
            this.gboPuan.Controls.Add(this.rbPuan5);
            this.gboPuan.Controls.Add(this.rbPuan1);
            this.gboPuan.Controls.Add(this.rbPuan4);
            this.gboPuan.Controls.Add(this.rbPuan2);
            this.gboPuan.Location = new System.Drawing.Point(18, 143);
            this.gboPuan.Name = "gboPuan";
            this.gboPuan.Size = new System.Drawing.Size(163, 237);
            this.gboPuan.TabIndex = 10;
            this.gboPuan.TabStop = false;
            this.gboPuan.Text = "Puanı";
            // 
            // rbPuanYok
            // 
            this.rbPuanYok.AutoSize = true;
            this.rbPuanYok.Checked = true;
            this.rbPuanYok.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPuanYok.ForeColor = System.Drawing.Color.Black;
            this.rbPuanYok.Location = new System.Drawing.Point(12, 25);
            this.rbPuanYok.Name = "rbPuanYok";
            this.rbPuanYok.Size = new System.Drawing.Size(139, 27);
            this.rbPuanYok.TabIndex = 9;
            this.rbPuanYok.TabStop = true;
            this.rbPuanYok.Text = "Puan Verilmedi";
            this.rbPuanYok.UseVisualStyleBackColor = true;
            this.rbPuanYok.CheckedChanged += new System.EventHandler(this.rbPuanYok_CheckedChanged);
            this.rbPuanYok.Leave += new System.EventHandler(this.rbPuanYok_Leave);
            // 
            // rbPuan3
            // 
            this.rbPuan3.AutoSize = true;
            this.rbPuan3.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPuan3.ForeColor = System.Drawing.Color.Yellow;
            this.rbPuan3.Location = new System.Drawing.Point(12, 107);
            this.rbPuan3.Name = "rbPuan3";
            this.rbPuan3.Size = new System.Drawing.Size(142, 27);
            this.rbPuan3.TabIndex = 6;
            this.rbPuan3.Tag = "3";
            this.rbPuan3.Text = "3- İdare Eder";
            this.rbPuan3.UseVisualStyleBackColor = true;
            this.rbPuan3.CheckedChanged += new System.EventHandler(this.rbPuanYok_CheckedChanged);
            this.rbPuan3.Leave += new System.EventHandler(this.rbPuanYok_Leave);
            // 
            // rbPuan5
            // 
            this.rbPuan5.AutoSize = true;
            this.rbPuan5.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPuan5.ForeColor = System.Drawing.Color.Green;
            this.rbPuan5.Location = new System.Drawing.Point(12, 165);
            this.rbPuan5.Name = "rbPuan5";
            this.rbPuan5.Size = new System.Drawing.Size(111, 27);
            this.rbPuan5.TabIndex = 8;
            this.rbPuan5.Tag = "5";
            this.rbPuan5.Text = "5- Çok İyi";
            this.rbPuan5.UseVisualStyleBackColor = true;
            this.rbPuan5.CheckedChanged += new System.EventHandler(this.rbPuanYok_CheckedChanged);
            this.rbPuan5.Leave += new System.EventHandler(this.rbPuanYok_Leave);
            // 
            // rbPuan1
            // 
            this.rbPuan1.AutoSize = true;
            this.rbPuan1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPuan1.ForeColor = System.Drawing.Color.Red;
            this.rbPuan1.Location = new System.Drawing.Point(12, 55);
            this.rbPuan1.Name = "rbPuan1";
            this.rbPuan1.Size = new System.Drawing.Size(123, 27);
            this.rbPuan1.TabIndex = 4;
            this.rbPuan1.Tag = "1";
            this.rbPuan1.Text = "1- Çok Kötü";
            this.rbPuan1.UseVisualStyleBackColor = true;
            this.rbPuan1.CheckedChanged += new System.EventHandler(this.rbPuanYok_CheckedChanged);
            this.rbPuan1.Leave += new System.EventHandler(this.rbPuanYok_Leave);
            // 
            // rbPuan4
            // 
            this.rbPuan4.AutoSize = true;
            this.rbPuan4.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPuan4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbPuan4.Location = new System.Drawing.Point(12, 136);
            this.rbPuan4.Name = "rbPuan4";
            this.rbPuan4.Size = new System.Drawing.Size(77, 27);
            this.rbPuan4.TabIndex = 7;
            this.rbPuan4.Tag = "4";
            this.rbPuan4.Text = "4- İyi";
            this.rbPuan4.UseVisualStyleBackColor = true;
            this.rbPuan4.CheckedChanged += new System.EventHandler(this.rbPuanYok_CheckedChanged);
            this.rbPuan4.Leave += new System.EventHandler(this.rbPuanYok_Leave);
            // 
            // rbPuan2
            // 
            this.rbPuan2.AutoSize = true;
            this.rbPuan2.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPuan2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rbPuan2.Location = new System.Drawing.Point(12, 78);
            this.rbPuan2.Name = "rbPuan2";
            this.rbPuan2.Size = new System.Drawing.Size(89, 27);
            this.rbPuan2.TabIndex = 5;
            this.rbPuan2.Tag = "2";
            this.rbPuan2.Text = "2- Kötü";
            this.rbPuan2.UseVisualStyleBackColor = true;
            this.rbPuan2.CheckedChanged += new System.EventHandler(this.rbPuanYok_CheckedChanged);
            this.rbPuan2.Leave += new System.EventHandler(this.rbPuanYok_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(186, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Değiştirmek İçin Fotoğraf Üstüne Tıklayınız.)";
            // 
            // txtFilmAd
            // 
            this.txtFilmAd.BackColor = System.Drawing.Color.LightCyan;
            this.txtFilmAd.Location = new System.Drawing.Point(22, 115);
            this.txtFilmAd.Name = "txtFilmAd";
            this.txtFilmAd.Size = new System.Drawing.Size(410, 26);
            this.txtFilmAd.TabIndex = 2;
            this.txtFilmAd.TextChanged += new System.EventHandler(this.txtFilmAd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Film Adı";
            // 
            // pboFoto
            // 
            this.pboFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pboFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboFoto.Location = new System.Drawing.Point(189, 147);
            this.pboFoto.Name = "pboFoto";
            this.pboFoto.Size = new System.Drawing.Size(243, 233);
            this.pboFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboFoto.TabIndex = 0;
            this.pboFoto.TabStop = false;
            this.pboFoto.Click += new System.EventHandler(this.pboFoto_Click);
            // 
            // lstFilmler
            // 
            this.lstFilmler.BackColor = System.Drawing.Color.LightCyan;
            this.lstFilmler.DisplayMember = "FilmAd";
            this.lstFilmler.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstFilmler.FormattingEnabled = true;
            this.lstFilmler.ItemHeight = 16;
            this.lstFilmler.Location = new System.Drawing.Point(485, 30);
            this.lstFilmler.Margin = new System.Windows.Forms.Padding(4);
            this.lstFilmler.Name = "lstFilmler";
            this.lstFilmler.Size = new System.Drawing.Size(321, 404);
            this.lstFilmler.TabIndex = 2;
            this.lstFilmler.ValueMember = "Id";
            this.lstFilmler.SelectedValueChanged += new System.EventHandler(this.lstFilmler_SelectedValueChanged);
            this.lstFilmler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstFilmler_KeyDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Resim Dosyaları (*.BMP;*.JPG;*.PNG;*.GIF)|*.BMP;*.JPG;*.JPEG;*.PNG;*.GIF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(841, 470);
            this.Controls.Add(this.lstFilmler);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(857, 509);
            this.Name = "Form1";
            this.Text = "ÖZ IMDB 1.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gboPuan.ResumeLayout(false);
            this.gboPuan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYeniFilm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbPuan5;
        private System.Windows.Forms.RadioButton rbPuan4;
        private System.Windows.Forms.RadioButton rbPuan3;
        private System.Windows.Forms.RadioButton rbPuan2;
        private System.Windows.Forms.RadioButton rbPuan1;
        private System.Windows.Forms.TextBox txtFilmAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pboFoto;
        private System.Windows.Forms.ListBox lstFilmler;
        private System.Windows.Forms.GroupBox gboPuan;
        private System.Windows.Forms.TextBox txtFilmId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbPuanYok;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

