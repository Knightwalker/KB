#include <iostream>
using namespace std;

int main() {
  int x1 = 0;
  int x2 = 0;
  cin >> x1 >> x2;

  if (x1 < x2) {
    cout << x1 << " " << x2 << endl;
  } else {
    cout << x2 << " " << x1 << endl;
  }
}