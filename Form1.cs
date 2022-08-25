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
namespace asynchronousForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
             Add(int.Parse(tbx1.Text) , int.Parse(tbx2.Text));
        }

        private async void btnImpact_Click(object sender, EventArgs e)
        {
             await Impact(int.Parse(tbx1.Text), int.Parse(tbx2.Text));
        }

        private void Add(int number1,int number2)
        {
            int total=number1 + number2;
            MessageBox.Show(total.ToString());
        }
        private Task Impact(int number1, int number2)
        {
            return Task.Run (()=>
            {
              Thread.Sleep(10000);
              int total = number1 * number2;
              MessageBox.Show(total.ToString());
           });
        }
    }
}
