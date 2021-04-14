using System;
using System.Drawing;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[1].WorkingArea.Location;
            label1.Parent = panel1;
            label1.BackColor = Color.Transparent;
            button4.Parent = panel1;
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;
            notifyIcon1.ShowBalloonTip(1000000000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError((Control)sender, "Test");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            helpProvider1.SetShowHelp((Control)sender, true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            helpProvider1.Dispose();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BRUH_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void LaunchWebBrowser_Click(object sender, EventArgs e)
        {
            winxpform1 f2 = new winxpform1();
            f2.ShowDialog(); // Browser
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            winxpform2 f3 = new winxpform2();
            f3.ShowDialog(); // Lotto Number Generator (taken from C++ Coding Book... huh)
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            savebigpoopy.ShowDialog();
        }
    }
}
