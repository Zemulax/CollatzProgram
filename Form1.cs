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
                    CollatzResolver(num);
                    NumberInput.Clear();
                    }

                }
                
                catch (Exception)
                
                {
                    MessageBox.Show("Null or values > 2^17 are not allowed yet!"); //"Nine Hundred ninety nine quadrillion"
                }


            

        }

        /// <summary>
        /// This is the engine of the collatz conjecture. checks if number is correct,even or odd.
        /// </summary>
        /// <param name="number">The number provided by user to calculate the conjecture.</param>
        public void CollatzResolver(long number)
        {

            long total;
            counter = 0;
            if (number <= 0)
            {             //if x is any negative integer or zero, halt!
                MessageBox.Show("Please enter a number from 1\n");
            }
            else
            {
                if (number % 2 == 0)
                {// this block of code begins when the argument is even
                    while (number % 2 == 0)
                    {
                        total = Even(number);
                        counter++;
                        Loga(total);

                        if (total == 1)
                        {                    //dont loop forever!
                            Text1();
                            break;
                        }
                        number--;

                        while (total % 2 == 1)
                        {            //nested for loop in iteration
                            total = Odd(total);
                            counter++;
                            Loga(total);
                        }
                        while (total % 2 == 0)
                        {
                            total = Even(total);
                            counter++;
                            Loga(total);

                            if (total == 1)
                            {                    //dont loop forever!
                                Text1();
                                break;
                            }
                            while (total % 2 == 1)
                            {   //this method call is likedly to have the lowest number per iteration
                                total = Odd(total);
                                counter++;
                                Loga(total);

                            }
                        }
                    }
                }
                else
                {
                    if (number <= 0)
                    {
                        MessageBox.Show("Please enter a number from 1\n");
                    }
                    else
                    {


                        while (number % 2 == 1)
                        {      // this block of code begins when the argument is odd

                            total = Odd(number);
                            counter++;
                            Loga(total);
                            number--;
                            while (total % 2 == 0)
                            {
                                total = Even(total);
                                counter++;
                                Loga(total);
                            }
                            while (total % 2 == 1)
                            {
                                if (total == 1)
                                {                    //dont loop forever!
                                    Text1();
                                    break;
                                }
                                total = Odd(total);
                                counter++;
                                Loga(total);

                                while (total % 2 == 0)
                                {
                                    total = Even(total);
                                    counter++;
                                    Loga(total);

                                }
                            }
                        }
                    }
                }
                Display2.Text += "\n**** Counter is " + counter + "\n";
                
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


