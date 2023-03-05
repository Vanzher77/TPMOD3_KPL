namespace TPMOD3_1302213058
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //input
            //Saat button di click akan meng outputkan text yang akan kita tulis
            string word = textBox1.Text;

            //output text, akan menampilkan Halo dan text yang kita tulis sebelumnya
            output1.Text = "Halo " + word;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //inputBox
        }
    }
}