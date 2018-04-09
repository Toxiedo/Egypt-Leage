using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Pipes;
using System.IO.Ports;
using System.IO.IsolatedStorage;
using System.IO.Compression;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Drawing.Design;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Egypt_leage
{
    public partial class The_first : Form
    {
        public The_first()
        {
            DirectoryInfo df1 = new DirectoryInfo(Path_Folders);
            if (!df1.Exists)
            {
                df1.Create();
            }
            InitializeComponent();
        }
      
        public static string Path_Folders = "\\Folder_Program";
        public static float sec = 0;
        public static float min = 0;
        public static float hour = 0;


        private void timer1_Tick(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
            timer1.Enabled = false;
        }
        team tn;
        public static string sec1 = "0";
        public static string min1 = "0";
        public static string hour1 = "0";
        
        private void The_first_Load(object sender, EventArgs e)
        {
            
            FileStream fs = new FileStream(Path_Folders + "\\teames.txt",FileMode.OpenOrCreate,FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (sr.Peek() != -1)
            {
                tn = new team();
                    string nmteam = sr.ReadLine();
                    string id2 = sr.ReadLine();
                    string address = sr.ReadLine();
                    string nmpers = sr.ReadLine();
                    string space = sr.ReadLine();

                    int id = Convert.ToInt32(id2);
                   

                    tn.getteaminformation(id, address, nmpers);
                    tn.getteamsname(nmteam);

                    Form2.teames.Add(tn);
              

            }
            sr.Close();
            fs.Close();
            FileStream fsw = new FileStream(Path_Folders + "\\teames.txt", FileMode.Create, FileAccess.Write);
            fsw.Close();

            FileStream alntayg = new FileStream(Path_Folders + "\\mathes_ntega.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader srder = new StreamReader(alntayg);
            while (srder.Peek() != -1)
            {
                string teamname = srder.ReadLine();
                string secteam = srder.ReadLine();
                int fgool = int.Parse(srder.ReadLine());
                int sgool = int.Parse(srder.ReadLine());
                string space = srder.ReadLine();
                
                for (int i = 0; i < Form2.teames.Count; i++)
                {
                    if (Form2.teames[i].nameteams == teamname)
                    {
                        Form2.teames[i].addnatega(fgool, sgool, secteam);
                    }
                    if (Form2.teames[i].nameteams == secteam)
                    {
                        Form2.teames[i].addnatega(sgool,fgool);
                    }
                }
            }
            srder.Close();
            alntayg.Close();
            FileStream ftw = new FileStream(Path_Folders + "\\mathes_ntega.txt", FileMode.Create, FileAccess.Write);
            ftw.Close();

            FileStream fion = new FileStream(Path_Folders + "\\found_image_or_no.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sfion = new StreamReader(fion);
            int es = 0;
            while (sfion.Peek() != -1)
            {
                string spf = sfion.ReadLine();
                bool found = bool.Parse(spf);
                Form2.teames[es].put_image_or_no(found);
                es++;
            }
            sfion.Close();
            fion.Close();
            FileStream fbo = new FileStream(Path_Folders + "\\found_image_or_no.txt", FileMode.Create, FileAccess.Write);
            fbo.Close();
           
            try
            {
                for (int i = 0; i < Form2.teames.Count(); i++)
                {
                   
                    if (Form2.teames[i].found == true)
                    {

                        Bitmap bmp = new Bitmap(Image.FromFile(Path_Folders + "\\Image program\\" + Form2.teames[i].nameteams + ".jpg"));
                        Image ims = bmp;
                        Form2.teames[i].getimagetoteam(ims);
                    }
  
                }
            }
            catch
            {}



            DirectoryInfo df = new DirectoryInfo( Path_Folders +"\\Image program\\");
            if (!df.Exists)
            {
                df.Create();
            }
            
        
        
        
        
        
        
        
        
        }
    
    
    
    }
}
