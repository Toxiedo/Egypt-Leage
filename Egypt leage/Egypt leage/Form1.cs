using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Egypt_leage
{
    public partial class Form1 : Form
    {
       
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            write_in_file();
            System.Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
        }
        

      
        private void button6_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.Show();
            this.Hide();
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {

            The_first.sec++;
            if (The_first.sec == 60)
            {
                The_first.min++;
                if (The_first.min == 60)
                {
                    The_first.hour++;
                    The_first.min = 0;
                }
                The_first.sec = 0;
                this.Text = The_first.hour.ToString() + ":" + The_first.min.ToString() + ":" + The_first.sec.ToString();
            }
            else
            {
                this.Text = The_first.hour.ToString() + ":" + The_first.min.ToString() + ":" + The_first.sec.ToString();
                //  clock = this.Text;
            }
            

        
        }

        private void button8_Click(object sender, EventArgs e)
        {
            randomform frmrand = new randomform();
            frmrand.Show();
            this.Hide();
        }
        public  void write_in_file()
        {


            FileStream fs = new FileStream(The_first.Path_Folders + "\\teames.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            for (int i = 0; i < Form2.teames.Count(); i++)
            {
                sw.WriteLine(Form2.teames[i].nameteams);
                sw.WriteLine(Form2.teames[i].id.ToString());
                sw.WriteLine(Form2.teames[i].teamaddress);
                sw.WriteLine(Form2.teames[i].nmpresant);
                sw.WriteLine("------------------------");

            }
            sw.Close();
            fs.Close();

            FileStream ftr = new FileStream(The_first.Path_Folders + "\\mathes_ntega.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sr = new StreamWriter(ftr);


            if (Form2.teames.Count() != 0)
            {
                for (int i = 0; i < Form2.teames.Count(); i++)
                {

                    for (int j = 0; j < Form2.teames[i].match.Count(); j++)
                    {
                        sr.WriteLine(Form2.teames[i].nameteams);
                        sr.WriteLine(Form2.teames[i].match[j]);
                        sr.WriteLine(Form2.teames[i].yourgool[j]);
                        sr.WriteLine(Form2.teames[i].agenstgool[j]);
                        sr.WriteLine("---------------------");
                    }

                }
            }
            sr.Close();
            ftr.Close();

            FileStream found_no = new FileStream(The_first.Path_Folders + "\\found_image_or_no.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sbool = new StreamWriter(found_no);
            for (int i = 0; i < Form2.teames.Count(); i++)
            {
                sbool.WriteLine(Form2.teames[i].found.ToString());
            }
            sbool.Close();
            found_no.Close();
        }

        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            write_in_file();
            System.Environment.Exit(0);
        }
    
    
    
    
    
    
    
    }
}
