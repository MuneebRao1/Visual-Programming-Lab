namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public string CustomerName { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }
        public string Status { get; set; }
        public string Hobbies { get; set; }




        public Form1()
        {
            InitializeComponent();
            CustomerName = "";
            Country = "";
            Gender = "";
            Status = "";
            Hobbies = "";


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button1_click(object sender, EventArgs e)
        {

            CustomerName = this.textBox1.Text;
            Country = this.comboBox1.Text;
            Gender = this.radioButton1.Checked? "Male" : radioButton2.Checked? "Female":"";
            Status = this.radioButton3.Checked ? "Unmarried" : "";
            Status = this.radioButton4.Checked ? "Married" : "";
            Hobbies = this.checkBox1.Checked ? "Painting ":"";
            Hobbies += this.checkBox2.Checked ? "Reading":"";






            Form2 f2 = new Form2(CustomerName,Country,Gender,Hobbies, Status);

            f2.ShowDialog();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}