namespace NEA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox textBox4 = new TextBox()
            {
                Size = new Size(23, 23),
                Location = new Point(670, 40),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White,
            };
            this.Controls.Add(textBox4);
            //Creates a new textbox when the button is pressed.
            this.Invalidate();
            //Redraws the textbox.
        }
    }
}
