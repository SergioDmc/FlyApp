using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyApp
{
    public partial class home : Form
    {
        private int conteo;
        public home()
        {
            InitializeComponent();
            conteo = 0;
            pictureBoxBackground.Visible = true;
            pictureBackground2.Visible = false;
            pictureBackground3.Visible = false;
            timerBackground.Enabled = true;
        }

        private void timerBackground_Tick(object sender, EventArgs e)
        {
            conteo++;
            if (conteo > 2)
                conteo = 0;     
            
                switch (conteo)
            {
                case 0:
                    pictureBackground3.Visible = false;
                    pictureBoxBackground.Visible = true;
                    panel1.Location = new Point(471, 322);
                    dronesOnAirLabel.Location = new Point(495, 478);
                    panel1.BackColor = Color.FromArgb(40, 40, 40);
                    dronesOnAirLabel.BackColor = Color.FromArgb(40, 40, 40);
                    dronesOnAirLabel.ForeColor = Color.FromArgb(240, 240, 240);
                    // context labels
                    packageSentLabel.Text = "Packages sended:";
                    timeFlyedLabel.Text = "Time on air:";
                    serviceLabel.Text = "Service status:";
                    availableDronesLabel.Text = "Available Drones:";
                    // container labels
                    packCountLabel.Text = "289";
                    timeTraveledCountLabel.Text = "2d 3hr 22min";
                    distanceTraveledCountLabel.Text = "Active";
                    availableDronCountLabel.Text = "29";

                    break;
                case 1:
                    pictureBackground2.Visible = true;
                    pictureBoxBackground.Visible = false;
                    panel1.Location = new Point(29, 382);
                    dronesOnAirLabel.Location = new Point(12, 339);
                    //Contexte labels
                    packageSentLabel.Text = "Tasks completed:";
                    timeFlyedLabel.Text = "Active Orders";
                    serviceLabel.Text = "Distance Traveled";
                    availableDronesLabel.Text = "Drones in repair";
                    // container labels
                    packCountLabel.Text = "52";
                    timeTraveledCountLabel.Text = "7";
                    distanceTraveledCountLabel.Text = "34Km";
                    availableDronCountLabel.Text = "3";
                    break;
                case 2:
                    pictureBackground2.Visible = false;
                    pictureBackground3.Visible = true;
                    panel1.Location = new Point(29, 382);
                    dronesOnAirLabel.Location = new Point(12, 339);
                    panel1.BackColor = Color.FromArgb(240, 240, 240);
                    dronesOnAirLabel.BackColor = Color.FromArgb(240, 240, 240);
                    dronesOnAirLabel.ForeColor = Color.FromArgb(40, 40, 40);
                    break;
            }
        }

    }
}
