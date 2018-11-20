using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVE2
{
    public partial class Form1 : Form
    {
        List<personas> myList = new List<personas>();
        /*
            static Stopwatch contador2;
            sw = Stopwatch.StartNew();
            Console.WriteLine("Tiempo:" + sw.ElapsedMilliseconds);
        */

        public Form1()
        {
            InitializeComponent();
        }

        static void ThreadJob()
        {
        }

        private void bottom_text_Click(object sender, EventArgs e)
        {
            int myIndex = myList.FindIndex(obj => obj.name.Equals(name.Text));
            if (myIndex == -1)
            {
                myList.Add(new personas(name.Text));
            }
            else
            {
                myList[myIndex].stop();
                myList.RemoveAt(myIndex);
            }
        }
    }
}
