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

namespace Threads
{
    public partial class FrmCheckThreadValue : Form
    {
        private BackgroundWorker _bw;
        public FrmCheckThreadValue()
        {

            InitializeComponent();
            _bw = new BackgroundWorker();
            _bw.DoWork += bw_DoWork;
            _bw.RunWorkerCompleted += bw_RunWorkerCompleted;
            _bw.RunWorkerAsync();

            // if you want to send arguments
            //_bw.RunWorkerAsync("Anas");

        }
        private void FrmCheckThreadValue_Load(object sender, EventArgs e)
        {
            ////Error when change text for textbox2
            //Action actionCheck = Check;
            //actionCheck.BeginInvoke(null, null);

            ////The same Error when change text for textbox2
            //Thread newThreads = new Thread(Check);
            //newThreads.Start();

        }
        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            //MessageBox.Show(e.Argument.ToString());
            //for (int i = 0; i < 9999999; i++)
            //{

            //}

            ////to return value
            //e.Result = "Mysoon";
            var flag = true;

            do
            {
                if (textBox1.Text == @"Mohamed")
                {
                    flag = false;
                }
               
            } while (flag);
        }

        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // to get return values
            //var result = e.Result.ToString();
            //MessageBox.Show(result);
            textBox2.Text = @"Hi! Mohamed Aamer";
            var bw = (BackgroundWorker)sender;
            bw.RunWorkerAsync();
        }




        public void Check()
        {
            do
            {
                textBox2.Text = textBox1.Text == @"Mohamed" ? @"Hi! Mohamed Aamer" : "";
            } while (true);
        }


    }
}
