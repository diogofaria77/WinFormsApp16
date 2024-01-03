namespace WinFormsApp16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                int soma = 0;

                // Utilizando um loop for para somar os números de 1 a 1000
                for (int i = 0; i <= 1000; i++)
                {
                    soma += i;
                    listBox1.Items.Add("+" + i.ToString());
                }
                MessageBox.Show(" soma de 1 a 1000 'e:" + soma.ToString());

            }
        }
    }
}