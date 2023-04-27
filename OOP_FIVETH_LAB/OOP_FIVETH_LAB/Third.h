#pragma once
#include <iostream>
#include <math.h>
#include <string>

#include "Boss.h"

using namespace std;

class Base {
private:
    int number = 0;
public:
    Base() {
        cout << "Base()" << endl;
    };

    Base(int obj) {
        this->number = obj;
        cout << "Base(int(obj))" << endl;
    };

    Base(Base *obj) {
        cout << "Base(Base *obj)" << endl;
    };

    Base(const Base &obj) {
        cout << "Base(Base& obj)" << endl;
    };

    virtual bool isA(string classname) {
        return classname == "Base";
    }

    void SetNumber(int N) {
        this->number = N;
    }

    int GetNumber() {
        return number;
    }

    virtual ~Base() {
        cout << "~Base" << endl;
    };
};

class Desc : public Base {
private:
    int N = 0;
public:
    Desc() {
        cout << "Desc()" << endl;
    };

    Desc(int obj) {
        this->N = obj;
        cout << "Desc(int(obj))" << endl;
    };

    Desc(Desc* obj) {
        cout << "Desc(Desc *obj)" << endl;
    };

    Desc(const Desc& obj) {
        cout << "Desc(Desc& obj)" << endl;
    };

    bool isA(string classname) {
        return classname == "Desc" || Base::isA(classname);
    }

    ~Desc() override {
        cout << "~Desc" << endl;
    };
};



class Tester3 : public Boss {
public:

    void func1(Base base) {
        cout << "func1(int(obj))" << endl;
        cout << "Desc? " << base.isA("Desc") << endl;
    };

    void func2(Base* base) {
        cout << "func2(Base* obj)" << endl;
        cout << "Desc? " << base->isA("Desc") << endl;
    };

    void func3(Base& base) {
        cout << "func3(Base& obj)" << endl;
        cout << "Desc? " << base.isA("Desc") << endl;
    };

    //STATIC

    Base f1() {
        cout << "f1()" << endl;
        Base obj;
        return obj;
    }

    Base* f2() {
        cout << "f2()" << endl;
        Base obj;
        return &obj; 
    }

    Base& f3() {
        cout << "f3()" << endl;
        Base obj;
        return obj;
    }

    //DYNAMIC

    Base f4() {
        cout << "f4()" << endl;
        Base* obj = new Base();
        return *obj;
    }

    Base *f5() {
        cout << "f5()" << endl;
        Base* obj = new Base();
        return obj;
    }

    Base& f6() {
        cout << "f6()" << endl;
        Base* obj = new Base();
        return *obj;
    }

    //Unique ptr

    unique_ptr<Base> uniq1(unique_ptr<Base> smth) {
        smth->SetNumber(5);
        return move(smth); //вернули объект из функции
    }

    void uniq2(unique_ptr<Base> smth) {
        smth->SetNumber(25);
        return; 
    } //объект удалится, т.к. вышли из зоны видимости


    //Shared ptr

    shared_ptr<Base> shar1(int N) {
        shared_ptr<Base> smth = make_shared<Base>(N);
        return smth;
    }

    void shar2(shared_ptr<Base> smth) {
        smth->SetNumber(250);
    }

    void Maker() override {

        //Передача объектов в функцию 
        cout << "Send objects in functions" << endl << endl;
        cout << "Base objects:" << endl;
        Base* obj = new Base();
        func1(*obj); //создается копия объекта, при выходе из ф-ии копия уничтожается
        func2(obj); //ф-я работает с исходным объектом
        func3(*obj);//ф-я работает с исходным объектом
        delete obj;
        cout << endl << endl;

        cout << "Desc objects:" << endl;
        Desc* obj2 = new Desc();
        func1(*obj2); //создается копия объекта, при выходе из ф-ии копия уничтожается
        func2(obj2); //ф-я работает с исходным объектом
        func3(*obj2); //ф-я работает с исходным объектом
        delete obj2;

        cout << endl << endl << "Create and return" << endl;

        //возврат объектов
        {
            cout << endl << "Static objects:" << endl;
            //в функции создается локальный объект, а при выходе - уничтожается
            Base ob1 = f1();
            //в функции создается локальный объект, перед выходом - уничтожается.
            //в переменную об2 передается адрес объекта (уничтоженного)
            Base ob2 = f2();
            //в функции создается локальный объект, перед выходом - уничтожается.
            //но ему назначается новое имя об3, при обращении к об3 будет обращение к чужой памяти
            Base ob3 = f3();
        }
        //Dynamic
        {
            cout << endl << "Dynamic objects:" << endl;
            //динамически в функции создается объект, копируется в об4,
            // и выходим из функции с утечкой памяти из-за созданного объекта
            Base ob4 = f4();
            //создается динамический объект в функции и его адрес возвращается и помещается в об5
            Base* ob5 = f5();
            delete ob5;
            //создается динамический объект в функции и его имя назначается ссылке об6 после выхода из функции
            Base& ob6 = f6();
            delete &ob6;

            
        }

        //Unique ptr
        cout << endl << endl << "unique_ptr" << endl << endl;
        {
            unique_ptr<Base> hi = make_unique<Base>(10);
            cout << hi->GetNumber() << endl;
            uniq2(move(hi));
            // cout << hi->GetNumber() << endl; //не работает, т.к. объект удален
            unique_ptr<Base> hi2 = make_unique<Base>(15);
            cout << hi2->GetNumber() << endl;
            hi2 = uniq1(move(hi2));
            cout << hi2->GetNumber() << endl;

            uniq2(move(hi2)); //удалим hi2
        }
        // Shared ptr
        cout << endl << "shared_ptr" << endl << endl;
        {
            shared_ptr<Base> p = make_shared<Base>(1);
            cout << p->GetNumber() << endl;
            shar2(p);
            cout << p->GetNumber() << endl;
        } 
        {
            shared_ptr<Base> p2 = shar1(15);
            cout << p2->GetNumber() << endl;
        }
    }

};