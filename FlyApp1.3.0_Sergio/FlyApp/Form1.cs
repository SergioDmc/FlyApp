using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace FlyApp
{
    public partial class Form1 : Form
    {
       
        int mov,movX,movY;
        LinearGradientBrush lgn = new LinearGradientBrush(new Point(0, 0), new Point(16, 0), Color.FromArgb(240, 240, 240), Color.FromArgb(37, 37, 37));
        
        public Form1()
        {
            InitializeComponent();
            openFormInPanel(new home());
            selectedPanel.Location = new Point(0, 216);
            selectedPanel.Visible = true;
            Graphics g = selectedPanel.CreateGraphics();
            g.FillRectangle(lgn, 0, 0, 15, 37);
       
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void closeButtom_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizeButtom_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            maximizeButtom.Visible = false;
            maxminButtom.Visible = true;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X+panelPrincipal.Width;
            movY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

       
        private void minimizeButtom_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            openFormInPanel(new home());
            selectedPanel.Location = new Point(0, 216);
            selectedPanel.Visible = true;
            Graphics g = selectedPanel.CreateGraphics();
            g.FillRectangle(lgn, 0, 0, 15, 37);

        }

        private void routeButton_Click(object sender, EventArgs e)
        {
            openFormInPanel(new trayectoryForm());
            selectedPanel.Location = new Point(0, 269);
            selectedPanel.Visible = true;
            Graphics g = selectedPanel.CreateGraphics();
            g.FillRectangle(lgn, 0, 0, 15, 37);
        }

        private void registersButton_Click(object sender, EventArgs e)
        {
            selectedPanel.Location = new Point(0, 325);
            selectedPanel.Visible = true;
            Graphics g = selectedPanel.CreateGraphics();
            g.FillRectangle(lgn, 0, 0, 15, 37);
        }

        private void dronesButton_Click(object sender, EventArgs e)
        {
            selectedPanel.Location = new Point(0, 381);
            selectedPanel.Visible = true;
            Graphics g = selectedPanel.CreateGraphics();
            g.FillRectangle(lgn, 0, 0, 15, 37);
        }

        private void configurationsButton_Click(object sender, EventArgs e)
        {
            selectedPanel.Location = new Point(0, 551);
            selectedPanel.Visible = true;
            Graphics g = selectedPanel.CreateGraphics();
            g.FillRectangle(lgn, 0, 0, 15, 37);
            openFormInPanel(new configs());
        }

        private void maxminButtom_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            maximizeButtom.Visible = true;
            maxminButtom.Visible = false;
        }

        private void openFormInPanel(object sonform)
        {
            if (this.containerPanel.Controls.Count > 0)
                this.containerPanel.Controls.RemoveAt(0);
            Form sf = sonform as Form;
            sf.TopLevel = false;
            sf.Dock = DockStyle.Fill;
            this.containerPanel.Controls.Add(sf);
            this.containerPanel.Tag = sf;
            sf.Show();
        }
    }
}
