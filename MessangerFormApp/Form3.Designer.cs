
namespace MessangerFormApp
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Dgv_Gelen = new System.Windows.Forms.DataGridView();
            this.Dgv_Gonderilen = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Alici = new System.Windows.Forms.TextBox();
            this.Txt_Baslik = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Gonder = new System.Windows.Forms.Button();
            this.Rtx_Mesaj = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Numara = new System.Windows.Forms.Label();
            this.Lbl_Isim = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Gelen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Gonderilen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Lbl_Isim);
            this.panel1.Controls.Add(this.Lbl_Numara);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 56);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Dgv_Gelen);
            this.panel2.Location = new System.Drawing.Point(13, 111);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 216);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.Dgv_Gonderilen);
            this.panel3.Location = new System.Drawing.Point(398, 111);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(368, 216);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.Rtx_Mesaj);
            this.panel4.Controls.Add(this.Btn_Gonder);
            this.panel4.Controls.Add(this.Txt_Baslik);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.Txt_Alici);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(13, 355);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(753, 182);
            this.panel4.TabIndex = 3;
            // 
            // Dgv_Gelen
            // 
            this.Dgv_Gelen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Gelen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Gelen.Location = new System.Drawing.Point(0, 0);
            this.Dgv_Gelen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dgv_Gelen.Name = "Dgv_Gelen";
            this.Dgv_Gelen.Size = new System.Drawing.Size(364, 212);
            this.Dgv_Gelen.TabIndex = 0;
            this.Dgv_Gelen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Gelen_CellClick);
            // 
            // Dgv_Gonderilen
            // 
            this.Dgv_Gonderilen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Gonderilen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Gonderilen.Location = new System.Drawing.Point(0, 0);
            this.Dgv_Gonderilen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dgv_Gonderilen.Name = "Dgv_Gonderilen";
            this.Dgv_Gonderilen.Size = new System.Drawing.Size(364, 212);
            this.Dgv_Gonderilen.TabIndex = 0;
            this.Dgv_Gonderilen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Gonderilen_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Alıcı:";
            // 
            // Txt_Alici
            // 
            this.Txt_Alici.Location = new System.Drawing.Point(93, 20);
            this.Txt_Alici.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Alici.Name = "Txt_Alici";
            this.Txt_Alici.Size = new System.Drawing.Size(189, 33);
            this.Txt_Alici.TabIndex = 3;
            // 
            // Txt_Baslik
            // 
            this.Txt_Baslik.Location = new System.Drawing.Point(93, 62);
            this.Txt_Baslik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Baslik.Name = "Txt_Baslik";
            this.Txt_Baslik.Size = new System.Drawing.Size(189, 33);
            this.Txt_Baslik.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Başlık:";
            // 
            // Btn_Gonder
            // 
            this.Btn_Gonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Gonder.ForeColor = System.Drawing.Color.Cornsilk;
            this.Btn_Gonder.Location = new System.Drawing.Point(93, 104);
            this.Btn_Gonder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Gonder.Name = "Btn_Gonder";
            this.Btn_Gonder.Size = new System.Drawing.Size(189, 45);
            this.Btn_Gonder.TabIndex = 6;
            this.Btn_Gonder.Text = "Gönder";
            this.Btn_Gonder.UseVisualStyleBackColor = true;
            this.Btn_Gonder.Click += new System.EventHandler(this.Btn_Gonder_Click);
            // 
            // Rtx_Mesaj
            // 
            this.Rtx_Mesaj.Location = new System.Drawing.Point(352, 20);
            this.Rtx_Mesaj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rtx_Mesaj.Name = "Rtx_Mesaj";
            this.Rtx_Mesaj.Size = new System.Drawing.Size(394, 128);
            this.Rtx_Mesaj.TabIndex = 7;
            this.Rtx_Mesaj.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(283, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mesaj:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "Gelen Meşajlar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(396, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 21);
            this.label9.TabIndex = 10;
            this.label9.Text = "Gönderilen Meşajlar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(316, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "İsim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numara:";
            // 
            // Lbl_Numara
            // 
            this.Lbl_Numara.AutoSize = true;
            this.Lbl_Numara.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Numara.Location = new System.Drawing.Point(202, 14);
            this.Lbl_Numara.Name = "Lbl_Numara";
            this.Lbl_Numara.Size = new System.Drawing.Size(52, 26);
            this.Lbl_Numara.TabIndex = 5;
            this.Lbl_Numara.Text = "Null";
            // 
            // Lbl_Isim
            // 
            this.Lbl_Isim.AutoSize = true;
            this.Lbl_Isim.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Isim.Location = new System.Drawing.Point(378, 14);
            this.Lbl_Isim.Name = "Lbl_Isim";
            this.Lbl_Isim.Size = new System.Drawing.Size(52, 26);
            this.Lbl_Isim.TabIndex = 6;
            this.Lbl_Isim.Text = "Null";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(785, 570);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesaj Paneli";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Gelen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Gonderilen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_Isim;
        private System.Windows.Forms.Label Lbl_Numara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView Dgv_Gelen;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView Dgv_Gonderilen;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox Rtx_Mesaj;
        private System.Windows.Forms.Button Btn_Gonder;
        private System.Windows.Forms.TextBox Txt_Baslik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Alici;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}