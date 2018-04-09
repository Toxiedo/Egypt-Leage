#include <iostream>
#include <iomanip>
#include <cassert>
#include <new>
//#include <sstream>
//#include <fstream>
#include <vector>
#include <string>
#include < conio.h >
#include "Functions.h"
#include "team.h"
using namespace std;

void main ()
{  
	//LoadInformation();
	cout << setw(50) << endl << "**** Welcome in leage Program **** " << endl;
	cout << setw(52) << "***************************************" << endl;
	cout << setw(55) << "*********************************************" << endl << endl << endl;  
	int number;
	int choose;
	cout << " IF U Want Inter Inf To Team OR Player OR New Math Press -----> 1  " << endl;
	cout << " If U Want Display Any Inf Press ----> 2  " << endl;
	cout << " IF U Want Search About Ant Inf Press ----> 3  " << endl;
	cout << " IF U Want Delet Any Team OR Player Press ----> 4 " << endl;
	cout << " IF U Want update any information press ----> 5 " << endl;
	cout << " IF U Want End El Program Press ----> 6 " << endl;
	cin>>number;
	cout<<"*******************************************************************************"<<endl;
	while( number < 6 && number !=0 )
	{
	switch(number)
	{
	case 1:
		{
			cout<<"If U Want To Add New Team Or New Player Press 1 "<<endl;
			cout<<"If U Want To Add New Match Press 2"<<endl;
			cout<<"if u Want out Enter any number except(1 or 2 )"<<endl;
			cout<<"*************************************************************************"<<endl;
			cin>>choose;
			switch(choose)
			{
			case 1:
				inter_information_teams_and_players();
				break;
			case 2:
				add_newmath();
				break;
			default:
				cerr<<"Error"<<endl;
				break;
			}
			break;
		}
	case 2:
		{
			cout<<"If You Want To Display Inf About Teams Press ----> 1"<<endl;
			cout<<"If You Want To Display Inf About Players Press ----> 2"<<endl;
			cout<<"If You Want To Display teams ordered by their points Press ----> 3"<<endl;
			cout<<"If You Want To Display top (10) players who score the greatest no of goals Press ----> 4"<<endl;
			cout<<"If You Want To Display top (10) goalkeepers who have the fewest no of goals Press ----> 5"<<endl;
			cout<<"If You Want To Display top (10) players ordered by their ages Press ----> 6"<<endl;
			cout<<"If You Want To Display top (10) players ordered by their salaries Press ----> 7"<<endl;
			cout<<"If You Want To Display teams ordered by the average ages of its players Press ----> 8"<<endl;
			cout<<"If You Want To Display teams ordered by the average salaries of its players Press ----> 9"<<endl;
			cout<<"If You Want To Display teams ordered by their Goals Press ----> 10"<<endl;
			cout<<"if You Want To Display Player gool press ----> 11"<<endl;
			cout<< "if you want to out enter --------> 12 "<<endl;
			cout<<"*******************************************************************************"<<endl;
			cin>>choose;
			switch(choose)
			{
			case 1:
				display_information_of_teams();
				break;
			case 2:
				display_information_of_players();
				break;
			case 3:
				display_arrang_teams_by_points();
				break;
			case 4:
				top_10_gools();
				break;
			case 5:
				top_10_Gk();
				break;
			case 6:
				top_10age();
				break;
			case 7:
				top_10salary();
				break;
			case 8:
				top_10_avga();
				break;
			case 9:
				top_10_avgs();
				break;
			case 10:
				top_10_goals_teams();
				break;
			case 11:
				playergools();
				break;
			default:
				break;
			}
			break;
		}
	case 3:
		{
		cout<<"IF You Want To Search For Team By His Name Press 1 "<< endl;
		cout<< "IF You Want To Search For Team By His ID Press 2 "<< endl;
		cout<< "IF You Want To Search For Player By His Name Press 3 "<< endl;
		cout<< "IF You Want To Search For Player By His ID Press 4 "<< endl;
		cout<<"IF you Want to out Enter any number except (1 ---> 4)"<<endl;
		cin>>choose;
			if(choose == 1)
			{
			string n;
			cout<< "Plz Enter The Team Name "<< endl;
			cin>>n;
			//getline(cin,n,);
			search_with_name(n);
			}
			else if(choose == 2)
			{
			int d;
			cout<< "Plz Enter The ID Of Team "<< endl;
			cin>>d;
			search_with_id(d);
			}
			else if(choose == 3)
			{
			string z;
			cout<< "Plz Enter The Player Name "<< endl;
			cin>>z;
			search_player_by_name(z);
			}
			else if(choose == 4)
			{
			int x;
			cout<< "Plz Enter The ID Of Player "<< endl;
			cin>>x;
			search_player_by_id(x);
			}
			break;
		}
	case 4:
		{
			cout<<"If You Want To Delete Team Press 1"<<endl;
			cout<<"If You Want To Delete Player Press 2"<<endl;
			cin>>choose;
			if(choose == 1)
			{
				delet_team();
			}
			else if(choose == 2)
			{
				delet_player_by_his_name();
			}
			break;
		}
	case 5:
		{
			update();
			cout << endl;
			break;
		}
	default:
			cerr<<"Error"<<endl;
			break;
		
	}

	cout << " IF U Want Inter Inf To Team OR Player OR New Math Press  ----> 1  " << endl;
	cout << " If U Want Display Any Inf Press ----> 2  " << endl;
	cout << " IF U Want Search About Ant Inf Press ----> 3  " << endl;
	cout << " IF U Want Delet Any Team OR Player Press ----> 4 " << endl;
	cout << " IF U Want update any information press ----> 5 " << endl;
	cout << " IF U Want End El Program Press ----> 6 " << endl;
cin>>number;
}
//SaveInformation();

}	