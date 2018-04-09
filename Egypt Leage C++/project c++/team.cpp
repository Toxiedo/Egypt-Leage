#include "team.h"

void team:: addnatega(int n1 ,int n2 )
{
	if ( n1 > n2 )
	{
		team::win += 1;
		team::point += 3;
		
	}
	
	else if ( n1 < n2 )
	{
		team::loss += 1;
		team::point += 0;
	}

	else if ( n1 == n2 )
	{
		team::draw += 1;
		team::point += 1;
	}
	team::havegool += n1;
	team::getgool += n2;
	team::deffgool += (n1-n2);
	//player::goal;
}



void team:: getteamsname(string tname)
{
	nameteams = tname;
}

void team ::add_players_information (string playname , string position1 , int id1 , float age1 , int day1 , int mounth1 , int year1 , float salary1,int number_tsh,string np1,string tname1)
{
	
		player ply;
		ply.get_information_of_player (  playname ,  position1 ,  id1 ,  age1 ,  day1 ,  mounth1 ,  year1 , salary1,number_tsh, np1,tname1 );
		plyname.push_back(playname);
		playeres.push_back(ply);
		
}


void team ::getteaminformation ( int n , string address )
{
	id = n;
	teamaddress = address;
}

team::team()
{
	team::loss = 0;
	team::point = 0;
	team::win = 0;
	team::draw = 0;
	team::havegool = 0;
	team::getgool = 0;
	team::deffgool = 0;
	team::avga = 0;
	team::avgs = 0;
}

