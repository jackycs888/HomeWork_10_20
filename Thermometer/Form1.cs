namespace Thermometer
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

        private void NumberButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                textBox1.Text += btn.Text;
            }
        }

        private void Button_Clear(object sender, EventArgs args)
        {
            textBox1.Text = string.Empty;
            label2.Text = string.Empty;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ThermoCalculate thermoCalculate = new ThermoCalculate();

            if (radioButton1.Checked)
            {
                double celsiusValue = double.Parse(textBox1.Text);
                double fahrenheitResult = thermoCalculate.ThermoTransfer(true, celsiusValue);
                label2.Text = $"{fahrenheitResult} ¢XF";
            }
            else if (radioButton2.Checked)
            {
                double fahrenheitValue = double.Parse(textBox1.Text);
                double celsiusResult = thermoCalculate.ThermoTransfer(false, fahrenheitValue);
                label2.Text = $"{celsiusResult} ¢XC";
            }
        }
    }
}
