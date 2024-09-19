/*\
    * MSSV: 19110290
    * HO & TEN: Pham Nguyen Phuong Duy
    * Assignment: Bai 3
    * Created_at: 27/12/2021
    * IDE: Visual Studio 2022 new
*/


#ifdef _WIN32
#define _CRT_SECURE_NO_DEPRECATE
#endif



#include <fstream>
#include <conio.h>
#include <stdlib.h>
#include <iostream>
#include <vector>
#include <stdio.h>

#define MAX 1000
#define Inf 99999

using namespace std;

int A[MAX][MAX];
int Min[MAX];
int B[MAX];
bool C[MAX];

int T, N, S, E;
int n;

void Read_file_line(int *n) {
    *n = 1;
    char c;
    FILE* file = fopen("thong_tin_dinh.txt", "rb");
    for (c = getc(file); c != EOF; c = getc(file))
        if (c == '\n')
            *n = *n + 1;
    fclose(file);
}


void read_input(int n)
{
    freopen("thong_tin_dinh.txt", "r", stdin);
    freopen("ket_qua_bai_3_19110290.txt", "w", stdout);


    scanf("%d", &T);
    scanf("%d", &N);

    if (T == 0)
    {
        for (int i = 1; i <= n - 3 ; i++)
        {
            int u, v, p;
            scanf("%d %d %d", &u, &v, &p);
            A[u][v] = A[v][u] = p;
        }
    }
    else
    {
        for (int i = 1; i <= n - 3; i++)
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
        if ( i >= 0 && way.size() -1 != i) {
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

void Bai3(void) {
    Read_file_line(&n);
    read_input(n);
    Dijkstra();
    output_Cost();
    output_shortWay(E);
}


int main()
{  
    Bai3();
    return 0;
}