#include <iostream>
#include <math.h>
#include <string>

#include "Boss.h"

using namespace std;

class ShootingGallery2 {
public:

    ShootingGallery2() {
        cout << "ShootingGallery()" << endl;
    }

    void GoodHit() {
        cout << "Goodhit" << endl;
    }

    void Zero() {
        cout << "Zero points" << endl;
        GoodHit();
    }

    void TopPoints() {
        cout << "TopPoints" << endl;
        Points();
    }

    virtual void Points() {
        cout << "Points" << endl;
    }

    void NoVirtual() {
        cout << "NoVirtual" << endl;
    }

    virtual void Virtual() {
        cout << "Virtual" << endl;
    }

    virtual ~ShootingGallery2() {
        cout << "~ShootingGallery()" << endl;
    }

};

class PriceList2 : public ShootingGallery2 {
protected:
    int* tmpPrices;
public:

    PriceList2() {
        tmpPrices = new int[15];
        cout << "PriceList()" << endl;
    }

    void GoodHit() {
        cout << "PriceList: GoodHit" << endl;
    }

    void Points() override {
        cout << "PriceList: Points" << endl;
    }

    void NoVirtual() {
        cout << "PriceList: Novirtual" << endl;
    }

    void Virtual() override{
        cout << "PriceList: Virtual" << endl;
    }

    ~PriceList2() {
        delete tmpPrices;
        cout << "~PriceList()" << endl;
    }
};




class Tester1 : public Boss {
public:
    void Maker() {
        PriceList2* shoot = new PriceList2();
       
        cout << endl << "����� ����������������� �������������� ������" << endl;
        shoot->Zero(); //����� ����������������� �������������� ������

        cout << endl << "����� ����������������� ������������ ������" << endl;
        shoot->TopPoints(); //����� ����������������� ������������ ������
        cout << endl;
        delete shoot;

        cout << endl;

        ShootingGallery2 * fshoot = new PriceList2();
        PriceList2* sshoot = new PriceList2();
        cout << endl << "� ������� ������ ����� �������������, � � ������� � ����� �� ������" << endl;

        fshoot->NoVirtual();
        cout << endl;

        sshoot->NoVirtual();
        cout << endl << "� ������� ������ ����� �����������, � � ������� � ����� �� ������" << endl;

        fshoot->Virtual();
        cout << endl;

        sshoot->Virtual();
        cout << endl;

        delete sshoot;
        delete fshoot;
    }

    
};