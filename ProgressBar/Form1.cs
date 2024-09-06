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

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Task Started...";
            Task t = new Task(LongRunningTask);
            t.Start();
            await t;
            UpdateStatus(); 
        }

         
        private void LongRunningTask()
        {

            for (int i=0; i < 10;i++)
            {
                Thread.Sleep(500);
            }
        }
        public void UpdateStatus()
        {
            this.label1.Text = "Task Completed Succesfully!!!";
        } 
        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
