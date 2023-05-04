using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        int[] mas;
        Random rand = new Random();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = rand.Next(0, 15);
            mas = new int[n];
            listBox1.Items.Clear();

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rand.Next(-3, 3);
                listBox1.Items.Add(Convert.ToString(mas[i]));

            }

            int sum = 0;
            int k = 0;
            int[] ki=new int[2];
            ki[0] = -1;
            ki[1] = -1;
            int lol = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] == 0 && ki[0]==-1)
                {
                    k++;
                    ki[0]=i;
                }
                if (mas[n - 1 - i] == 0 && ki[1]==-1)
                {
                    k++;
                    ki[1] = n - 1 - i;
                }
            }
            if (ki[0] != -1 && ki[1]!=-1)
            {
                lol = ki[0];
                for (; lol < ki[1]; lol++)
                {
                    sum = sum + mas[lol];
                }
            }

            label1.Text ="сума между первым и последними индексами:\n" + sum;
        }
    }
}
