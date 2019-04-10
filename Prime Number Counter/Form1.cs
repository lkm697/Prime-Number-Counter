using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_Number_Counter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long min = long.Parse(minText.Text);
            long max = long.Parse(maxText.Text);
            //resultText.Text = PrimeCal.PrimeCount(min, max).ToString();
            long result; string timer;
            button1.BackColor = Color.Red;
            button1.Text = "Calculating...";
            PrimeCal.PrimeCount(min, max, out result, out timer);

            resultText.Text = result.ToString();
            timeLabel.Text = timer;
            button1.BackColor = Color.Cyan;
            button1.Text = "Calculate Primes";
        }
    }
}
