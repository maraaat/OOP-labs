#include <iostream>
#include "First.h"
#include "Second.h"
#include "Third.h"
#include "Boss.h"
using namespace std;

int main()
{
    setlocale(LC_ALL, "Russian");
    Boss* ex1 = new Tester1();
    ex1->Maker();
    Boss* ex2 = new Tester2();
    ex2->Maker();
    Boss* ex3 = new Tester3();
    ex3->Maker();
}

