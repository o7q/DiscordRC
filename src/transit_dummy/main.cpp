#include <iostream>

using namespace std;

void dummyLoop();

main()
{
    dummyLoop();
    return 1;
}

void dummyLoop()
{
    cin.get();
    dummyLoop();
}