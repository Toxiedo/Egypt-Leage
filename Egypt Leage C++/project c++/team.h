#include "player.h"

using namespace std;

class team
{
public:
	team();
	string nameteams;
	string teamaddress;
	int id;
	vector <player> playeres;
	vector <string> plyname;
	void getteamsname( string tname );
	void getteaminformation ( int n , string address );
	void add_players_information( string playname , string position1 , int id1 , float age1 , int day1 , int mounth1 , int year1 , float salary1 , int number_tsh,string np1,string tname1);
	void addnatega (int n1 , int n2 );
	int win;
	int loss;
	int draw;
	int point;
	int havegool;
	int getgool;
	int deffgool;
	double avgs,avga;
};