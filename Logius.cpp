// Logius.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <string>
#include "Header.h"

using namespace std;

int main()
{    
    string user_commands[] = {"active_links","server_information","getmac"};

    cout << "__________SERVER OSO v1.0_________" << endl;
    cout <<"\n\nSERVER COMMANDS"<< endl;
    cout << user_commands[0] << endl;
    cout << user_commands[1] << endl;
    cout << user_commands[2] << endl;


    Task desk;
    desk.input_command();
}
