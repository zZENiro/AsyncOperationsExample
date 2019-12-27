using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AsyncOperations
{
    public partial class Form1 : Form
    {
        static int a = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoAsync();
            this.label1.Text = $"A is {a}";
        }

        private async Task DoAsync()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                a = 5;
            });

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label1.Text = $"A is {a}";
        }
    }
}
