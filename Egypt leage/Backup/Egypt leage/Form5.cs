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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
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
            comboBox7.Items.Clear();
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                   // c.Enabled = false;
                    c.Visible = false;
                }

                if (c is ComboBox)
                {
                    c.Text = "";
                   // c.Enabled = false;
                    c.Visible = false;
                }

                if (c is Label)
                {
                  //  c.Enabled = false;
                    c.Visible = false;
                }

                if (c is ListBox)
                {
                    c.Text = "";
                  //  c.Enabled = false;
                    c.Visible = false;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  label6.Enabled = true;
          //  comboBox6.Enabled = true;
            label6.Visible = true;
            comboBox6.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  label1.Enabled = true;
          //  comboBox1.Enabled = true;
            label1.Visible = true;
            comboBox1.Visible = true;
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.Text == "الرقم السرى")
            {
               // comboBox5.Enabled = true;
              //  label5.Enabled = true;
                label5.Visible = true;
                comboBox5.Visible = true;

              //  comboBox2.Enabled = false;
              //  label4.Enabled = false;
                label4.Visible = false;
                comboBox2.Visible = false;

              //  comboBox7.Enabled = false;
              //  label7.Enabled = false;
                label7.Visible = false;
                comboBox7.Visible = false;

            }

            if (comboBox6.Text == "اسم الفريق")
            {
                comboBox7.Items.Clear();
                label4.Visible = true;
                comboBox2.Visible = true;

                label5.Visible = false;
                comboBox5.Visible = false;

                label7.Visible = false;
                comboBox7.Visible = false;
            }

            if (comboBox6.Text == "اسم اللاعب")
            {
                comboBox7.Items.Clear();
                for (int i = 0; i < Form2.teames.Count(); i++)
                {
                    for (int j = 0; j < Form2.teames[i].playeres.Count(); j++)
                    {
                       
                        comboBox7.Items.Add(Form2.teames[i].playeres[j].nameplayer);
                        
                    }
                }//end for
              
                label7.Visible = true;
                comboBox7.Visible = true;

                
                label5.Visible = false;
                comboBox5.Visible = false;

               
                label4.Visible = false;
                comboBox2.Visible = false;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "الرقم السرى")
            {
               // comboBox4.Enabled = true;
                //label2.Enabled = true;
                label2.Visible = true;
                comboBox4.Visible = true;

                //comboBox3.Enabled = false;
                //label3.Enabled = false;
                label3.Visible = false;
                comboBox3.Visible = false;

            }
            if (comboBox1.Text == "اسم الفريق")
            {
                //comboBox3.Enabled = true;
                //label3.Enabled = true;
                label3.Visible = true;
                comboBox3.Visible = true;

               // comboBox4.Enabled = false;
               // label2.Enabled = false;
                label2.Visible = false;
                comboBox4.Visible = false;
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            label8.Visible = true;
            //label8.Enabled = true;
            comboBox8.Visible = true;
            //comboBox8.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox7.Items.Clear();
          //  label8.Visible = true;
            label7.Visible = true;
            //label8.Enabled = true;
            //comboBox8.Visible = true;
            comboBox7.Visible = true;
           // comboBox8.Enabled = true;
            for (int i = 0; i < Form2.teames.Count; i++)
            {
                if (Form2.teames[i].nameteams == comboBox2.Text)
                {
                    for (int j = 0; j < Form2.teames[i].playeres.Count; j++)
                    {
                        comboBox7.Items.Add(Form2.teames[i].playeres[j].nameplayer);
                    }
                    break;
                }
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            label8.Visible = true;
           // label8.Enabled = true;
            comboBox8.Visible = true;
          //  comboBox8.Enabled = true;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < Form2.teames.Count(); i++)
                {
                    comboBox4.Items.Add(Form2.teames[i].id);
                    comboBox3.Items.Add(Form2.teames[i].nameteams);
                    comboBox10.Items.Add(Form2.teames[i].nameteams);
                }
                for (int i = 0; i < Form2.teames.Count(); i++)
                {
                    for (int j = 0; j < Form2.teames[i].playeres.Count(); j++)
                    {
                        comboBox5.Items.Add(Form2.teames[i].playeres[j].id);
                        //comboBox7.Items.Add(Form2.teames[i].playeres[j].nameplayer);
                        comboBox2.Items.Add(Form2.teames[i].playeres[j].tname);
                    }
                }//end for
            }//end try
            catch
            {
                MessageBox.Show("Error or not Found Date.....");
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox8.Text == "المرتب")
                {
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label10.Visible = true;
                    label9.Visible = true;

                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;

                    textBox5.Visible = false;
                    textBox6.Visible = false;
                    label13.Visible = false;
                    label14.Visible = false;

                    comboBox10.Visible = false;
                    textBox8.Visible = false;
                    label15.Visible = false;
                    label16.Visible = false;

                    textBox9.Visible = false;
                    textBox10.Visible = false;
                    label17.Visible = false;
                    label18.Visible = false;

                    for (int i = 0; i < Form2.teames.Count(); i++)
                    {
                        for (int j = 0; j < Form2.teames[i].playeres.Count(); j++)
                        {
                            if (comboBox5.Visible == true)
                            {
                                if (Form2.teames[i].playeres[j].id == int.Parse(comboBox5.Text))
                                {
                                    textBox1.Text = Form2.teames[i].playeres[j].salary.ToString();
                                }
                            }

                            else if (comboBox2.Visible == true)
                            {
                                if (Form2.teames[i].playeres[j].tname == comboBox2.Text)
                                {
                                    textBox1.Text = Form2.teames[i].playeres[j].salary.ToString();
                                }
                            }
                            else if (comboBox7.Visible == true)
                            {
                                if (Form2.teames[i].playeres[j].nameplayer == comboBox7.Text)
                                {
                                    textBox1.Text = Form2.teames[i].playeres[j].salary.ToString();
                                }
                            }//end else
                        }
                    }



                }


                if (comboBox8.Text == "رقم التيشرت")
                {
                    textBox1.Visible = false;
                    textBox2.Visible = false;
                    label10.Visible = false;
                    label9.Visible = false;

                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    label11.Visible = true;
                    label12.Visible = true;

                    textBox5.Visible = false;
                    textBox6.Visible = false;
                    label13.Visible = false;
                    label14.Visible = false;

                    comboBox10.Visible = false;
                    textBox8.Visible = false;
                    label15.Visible = false;
                    label16.Visible = false;

                    textBox9.Visible = false;
                    textBox10.Visible = false;
                    label17.Visible = false;
                    label18.Visible = false;

                    for (int i = 0; i < Form2.teames.Count(); i++)
                    {
                        for (int j = 0; j < Form2.teames[i].playeres.Count(); j++)
                        {
                            if (comboBox5.Visible == true)
                            {
                                if (Form2.teames[i].playeres[j].id == int.Parse(comboBox5.Text))
                                {
                                    textBox4.Text = Form2.teames[i].playeres[j].nu_tshert.ToString();
                                }
                            }

                            else if (comboBox2.Visible == true)
                            {
                                if (Form2.teames[i].playeres[j].tname == comboBox2.Text)
                                {
                                    textBox4.Text = Form2.teames[i].playeres[j].nu_tshert.ToString();
                                }
                            }
                            else if (comboBox7.Visible == true)
                            {
                                if (Form2.teames[i].playeres[j].nameplayer == comboBox7.Text)
                                {
                                    textBox4.Text = Form2.teames[i].playeres[j].nu_tshert.ToString();
                                }
                            }//end else
                        }//end for
                    }

                }


                if (comboBox8.Text == "عمر الاعب")
                {
                    textBox1.Visible = false;
                    textBox2.Visible = false;
                    label10.Visible = false;
                    label9.Visible = false;

                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;

                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    label13.Visible = true;
                    label14.Visible = true;

                    comboBox10.Visible = false;
                    textBox8.Visible = false;
                    label15.Visible = false;
                    label16.Visible = false;

                    textBox9.Visible = false;
                    textBox10.Visible = false;
                    label17.Visible = false;
                    label18.Visible = false;

                    for (int i = 0; i < Form2.teames.Count(); i++)
                    {
                        for (int j = 0; j < Form2.teames[i].playeres.Count(); j++)
                        {
                            if (comboBox5.Visible == true)
                            {
                                if (Form2.teames[i].playeres[j].id == int.Parse(comboBox5.Text))
                                {
                                    textBox6.Text = Form2.teames[i].playeres[j].age.ToString();
                                }
                            }

                            else if (comboBox2.Visible == true)
                            {
                                if (Form2.teames[i].playeres[j].tname == comboBox2.Text)
                                {
                                    textBox6.Text = Form2.teames[i].playeres[j].age.ToString();
                                }
                            }
                            else if (comboBox7.Visible == true)
                            {
                                if (Form2.teames[i].playeres[j].nameplayer == comboBox7.Text)
                                {
                                    textBox6.Text = Form2.teames[i].playeres[j].age.ToString();
                                }
                            }//end else
                        }
                    }
                }


                    if (comboBox8.Text == "الفريق")
                    {
                        textBox1.Visible = false;
                        textBox2.Visible = false;
                        label10.Visible = false;
                        label9.Visible = false;

                        textBox3.Visible = false;
                        textBox4.Visible = false;
                        label11.Visible = false;
                        label12.Visible = false;

                        textBox5.Visible = false;
                        textBox6.Visible = false;
                        label13.Visible = false;
                        label14.Visible = false;


                        comboBox10.Visible = true;
                        textBox8.Visible = true;
                        label15.Visible = true;
                        label16.Visible = true;

                        textBox9.Visible = false;
                        textBox10.Visible = false;
                        label17.Visible = false;
                        label18.Visible = false;

                        for (int i = 0; i < Form2.teames.Count(); i++)
                        {
                            for (int j = 0; j < Form2.teames[i].playeres.Count(); j++)
                            {
                                if (comboBox5.Visible == true)
                                {
                                    if (Form2.teames[i].playeres[j].id == int.Parse(comboBox5.Text))
                                    {
                                        textBox8.Text = Form2.teames[i].playeres[j].tname.ToString();
                                    }
                                }

                                else if (comboBox2.Visible == true)
                                {
                                    if (Form2.teames[i].playeres[j].tname == comboBox2.Text)
                                    {
                                        textBox8.Text = Form2.teames[i].playeres[j].tname.ToString();
                                    }
                                }
                                else if (comboBox7.Visible == true)
                                {
                                    if (Form2.teames[i].playeres[j].nameplayer == comboBox7.Text)
                                    {
                                        textBox8.Text = Form2.teames[i].playeres[j].tname.ToString();
                                    }
                                }//end else
                            }// end for
                        }// end for
                    }
                


                if (comboBox8.Text == "الرقم السرى")
                {
                    textBox1.Visible = false;
                    textBox2.Visible = false;
                    label10.Visible = false;
                    label9.Visible = false;

                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;

                    textBox5.Visible = false;
                    textBox6.Visible = false;
                    label13.Visible = false;
                    label14.Visible = false;

                    comboBox10.Visible = false;
                    textBox8.Visible = false;
                    label15.Visible = false;
                    label16.Visible = false;

                    textBox9.Visible = true;
                    textBox10.Visible = true;
                    label17.Visible = true;
                    label18.Visible = true;

                    for (int i = 0; i < Form2.teames.Count(); i++)
                    {
                        for (int j = 0; j < Form2.teames[i].playeres.Count(); j++)
                        {
                            if (comboBox5.Visible == true)
                            {
                                if (Form2.teames[i].playeres[j].id == int.Parse(comboBox5.Text))
                                {
                                    textBox10.Text = Form2.teames[i].playeres[j].id.ToString();
                                }
                            }

                            else if (comboBox2.Visible == true)
                            {
                                if (Form2.teames[i].playeres[j].tname == comboBox2.Text)
                                {
                                    textBox10.Text = Form2.teames[i].playeres[j].id.ToString();
                                }
                            }
                            else if (comboBox7.Visible == true)
                            {
                                if (Form2.teames[i].playeres[j].nameplayer == comboBox7.Text)
                                {
                                    textBox10.Text = Form2.teames[i].playeres[j].id.ToString();
                                }
                            }//end elseif
                        }//end for
                    }//end for


                }//end if
            }//end try

            catch
            {
                MessageBox.Show("Error.....");
            }


        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
                if (comboBox9.Text == "الرقم السرى")
                {
                    label20.Visible = true;
                    label19.Visible = true;
                    textBox11.Visible = true;
                    textBox12.Visible = true;

                    label21.Visible = false;
                    label22.Visible = false;
                    textBox13.Visible = false;
                    textBox14.Visible = false;

                    for (int i = 0; i < Form2.teames.Count(); i++)
                    {
                        if (comboBox4.Visible == true)
                        {
                            if (Form2.teames[i].id == int.Parse(comboBox4.Text))
                            {
                                textBox12.Text = Form2.teames[i].id.ToString();
                            }
                        }
                        else if (comboBox3.Visible == true)
                        {
                            if (Form2.teames[i].nameteams == comboBox3.Text)
                            {
                                textBox12.Text = Form2.teames[i].id.ToString();
                            }
                        }
                    }


                }
                if (comboBox9.Text == "رئيس النادى")
                {
                    label21.Visible = true;
                    label22.Visible = true;
                    textBox13.Visible = true;
                    textBox14.Visible = true;

                    label20.Visible = false;
                    label19.Visible = false;
                    textBox11.Visible = false;
                    textBox12.Visible = false;

                    for (int i = 0; i < Form2.teames.Count(); i++)
                    {
                        if (comboBox4.Visible == true)
                        {
                            if (Form2.teames[i].id == int.Parse(comboBox4.Text))
                            {
                                textBox13.Text = Form2.teames[i].nmpresant;
                            }
                        }
                        else if (comboBox3.Visible == true)
                        {
                            if (Form2.teames[i].nameteams == comboBox3.Text)
                            {
                                textBox13.Text = Form2.teames[i].nmpresant;
                            }
                        }
                    }


                }
            //}
            //catch
            //{
           //     MessageBox.Show("Error.....");
            //}
       
        
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox9.Visible = true;
            label23.Visible = true;

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox9.Visible = true;
            label23.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //try
            //{
                // To update team
                if(comboBox9.Visible == true)
                {
                    if (comboBox9.Text != "")
                    {
                        for (int i = 0; i < Form2.teames.Count(); i++)
                        {
                            if (textBox13.Visible == true)
                            {
                                if (comboBox4.Visible == true)
                                {
                                    if (Form2.teames[i].id == int.Parse(comboBox4.Text))
                                    {
                                        Form2.teames[i].nmpresant = textBox14.Text;
                                    }//end if
                                }
                                else if (comboBox3.Visible == true)
                                {
                                    if (Form2.teames[i].nameteams == comboBox3.Text)
                                    {
                                        Form2.teames[i].nmpresant = textBox14.Text;
                                    }
                                }
                            }
                            if (textBox12.Visible == true)
                            {
                                if (comboBox4.Visible == true)
                                {
                                    if (Form2.teames[i].id == int.Parse(comboBox4.Text))
                                    {
                                        Form2.teames[i].id = int.Parse(textBox11.Text);
                                    }//end if
                                }
                                else if (comboBox3.Visible == true)
                                {
                                    if (Form2.teames[i].nameteams == comboBox3.Text)
                                    {
                                        Form2.teames[i].id = int.Parse(textBox11.Text);
                                    }
                                }
                            }//end if
                        }//end for
                    }
                }//end first if

                // To Update player
                if(comboBox8.Visible == true && comboBox8.Text != "" )
                {
                    for (int i = 0; i < Form2.teames.Count();i++ )
                    {
                        for (int j = 0; j < Form2.teames[i].playeres.Count();j++ )
                        { 

                            if(textBox1.Visible == true)
                            {
                                //if(Form2.teames[i].playeres[j].id == int.Parse(comboBox5.Text)|| Form2.teames[i].playeres[j].tname == comboBox2.Text || Form2.teames[i].playeres[j].nameplayer == comboBox7.Text)
                                //{
                                //    Form2.teames[i].playeres[j].salary = int.Parse(textBox2.Text);
                                //}
                                if (comboBox5.Visible == true)
                                {
                                    if (Form2.teames[i].playeres[j].id == int.Parse(comboBox5.Text))
                                    {
                                        Form2.teames[i].playeres[j].salary = int.Parse(textBox2.Text);
                                    }
                                }

                                else if (comboBox2.Visible == true)
                                {
                                    if (Form2.teames[i].playeres[j].tname == comboBox2.Text)
                                    {
                                        Form2.teames[i].playeres[j].salary = int.Parse(textBox2.Text);
                                    }
                                }
                                else if (comboBox7.Visible == true)
                                {
                                    if (Form2.teames[i].playeres[j].nameplayer == comboBox7.Text)
                                    {
                                        Form2.teames[i].playeres[j].salary = int.Parse(textBox2.Text);
                                    }
                                }//end else
                            }//end first if


                            else if (textBox4.Visible == true)
                            {
                                //if (Form2.teames[i].playeres[j].id == int.Parse(comboBox5.Text) || Form2.teames[i].playeres[j].tname == comboBox2.Text || Form2.teames[i].playeres[j].nameplayer == comboBox7.Text)
                                //{
                                //    Form2.teames[i].playeres[j].nu_tshert = int.Parse(textBox3.Text);
                                //}
                                if (comboBox5.Visible == true)
                                {
                                    if (Form2.teames[i].playeres[j].id == int.Parse(comboBox5.Text))
                                    {
                                        Form2.teames[i].playeres[j].nu_tshert = int.Parse(textBox3.Text);
                                    }
                                }

                                else if (comboBox2.Visible == true)
                                {
                                    if (Form2.teames[i].playeres[j].tname == comboBox2.Text)
                                    {
                                        Form2.teames[i].playeres[j].nu_tshert = int.Parse(textBox3.Text);
                                    }
                                }
                                else if (comboBox7.Visible == true)
                                {
                                    if (Form2.teames[i].playeres[j].nameplayer == comboBox7.Text)
                                    {
                                        Form2.teames[i].playeres[j].nu_tshert = int.Parse(textBox3.Text);
                                    }
                                }//end else
                            }//end else if

                            else if (textBox6.Visible == true)
                            {
                                //if (Form2.teames[i].playeres[j].id == int.Parse(comboBox5.Text) || Form2.teames[i].playeres[j].tname == comboBox2.Text || Form2.teames[i].playeres[j].nameplayer == comboBox7.Text)
                                //{
                                //    Form2.teames[i].playeres[j].age = int.Parse(textBox5.Text);
                                //}
                                if (comboBox5.Visible == true)
                                {
                                    if (Form2.teames[i].playeres[j].id == int.Parse(comboBox5.Text))
                                    {
                                        Form2.teames[i].playeres[j].age = int.Parse(textBox5.Text);
                                    }
                                }

                                else if (comboBox2.Visible == true)
                                {
                                    if (Form2.teames[i].playeres[j].tname == comboBox2.Text)
                                    {
                                        Form2.teames[i].playeres[j].age = int.Parse(textBox5.Text);
                                    }
                                }
                                else if (comboBox7.Visible == true)
                                {
                                    if (Form2.teames[i].playeres[j].nameplayer == comboBox7.Text)
                                    {
                                        Form2.teames[i].playeres[j].age = int.Parse(textBox5.Text);
                                    }
                                }//end else
                            }//end else if

                            else if (textBox8.Visible == true)
                            {
                                if(comboBox2.Visible == true)
                                {
                                    bool found = false;
                                    if (Form2.teames[i].nameteams == comboBox2.Text)
                                    {
                                        string playn = comboBox7.Text;
                                        if (Form2.teames[i].playeres[j].nameplayer == comboBox7.Text)
                                        {
                                            double num = Form2.teames[i].playeres[j].salary;
                                            double num1 = Form2.teames[i].playeres[j].nu_tshert;
                                            double num2 = Form2.teames[i].playeres[j].id;
                                            double num3 = Form2.teames[i].playeres[j].number_gool_first;
                                            float age = Form2.teames[i].playeres[j].age;
                                            int year = Form2.teames[i].playeres[j].year;
                                            int day = Form2.teames[i].playeres[j].day;
                                            int mounth = Form2.teames[i].playeres[j].mounth;
                                            string tname = comboBox10.Text;
                                            string np1 = Form2.teames[i].playeres[j].personal_id;
                                            Image plyim = Form2.teames[i].playeres[j].plyiamge;
                                            found = true;
                                            for (int k = 0; k < Form2.teames.Count; k++)
                                            {
                                                if (Form2.teames[k].nameteams == comboBox10.Text)
                                                {

                                                    Form2.teames[k].add_players_information(playn, textBox4.Text, num2, age, day, mounth, year, num, num1, np1, tname, num3,plyim);
                                                    break;
                                                }// end if

                                            }//end for

                                            for (int s = 0; s < Form2.teames.Count; s++)
                                            {
                                                if (Form2.teames[s].nameteams == textBox8.Text)
                                                {
                                                    for (int d = 0; d < Form2.teames[s].playeres.Count; d++)
                                                    {
                                                        if (Form2.teames[s].playeres[d].nameplayer == comboBox7.Text)
                                                        {
                                                            Form2.teames[s].playeres.RemoveAt(d);
                                                            break;
                                                        }
                                                            
                                                    }//end for
                                                    break;
                                                }//end if
                                            }//end for


                                           
                                        }//end if
                                    }
                                    if (found == true)
                                    {
 
                                    }
                                }//end if


                                else if(comboBox5.Visible == true)
                                {
                                    if(Form2.teames[i].playeres[j].id == int.Parse(comboBox5.Text))
                                    {
                                                                               double num = Form2.teames[i].playeres[j].salary;
                                        double num1 = Form2.teames[i].playeres[j].nu_tshert;
                                        double num2 = Form2.teames[i].playeres[j].id;
                                        double num3 = Form2.teames[i].playeres[j].number_gool_first;
                                        float age = Form2.teames[i].playeres[j].age;
                                        int year = Form2.teames[i].playeres[j].year;
                                        int day = Form2.teames[i].playeres[j].day;
                                        int mounth = Form2.teames[i].playeres[j].mounth;
                                        string tname = comboBox10.Text;
                                        string np1 = Form2.teames[i].playeres[j].personal_id;
                                        Image plyim = Form2.teames[i].playeres[j].plyiamge;
                                        for (int k = 0; k < Form2.teames.Count(); k++)
                                        {
                                            if (Form2.teames[k].nameteams == comboBox10.Text)
                                            {

                                                Form2.teames[k].add_players_information(textBox1.Text, textBox4.Text, num2, age, day, mounth, year, num, num1, np1, tname, num3,plyim);
                                                //Form2.teames[k].add_players_information();
                                                //Form2.teames[k].playeres.Add(Form2.teames[i].playeres[j]);
                                                //Form2.teames[k].plyname.Add(Form2.teames[i].playeres[j].nameplayer );
                                            }// end if

                                            //Form2.teames[i].playeres[j].tname = textBox7.Text;
                                            if (Form2.teames[k].nameteams == textBox8.Text)
                                            {
                                                Form2.teames[k].playeres.Remove(Form2.teames[i].playeres[j]);
                                            }//end if


                                        }//end for
                                    }//end if
                                }//end else if


                                else if (comboBox7.Visible == true)
                                {
                                    if(Form2.teames[i].playeres[j].nameplayer == comboBox7.Text)
                                    {
                                                                               double num = Form2.teames[i].playeres[j].salary;
                                        double num1 = Form2.teames[i].playeres[j].nu_tshert;
                                        double num2 = Form2.teames[i].playeres[j].id;
                                        double num3 = Form2.teames[i].playeres[j].number_gool_first;
                                        float age = Form2.teames[i].playeres[j].age;
                                        int year = Form2.teames[i].playeres[j].year;
                                        int day = Form2.teames[i].playeres[j].day;
                                        int mounth = Form2.teames[i].playeres[j].mounth;
                                        string tname = comboBox10.Text;
                                        string np1 = Form2.teames[i].playeres[j].personal_id;
                                        Image plyim = Form2.teames[i].playeres[j].plyiamge;
                                        for (int k = 0; k < Form2.teames.Count(); k++)
                                        {
                                            if (Form2.teames[k].nameteams == comboBox10.Text)
                                            {

                                                Form2.teames[k].add_players_information(textBox1.Text, textBox4.Text, num2, age, day, mounth, year, num, num1, np1, tname, num3,plyim);
                                                //Form2.teames[k].add_players_information();
                                                //Form2.teames[k].playeres.Add(Form2.teames[i].playeres[j]);
                                                //Form2.teames[k].plyname.Add(Form2.teames[i].playeres[j].nameplayer );
                                            }// end if

                                            //Form2.teames[i].playeres[j].tname = textBox7.Text;
                                            if (Form2.teames[k].nameteams == textBox8.Text)
                                            {
                                                Form2.teames[k].playeres.Remove(Form2.teames[i].playeres[j]);
                                            }//end if


                                        }//end for
                                    }
                                }
                            }//end else if





                            else if (textBox10.Visible == true)
                            {
                                //if (Form2.teames[i].playeres[j].id == int.Parse(comboBox5.Text) || Form2.teames[i].playeres[j].tname == comboBox2.Text || Form2.teames[i].playeres[j].nameplayer == comboBox7.Text)
                                //{
                                //    Form2.teames[i].playeres[j].id = int.Parse(textBox9.Text);
                                //}
                                if (comboBox5.Visible == true)
                                {
                                    if (Form2.teames[i].playeres[j].id == int.Parse(comboBox5.Text))
                                    {
                                        Form2.teames[i].playeres[j].id = int.Parse(textBox9.Text);
                                    }
                                }

                                else if (comboBox2.Visible == true)
                                {
                                    if (Form2.teames[i].playeres[j].tname == comboBox2.Text)
                                    {
                                        Form2.teames[i].playeres[j].id = int.Parse(textBox9.Text);
                                    }
                                }
                                else if (comboBox7.Visible == true)
                                {
                                    if (Form2.teames[i].playeres[j].nameplayer == comboBox7.Text)
                                    {
                                        Form2.teames[i].playeres[j].id = int.Parse(textBox9.Text);
                                    }
                                }//end elseif
                            }//end else if



                        }//end for
                    }//end first for loop
                }//end first if




                MessageBox.Show("Updata......");
            //}
            //catch 
            //{
            //    MessageBox.Show("Error.....")
            //}
       
        
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.write_in_file();
            System.Environment.Exit(0);
        }

       
    
    
    
    
    
    
    }
}
