namespace FastFoodApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SlidePanel.Height = button1.Height;
            SlidePanel.Top = button1.Top;
            firstCustomControl1.BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = button1.Height;
            SlidePanel.Top = button1.Top;
            firstCustomControl1.BringToFront();
        }
        //private void button2_Click(object sender, EventArgs e)
        //{
            //SlidePanel.Height = button2.Height;
            //SlidePanel.Top = button2.Top;
            //mySecondCustomControl1.Visible = true;  // Ensure it's visible
           // mySecondCustomControl1.BringToFront();
        //}

        private void button2_Click_1(object sender, EventArgs e)
        {
            SlidePanel.Height = button2.Height;
            SlidePanel.Top = button2.Top;
            //mySecondCustomControl1.Visible = true;  // Ensure it's visible
            mySecondCustomControl1.BringToFront();
        }
    }
}