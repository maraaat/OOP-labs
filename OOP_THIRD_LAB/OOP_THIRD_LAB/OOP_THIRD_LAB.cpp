#include <iostream>
#include <assert.h>
#include <windows.h>
#include <string>
using namespace std;

template <typename T>
class Container {
private:
	T* elements;
	int size; //size of container
public:
	Container() {
		size = 0;
		elements = new T[size];
	}
	Container(int size) {
		this->size = size;
		elements = new T[size]; // создание динамического массива типа шаблонной функции
		cout << "Write " << size << " elements:" << endl;
		for (int i = 0; i < size; i++) {
			T tmp;
			cin >> tmp;
			//cout << endl;
			elements[i] = tmp;
		}
	}
	Container(const Container& a) {
		size = a.size();
		elements = new T[size];
		for (int i = 0; i < size; i++) {
			elements[i] = a.elements[i];
		}
	}
	~Container() {
		delete[] elements;
	}

	void vyvod() {
		cout << "Container: ";
		for (int i = 0; i < size; i++) {
			cout << elements[i] << " ";
		}
		cout << endl;
	}

	void resize(int N) {
		T* tmp = elements;
		elements = new T[N];
		for (int i = 0; i < N && i<size; i++) {
			elements[i] = tmp[i];
		}
		size = N;
		delete[] tmp;
	}

	void addfront(const T& el) {
		T* tmp = elements;
		size += 1;
		elements = new T[size];
		elements[0] = el;
		for (int i = 1; i < size; i++) {
			elements[i] = tmp[i - 1];
		}
		delete[] tmp;

	}
	void add_N_elemenets(int N) {
		resize(size + N);
		cout << "Write " << N << " element(s): ";
		for (int i = 0; i < N; i++) {
			T tmp;
			cin >> tmp;
			elements[size - N + i] = tmp;
		}
	}
	void addback(const T &el) {
		resize(size + 1);
		elements[size - 1] = el;
	}
	void addinindex(int index, const T& el) {
		if (index >= size) addback(el);
		else if (index <= 0) addfront(el);
		else {
			T* tmp = elements;
			size += 1;
			elements = new T[size];
			for (int i = 0; i < index; i++) {
				elements[i] = tmp[i];
			}
			elements[index] = el;
			for (int i = index; i < size; i++) {
				elements[i + 1] = tmp[i];
			}
			delete[] tmp;
		}
		
	}

	T& getel(int index) {
		return elements[index];
	}

	int getsize() {
		return size;
	}

	void removeinindex(int index) {
		if (index >= size) {
			removeinindex(size-1);
		}
		else if (index <= 0) {
			removeinindex(0);
		}
		else {
			T* tmp = elements;
			size -= 1;
			elements = new T[size];
			for (int i = 0; i < index; i++) {
				elements[i] = tmp[i];
			}
			for (int i = index; i < size; i++) {
				elements[i] = tmp[i + 1];
			}
			delete[] tmp;
		}
	}
};



int main() {
	Container <int> chisla(5);
	chisla.vyvod();
	chisla.addback(15);
	chisla.vyvod();
	chisla.addfront(100);
	chisla.vyvod();
	int size = chisla.getsize();
	cout << "Size = " << size << endl;
	int el5 = chisla.getel(5);
	cout << "Element[5] = " << el5 << endl;
	chisla.addinindex(7, 1500);
	chisla.vyvod();
	chisla.removeinindex(1);
	chisla.vyvod();


	Container <string> animals(3);
	animals.vyvod();
	animals.addback("dog");
	animals.vyvod();
	animals.addfront("cat");
	animals.vyvod();
	int siz = animals.getsize();
	cout << "Size = " << siz << endl;
	// el5 = animals.getel(5);
	//cout << "Element[5] = " << el5 << endl;
	animals.addinindex(7, "1500");
	animals.vyvod();
	animals.removeinindex(1);
	animals.vyvod();

	animals.add_N_elemenets(2);
	animals.vyvod();
}