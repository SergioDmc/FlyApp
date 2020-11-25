namespace FlyApp
{
    partial class trayectoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trayectoryForm));
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.toolTipCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newRouteScrollBar = new System.Windows.Forms.VScrollBar();
            this.selectedButton = new System.Windows.Forms.Panel();
            this.mapPrefPanel = new System.Windows.Forms.Panel();
            this.savePrefrencesButton = new System.Windows.Forms.Button();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lngTextBox = new System.Windows.Forms.TextBox();
            this.latTextBox = new System.Windows.Forms.TextBox();
            this.defaultZoomLabel = new System.Windows.Forms.Label();
            this.zoomTrackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.markerLabel = new System.Windows.Forms.Label();
            this.reliefRadioButton = new System.Windows.Forms.RadioButton();
            this.originalRadioButton = new System.Windows.Forms.RadioButton();
            this.satelitalRadioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.newRoutePanel = new System.Windows.Forms.Panel();
            this.saveRouteButton = new System.Windows.Forms.Button();
            this.flyPHLabel = new System.Windows.Forms.Label();
            this.distancePFLabel = new System.Windows.Forms.Label();
            this.packagePHLabel = new System.Windows.Forms.Label();
            this.routeTimeLabel = new System.Windows.Forms.Label();
            this.pointPictureBox = new System.Windows.Forms.PictureBox();
            this.distancePictureBox = new System.Windows.Forms.PictureBox();
            this.packagesPictureBox = new System.Windows.Forms.PictureBox();
            this.timePictureBox = new System.Windows.Forms.PictureBox();
            this.indoorsRadioButton = new System.Windows.Forms.RadioButton();
            this.outdoorsRadioButton = new System.Windows.Forms.RadioButton();
            this.routesComboBox = new System.Windows.Forms.ComboBox();
            this.dronesComboBox = new System.Windows.Forms.ComboBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.idPieceTextBox = new System.Windows.Forms.TextBox();
            this.orderIdTextBox = new System.Windows.Forms.TextBox();
            this.namesLabel = new System.Windows.Forms.Label();
            this.idRouteTextBox = new System.Windows.Forms.TextBox();
            this.routeNameTextBox = new System.Windows.Forms.TextBox();
            this.createRoutePanel = new System.Windows.Forms.Panel();
            this.savePathButton = new System.Windows.Forms.Button();
            this.pointTextBox = new System.Windows.Forms.TextBox();
            this.altZLabel = new System.Windows.Forms.Label();
            this.lngYLabel = new System.Windows.Forms.Label();
            this.latXLabel = new System.Windows.Forms.Label();
            this.altZNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lngYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LatXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.descritionLabel = new System.Windows.Forms.Label();
            this.gradientPanel11 = new FlyApp.GradientPanel1();
            this.panel2 = new System.Windows.Forms.Panel();
            this.newRouteButton = new System.Windows.Forms.Button();
            this.mapPreferencesButton = new System.Windows.Forms.Button();
            this.editRouteButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.mapPrefPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).BeginInit();
            this.newRoutePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distancePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timePictureBox)).BeginInit();
            this.createRoutePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.altZNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lngYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LatXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.Font = new System.Drawing.Font("BankGothic Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(0, 0);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(646, 550);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            this.gMapControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.setMarkerP);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(646, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 550);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // toolTipCheckBox
            // 
            this.toolTipCheckBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTipCheckBox.Location = new System.Drawing.Point(28, 24);
            this.toolTipCheckBox.Name = "toolTipCheckBox";
            this.toolTipCheckBox.Size = new System.Drawing.Size(134, 27);
            this.toolTipCheckBox.TabIndex = 3;
            this.toolTipCheckBox.Text = "Map Tooltip";
            this.toolTipCheckBox.UseVisualStyleBackColor = true;
            this.toolTipCheckBox.CheckedChanged += new System.EventHandler(this.toolTipCheckBox_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.newRouteScrollBar);
            this.panel1.Location = new System.Drawing.Point(649, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 550);
            this.panel1.TabIndex = 4;
            // 
            // newRouteScrollBar
            // 
            this.newRouteScrollBar.LargeChange = 50;
            this.newRouteScrollBar.Location = new System.Drawing.Point(227, 145);
            this.newRouteScrollBar.Maximum = 150;
            this.newRouteScrollBar.Name = "newRouteScrollBar";
            this.newRouteScrollBar.Size = new System.Drawing.Size(20, 360);
            this.newRouteScrollBar.TabIndex = 8;
            this.newRouteScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.newRouteScrollBar_Scroll);
            // 
            // selectedButton
            // 
            this.selectedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.selectedButton.Location = new System.Drawing.Point(236, 95);
            this.selectedButton.Name = "selectedButton";
            this.selectedButton.Size = new System.Drawing.Size(10, 45);
            this.selectedButton.TabIndex = 7;
            this.selectedButton.Visible = false;
            // 
            // mapPrefPanel
            // 
            this.mapPrefPanel.Controls.Add(this.savePrefrencesButton);
            this.mapPrefPanel.Controls.Add(this.colorComboBox);
            this.mapPrefPanel.Controls.Add(this.label3);
            this.mapPrefPanel.Controls.Add(this.lngTextBox);
            this.mapPrefPanel.Controls.Add(this.latTextBox);
            this.mapPrefPanel.Controls.Add(this.defaultZoomLabel);
            this.mapPrefPanel.Controls.Add(this.zoomTrackBar);
            this.mapPrefPanel.Controls.Add(this.label2);
            this.mapPrefPanel.Controls.Add(this.label1);
            this.mapPrefPanel.Controls.Add(this.markerLabel);
            this.mapPrefPanel.Controls.Add(this.reliefRadioButton);
            this.mapPrefPanel.Controls.Add(this.originalRadioButton);
            this.mapPrefPanel.Controls.Add(this.satelitalRadioButton);
            this.mapPrefPanel.Controls.Add(this.toolTipCheckBox);
            this.mapPrefPanel.Controls.Add(this.label4);
            this.mapPrefPanel.Location = new System.Drawing.Point(646, 145);
            this.mapPrefPanel.Name = "mapPrefPanel";
            this.mapPrefPanel.Size = new System.Drawing.Size(220, 363);
            this.mapPrefPanel.TabIndex = 4;
            this.mapPrefPanel.Visible = false;
            // 
            // savePrefrencesButton
            // 
            this.savePrefrencesButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePrefrencesButton.Location = new System.Drawing.Point(11, 330);
            this.savePrefrencesButton.Name = "savePrefrencesButton";
            this.savePrefrencesButton.Size = new System.Drawing.Size(227, 23);
            this.savePrefrencesButton.TabIndex = 17;
            this.savePrefrencesButton.Text = "Save";
            this.savePrefrencesButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.savePrefrencesButton.UseVisualStyleBackColor = true;
            this.savePrefrencesButton.Click += new System.EventHandler(this.savePrefrencesButton_Click);
            // 
            // colorComboBox
            // 
            this.colorComboBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Location = new System.Drawing.Point(28, 52);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(206, 28);
            this.colorComboBox.TabIndex = 16;
            this.colorComboBox.Text = "Marker Color";
            this.colorComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Default position";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lngTextBox
            // 
            this.lngTextBox.Location = new System.Drawing.Point(134, 286);
            this.lngTextBox.Name = "lngTextBox";
            this.lngTextBox.Size = new System.Drawing.Size(100, 20);
            this.lngTextBox.TabIndex = 13;
            this.lngTextBox.TextChanged += new System.EventHandler(this.lngTextBox_TextChanged);
            // 
            // latTextBox
            // 
            this.latTextBox.Location = new System.Drawing.Point(17, 286);
            this.latTextBox.Name = "latTextBox";
            this.latTextBox.Size = new System.Drawing.Size(100, 20);
            this.latTextBox.TabIndex = 12;
            this.latTextBox.TextChanged += new System.EventHandler(this.latTextBox_TextChanged);
            // 
            // defaultZoomLabel
            // 
            this.defaultZoomLabel.AutoSize = true;
            this.defaultZoomLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defaultZoomLabel.Location = new System.Drawing.Point(89, 256);
            this.defaultZoomLabel.Name = "defaultZoomLabel";
            this.defaultZoomLabel.Size = new System.Drawing.Size(79, 16);
            this.defaultZoomLabel.TabIndex = 11;
            this.defaultZoomLabel.Text = "Default zoom";
            this.defaultZoomLabel.Click += new System.EventHandler(this.defaultZoomLabel_Click);
            // 
            // zoomTrackBar
            // 
            this.zoomTrackBar.Location = new System.Drawing.Point(14, 220);
            this.zoomTrackBar.Maximum = 25;
            this.zoomTrackBar.Minimum = 3;
            this.zoomTrackBar.Name = "zoomTrackBar";
            this.zoomTrackBar.Size = new System.Drawing.Size(222, 45);
            this.zoomTrackBar.TabIndex = 10;
            this.zoomTrackBar.Value = 15;
            this.zoomTrackBar.Scroll += new System.EventHandler(this.zoomTrackBar_Scroll);
            this.zoomTrackBar.ValueChanged += new System.EventHandler(this.zoomTrackBar_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("BankGothic Lt BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Map";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BankGothic Lt BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "View";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // markerLabel
            // 
            this.markerLabel.AutoSize = true;
            this.markerLabel.Font = new System.Drawing.Font("BankGothic Lt BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markerLabel.Location = new System.Drawing.Point(12, 3);
            this.markerLabel.Name = "markerLabel";
            this.markerLabel.Size = new System.Drawing.Size(67, 16);
            this.markerLabel.TabIndex = 7;
            this.markerLabel.Text = "Marker";
            // 
            // reliefRadioButton
            // 
            this.reliefRadioButton.AutoSize = true;
            this.reliefRadioButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reliefRadioButton.Location = new System.Drawing.Point(28, 168);
            this.reliefRadioButton.Name = "reliefRadioButton";
            this.reliefRadioButton.Size = new System.Drawing.Size(110, 25);
            this.reliefRadioButton.TabIndex = 6;
            this.reliefRadioButton.Text = "Relief view";
            this.reliefRadioButton.UseVisualStyleBackColor = true;
            this.reliefRadioButton.CheckedChanged += new System.EventHandler(this.reliefRadioButton_CheckedChanged);
            // 
            // originalRadioButton
            // 
            this.originalRadioButton.AutoSize = true;
            this.originalRadioButton.Checked = true;
            this.originalRadioButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalRadioButton.Location = new System.Drawing.Point(28, 139);
            this.originalRadioButton.Name = "originalRadioButton";
            this.originalRadioButton.Size = new System.Drawing.Size(129, 25);
            this.originalRadioButton.TabIndex = 5;
            this.originalRadioButton.TabStop = true;
            this.originalRadioButton.Text = "Original view";
            this.originalRadioButton.UseVisualStyleBackColor = true;
            this.originalRadioButton.CheckedChanged += new System.EventHandler(this.originalRadioButton_CheckedChanged);
            // 
            // satelitalRadioButton
            // 
            this.satelitalRadioButton.AutoSize = true;
            this.satelitalRadioButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.satelitalRadioButton.Location = new System.Drawing.Point(28, 112);
            this.satelitalRadioButton.Name = "satelitalRadioButton";
            this.satelitalRadioButton.Size = new System.Drawing.Size(132, 25);
            this.satelitalRadioButton.TabIndex = 4;
            this.satelitalRadioButton.Text = "Satelital view";
            this.satelitalRadioButton.UseVisualStyleBackColor = true;
            this.satelitalRadioButton.CheckedChanged += new System.EventHandler(this.satelitalRadioButton_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(119, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = ",";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // newRoutePanel
            // 
            this.newRoutePanel.Controls.Add(this.saveRouteButton);
            this.newRoutePanel.Controls.Add(this.flyPHLabel);
            this.newRoutePanel.Controls.Add(this.distancePFLabel);
            this.newRoutePanel.Controls.Add(this.packagePHLabel);
            this.newRoutePanel.Controls.Add(this.routeTimeLabel);
            this.newRoutePanel.Controls.Add(this.pointPictureBox);
            this.newRoutePanel.Controls.Add(this.distancePictureBox);
            this.newRoutePanel.Controls.Add(this.packagesPictureBox);
            this.newRoutePanel.Controls.Add(this.timePictureBox);
            this.newRoutePanel.Controls.Add(this.indoorsRadioButton);
            this.newRoutePanel.Controls.Add(this.outdoorsRadioButton);
            this.newRoutePanel.Controls.Add(this.routesComboBox);
            this.newRoutePanel.Controls.Add(this.dronesComboBox);
            this.newRoutePanel.Controls.Add(this.weightTextBox);
            this.newRoutePanel.Controls.Add(this.idPieceTextBox);
            this.newRoutePanel.Controls.Add(this.orderIdTextBox);
            this.newRoutePanel.Controls.Add(this.namesLabel);
            this.newRoutePanel.Controls.Add(this.idRouteTextBox);
            this.newRoutePanel.Controls.Add(this.routeNameTextBox);
            this.newRoutePanel.Location = new System.Drawing.Point(646, 145);
            this.newRoutePanel.Name = "newRoutePanel";
            this.newRoutePanel.Size = new System.Drawing.Size(230, 468);
            this.newRoutePanel.TabIndex = 5;
            this.newRoutePanel.Visible = false;
            // 
            // saveRouteButton
            // 
            this.saveRouteButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveRouteButton.Location = new System.Drawing.Point(8, 429);
            this.saveRouteButton.Name = "saveRouteButton";
            this.saveRouteButton.Size = new System.Drawing.Size(215, 30);
            this.saveRouteButton.TabIndex = 10;
            this.saveRouteButton.Text = "Save";
            this.saveRouteButton.UseVisualStyleBackColor = true;
            // 
            // flyPHLabel
            // 
            this.flyPHLabel.AutoSize = true;
            this.flyPHLabel.Font = new System.Drawing.Font("BankGothic Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flyPHLabel.Location = new System.Drawing.Point(146, 400);
            this.flyPHLabel.Name = "flyPHLabel";
            this.flyPHLabel.Size = new System.Drawing.Size(68, 19);
            this.flyPHLabel.TabIndex = 18;
            this.flyPHLabel.Text = "--- P/h";
            // 
            // distancePFLabel
            // 
            this.distancePFLabel.AutoSize = true;
            this.distancePFLabel.Font = new System.Drawing.Font("BankGothic Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distancePFLabel.Location = new System.Drawing.Point(26, 400);
            this.distancePFLabel.Name = "distancePFLabel";
            this.distancePFLabel.Size = new System.Drawing.Size(69, 19);
            this.distancePFLabel.TabIndex = 17;
            this.distancePFLabel.Text = "--- K/m";
            // 
            // packagePHLabel
            // 
            this.packagePHLabel.AutoSize = true;
            this.packagePHLabel.Font = new System.Drawing.Font("BankGothic Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packagePHLabel.Location = new System.Drawing.Point(146, 313);
            this.packagePHLabel.Name = "packagePHLabel";
            this.packagePHLabel.Size = new System.Drawing.Size(68, 19);
            this.packagePHLabel.TabIndex = 16;
            this.packagePHLabel.Text = "--- P/h";
            // 
            // routeTimeLabel
            // 
            this.routeTimeLabel.AutoSize = true;
            this.routeTimeLabel.Font = new System.Drawing.Font("BankGothic Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routeTimeLabel.Location = new System.Drawing.Point(26, 313);
            this.routeTimeLabel.Name = "routeTimeLabel";
            this.routeTimeLabel.Size = new System.Drawing.Size(59, 19);
            this.routeTimeLabel.TabIndex = 15;
            this.routeTimeLabel.Text = "--:--:--";
            // 
            // pointPictureBox
            // 
            this.pointPictureBox.Image = global::FlyApp.Properties.Resources.plane;
            this.pointPictureBox.Location = new System.Drawing.Point(150, 343);
            this.pointPictureBox.Name = "pointPictureBox";
            this.pointPictureBox.Size = new System.Drawing.Size(50, 50);
            this.pointPictureBox.TabIndex = 14;
            this.pointPictureBox.TabStop = false;
            // 
            // distancePictureBox
            // 
            this.distancePictureBox.Image = global::FlyApp.Properties.Resources.distance;
            this.distancePictureBox.Location = new System.Drawing.Point(30, 343);
            this.distancePictureBox.Name = "distancePictureBox";
            this.distancePictureBox.Size = new System.Drawing.Size(50, 50);
            this.distancePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.distancePictureBox.TabIndex = 13;
            this.distancePictureBox.TabStop = false;
            // 
            // packagesPictureBox
            // 
            this.packagesPictureBox.Image = global::FlyApp.Properties.Resources.package;
            this.packagesPictureBox.Location = new System.Drawing.Point(150, 257);
            this.packagesPictureBox.Name = "packagesPictureBox";
            this.packagesPictureBox.Size = new System.Drawing.Size(50, 50);
            this.packagesPictureBox.TabIndex = 12;
            this.packagesPictureBox.TabStop = false;
            // 
            // timePictureBox
            // 
            this.timePictureBox.Image = global::FlyApp.Properties.Resources.chronometer;
            this.timePictureBox.Location = new System.Drawing.Point(30, 257);
            this.timePictureBox.Name = "timePictureBox";
            this.timePictureBox.Size = new System.Drawing.Size(50, 50);
            this.timePictureBox.TabIndex = 11;
            this.timePictureBox.TabStop = false;
            // 
            // indoorsRadioButton
            // 
            this.indoorsRadioButton.AutoSize = true;
            this.indoorsRadioButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indoorsRadioButton.Location = new System.Drawing.Point(127, 193);
            this.indoorsRadioButton.Name = "indoorsRadioButton";
            this.indoorsRadioButton.Size = new System.Drawing.Size(73, 21);
            this.indoorsRadioButton.TabIndex = 10;
            this.indoorsRadioButton.TabStop = true;
            this.indoorsRadioButton.Text = "Indoors";
            this.indoorsRadioButton.UseVisualStyleBackColor = true;
            // 
            // outdoorsRadioButton
            // 
            this.outdoorsRadioButton.AutoSize = true;
            this.outdoorsRadioButton.Checked = true;
            this.outdoorsRadioButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outdoorsRadioButton.Location = new System.Drawing.Point(30, 193);
            this.outdoorsRadioButton.Name = "outdoorsRadioButton";
            this.outdoorsRadioButton.Size = new System.Drawing.Size(86, 21);
            this.outdoorsRadioButton.TabIndex = 9;
            this.outdoorsRadioButton.TabStop = true;
            this.outdoorsRadioButton.Text = "Outdoors";
            this.outdoorsRadioButton.UseVisualStyleBackColor = true;
            // 
            // routesComboBox
            // 
            this.routesComboBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routesComboBox.FormattingEnabled = true;
            this.routesComboBox.Location = new System.Drawing.Point(8, 215);
            this.routesComboBox.Name = "routesComboBox";
            this.routesComboBox.Size = new System.Drawing.Size(215, 25);
            this.routesComboBox.TabIndex = 7;
            this.routesComboBox.SelectedIndexChanged += new System.EventHandler(this.routesComboBox_SelectedIndexChanged);
            // 
            // dronesComboBox
            // 
            this.dronesComboBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dronesComboBox.FormattingEnabled = true;
            this.dronesComboBox.Location = new System.Drawing.Point(8, 165);
            this.dronesComboBox.Name = "dronesComboBox";
            this.dronesComboBox.Size = new System.Drawing.Size(215, 25);
            this.dronesComboBox.TabIndex = 6;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightTextBox.ForeColor = System.Drawing.Color.Gray;
            this.weightTextBox.Location = new System.Drawing.Point(8, 139);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(215, 22);
            this.weightTextBox.TabIndex = 5;
            this.weightTextBox.Text = "Weight";
            this.weightTextBox.Enter += new System.EventHandler(this.weightTextBox_Enter);
            this.weightTextBox.Leave += new System.EventHandler(this.weightTextBox_Leave);
            // 
            // idPieceTextBox
            // 
            this.idPieceTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idPieceTextBox.ForeColor = System.Drawing.Color.Gray;
            this.idPieceTextBox.Location = new System.Drawing.Point(8, 103);
            this.idPieceTextBox.Name = "idPieceTextBox";
            this.idPieceTextBox.Size = new System.Drawing.Size(215, 22);
            this.idPieceTextBox.TabIndex = 4;
            this.idPieceTextBox.Text = "Package ID";
            this.idPieceTextBox.Enter += new System.EventHandler(this.idPieceTextBox_Enter);
            this.idPieceTextBox.Leave += new System.EventHandler(this.idPieceTextBox_Leave);
            // 
            // orderIdTextBox
            // 
            this.orderIdTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIdTextBox.ForeColor = System.Drawing.Color.Gray;
            this.orderIdTextBox.Location = new System.Drawing.Point(8, 77);
            this.orderIdTextBox.Name = "orderIdTextBox";
            this.orderIdTextBox.Size = new System.Drawing.Size(215, 22);
            this.orderIdTextBox.TabIndex = 3;
            this.orderIdTextBox.Text = "Order ID";
            this.orderIdTextBox.Enter += new System.EventHandler(this.orderIdTextBox_Enter);
            this.orderIdTextBox.Leave += new System.EventHandler(this.orderIdTextBox_Leave);
            // 
            // namesLabel
            // 
            this.namesLabel.AutoSize = true;
            this.namesLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namesLabel.Location = new System.Drawing.Point(4, 1);
            this.namesLabel.Name = "namesLabel";
            this.namesLabel.Size = new System.Drawing.Size(91, 20);
            this.namesLabel.TabIndex = 2;
            this.namesLabel.Text = "Route data";
            // 
            // idRouteTextBox
            // 
            this.idRouteTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idRouteTextBox.ForeColor = System.Drawing.Color.Gray;
            this.idRouteTextBox.Location = new System.Drawing.Point(8, 50);
            this.idRouteTextBox.Name = "idRouteTextBox";
            this.idRouteTextBox.Size = new System.Drawing.Size(215, 22);
            this.idRouteTextBox.TabIndex = 1;
            this.idRouteTextBox.Text = "Route ID";
            this.idRouteTextBox.Enter += new System.EventHandler(this.idRouteTextBox_Enter);
            this.idRouteTextBox.Leave += new System.EventHandler(this.idRouteTextBox_Leave);
            // 
            // routeNameTextBox
            // 
            this.routeNameTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routeNameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.routeNameTextBox.Location = new System.Drawing.Point(8, 24);
            this.routeNameTextBox.Name = "routeNameTextBox";
            this.routeNameTextBox.Size = new System.Drawing.Size(215, 22);
            this.routeNameTextBox.TabIndex = 0;
            this.routeNameTextBox.Text = "Route name";
            this.routeNameTextBox.Enter += new System.EventHandler(this.routeNameTextBox_Enter);
            this.routeNameTextBox.Leave += new System.EventHandler(this.routeNameTextBox_Leave);
            // 
            // createRoutePanel
            // 
            this.createRoutePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.createRoutePanel.Controls.Add(this.savePathButton);
            this.createRoutePanel.Controls.Add(this.pointTextBox);
            this.createRoutePanel.Controls.Add(this.altZLabel);
            this.createRoutePanel.Controls.Add(this.lngYLabel);
            this.createRoutePanel.Controls.Add(this.latXLabel);
            this.createRoutePanel.Controls.Add(this.altZNumericUpDown);
            this.createRoutePanel.Controls.Add(this.lngYNumericUpDown);
            this.createRoutePanel.Controls.Add(this.LatXNumericUpDown);
            this.createRoutePanel.Controls.Add(this.deleteButton);
            this.createRoutePanel.Controls.Add(this.addButton);
            this.createRoutePanel.Controls.Add(this.dataGridView);
            this.createRoutePanel.Controls.Add(this.descritionLabel);
            this.createRoutePanel.Location = new System.Drawing.Point(0, 450);
            this.createRoutePanel.Name = "createRoutePanel";
            this.createRoutePanel.Size = new System.Drawing.Size(646, 100);
            this.createRoutePanel.TabIndex = 6;
            this.createRoutePanel.Visible = false;
            // 
            // savePathButton
            // 
            this.savePathButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePathButton.Image = global::FlyApp.Properties.Resources.save;
            this.savePathButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savePathButton.Location = new System.Drawing.Point(173, 49);
            this.savePathButton.Name = "savePathButton";
            this.savePathButton.Size = new System.Drawing.Size(120, 38);
            this.savePathButton.TabIndex = 10;
            this.savePathButton.Text = "       Save";
            this.savePathButton.UseVisualStyleBackColor = true;
            // 
            // pointTextBox
            // 
            this.pointTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointTextBox.Location = new System.Drawing.Point(173, 24);
            this.pointTextBox.Name = "pointTextBox";
            this.pointTextBox.Size = new System.Drawing.Size(120, 23);
            this.pointTextBox.TabIndex = 9;
            // 
            // altZLabel
            // 
            this.altZLabel.AutoSize = true;
            this.altZLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altZLabel.Location = new System.Drawing.Point(9, 65);
            this.altZLabel.Name = "altZLabel";
            this.altZLabel.Size = new System.Drawing.Size(32, 20);
            this.altZLabel.TabIndex = 8;
            this.altZLabel.Text = "Alt.";
            // 
            // lngYLabel
            // 
            this.lngYLabel.AutoSize = true;
            this.lngYLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lngYLabel.Location = new System.Drawing.Point(6, 39);
            this.lngYLabel.Name = "lngYLabel";
            this.lngYLabel.Size = new System.Drawing.Size(39, 20);
            this.lngYLabel.TabIndex = 7;
            this.lngYLabel.Text = "Lng.";
            // 
            // latXLabel
            // 
            this.latXLabel.AutoSize = true;
            this.latXLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latXLabel.Location = new System.Drawing.Point(6, 15);
            this.latXLabel.Name = "latXLabel";
            this.latXLabel.Size = new System.Drawing.Size(35, 20);
            this.latXLabel.TabIndex = 6;
            this.latXLabel.Text = "Lat.";
            // 
            // altZNumericUpDown
            // 
            this.altZNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.altZNumericUpDown.DecimalPlaces = 4;
            this.altZNumericUpDown.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altZNumericUpDown.Location = new System.Drawing.Point(44, 66);
            this.altZNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.altZNumericUpDown.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.altZNumericUpDown.Name = "altZNumericUpDown";
            this.altZNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.altZNumericUpDown.TabIndex = 5;
            // 
            // lngYNumericUpDown
            // 
            this.lngYNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lngYNumericUpDown.DecimalPlaces = 4;
            this.lngYNumericUpDown.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lngYNumericUpDown.Location = new System.Drawing.Point(44, 40);
            this.lngYNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.lngYNumericUpDown.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.lngYNumericUpDown.Name = "lngYNumericUpDown";
            this.lngYNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.lngYNumericUpDown.TabIndex = 4;
            // 
            // LatXNumericUpDown
            // 
            this.LatXNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LatXNumericUpDown.DecimalPlaces = 4;
            this.LatXNumericUpDown.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LatXNumericUpDown.Location = new System.Drawing.Point(44, 14);
            this.LatXNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.LatXNumericUpDown.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.LatXNumericUpDown.Name = "LatXNumericUpDown";
            this.LatXNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.LatXNumericUpDown.TabIndex = 3;
            // 
            // deleteButton
            // 
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Image = global::FlyApp.Properties.Resources.delete;
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.Location = new System.Drawing.Point(298, 51);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(95, 44);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Image = global::FlyApp.Properties.Resources.add;
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.Location = new System.Drawing.Point(298, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(95, 44);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "           Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(398, 6);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(242, 91);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.pickRow);
            // 
            // descritionLabel
            // 
            this.descritionLabel.AutoSize = true;
            this.descritionLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descritionLabel.Location = new System.Drawing.Point(172, 9);
            this.descritionLabel.Name = "descritionLabel";
            this.descritionLabel.Size = new System.Drawing.Size(97, 16);
            this.descritionLabel.TabIndex = 11;
            this.descritionLabel.Text = "Point description";
            // 
            // gradientPanel11
            // 
            this.gradientPanel11.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gradientPanel11.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gradientPanel11.Location = new System.Drawing.Point(646, 514);
            this.gradientPanel11.Name = "gradientPanel11";
            this.gradientPanel11.Size = new System.Drawing.Size(250, 36);
            this.gradientPanel11.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.selectedButton);
            this.panel2.Controls.Add(this.newRouteButton);
            this.panel2.Controls.Add(this.mapPreferencesButton);
            this.panel2.Controls.Add(this.editRouteButton);
            this.panel2.Location = new System.Drawing.Point(646, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 145);
            this.panel2.TabIndex = 9;
            // 
            // newRouteButton
            // 
            this.newRouteButton.FlatAppearance.BorderSize = 0;
            this.newRouteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newRouteButton.Font = new System.Drawing.Font("Earth Orbiter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newRouteButton.Image = ((System.Drawing.Image)(resources.GetObject("newRouteButton.Image")));
            this.newRouteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newRouteButton.Location = new System.Drawing.Point(3, 3);
            this.newRouteButton.Name = "newRouteButton";
            this.newRouteButton.Size = new System.Drawing.Size(227, 45);
            this.newRouteButton.TabIndex = 0;
            this.newRouteButton.Text = "New Route";
            this.newRouteButton.UseVisualStyleBackColor = true;
            this.newRouteButton.Click += new System.EventHandler(this.newRouteButton_Click);
            // 
            // mapPreferencesButton
            // 
            this.mapPreferencesButton.FlatAppearance.BorderSize = 0;
            this.mapPreferencesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mapPreferencesButton.Font = new System.Drawing.Font("Earth Orbiter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapPreferencesButton.Image = global::FlyApp.Properties.Resources.alfiler;
            this.mapPreferencesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mapPreferencesButton.Location = new System.Drawing.Point(3, 95);
            this.mapPreferencesButton.Name = "mapPreferencesButton";
            this.mapPreferencesButton.Size = new System.Drawing.Size(227, 45);
            this.mapPreferencesButton.TabIndex = 2;
            this.mapPreferencesButton.Text = "Map Preferences";
            this.mapPreferencesButton.UseVisualStyleBackColor = true;
            this.mapPreferencesButton.Click += new System.EventHandler(this.mapPreferencesButton_Click);
            // 
            // editRouteButton
            // 
            this.editRouteButton.FlatAppearance.BorderSize = 0;
            this.editRouteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editRouteButton.Font = new System.Drawing.Font("Earth Orbiter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editRouteButton.Image = global::FlyApp.Properties.Resources.editar1;
            this.editRouteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editRouteButton.Location = new System.Drawing.Point(3, 49);
            this.editRouteButton.Name = "editRouteButton";
            this.editRouteButton.Size = new System.Drawing.Size(227, 45);
            this.editRouteButton.TabIndex = 1;
            this.editRouteButton.Text = "Edit Route";
            this.editRouteButton.UseVisualStyleBackColor = true;
            this.editRouteButton.Click += new System.EventHandler(this.editRouteButton_Click);
            // 
            // trayectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.createRoutePanel);
            this.Controls.Add(this.gradientPanel11);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.newRoutePanel);
            this.Controls.Add(this.mapPrefPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gMapControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "trayectoryForm";
            this.Text = "trayectoryForm";
            this.Load += new System.EventHandler(this.trayectoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.mapPrefPanel.ResumeLayout(false);
            this.mapPrefPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).EndInit();
            this.newRoutePanel.ResumeLayout(false);
            this.newRoutePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distancePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timePictureBox)).EndInit();
            this.createRoutePanel.ResumeLayout(false);
            this.createRoutePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.altZNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lngYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LatXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.CheckBox toolTipCheckBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button newRouteButton;
        private System.Windows.Forms.Button mapPreferencesButton;
        private System.Windows.Forms.Button editRouteButton;
        private GradientPanel1 gradientPanel11;
        private System.Windows.Forms.Panel mapPrefPanel;
        private System.Windows.Forms.RadioButton reliefRadioButton;
        private System.Windows.Forms.RadioButton originalRadioButton;
        private System.Windows.Forms.RadioButton satelitalRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label markerLabel;
        private System.Windows.Forms.Label defaultZoomLabel;
        private System.Windows.Forms.TrackBar zoomTrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lngTextBox;
        private System.Windows.Forms.TextBox latTextBox;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel newRoutePanel;
        private System.Windows.Forms.TextBox idRouteTextBox;
        private System.Windows.Forms.TextBox routeNameTextBox;
        private System.Windows.Forms.Label namesLabel;
        private System.Windows.Forms.TextBox idPieceTextBox;
        private System.Windows.Forms.TextBox orderIdTextBox;
        private System.Windows.Forms.ComboBox routesComboBox;
        private System.Windows.Forms.ComboBox dronesComboBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.VScrollBar newRouteScrollBar;
        private System.Windows.Forms.Panel createRoutePanel;
        private System.Windows.Forms.RadioButton indoorsRadioButton;
        private System.Windows.Forms.RadioButton outdoorsRadioButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.NumericUpDown LatXNumericUpDown;
        private System.Windows.Forms.Label altZLabel;
        private System.Windows.Forms.Label lngYLabel;
        private System.Windows.Forms.Label latXLabel;
        private System.Windows.Forms.NumericUpDown altZNumericUpDown;
        private System.Windows.Forms.NumericUpDown lngYNumericUpDown;
        private System.Windows.Forms.TextBox pointTextBox;
        private System.Windows.Forms.Button savePathButton;
        private System.Windows.Forms.Label descritionLabel;
        private System.Windows.Forms.Panel selectedButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pointPictureBox;
        private System.Windows.Forms.PictureBox distancePictureBox;
        private System.Windows.Forms.PictureBox packagesPictureBox;
        private System.Windows.Forms.PictureBox timePictureBox;
        private System.Windows.Forms.Button saveRouteButton;
        private System.Windows.Forms.Label flyPHLabel;
        private System.Windows.Forms.Label distancePFLabel;
        private System.Windows.Forms.Label packagePHLabel;
        private System.Windows.Forms.Label routeTimeLabel;
        private System.Windows.Forms.Button savePrefrencesButton;
    }
}