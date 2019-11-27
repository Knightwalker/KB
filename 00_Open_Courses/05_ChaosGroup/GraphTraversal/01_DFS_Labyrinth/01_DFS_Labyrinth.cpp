#include <iostream>
#include <chrono>
#include <thread>

using std::cout;
using std::endl;

class Labyrinth {
private:

	char maze[14][14]{
		{'*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*'},
		{'*', 's', ' ', ' ', ' ', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', '*'},
		{'*', ' ', '*', '*', '*', '*', ' ', '*', ' ', '*', ' ', ' ', ' ', '*'},
		{'*', ' ', '*', ' ', ' ', '*', ' ', '*', ' ', '*', ' ', '*', ' ', '*'},
		{'*', ' ', '*', ' ', '*', '*', '*', '*', ' ', '*', ' ', '*', '*', '*'},
		{'*', ' ', '*', ' ', '*', ' ', ' ', ' ', ' ', '*', ' ', ' ', ' ', '*'},
		{'*', ' ', '*', ' ', '*', ' ', '*', '*', '*', '*', '*', '*', ' ', '*'},
		{'*', ' ', '*', ' ', '*', ' ', '*', ' ', ' ', ' ', ' ', '*', ' ', '*'},
		{'*', ' ', ' ', ' ', ' ', ' ', '*', ' ', '*', '*', ' ', '*', ' ', '*'},
		{'*', ' ', '*', '*', '*', '*', '*', ' ', ' ', '*', ' ', '*', ' ', '*'},
		{'*', ' ', '*', ' ', ' ', ' ', '*', '*', ' ', '*', ' ', ' ', ' ', '*'},
		{'*', ' ', '*', ' ', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*'},
		{'*', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '*'},
		{'*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', 'e', '*'}
	};

	int steps = 0;

	void _findExit(int y, int x) {

		if (this->maze[y][x] == '*') {
			return; // there is a wall, no path ahead
		}

		if (this->maze[y][x] == '.') {
			return; // we have been here already, escape endless loop
		}

		if (maze[y][x] == 'e') {

			for (int i = 0; i < 14; i++)
			{
				for (int j = 0; j < 14; j++)
				{
					cout << maze[i][j] << " ";
				}
				cout << endl;
			}
			cout << endl;

			return;
		}

		this->maze[y][x] = '.'; // mark the visited cell

		this->_findExit(y - 1, x); // check up
		this->_findExit(y, x - 1); // check left
		this->_findExit(y, x + 1); // check right
		this->_findExit(y + 1, x); // check down

		this->maze[y][x] = ' '; // backtrack happens here

	}

public:

	void findExit() {
		this->_findExit(1, 1);
	}

};

int main()
{
	Labyrinth labyrinth;
	labyrinth.findExit();

}