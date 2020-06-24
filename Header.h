#pragma once
#include <iostream>
#include <string>
#include <windows.h>

using namespace std;

class Task 
{

public:   

    //launch server
    void information_server()
    {
        //get information about computer
        cout << "__________Server Information:" << endl;
        system("ipconfig");
    }


    void active_links()
    {
        // active links by TCP protocol
        cout << "__________active links with  TCP protocols:";
        system("netstat");
        
    }
    void getmac()
    {
        cout << "GETMAC OF SERVER OSO:";
        system("getmac");
    }

    //get link with another sever

    // Function to  enter of command
    void input_command()
    {
        string command;
        string go;
        
         //enter command
            cin >> command;
            if (command == "server_information") {
                //launch server
                 information_server();
                 cout << "go next?";
                 cin >> go;
                 if (go == "go")
                 {
                     input_command();
                 }
                 else {
                     cout << "\nServer job is over!";
                 }
            } 
            if (command == "active_links") {
                //show active links with TCP protocol
                active_links();
                cout << "go next?";
                cin >> go;
                if (go == "go")
                {
                    input_command();
                }
                else {
                    cout << "\nServer job is over!";
                }
            }
            if (command == "getmac")
            {
                getmac();
                cout << "go next?";
                cin >> go;
                if (go == "go")
                {
                    input_command();
                }
                else {
                    cout << "\nServer job is over!";
                }

            }
           
            
        
    }

    
};