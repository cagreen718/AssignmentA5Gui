namespace ComicConventionGUI5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton ConAuto = new RadioButton();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton ConSup = new RadioButton();


        }

        private void bttnClear_Click(object sender, EventArgs e)
        {

            //rEF: https://www.codeproject.com/Tips/733147/Clear-All-textbox-Text-On-One-Click-2#:~:text=Just%20use%20textbox%2Did.,will%20clear%20the%20textbox%20text.
            textBox1.Text = string.Empty;
            txtCostBox.Text = string.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { //1st Textbox and Ref: https://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers less than 20.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void txtCostBox_TextChanged(object sender, EventArgs e)
        { // last Textbox

           
        }

        private void rBttnCon_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton Con = new RadioButton();

        }

        private void bttnCalculate_Click(object sender, EventArgs e)
        {
             if (rBttnConSup.Checked)
                        {
                            int totalCost = 380 * Convert.ToInt32(textBox1.Text);
                            txtCostBox.Text = totalCost.ToString();
                        }
                        if (rBttnConAuto.Checked)
                        {
                            int totalCost = 275 * Convert.ToInt32(textBox1.Text);
                            txtCostBox.Text = totalCost.ToString();
                        }
                        else
                        {
                            int totalCost = 209 * Convert.ToInt32(textBox1.Text);
                            txtCostBox.Text = totalCost.ToString();
                        }
        }
    }
}
