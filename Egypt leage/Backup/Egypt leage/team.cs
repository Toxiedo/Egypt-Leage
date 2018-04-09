using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Egypt_leage
{
    public class team
    {
       
        public  string nameteams;
        public  string teamaddress;
        public  string nmpresant;
        public  int id;
        public  bool found = false;
        public  Image teamimage = null;
        public  List<player> playeres= new List<player>();
        public  List<string> plyname= new List<string>();
        public  List<string> match = new List<string>();

        public  List<string> random_team = new List<string>();
        public List<string> team_random = new List<string>();

        public  List<int> yourgool = new List<int>();
        public  List<int> agenstgool = new List<int>();
        public  int win = 0;
        public  int loss = 0;
        public  int draw = 0;
        public  int point = 0;
        public  int havegool = 0;
        public  int getgool = 0;
        public  int deffgool = 0;
        public  double avgs = 0.0, avga = 0.0;

        public  void addnatega(int n1 ,int n2 , string match_team)
        {
	        if ( n1 > n2 )
	        {
		        this.win += 1;
                this.point += 3;
        		
	        }
        	
	        else if ( n1 < n2 )
	        {
                this.loss += 1;
                this.point += 0;
	        }

	        else if ( n1 == n2 )
	        {
                this.draw += 1;
                this.point += 1;
	        }
            this.havegool += n1;
            this.getgool += n2;
            this.deffgool += (n1 - n2);
            match.Add(match_team);
            yourgool.Add(n1);
            agenstgool.Add(n2);
        }
        public void addnatega(int n1,int n2)
        {
            if (n1 > n2)
            {
                this.win += 1;
                this.point += 3;

            }

            else if (n1 < n2)
            {
                this.loss += 1;
                this.point += 0;
            }

            else if (n1 == n2)
            {
                this.draw += 1;
                this.point += 1;
            }
            this.havegool += n1;
            this.getgool += n2;
            this.deffgool += (n1 - n2);
            
        }

        public void  getteamsname(string tname)
        {
            this.nameteams = tname;
            
        }

        public void put_image_or_no(bool fon)
        {
            this.found = fon;

        }

        public void getimagetoteam(Image timg)
        {
            this.teamimage = timg;
        }

        public  void add_players_information (string playname , string position1 , double id1 , float age1 , int day1 , int mounth1 , int year1 , double salary1,double number_tsh,string np1,string tname1, double nmgool , Image plyimgg)
        {
	    
		    player ply = new player();
		    ply.get_information_of_player (  playname ,  position1 ,  id1 ,  age1 ,  day1 ,  mounth1 ,  year1 , salary1,number_tsh, np1,tname1,nmgool );
            ply.get_image_ply(plyimgg);
		    plyname.Add(playname);
           // plyimage.Add(plyimgg);
		    playeres.Add(ply);
		
        }
    
        public  void getteaminformation ( int n , string address, string nms )
        {
            this.id = n;
            this.teamaddress = address;
            this.nmpresant = nms;
        }
        public double get_age()
        {
            if (playeres.Count == 0)
            {
                return avga;
            }
            else
            {
                double sum = 0.0;
                for (int i = 0; i < playeres.Count(); i++)
                {
                    sum += playeres[i].age;

                }

                avga = sum / playeres.Count();
                return avga;

            }
        }
        public double get_salary()
        {
            if (playeres.Count == 0)
            {
                return avgs;
            }
            else
            {
                double sum = 0.0;
                for (int i = 0; i < playeres.Count(); i++)
                {
                    sum += playeres[i].salary;

                }

                avgs = sum / playeres.Count();
                return avgs;

            }
        }




    }
}
