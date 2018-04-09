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
   
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        public List<team> sortteam;
        public List<player> sortplayer;
       // public List<team> tempteam;
      //  public List<player> tempplayer;
        private void Form7_Load(object sender, EventArgs e)
        {
            try
            {
                sortteam = new List<team>();
                sortplayer = new List<player>();
                for (int i = 0; i < Form2.teames.Count(); i++)
                {
                    sortteam.Add(Form2.teames[i]);
                    for (int j = 0; j < Form2.teames[i].playeres.Count(); j++)
                    {
                        sortplayer.Add(Form2.teames[i].playeres[j]);
                    }
                }
                for (int i = 0; i < Form2.teames.Count(); i++)
                {

                    for (int j = 0; j < Form2.teames[i].playeres.Count(); j++)
                    {
                        comboBox3.Items.Add(sortplayer[i].nameplayer);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error. . .");
            }
            


        }
        public void sort_team()
        {
            try
            {

                if (comboBox1.Text == "عدد النقط")
                {
                    for (int i = 0; i < (sortteam.Count() - 1); i++)
                    {
                        for (int j = 0; j < (sortteam.Count() - 1); j++)
                        {
                            if (sortteam[i].point < sortteam[i + 1].point)
                            {
                                // tempteam = new List<team>();
                                team tempteam = new team();
                                tempteam = sortteam[i];
                                sortteam[i] = sortteam[i + 1];
                                sortteam[i + 1] = tempteam;
                            }
                        }
                    }
                    // MessageBox.Show("ok.........");
                }

                else if (comboBox1.Text == "افضل هجوم")
                {
                    for (int i = 0; i < (sortteam.Count() - 1); i++)
                    {
                        for (int j = 0; j < (sortteam.Count() - 1); j++)
                        {
                            if (sortteam[i].havegool < sortteam[i + 1].havegool)
                            {
                                // tempteam = new List<team>();
                                team tempteam = new team();
                                tempteam = sortteam[i];
                                sortteam[i] = sortteam[i + 1];
                                sortteam[i + 1] = tempteam;
                            }
                        }
                    }
                }

                else if (comboBox1.Text == "افضل دفاع")
                {
                    for (int i = 0; i < (sortteam.Count() - 1); i++)
                    {
                        for (int j = 0; j < (sortteam.Count() - 1); j++)
                        {
                            if (sortteam[i].getgool > sortteam[i + 1].getgool)
                            {
                                // tempteam = new List<team>();
                                team tempteam = new team();
                                tempteam = sortteam[i];
                                sortteam[i] = sortteam[i + 1];
                                sortteam[i + 1] = tempteam;
                            }
                        }
                    }
                }

                else if (comboBox1.Text == "متوسط اعمار الفريق")
                {
                    for (int i = 0; i < (sortteam.Count() - 1); i++)
                    {
                        for (int j = 0; j < (sortteam.Count() - 1); j++)
                        {
                            if (sortteam[i].get_age() < sortteam[i + 1].get_age())
                            {
                                // tempteam = new List<team>();
                                team tempteam = new team();
                                tempteam = sortteam[i];
                                sortteam[i] = sortteam[i + 1];
                                sortteam[i + 1] = tempteam;
                            }
                        }
                    }
                }

                else if (comboBox1.Text == "متوسط اسعار الفريق")
                {
                    for (int i = 0; i < (sortteam.Count() - 1); i++)
                    {
                        for (int j = 0; j < (sortteam.Count() - 1); j++)
                        {
                            if (sortteam[i].get_salary() < sortteam[i + 1].get_salary())
                            {
                                // tempteam = new List<team>();
                                team tempteam = new team();
                                tempteam = sortteam[i];
                                sortteam[i] = sortteam[i + 1];
                                sortteam[i + 1] = tempteam;
                            }
                        }
                    }
                }
            }//end try
            catch
            {
                MessageBox.Show("Error in Method sort_team");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.write_in_file();

            System.Environment.Exit(0);
        }

       

        private void label4_Click(object sender, EventArgs e)
        {
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
                }

                if (c is ListBox)
                {
                    c.Text = "";
                    c.Visible = false;
                    c.Refresh();
                }


            }
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label4.Visible = true;
            label1.Visible = true;
            label12.Visible = true;
            comboBox1.Visible = true;
            textBox2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //comboBox3.Items.Clear();
            //comboBox4.Items.Clear();
            //listBox1.Items.Clear();
            //listBox2.Items.Clear();
            //listBox3.Items.Clear();
            //listBox4.Items.Clear();
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
                }

                if (c is ListBox)
                {
                    c.Text = "";
                    c.Visible = false;
                    c.Refresh();
                }


            }
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label4.Visible = true;
        }

        private void comboBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                comboBox2.Items.Clear();
                sort_team();
                for (int i = 0; i < Form2.teames.Count(); i++)
                {
                    comboBox2.Items.Add(sortteam[i].nameteams);
                }
                if (comboBox2.Text != "")
                {
                    for (int i = 0; i < sortteam.Count; i++)
                    {
                        if (sortteam[i].nameteams == comboBox2.Text)
                        {
                            label17.Text = (i + 1).ToString();
                            label20.Text = sortteam[i].point.ToString();
                            label21.Text = sortteam[i].havegool.ToString();
                            label22.Text = sortteam[i].getgool.ToString();
                            label23.Text = sortteam[i].deffgool.ToString();
                            label24.Text = (sortteam[0].point - sortteam[i].point).ToString();
                        }
                    }
                }
            }// end try
            catch
            {
                MessageBox.Show("Error.....");
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox3.Items.Clear();
                sort_player();
                for (int i = 0; i < sortplayer.Count; i++)
                {
                    comboBox3.Items.Add(sortplayer[i].nameplayer);
                }
                if (comboBox3.Text != "")
                {
                    for (int i = 0; i < sortplayer.Count; i++)
                    {
                        if (sortplayer[i].nameplayer == comboBox3.Text)
                        {
                            label27.Text = (i + 1).ToString();
                            label28.Text = sortplayer[i].goal.ToString();
                            label29.Text = comboBox6.Text;
                            if (comboBox6.Text == "عدد الاهداف")
                            {
                                label30.Text = sortplayer[i].goal.ToString();
                            }
                            else if (comboBox6.Text == "العمر")
                            {
                                label30.Text = sortplayer[i].age.ToString();
                            }
                            else if (comboBox6.Text == "المرتب")
                            {
                                label30.Text = sortplayer[i].salary.ToString();
                            }
                            break;
                        }

                    }
                }//end if
            }
            catch
            {
                MessageBox.Show("Error......");
            }

           
        }






  



        public void sort_player()
        {
            try
            {

                if (comboBox5.Text == "العمر" || comboBox6.Text == "العمر")
                {
                    for (int i = 0; i < (sortplayer.Count() - 1); i++)
                    {
                        for (int j = 0; j < (sortplayer.Count() - 1); j++)
                        {
                            if (sortplayer[i].age < sortplayer[i + 1].age)
                            {
                                // tempteam = new List<team>();
                                player tempplayer = new player();
                                tempplayer = sortplayer[i];
                                sortplayer[i] = sortplayer[i + 1];
                                sortplayer[i + 1] = tempplayer;
                            }
                        }
                    }
                    //MessageBox.Show("ok.........");
                }

                else if (comboBox5.Text == "المرتب" || comboBox6.Text == "المرتب")
                {
                    for (int i = 0; i < (sortplayer.Count() - 1); i++)
                    {
                        for (int j = 0; j < (sortplayer.Count() - 1); j++)
                        {
                            if (sortplayer[i].salary < sortplayer[i + 1].salary)
                            {
                                // tempteam = new List<team>();
                                player tempplayer = new player();
                                tempplayer = sortplayer[i];
                                sortplayer[i] = sortplayer[i + 1];
                                sortplayer[i + 1] = tempplayer;
                            }
                        }
                    }
                    // MessageBox.Show("ok.........");
                }
                else if (comboBox5.Text == "عدد الاهداف" || comboBox6.Text == "عدد الاهداف")
                {
                    for (int i = 0; i < (sortplayer.Count() - 1); i++)
                    {
                        for (int j = 0; j < (sortplayer.Count() - 1); j++)
                        {
                            if (sortplayer[i].goal < sortplayer[i + 1].goal)
                            {
                                // tempteam = new List<team>();
                                player tempplayer = new player();
                                tempplayer = sortplayer[i];
                                sortplayer[i] = sortplayer[i + 1];
                                sortplayer[i + 1] = tempplayer;
                            }
                        }
                    }
                    // MessageBox.Show("ok.........");
                }
            }// end try
            catch
            {
                MessageBox.Show("Error in Method Sort_player");
            }
           
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < sortplayer.Count; i++)
                {
                    if (sortplayer[i].nameplayer == comboBox3.Text)
                    {
                        label27.Text = (i + 1).ToString();
                        label28.Text = sortplayer[i].goal.ToString();
                        break;
                    }

                }
                label25.Visible = true;
                label26.Visible = true;
                label27.Visible = true;
                label28.Visible = true;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
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
                }

                if (c is ListBox)
                {
                    c.Text = "";
                    c.Visible = false;
                    c.Refresh();
                }


            }
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            label8.Visible = true;
            comboBox6.Visible = true;
            comboBox3.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
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
                }

                if (c is ListBox)
                {
                    c.Text = "";
                    c.Visible = false;
                    c.Refresh();
                }


            }
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label4.Visible = true;
            label2.Visible = true;
            label10.Visible = true;
            comboBox4.Visible = true;
            comboBox2.Visible = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label20.Visible = true;
            label21.Visible = true;
            label22.Visible = true;
            label23.Visible = true;
            label24.Visible = true;
            label17.Visible = true;

            label15.Visible = true;
            label16.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            try
            {
                for (int i = 0; i < sortteam.Count; i++)
                {
                    if (sortteam[i].nameteams == comboBox2.Text)
                    {
                        label17.Text = (i + 1).ToString();
                        label20.Text = sortteam[i].point.ToString();
                        label21.Text = sortteam[i].havegool.ToString();
                        label22.Text = sortteam[i].getgool.ToString();
                        label23.Text = sortteam[i].deffgool.ToString();
                        label24.Text = (sortteam[0].point - sortteam[i].point).ToString();
                    }
                }
            }// end try
            catch
            {
                MessageBox.Show("Error");
            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
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
                }

                if (c is ListBox)
                {
                    c.Text = "";
                    c.Visible = false;
                    c.Refresh();
                }


            }
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label4.Visible = true;
           
            comboBox5.Visible = true;
            textBox1.Visible = true;
            label9.Visible = true;
            label11.Visible = true;
        }

       

        

       

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                bool found = false;
                 found =  textBox2.Visible;
                 listBox1.Items.Clear();
                 listBox2.Items.Clear();
                if (textBox2.Visible == true && textBox2.Text != "")
                {
                    if (int.Parse(textBox2.Text) <= sortteam.Count())
                    {

                        listBox1.Visible = true;
                        sort_team();
                        int counter = int.Parse(textBox2.Text);
                        for (int i = 0; i < counter; i++)
                        {
                            listBox1.Items.Add(sortteam[i].nameteams);
                        }

                    }//end if
                    else
                    {
                        MessageBox.Show(" This number > number of Team ");
                    }
                }//end if
                else if(found != false)
                {
                    MessageBox.Show("The Textbox2 is Empty");
                }

                found = false;
                found = textBox1.Visible;
                if (textBox1.Visible == true && textBox1.Text != "")
                {
                    if (int.Parse(textBox1.Text) <= sortplayer.Count())
                    {

                        listBox2.Visible = true;
                        sort_player();
                        int counter = int.Parse(textBox1.Text);
                        for (int i = 0; i < counter; i++)
                        {
                            listBox2.Items.Add(sortplayer[i].nameplayer);
                        }

                    }//end if
                    else 
                    {
                        MessageBox.Show(" This number > number of Team ");
                    }
                }//end if

                else if (found != false)
                {
                    MessageBox.Show("The Textbox1 is Empty");
                }

            }//end try

            catch
            {
                MessageBox.Show("Error......");
            }

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.write_in_file();
            System.Environment.Exit(0);
        }

        
    
    
    
    
    
   

    
    
    
    
    
    
    
    }
}
