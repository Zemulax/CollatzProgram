using System;

namespace CollatzProgram1
{
    public partial class Collatz : Form
    {
        public Collatz()
        {
            InitializeComponent();
            Progressbar.Minimum = 0;
            Progressbar.Maximum = 62118; //this is the highest number of cycles from a submitted number
            
        }

        int counter;
        readonly long maxValue = 9223368888888888888; //nine quintillion...

        private void Start_Click(object sender, EventArgs e)
        {
            Display2.Text = " *****************\n";
            //converting the user input into a number
            long num;
                try
                {
                    Progressbar.Value = 0; //resets the value of the progress bar
                    num = long.Parse(NumberInput.Text);
                    if (num > maxValue)
                    {
                    MessageBox.Show("illegal number detected");
                    return;
                    }
                    else
                    {
                     CollatzResolver(submittedNumber);
                    NumberInput.Clear();
                    }

                }
                
                catch (Exception)
                
                {
                    MessageBox.Show("Null or values > 2^17 are not allowed yet!"); //"Nine Hundred ninety nine quadrillion"
                }
        }

        /// <summary>
        /// Performs math on even numbers only.
        /// </summary>
        /// <param name="evenNumber">The even number to do the math on.</param>
        /// <returns>returns the result of involving the even number</returns>
        public long Even(long evenNumber)
        {
            Display2.Text += "\n Calculating for " + evenNumber + "\n";
            Progressbar.Increment(1);
            return evenNumber / 2;
        }

        /// <summary>
        /// performs math on odd numbers only
        /// </summary>
        /// <param name="oddNumber">The odd number to perform the calculations on.</param>
        /// <returns> returns the result of calculating an odd number</returns>
        public long Odd(long oddNumber)
        {
           
            Display2.Text += "\n Calculating for " + oddNumber + "\n";
            Progressbar.Increment(1);
            return (oddNumber * 3) + 1;
        }
        /// <summary>
        /// Simply tells the user 1 has been reached.End of the program execution
        /// </summary>
        public void Text1()
        {
            Display2.Text += "\n <<<< 1 has been Reached! >>>>\n";
        }
        /// <summary>
        /// This method simply logs a generated value
        /// </summary>
        /// <param name="number">number to be logged</param>
        public void Loga(long number)
        {
            
            Display2.Text += " >>" + number + " was generated\n";
        }

        private void Display_TextChanged(object sender, EventArgs e)
        {

        }

        private void Progressbar_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


