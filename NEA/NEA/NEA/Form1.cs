namespace NEA
{
    public partial class Form1 : Form
    {
        List<TextBox> textBoxes = new List<TextBox>();
        //Creates a list to hold the textboxes
        int nextBox = 0;
        int vertical = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                int tempHorizontal = 0;
                if (nextBox % 3 == 0)
                {
                    tempHorizontal = 0;
                }
                else if (nextBox % 3 == 1)
                {
                    tempHorizontal = 30;
                }
                else
                {
                    tempHorizontal = 60;
                }
                //Makes the horizontal position iterate between three columns.
                TextBox tempbox = new TextBox()
                {
                    Size = new Size(23, 23),
                    Location = new Point(670 + tempHorizontal, 50 + 30 * (vertical)),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White,
                };
                textBoxes.Add(tempbox);
                //Creates a new texbox when the button is pressed.
                this.Controls.Add(textBoxes[nextBox]);
                //Adds the textbox to the list.
                this.Invalidate();
                //Redraws the textbox.
                nextBox += 1;
            }
            vertical += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
