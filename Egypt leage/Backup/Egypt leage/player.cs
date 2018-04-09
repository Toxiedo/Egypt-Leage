using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Egypt_leage
{
    public class player
    {
       public  string nameplayer;
       public  Image plyiamge = null;
       public  string tname;
       public  string position;
       public  string personal_id;
       public  double number_gool_first = 0;
       public  double nu_tshert;
       public  double id;
       public  float age;
       public  int day;
       public  int mounth;
       public  int year;
       public  double salary;
       public  int goal;
       public  void get_information_of_player(string plyname, string position1, double id1, float age1, int day1, int mounth1, int year1, double salary1, double number_tsh, string np1, string tname1, double nmgool)
       {
          this.nameplayer = plyname;
          this.position = position1;
          this.id = id1;
          this.age = age1;
          this.salary = salary1;
          this.day = day1;
          this.mounth = mounth1;
          this.year = year1;
          this.nu_tshert = number_tsh;
          this.personal_id = np1;
          this.tname = tname1;
          this.number_gool_first = nmgool;
          this.age = 2011 - this.year;
       }
       public void getgool(int gool1)
       {
           this.goal += gool1;
       }
    
       public void get_image_ply(Image plyimg)
       {
           this.plyiamge = plyimg;
       }
    
    
    }
}
