namespace Алгоритмы
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Draw();
            GraficSpace space = new();
            space.CreateCell(decartSpace);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void decartSpace_Click(object sender, EventArgs e)
        {
            Graphics _graphics = Graphics.FromImage(new Bitmap(decartSpace.Width, decartSpace.Height));
            _graphics.Clear(Color.White);
        }
        private void decartSpace_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void decartSpace_Paint(object sender, PaintEventArgs e)
        {
            
            Pen pen = new Pen(Color.Black);
            
        }
        public void Draw()
        {
        }
    }
}