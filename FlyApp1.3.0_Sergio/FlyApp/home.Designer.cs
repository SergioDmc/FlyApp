namespace FlyApp
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.timerBackground = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.pictureBackground2 = new System.Windows.Forms.PictureBox();
            this.pictureBackground3 = new System.Windows.Forms.PictureBox();
            this.dronesOnAirLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.availableDronCountLabel = new System.Windows.Forms.Label();
            this.distanceTraveledCountLabel = new System.Windows.Forms.Label();
            this.timeTraveledCountLabel = new System.Windows.Forms.Label();
            this.packCountLabel = new System.Windows.Forms.Label();
            this.availableDronesLabel = new System.Windows.Forms.Label();
            this.serviceLabel = new System.Windows.Forms.Label();
            this.timeFlyedLabel = new System.Windows.Forms.Label();
            this.packageSentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackground2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackground3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerBackground
            // 
            this.timerBackground.Interval = 5000;
            this.timerBackground.Tick += new System.EventHandler(this.timerBackground_Tick);
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxBackground.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackground.Image")));
            this.pictureBoxBackground.Location = new System.Drawing.Point(-1, -1);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(883, 571);
            this.pictureBoxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackground.TabIndex = 1;
            this.pictureBoxBackground.TabStop = false;
            // 
            // pictureBackground2
            // 
            this.pictureBackground2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBackground2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBackground2.Image")));
            this.pictureBackground2.Location = new System.Drawing.Point(-1, -4);
            this.pictureBackground2.Name = "pictureBackground2";
            this.pictureBackground2.Size = new System.Drawing.Size(883, 574);
            this.pictureBackground2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBackground2.TabIndex = 2;
            this.pictureBackground2.TabStop = false;
            this.pictureBackground2.Visible = false;
            // 
            // pictureBackground3
            // 
            this.pictureBackground3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBackground3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBackground3.Image")));
            this.pictureBackground3.Location = new System.Drawing.Point(0, -1);
            this.pictureBackground3.Name = "pictureBackground3";
            this.pictureBackground3.Size = new System.Drawing.Size(883, 574);
            this.pictureBackground3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBackground3.TabIndex = 3;
            this.pictureBackground3.TabStop = false;
            this.pictureBackground3.Visible = false;
            // 
            // dronesOnAirLabel
            // 
            this.dronesOnAirLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dronesOnAirLabel.AutoSize = true;
            this.dronesOnAirLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dronesOnAirLabel.Font = new System.Drawing.Font("HURTMOLD_", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dronesOnAirLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dronesOnAirLabel.Location = new System.Drawing.Point(495, 478);
            this.dronesOnAirLabel.Name = "dronesOnAirLabel";
            this.dronesOnAirLabel.Size = new System.Drawing.Size(337, 40);
            this.dronesOnAirLabel.TabIndex = 4;
            this.dronesOnAirLabel.Text = "Drones on air: 45";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.availableDronCountLabel);
            this.panel1.Controls.Add(this.distanceTraveledCountLabel);
            this.panel1.Controls.Add(this.timeTraveledCountLabel);
            this.panel1.Controls.Add(this.packCountLabel);
            this.panel1.Controls.Add(this.availableDronesLabel);
            this.panel1.Controls.Add(this.serviceLabel);
            this.panel1.Controls.Add(this.timeFlyedLabel);
            this.panel1.Controls.Add(this.packageSentLabel);
            this.panel1.Location = new System.Drawing.Point(471, 322);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 153);
            this.panel1.TabIndex = 5;
            // 
            // availableDronCountLabel
            // 
            this.availableDronCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.availableDronCountLabel.Font = new System.Drawing.Font("BankGothic Lt BT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableDronCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.availableDronCountLabel.Location = new System.Drawing.Point(195, 122);
            this.availableDronCountLabel.Name = "availableDronCountLabel";
            this.availableDronCountLabel.Size = new System.Drawing.Size(183, 23);
            this.availableDronCountLabel.TabIndex = 7;
            this.availableDronCountLabel.Text = "29";
            this.availableDronCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // distanceTraveledCountLabel
            // 
            this.distanceTraveledCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.distanceTraveledCountLabel.Font = new System.Drawing.Font("BankGothic Lt BT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceTraveledCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.distanceTraveledCountLabel.Location = new System.Drawing.Point(195, 89);
            this.distanceTraveledCountLabel.Name = "distanceTraveledCountLabel";
            this.distanceTraveledCountLabel.Size = new System.Drawing.Size(183, 23);
            this.distanceTraveledCountLabel.TabIndex = 6;
            this.distanceTraveledCountLabel.Text = "Active";
            this.distanceTraveledCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timeTraveledCountLabel
            // 
            this.timeTraveledCountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeTraveledCountLabel.AutoEllipsis = true;
            this.timeTraveledCountLabel.Font = new System.Drawing.Font("BankGothic Lt BT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTraveledCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.timeTraveledCountLabel.Location = new System.Drawing.Point(153, 54);
            this.timeTraveledCountLabel.Name = "timeTraveledCountLabel";
            this.timeTraveledCountLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.timeTraveledCountLabel.Size = new System.Drawing.Size(225, 23);
            this.timeTraveledCountLabel.TabIndex = 5;
            this.timeTraveledCountLabel.Text = "2d 3hr 22min";
            this.timeTraveledCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // packCountLabel
            // 
            this.packCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.packCountLabel.Font = new System.Drawing.Font("BankGothic Lt BT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.packCountLabel.Location = new System.Drawing.Point(195, 22);
            this.packCountLabel.Name = "packCountLabel";
            this.packCountLabel.Size = new System.Drawing.Size(183, 23);
            this.packCountLabel.TabIndex = 4;
            this.packCountLabel.Text = "289";
            this.packCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // availableDronesLabel
            // 
            this.availableDronesLabel.AutoSize = true;
            this.availableDronesLabel.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableDronesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.availableDronesLabel.Location = new System.Drawing.Point(11, 122);
            this.availableDronesLabel.Name = "availableDronesLabel";
            this.availableDronesLabel.Size = new System.Drawing.Size(157, 21);
            this.availableDronesLabel.TabIndex = 3;
            this.availableDronesLabel.Text = "Available Drones:";
            // 
            // serviceLabel
            // 
            this.serviceLabel.AutoSize = true;
            this.serviceLabel.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.serviceLabel.Location = new System.Drawing.Point(11, 89);
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(130, 21);
            this.serviceLabel.TabIndex = 2;
            this.serviceLabel.Text = "Service status:";
            // 
            // timeFlyedLabel
            // 
            this.timeFlyedLabel.AutoSize = true;
            this.timeFlyedLabel.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeFlyedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.timeFlyedLabel.Location = new System.Drawing.Point(11, 56);
            this.timeFlyedLabel.Name = "timeFlyedLabel";
            this.timeFlyedLabel.Size = new System.Drawing.Size(103, 21);
            this.timeFlyedLabel.TabIndex = 1;
            this.timeFlyedLabel.Text = "Time on air:";
            // 
            // packageSentLabel
            // 
            this.packageSentLabel.AutoSize = true;
            this.packageSentLabel.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageSentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.packageSentLabel.Location = new System.Drawing.Point(11, 24);
            this.packageSentLabel.Name = "packageSentLabel";
            this.packageSentLabel.Size = new System.Drawing.Size(166, 21);
            this.packageSentLabel.TabIndex = 0;
            this.packageSentLabel.Text = "Packages sended:";
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 571);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dronesOnAirLabel);
            this.Controls.Add(this.pictureBoxBackground);
            this.Controls.Add(this.pictureBackground3);
            this.Controls.Add(this.pictureBackground2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "home";
            this.Text = "home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackground2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackground3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxBackground;
        private System.Windows.Forms.Timer timerBackground;
        private System.Windows.Forms.PictureBox pictureBackground2;
        private System.Windows.Forms.PictureBox pictureBackground3;
        private System.Windows.Forms.Label dronesOnAirLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label availableDronCountLabel;
        private System.Windows.Forms.Label distanceTraveledCountLabel;
        private System.Windows.Forms.Label timeTraveledCountLabel;
        private System.Windows.Forms.Label packCountLabel;
        private System.Windows.Forms.Label availableDronesLabel;
        private System.Windows.Forms.Label serviceLabel;
        private System.Windows.Forms.Label timeFlyedLabel;
        private System.Windows.Forms.Label packageSentLabel;
    }
}