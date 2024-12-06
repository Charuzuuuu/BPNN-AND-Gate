using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backprop;

namespace BPNN_AND_Gate
{
    public partial class Form1 : Form
    {
        NeuralNet nn;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nn = new NeuralNet(4, 200, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < 100; x++)
            {
                //0000
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //0001
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //0010
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //0011
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //0100
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //0101
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //0110
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //0111
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //1000
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //1001
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //1010
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //1011
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //1100
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //1101
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //1110
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //1111
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nn.setInputs(0, Convert.ToDouble(textBox1.Text));
            nn.setInputs(1, Convert.ToDouble(textBox2.Text));
            nn.setInputs(2, Convert.ToDouble(textBox3.Text));
            nn.setInputs(3, Convert.ToDouble(textBox4.Text));
            nn.run();
            textBox5.Text = "" + nn.getOuputData(0);
        }
    }
}
