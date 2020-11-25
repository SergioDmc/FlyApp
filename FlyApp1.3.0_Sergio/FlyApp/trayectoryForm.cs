using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.IO;

namespace FlyApp
{
    public partial class trayectoryForm : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dataT = new DataTable();
        List<PointLatLng> puntos = new List<PointLatLng>();
        GMapOverlay Ruta = new GMapOverlay("Ruta");
        Bitmap bmmarkerhome = FlyApp.Properties.Resources.homepin;
        dbPreferences<preferences> dbp = new dbPreferences<preferences>("dbPrefs.json");

        double latInit = 20.652836;
        double lngInit = -103.389278;
        int viewtype=0;
        public trayectoryForm()
        {
            InitializeComponent();
            dbp.load();
        }

        private void trayectoryForm_Load(object sender, EventArgs e)
        {
            try
            {
                latInit = dbp.prefValues[0].initLAT;
                lngInit = dbp.prefValues[0].initLNG;
            }
            catch (Exception) { }


            dataT.Columns.Add(new DataColumn("Description", typeof(string)));
            dataT.Columns.Add(new DataColumn("Lat.", typeof(double)));
            dataT.Columns.Add(new DataColumn("Lng", typeof(double)));
            dataT.Columns.Add(new DataColumn("Alt", typeof(double)));
            dataGridView.DataSource = dataT;

            LatXNumericUpDown.Value = Convert.ToDecimal(latInit);
            lngYNumericUpDown.Value = Convert.ToDecimal(lngInit);

            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(latInit, lngInit);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 15;
            gMapControl1.AutoScroll = true;

            pointTextBox.Text = "home";

            //Marker
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(latInit, lngInit), GMarkerGoogleType.red_dot);
            markerOverlay.Markers.Add(marker);
            
            gMapControl1.Overlays.Add(markerOverlay);

            zoomTrackBar.Value = 15;

            //Color Combo Box
            colorComboBox.DropDownStyle= System.Windows.Forms.ComboBoxStyle.DropDownList;
            colorComboBox.Items.Add("Select Color");
            colorComboBox.Items.Add("Red");
            colorComboBox.Items.Add("Blue");
            colorComboBox.Items.Add("Green");
            colorComboBox.Items.Add("Black");
            colorComboBox.Items.Add("Yellow");
            colorComboBox.SelectedIndex = 0;

            //Routes Combo Box
            routesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            routesComboBox.Items.Add("Select a path");
            routesComboBox.Items.Add("New path");
            routesComboBox.SelectedIndex = 0;

            //Drone combobox
            dronesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            dronesComboBox.Items.Add("Select a drone");
            dronesComboBox.SelectedIndex = 0;

            createRoutePanel.Visible =false; //Cambiar al FALSE
            newRoutePanel.Visible = false;

            //Map preferences
            try
            {
                toolTipCheckBox.Checked = dbp.prefValues[0].markerTooltipActive;
                switch (dbp.prefValues[0].view)
                {
                    case 0: originalRadioButton.Checked = true; break;
                    case 1: satelitalRadioButton.Checked = true; break;
                    case 2: reliefRadioButton.Checked = true; break;
                }
                zoomTrackBar.Value = Convert.ToInt32(dbp.prefValues[0].zoom);
                latTextBox.Text = dbp.prefValues[0].initLAT.ToString();
                lngTextBox.Text = dbp.prefValues[0].initLNG.ToString();
                colorComboBox.SelectedIndex = (int)dbp.prefValues[0].marColor;
            }
            catch (Exception) { }

        }

        private void toolTipCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (toolTipCheckBox.Checked)
            {
                marker.ToolTipMode = MarkerTooltipMode.Always;
                marker.ToolTipText = string.Format("Ubication: \n Latitude: {0} \n Longitude: {1} ",LatXNumericUpDown.Value, lngYNumericUpDown.Value);
                marker.ToolTip.Foreground = Brushes.LightGray;
                marker.ToolTip.Fill = Brushes.Black;
            }
            else
            {
                marker.ToolTipMode = MarkerTooltipMode.Never;
            }
            gMapControl1.Zoom = gMapControl1.Zoom + .1;
            gMapControl1.Zoom = gMapControl1.Zoom - .1;
        }

        private void mapPreferencesButton_Click(object sender, EventArgs e)
        {
            mapPrefPanel.Visible = true;
            newRoutePanel.Visible = false;
            selectedButton.Location = new Point(227, 95);
            selectedButton.Visible = true;
            mapPrefPanel.Size = new Size(250, 363);
            mapPreferencesButton.BackColor=Color.FromArgb(210, 210, 210);
            editRouteButton.BackColor = SystemColors.Control;
            newRouteButton.BackColor = SystemColors.Control;



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = colorComboBox.SelectedIndex;
            markerOverlay.Clear();

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (i == 0)
                {
                    marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(dataGridView.Rows[i].Cells[1].Value), Convert.ToDouble(dataGridView.Rows[i].Cells[2].Value)), bmmarkerhome);
                }
                else
                {
                    marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(dataGridView.Rows[i].Cells[1].Value), Convert.ToDouble(dataGridView.Rows[i].Cells[2].Value)), GMarkerGoogleType.blue);

                }
                markerOverlay.Markers.Add(marker);
            }
            switch (index)
            {
                case 1:
                    marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(LatXNumericUpDown.Value), Convert.ToDouble(lngYNumericUpDown.Value)), GMarkerGoogleType.red);
                    break;
                case 2:
                    marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(LatXNumericUpDown.Value), Convert.ToDouble(lngYNumericUpDown.Value)), GMarkerGoogleType.blue);
                    break;
                case 3:
                    marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(LatXNumericUpDown.Value), Convert.ToDouble(lngYNumericUpDown.Value)), GMarkerGoogleType.green);
                    break;
                case 4:
                    marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(LatXNumericUpDown.Value), Convert.ToDouble(lngYNumericUpDown.Value)), GMarkerGoogleType.black_small);
                    break;
                case 5:
                    marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(LatXNumericUpDown.Value), Convert.ToDouble(lngYNumericUpDown.Value)), GMarkerGoogleType.yellow);
                    break;
                default:
                    marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(LatXNumericUpDown.Value), Convert.ToDouble(lngYNumericUpDown.Value)), GMarkerGoogleType.red_dot);
                    break;
            }
            markerOverlay.Markers.Add(marker);
            if (toolTipCheckBox.Checked == true)
            {
                marker.ToolTipText = string.Format("Ubication: \n Latitude: {0} \n Longitude: {1} ", LatXNumericUpDown.Value, lngYNumericUpDown.Value);
                marker.ToolTip.Foreground = Brushes.LightGray;
                marker.ToolTip.Fill = Brushes.Black;
                marker.ToolTipMode = MarkerTooltipMode.Always;
            }
            gMapControl1.Zoom = gMapControl1.Zoom + .1;
            gMapControl1.Zoom = gMapControl1.Zoom - .1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void satelitalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleChinaSatelliteMap;
            viewtype = 1;
        }

        private void originalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            viewtype = 0;
        }

        private void reliefRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleTerrainMap;
            viewtype = 2;
        }


        private void zoomTrackBar_Scroll(object sender, EventArgs e)
        {

        }

        private void defaultZoomLabel_Click(object sender, EventArgs e)
        {

        }

        private void latTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lngTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zoomTrackBar.Value = Convert.ToInt32(gMapControl1.Zoom);
        }

        private void zoomTrackBar_ValueChanged(object sender, EventArgs e)
        {
            gMapControl1.Zoom = zoomTrackBar.Value;
        }

        private void newRouteButton_Click(object sender, EventArgs e)
        {
            newRoutePanel.Visible = true;
            mapPrefPanel.Visible = false;
            selectedButton.Location = new Point(227, 3);
            selectedButton.Visible = true;
            mapPrefPanel.Size = new Size(220,363);
            editRouteButton.BackColor = SystemColors.Control;
            newRouteButton.BackColor = Color.FromArgb(210, 210, 210);
            mapPreferencesButton.BackColor = SystemColors.Control;


        }

        private void routesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = routesComboBox.SelectedIndex;
            if (index==1)
            {
                createRoutePanel.Visible = true;
            }
            else
            {
                createRoutePanel.Visible = false;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            dataT.Rows.Add(pointTextBox.Text,LatXNumericUpDown.Value,lngYNumericUpDown.Value,altZNumericUpDown.Value);
            Ruta.Clear();
            markerOverlay.Clear();
            
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (i==0)
                {
                    marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(dataGridView.Rows[i].Cells[1].Value), Convert.ToDouble(dataGridView.Rows[i].Cells[2].Value)),bmmarkerhome);
                }
                else
                {
                    marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(dataGridView.Rows[i].Cells[1].Value), Convert.ToDouble(dataGridView.Rows[i].Cells[2].Value)), GMarkerGoogleType.blue);
                    
                }
                markerOverlay.Markers.Add(marker);
            }
            marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(LatXNumericUpDown.Value), Convert.ToDouble(lngYNumericUpDown.Value)), GMarkerGoogleType.red);
            markerOverlay.Markers.Add(marker);
            if (dataGridView.Rows.Count == 0)
            {
                pointTextBox.Text = "home";
            }
            else
            {
                pointTextBox.Text = "P" + dataGridView.Rows.Count.ToString();
            }

            puntos.Add(new PointLatLng(Convert.ToDouble(LatXNumericUpDown.Value), Convert.ToDouble(lngYNumericUpDown.Value)));
            GMapRoute routePoints = new GMapRoute(puntos,"Ruta");
            Ruta.Routes.Add(routePoints);
            gMapControl1.Overlays.Add(Ruta);
            gMapControl1.Zoom = gMapControl1.Zoom + .1;
            gMapControl1.Zoom = gMapControl1.Zoom - .1;

            

        }
        int pRow = 0;
        private void pickRow(object sender, DataGridViewCellMouseEventArgs e)
        {
            pRow = e.RowIndex;
            pointTextBox.Text = dataGridView.Rows[pRow].Cells[0].Value.ToString();
            LatXNumericUpDown.Value = Convert.ToDecimal(dataGridView.Rows[pRow].Cells[1].Value);
            lngYNumericUpDown.Value= Convert.ToDecimal(dataGridView.Rows[pRow].Cells[2].Value);
            altZNumericUpDown.Value= Convert.ToDecimal(dataGridView.Rows[pRow].Cells[3].Value);
            marker.Position = new PointLatLng(Convert.ToDouble(dataGridView.Rows[pRow].Cells[1].Value), Convert.ToDouble(dataGridView.Rows[pRow].Cells[2].Value));
            gMapControl1.Position = marker.Position;
            if(toolTipCheckBox.Checked)
                marker.ToolTipText = string.Format("Ubication. \n Latitude: {0} \n Longitude: {1}", dataGridView.Rows[pRow].Cells[1].Value, dataGridView.Rows[pRow].Cells[2].Value);

        }

        private void setMarkerP(object sender, MouseEventArgs e)
        {
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;
           LatXNumericUpDown.Value = Convert.ToDecimal(lat);
           lngYNumericUpDown.Value = Convert.ToDecimal(lng);
            marker.Position = new PointLatLng(lat, lng);
            if (toolTipCheckBox.Checked == true)
            {
                marker.ToolTipText = string.Format("Ubication: \n Latitude: {0} \n Longitude: {1} ", lat, lng);
                marker.ToolTip.Foreground = Brushes.LightGray;
                marker.ToolTip.Fill = Brushes.Black;
                marker.ToolTipMode = MarkerTooltipMode.Always;
            }
            gMapControl1.Zoom = gMapControl1.Zoom + .1;
            gMapControl1.Zoom = gMapControl1.Zoom - .1;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(dataGridView.Rows.Count > 0)
            {
                dataGridView.Rows.RemoveAt(dataGridView.Rows.Count - 1);
                Ruta.Clear();
                puntos.RemoveAt(puntos.Count-1);
                GMapRoute routePoints = new GMapRoute(puntos, "Ruta");
                Ruta.Routes.Add(routePoints);
                gMapControl1.Overlays.Add(Ruta);
                gMapControl1.Zoom = gMapControl1.Zoom + .1;
                gMapControl1.Zoom = gMapControl1.Zoom - .1;
                markerOverlay.Clear();
                for (int i = 0;i<dataGridView.Rows.Count; i++)
                {
                    if (i == 0)
                    {
                        marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(dataGridView.Rows[i].Cells[1].Value), Convert.ToDouble(dataGridView.Rows[i].Cells[2].Value)), bmmarkerhome);
                    }
                    else
                    {
                        marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(dataGridView.Rows[i].Cells[1].Value), Convert.ToDouble(dataGridView.Rows[i].Cells[2].Value)), GMarkerGoogleType.blue);
                    }
                    markerOverlay.Markers.Add(marker);
                }
                marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(LatXNumericUpDown.Value), Convert.ToDouble(lngYNumericUpDown.Value)), GMarkerGoogleType.red);
                markerOverlay.Markers.Add(marker);
                if (dataGridView.Rows.Count == 0)
                {
                    pointTextBox.Text = "home";
                }
                else
                {
                    pointTextBox.Text = "P" + dataGridView.Rows.Count.ToString();
                }

            }
                

        }

        private void routeNameTextBox_Enter(object sender, EventArgs e)
        {
            if (routeNameTextBox.Text == "Route name")
            {
                routeNameTextBox.Text = "";
                routeNameTextBox.ForeColor = Color.Black;
            }
        }

        private void routeNameTextBox_Leave(object sender, EventArgs e)
        {
            if (routeNameTextBox.Text == "")
            {
                routeNameTextBox.Text = "Route name";
                routeNameTextBox.ForeColor = Color.Gray;
            }
        }

        private void idRouteTextBox_Enter(object sender, EventArgs e)
        {
            if (idRouteTextBox.Text == "Route ID")
            {
                idRouteTextBox.Text = "";
                idRouteTextBox.ForeColor = Color.Black;
            }
        }

        private void idRouteTextBox_Leave(object sender, EventArgs e)
        {
            if (idRouteTextBox.Text == "")
            {
                idRouteTextBox.Text = "Route ID";
                idRouteTextBox.ForeColor = Color.Gray;
            }
        }

        private void orderIdTextBox_Enter(object sender, EventArgs e)
        {
            if (orderIdTextBox.Text == "Order ID")
            {
                orderIdTextBox.Text = "";
                orderIdTextBox.ForeColor = Color.Black;
            }
        }

        private void orderIdTextBox_Leave(object sender, EventArgs e)
        {
            if (orderIdTextBox.Text == "")
            {
                orderIdTextBox.Text = "Order ID";
                orderIdTextBox.ForeColor = Color.Gray;
            }
        }

        private void idPieceTextBox_Enter(object sender, EventArgs e)
        {
            if (idPieceTextBox.Text == "Package ID")
            {
                idPieceTextBox.Text = "";
                idPieceTextBox.ForeColor = Color.Black;
            }
        }

        private void idPieceTextBox_Leave(object sender, EventArgs e)
        {
            if (idPieceTextBox.Text == "")
            {
                idPieceTextBox.Text = "Package ID";
                idPieceTextBox.ForeColor = Color.Gray;
            }
        }

        private void weightTextBox_Enter(object sender, EventArgs e)
        {
            if (weightTextBox.Text == "Weight")
            {
                weightTextBox.Text ="";
                weightTextBox.ForeColor = Color.Black;
            }
        }

        private void weightTextBox_Leave(object sender, EventArgs e)
        {
            if (weightTextBox.Text == "")
            {
                weightTextBox.Text = "Weight";
                weightTextBox.ForeColor = Color.Gray;
            }
        }

        private void editRouteButton_Click(object sender, EventArgs e)
        {
            selectedButton.Location = new Point(227, 49);
            selectedButton.Visible = true;
            editRouteButton.BackColor = Color.FromArgb(210,210,210);
            newRouteButton.BackColor = SystemColors.Control;
            mapPreferencesButton.BackColor = SystemColors.Control;
        }

        private void newRouteScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            newRoutePanel.Location = new Point(646, 145-newRouteScrollBar.Value);
        }

        private void savePrefrencesButton_Click(object sender, EventArgs e)
        {

            string profile = "main";

            preferences.markerColor color;
            color=preferences.markerColor.def;
            switch (colorComboBox.SelectedIndex)
            {
                case 0: color = preferences.markerColor.def; break;
                case 1: color = preferences.markerColor.red; break;
                case 2: color = preferences.markerColor.blue; break;
                case 3: color = preferences.markerColor.green; break;
                case 4: color = preferences.markerColor.black; break;
                case 5: color = preferences.markerColor.yellow; break;

            }

            preferences prefs = new preferences(profile, toolTipCheckBox.Checked, viewtype, zoomTrackBar.Value,Convert.ToDouble(latTextBox.Text) ,Convert.ToDouble(lngTextBox.Text) ,color);
            if (File.Exists("dbPrefs.json"))
            {
                DialogResult dr=MessageBox.Show("Are you sure?\nYou will rewrite your preferences permanently.","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
                if(dr==DialogResult.OK)
                    dbp.refresh(x => x.profile == profile, prefs);
            }
            else
            {
                dbp.insert(prefs);
            }   
        }
    }
}
