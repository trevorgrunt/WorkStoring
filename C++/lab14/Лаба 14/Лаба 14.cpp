#include <iostream>
#include <cstdlib>
#include <windows.h>
using namespace std;
struct office
{
    char FSurname[15];
    char FName[15];
    char FLastName[15];
    char FAdress[30];
    int Fnomer;
    int Fbirthday_year;
};
int main()
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    int n, i;
    bool key = true;
    office mas[10];
    cout << "Ввод данных в массив:" << endl;
    cout << "Введите количество записей: " << endl;
    cin >> n;
    for (i = 0;i < n;i++)
    {
        cout << "Введите фамилию: ";
        cin.get();
        cin.getline(mas[i].FSurname, 15);
        cout << "Введите имя: ";
        cin.getline(mas[i].FName, 15);
        cout << "Введите отчество: ";
        cin.getline(mas[i].FLastName, 15);
        cout << "Введите домашний адрес: ";
        cin.getline(mas[i].FAdress, 30);
        cout << "Введите номер участка: ";
        cin >> mas[i].Fnomer;
        cout << "Введите год рождения: ";
        cin >> mas[i].Fbirthday_year;
        while (mas[i].Fbirthday_year < 1900 || mas[i].Fbirthday_year>2000)
        {
            cout << "Введите заново год рождения: ";
            cin >> mas[i].Fbirthday_year;
        }
        cout << endl;
    }
    system("cls");
    cout << "Вывод массива на экран:" << endl;
    for (i = 0;i < n;i++)
    {
        cout << i + 1 << "\t" << mas[i].FSurname << "\t" << mas[i].FName[0] << "." << mas[i].FLastName[0] << "." << "\t" << mas[i].FAdress << "\t" << mas[i].Fnomer << "\t" << mas[i].Fbirthday_year << endl;
    }
    cout << endl;
    cout << "Вывод граждан родившихся до 1950 года" << endl;
    for (i = 0;i < n;i++)
    {
        if (mas[i].Fbirthday_year < 1950)
        {
            cout << i + 1 << "\t" << mas[i].FSurname << "\t" << mas[i].FName[0] << "." << mas[i].FLastName[0] << "." << "\t" << mas[i].FAdress << "\t" << mas[i].Fnomer << "\t" << mas[i].Fbirthday_year << endl;
            break;
            key = true;
        }
    }
    if (key == false)
    {

        cout << "Запись не соответствует поиску записи!" << endl;
    }
    cout << endl;
    cout << "Вывод граждан c номером участка 55" << endl;
    for (i = 0;i < n;i++)
    {
        if (mas[i].Fnomer == 55)
        {

            cout << i + 1 << "\t" << mas[i].FSurname << "\t" << mas[i].FName[0] << "." << mas[i].FLastName[0] << "." << "\t" << mas[i].FAdress << "\t" << mas[i].Fnomer << "\t" << mas[i].Fbirthday_year << endl;
            break;
            key = true;
        }
    }
    if (key == false)
    {
        cout << "Запись не соответствует поиску записи" << endl;
    }
    system("Pause");
    return 0;
}