# -*- coding: utf-8 -*-
"""19110290_THPTTT_Tuan8.ipynb

Automatically generated by Colaboratory.

Original file is located at
    https://colab.research.google.com/drive/149ew1lKYl-XSMkZlIp_xL0K45RavWmRR

# Họ & Tên: Phạm Nguyễn Phương Duy
# MSSV: 19110290

## Bài 1
# a)
"""

#hàm strcat là hàm nối chuỗi thành một chuỗi mới
def strcat(n):
    temp = []
    A = [('abc'),('def'),('ghi'),('jkl'),('mno'),('pqr'),('stu'),('vwx'),('yz')]
    if n == 0:
        temp.append(A[0])
    else:
        for i in range(0,n):
            temp.append(A[i])
        A_string = "".join(temp)
    return A_string

#hàm để tìm chính xác ký tự thứ k
def find_char(n, k):
    s = strcat(n)
    if k < 1 or k > len(s):
        return ""
    return s[k-1]

# Ví dụ:
# Tìm ký tự thứ 3 của chuỗi được trả về bởi strcat(2)
k = 3
n = 2
result = find_char(n, k)
if result == "":
  print(f"k phải nằm trong khoảng từ 1 đến {len(strcat(n))}")
else:
  print(f"Ký tự thứ k = {k} trong chuỗi strcat({n}) là {result}")

"""#b)

**Ta đánh giá độ phức tạp của thuật toán tìm chính xác ký tự thứ k là $O(n)$.**
"""

