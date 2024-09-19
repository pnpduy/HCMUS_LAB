--Xuất danh sách các nhà cung cấp (gồm Id, CompanyName, ContactName, City, Country, Phone) 
--kèm theo giá min và max của các sản phẩm mà nhà cung cấp đó cung cấp. 
--Có sắp xếp theo thứ tự Id của nhà cung cấp
SELECT S.Id,S.CompanyName,
	   S.ContactName,S.City,
	   S.Country,S.Phone,
	   MAX(P.UnitPrice) AS MaxPrice,
	   MIN(P.UnitPrice) AS MinPrice
FROM Supplier AS S
INNER JOIN [Product] AS P ON S.Id = P.SupplierId
GROUP BY S.Id,S.CompanyName,
		 S.ContactName,S.City,
		 S.Country,S.Phone
ORDER BY S.Id 

--Cũng câu trên nhưng chỉ xuất danh sách nhà cung cấp 
--có sự khác biệt giá (max – min) không quá lớn (<=30)
SELECT S.Id,S.CompanyName,
	   S.ContactName,S.City,
	   S.Country,S.Phone,
	   MAX(P.UnitPrice) AS MaxPrice,
	   MIN(P.UnitPrice) AS MinPrice
FROM Supplier AS S
INNER JOIN [Product] AS P ON S.Id = P.SupplierId
GROUP BY S.Id,S.CompanyName,
		 S.ContactName,S.City,
		 S.Country,S.Phone
HAVING (Max(P.UnitPrice)-MIN(P.UnitPrice)) <= 30
ORDER BY S.Id 

--Xuất danh sách các hóa đơn (Id, OrderNumber, OrderDate) kèm 
--theo tổng giá chi trả (UnitPrice*Quantity) cho hóa đơn đó, 
--bên cạnh đó có cột Description là “VIP” nếu tổng giá lớn hơn 1500 
--và “Normal” nếu tổng giá nhỏ hơn 1500
SELECT O.Id, O.OrderNumber, O.OrderDate,
	   SUM(OI.UnitPrice*OI.Quantity) AS Total,
	   'VIP' AS [Description]
FROM [Order] AS O
INNER JOIN [OrderItem] AS OI ON O.Id = OI.OrderId
GROUP BY O.Id, O.OrderNumber, O.OrderDate 
HAVING SUM(OI.UnitPrice*OI.Quantity) > 1500
UNION
SELECT O.Id, O.OrderNumber, O.OrderDate,
	   SUM(OI.UnitPrice*OI.Quantity) AS Total,
	   'Normal' AS [Description]
FROM [Order] AS O
INNER JOIN [OrderItem] AS OI ON O.Id = OI.OrderId
GROUP BY O.Id, O.OrderNumber, O.OrderDate 
HAVING SUM(OI.UnitPrice*OI.Quantity) < 1500
ORDER BY O.Id 


--Xuất danh sách những hóa đơn (Id, OrderNumber, OrderDate) 
--trong tháng 7 nhưng phải ngoại trừ ra những hóa đơn từ khách hàng France
SELECT Id, OrderNumber, OrderDate
FROM [Order] 
WHERE MONTH(OrderDate) = 7
EXCEPT
SELECT O.Id, O.OrderNumber, O.OrderDate
FROM [Order] AS O
INNER JOIN [Customer] AS C ON O.CustomerId = C.Id
WHERE Country ='France';

SELECT* FROM[Order]

--Xuất danh sách những hóa đơn (Id, OrderNumber, OrderDate, TotalAmount)
--nào có TotalAmount nằm trong top 5 các hóa đơn.
SELECT Id, OrderNumber, OrderDate, TotalAmount
FROM [Order]
WHERE TotalAmount IN (SELECT TOP 5 TotalAmount
					  FROM [Order]
					  GROUP BY TotalAmount
					  ORDER BY COUNT(Id) DESC)
