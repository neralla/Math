using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace MathApplication
{
    public partial class FrmGeneratePrimeNumbers : Form
    {
        public FrmGeneratePrimeNumbers()
        {
            InitializeComponent();
            
        }
        private int counter;
        private CancellationToken token;
        private CancellationTokenSource tokensource  ;
        private int timeInSeconds = 60;
        private long largestPrime=7;
        private void GeneratePrime_Click(object sender, EventArgs e)
        {
            counter = 0;
            tokensource = new CancellationTokenSource();
            token = tokensource.Token;
            ShowProgressInSeconds();
            GetLargestPrime(token);
            btnGeneratePrimeNumbers.Enabled = false;
        }

        private void Secondstimer_Tick(object sender, EventArgs e)
        {

            if (counter < timeInSeconds)
            {
                counter++;
                lblSecondsProgress.Text = counter.ToString();
                txtHighestPrimeNumber.Text = largestPrime.ToString();
            }
            else
            {
                SecondsTimer.Enabled = false;
                tokensource.Cancel();
                btnGeneratePrimeNumbers.Enabled = true;
            }
        }
        public void ShowProgressInSeconds()
        {
            if (!SecondsTimer.Enabled)
            {
                lblSecondsProgress.Text = counter.ToString();
                SecondsTimer.Interval =  1000;// milliSeconds / 1000;
                SecondsTimer.Enabled = true;
            }
        }
        private  long GetLargestPrime(CancellationToken token)
        {
            try
            {           
                 Task t = Task.Factory.StartNew(() =>
                {

                    long numberToVerify = largestPrime;
                        while (1 == 1)
                        {
                            if (token.IsCancellationRequested)
                            {
                                break;
                            }
                            else
                            {
                                numberToVerify++;
                                if (IsPrime(numberToVerify))
                                {
                                    largestPrime = numberToVerify;
                                }
                            }
                        }                

                }, token);
                t.Wait(timeInSeconds);
                return largestPrime;
            }
            catch (AggregateException agEx)
            {
                if (agEx.InnerException is OutOfMemoryException)
                    throw new Exception(string.Format("Task error occured as value of highest prime exceeded the range of long"));
                else
                    throw agEx.InnerException;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private static bool IsPrime(long input)
        {

            if (input % 2 == 0)
            {
                return false;
            }
            for (long i = 3; i * i <= input; i += 2)
            {
                if ((input % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
