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
    public partial class Form3 : Form
    {
        bool need_image = false;
        string path;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int num = 10000;
            int num1 = 20000;
            int num2 = 30000;
            int num3 = 40000;
            float age = 2011 - 1975;
            int year = 1975;
            int day = 26;
            int mounth = 8;
            string tname = "ahly";
            string np1 = "5456465";

            for (int i = 0; i < Form2.teames.Count(); i++)
            {
                if (Form2.teames[i].nameteams == "ahly")
                {
                    Form2.teames[i].add_players_information("ahmed moataz", "cf", num2, age, day, mounth, year, num, num1, np1, tname, num3,pictureBox1.Image);
                    Form2.teames[i].playeres[0].getgool(10);
                }
            }
            int num11 = 1100;
            int num111 = 2200;
            int num21= 3300;
            int num31 = 4400;
            float age1 = 2011 - 1976;
            int year1 = 1976;
            int day1 = 261;
            int mounth1 = 81;
            string tname1 = "zam";
            string np11 = "54564655";

            for (int i = 0; i < Form2.teames.Count(); i++)
            {
                if (Form2.teames[i].nameteams == "zam")
                {
                    Form2.teames[i].add_players_information("sameh", "gh", num21, age1, day1, mounth1, year1, num11, num111, np11, tname1, num31,pictureBox1.Image);
                    Form2.teames[i].playeres[0].getgool(2);
                }
            }
            for (int i = 1; i <= 31; i++)
            {
                comboBox2.Items.Add(i);
            }
            for (int i = 1; i <= 12; i++)
            {
                comboBox3.Items.Add(i);
            }
            for (int i = 1975; i <= 1992; i++)
            {
                comboBox4.Items.Add(i);
            }
            for (int i = 0; i < Form2.teames.Count(); i++)
            {
                comboBox1.Items.Add(Form2.teames[i].nameteams);
            }
        }

      

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = imageList1.Images[1];
            foreach( Control c in this.Controls )
            {
                if (c is Label)
                    c.BackColor = Color.Transparent;
                if (c is TextBox)
                    c.Text = "";
                if (c is ComboBox)
                    c.Text = "";
               
                
            }
            pictureBox1.Image = null;
            comboBox1.Focus();
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.write_in_file();
            System.Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                int num = Convert.ToInt32(textBox6.Text);
                int num1 = Convert.ToInt32(textBox2.Text);
                int num2 = Convert.ToInt32(textBox3.Text);
                int num3 = Convert.ToInt32(textBox5.Text);
                if (num <= 0)
                    MessageBox.Show(" يرجى مراجع المرتب مرة اخرى");
                if (num1 <= 0)
                    MessageBox.Show("يرجى مراجع رقم التشيرت مرة اخرى ");
                if (num2 <= 0)
                    MessageBox.Show("يرجى مراجع الرقم السرى مرة اخرى");
                if (num3 <= 0)
                    MessageBox.Show("يرجى مراجع عدد الاهداف مرة اخرى");

                float age = 2011 - float.Parse(comboBox4.Text);
                int year = int.Parse(comboBox4.Text);
                int day = int.Parse(comboBox2.Text);
                int mounth = int.Parse(comboBox3.Text);
                string tname = comboBox1.Text;
                string np1 = textBox7.Text;
                

                for (int i = 0; i < Form2.teames.Count(); i++)
                {
                    if (Form2.teames[i].nameteams == comboBox1.Text)
                    {
                        Form2.teames[i].add_players_information(textBox1.Text, textBox4.Text,num2,age,day,mounth,year,num,num1,np1,tname,num3,pictureBox1.Image);
                      
                    }
                }

                MessageBox.Show("Saved....");
               
                
                
            }
            catch
            {
                MessageBox.Show("Error.....");
            }
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ahly")
                this.BackgroundImage = imageList1.Images[0];

            foreach (Control c in this.Controls)
            {
                if (c is Label)
                {
                    c.BackColor = Color.Black;
                }


            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(path);
                need_image = true;
            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.write_in_file();
            System.Environment.Exit(0);
        }

      

        
      

        

        

       








    }
}
