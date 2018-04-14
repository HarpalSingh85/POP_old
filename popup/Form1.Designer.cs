namespace popup
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblnm = new System.Windows.Forms.Label();
            this.trayNt = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnPostpone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.lblDisplay = new System.Windows.Forms.Label();
            this._progress = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(254, 168);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 0;
            this.btnRestart.Text = "&Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(335, 168);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblnm
            // 
            this.lblnm.AutoSize = true;
            this.lblnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnm.Location = new System.Drawing.Point(42, 12);
            this.lblnm.Name = "lblnm";
            this.lblnm.Size = new System.Drawing.Size(45, 16);
            this.lblnm.TabIndex = 2;
            this.lblnm.Text = "label1";
            // 
            // trayNt
            // 
            this.trayNt.Text = "notifyIcon1";
            this.trayNt.Visible = true;
            this.trayNt.BalloonTipClicked += new System.EventHandler(this.trayNt_BalloonTipClicked);
            this.trayNt.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayNt_MouseDoubleClick);
            // 
            // btnPostpone
            // 
            this.btnPostpone.Location = new System.Drawing.Point(173, 168);
            this.btnPostpone.Name = "btnPostpone";
            this.btnPostpone.Size = new System.Drawing.Size(75, 23);
            this.btnPostpone.TabIndex = 3;
            this.btnPostpone.Text = "&Postpone";
            this.btnPostpone.UseVisualStyleBackColor = true;
            this.btnPostpone.Click += new System.EventHandler(this.btnPostpone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "_";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplay.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(308, 60);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(100, 23);
            this.lblDisplay.TabIndex = 5;
            this.lblDisplay.Text = "label2";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _progress
            // 
            this._progress.Location = new System.Drawing.Point(9, 60);
            this._progress.Name = "_progress";
            this._progress.Size = new System.Drawing.Size(296, 23);
            this._progress.Step = 1;
            this._progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this._progress.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblnm);
            this.groupBox1.Location = new System.Drawing.Point(9, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 51);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::popup.Properties.Resources.Information_icon;
            this.pictureBox1.Location = new System.Drawing.Point(4, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(9, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 57);
            this.label2.TabIndex = 8;
            this.label2.Text = "_";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 199);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._progress);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPostpone);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRestart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pulse Secure Restart Notification";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblnm;
        private System.Windows.Forms.NotifyIcon trayNt;
        private System.Windows.Forms.Button btnPostpone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.ProgressBar _progress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label2;
    }
}

