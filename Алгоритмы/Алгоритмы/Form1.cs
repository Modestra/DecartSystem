using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
namespace Алгоритмы
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Draw();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void decartSpace_Click(object sender, EventArgs e)
        {

        }
        private void decartSpace_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void decartSpace_Paint(object sender, PaintEventArgs e)
        {
           
        }
        public void Draw()
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
 
        }
        private async void inputButton_Click(object sender, EventArgs e) //x + 30
        {
            listBox1.Items.Clear();
            Point[] points = new Point[decartSpace.Width*2];
            string example = textBox1.Text;
            int i = 0;
                for (int x = 0; x <= decartSpace.Width; x++)
                {
                    if (example.Contains('x'))
                    {

                    }
                    else if(example.Contains('='))
                    {
                        listBox1.Items.Add("Уравнение не должно содержать знак =");
                    }
                }
            //GraficSpace space = new();
            //space.CreateCell(decartSpace, points);
            Graphics graphics = decartSpace.CreateGraphics();
            Pen pen = new Pen(Color.Red, 2f);
            graphics.DrawLines(pen, points);

        }
        void Example()
        {
            Thread.Sleep(10000);
            
        }
        async Task Complete()
        {
            await Task.Run(() => Example());
        }
    }
}