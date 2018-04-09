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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        Image img;
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Enabled = true;
            comboBox1.Enabled = true;
            label1.Visible = true;
            comboBox1.Visible = true;
            label6.Visible = false;
            comboBox6.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == "الرقم السرى")
            {
                comboBox4.Enabled = true;
                label2.Enabled = true;
                label2.Visible = true;
                comboBox4.Visible = true;

                comboBox3.Enabled = false;
                label3.Enabled = false;
                label3.Visible = false;
                comboBox3.Visible = false;
                comboBox3.Text = "";

            }
            if (comboBox1.Text == "اسم الفريق")
            {
                comboBox3.Enabled = true;
                label3.Enabled = true;
                label3.Visible = true;
                comboBox3.Visible = true;

                comboBox4.Enabled = false;
                label2.Enabled = false;
                label2.Visible = false;
                comboBox4.Visible = false;
                comboBox4.Text = "";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Enabled = true;
            comboBox6.Enabled = true;
            label6.Visible = true;
            comboBox6.Visible = true;
            label1.Visible = false;
            comboBox1.Visible = false;
            
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.Text == "الرقم السرى")
            {
                comboBox5.Enabled = true;
                label5.Enabled = true;
                label5.Visible = true;
                comboBox5.Visible = true;

                comboBox2.Enabled = false;
                label4.Enabled = false;
                label4.Visible = false;
                comboBox2.Visible = false;
                comboBox2.Text = "";

                comboBox7.Enabled = false;
                label7.Enabled = false;
                label7.Visible = false;
                comboBox7.Visible = false;
                comboBox7.Text = "";

            }

            if (comboBox6.Text == "اسم الفريق")
            {
                comboBox2.Enabled = true;
                label4.Enabled = true;
                label4.Visible = true;
                comboBox2.Visible = true;

                comboBox5.Enabled = false;
                label5.Enabled = false;
                label5.Visible = false;
                comboBox5.Visible = false;
                comboBox5.Text = "";

                comboBox7.Enabled = false;
                label7.Enabled = false;
                label7.Visible = false;
                comboBox7.Visible = false;
                comboBox7.Text = "";
            }

            if (comboBox6.Text == "اسم اللاعب")
            {
                comboBox7.Enabled = true;
                label7.Enabled = true;
                label7.Visible = true;
                comboBox7.Visible = true;

                comboBox5.Enabled = false;
                label5.Enabled = false;
                label5.Visible = false;
                comboBox5.Visible = false;
                comboBox5.Text = "";

                comboBox2.Enabled = false;
                label4.Enabled = false;
                label4.Visible = false;
                comboBox2.Visible = false;
                comboBox2.Text = "";
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.write_in_file();

            System.Environment.Exit(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = img;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox2.Image = null;
            pictureBox1.Image = null;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                    c.Enabled = false;
                    c.Visible = false;
                }
                   
                if (c is ComboBox)
                {
                    c.Text = "";
                    c.Enabled = false;
                    c.Visible = false;
                }

                if (c is Label)
                {
                    c.Enabled = false;
                    c.Visible = false;
                    c.ForeColor = Color.Black;
                    c.BackColor = Color.Transparent;
                }

                if (c is ListBox)
                {
                    c.Text = "";
                    c.Enabled = false;
                    c.Visible = false;
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (comboBox1.Visible == true)
                {
                    listBox1.Visible = true;
                    listBox1.Enabled = true;
                    pictureBox1.Visible = true;
                    for (int i = 0; i < Form2.teames.Count(); i++)
                    {
                        if ( Form2.teames[i].nameteams == comboBox3.Text )
                        {
                            listBox1.Items.Add(Form2.teames[i].nameteams);
                            listBox1.Items.Add(Form2.teames[i].id);
                            listBox1.Items.Add(Form2.teames[i].teamaddress);
                            listBox1.Items.Add(Form2.teames[i].nmpresant);
                            listBox1.Items.Add(Form2.teames[i].point);
                            listBox1.Items.Add(Form2.teames[i].havegool);
                            listBox1.Items.Add("-------------------------");
                            pictureBox1.Image = Form2.teames[i].teamimage;
                        }
                        if (comboBox4.Visible == true)
                        {
                            if (Form2.teames[i].id == int.Parse(comboBox4.Text))
                            {
                                listBox1.Items.Add(Form2.teames[i].nameteams);
                                listBox1.Items.Add(Form2.teames[i].teamaddress);
                                listBox1.Items.Add(Form2.teames[i].nmpresant);
                                listBox1.Items.Add(Form2.teames[i].point);
                                listBox1.Items.Add("-------------------------");
                                pictureBox1.Image = Form2.teames[i].teamimage;
                            }
                        }
                    }
                }// end first if


                if (comboBox6.Visible == true)
                {
                    listBox2.Visible = true;
                    listBox2.Enabled = true;
                    pictureBox2.Visible = true;
                    for (int i = 0; i < Form2.teames.Count(); i++)
                    {
                        for (int j = 0; j < Form2.teames[i].playeres.Count(); j++)
                        {
                            if (comboBox5.Visible == true)
                            {
                                if (Form2.teames[i].playeres[j].id == int.Parse(comboBox5.Text))
                                {
                                    listBox2.Items.Add(Form2.teames[i].playeres[j].id);
                                    listBox2.Items.Add(Form2.teames[i].playeres[j].nameplayer);
                                    listBox2.Items.Add(Form2.teames[i].playeres[j].tname);
                                    listBox2.Items.Add(Form2.teames[i].playeres[j].salary);
                                    listBox2.Items.Add(Form2.teames[i].playeres[j].nu_tshert);
                                    listBox2.Items.Add(Form2.teames[i].playeres[j].goal);
                                    listBox2.Items.Add(Form2.teames[i].playeres[j].age);
                                    listBox2.Items.Add("-------------------------");
                                    pictureBox2.Image = Form2.teames[i].playeres[j].plyiamge;
                                }//end if
                            }
                            else if (comboBox7.Visible == true)
                            {
                                if (Form2.teames[i].playeres[j].nameplayer == comboBox7.Text)
                                {
                                    listBox2.Items.Add(Form2.teames[i].playeres[j].id);
                                    listBox2.Items.Add(Form2.teames[i].playeres[j].nameplayer);
                                    listBox2.Items.Add(Form2.teames[i].playeres[j].tname);
                                    listBox2.Items.Add(Form2.teames[i].playeres[j].salary);
                                    listBox2.Items.Add(Form2.teames[i].playeres[j].nu_tshert);
                                    listBox2.Items.Add(Form2.teames[i].playeres[j].goal);
                                    listBox2.Items.Add(Form2.teames[i].playeres[j].age);
                                    listBox2.Items.Add("-------------------------");
                                    pictureBox2.Image = Form2.teames[i].playeres[j].plyiamge;
                                }
                            }
                            else if (comboBox2.Visible == true)
                            {
                                if (Form2.teames[i].playeres[j].tname == comboBox2.Text)
                                {
                                    listBox2.Items.Add(Form2.teames[i].playeres[j].id);
                                    listBox2.Items.Add(Form2.teames[i].playeres[j].nameplayer);
                                    listBox2.Items.Add(Form2.teames[i].playeres[j].tname);
                                    listBox2.Items.Add(Form2.teames[i].playeres[j].salary);
                                    listBox2.Items.Add(Form2.teames[i].playeres[j].nu_tshert);
                                    listBox2.Items.Add(Form2.teames[i].playeres[j].goal);
                                    listBox2.Items.Add(Form2.teames[i].playeres[j].age);
                                    listBox2.Items.Add("-------------------------");
                                    pictureBox2.Image = Form2.teames[i].playeres[j].plyiamge;
                                }
                            }
                        }//end for
                    }// end for
                }//end if
            }//end try
            catch
            {
                MessageBox.Show("Error");
            }
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                img = this.BackgroundImage;
                for (int i = 0; i < Form2.teames.Count(); i++)
                {
                    comboBox4.Items.Add(Form2.teames[i].id);
                    comboBox3.Items.Add(Form2.teames[i].nameteams);
                }
                for (int i = 0; i < Form2.teames.Count(); i++)
                {
                    for (int j = 0; j < Form2.teames[i].playeres.Count(); j++)
                    {
                        comboBox5.Items.Add(Form2.teames[i].playeres[j].id);
                        comboBox7.Items.Add(Form2.teames[i].playeres[j].nameplayer);
                        comboBox2.Items.Add(Form2.teames[i].playeres[j].tname);
                    }
                }
            }
            catch
            { }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Form3 frm3 = new Form3();
            if (comboBox3.Text == "ahly")
            {
                this.BackgroundImage = frm3.imageList1.Images[2];
                foreach (Control c in this.Controls)
                {
                    if (c is Label)
                    {
                        c.BackColor = Color.Black;
                        c.ForeColor = Color.Red;
                    }

                    

                }
                
            }
            

        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.write_in_file();
            System.Environment.Exit(0);
        }
    
    
    
    
    
    
    
    
    
    
    
    }
}
