//#include <iostream>
//#include <assert.h>
//#include <windows.h>
//#include <string>
//#include <time.h>
//#include <chrono>
//using namespace std;
//
//template <typename T>
//class Container {
//private:
//	T* elements;
//	int size; //size of container
//public:
//	Container() {
//		size = 0;
//		elements = new T[size];
//	}
//	Container(int size) {
//		this->size = size;
//		elements = new T[size]; // создание динамического массива типа шаблонной функции
//		cout << "Write " << size << " elements:" << endl;
//		for (int i = 0; i < size; i++) {
//			T tmp;
//			cin >> tmp;
//			//cout << endl;
//			elements[i] = tmp;
//		}
//	}
//	Container(const Container& a) {
//		size = a.size();
//		elements = new T[size];
//		for (int i = 0; i < size; i++) {
//			elements[i] = a.elements[i];
//		}
//	}
//	~Container() {
//		delete[] elements;
//	}
//
//	void vyvod() {
//		cout << "Container: ";
//		for (int i = 0; i < size; i++) {
//			cout << elements[i] << " ";
//		}
//		cout << endl;
//	}
//
//	void resize(int N) {
//		T* tmp = elements;
//		elements = new T[N];
//		for (int i = 0; i < N && i<size; i++) {
//			elements[i] = tmp[i];
//		}
//		size = N;
//		delete[] tmp;
//	}
//
//	void addfront(const T& el) {
//		T* tmp = elements;
//		size += 1;
//		elements = new T[size];
//		elements[0] = el;
//		for (int i = 1; i < size; i++) {
//			elements[i] = tmp[i - 1];
//		}
//		delete[] tmp;
//
//	}
//	void add_N_elemenets(int N) {
//		resize(size + N);
//		cout << "Write " << N << " element(s): ";
//		for (int i = 0; i < N; i++) {
//			T tmp;
//			cin >> tmp;
//			elements[size - N + i] = tmp;
//		}
//	}
//	void addback(const T &el) {
//		resize(size + 1);
//		elements[size - 1] = el;
//	}
//	void addinindex(int index, const T& el) {
//		if (index > size) addback(el);
//		else if (index < 0) addfront(el);
//		else {
//			T* tmp = elements;
//			size += 1;
//			elements = new T[size];
//			for (int i = 0; i < index; i++) {
//				elements[i] = tmp[i];
//			}
//			elements[index] = el;
//
//			for (int i = index+1; i < size; i++) {
//				elements[i] = tmp[i-1];
//			}
//			delete[] tmp;
//		}
//		
//	}
//
//	T& getel(int index) {
//		return elements[index];
//	}
//
//	int getsize() {
//		return size;
//	}
//
//	void removeinindex(int index) {
//		if (size==0) {
//			size = 0;
//		}
//		else if (index <= 0 && size==0) {
//			index = 0;
//		}
//		else if (index < 0) {
//			removeinindex(0);
//		}
//		else if (index >= size) {
//			removeinindex(size - 1);
//		}
//
//		else {
//			T* tmp = elements;
//			size -= 1;
//			elements = new T[size];
//			for (int i = 0; i < index; i++) {
//				elements[i] = tmp[i];
//			}
//			for (int i = index; i < size; i++) {
//				elements[i] = tmp[i + 1];
//			}
//			delete[] tmp;
//		}
//	}
//};
//
//
//
//int main() {
//	//Container <int> chisla(5);
//	//chisla.vyvod();
//	//chisla.addback(15);
//	//chisla.vyvod();
//	//chisla.addfront(100);
//	//chisla.vyvod();
//	//int size = chisla.getsize();
//	//cout << "Size = " << size << endl;
//	//int el5 = chisla.getel(5);
//	//cout << "Element[5] = " << el5 << endl;
//	//chisla.addinindex(7, 1500);
//	//chisla.vyvod();
//	//chisla.removeinindex(1);
//	//chisla.vyvod();
//
//
//	//Container <string> animals(3);
//	//animals.vyvod();
//	//animals.addback("dog");
//	//animals.vyvod();
//	//animals.addfront("cat");
//	//animals.vyvod();
//	//int siz = animals.getsize();
//	//cout << "Size = " << siz << endl;
//	//// el5 = animals.getel(5);
//	////cout << "Element[5] = " << el5 << endl;
//	//animals.addinindex(7, "1500");
//	//animals.vyvod();
//	//animals.removeinindex(1);
//	//animals.vyvod();
//
//	//animals.add_N_elemenets(2);
//	//animals.vyvod();
//	srand(time(NULL));
//
//	Container <int> chisla;
//
//	int counter = 0;
//
//	double time_spent = 0.0;
//	clock_t begin = clock();
//
//	while (counter != 100) {
//		int tmp = rand() % 4 ;
//		if (tmp == 0) {
//			chisla.addback(rand());
//		}
//		else if (tmp == 1) {
//			chisla.addfront(rand());
//		}
//		else if (tmp == 2) {
//			chisla.addinindex(rand() % (chisla.getsize()+1), rand());
//		}
//		else if (tmp == 3) {
//			chisla.removeinindex(rand() % (chisla.getsize()+1));
//		}
//		counter++;
//	}
//	clock_t end = clock();
//	time_spent += (double)(end - begin) / CLOCKS_PER_SEC;
//	printf("The elapsed time is %f seconds in 100 actions\n", time_spent);
//	
//
//
//
//
//	Container <int> chisl;
//
//	counter = 0;
//
//	time_spent = 0.0;
//	begin = clock();
//
//	while (counter != 1000) {
//		int tmp = rand() % 4;
//		if (tmp == 0) {
//			chisl.addback(rand());
//		}
//		else if (tmp == 1) {
//			chisl.addfront(rand());
//		}
//		else if (tmp == 2) {
//			chisl.addinindex(rand() % (chisl.getsize() + 1), rand());
//		}
//		else if (tmp == 3) {
//			chisl.removeinindex(rand() % (chisl.getsize() + 1));
//		}
//		counter++;
//	}
//	end = clock();
//	time_spent += (double)(end - begin) / CLOCKS_PER_SEC;
//	printf("The elapsed time is %f seconds in 1000 actions\n", time_spent);
//
//
//
//
//	Container <int> chis;
//
//	counter = 0;
//
//	time_spent = 0.0;
//	begin = clock();
//
//	while (counter != 10000) {
//		int tmp = rand() % 4;
//		if (tmp == 0) {
//			chis.addback(rand());
//		}
//		else if (tmp == 1) {
//			chis.addfront(rand());
//		}
//		else if (tmp == 2) {
//			chis.addinindex(rand() % (chis.getsize() + 1), rand());
//		}
//		else if (tmp == 3) {
//			chis.removeinindex(rand() % (chis.getsize() + 1));
//		}
//		counter++;
//	}
//	end = clock();
//	time_spent += (double)(end - begin) / CLOCKS_PER_SEC;
//	printf("The elapsed time is %f seconds in 10000 actions\n", time_spent);
//}



#include <iostream>
#include <assert.h>
#include <windows.h>
#include <string>
#include <time.h>
#include <chrono>
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
		for (int i = 0; i < N && i < size; i++) {
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
	void addback(const T& el) {
		resize(size + 1);
		elements[size - 1] = el;
	}
	void addinindex(int index, const T& el) {
		if (index > size) addback(el);
		else if (index < 0) addfront(el);
		else {
			T* tmp = elements;
			size += 1;
			elements = new T[size];
			for (int i = 0; i < index; i++) {
				elements[i] = tmp[i];
			}
			elements[index] = el;

			for (int i = index + 1; i < size; i++) {
				elements[i] = tmp[i - 1];
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
		if (size == 0) {
			size = 0;
		}
		else if (index <= 0 && size == 0) {
			index = 0;
		}
		else if (index < 0) {
			removeinindex(0);
		}
		else if (index >= size) {
			removeinindex(size - 1);
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

void tester(int N) {

	srand(time(NULL));
	Container <int> chisla;

	int counter = 0;

	double time_spent = 0.0;
	clock_t begin = clock();

	while (counter != N) {
		int tmp = rand() % 4;
		if (tmp == 0) {
			chisla.addback(rand());
		}
		else if (tmp == 1) {
			chisla.addfront(rand());
		}
		else if (tmp == 2) {
			chisla.addinindex(rand() % (chisla.getsize() + 1), rand());
		}
		else if (tmp == 3) {
			chisla.removeinindex(rand() % (chisla.getsize() + 1));
		}
		counter++;
	}
	clock_t end = clock();
	time_spent += (double)(end - begin) / CLOCKS_PER_SEC;
	printf("The elapsed time is %f seconds in %d actions\n", time_spent, N);


}

int main() {
	tester(100);
	tester(1000);
	tester(10000);
	
}