namespace Алгоритмы
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void decartSpace_Click(object sender, EventArgs e)
        {
            Graphics _graphics = Graphics.FromImage(new Bitmap(decartSpace.Width, decartSpace.Height));
            _graphics.Clear(Color.White);
        }
    }
}