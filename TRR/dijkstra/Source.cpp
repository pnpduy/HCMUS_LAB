#ifdef _WIN32
#define _CRT_SECURE_NO_DEPRECATE
#endif

#include <iostream>
#include<fstream>
#include <cstdio>
#include <cstdlib>
#include <cassert>
#include <vector>
#include <queue>
using namespace std;
const int inf = 1000;
const int N = 100;
#define X first
#define Y second
typedef pair <int, int> ii;
typedef vector <ii> Vii;

int t , k, l, n, m;
Vii a[N];
int st, kt;
int d[N];
int path[N];



void Dijkstra(int st) {

	priority_queue <ii, Vii, greater <ii>> q;
	for (int i = 0; i <= n; i++)
	{
		d[i] = inf;
	}
	d[st] = 0;
	q.push({ 0, st });
	path[st] = -1;

	while (q.size())
	{
		int u = q.top().Y;
		int du = q.top().X;
		q.pop();

		if (du != d[u]) {
			continue;
		}

		for (int i = 0; i < a[u].size(); i++)
		{
			int v = a[u][i].Y;
			int dv = a[u][i].X;

			if (d[v] > du + dv)
			{
				d[v] = du + dv;
				q.push({ d[v], v });
				path[v] = u;
			}
		}
	}
}

void read_input(void) {
	ios_base::sync_with_stdio(false);
	cin.tie(NULL);
	cout.tie(NULL);

	freopen("input.txt", "r", stdin);
	freopen("output.txt", "w", stdout);

	int kt = 6;

	cin >> n >> m;
	for (int i = 0; i <= m; i++)
	{
		int u, v, w;
		cin >> u >> v >> w;
		a[u].push_back({ w , v });
		a[v].push_back({ w , u });
	}
	
	//cout << a.back();

	Dijkstra(1);
	cout << d[kt] << "\n";
	int way[N], cnt = 0;
	while (kt != -1)
	{
		way[++cnt] = kt;
		kt = path[kt];
	}

	for (int i = cnt; i >= 1; i--)
	{
		cout << way[i] << "->";
		
	}
}


int main() {
	read_input();
	return 0;
}