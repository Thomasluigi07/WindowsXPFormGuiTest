using System;
using System.Drawing;
using System.Windows.Forms;
namespace WindowsFormsApp2
{
    public partial class winxpform2 : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public winxpform2()
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
            Clear();
        }
        private void Clear()
        {
            this.label7.Text = "...";
            this.label6.Text = "...";
            this.label8.Text = "...";
            this.label5.Text = "...";
            this.label3.Text = "...";
            this.label4.Text = "...";
            this.getBtn.Enabled = true;
            this.resetBtn.Enabled = false;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void winxpform2_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void getBtn_Click(object sender, EventArgs e)
        {
            this.label7.Text = "WHOOPS";
            this.label6.Text = "WE";
            this.label8.Text = "HAVE";
            this.label5.Text = "RAN";
            this.label3.Text = "INTO";
            this.label4.Text = "A PROBLEM";
            this.getBtn.Enabled = false;
            this.resetBtn.Enabled = true;
        }
    }
}
