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
            string[] lines = System.IO.File.ReadAllLines(@"..\..\..\..\lvl1-2.inp");
            string[][] splitLines = Splitlines(lines);
            int images = GetNumberOfImages(splitLines);
            int[] linecounts = GetLines(splitLines, images);
            int[] Fulltimestamps = GetFullTimestamp(splitLines, images, linecounts);
            Array.Sort(Fulltimestamps);
            System.IO.File.WriteAllLines(@"..\..\..\..\ergebnis1-2.txt", intToString(Fulltimestamps));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }






        //Berger

        

        public static string[][] Splitlines(string[] lines)
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

        public static int GetNumberOfImages(string[][] values)
        {
            return Convert.ToInt32(values[0][0]);
        }



       public static string[] intToString(int[] timestamps)
        {
            string[] Timestamps = new string[timestamps.Length];
            for(int i = 0; i < timestamps.Length; i++)
            {
                Timestamps[i] = Convert.ToString(timestamps[i]);
            }

            return Timestamps;
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

        /*
       public static string[] GetResolution(string [] lines)
        {
            int[] vals = GetLines(Splitlines(lines),GetNumberOfImages(Splitlines(lines)));
            List<string> lst = new List<string>();
            int counter = 0;
            for (int i = 1; i < lines.Length;i++)
            {
                if(counter < vals[i])
                {

                    counter++;
                }
            }
        }
        */



































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
                    numbers[j] = Convert.ToInt32(value[i][1]);
                } else
                {
                    numbers[j] = Convert.ToInt32(value[i + numbers[j-1]][2]+1);
                }
                j++;
                
            }
            return numbers;
        }

        public static int [] GetFullTimestamp (string [][] value, int images, int [] linenumbers)
        {
            int[] Timestamps = new int[images];
            bool leer = false;
            int currentLine = 1;

            for (int i = 0; i < images; i++)
            {
                for (int k = 0; k <= linenumbers[i]; k++)
                {
                    if (i != 0 && leer == false)
                    {
                        leer = false;
                    } else
                    {
                        leer = true;
                    }
                }
                if (leer != false)
                {
                    currentLine += linenumbers[i];
                    Timestamps[i] = Convert.ToInt32(value[currentLine-1][0]);
                }
            }
            return Timestamps;
        }
    }
}
