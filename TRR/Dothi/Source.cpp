/*\
    * MSSV: 19110290
    * HO & TEN: Pham Nguyen Phuong Duy
    * Assignment: Bai 2
    * Created_at: 08/12/2021
    * IDE: Visual Studio 2019
*/


#ifdef _WIN32
#define _CRT_SECURE_NO_DEPRECATE
#endif

#include<iostream>
#include<fstream>
#include <conio.h>
#include<stdlib.h>
#include <vector>
using namespace std;
#define TRUE 1
#define FALSE 0
#define MAX 100

using namespace std;
int A[MAX][MAX], B[MAX], queue[MAX];
//solt là số lien thong
//n được dùng để tìm ta só hàng của ma trân kề dùng đến hết chương trình
int i, solt, n;

//Hàm tính ma trân kề có bao nhiêu hàng.
void Matrix(int* n) {
    *n = 1;
    char c;
    FILE* file = fopen("input_dothi.txt", "rb");
    for (c = getc(file); c != EOF; c = getc(file))
        if (c == '\n')
            *n = *n + 1;
    fclose(file);
}

void read_Matrix(int n) {

    FILE* file = fopen("input_dothi.txt", "rb");

    if (file == NULL)
    {
        printf("Khong mo duoc file\n");
        exit(0);
    }

    cout << "\nMa tran ke: " << endl;
    for (int i = 1; i <= n; i++) {
        for (int j = 1; j <= n; j++) {
            fscanf(file, "%d", &A[i][j]);
            cout << A[i][j] << " ";
        }
        cout << endl;
    }
    printf("Do thi co %d dinh\n ", n);
    for (int i = 1; i < n; i++)
    {
        B[MAX] = 0;
    }
    solt = 0;
    fclose(file);
}

// Hàm xuất kết quả liên thông được lưu trong mảng 
void Result(int* B, int n, int solt) {
    int slt = 0;
    printf("\n So luong thanh phan lien thong la %d:", solt);
    if (solt == 1) {
        printf("\n Do thi la lien thong");
        _getch(); return;
    }
    for (int i = 1; i <= solt; i++) {
        printf("\n Thanh phan lien thong thu %d:", i);
        for (int j = 1; j <= n; j++) {
            if (B[j] == i)
                printf("%3d", j);
        }
    }
}

//thuật toán tìm kiếm theo chiều rộng Breadth first search (BFS)
void BFS(int A[][MAX], int n, int i, int* solt, int B[], int queue[MAX]) {
    int first_queue = 1;
    int last_queue = 1;
    int u, j;
    queue[first_queue] = i; B[i] = *solt;
    while (first_queue <= last_queue) {
        u = queue[first_queue];
        first_queue = first_queue + 1;
        for (j = 1; j <= n; j++) {
            if (A[u][j] == 1 && B[j] == 0) {
                last_queue = last_queue + 1;
                queue[last_queue] = j;
                B[j] = *solt;
            }
        }
    }
}

//duyệt hết tất cả các thành phần liên thông của đồ thị.
void component(void) {
    Matrix(&n);
    read_Matrix(n);
    for (i = 1; i <= n; i++) {
        if (B[i] == 0) {
            solt = solt + 1;
            BFS(A, n, i, &solt, B, queue);
        }
    }
    Result(B, n, solt);
    _getch();
}


int main() {
    component();
    return 0;
}

