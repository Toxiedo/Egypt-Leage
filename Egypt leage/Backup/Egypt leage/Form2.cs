using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Globalization;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Egypt_leage
{
    public partial class Form2 : Form
    {
         public static List<team> teames = new List<team>();
         public static team tn;
         string path;
         bool need_image = false;
        public Form2()
        {
            InitializeComponent();
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = imageList1.Images[8];
            try
            {
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                        c.Text = "";
                    if (c is ComboBox)
                        c.Text = "";

                }
                textBox1.Focus();
                pictureBox1.Image = null;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tn = new team();
                bool f = false;
                double num2 = Convert.ToDouble(textBox3.Text);
                if (num2 <= 0)
                    MessageBox.Show("يرجى مراجع الرقم السرى مرة اخرى");
                for (int i = 0; i < Form2.teames.Count(); i++)
                {
                    if (Form2.teames[i].id == num2)
                    {
                        f = true;
                    }
                }
                string nmteam = textBox1.Text;
                int id = Convert.ToInt32(textBox3.Text);
                string address = textBox2.Text;
                string nmpers = textBox4.Text;
                if (f == false)
                {
                    
                    tn.getteaminformation(id, address, nmpers);
                    tn.getteamsname(nmteam);
                    if (need_image == true)
                    {
                        tn.getimagetoteam(pictureBox1.Image);
                        bool fond = true;
                        tn.put_image_or_no(fond);
                    }
                    else if(need_image == false)
                    {
                        bool fund = false;
                        tn.put_image_or_no(fund);
                    }

                    

                    teames.Add(tn);


                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Save(The_first.Path_Folders + "\\Image program\\" + textBox1.Text + ".jpg", ImageFormat.Jpeg);

                    }

                   
                    MessageBox.Show("Saved....");
                }
                else
                {
                    MessageBox.Show("this id found befor....");
                }

               
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            this.BackgroundImage = imageList1.Images[8];
            //tn = new team();

            //string nmteam = "ahly";
            //int id = 1;
            //string address = "cairo";
            //string nmpers = "ahmed";
            //tn.getteaminformation(id, address, nmpers);
            //tn.getteamsname(nmteam);
            //tn.addnatega(6, 1, "zam");
            //teames.Add(tn);

            //tn = new team();
            //string nmteam1 = "zam";
            //int id1 = 2;
            //string address1 = "cairo";
            //string nmpers1 = "ahmed";
            //tn.getteaminformation(id1, address1, nmpers1);
            //tn.getteamsname(nmteam1);
            //tn.addnatega(1, 6);
            //teames.Add(tn);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "ahly")
            {
                this.BackgroundImage = imageList1.Images[1];
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "ahly")
            {
                this.BackgroundImage = imageList1.Images[7];
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "ahly")
            {
                this.BackgroundImage = imageList1.Images[0];
            }
        }
       
        private void button5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile( path );
                need_image = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.write_in_file();
            System.Environment.Exit(0);
        }

       
      

      
   
    
    
    
    
    
    
    
    }
}
