#include <iostream>
#include <string>
#include <iomanip>

using namespace std;

void placeit(int n, int r) {
	int A = 0;
	int p1 = 1;
	int p2 = 1;
	for (int i = 1; i <= n; i++) {
		p1 *= i;
	}
	for (int i = 1; i <= n - r; i++) {
		p2 *= i;
	}
	A = p1 / p2;
	cout << A << endl;
}

void stirlinh(int en) {
	const int num = 8;

	cout << "Stirling Numbers:" << endl;
	int stirArray[num][num];
	for (int n = 0; n < num; n++) {
		for (int k = 0; k < num; k++) {
			if (k == 0) {
				stirArray[n][k] = 0;
			}
			else if (k == n) {
				stirArray[n][k] = 1;
			}
			else if (n == 0 && k == 0) {
				stirArray[n][k] = 1;
			}
			else if (k > n) {
				stirArray[n][k] = 0;
			}
			else {
				stirArray[n][k] = stirArray[n - 1][k - 1] + k * stirArray[n - 1][k];
			}
		}
	}
	for (int n = 0; n < num; n++) {
		for (int k = 0; k < num; k++) {
			cout << stirArray[n][k] << ' ';
		}
		cout << endl;
	}
	cout << endl;

	cout << "Bell:" << endl;
	int bArray[num] = { 0 };
	for (int n = 0; n < num; n++) {
		for (int k = 0; k < num; k++) {
			if (k > n) {
				break;
			}
			else {
				bArray[n] += stirArray[n][k];
			}
		}
	}
	for (int n = 0; n < num; n++) {
		cout << bArray[n] << endl;
	}
}

int main()
{
	int n = 5;
	int r = 3;

	cout << "Placement:" << endl;
	placeit(n, r);
	cout << endl << endl << endl;

	int en = 2 + 5 + 1;

	stirlinh(en);
}
