using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
namespace Алгоритмы
{
    public partial class Form1 : Form
    {
        List<double> ordinat = new List<double>();
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
        private async void inputButton_Click(object sender, EventArgs e)
        {
            //string[] input = textBox1.Text.Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries); //Работает
            string example = textBox1.Text;
            await Complete();
            for (double x = -decartSpace.Width; x < decartSpace.Width; x = x + 1.0)
            {
                if(example.Contains('x'))
                {
                    string input = example.Replace("x", Convert.ToString(x));
                    ScriptEngine engine = Python.CreateEngine();
                    ScriptScope scope = engine.CreateScope();
                    scope.SetVariable("x", input);
                    engine.ExecuteFile(@"C:\Users\Пользователь\OneDrive\Рабочий стол\DecartSystem\Алгоритмы\Алгоритмы\script.py", scope);
                    dynamic calc = scope.GetVariable("calc");
                    ordinat.Add(calc(input));
                    listBox1.Items.Add(calc(input));
                }
            }
        }
        void Example()
        {
            Thread.Sleep(8000);
        }
        async Task Complete()
        {

        }
    }
}