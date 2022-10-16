namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(numericUpDown1.Value < 127)
            {
                label4.Text = "Klasa A";
                label4.Visible = true;
            }
           else if(numericUpDown1.Value <192 ) 
    {
                label4.Text = "Klasa B";
                label4.Visible = true;
            }
            else if( numericUpDown1.Value <224)
            {
                label4.Text = "Klasa C";
                label4.Visible = true;
            }
            else if( numericUpDown1.Value < 240){
                label4.Text = "Klasa D";
                label4.Visible = true;
            }
            else if(numericUpDown1.Value < 248)
            {
                label4.Text = "Klasa E";
                label4.Visible = true;
            }
            else if (numericUpDown1.Value < 256)
            {
                label4.Text = "Klasa F";
                label4.Visible = true;
            }
            
            
            if (numericUpDown1.Value > 255 || numericUpDown2.Value > 255 || numericUpDown3.Value > 255 || numericUpDown4.Value > 255)
            {
                label1.Text = "Nie poprawne";
                label1.Visible = true;
            }
            else 
                label1.Text = "poprawne";
            label1.Visible=true;
        }
        
    }
}