#include <iostream>
#include <math.h>

using namespace std;

class Vector {

protected:
    int x, y;
    double dlina;
public:

    Vector() {
        cout << "Zero vector" << endl;;
        x = y = 0;
        printf_s("Vector = { %d ; %d }\n", x, y);
    }

    Vector(int x1, int y1, int x2, int y2) {
        x = x2 - x1;
        y = y2 - y1;
        printf_s("Vector = { %d ; %d }\n", x, y);
    }

    Vector(const Vector &a) {
        x = a.x;
        y = a.y;
        printf_s("Vector = { %d ; %d }\n", x, y);
    }
    
    ~Vector() {
        printf_s("Vector {%d ; %d} is deleted\n", x ,y);
    }

    void length() {
        dlina = sqrt(pow(x, 2) + pow(y, 2));
        cout << "Length = " << dlina << endl;
    }

    void add(const Vector& a) {
        printf_s("Vector 1 + Vector 2 = { %d ; %d }\n", x + a.x, y + a.y);
    }
    void reset();
};
void Vector::reset() {
    x = 0; y = 0;
}


class ColoredVector: public Vector {
protected:
    int color;
public:

    ColoredVector():Vector() {
        printf_s("ColoredVector = { %d ; %d }\n", x, y);
        color = 0;
    }

    ColoredVector(int x1, int y1, int x2, int y2, int color):Vector(x1, y1, x2, y2) {
        this->color = color;
        printf_s("ColoredVector = { %d ; %d }\n", x, y);
    }

    ColoredVector(const ColoredVector &a){
        color = a.color;
        x = a.x;
        y = a.y;
        printf_s("Vector { %d ; %d } Color = %d\n", x, y, color);
    }

    ~ColoredVector() {
        printf_s("{ %d ; %d } color = %d\n", x, y, color);
    }

    void length() {
        dlina = sqrt(pow(x, 2) + pow(y, 2));
        cout << "Length = " << dlina << endl;
    }

    void add(const ColoredVector& a) {
        printf_s("ColoredVector 1 + ColoredVector 2 = { %d ; %d }", x + a.x, y + a.y);
    }

    void ChangeColor(int clr) {
        color = clr;
    }
};

class VectorToSection
{

protected:
    Vector* ab;
    Vector* cd;
public:

    VectorToSection() {
        printf_s("Creating zero section\n");
        ab = new Vector;
        cd = new Vector;

    }

    VectorToSection(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4) {
        cout << "Creating section from coord: " << endl;
        ab = new Vector( x1,  y1,  x2,  y2);
        cd = new Vector( x3,  y3,  x4,  y4);
        printf_s("Vector = ( %d ; %d ) ( %d ; %d )\n", x2-x1, y2-y1, x4-x3, y4-y3);
    }

    VectorToSection(const VectorToSection& a) {
        /*ab = a.ab;
        cd = a.cd;*/
        cout << "Creating copy section" << endl;
        ab = new Vector(*(a.ab));
        cd = new Vector(*(a.cd));

       // printf_s("Vector = { %d ; %d }\n");
    }

    ~VectorToSection() {
        delete ab;
        delete cd;
        cout << "VectorToSection is deleted" << endl;
    }
};

int main()
{
    ///// static objects /////

    cout << "Static" << endl;
    Vector ab;
    Vector cd(1, 2, 3, 4);
    Vector ef(cd); //констр копирования
    cd.length();
    ef.add(cd);  

    cout << "Dynamic" << endl;
    ////// dynamic objects /////

    Vector* qw = new Vector;
    Vector* er = new Vector(1, 2, 3, 4);
    Vector* ty = new Vector(*er);
    er->length();
    ty->add(*er);
    ty->reset();
    cout << "Delete Dynamic" << endl;

    delete qw;
    delete er; 
    delete ty;
    
    ///// daughter class /////
    
    cout << "Creating a daughter class" << endl; 
    ColoredVector* qz = new ColoredVector(1, 2, 3, 9, 6);
    ColoredVector* ww = new ColoredVector(1, 3, 1, 0, 5);
    qz->length();
    qz->add(*ww);
    cout << endl << "Delete a daughter classes" << endl;
    delete qz;
    delete ww;

    //Set in base class daughter class
    cout << "Set in base class daughter class" << endl;
    Vector* aa = new ColoredVector(1, 5, 7, 2, 1);
    ColoredVector* bb = new ColoredVector(1, 2, 3, 2, 1);
    delete aa;
    delete bb;
     
    cout << "Composition" << endl;
    VectorToSection* ee = new VectorToSection;
    VectorToSection* rr = new VectorToSection(4, 5, 3, 1, 5, 9, 7, 2);
    VectorToSection* tt = new VectorToSection(*rr);
    VectorToSection* yy = new VectorToSection(1,2,3,4,5,6,7,8);

    delete ee;
    delete rr;
    delete tt;
    delete yy;
}
