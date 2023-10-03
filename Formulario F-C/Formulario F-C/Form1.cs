namespace Formulario_F_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float F = float.Parse(textbox1.Text);
            //label1.Text = F.ToString();
            float C = (F - 32) * 5.0f / 9.0f;
            textbox2 .Text = C.ToString();
            //label2.Text = C.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float C = float.Parse(textbox2.Text);
            float F = ((C * (9f / 5f)) + 32);
            textbox1. Text = F.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textbox1.Text = "0,0";
            textbox2.Text = "0,0";
        }
    }
}
