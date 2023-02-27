#include <iostream>
#include <math.h>

using namespace std;

class Vector {

protected:
    int x, y;
    double dlina;
public:

    Vector() {
        cout << "Vector" << endl;;
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
        cout << "Bye Vector" << endl;
    }

    void length() {
        dlina = sqrt(pow(x, 2) + pow(y, 2));
        cout << "Length = " << dlina << endl;
    }

    void add(const Vector& a) {
        printf_s("Vector 1 + Vector 2 = { %d ; %d }", x + a.x, y + a.y);
    }
};


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
        cout << "Creating section: " << endl;
        ab = new Vector;
        cd = new Vector;

    }

    VectorToSection(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4) {
        cout << "Creating section: " << endl;
        ab = new Vector( x1,  y1,  x2,  y2);
        cd = new Vector( x3,  y3,  x4,  y4);
        printf_s("Vector = ( %d ; %d ) ( %d ; %d )\n", x2-x1, y2-y1, x4-x3, y4-y3);
    }

    VectorToSection(const VectorToSection& a) {
        /*ab = a.ab;
        cd = a.cd;*/
        cout << "Creating section" << endl;
        ab = new Vector(*(a.ab));
        cd = new Vector(*(a.cd));

       // printf_s("Vector = { %d ; %d }\n");
    }

    ~VectorToSection() {
        delete ab;
        delete cd;
        cout << "Bye VectorToPoint" << endl;
    }
};


int main()
{
//    //static
//    Vector ab;
//    Vector cd(1, 2, 3, 4);
//    Vector ef(cd);
//    cd.length();
//    ef.add(cd);
//    //dynamic
//    Vector *qw = new Vector;
//    Vector *er = new Vector(1, 2, 3, 4);
//    Vector* ty = new Vector(*er);
//
//    delete qw;
//    delete er; 
//    delete ty;
      
  //  ColoredVector* ab = new ColoredVector(1, 2, 3, 4, 6);
 
  //  delete ab;


    VectorToSection* ab = new VectorToSection;
    VectorToSection* cd = new VectorToSection(*ab);
    VectorToSection* ef = new VectorToSection(1,2,3,4,5,6,7,8);
    delete ab;
    delete cd;
    delete ef;
}
