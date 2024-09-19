#ifdef _WIN32
#define _CRT_SECURE_NO_DEPRECATE
#endif

#include <iostream>
#include <vector>

#define MAX 100
#define Inf 99999

using namespace std;

int A[MAX][MAX];
int Min[MAX];
int B[MAX];
bool C[MAX];

int T, N, S, E;


void read_input()
{
    freopen("thong_tin_dinh.txt", "r", stdin);
    freopen("ket_qua_bonus.txt", "w", stdout);

    scanf("%d", &T);
    scanf("%d", &N);

    if (T == 0)
    {
        for (int i = 1; i <= N + 1; i++)
        {
            int u, v, p;
            scanf("%d %d %d", &u, &v, &p);
            A[u][v] = A[v][u] = p;
        }
    }
    else
    {
        for (int i = 1; i <= N + 1; i++)
        {
            int u, v, p;
            scanf("%d %d %d", &u, &v, &p);
            A[u][v] = p;
        }
    }

    scanf("%d %d", &S, &E);
    for (int i = 1; i <= N; i++) {
        Min[i] = MAX;
    }
    Min[S] = 0;
}

void read_input_name() {
    FILE* fileName = fopen("ten_dinh.txt", "r");

       




    fclose(fileName);
}




void Dijkstra()
{
    int d = S;
    do
    {
        d = E;
        for (int i = 1; i <= N; i++)
            if (C[i] == false && Min[d] > Min[i])
            {
                d = i;
            }
        C[d] = true;

        if (Min[d] == MAX || d == E) break;

        for (int v = 1; v <= N; v++)
        {
            if (A[d][v] > 0 && !C[v])
            {
                if (A[d][v] + Min[d] < Min[v])
                {
                    Min[v] = A[d][v] + Min[d];
                    B[v] = d;
                }
            }
        }

    } while (true);
}


void output_shortWay(int end)
{
    int u = end;
    vector<int> way;
    while (u != S)
    {
        way.push_back(u);
        u = B[u];
    }
    way.push_back(S);
    printf("\nDuong di ngan nhat cua do thi la: ");
    for (int i = way.size() - 1; i >= 0; i--) {
        if (i >= 0 && way.size() - 1 != i) {
            printf(" -> ");
        }
        printf("%d", way[i]);

    }
}


void output_Cost()
{
    if (Min[E] == MAX)
        printf("Khong co duong di ngan nhat");
    else
        printf("Tong chi phi di chuyen = %d", Min[E]);
}




int main()
{
    read_input();
    Dijkstra();
    output_Cost();
    output_shortWay(E);

    return 0;
}