namespace FlyApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.selectedPanel = new System.Windows.Forms.Panel();
            this.configurationsButton = new System.Windows.Forms.Button();
            this.dronesButton = new System.Windows.Forms.Button();
            this.registersButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.routeButton = new System.Windows.Forms.Button();
            this.configButton = new System.Windows.Forms.PictureBox();
            this.homeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maxminButtom = new System.Windows.Forms.PictureBox();
            this.minimizeButtom = new System.Windows.Forms.PictureBox();
            this.maximizeButtom = new System.Windows.Forms.PictureBox();
            this.closeButtom = new System.Windows.Forms.PictureBox();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configButton)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxminButtom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButtom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeButtom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtom)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panelPrincipal.Controls.Add(this.selectedPanel);
            this.panelPrincipal.Controls.Add(this.configurationsButton);
            this.panelPrincipal.Controls.Add(this.dronesButton);
            this.panelPrincipal.Controls.Add(this.registersButton);
            this.panelPrincipal.Controls.Add(this.pictureBox3);
            this.panelPrincipal.Controls.Add(this.routeButton);
            this.panelPrincipal.Controls.Add(this.configButton);
            this.panelPrincipal.Controls.Add(this.homeButton);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(85, 600);
            this.panelPrincipal.TabIndex = 0;
            // 
            // selectedPanel
            // 
            this.selectedPanel.Location = new System.Drawing.Point(70, 216);
            this.selectedPanel.Name = "selectedPanel";
            this.selectedPanel.Size = new System.Drawing.Size(15, 37);
            this.selectedPanel.TabIndex = 0;
            // 
            // configurationsButton
            // 
            this.configurationsButton.FlatAppearance.BorderSize = 0;
            this.configurationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.configurationsButton.Image = global::FlyApp.Properties.Resources.gear1;
            this.configurationsButton.Location = new System.Drawing.Point(0, 551);
            this.configurationsButton.Name = "configurationsButton";
            this.configurationsButton.Size = new System.Drawing.Size(85, 37);
            this.configurationsButton.TabIndex = 6;
            this.configurationsButton.UseVisualStyleBackColor = true;
            this.configurationsButton.Click += new System.EventHandler(this.configurationsButton_Click);
            // 
            // dronesButton
            // 
            this.dronesButton.FlatAppearance.BorderSize = 0;
            this.dronesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dronesButton.Image = global::FlyApp.Properties.Resources.drone;
            this.dronesButton.Location = new System.Drawing.Point(0, 381);
            this.dronesButton.Name = "dronesButton";
            this.dronesButton.Size = new System.Drawing.Size(85, 37);
            this.dronesButton.TabIndex = 3;
            this.dronesButton.UseVisualStyleBackColor = true;
            this.dronesButton.Click += new System.EventHandler(this.dronesButton_Click);
            // 
            // registersButton
            // 
            this.registersButton.FlatAppearance.BorderSize = 0;
            this.registersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registersButton.Image = global::FlyApp.Properties.Resources.routesList;
            this.registersButton.Location = new System.Drawing.Point(0, 325);
            this.registersButton.Name = "registersButton";
            this.registersButton.Size = new System.Drawing.Size(85, 37);
            this.registersButton.TabIndex = 2;
            this.registersButton.UseVisualStyleBackColor = true;
            this.registersButton.Click += new System.EventHandler(this.registersButton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FlyApp.Properties.Resources.logo3;
            this.pictureBox3.Location = new System.Drawing.Point(2, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 162);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // routeButton
            // 
            this.routeButton.FlatAppearance.BorderSize = 0;
            this.routeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.routeButton.Image = global::FlyApp.Properties.Resources.mapEditor;
            this.routeButton.Location = new System.Drawing.Point(0, 269);
            this.routeButton.Name = "routeButton";
            this.routeButton.Size = new System.Drawing.Size(85, 37);
            this.routeButton.TabIndex = 1;
            this.routeButton.UseVisualStyleBackColor = true;
            this.routeButton.Click += new System.EventHandler(this.routeButton_Click);
            // 
            // configButton
            // 
            this.configButton.Location = new System.Drawing.Point(0, 0);
            this.configButton.Name = "configButton";
            this.configButton.Size = new System.Drawing.Size(100, 50);
            this.configButton.TabIndex = 5;
            this.configButton.TabStop = false;
            // 
            // homeButton
            // 
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Image = global::FlyApp.Properties.Resources.home11;
            this.homeButton.Location = new System.Drawing.Point(0, 216);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(85, 37);
            this.homeButton.TabIndex = 0;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.maxminButtom);
            this.panel1.Controls.Add(this.minimizeButtom);
            this.panel1.Controls.Add(this.maximizeButtom);
            this.panel1.Controls.Add(this.closeButtom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(85, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 50);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // maxminButtom
            // 
            this.maxminButtom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxminButtom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maxminButtom.Image = global::FlyApp.Properties.Resources.min_tama;
            this.maxminButtom.Location = new System.Drawing.Point(836, 4);
            this.maxminButtom.Name = "maxminButtom";
            this.maxminButtom.Size = new System.Drawing.Size(25, 25);
            this.maxminButtom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maxminButtom.TabIndex = 4;
            this.maxminButtom.TabStop = false;
            this.maxminButtom.Visible = false;
            this.maxminButtom.Click += new System.EventHandler(this.maxminButtom_Click);
            // 
            // minimizeButtom
            // 
            this.minimizeButtom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButtom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButtom.Image = global::FlyApp.Properties.Resources.minimize;
            this.minimizeButtom.Location = new System.Drawing.Point(805, 5);
            this.minimizeButtom.Name = "minimizeButtom";
            this.minimizeButtom.Size = new System.Drawing.Size(25, 25);
            this.minimizeButtom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButtom.TabIndex = 5;
            this.minimizeButtom.TabStop = false;
            this.minimizeButtom.Click += new System.EventHandler(this.minimizeButtom_Click);
            // 
            // maximizeButtom
            // 
            this.maximizeButtom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButtom.Image = global::FlyApp.Properties.Resources.maximize;
            this.maximizeButtom.Location = new System.Drawing.Point(836, 5);
            this.maximizeButtom.Name = "maximizeButtom";
            this.maximizeButtom.Size = new System.Drawing.Size(25, 25);
            this.maximizeButtom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizeButtom.TabIndex = 6;
            this.maximizeButtom.TabStop = false;
            this.maximizeButtom.Click += new System.EventHandler(this.maximizeButtom_Click);
            // 
            // closeButtom
            // 
            this.closeButtom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButtom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButtom.Image = global::FlyApp.Properties.Resources.cross;
            this.closeButtom.Location = new System.Drawing.Point(867, 5);
            this.closeButtom.Name = "closeButtom";
            this.closeButtom.Size = new System.Drawing.Size(25, 25);
            this.closeButtom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButtom.TabIndex = 4;
            this.closeButtom.TabStop = false;
            this.closeButtom.Click += new System.EventHandler(this.closeButtom_Click);
            // 
            // containerPanel
            // 
            this.containerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.containerPanel.Location = new System.Drawing.Point(85, 50);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(895, 550);
            this.containerPanel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.containerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FlyApp";
            this.panelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configButton)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maxminButtom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButtom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeButtom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox closeButtom;
        private System.Windows.Forms.PictureBox minimizeButtom;
        private System.Windows.Forms.PictureBox maximizeButtom;
        private System.Windows.Forms.PictureBox maxminButtom;
        private System.Windows.Forms.PictureBox configButton;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button dronesButton;
        private System.Windows.Forms.Button registersButton;
        private System.Windows.Forms.Button routeButton;
        private System.Windows.Forms.Panel selectedPanel;
        private System.Windows.Forms.Button configurationsButton;
    }
}

