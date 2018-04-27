using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }






        //Berger

        string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Berger Elias\Downloads\lvl1-0.inp");

        public string[][] Splitlines(string[] lines)
        {
            string[][] res = new string[lines.Length][];
            int i = 0;

            foreach (string line in lines)
            {
                res[i] = line.Split(' ');

                i++;
            }
            return res;
        }

        public int GetNumberOfImages(string[][] values)
        {
            return Convert.ToInt32(values[0][0]);
        }

















































        //Krug

        public static long GetTimestamps(string imagevalue)
        {
            if(imagevalue.Length > 0)
            {
                
                int timestamp;
                string[] arr_imgval = imagevalue.Split(' ');
                foreach (string val in arr_imgval) Console.WriteLine(val);
                // timestamp auslesen
                timestamp = Int32.Parse(arr_imgval[0]);
                return timestamp;
            }
            else throw new ArgumentOutOfRangeException("imagevalue is < 0");
        }








































        //Felix









































        //Dominik
    }
}
