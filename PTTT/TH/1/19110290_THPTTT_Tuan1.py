# -*- coding: utf-8 -*-
"""19110290_THPTTT_Tuan1.ipynb

Automatically generated by Colaboratory.

Original file is located at
    https://colab.research.google.com/drive/1B8Md5R_JaHqX7ljJ5Kmc0YPeKKKYJDwI

# Họ & Tên: Phạm Nguyễn Phương Duy
# MSSV: 19110290

**Bài 1**

1. Viết chương trình để biểu diễn một số thập phân N sang dạng biểu diễn nhị phân có độ phức tạp thuật toán là O(log2 N).
  * Input: Số thập phân N.
  * Output: Dạng biểu diễn nhị phân của N.
"""

def DecimalToBinary ( n ):  
    Output =  "" 
    while (n !=  0):       
      Output =  str (n% 2 ) + Output
      print(n , "%2=" , n% 2 )       
      n = n// 2
    return ("Số thập phân thành nhị phân"  , Output); 

DecimalToBinary(25)

"""---

2. Giả sử các em đã xây dựng thuật toán trên. Hãy viết một chương trình
để đếm số phép gán và số phép so sánh mà chương trình trên đã dùng
để biểu diễn một số thập phân N.
  * Input: binary(N), N = 100, 200, 300, 400, . . . , 1000.
  * Output: Gan(N), Sosanh(N). Vẽ log2 N, Gan(N), và Sosanh(N) trên
cùng một đồ thị để so sánh.
"""

import math

def DecimalToBinary(n):
    Gan = 0
    SoSanh = 0
    Output = ""
    while(n != 0):
      SoSanh = SoSanh + 1
      Output = str(n%2) + Output
      #print(n ,"%2=", n%2)
      n = n//2
      Gan = Gan + 2

    print("Số phép gán: ", Gan)
    print("Số phép so sánh: ", SoSanh)
    return  Output

def Log2N(n):
  return math.log2(n)

#TH1: n = 100
n = 100
print("Với n =",n)
print( n, "chuyển sang nhị phân là" ,DecimalToBinary(n))
print("Giá trị của hàm log2: ",Log2N(n))
print("\n")

#TH2: n = 300
n = 200
print("Với n =",n)
print( n, "chuyển sang nhị phân là" ,DecimalToBinary(n))
print("Giá trị của hàm log2: ",Log2N(n))
print("\n")

#TH3: n = 300
n = 300
print("Với n =",n)
print( n, "chuyển sang nhị phân là" ,DecimalToBinary(n))
print("Giá trị của hàm log2: ",Log2N(n))
print("\n")

#TH4: n = 400
n = 400
print("Với n =",n)
print( n, "chuyển sang nhị phân là" ,DecimalToBinary(n))
print("Giá trị của hàm log2: ",Log2N(n))
print("\n")

#TH5: n = 500
n = 500
print("Với n =",n)
print( n, "chuyển sang nhị phân là" ,DecimalToBinary(n))
print("Giá trị của hàm log2: ",Log2N(n))
print("\n")

#TH6: n = 600
n = 600
print( n, "chuyển sang nhị phân là" ,DecimalToBinary(n))
print("Giá trị của hàm log2: ",Log2N(n))
print("\n")

#TH7: n = 700
n = 700
print("Với n =",n)
print( n, "chuyển sang nhị phân là" ,DecimalToBinary(n))
print("Giá trị của hàm log2: ",Log2N(n))
print("\n")

#TH8: n = 800
n = 800
print("Với n =",n)
print( n, "chuyển sang nhị phân là" ,DecimalToBinary(n))
print("Giá trị của hàm log2: ",Log2N(n))
print("\n")

#TH9: n = 900
n = 900
print("Với n =",n)
print( n, "chuyển sang nhị phân là" ,DecimalToBinary(n))
print("Giá trị của hàm log2: ",Log2N(n))
print("\n")

#TH10: n = 1000
n = 1000
print("Với n =",n)
print( n, "chuyển sang nhị phân là" ,DecimalToBinary(n))
print("Giá trị của hàm log2: ",Log2N(n))
print("\n")

"""* Vẽ log2 N, Gan(N), và Sosanh(N) trên
cùng một đồ thị để so sánh.
"""

import matplotlib.pyplot as plt
import numpy as np

value_N = ('100', '200', '300', '400', '500' , '600', '700', '800', '900', '1000')
value_Bar = {
    'Gán': (14, 16, 18, 18, 18, 20, 20, 20, 20, 20),
    'So Sánh': (7, 8, 9, 9, 9, 10, 10, 10, 10, 10),
    'Log2': (6.64, 7.64, 8.22, 8.64, 8.96, 9.22, 9.45, 9.64, 9.81, 9.96),
}

x = np.arange(len(value_N)) 
width = 0.25  
multiplier = 0

fig, ax = plt.subplots(figsize =(12, 8))

for attribute, measurement in value_Bar.items():
    offset = width * multiplier
    rects = ax.bar(x + offset, measurement, width, label = attribute)
    ax.bar_label(rects, padding = 3)
    multiplier += 1

ax.set_ylabel('Giá tri')
ax.set_xlabel('Giá trị N')
ax.set_title('Bảng so sánh Log2 N, Gan(N), và Sosanh(N)')
ax.set_xticks(x + width, value_N)
ax.legend(loc='upper left', ncols = 3)
ax.set_ylim(0, 22)

plt.show()