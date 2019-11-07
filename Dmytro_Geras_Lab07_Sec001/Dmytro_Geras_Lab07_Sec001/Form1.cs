using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dmytro_Geras_Lab07_Sec001
{
    public partial class Form1 : Form
    {
        int[] intGenerate;
        double[] doubleGenerate;
        char[] charGenerate;
        int type = 1;
        Boolean searchResult;


        // Create a new form.


        public Form1()
        {
            InitializeComponent();

        }


        private async void btnFactorial_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbFactorial.Text, "[^0-9]") || tbFactorial.Text == "")
            {
                MessageBox.Show("Please enter only numbers.");
                tbFactorial.Text = "";
            }
            else
            {

                // retrieve user's input as an integer
                ulong number = ulong.Parse(tbFactorial.Text);

                resultFactorial.Text = "Calculating...";

                // Task to perform Fibonacci calculation in separate thread
                Task<ulong> factorialTask = Task.Run(() => Factorial(number));

                // wait for Task in separate thread to complete
                await Task.Delay(12000);
                await factorialTask;
                


                // display result after Task in separate thread completes
                resultFactorial.Text = factorialTask.Result.ToString();
            }
        }
        // recursive method Factorial; calculates nth Factorial number
        public ulong Factorial(ulong number)
        {

            if (number == 0 || number == 1)
                return 1;
            else
            {

                ulong factorial = 1;
                for (ulong i = 1; i <= number; i++)
                {
                    factorial *= i;
                }
                return factorial;
            }
        }

        // determine whether an int is even
        private static bool IsEven(int number) => number % 2 == 0;

        // determine whether an int is odd
        private static bool IsOdd(int number) => number % 2 == 1;

        public delegate bool NumberPredicate(int number);
        NumberPredicate evenPredicate = IsEven;
        NumberPredicate oddPredicate = IsOdd;
        //private object cancellationToken;

        private void btnEvenOdd_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbEvenOdd.Text, "[^0-9]") || tbEvenOdd.Text == "")
            {
                MessageBox.Show("Please enter only numbers.");
                tbEvenOdd.Text = "";
            }
            else
            {

               
                    int number = int.Parse(tbEvenOdd.Text);
                    if (evenPredicate(number))
                    {
                        resultEvenOdd.Text = "Even";
                    }
                    else if (oddPredicate(number))
                    {
                        resultEvenOdd.Text = "Odd";
                    }
                    else
                    {
                        resultEvenOdd.Text = "Only integers are allowed";
                    }
                
            }
            
            // 
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = "";
            tbSearch.Text = "";
            Random rnd = new Random();
            if (radioIntegers.Checked)
            {
                intGenerate = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    int x = rnd.Next(10, 99);
                    intGenerate[i] = x;
                }
                listBoxGenerated.DataSource = intGenerate;
                type = 1;
            }
            else if (radioDoubles.Checked)
            {
                doubleGenerate = new double[10];
                for (int i = 0; i < 10; i++)
                {
                    int x = rnd.Next(10, 99);
                    double y = rnd.NextDouble() + x;
                    double truncated = Math.Truncate(y * 10) / 10;
                    doubleGenerate[i] = truncated;
                }
                listBoxGenerated.DataSource = doubleGenerate;
                type = 2;
            }
            else 
            {
                charGenerate = new char[10];
                //char[] passwd = new char[10];
                string allowedChars = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ";
                for (int i = 0; i < 10; i++)
                {
                    charGenerate[i] = allowedChars[rnd.Next(0, allowedChars.Length)];
                }
                listBoxGenerated.DataSource = charGenerate;
                type = 3;
            }
        }


        private static Boolean SearchData<T>(T[] inputArray, T currentVal) where T : IComparable<T>
        {
            int n = 0;

            foreach (var element in inputArray)
            {
                if (currentVal.CompareTo(element) == 0)
                {
                    return true;
                }
                n++;
            }
            return false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                switch (type)
                {
                    case 1:
                        int item1 = int.Parse(tbSearch.Text);
                        searchResult = SearchData(intGenerate, item1);
                        break;

                    case 2:
                        double item2 = double.Parse(tbSearch.Text);
                        searchResult = SearchData(doubleGenerate, item2);
                        break;

                    case 3:
                        var item3 = char.Parse(tbSearch.Text);
                        searchResult = SearchData(charGenerate, item3);
                        break;
                }
                if (searchResult) { tbDisplay.Text = "Found"; }
                else { tbDisplay.Text = "Not found"; }
            }
            catch (Exception ex) { tbDisplay.Text = ex.Message; }
        }

        private void PrintData<T>(T[] inputArray, int i1, int i2)
        {
            
            try
            {
                if (inputArray[i1] == null || inputArray[i2] == null)
                {
                    tbDisplay.Text = "Index is out of range";
                }
                else if (i2 <= i1)
                {
                    //throw new ArrayException("First index must be less then the second one");
                    tbDisplay.Text = "First index must be less then the second one";
                }
                else
                {
                    for (int i = i1; i <= i2; i++)
                    {
                        tbDisplay.Text = tbDisplay.Text +"  "+ inputArray[i];
                    }
                }

            }
            catch (Exception ex)
            {
               tbDisplay.Text=ex.Message;
            }
            
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = "";
            int i1, i2;
            if (System.Text.RegularExpressions.Regex.IsMatch(tbLowIndex.Text, "[^0-9]") ||
                System.Text.RegularExpressions.Regex.IsMatch(tbHighIndex.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                tbLowIndex.Text = "";
                tbHighIndex.Text = "";
            }
            else
            {
                try
                {
                    i1 = int.Parse(tbLowIndex.Text);
                    i2 = int.Parse(tbHighIndex.Text);


                    switch (type)
                    {
                        case 1:
                            PrintData(intGenerate, i1, i2);
                            break;

                        case 2:
                            PrintData(doubleGenerate, i1, i2);
                            break;

                        case 3:
                            PrintData(charGenerate, i1, i2);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    tbDisplay.Text = ex.Message;
                }
            }

        }
        
    }
}
