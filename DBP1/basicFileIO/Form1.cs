using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basicFileIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitVariables();

        }

        private void InitVariables() {
            textBoxDisplay.Text = "Hi, Hello, Good, \r\nNext line.";
        
        }

        private void buttonFileStreamWrite_Click(object sender, EventArgs e)
        {
            
            BinaryWriter bw = new BinaryWriter(new FileStream("a.dat", FileMode.Create));

            bw.Write("김개똥");
            bw.Write(0);
            bw.Write(24);
            bw.Write("컴퓨터");

            bw.Write("홍길순");
            bw.Write(1);
            bw.Write(24);
            bw.Write("모바일");

            /*
            * bw.Write(1234);
            bw.Write("Hello World");
            */

            bw.Close();

            /*long someValue = 0x123456789ABCDEF0;
            // long someValue = 123456789;
            Stream outStream = new FileStream("a.dat", FileMode.Create);
            byte[] wBytes = BitConverter.GetBytes(someValue);
            outStream.Write(wBytes, 0, wBytes.Length);
            outStream.Close();
            Console.WriteLine("READ DATA DONE."); */

            // function_bad();
        }

        //  private void function_bad() {
        //      Console.WriteLine("I'm a bad function");
        //  }

        private void buttonBinaryWrite_Click(object sender, EventArgs e)
        {
            BinaryReader br = new BinaryReader(new FileStream("a.dat", FileMode.Open));
            
            int num1 = br.ReadInt32();
            string str = br.ReadString();

            Console.WriteLine("Read Int =" + num1);
            Console.WriteLine("Read str =" + str);
            br.Close();

            /*byte[] rBytes = new byte[8];
            Stream inStream = new FileStream("a.dat", FileMode.Open);
            inStream.Read(rBytes, 0, rBytes.Length);
            long readValue = BitConverter.ToInt64(rBytes, 0);
            Console.WriteLine("READ DATA = " + readValue);
            inStream.Close(); */

            //  function_bad();
        }

        private void buttonBinaryRead_Click(object sender, EventArgs e)
        {

        }

        private void buttonStreamWriter_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(new FileStream("a.txt", FileMode.Create));
            sw.WriteLine(int.MaxValue);
            sw.WriteLine("Good Morning");
            sw.WriteLine(uint.MaxValue);
            sw.WriteLine("안녕하세요");
            sw.WriteLine(double.MaxValue);
            sw.Close();
        }

        private void buttonStreamReader_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(new FileStream("a.txt", FileMode.Open));
            textBoxDisplay.Text = "";
            while (sr.EndOfStream == false)
            {
                textBoxDisplay.Text += sr.ReadLine();
                textBoxDisplay.Text += "\r\n";
            }
            sr.Close();
        }
    }
}
