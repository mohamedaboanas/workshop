using System;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Windows.Forms;

namespace Threads
{
    public partial class Form1 : Form
    {
        internal class MyThreadParam
        {
            public int X { get; set; }
            public string Name { get; set; }

            public MyThreadParam(int x, string name)
            {
                X = x;
                Name = name;
            }
        }

        public Form1()
        {
           
            Func<string, Int64> myFunc = CountWithString;
            InitializeComponent();

            var asyncResultText = myFunc.BeginInvoke("Ali", GetValues, null);
           // var res = myFunc.EndInvoke(asyncResultText);
            //MessageBox.Show(res.ToString());

            //Func<Int64> myCounter = Counter;
            //var asyncResult = myCounter.BeginInvoke(null, null);

            //var result = myCounter.EndInvoke(asyncResult);
            //MessageBox.Show(result.ToString());

            //var count = Counter();
            //MessageBox.Show(count.ToString());

            //// Using Delegate to call to function and put them in Thread to workin asyncrus
            //Action<object> wD = WorkingWithoutThreadingStart;
            //wD += WorkingWithThreadingStart;

            //var thread = new Thread(new ParameterizedThreadStart(wD));
            //thread.Start(new MyThreadParam(5, "Mohamed"));
            ////WorkingWithoutThreadingStart();
        }

        private void GetValues (IAsyncResult ar)
        {
            var isynResult = (AsyncResult) ar;
            Func<string, Int64> myDelgReturn = (Func<string, Int64>) isynResult.AsyncDelegate;
            long value = myDelgReturn.EndInvoke(ar);
            MessageBox.Show(value.ToString());



        }
        private void WorkingWithThreadingStart(object param)
        {
            var threadParam = (MyThreadParam)param;

            MessageBox.Show(threadParam.Name);
        }
        private void WorkingWithoutThreadingStart(object param)
        {
            MessageBox.Show(@"Without Thread");
        }

        private Int64 Counter()
        {
            var counter = 0;
            for (var i = 0; i < 900000; i++)
            {
                counter++;
            }

            return counter;
        }

        private Int64 CountWithString(string param)
        {
            var counter = 0;
            for (var i = 0; i < 8880000; i++)
            {
                counter++;
            }

            if (param == "Ali")
            {
                return counter = 10;
            }
            else if (param == "Mohamed")
            {
                return counter = 5;
            }

            return counter;
        }

    }
}
