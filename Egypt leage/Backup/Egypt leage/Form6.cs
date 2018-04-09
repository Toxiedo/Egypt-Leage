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
    public partial class Form6 : Form
    {
        public int numgool1;
        public int gool2;
        public int plygool1 = 0;
        public int ply2gool2 = 0;
        public int counter = 0;
        public Form6()
        {
            InitializeComponent();
        }
        Image img;

        private void button3_Click(object sender, EventArgs e)
        {
            

            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.write_in_file();
            
            System.Environment.Exit(0);
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            img = this.BackgroundImage;
            plygool1 = 0;
            ply2gool2 = 0;
            counter = 0;
            try
            {
                for (int i = 0; i < Form2.teames.Count(); i++)
                {
                    comboBox1.Items.Add(Form2.teames[i].nameteams);
                    comboBox2.Items.Add(Form2.teames[i].nameteams);
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            
        }
        //object[] firstteam = new object[20];
        //public static string[] secteam;
        //public static int[] fristgool;
        //public static int[] secgool;
        //public static int counts = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                numgool1 = int.Parse(textBox1.Text);
                gool2 = int.Parse(textBox2.Text);
               // plygool1 = int.Parse(textBox3.Text);
               // ply2gool2 = int.Parse(textBox4.Text);
                
                for (int i = 0; i < Form2.teames.Count(); i++)
                {
                    if (Form2.teames[i].nameteams == comboBox1.Text)
                    {
                        Form2.teames[i].addnatega(numgool1, gool2, comboBox2.Text);
                        for (int k = 0; k < listBox1.Items.Count; k++)
                        {
                            for (int j = 0; j < Form2.teames[i].playeres.Count(); j++)
                            {
                                if (Form2.teames[i].playeres[j].nameplayer == listBox1.Items[i].ToString())
                                {
                                    Form2.teames[i].playeres[j].getgool(int.Parse(listBox3.Items[i].ToString()) );
                                }// end if
                            }// end for
                        }
                    }//end if
                    else if (Form2.teames[i].nameteams == comboBox2.Text)
                    {
                        Form2.teames[i].addnatega(gool2, numgool1);
                        for (int k = 0; k < listBox2.Items.Count; k++)
                        {
                            for (int j = 0; j < Form2.teames[i].playeres.Count(); j++)
                            {
                                if (Form2.teames[i].playeres[j].nameplayer == listBox1.Items[i].ToString())
                                {
                                    Form2.teames[i].playeres[j].getgool(int.Parse(listBox4.Items[i].ToString()) );
                                }// end if
                            }// end for
                        }
                    }
                    
                    
                }//end for
                //end if

               

                MessageBox.Show("Saved......");
                ply2gool2 = 0;
                plygool1 = 0;
                numgool1 = 0;
                gool2 = 0;
                button1.Text = "تم الحفظ";
                button1.Enabled = false;
            }
            catch
            {
               MessageBox.Show("Error....");
            }
                
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < comboBox3.Items.Count; i++)
                comboBox3.Items.Remove(i);

            comboBox3.Refresh();
                for (int i = 0; i < Form2.teames.Count(); i++)
                {
                    if (Form2.teames[i].nameteams == comboBox1.Text)
                    {

                        for (int j = 0; j < Form2.teames[i].playeres.Count(); j++)
                        {
                            comboBox3.Items.Add(Form2.teames[i].playeres[j].nameplayer);
                        }
                    }
                }//end for


        }//end function

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            

          

            if (comboBox2.Text == "esm" && comboBox1.Text == "ahly")
            {
               this.BackgroundImage = imageList1.Images[1];
               foreach (Control c in this.Controls)
               {

                   if (c is Label)
                   {
                       c.BackColor = Color.Black;
                   }
               }
            }
            else if (comboBox2.Text == "ahly" && comboBox1.Text == "esm")
            {
               this.BackgroundImage = imageList1.Images[1];
               foreach (Control c in this.Controls)
               {

                   if (c is Label)
                   {
                       c.BackColor = Color.Black;
                   }
               }
            }
            else if (comboBox2.Text == "zam" && comboBox1.Text == "ahly")
            {
                this.BackgroundImage = imageList1.Images[3];
                foreach (Control c in this.Controls)
                {

                    if (c is Label)
                    {
                        c.BackColor = Color.Black;
                    }
                }
            }
            else if(comboBox2.Text == "ahly" && comboBox1.Text == "zam")
            {
                this.BackgroundImage = imageList1.Images[3];
                foreach (Control c in this.Controls)
                {

                    if (c is Label)
                    {
                        c.BackColor = Color.Black;
                    }
                }
            }

            if (comboBox2.Text != "ahly" && comboBox1.Text != "ahly")
            {
                if (comboBox1.Text == "zam" || comboBox2.Text == "zam")
                {
                    this.BackgroundImage = imageList1.Images[2];
                    foreach (Control c in this.Controls)
                    {

                        if (c is Label)
                        {
                            c.BackColor = Color.Black;
                        }
                    }
                }
            }


            for (int i = 0; i < comboBox4.Items.Count; i++)
                comboBox4.Items.Remove(i);

            comboBox4.Refresh();
            for (int i = 0; i < Form2.teames.Count(); i++)
            {
                if (Form2.teames[i].nameteams == comboBox2.Text)
                {

                    for (int j = 0; j < Form2.teames[i].playeres.Count(); j++)
                    {
                        comboBox4.Items.Add(Form2.teames[i].playeres[j].nameplayer);
                    }
                }
            }//end for

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == comboBox2.Text)
                {
                    MessageBox.Show("The team can't play with itself");

                }// end first if
                else
                {
                    bool found = false;
                    for (int i = 0; i < Form2.teames.Count(); i++)
                    {
                        if (Form2.teames[i].nameteams == comboBox1.Text)
                        {
                            for (int j = 0; j < Form2.teames[i].match.Count(); j++)
                            {
                                if (Form2.teames[i].match[j] == comboBox2.Text)
                                {
                                    found = true;
                                    MessageBox.Show("this match was played");
                                    break;
                                }//end if
                            }//end for
                            break;
                        }//end if
                    }//end for


                    if (found == false)
                    {
                        label8.Visible = true;
                        label7.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        textBox3.Visible = true;
                        textBox4.Visible = true;
                        comboBox4.Visible = true;
                        comboBox3.Visible = true;
                        button6.Visible = true;
                        button7.Visible = true;
                        numgool1 = int.Parse(textBox1.Text);
                        gool2 = int.Parse(textBox2.Text);
                    }// end if
                }//end else
            }//end try
            catch
            {
                MessageBox.Show("Error.... u not't Enter Natega");
            }
           
                
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(textBox3.Text);
                int num2 = int.Parse(textBox1.Text);
                bool found = false;
                bool found2 = false;
                if (num1 > num2)
                {
                    found = true;
                    MessageBox.Show("Error...");
                }
                if (found == false)
                {
                    plygool1 += num1;
                    if (plygool1 > num2)
                    {
                        found2 = true;
                        MessageBox.Show("Error....");
                    }
                    if (found2 == false)
                    {
                        listBox1.Visible = true;
                        listBox3.Visible = true;
                        listBox1.Items.Add(comboBox3.Text);
                        listBox3.Items.Add(textBox3.Text);
                        comboBox3.Text = "";
                        textBox3.Text = "";
                    }
                }// end first if
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(textBox4.Text);
                int num2 = int.Parse(textBox2.Text);
                bool found = false;
                bool found2 = false;
                if (num1 > num2)
                {
                    found = true;
                    MessageBox.Show("Error...");
                }
                if (found == false)
                {
                    ply2gool2 += num1;
                    if (ply2gool2 > num2)
                    {
                        found2 = true;
                        MessageBox.Show("Error....");
                    }
                    if (found2 == false)
                    {
                        listBox2.Visible = true;
                        listBox4.Visible = true;
                        listBox1.Visible = true;
                        listBox3.Visible = true;
                        listBox2.Items.Add(comboBox4.Text);
                        listBox4.Items.Add(textBox4.Text);
                        comboBox4.Text = "";
                        textBox4.Text = "";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.BackgroundImage = img;
                ply2gool2 = 0;
                plygool1 = 0;
                numgool1 = 0;
                gool2 = 0;
                //for (int j = 0; j < comboBox3.Items.Count; j++)
                //{
                //    comboBox3.Items.RemoveAt(j);
                //}
                //for (int i = 0; i < comboBox4.Items.Count; i++)
                //{
                //      comboBox4.Items.RemoveAt(i);
                //}
                comboBox3.Items.Clear();
                comboBox4.Items.Clear();
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                listBox4.Items.Clear();

                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                        c.Visible = false;
                    }

                    if (c is ComboBox)
                    {
                        c.Text = "";
                        c.Visible = false;

                    }

                    if (c is Label)
                    {

                        c.Visible = false;
                        c.BackColor = Color.Transparent;
                    }

                    if (c is ListBox)
                    {
                        c.Text = "";
                        c.Visible = false;
                        c.Refresh();
                    }


                }
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                button6.Visible = false;
                button7.Visible = false;
                MessageBox.Show(Form2.teames[0].havegool.ToString() + "   " + Form2.teames[1].havegool.ToString());
                button1.Enabled = true;
                button1.Text = "حفظ";
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
               
                listBox5.Visible = true;
                for (int i = 0; i < Form2.teames.Count(); i++)
                {
                        if (Form2.teames[i].nameteams.Contains(comboBox1.Text) )
                        {
                            if (listBox5.Items.Contains(Form2.teames[i].nameteams))
                            {
                            }
                            else
                            {
                               listBox5.Items.Add(Form2.teames[i].nameteams);
                            }
                        }
                        else
                        {
                            if (listBox5.Items.Contains(Form2.teames[i].nameteams))
                            {
                                listBox5.Items.Remove(Form2.teames[i].nameteams);
                            }
                        }//end else

                }//end first for
                if (comboBox1.Text == "")
                {
                    listBox5.Items.Clear();
                    listBox5.Visible = false;
                }
            }//end try
            catch
            {
                MessageBox.Show("Error in index");
            }
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {

                listBox6.Visible = true;
                for (int i = 0; i < Form2.teames.Count(); i++)
                {
                    if (Form2.teames[i].nameteams.Contains(comboBox2.Text))
                    {
                        if (listBox6.Items.Contains(Form2.teames[i].nameteams))
                        {
                        }
                        else
                        {
                            listBox6.Items.Add(Form2.teames[i].nameteams);
                        }
                    }
                    else
                    {
                        if (listBox6.Items.Contains(Form2.teames[i].nameteams))
                        {
                            listBox6.Items.Remove(Form2.teames[i].nameteams);
                        }
                    }//end else

                }//end first for
                if (comboBox2.Text == "")
                {
                    listBox6.Items.Clear();
                    listBox6.Visible = false;
                }
            }//end try
            catch
            {
                MessageBox.Show("Error in index");
            }



        }

        private void listBox5_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int x = listBox5.SelectedIndex;
                    comboBox1.Text = listBox5.Items[x].ToString();
                    listBox5.Items.Clear();
                    listBox5.Visible = false;
                    comboBox1.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error in listbox5_keydown");
            }
        }

        private void listBox6_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int x = listBox6.SelectedIndex;
                    comboBox2.Text = listBox6.Items[x].ToString();
                    listBox6.Items.Clear();
                    listBox6.Visible = false;
                    comboBox2.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error in listbox6_keydown");
            }
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.write_in_file();
            System.Environment.Exit(0);
        }

        

        
        
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}
