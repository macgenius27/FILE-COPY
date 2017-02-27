using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Net;
using System.Windows.Forms;
using System.Diagnostics;

namespace temp1
{
    public partial class Form1 : Form
    {
        bool a = false;
        long temp = 0;
        string dest = null;
        string name = null;
        string sourcepath = null;
        FileStream obj1;
        Thread t1;
        Thread t2;
        Thread t3;
        Thread t4;
        Thread t5;
        Thread t6;
        Thread t7;
        Thread t8;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            progressBar1.Hide();
            label1.Hide();
        }
        public void read1(long i)
        {
            long temp2 = 0;
            FileStream obj = File.OpenRead(sourcepath);
            byte[] byffer = new byte[i];
            obj.Read(byffer, 0, byffer.Length);
            obj1.Write(byffer, 0, byffer.Length);
            progressBar1.Increment( progressBar1.Value+(int)i);
            obj.Close();
            //if (progressBar1.Value == progressBar1.Maximum)
            //{
            //    progressBar1.Hide();
            //    label1.Show();
            //}
        }
        public void read2(long i)
        {
            long temp2 = 0;
            FileStream obj = File.OpenRead(sourcepath);
            byte[] byffer = new byte[i];
                obj.Seek(i, SeekOrigin.Begin);
                obj.Read(byffer, 0, byffer.Length);
                obj1.Seek(i, SeekOrigin.Begin);
                obj1.Write(byffer, 0, byffer.Length);
                progressBar1.Increment(progressBar1.Value + (int)i);
            obj.Close();
            //if (progressBar1.Value == progressBar1.Maximum)
            //{
            //    progressBar1.Hide();
            //    label1.Show();
            //}
        }
        public void read3(long i)
        {
            long temp2 = 0;
            FileStream obj = File.OpenRead(sourcepath);
            byte[] byffer = new byte[i];
            long op = i + i;
            obj.Seek(op, SeekOrigin.Begin);
            obj.Read(byffer, 0, byffer.Length);
            long i1 = i + i;
     
                obj1.Seek(i1, SeekOrigin.Begin);
                obj1.Write(byffer, 0, byffer.Length);
                progressBar1.Increment(progressBar1.Value + (int)i);
         
            obj.Close();
            //if (progressBar1.Value == progressBar1.Maximum)
            //{
            //    progressBar1.Hide();
            //    label1.Show();
            //}
        }
        public void read4(long i)
        {
            long temp2 = 0;
            FileStream obj = File.OpenRead(sourcepath);
            byte[] byffer = new byte[i];
            long op = i + i + i;
            obj.Seek(op, SeekOrigin.Begin);
            obj.Read(byffer,0,byffer.Length);
            long i1 = i + i + i;
            obj1.Seek(i1, SeekOrigin.Begin);
            obj1.Write(byffer, 0, byffer.Length);
            progressBar1.Increment(progressBar1.Value + (int)i);    
            obj.Close();
            //if (progressBar1.Value == progressBar1.Maximum)
            //{
            //    progressBar1.Hide();
            //    label1.Show();
            //}
        }
        public void read5(long i)
        {
            long temp2 = 0;
            FileStream obj = File.OpenRead(sourcepath);
            byte[] byffer = new byte[i];
            long op = i + i + i+i;
            obj.Seek(op, SeekOrigin.Begin);
            obj.Read(byffer, 0, byffer.Length);
            long i1 = i + i + i+i;
            obj1.Seek(i1, SeekOrigin.Begin);
            obj1.Write(byffer, 0, byffer.Length);
            progressBar1.Increment(progressBar1.Value + (int)i);
            obj.Close();
            //if (progressBar1.Value == progressBar1.Maximum)
            //{
            //    progressBar1.Hide();
            //    label1.Show();
            //}
        }
        public void read6(long i)
        {
            long temp2 = 0;
            FileStream obj = File.OpenRead(sourcepath);
            byte[] byffer = new byte[i];
            long op = i + i + i+i+i;
            obj.Seek(op, SeekOrigin.Begin);
            obj.Read(byffer, 0, byffer.Length);
            long i1 = i + i + i+i+i;
       
                obj1.Seek(i1, SeekOrigin.Begin);
                obj1.Write(byffer, 0, byffer.Length);
                progressBar1.Increment(progressBar1.Value + (int)i);
   

            obj.Close();
            //if (progressBar1.Value == progressBar1.Maximum)
            //{
            //    progressBar1.Hide();
            //    label1.Show();
            //}
        }
        public void read7(long i)
        {
            long temp2 = 0;
            FileStream obj = File.OpenRead(sourcepath);
            byte[] byffer = new byte[i];
            long op = i + i + i + i + i + i;
            obj.Seek(op, SeekOrigin.Begin);
            obj.Read(byffer, 0, byffer.Length);
            long i1 = i + i + i + i + i + i;
                obj1.Seek(i1, SeekOrigin.Begin);
                obj1.Write(byffer, 0, byffer.Length);
                progressBar1.Increment(progressBar1.Value + (int)i);
            obj.Close();
            //if (progressBar1.Value == progressBar1.Maximum)
            //{
            //    progressBar1.Hide();
            //    label1.Show();
            //}
        }
        public void read8(long i)
        {
            long temp2 = 0;
            FileStream obj = File.OpenRead(sourcepath);
            byte[] byffer = new byte[i];
            long op = i + i + i + i + i + i+i;
            obj.Seek(op, SeekOrigin.Begin);
            obj.Read(byffer, 0, byffer.Length);
            long i1 = i + i + i + i + i + i+i;
                obj1.Seek(i1, SeekOrigin.Begin);
                obj1.Write(byffer, 0, byffer.Length);
                progressBar1.Increment(progressBar1.Value + (int)i);

            obj.Close();
            //if (progressBar1.Value == progressBar1.Maximum)
            //{
            //    progressBar1.Hide();
            //    label1.Show();
            //}
        }

        public void findName()
        {
            int temp = sourcepath.LastIndexOf(@"\");
            name = sourcepath.Substring(temp + 1);
        }
        public void progress()
        {
            while (true)
            {
                if (t1.IsAlive == false && t2.IsAlive == false && t3.IsAlive == false && t4.IsAlive == false && t5.IsAlive == false && t6.IsAlive == false && t7.IsAlive == false && t8.IsAlive == false)
                {
                    progressBar1.Hide();
                    label1.Text = "Doneeeee!!!!!";
                    label1.Show();
                    break;
                }
            
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            obj1 = File.Open(dest, FileMode.OpenOrCreate);
            progressBar1.Show();
            label1.Hide();
            try
            {
                FileStream obj = File.OpenRead(sourcepath);
                progressBar1.Maximum = (int)obj.Length;
                long size_of_buffer = obj.Length / 8;
       t1=          new Thread(() => { read1(size_of_buffer); });
     t2 = new Thread(() => { read2(size_of_buffer); });
       t3 = new Thread(() => { read3(size_of_buffer); });
      t4 = new Thread(() => { read4(size_of_buffer); });
      t5 = new Thread(() => { read5(size_of_buffer); });
      t6 = new Thread(() => { read6(size_of_buffer); });
       t7 = new Thread(() => { read7(size_of_buffer); });
      t8 = new Thread(() => { read8(size_of_buffer); });
     
      t1.Start();
      t2.Start();
      t3.Start();
      t4.Start();
      t5.Start();
      t6.Start();
      t7.Start();
      t8.Start();
   
      
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            new Thread(progress).Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                sourcepath = openFileDialog1.FileName.ToString();
                textBox1.Text = sourcepath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            findName();
            DialogResult dr = folderBrowserDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                textBox2.Text = folderBrowserDialog1.SelectedPath+name;
                dest = folderBrowserDialog1.SelectedPath+name;
            }
        }
    }
}
