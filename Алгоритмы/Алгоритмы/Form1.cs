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
            GraficSpace space = new();
            space.CreateCell(decartSpace);
        }
        public enum Elements
        {
            Multuply = '*',
            Devine = '/',
            Stepen = '^',
            Sum = '+',
            Minus = '-'
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
        public double Result(double a, double b, Elements operation)
        {
            double result = operation switch
            {
               Elements.Devine => a/b,
               Elements.Multuply => a*b,
               Elements.Sum => a + b,
               Elements.Minus => a - b
            };
            return result;
        }
        private void inputButton_Click(object sender, EventArgs e)
        {
            //string[] input = textBox1.Text.Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries); //Работает
            string example = "x^2";
            for (int x = -decartSpace.Width; x < decartSpace.Width; x = x + 1)
            {
                if(example.Contains('x'))
                {
                    string input = example.Replace("x", Convert.ToString(x));
                    ScriptEngine engine = Python.CreateEngine();
                    ScriptScope scope = engine.CreateScope();
                    scope.SetVariable("x", input);
                    engine.ExecuteFile(@"C:\Users\Пользователь\OneDrive\Рабочий стол\DecartSystem\Алгоритмы\Алгоритмы\script.py", scope);
                    dynamic calc = scope.GetVariable("calc");
                    listBox1.Items.Add(calc(input));
                }
            }
        }
    }
}