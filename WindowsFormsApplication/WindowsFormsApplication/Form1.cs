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
            string[] lines = System.IO.File.ReadAllLines(@"..\..\..\..\lvl1-1.inp");
            string[][] splitLines = Splitlines(lines);
            int images = GetNumberOfImages(splitLines);
            int[] linecounts = GetLines(splitLines, images);
            int[] Fulltimestamps = GetFullTimestamp(splitLines, images, linecounts);
            Array.Sort(Fulltimestamps);
            for(int i = 0; i<images; i++)
            {
                System.IO.File.WriteAllLines(@"../../../../ergebnis1-1.txt", Convert.ToString(Fulltimestamps))
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }






        //Berger

        

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
        public static int[] GetLines(string [][] value, int images)
        {
            int[] numbers = new int[images];
            int j=0;
            
            for (int i = 1; i < images; i++)
            {
                if (j == 0)
                {
                    numbers[j] = Convert.ToInt32(value[i][2]+1);
                } else
                {
                    numbers[j] = Convert.ToInt32(value[i + numbers[j-1]][2]+1);
                }
                
            }
            return numbers;
        }

        public static int [] GetFullTimestamp (string [][] value, int images, int [] linenumbers)
        {
            int number=0;
            int[] Timestamps = new int[images];
            bool leer = false;

            for (int i = 0; number < images; i++)
            {
                for (int k = 0; k <= linenumbers[i]; k++)
                {
                    if (number != 0 && leer != false)
                    {
                        leer = false;
                    } else
                    {
                        leer = true;
                    }
                }
                if (leer != false)
                {
                    Timestamps[i] = Convert.ToInt32(value[1 + linenumbers[i]][0]);
                }
                number++;
            }
            return Timestamps;
        }
    }
}
