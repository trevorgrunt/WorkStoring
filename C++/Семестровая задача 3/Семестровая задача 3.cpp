#include <iostream>
#include <sstream>
#include <string>
#include <list>
#include <map>
#include <fstream>

int main()
{
    std::string str, reWrStr, result;

    std::ifstream file("C:\\text.txt"); // файл из которого читаем

    std::getline(file, str);

    file.close(); // обязательно закрываем файл что бы не повредить его

    for (int i = 0, len = str.size(); i < len; i++)
    {
        // проверяем, является ли символ разбора пунктуацией или нет
        if (ispunct(str[i]))
        {
            str.erase(i--, 1);
            len = str.size();
        }
    }

    std::istringstream istr(str); // Поток для работы со строкой

    std::multimap<std::string, int> strMultimap; // Ассоциативный массив, multimap может хранить дублировавшие ключи 
    // поэтому используется не просто map

    int count = 0; // Счетчик 
    std::list <std::string> outList{}; // Инициализация списка
    while (istr >> reWrStr)
    {
        if (reWrStr.length() > 3) // Условие на длину слова больше 3х
        {
            strMultimap.emplace(reWrStr, count); // Добавляем слово в качестве ключа, а счетчик в качестве значения
            outList.emplace_back(reWrStr); // Добавляем слово в конец списка
            count++;
        }
    }

    outList.sort(); 

    outList.unique(); // Удаляем дубликаты
    int listSize = outList.size();
    for (listSize; listSize > 0; listSize--)
    {
        std::cout << strMultimap.count(outList.front()) << " " << outList.front() << std::endl;
        // В outlist.front происходит вызов первого элемента в списке после чего этот элемент передаётся в другую функцию
        // которая возвращает значение того, сколько он насчитал слов которое было в списке
        // << " " << outList.front() << std::endl; - Пробел +  опять вызываем первый элемент списка
        outList.pop_front(); // Удаляем элемент из списка
    }

    return 0;
}
