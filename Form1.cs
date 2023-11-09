using System.Windows.Forms;


namespace Triangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
            this.BackColor = Color.DarkSeaGreen;
            button1.Text = "����������";
            button1.BackColor = Color.Coral;
            textBox1.BackColor = Color.DarkOrchid;
            textBox2.BackColor = Color.DarkOrchid;
            textBox3.BackColor = Color.DarkOrchid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                double side1 = Convert.ToDouble(textBox1.Text);
                double side2 = Convert.ToDouble(textBox2.Text);
                double side3 = Convert.ToDouble(textBox3.Text);
                if (side1 + side2 >= side3 && side2 + side3 >= side1 && side1 + side3 >= side2)
                {
                    if (side1 == side2 && side2 == side3 && side1 == side3)
                    {
                        MessageBox.Show("����������� ��������������");
                    }
                    else if (side1 == side2 || side1 == side3 || side2 == side3)
                    {
                        MessageBox.Show("����������� ��������������");
                    }
                    else
                    {
                        MessageBox.Show("����������� ��������������");
                    }
                }
                else
                {
                    MessageBox.Show("������������ �� ����������");
                }

            }
            catch
            {
                MessageBox.Show(
                    "������� �������� ������ ������������"
                    ); 
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}