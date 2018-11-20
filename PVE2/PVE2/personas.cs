using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVE2
{
    class personas
    {
        Stopwatch sw;
        public string name;
        public Boolean active;

        public personas(string str)
        {
            name = str;
            active = false;
            sw = Stopwatch.StartNew();
        }

        public string get(){
            return name;
        }

        public void stop()
        {
            active = true;
            MessageBox.Show("Tiempo checado: "+sw.Elapsed.Seconds.ToString()+" segundos");
        }
    }
}
