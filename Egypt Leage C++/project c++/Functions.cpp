#include <iostream>
#include <iomanip>
#include <vector>
#include "team.h"
#include "Functions.h"
#include <string>
#include < conio.h >
#include<fstream>
#include <sstream>
using namespace std;

string tname;
string playname;
int number;
vector <team> teames;




void inter_information_teams_and_players()
{

	string plyname ,position1;
	int id1;
	float age1;
	int day1 , mounth1 , year1;
	float salary1; 
	int number_t_shert;
	char np[14];
	string np1;
	cout << " IF U Want Enter Teams Name ----> 1 " << endl;
	cout << " IF U Want ADD player Information ----> 2 " << endl;
	cout << " IF U Want Display Team Player ----> 3 " << endl;
	cout <<	" IF U Want Exit ----> 4" << endl;
	
	cin >> number;
	while ( number < 4 )
	{	
		int id;
		string address;
		if ( number == 1 )
		{
			team t;
			bool found = true;
			int last_id_for_teams = 0;
			cout << " plz enetr Team ID " << endl;
			cin >> id;
			
		   for ( int k = 0 , i = 0 ; k < teames.size() ; k++,i++  )
		   {
			
			   found = true;
				if ( teames[k].id == id )
				{
					cout << " This ID is Found Befour " << endl;
					found = false;
					if ( found == false )
					{
						cout << endl << " Plz Enter The ID Agian " << endl;
						cin >> id;
					}
				}
			}
			cout << " plz enetr Team Name " << endl;
			cin >> tname;
			cout << " plz enetr Team Address " << endl;
			cin>>address;
			t.getteamsname(tname);
			t.getteaminformation( id , address );
			teames.push_back(t);
		   
		}

		else if ( number == 2 )
		{
			cout << endl << endl;
			char ch;
			bool found = true;
			cout << " plz Enetr Teams Name " << endl;
			cin >> tname;
			for ( int i = 0 ; i < teames.size() ; i++ )
			{
				if ( teames[i].nameteams == tname )
				{
					cout << "  Enetr the players Information " << endl << endl;
					do
					{
						cout << " plz Enetr the players  ID " << endl;
						cin >> id1;
						
						for ( int k = 0 ; k < teames.size() ; k++ )
						{
							for ( int l = 0 ; l < teames[k].playeres.size() ; l++ )
							{
								found = true;
								if ( teames[k].playeres[l].id == id1 )
								{
									cout << " This ID is Found Befour " << endl;
									found = false;
								}
								if ( found == false )
								{
									cout << endl << " Plz Enter The ID Agian " << endl;
									cin >> id1;
								}
							}
						}
						
						cout << " plz Enetr the players Name " << endl;
						cin >> playname;
						cout << " plz Enetr the players  position " << endl;
						cin >> position1;
						cout << " plz Enetr the players  Age " << endl;
						cin >> age1;
						while(age1 < 16 || age1 > 46 )
						{
							cout << "Erorr" << endl;
							cout << "that is leage professional player must beg than 15 and less than 46 " << endl;
							cin >> age1;
						}
						year1 = 2011 - age1;

						cout << " plz Enetr the players  Salary " << endl;
						cin >> salary1;
						while(salary1 <= 0 )
						{
							if(salary1 < 0 || salary1 == 0)
							{
								cout << "Erorr salary should be great than 0 " << endl<<endl;
								cout << " Plz Enter The Salary greater Than 0 ---- > ";
								cin >> salary1;
							}
						}

						cout << endl << " plz Enetr the players  number of his t_shert " << endl;
						cin >> number_t_shert;
						for ( int k = 0 ; k < teames.size() ; k++ )
						{
							for ( int l = 0 ; l < teames[k].playeres.size() ; l++ )
							{
								if(teames[k].nameteams == tname)
								{
									found = true;
									if ( teames[k].playeres[l].nu_tshert == number_t_shert )
									{
										cout << " This number_t_shert is Found Befour " << endl;
										found = false;
									}
									if ( found == false )
									{
										cout << endl << " Plz Enter The number_t_shert Agian " << endl;
										cin >> number_t_shert;
									}
								}
							}
						}

						cout << " plz Enetr the players  Birth Day " << endl;
						cin >> day1;
						while(day1 > 1 || day1 < 31)
						{
							if(day1 < 1 || day1 > 31 )
							{
								cout << " Error U mast Enter Day Less than 31 And Big than 0 " << endl;
								cout << " PLz Enter the players  Birth Day " << endl;
								cin >> day1;
							}
							else
								break;
						}
						cout << " plz Enetr the players  Birth Mounth " << endl;
						cin >> mounth1;
						while(mounth1 < 1 || mounth1 > 12)
						{
							if(mounth1 < 1 || mounth1 > 12 )
							{
								cout << " Error U mast Enter mounth Less than 12 And Big than 0 " << endl;
								cout << " PLz Enter the players  Birth mounth " << endl;
								cin >> mounth1;
							}
						}
						cout << " Player born in " << year1 << endl;
						cout << " Plz Enter Number of his personal identity card " << endl;
						char letter = '\0';
						for (int n = 0 ; n < 14 ; n++)
						{
							letter = getche();
							if(letter != '\r')
							{
							  np[n] = letter;
							}
							else
							{
								cout << "Error U Must Enter 14 Number "<< endl;
								cout << "Plz Enter The Number from First -----> " << endl;
								n = 0;
							}
						}
						np1 = np;
						cout << endl;
						teames[i].add_players_information( playname ,  position1 ,  id1 ,  age1 ,  day1 ,  mounth1 ,  year1 , salary1,number_t_shert,np1,tname);
						cout << " If u want countinous Enter y || n   ";
						cin >> ch;
					}while ( ch != 'n');
					
				}
			}
		}

		
		

	else if ( number == 3 )
		{
			cout << endl << endl;
			cout << " plz Enetr Team Name " << endl;
			cin >> tname;
			for ( int i = 0 ; i < teames.size() ; i++ )
			{
				if ( teames[i].nameteams == tname )
				{
					cout << "________________________________________" << endl;
					cout << " Team ID ----> " << teames[i].id << endl;
					cout << " Team Name ----> " << teames[i].nameteams << endl;
					cout << " Tean Address ---->" << teames[i].teamaddress << endl;
					
					cout << " Information of players in This team " << endl;
					cout << " ____________________________________" << endl << endl;
					for ( int j = 0 ; j < teames[i].playeres.size() ; j++ )
					{
						if ( j == 0 )
						{
							cout << j << " The ID of player is " << teames[i].playeres[j].id << endl;
							cout << j << " The Name of player is   " <<  teames[i].plyname[j] << endl;
							cout << j << " The Position of player is " << teames[i].playeres[j].position << endl;
							cout << j << " The Age of player is " << teames[i].playeres[j].age << endl;
							cout << j << " The Salary of player is " << teames[i].playeres[j].salary << endl;
							cout << j << " The Number of player t_shert is " << teames[i].playeres[j].nu_tshert << endl;
							cout << j << " The Number of player personal ID is " << teames[i].playeres[j].personal_id << endl;
							cout << j << " The Birth Date of player is " << teames[i].playeres[j].day << " / " << teames[i].playeres[j].mounth << " / " << teames[i].playeres[j].year << endl;
							cout << "_________________________________________________________________" << endl;
							cout << "_________________________________________________________________" << endl;
							
						}
						else
						{
							cout <<  setw(32) <<  j << " The ID of player is " << teames[i].playeres[j].id;
							cout <<  setw(32) <<  j << " The Name of player is   " <<  teames[i].plyname[j] << endl;
							cout <<  setw(32) <<  j << " The Position of player is " << teames[i].playeres[j].position << endl;
							cout <<  setw(32) <<  j << " The Age of player is " << teames[i].playeres[j].age << endl;
							cout <<  setw(32) <<  j << " The Salary of player is " << teames[i].playeres[j].salary << endl;
							cout <<  setw(32) <<  j << " The Number of player t_shert is " << teames[i].playeres[j].nu_tshert << endl;
							cout <<  setw(32) <<  j << " The Number of player personal ID is " << teames[i].playeres[j].personal_id << endl;
							cout <<  setw(32) <<  j << " The Birth Date of player is " << teames[i].playeres[j].day << " / " << teames[i].playeres[j].mounth << " / " << teames[i].playeres[j].year << endl << endl << endl;
							cout << "_________________________________________________________________" << endl;
							cout << "_________________________________________________________________" << endl;
					
						}
					}

				}
			}
		}

		
		cout << " IF U Want Enter Teams Name ----> 1 " << endl;
		cout << " IF U Want ADD player Information ----> 2 " << endl;
		cout << " IF U Want Display Team Player ----> 3 " << endl;
		cout <<	" IF U Want Exit ----> 4" << endl;
		cin >> number;
	}

}

void add_newmath()
{
	string firstteam;
	string secondteam;
	string nameplayer1;
	int n1,n2;
	int gool1;
	int gool2;
	int totalgools = 0;
	cout << " Plz Enter the two team " << endl;
	cout << " The First Team " << endl;
	cin >> firstteam;
	cout << " The Second Team " << endl;
	cin >> secondteam;
	cout << " Plz Enter the no of gool to firstteam = ";
	cin >> n1;
	cout << " Plz Enter the no of gool to Secondteam = ";
	cin >> n2;
	
	
	for ( int i = 0 ; i < teames.size() ; i++ )
	{
			if( teames[i].nameteams == firstteam )
			{
				teames[i].addnatega(n1,n2);
				if ( n1 > 0 )
				{
					bool found = false;
					while (n1 != totalgools)
					{
						
						cout << " Plz Enter The name Of Player Who Enter The Gool In First Team " << endl;
						cin >> nameplayer1;
						for ( int j = 0 ; j < teames[i].playeres.size() ; j++ )
						{
							if ( teames[i].plyname[j] == nameplayer1 )
							{
								cout << "Plz Enter The number of Gools " << endl;
								cin >> gool1;
								if(gool1 > n1 )
								{
									cout << "Erorr thats big than the number of gool in the math " << endl;
									//cout << " Enter number of gool again ----> " << endl;
									//break;
								}
								else
								{
									teames[i].playeres[j].getgool(gool1);
									totalgools += gool1;
									found = true;
								}
								
							}//end if
						}//end for j
					}//end while
			
				}//end if
			}//end if
	}//end for i
	totalgools = 0;
	cout << endl << " The Second Team " << endl;
	for ( int i = 0 ; i < teames.size() ; i++ )
	{
		
		if( teames[i].nameteams == secondteam )
		{
			teames[i].addnatega(n2,n1);
				if ( n2 > 0 )
				{
					while (n2 != totalgools )
					{
						cout << " Plz Enter The name Of Player Who Enter The Gool In Second Team " << endl;
						cin >> nameplayer1;
						for ( int j = 0 ; j < teames[i].playeres.size() ; j++ )
						{
							if ( teames[i].plyname[j] == nameplayer1 )
							{
								cout << "Plz Enter The number of Gools " << endl;
								cin >> gool2;
								if(gool2 > n2 )
								{
									cout << "Erorr thats big than the number of gool in the math " << endl;
									//cout << " Enter number of gool again ----> " << endl;
									break;
								}
								teames[i].playeres[j].getgool(gool2);
								totalgools += gool2;
							}//end if
						}//end for j
					}//end while
				}//end if
		}//end if
	}//end for i

}
void display_information_of_teams()
{
	cout << endl << endl;
	cout << " Information OF This Team  " << endl;
	cout << " _________________________ " << endl;
	for( int i = 0 ; i < teames.size() ; i++ )
	{
		cout << " The ID of " << i+1  << " Team ----> " << teames[i].id << endl;
		cout << " Name of " << i+1  << " Team ----> " << teames[i].nameteams << endl;
		cout << " The Address of " << i+1  << " team ----> " << teames[i].teamaddress << endl;
		cout << " __________________________________________________________" << endl;
		cout << " name of his playeres " << endl;
		for ( int j = 0 ; j < teames[i].playeres.size() ; j++ )
		{

				if ( j == 0 )
				{
					cout << j << " is ::"<< teames[i].plyname[j] << endl;
				}
				else
				{
					cout <<  setw(32) << j << " is ::"<< teames[i].plyname[j] << endl;
			
				}
		}
		cout << " ____________________________________ " << endl;
		cout << endl;
		cout << " its point =  " << teames[i].point << endl;
		cout << " its won =   "  << teames[i].win  << "  math " << endl << endl;
		cout << " its draw =  "  << teames[i].draw << "  math " << endl << endl;
		cout << " its loss =  "  << teames[i].loss << "  math " << endl << endl;
		cout << " its Gool =  "  << teames[i].havegool << endl << endl;
		cout << " The loss Gool =  "  << teames[i].getgool << endl << endl;
		cout << " The Deff Gool =  "  << teames[i].deffgool << endl << endl << endl;
		cout << " ____________________________________________________________________ " << endl;
		cout << " ____________________________________________________________________ " << endl;
	}


}
void search_with_name(string name)
{
	cout << endl << endl;
	for ( int i = 0 ; i < teames.size() ; i++ )
	{
		if ( teames[i].nameteams == name )
		{
			cout << " The ID of " << i+1  << " team " << teames[i].id << endl;
			cout << " name of " << i+1  << " team " << teames[i].nameteams << endl;
			cout << " The Address of " << i+1  << " team " << teames[i].teamaddress << endl;
			cout << " name of his playeres " << endl;
			for ( int j = 0 ; j < teames[i].playeres.size() ; j++ )
			{
				if ( j == 0 )
				{
					cout << j << " is ::"<< teames[i].plyname[j] << endl;
				}
				else
				{
					cout <<  setw(32) << j << " is ::"<< teames[i].plyname[j] << endl;
			
				}
			}
			cout << endl;
			cout << " its point =  " << teames[i].point << endl;
			cout << " its won =   "  << teames[i].win  << "  math " << endl << endl;
			cout << " its draw =  "  << teames[i].draw << "  math " << endl << endl;
			cout << " its loss =  "  << teames[i].loss << "  math " << endl << endl;
			cout << " its Gool =  "  << teames[i].havegool << endl << endl;
			cout << " The loss Gool =  "  << teames[i].getgool << endl << endl;
			cout << " The Deff Gool =  "  << teames[i].deffgool << endl << endl << endl;

		}
		
	}
}
void search_with_id ( int id )
{
	cout << endl << endl;
	for ( int i = 0 ; i < teames.size() ; i++ )
	{
		if ( teames[i].id == id )
		{
			cout << " The ID of " << i+1  << " team " << teames[i].id << endl;
			cout << " name of " << i+1  << " team " << teames[i].nameteams << endl;
			cout << " The Address of " << i+1  << " team " << teames[i].teamaddress << endl;
			cout << " name of his playeres " << endl;
			for ( int j = 0 ; j < teames[i].playeres.size() ; j++ )
			{
				if ( j == 0 )
				{
					cout << j << " is ::"<< teames[i].plyname[j] << endl;
				}
				else
				{
					cout <<  setw(32) << j << " is ::"<< teames[i].plyname[j] << endl;
			
				}
			}
			cout << endl;
			cout << " its point =  " << teames[i].point << endl;
			cout << " its won =   "  << teames[i].win  << "  math " << endl << endl;
			cout << " its draw =  "  << teames[i].draw << "  math " << endl << endl;
			cout << " its loss =  "  << teames[i].loss << "  math " << endl << endl;
			cout << " its Gool =  "  << teames[i].havegool << endl << endl;
			cout << " The loss Gool =  "  << teames[i].getgool << endl << endl;
			cout << " The Deff Gool =  "  << teames[i].deffgool << endl << endl << endl;

		}
		cout << endl;
	}
}
void display_information_of_players()
{
	cout << endl << endl;
	cout << " Plz Enter Name of Team u Want Display Information of its Players " << endl;
	cin >> tname;
	for ( int i = 0 ; i < teames.size() ; i++ )
	{
		if (teames[i].nameteams == tname )
		{
			cout << " team name = " << teames[i].nameteams << endl;
			cout << " Information of players in This team " << endl << endl;
			for ( int j = 0 ; j < teames[i].playeres.size() ; j++ )
			{
					if ( j == 0 )
					{
							cout << j << " The ID of player is " << teames[i].playeres[j].id << endl;
							cout << j << " The Name of player is   " <<  teames[i].plyname[j] << endl;
							cout << j << " The Position of player is " << teames[i].playeres[j].position << endl;
							cout << j << " The Number of Gool He Is Enter " << teames[i].playeres[j].goal << endl;
							cout << j << " The Age of player is " << teames[i].playeres[j].age << endl;
							cout << j << " The Salary of player is " << teames[i].playeres[j].salary << endl;
							cout << j << " The Birth Date of player is " << teames[i].playeres[j].day << " / " << teames[i].playeres[j].mounth << " / " << teames[i].playeres[j].year << endl << endl << endl;
							
					}
					else
					{
							cout <<  setw(32) <<  j << " The ID of player is " << teames[i].playeres[j].id;
							cout <<  setw(32) <<  j << " The Name of player is   " <<  teames[i].plyname[j] << endl;
							cout <<  setw(32) <<  j << " The Position of player is " << teames[i].playeres[j].position << endl;
							cout <<  setw(32) <<  j << " The Number of Gool He Is Enter " << teames[i].playeres[j].goal << endl;
							cout <<  setw(32) <<  j << " The Age of player is " << teames[i].playeres[j].age << endl;
							cout <<  setw(32) <<  j << " The Salary of player is " << teames[i].playeres[j].salary << endl;
							cout <<  setw(32) <<  j << " The Birth Date of player is " << teames[i].playeres[j].day << " / " << teames[i].playeres[j].mounth << " / " << teames[i].playeres[j].year << endl << endl << endl;
							
					
					}
			}

		}

	}
	
}
void search_player_by_name(string name)
{
	cout << endl << endl;
	for ( int i = 0 ; i < teames.size() ; i++ )
	{
		for ( int j = 0 ; j < teames[i].playeres.size() ; j++ )
		{
			if ( teames[i].plyname[j] == name )
			{
				cout << " team name = " << teames[i].nameteams << endl;
				cout << " Information of players in This team " << endl;
				
					if ( j == 0 )
					{
							cout << j << " The ID of player is " << teames[i].playeres[j].id << endl;
							cout << j << " The Name of player is   " <<  teames[i].plyname[j] << endl;
							cout << j << " The Position of player is " << teames[i].playeres[j].position << endl;
							cout << j << " The Number of Gool He Is Enter " << teames[i].playeres[j].goal << endl;
							cout << j << " The Age of player is " << teames[i].playeres[j].age << endl;
							cout << j << " The Salary of player is " << teames[i].playeres[j].salary << endl;
							cout << j << " The Birth Date of player is " << teames[i].playeres[j].day << " / " << teames[i].playeres[j].mounth << " / " << teames[i].playeres[j].year << endl << endl << endl;
							
					}
					else
					{
							cout <<  setw(32) <<  j << " The ID of player is " << teames[i].playeres[j].id;
							cout <<  setw(32) <<  j << " The Name of player is   " <<  teames[i].plyname[j] << endl;
							cout <<  setw(32) <<  j << " The Position of player is " << teames[i].playeres[j].position << endl;
							cout <<  setw(32) <<  j << " The Number of Gool He Is Enter " << teames[i].playeres[j].goal << endl;
							cout <<  setw(32) <<  j << " The Age of player is " << teames[i].playeres[j].age << endl;
							cout <<  setw(32) <<  j << " The Salary of player is " << teames[i].playeres[j].salary << endl;
							cout <<  setw(32) <<  j << " The Birth Date of player is " << teames[i].playeres[j].day << " / " << teames[i].playeres[j].mounth << " / " << teames[i].playeres[j].year << endl << endl << endl;
							
					
					}//end else
				
			}//end if
		}//end for j
	}// end for i
}//end function
void search_player_by_id ( int id )
{
	cout << endl << endl;
	for ( int i = 0 ; i < teames.size() ; i++ )
	{
		for ( int j = 0 ; j < teames[i].playeres.size() ; j++ )
		{
			if ( teames[i].playeres[j].id == id )
			{
				cout << " team name = " << teames[i].nameteams << endl;
				cout << " Information of players in This team " << endl;
				
					if ( j == 0 )
					{
							cout << j << " The ID of player is " << teames[i].playeres[j].id << endl;
							cout << j << " The Name of player is   " <<  teames[i].plyname[j] << endl;
							cout << j << " The Position of player is " << teames[i].playeres[j].position << endl;
							cout << j << " The Number of Gool He Is Enter " << teames[i].playeres[j].goal << endl;
							cout << j << " The Age of player is " << teames[i].playeres[j].age << endl;
							cout << j << " The Salary of player is " << teames[i].playeres[j].salary << endl;
							cout << j << " The Birth Date of player is " << teames[i].playeres[j].day << " / " << teames[i].playeres[j].mounth << " / " << teames[i].playeres[j].year << endl << endl << endl;
							
					}
					else
					{
							cout <<  setw(32) <<  j << " The ID of player is " << teames[i].playeres[j].id;
							cout <<  setw(32) <<  j << " The Name of player is   " <<  teames[i].plyname[j] << endl;
							cout <<  setw(32) <<  j << " The Position of player is " << teames[i].playeres[j].position << endl;
							cout <<  setw(32) <<  j << " The Number of Gool He Is Enter " << teames[i].playeres[j].goal << endl;
							cout <<  setw(32) <<  j << " The Age of player is " << teames[i].playeres[j].age << endl;
							cout <<  setw(32) <<  j << " The Salary of player is " << teames[i].playeres[j].salary << endl;
							cout <<  setw(32) <<  j << " The Birth Date of player is " << teames[i].playeres[j].day << " / " << teames[i].playeres[j].mounth << " / " << teames[i].playeres[j].year << endl << endl << endl;
							
					
					}//end else
				
			}//end if
		}//end for j
	}// end for i
}
void search_player_by_team( string name )
{
	cout << endl << endl;
	for ( int i = 0 ; i < teames.size() ; i++ )
	{
		for ( int j = 0 ; j < teames[i].playeres.size() ; j++ )
		{
			if ( teames[i].nameteams == name )
			{
				cout << " team name = " << teames[i].nameteams << endl;
				cout << " Information of players in This team " << endl;
				
					if ( j == 0 )
					{
							cout << j << " The ID of player is " << teames[i].playeres[j].id << endl;
							cout << j << " The Name of player is   " <<  teames[i].plyname[j] << endl;
							cout << j << " The Position of player is " << teames[i].playeres[j].position << endl;
							cout << j << " The Number of Gool He Is Enter " << teames[i].playeres[j].goal << endl;
							cout << j << " The Age of player is " << teames[i].playeres[j].age << endl;
							cout << j << " The Salary of player is " << teames[i].playeres[j].salary << endl;
							cout << j << " The Birth Date of player is " << teames[i].playeres[j].day << " / " << teames[i].playeres[j].mounth << " / " << teames[i].playeres[j].year << endl << endl << endl;
							
					}
					else
					{
							cout <<  setw(32) <<  j << " The ID of player is " << teames[i].playeres[j].id;
							cout <<  setw(32) <<  j << " The Name of player is   " <<  teames[i].plyname[j] << endl;
							cout <<  setw(32) <<  j << " The Position of player is " << teames[i].playeres[j].position << endl;
							cout <<  setw(32) <<  j << " The Number of Gool He Is Enter " << teames[i].playeres[j].goal << endl;
							cout <<  setw(32) <<  j << " The Age of player is " << teames[i].playeres[j].age << endl;
							cout <<  setw(32) <<  j << " The Salary of player is " << teames[i].playeres[j].salary << endl;
							cout <<  setw(32) <<  j << " The Birth Date of player is " << teames[i].playeres[j].day << " / " << teames[i].playeres[j].mounth << " / " << teames[i].playeres[j].year << endl << endl << endl;
							
					
					}//end else
				
			}//end if
		}//end for j
	}// end for i
}
void delet_player_by_his_name( )
{
	string Delet_player;
	cout << " Plz Enter The Name of Player u Want Delet " << endl;
	cin >> Delet_player;
	for ( int i = 0 ; i < teames.size() ; i++ )
	{
		for ( int j = 0 ; j < teames[i].playeres.size() ; j++ )
		{
			if ( teames[i].playeres[j].nameplayer == Delet_player || teames[i].plyname[j] == Delet_player )
			{
				teames[i].plyname.erase(teames[i].plyname.begin() + j);
				teames[i].playeres.erase(teames[i].playeres.begin() + j);
			}
		}
	}
}
void delet_team( )
{
    cout << " plz enetr teams name u want Delete " << endl;
	cin >> tname;
	for ( int i = 0 ; i < teames.size() ; i++ )
	{
		if ( teames[i].nameteams == tname )
		{
			teames.erase(teames.begin() + i );

		}
	}

}
void display_arrang_teams_by_points ()
{
	for(int j=0; j<teames.size();j++)
	{
		for(int k=0;k<(teames.size()-1);k++)
		{
			if(teames[k+1].point > teames[k].point)
			{
				team temp = teames[k];
				teames[k] = teames[k+1];
				teames[k+1] = temp;
			}
		}
	}
	cout<<"**********************************\n";
	cout<<"*Teams"<<setw(10)<<"Points*"<<endl;
	cout<<"**********************************\n";
	for(int y=0;y<teames.size();y++)
	{
		cout<<setw(10)<<teames[y].nameteams<<setw(5)<<teames[y].point<<endl;
	}
	cout<<"**********************************\n";
}
void top_10_gools()
{
	vector <player> q;
	player p;
	int a=0;
	for(int j=0; j<teames.size();j++)
	{
		for(int h=0;h<teames[j].playeres.size();h++)
		{
			p = teames[j].playeres[h];
			a++;
			q.push_back(p);
		}
	}

	for(int i=0; i<q.size();i++)
	{
		for(int s=0;s<q.size()-1;s++)
		{
				if(q[s+1].goal  > q[s].goal)
				{
					player temp = q[s];
					q[s] = q[s+1];
					q[s+1] = temp;
				}
		}
	}
	cout<<setw(15)<<"Player Name"<<setw(15)<<"Goals"<<endl;
	for(int qw=0;qw<10;qw++)
	{
		if(qw == q.size())
			break;
		cout<<setw(15)<<q[qw].nameplayer<<setw(15)<<q[qw].goal<<endl;
		
	}
}
void top_10_Gk()
{
	//vector <player> q;
	for(int j=0; j<teames.size();j++)
	{
		for(int k=0;k<(teames.size()-1);k++)
		{
			if(teames[k+1].getgool > teames[k].getgool)
			{
				team temp = teames[k];
				teames[k] = teames[k+1];
				teames[k+1] = temp;
			}
		}
	}
	cout<<"Player"<<"   "<<"Goals"<<endl;
	for(int y = teames.size()-1 ; y >= 0  ; y--)
	{
		for(int i = 0 ;i < teames[y].playeres.size(); i++)
		{
			if(teames[y].playeres[i].position=="GK"||teames[y].playeres[i].position=="gk"||teames[y].playeres[i].position=="Gk"||teames[y].playeres[i].position=="gK")
			{
				cout<<teames[y].playeres[i].nameplayer<<"  ";
			}
		}
		cout<<teames[y].getgool<<endl;
		if(y == teames.size())
			break;
	}
}
void top_10_avgs()
{
	double total=0.0;
	int count=0;
	for(int i=0;i<teames.size();i++)
	{
		for(int j=0;j<teames[i].playeres.size();j++)
		{
			total += teames[i].playeres[j].salary;
			count++;
		}
		teames[i].avgs = total/count;
		total=0.0;
		count=0;
	}
	for(int s=0; s<teames.size();s++)
	{
		for(int k=0;k<(teames.size()-1);k++)
		{
			if(teames[k+1].avgs > teames[k].avgs)
			{
				team temp = teames[k];
				teames[k] = teames[k+1];
				teames[k+1] = temp;
			}
		}
	}
	cout<<"Teams"<<"   "<<"Values"<<endl;
	for(int g=0;g<teames.size();g++)
	{
		cout<<teames[g].nameteams<<"  "<<teames[g].avgs<<endl;
	}
}
void top_10_avga()
{
	double total=0.0;
	int count=0;
	for(int i=0;i<teames.size();i++)
	{
		for(int j=0;j<teames[i].playeres.size();j++)
		{
			total += teames[i].playeres[j].age;
			count++;
		}
		teames[i].avga = total/count;
		total=0;
		count=0;
	}
	for(int s=0; s<teames.size();s++)
	{
		for(int k=0;k<(teames.size()-1);k++)
		{
			if(teames[k+1].avga > teames[k].avga)
			{
				team temp = teames[k];
				teames[k] = teames[k+1];
				teames[k+1] = temp;
			}
		}
	}
	cout<<"Teams"<<"   "<<"Values"<<endl;
	for(int g=0;g<teames.size();g++)
	{
		cout<<teames[g].nameteams<<"  "<<teames[g].avga<<endl;
	}
}
void update()
{
	int rakam,s,m;
	cout<< "Plz Choose The Team "<< endl;
	for(int i=0;i<teames.size();i++)
	{
		cout<<i+1<<"-"<<teames[i].nameteams<<endl;
	}
	cin>>rakam;
	cout<<"Choose Player"<<endl;
	for(int j=0;j<teames[rakam-1].playeres.size();j++)
	{
		cout<<j+1<<"-"<<teames[rakam-1].playeres[j].nameplayer<<"\n";
	}
	cout << "Enter number player ---->   ";
	cin>>s;
	cout << endl;
	cout<<setw(25) << teames[rakam-1].playeres[s-1].nameplayer<<endl;
	cout<<setw(44) << "*************************" << endl;
	cout<<setw(20) << "*"<< " ID        ----> " <<teames[rakam-1].playeres[s-1].id<< setw(6) << "*"<<endl;
	cout<<setw(20) << "*"<< " team name ----> " <<teames[rakam-1].playeres[s-1].tname<< setw(3) <<"*"<<endl;
	cout<<setw(20) << "*"<< " position  ----> " <<teames[rakam-1].playeres[s-1].position<< setw(5) <<"*"<<endl;
	cout<<setw(20) << "*"<< " salary    ----> " <<teames[rakam-1].playeres[s-1].salary<< setw(1) <<"*"<<endl;
	cout<<setw(44) << "*************************" << endl;
	cout<< "If You Want To Update Position Press ----> 1 \n";
	cout<< "If You Want To Update Salary Press ----> 2 \n";
	cout<< "If You Want To Update Id Press ----> 3 \n";
	cout<< "If You Want To Update Teamname Press ----> 4 \n";
	cout<< "If You Want To Update age Press ----> 5 \n";
	cout<< "If You Want To Update name player Press ----> 6 \n";
	cin>>m;
	switch(m)
	{
	case 1:
		cout << "Enter new position ----> ";
		cin>>teames[rakam-1].playeres[s-1].position;
		break;
	case 2:
		cout << "Enter new Salary ----> ";
		cin>>teames[rakam-1].playeres[s-1].salary;
		break;
	case 3:
		cout << "Enter new Id ----> ";
		cin>>teames[rakam-1].playeres[s-1].id;
		break;
	case 4:
		cout << "Enter new Teamname ----> ";
		cin>>teames[rakam-1].playeres[s-1].tname;
		break;
	case 5:
		cout << "Enter new age ----> ";
		cin>>teames[rakam-1].playeres[s-1].age;
		break;
	case 6:
		cout << "Enter new name player ----> ";
		cin>>teames[rakam-1].playeres[s-1].nameplayer;
		break;
	}
}
void top_10age()
{
	vector <player> q;
	player p;
	int a=0;
	for(int j=0; j<teames.size();j++)
	{
		for(int h=0;h<teames[j].playeres.size();h++)
		{
			p = teames[j].playeres[h];
			a++;
			q.push_back(p);
		}
	}

	for(int i=0; i<q.size();i++)
	{
		for(int s=0;s<q.size()-1;s++)
		{
				if(q[s+1].age  > q[s].age)
				{
					player temp = q[s];
					q[s] = q[s+1];
					q[s+1] = temp;
				}
		}
	}
	cout<<setw(15)<<"Player Name"<<setw(15)<<"Age"<<endl;
	for(int qw=0;qw<10;qw++)
	{
		if(qw == teames.size())
			break;
		cout<<setw(15)<<q[qw].nameplayer<<setw(15)<<q[qw].age<<endl;
	}
}
void top_10salary()
{
	vector <player> q;
	player p;
	int a=0;
	for(int j=0; j<teames.size();j++)
	{
		for(int h=0;h<teames[j].playeres.size();h++)
		{
			p = teames[j].playeres[h];
			a++;
			q.push_back(p);
		}
	}

	for(int i=0; i<q.size();i++)
	{
		for(int s=0;s<q.size()-1;s++)
		{
				if(q[s+1].salary  > q[s].salary)
				{
					player temp = q[s];
					q[s] = q[s+1];
					q[s+1] = temp;
				}
		}
	}
	cout<<setw(15)<<"Player Name"<<setw(15)<<"Salary"<<endl;
	for(int qw=0;qw<10;qw++)
	{
		if(qw == q.size())
			break;
		cout<<setw(15)<<q[qw].nameplayer<<setw(15)<<q[qw].salary<<endl;
	}
}
void top_10_goals_teams()
{
	for(int j=0; j<teames.size();j++)
	{
		for(int k=0;k<(teames.size()-1);k++)
		{
			if(teames[k+1].havegool > teames[k].havegool)
			{
				team temp = teames[k];
				teames[k] = teames[k+1];
				teames[k+1] = temp;
			}
		}
	}
	cout<<"**********************************\n";
	cout<<"Teams"<<setw(10)<<"goals"<<endl;
	cout<<"**********************************\n";
	for(int y=0;y<teames.size();y++)
	{
		cout<<setw(10)<<teames[y].nameteams<<setw(5)<<teames[y].havegool<<endl;
	}
	cout<<"**********************************\n";
}
void LoadInformation()
{
	string teamname,teamadress,teamid;
	string nameplayer;
	string tname;
	string position;
	string id, age, day, mounth, year;
	string salary, goal;
	int counter = 0;
	ifstream teamfile("team file.txt");
	ifstream playerfile("player file.txt");
	//ifstream accountfile("Accounts file.txt");
	while(teamfile.good())
	{	string line;
		getline(teamfile,line);
		if(line == "----------------------------------------------------------------")
			{
				continue;
			}
			else
			{
				stringstream ss(line);

					team t;
					ss>>t.id;
					ss>>t.nameteams;
					ss>>t.teamaddress;
					teames.push_back(t);
			}
		//branch::AddBranch(branchname,branchadress,branchid);
	}
	while(playerfile.good())
	{
		int i=0;
		string line;
		getline(playerfile,line);
		if(line == "----------------------------------------------------------------")
		{
			i++;
			continue;
		}
		else
		{
			stringstream ss(line);
			player p;
			ss>>p.tname;
			ss>>p.id;
			ss>>p.nameplayer;
			ss>>p.position;
			ss>>p.salary;
			ss>>p.age;
			ss>>p.goal;
			ss>>p.day;
			ss>>p.mounth;
			ss>>p.year;
			teames[i].playeres.push_back(p);

		}

	}

}
void SaveInformation()
{
	ofstream teamfile("team file.txt",ios::app);
	ofstream playerfile("player file.txt",ios::app);	
	int i = 0;
	while(i != teames.size())
	{	
		teamfile<<teames[i].id<<" ";
		teamfile<<teames[i].nameteams<<" ";
		teamfile<<teames[i].teamaddress<<endl;
		teamfile<<"----------------------------------------------------------------"<<endl;
		i++;	
	}	
	i = 0;
	while(i != teames[i].playeres.size())
	{
		playerfile<<teames[i].playeres[i].tname<<" ";
		playerfile<<teames[i].playeres[i].id<<" ";
		playerfile<<teames[i].playeres[i].nameplayer<<" ";
		playerfile<<teames[i].playeres[i].position<<" ";
		playerfile<<teames[i].playeres[i].salary<<" ";
		playerfile<<teames[i].playeres[i].age<<" ";
		playerfile<<teames[i].playeres[i].goal<<" ";
		playerfile<<teames[i].playeres[i].day<<" ";
		playerfile<<teames[i].playeres[i].mounth<<" ";
		playerfile<<teames[i].playeres[i].year<<endl;
		
		i++;
		
	}
playerfile<<"----------------------------------------------------------------"<<endl;
	teamfile.close();
	playerfile.close();
}
void playergools()
{
	string nmply;
	cout << "Enter player name " <<endl;
	cin>> nmply;
	bool found = false;
	for(int i = 0 ; i < teames.size(); i++)
	{
		for(int j = 0;j<teames[i].playeres.size(); j++)
		{
			if(teames[i].playeres[j].nameplayer == nmply)
			{
				cout << " number of gool is ---->  " << teames[i].playeres[j].goal << endl;	
				found = true;
			}
		}
	}
	if(found == false )
		cout << " player not found " << endl;

}