#include <iostream>
#include "First.h"
#include "Second.h"
#include "Third.h"
#include "Boss.h"
using namespace std;

int main()
{
    setlocale(LC_ALL, "Russian");
    /*Boss* part1 = new Tester2();
    part1->Maker();*/

    Boss* ex = new Tester3();
    ex->Maker();
}

