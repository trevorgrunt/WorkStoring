#include <iostream> 
#include <fstream> 
#include <string> 
using namespace std;
bool IsLoggedIn()
{ 
	string username, password, un, pw;
	cout << "������� ��� ������������: "; cin >> username;
	cout << "������� ������: "; cin >> password;
	
	ifstream read("C:\ " + username + ".txt");
	getline(read, un);
	getline(read, pw);

	if (un == username && pw == password)
	{
		return true;
	}
	else
	{
		return false;
	}
}

int main()
{
	int choice;
	setlocale(LC_ALL, "Russian");
	cout << "1: Register\n2: Login\nYour choice: "; cin >> choice;
	if (choice == 1)
	{
		string username, password;
		
		cout << "�������� ��� ������������: "; cin >> username;
		cout << "�������� ������: "; cin >> password;

		ofstream file;  
		file.open("C:\ " + username + ".txt");
		file << username << endl << password;
		file.close();

		main();
	}
	else if (choice == 2)
	{
		bool status = IsLoggedIn();
		
		if (!status)
		{
			cout << "�������� �����!" << endl; 
			system("PAUSE");
			return 0;
		}
		else
		{
			cout << "������� ���� � �������!" << endl; 
			system("PAUSE"); 
			return 1;
		}
	}
	
}