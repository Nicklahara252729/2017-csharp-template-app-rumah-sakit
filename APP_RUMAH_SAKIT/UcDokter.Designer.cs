namespace APP_RUMAH_SAKIT
{
    partial class UcDokter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKdDokter = new System.Windows.Forms.TextBox();
            this.TxtNamaDokter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbJKelamin = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtAlamat = new System.Windows.Forms.TextBox();
            this.TxtNoHp = new System.Windows.Forms.TextBox();
            this.CmbSpesialis = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnPengobatan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Dokter";
            // 
            // TxtKdDokter
            // 
            this.TxtKdDokter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtKdDokter.Location = new System.Drawing.Point(160, 29);
            this.TxtKdDokter.Name = "TxtKdDokter";
            this.TxtKdDokter.Size = new System.Drawing.Size(175, 26);
            this.TxtKdDokter.TabIndex = 1;
            this.TxtKdDokter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtKdDokter_KeyPress);
            // 
            // TxtNamaDokter
            // 
            this.TxtNamaDokter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNamaDokter.Location = new System.Drawing.Point(160, 64);
            this.TxtNamaDokter.Name = "TxtNamaDokter";
            this.TxtNamaDokter.Size = new System.Drawing.Size(218, 26);
            this.TxtNamaDokter.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Dokter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jenis Kelamin";
            // 
            // CmbJKelamin
            // 
            this.CmbJKelamin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbJKelamin.FormattingEnabled = true;
            this.CmbJKelamin.Items.AddRange(new object[] {
            "Pria",
            "Wanita"});
            this.CmbJKelamin.Location = new System.Drawing.Point(160, 99);
            this.CmbJKelamin.Name = "CmbJKelamin";
            this.CmbJKelamin.Size = new System.Drawing.Size(136, 28);
            this.CmbJKelamin.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(460, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nomor HP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(460, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Spesialis";
            // 
            // TxtAlamat
            // 
            this.TxtAlamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAlamat.Location = new System.Drawing.Point(160, 134);
            this.TxtAlamat.Multiline = true;
            this.TxtAlamat.Name = "TxtAlamat";
            this.TxtAlamat.Size = new System.Drawing.Size(249, 78);
            this.TxtAlamat.TabIndex = 9;
            // 
            // TxtNoHp
            // 
            this.TxtNoHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNoHp.Location = new System.Drawing.Point(554, 29);
            this.TxtNoHp.Name = "TxtNoHp";
            this.TxtNoHp.Size = new System.Drawing.Size(175, 26);
            this.TxtNoHp.TabIndex = 10;
            // 
            // CmbSpesialis
            // 
            this.CmbSpesialis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSpesialis.FormattingEnabled = true;
            this.CmbSpesialis.Items.AddRange(new object[] {
            "Umum",
            "Bedah",
            "Anak",
            "Gigi",
            "Jantung",
            "THT"});
            this.CmbSpesialis.Location = new System.Drawing.Point(554, 64);
            this.CmbSpesialis.Name = "CmbSpesialis";
            this.CmbSpesialis.Size = new System.Drawing.Size(175, 28);
            this.CmbSpesialis.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(335, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "*/Dok001";
            // 
            // BtnPengobatan
            // 
            this.BtnPengobatan.BackColor = System.Drawing.Color.DimGray;
            this.BtnPengobatan.FlatAppearance.BorderSize = 0;
            this.BtnPengobatan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnPengobatan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPengobatan.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPengobatan.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnPengobatan.Location = new System.Drawing.Point(694, 178);
            this.BtnPengobatan.Name = "BtnPengobatan";
            this.BtnPengobatan.Size = new System.Drawing.Size(123, 34);
            this.BtnPengobatan.TabIndex = 26;
            this.BtnPengobatan.TabStop = false;
            this.BtnPengobatan.Text = "SAVE";
            this.BtnPengobatan.UseVisualStyleBackColor = false;
            this.BtnPengobatan.Click += new System.EventHandler(this.BtnPengobatan_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LimeGreen;
            this.button1.Location = new System.Drawing.Point(571, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 34);
            this.button1.TabIndex = 27;
            this.button1.TabStop = false;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.OrangeRed;
            this.button2.Location = new System.Drawing.Point(448, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 34);
            this.button2.TabIndex = 28;
            this.button2.TabStop = false;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UcDokter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnPengobatan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CmbSpesialis);
            this.Controls.Add(this.TxtNoHp);
            this.Controls.Add(this.TxtAlamat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbJKelamin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNamaDokter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtKdDokter);
            this.Controls.Add(this.label1);
            this.Name = "UcDokter";
            this.Size = new System.Drawing.Size(854, 238);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtKdDokter;
        private System.Windows.Forms.TextBox TxtNamaDokter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbJKelamin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtAlamat;
        private System.Windows.Forms.TextBox TxtNoHp;
        private System.Windows.Forms.ComboBox CmbSpesialis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnPengobatan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
