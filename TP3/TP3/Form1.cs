namespace TP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt16(textBox1.Text);
            listboxArr1.Items.Add(number);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt16(textBox2.Text);
            listboxArr2.Items.Add(number);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listboxArr3.Items.Clear();
            for(int i = 0; i < listboxArr1.Items.Count; i++)
            {
                int numberOne = Convert.ToInt16(listboxArr1.Items[i]);
                int numberTwo = Convert.ToInt16(listboxArr2.Items[i]);
                listboxArr3.Items.Add(numberOne + numberTwo);
            }
        }
    }
}