--Truy v?n danh sách các Customer 
SELECT * FROM Customer

--Truy v?n danh sách các Customer theo các thông tin Id, FullName (là k?t h?p FirstName-LastName), City, Country
SELECT Id,
		CONCAT(FirstName,' ',LastName) AS'Full Name',
		City, Country
FROM Customer


--Cho bi?t có bao nhiêu khách hàng t? Germany và UK, ?ó là nh?ng khách hàng nào
SELECT * 
FROM Customer
WHERE Country in ('Germany', 'UK')

SELECT COUNT(Country)
FROM Customer WHERE Country in ('Germany', 'UK')


--Li?t kê danh sách khách hàng theo th? t? t?ng d?n c?a FirstName và gi?m d?n c?a Country
SELECT *
FROM Customer
ORDER BY FirstName ASC, Country DESC


--Truy v?n danh sách các khách hàng v?i ID là 5,10, t? 1-10, và t? 5-10
SELECT *
FROM Customer
WHERE Id = 5 OR Id = 10

SELECT TOP 10 *
FROM Customer

SELECT *
FROM Customer
ORDER BY Id
OFFSET 4 ROWS
FETCH NEXT 6 ROWS ONLY


--Truy vấn các khách hàng ở các sản phẩm (Product) mà đóng gói dưới dạng 
--bottles có giá từ 15 đến 20 mà không từ nhà cung cấp có ID là 16.
SELECT * 
FROM Product
WHERE Package LIKE '%bottles%' 
AND UnitPrice BETWEEN 15 AND 20 
AND NOT SupplierId = 16
