#include <iostream>
#include <math.h>
#include <string>

#include "Boss.h"

using namespace std;

class ShootingGallery {
protected:
public:

    ShootingGallery() {
        cout << "ShootingGallery()" << endl;
    }

    virtual void Points() {}

    virtual bool isA(string classname) {
        return classname == "ShootingGallery";

    }

    virtual string classname() = 0;

    virtual ~ShootingGallery() {
        cout << "~ShootingGallery()" << endl;
    }

};


class Bear : public ShootingGallery {
public:
    string classname() override {
        return "Bear";
    }

    void Points() override {
        cout << "100 points - hunter" << endl;
    }

    bool isA(string classname) override {
        return classname == "Bear" || ShootingGallery::isA(classname);
    }

    virtual void CanTeachOthers() {
        cout << "He is very good sniper" << endl;
    }
};

class Chocolate :public ShootingGallery {
public:
    string classname() override {
        return "Chocolate";
    }

    void Points() override {
        cout << "Only 15 points" << endl;
    }

    bool isA(string classname) override {
        return classname == "Chocolate" || ShootingGallery::isA(classname);
    }
    void CantTeachOthers() {
        cout << "He isn't good sniper" << endl;
    }
};


class SuperGame : public Bear {
public:
    string classname() override {
        return "SuperGame";
    }

    void Points() override {
        cout << "He chose SuperGame" << endl;
    }
    bool isA(string classname) override {
        return classname == "SuperGame" || Bear::isA(classname);
    }
    void CanTeachOthers() override {
        cout << "He is a very good sniper, and play SuperGame" << endl;
    }
};

class Tester2 : public Boss {
public:


    ShootingGallery** generator() {

        int size = 10;
        ShootingGallery** Strikers = new ShootingGallery * [size];

        for (int i = 0; i < 10; i++) {
            int tmp = rand() % 3;
            if (tmp == 0)
                Strikers[i] = new Bear();
            else if (tmp == 1) {
                Strikers[i] = new Chocolate();
            }
            else
                Strikers[i] = new SuperGame();
        }
        return Strikers;
    }

    void dangercast(ShootingGallery* Shoot) {
        Bear* bear = static_cast<Bear*>(Shoot);
    }

    void Maker() override {
        ShootingGallery** Strikers = generator();
        for (int i = 0; i < 10; i++) {
            Strikers[i]->Points();
        }

        cout << endl << "STATIC CAST" << endl;

        for (int i = 0; i < 10; i++) {
            if (Strikers[i]->isA("Bear")) {
                static_cast<Bear*>(Strikers[i])->CanTeachOthers();
            }
            else if (Strikers[i]->isA("Chocolate")) {
                static_cast<Chocolate*>(Strikers[i])->CantTeachOthers();
            }
            else {
                cout << "Stop" << endl;
            }
        }

        cout << endl <<"DYNAMIC CAST" << endl;

        for (int i = 0; i < 10; i++) {
            SuperGame* sg = dynamic_cast<SuperGame*>(Strikers[i]);
            if (sg != nullptr) {
                sg->CanTeachOthers();
                continue;
            }

            Bear* bear = dynamic_cast<Bear*>(Strikers[i]);
            if (bear != nullptr) {
                bear->CanTeachOthers();
                continue;
            }

            Chocolate* choc = dynamic_cast<Chocolate*>(Strikers[i]);
            if (choc != nullptr) {
                choc->CantTeachOthers();
                continue;
            }

        }
        cout << "Break broke broken" << endl;
    }
};