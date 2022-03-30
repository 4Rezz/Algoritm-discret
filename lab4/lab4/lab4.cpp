#include <iostream>
#include <string>
#include <iomanip>
#include <algorithm>
#include <vector>

using namespace std;

void Permutation(int n) {
    int* i = new int[n];
    for (int k = 0; k < n; k++)
    {
        i[k] = k + 1;
    }
    sort(i, i + n);
    do {
        for (int k = 0; k < n; k++)
        {
            cout << i[k] << " ";
        }
        cout << endl;
    } while (next_permutation(i, i + n));
}

void Combination(int n, int r)
{
    vector<bool> a(n); //Масив Селекторів

    fill(a.begin(), a.begin() + r, true);


    cout << "Combination with " << n << " to " << r << ":" << endl;
    do {
        for(int i = 0; i < n; ++i)
            if (a[i]) {
                cout << (i + 1) << " ";
            }
        cout << endl;
    } while (prev_permutation(a.begin(), a.end()));
}

int main()
{
    int n = 0;
    unsigned int r = 0;
    cout << "Task 1:" << endl;
    cout << "n = "; cin >> n;
    Permutation(n);
    cout << " Task 2:" << endl;
    cout << " en = "; cin >> n;
    cout << " er (er <= en) = "; cin >> r;
    Combination(n, r);
}
