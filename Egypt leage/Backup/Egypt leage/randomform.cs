using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Egypt_leage
{
    public partial class randomform : Form
    {
        public int count = 0;
        public randomform()
        {
            InitializeComponent();
       
        }
        const int seed = 19;
        Random r = new Random(seed);
        

        
       // int[] arr2 = new int[Form2.teames.Count() * (Form2.teames.Count()-1) ];
        private void randomform_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= Form2.teames.Count(); i++)
            {
                count += i;
            }
            int[] arr = new int[count];
            try
            {
                bool fo_team = false;
                int randnm;

                for (int i = 0; i < count; i++)
                {
                    randnm = r.Next() % Form2.teames.Count();
                    arr[i] = randnm;
                }//end for

                for (int i = 0; i < Form2.teames.Count(); i++)
                {
                    for (int h = 0; h < count; h++)
                    {
                        for (int j = 0; j < Form2.teames[i].random_team.Count(); j++)
                        {
                            if (Form2.teames[i].random_team[j] == Form2.teames[arr[h]].nameteams || Form2.teames[i].nameteams == Form2.teames[arr[h]].nameteams )
                            {
                                fo_team = true;
                                break;
                            }
                        }
                        if (fo_team == false)
                        {
                             Form2.teames[i].random_team.Add(Form2.teames[arr[h]].nameteams);
                        }
                        fo_team = false;
                    }
                }

                for (int i = 0; i < arr.Count(); i++)
                {
                    listBox1.Items.Add( (i+1).ToString() + ")  " +  Form2.teames[ arr[i] ].nameteams);
                   // listBox2.Items.Add(i.ToString() + ")  " +  Form2.teames[arr2[i]].nameteams);
                }
                for (int i = 0; i < Form2.teames.Count(); i++)
                {
                    if (Form2.teames[i].nameteams == "at7at alex")
                    {
                        for (int j = 0; j < Form2.teames[i].random_team.Count(); j++)
                        {
                            listBox3.Items.Add(Form2.teames[i].random_team[j]);
                        }
                    }
                }


                //int co = 0;
                //for (int i = 0; i < Form2.teames.Count(); i++)
                //{
                //    for (int j = 0; j < Form2.teames[i].random_team.Count(); j++)
                //    {
                //        int r1 = r.Next() % Form2.teames.Count();
                //        int r2 = r.Next() % Form2.teames[i].random_team.Count();
                //        if (listBox2.Items.Contains(Form2.teames[i].random_team[r2]))
                //        {
                //            continue;
                //        }
                //        else
                //        {
                //            listBox2.Items.Add((co + 1) + ")  " + Form2.teames[i].random_team[r2]);
                //        }
                //        co++;
                //    }
                //}
                int con = 0;
                bool fond = false;
               // for (int a = 0; a < Form2.teames.Count(); a++)
                //{
                    for (int i = 0; i < arr.Count(); i++)
                    {
                        string s = Form2.teames[arr[i]].nameteams;
                        for (int h = 0; h < Form2.teames.Count(); h++)
                        {
                            if (Form2.teames[h].nameteams == s)
                            {
                                int rr = r.Next() % Form2.teames[h].random_team.Count();
                               for (int j = 0; j < Form2.teames[h].random_team.Count(); j++)
                                {
                                    
                                    if (Form2.teames[h].random_team[rr] == Form2.teames[h].random_team[j])
                                    {
                                        fond = true;
                                    }
                               }
                                if(fond == false)
                                {
                                    listBox2.Items.Add((con + 1) + ")  " + Form2.teames[h].random_team[rr]);
                                    Form2.teames[h].team_random.Add(Form2.teames[h].random_team[rr]);
                                    con++;
                                }
                                fond = false;
                                  // break;
                                
                            }
                        }
                    }
               // }




                    for (int i = 0; i < Form2.teames.Count(); i++)
                    {
                        if (Form2.teames[i].nameteams == "ahly")
                        {
                            for (int j = 0; j < Form2.teames[i].team_random.Count(); j++)
                            {
                                listBox4.Items.Add(Form2.teames[i].team_random[j]);
                            }
                        }
                    }




            }//end try
            catch
            {
                MessageBox.Show("Error in random");
            }
        
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.write_in_file();

            System.Environment.Exit(0);
        }

        private void randomform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.write_in_file();
            System.Environment.Exit(0);
        }
    
    
    
    
    
    
    
    
    
    
    
    }
}
