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






        //Berger

        string lines = System.IO.File.ReadAllText(@"C:\Users\Berger Elias\Downloads\lvl1-0.inp");

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




















































        //Krug










































        //Felix









































        //Dominik
    }
}
