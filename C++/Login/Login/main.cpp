#include <iostream> 
#include <fstream> 
#include <string> 
using namespace std;
bool IsLoggedIn()
{ 
	string username, password, un, pw;
	cout << "Введите имя пользователя: "; cin >> username;
	cout << "Введите пароль: "; cin >> password;
	
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
		
		cout << "Выберите имя пользователя: "; cin >> username;
		cout << "Выберите пароль: "; cin >> password;

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
			cout << "Неверный логин!" << endl; 
			system("PAUSE");
			return 0;
		}
		else
		{
			cout << "Удачный вход в систему!" << endl; 
			system("PAUSE"); 
			return 1;
		}
	}
	
}