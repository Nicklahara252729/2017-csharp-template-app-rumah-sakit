namespace APP_RUMAH_SAKIT
{
    partial class FrmPrint
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CrvReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.BtnClose.ForeColor = System.Drawing.Color.Red;
            this.BtnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnClose.Location = new System.Drawing.Point(632, 1);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(33, 33);
            this.BtnClose.TabIndex = 8;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.BtnMinimize.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.BtnMinimize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnMinimize.Location = new System.Drawing.Point(600, 1);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(33, 33);
            this.BtnMinimize.TabIndex = 7;
            this.BtnMinimize.Text = "-";
            this.BtnMinimize.UseVisualStyleBackColor = true;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CrvReport);
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 431);
            this.panel1.TabIndex = 9;
            // 
            // CrvReport
            // 
            this.CrvReport.ActiveViewIndex = -1;
            this.CrvReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrvReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrvReport.Location = new System.Drawing.Point(0, 0);
            this.CrvReport.Name = "CrvReport";
            this.CrvReport.Size = new System.Drawing.Size(665, 431);
            this.CrvReport.TabIndex = 0;
            this.CrvReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(666, 464);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnMinimize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrint";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmPrint_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmPrint_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmPrint_MouseUp);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnMinimize;
        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrvReport;
    }
}