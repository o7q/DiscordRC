#include <iostream>
#include <fstream>
#include <regex>

using namespace std;

// configure global variables
string ver = "v1.0.0"; // version

main()
{
    cout << " transit-operator\n DiscordRC " + ver + " by o7q\n\n";

    string transit_content;
    ifstream readTransit("transit");
    for (int i = 1; i <= 2; i++) getline(readTransit, transit_content);
    readTransit.close();

    size_t found_index = transit_content.find("shell=", 0);
    if (found_index != string::npos)
    {
        string shell = regex_replace(transit_content, regex("shell="), "");
        system(shell.c_str());
    }

    system("del \"transit\" /f 2> nul");

    return 0;
}