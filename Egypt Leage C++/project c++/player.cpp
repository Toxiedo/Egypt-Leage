#include "player.h"


void player ::get_information_of_player ( string plyname , string position1 , int id1 , float age1 , int day1 , int mounth1 , int year1 , float salary1 ,int number_tsh,string np1 ,string tname1)
{
	nameplayer = plyname;
	position = position1;
	id = id1;
	age = age1;
	salary = salary1;
	day = day1;
	mounth = mounth1;
	year = year1;
	nu_tshert =  number_tsh;
	personal_id =  np1;
	tname = tname1;
	//tname = Tname;

}

void player :: getgool ( int gool1 )
{
	player::goal += gool1;
}

player::player()
{
	player::goal = 0;

}