namespace APP_RUMAH_SAKIT
{
    partial class FrmDokter
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
            this.LblKodeDokter = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnDataPasien = new System.Windows.Forms.Button();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.DgvViewData = new System.Windows.Forms.DataGridView();
            this.BtnDiagnose = new System.Windows.Forms.Button();
            this.BtnDataResep = new System.Windows.Forms.Button();
            this.PanelUsControl = new System.Windows.Forms.Panel();
            this.LblInfoMenu = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PctLogout = new System.Windows.Forms.PictureBox();
            this.BtnNamaDokter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // LblKodeDokter
            // 
            this.LblKodeDokter.AutoSize = true;
            this.LblKodeDokter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKodeDokter.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblKodeDokter.Location = new System.Drawing.Point(408, 5);
            this.LblKodeDokter.Name = "LblKodeDokter";
            this.LblKodeDokter.Size = new System.Drawing.Size(125, 22);
            this.LblKodeDokter.TabIndex = 28;
            this.LblKodeDokter.Text = "Kode Dokter";
            // 
            // BtnClose
            // 
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnClose.Location = new System.Drawing.Point(877, -2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(30, 35);
            this.BtnClose.TabIndex = 29;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.LblInfoMenu);
            this.panel1.Controls.Add(this.BtnDataResep);
            this.panel1.Controls.Add(this.BtnDiagnose);
            this.panel1.Controls.Add(this.BtnDataPasien);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 46);
            this.panel1.TabIndex = 30;
            // 
            // BtnDataPasien
            // 
            this.BtnDataPasien.BackColor = System.Drawing.Color.White;
            this.BtnDataPasien.FlatAppearance.BorderSize = 0;
            this.BtnDataPasien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnDataPasien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDataPasien.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDataPasien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnDataPasien.Location = new System.Drawing.Point(6, 0);
            this.BtnDataPasien.Name = "BtnDataPasien";
            this.BtnDataPasien.Size = new System.Drawing.Size(156, 43);
            this.BtnDataPasien.TabIndex = 34;
            this.BtnDataPasien.Text = "Data Pasien";
            this.BtnDataPasien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDataPasien.UseVisualStyleBackColor = false;
            this.BtnDataPasien.Click += new System.EventHandler(this.BtnDataPasien_Click);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnMinimize.Location = new System.Drawing.Point(847, -2);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(30, 35);
            this.BtnMinimize.TabIndex = 32;
            this.BtnMinimize.Text = "-";
            this.BtnMinimize.UseVisualStyleBackColor = true;
            // 
            // DgvViewData
            // 
            this.DgvViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvViewData.Location = new System.Drawing.Point(-2, 279);
            this.DgvViewData.Name = "DgvViewData";
            this.DgvViewData.Size = new System.Drawing.Size(913, 212);
            this.DgvViewData.TabIndex = 33;
            // 
            // BtnDiagnose
            // 
            this.BtnDiagnose.BackColor = System.Drawing.Color.White;
            this.BtnDiagnose.FlatAppearance.BorderSize = 0;
            this.BtnDiagnose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnDiagnose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDiagnose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDiagnose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnDiagnose.Location = new System.Drawing.Point(168, 0);
            this.BtnDiagnose.Name = "BtnDiagnose";
            this.BtnDiagnose.Size = new System.Drawing.Size(156, 43);
            this.BtnDiagnose.TabIndex = 35;
            this.BtnDiagnose.Text = "Diagnose";
            this.BtnDiagnose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDiagnose.UseVisualStyleBackColor = false;
            this.BtnDiagnose.Click += new System.EventHandler(this.BtnDiagnose_Click);
            // 
            // BtnDataResep
            // 
            this.BtnDataResep.BackColor = System.Drawing.Color.White;
            this.BtnDataResep.FlatAppearance.BorderSize = 0;
            this.BtnDataResep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnDataResep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDataResep.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDataResep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnDataResep.Location = new System.Drawing.Point(330, 0);
            this.BtnDataResep.Name = "BtnDataResep";
            this.BtnDataResep.Size = new System.Drawing.Size(156, 43);
            this.BtnDataResep.TabIndex = 36;
            this.BtnDataResep.Text = "Data Resep";
            this.BtnDataResep.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDataResep.UseVisualStyleBackColor = false;
            this.BtnDataResep.Click += new System.EventHandler(this.BtnDataResep_Click);
            // 
            // PanelUsControl
            // 
            this.PanelUsControl.Location = new System.Drawing.Point(0, 74);
            this.PanelUsControl.Name = "PanelUsControl";
            this.PanelUsControl.Size = new System.Drawing.Size(911, 208);
            this.PanelUsControl.TabIndex = 34;
            // 
            // LblInfoMenu
            // 
            this.LblInfoMenu.AutoSize = true;
            this.LblInfoMenu.Font = new System.Drawing.Font("CentSchbkCyrill BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblInfoMenu.ForeColor = System.Drawing.Color.White;
            this.LblInfoMenu.Location = new System.Drawing.Point(743, 8);
            this.LblInfoMenu.Name = "LblInfoMenu";
            this.LblInfoMenu.Size = new System.Drawing.Size(164, 30);
            this.LblInfoMenu.TabIndex = 65;
            this.LblInfoMenu.Text = "Data Pasien";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::APP_RUMAH_SAKIT.Properties.Resources.pasien;
            this.pictureBox3.Location = new System.Drawing.Point(139, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::APP_RUMAH_SAKIT.Properties.Resources.xgwsazhuzgbydhvnuxbb1;
            this.pictureBox2.Location = new System.Drawing.Point(301, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 66;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::APP_RUMAH_SAKIT.Properties.Resources.obat1;
            this.pictureBox1.Location = new System.Drawing.Point(463, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // PctLogout
            // 
            this.PctLogout.Image = global::APP_RUMAH_SAKIT.Properties.Resources.Apps_Dialog_Shutdown_icon;
            this.PctLogout.Location = new System.Drawing.Point(-2, -2);
            this.PctLogout.Name = "PctLogout";
            this.PctLogout.Size = new System.Drawing.Size(31, 31);
            this.PctLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctLogout.TabIndex = 31;
            this.PctLogout.TabStop = false;
            this.PctLogout.Click += new System.EventHandler(this.PctLogout_Click);
            // 
            // BtnNamaDokter
            // 
            this.BtnNamaDokter.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnNamaDokter.FlatAppearance.BorderSize = 0;
            this.BtnNamaDokter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnNamaDokter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNamaDokter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNamaDokter.ForeColor = System.Drawing.Color.White;
            this.BtnNamaDokter.Location = new System.Drawing.Point(35, -1);
            this.BtnNamaDokter.Name = "BtnNamaDokter";
            this.BtnNamaDokter.Size = new System.Drawing.Size(208, 30);
            this.BtnNamaDokter.TabIndex = 29;
            this.BtnNamaDokter.TabStop = false;
            this.BtnNamaDokter.Text = "Dokter";
            this.BtnNamaDokter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNamaDokter.UseVisualStyleBackColor = false;
            // 
            // FrmDokter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(911, 491);
            this.Controls.Add(this.BtnNamaDokter);
            this.Controls.Add(this.PanelUsControl);
            this.Controls.Add(this.DgvViewData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnMinimize);
            this.Controls.Add(this.PctLogout);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LblKodeDokter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDokter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDokter";
            this.Load += new System.EventHandler(this.FrmDokter_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmDokter_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmDokter_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmDokter_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctLogout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblKodeDokter;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PctLogout;
        private System.Windows.Forms.Button BtnMinimize;
        private System.Windows.Forms.DataGridView DgvViewData;
        private System.Windows.Forms.Button BtnDataPasien;
        private System.Windows.Forms.Button BtnDataResep;
        private System.Windows.Forms.Button BtnDiagnose;
        private System.Windows.Forms.Panel PanelUsControl;
        private System.Windows.Forms.Label LblInfoMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnNamaDokter;
    }
}