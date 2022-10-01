#include <iostream>
#include <fstream>
#include <string>
#include <regex>

using namespace std;

#define objChecker check
#define objScraper scrape
#define itemCleaner clean

// functions
bool objChecker(string piece);                  // object checker
string objScraper(string chunk, string chisel); // object scraper
void itemCleaner(int item);                     // item cleaner

// configure global variables
const string ver = "v1.0.0";         // version
string transit_content;              // transit content
const string objDict[] = {"shell="}; // object dictionary

main()
{
    cout << " transit-operator\n DiscordRC " + ver + " by o7q\n\n";

    // process transit
    ifstream readTransit("transit_to");
    for (int i = 1; i <= 2; i++) getline(readTransit, transit_content);
    readTransit.close();
    for (size_t i = 0; i < sizeof(objDict) / sizeof(string); i++)
    {
        //size_t match_index = transit_content.find(objDict[i], 0);
        if (transit_content.find(objDict[i], 0) != string::npos)
        {
            if (check(objDict[0]) == true) system(scrape(transit_content, objDict[0]).c_str());
        }
    }

    clean(0);
    return 0;
}

// object checker function
bool objChecker(string piece)
{
    return strstr(transit_content.c_str(), piece.c_str()) ? true : false;
}

// object scraper function
string objScraper(string chunk, string junk)
{
    return regex_replace(chunk, regex(junk), "");
}

// item cleaner function
void itemCleaner(int item)
{
    const string objItem[] = {"transit_to", "transit_from"};
    system(("del \"" + objItem[item] + "\" /f 2> nul").c_str());
}