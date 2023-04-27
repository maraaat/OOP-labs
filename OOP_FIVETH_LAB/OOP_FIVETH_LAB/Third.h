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
        return move(smth); //������� ������ �� �������
    }

    void uniq2(unique_ptr<Base> smth) {
        smth->SetNumber(25);
        return; 
    } //������ ��������, �.�. ����� �� ���� ���������


    //Shared ptr

    shared_ptr<Base> shar1(int N) {
        shared_ptr<Base> smth = make_shared<Base>(N);
        return smth;
    }

    void shar2(shared_ptr<Base> smth) {
        smth->SetNumber(250);
    }

    void Maker() override {

        //�������� �������� � ������� 
        cout << "Send objects in functions" << endl << endl;
        cout << "Base objects:" << endl;
        Base* obj = new Base();
        func1(*obj); //��������� ����� �������, ��� ������ �� �-�� ����� ������������
        func2(obj); //�-� �������� � �������� ��������
        func3(*obj);//�-� �������� � �������� ��������
        delete obj;
        cout << endl << endl;

        cout << "Desc objects:" << endl;
        Desc* obj2 = new Desc();
        func1(*obj2); //��������� ����� �������, ��� ������ �� �-�� ����� ������������
        func2(obj2); //�-� �������� � �������� ��������
        func3(*obj2); //�-� �������� � �������� ��������
        delete obj2;

        cout << endl << endl << "Create and return" << endl;

        //������� ��������
        {
            cout << endl << "Static objects:" << endl;
            //� ������� ��������� ��������� ������, � ��� ������ - ������������
            Base ob1 = f1();
            //� ������� ��������� ��������� ������, ����� ������� - ������������.
            //� ���������� ��2 ���������� ����� ������� (�������������)
            Base ob2 = f2();
            //� ������� ��������� ��������� ������, ����� ������� - ������������.
            //�� ��� ����������� ����� ��� ��3, ��� ��������� � ��3 ����� ��������� � ����� ������
            Base ob3 = f3();
        }
        //Dynamic
        {
            cout << endl << "Dynamic objects:" << endl;
            //����������� � ������� ��������� ������, ���������� � ��4,
            // � ������� �� ������� � ������� ������ ��-�� ���������� �������
            Base ob4 = f4();
            //��������� ������������ ������ � ������� � ��� ����� ������������ � ���������� � ��5
            Base* ob5 = f5();
            delete ob5;
            //��������� ������������ ������ � ������� � ��� ��� ����������� ������ ��6 ����� ������ �� �������
            Base& ob6 = f6();
            delete &ob6;

            
        }

        //Unique ptr
        cout << endl << endl << "unique_ptr" << endl << endl;
        {
            unique_ptr<Base> hi = make_unique<Base>(10);
            cout << hi->GetNumber() << endl;
            uniq2(move(hi));
            // cout << hi->GetNumber() << endl; //�� ��������, �.�. ������ ������
            unique_ptr<Base> hi2 = make_unique<Base>(15);
            cout << hi2->GetNumber() << endl;
            hi2 = uniq1(move(hi2));
            cout << hi2->GetNumber() << endl;

            uniq2(move(hi2)); //������ hi2
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