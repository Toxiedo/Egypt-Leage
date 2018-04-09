#include < iostream >
#include <vector>
#include <string>
using namespace std;

class player
{
private:

public:
	string nameplayer;
	string tname;
	string position;
	string personal_id;
	int nu_tshert;
	int id;
	float age;
	int day;
	int mounth;
	int year;
	float salary;
	int goal;
	void get_information_of_player ( string plyname , string position1 , int id1 , float age1 , int day1 , int mounth1 , int year1 , float salary1 , int number_tsh,string np1,string tname1);
	void getgool( int gool1);
	player();
};