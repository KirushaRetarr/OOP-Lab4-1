using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int[] genMass = new int[n];
            Random randValue = new Random();

            for (int i = 0; i < genMass.Length; i++)
            {
                genMass[i] = randValue.Next(1, 50);
            }
            
            textBox4.Text = string.Join(" ", genMass);

            List<int> evenMass = new List<int> { };
            List<int> forSumMass = new List<int> { };

            for (int i = 0; i < genMass.Length; i++) {
                if (i % 2 == 0)
                {
                    evenMass.Add(genMass[i]);
                }
            }

            for (int i = 1; i < genMass.Length - 1; i++)
            {
                forSumMass.Add(genMass[i]);
            }

            int multiResult = 1;
            int sumResult = 0;

            foreach (int num in evenMass)
            {
                multiResult *= num;
            }

            foreach (int num in forSumMass)
            {
                sumResult += num;
            }

            textBox2.Text = multiResult.ToString();
            textBox3.Text = sumResult.ToString();
        }
    }
}
