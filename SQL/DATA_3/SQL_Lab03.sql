
---cau1
--Sắp xếp sản phẩm tăng dần theo UnitPrice, và tìm 20% dòng có 
--UnitPrice cao nhất (Lưu ý: Dùng ROW_NUMBER )
SELECT * 
FROM 
(
	SELECT RowNum, Id, ProductName, SupplierId, UnitPrice, Package,
	IsDiscontinued, MAX(RowNum) OVER (ORDER BY (SELECT 1)) AS RowLast
	FROM(
		SELECT ROW_NUMBER() OVER (ORDER BY UnitPrice) AS RowNum,
				Id, ProductName, SupplierId, UnitPrice, Package,
				IsDiscontinued
		FROM Product
	) AS DerivedTable
) Report
WHERE Report.RowNum >= 0.2 * RowLast


---Câu 2
--Với mỗi hóa đơn, xuất danh sách các sản phẩm, số lượng (Quantity) 
--và số phần trăm của sản phẩm đó trong hóa đơn. 
--(Gợi ý: ta lấy Quantity chia cho tổng Quantity theo hóa đơn * 100 + ‘%’. Dùng SUM … OVER)

SELECT OrderId, Id, ProductName, UnitPrice, Package, Quantity, STR([Percent],5,2) + '%' AS [Percent]
FROM
(
	SELECT O.OrderId, P.Id, P.ProductName,P.UnitPrice,P.Package, O.Quantity,
	CAST(O.Quantity AS DECIMAL(5,2))*100/ (SUM(O.Quantity) OVER (PARTITION BY O.OrderId)) AS [Percent]
	FROM OrderItem AS O
	INNER JOIN Product AS P ON O.ProductId = P.Id
) Report
ORDER BY Report.OrderId

---Câu 3
--Xuất danh sách các nhà cung cấp kèm theo các cột USA, UK, France, Germany, Others. 
--Nếu nhà cung cấp nào thuộc các quốc gia  này thì ta đánh số 1 còn lại là 0 
--(Gợi ý: Tạo bảng tạm theo chiều dọc trước với tên nhà cung cấp và thuộc quốc gia USA, UK, France, Germany hay Others. 
--Sau đó PIVOT bảng tạm này để tạo kết quả theo chiều ngang)

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES
		  WHERE TABLE_NAME = N'Company')
BEGIN
	DROP TABLE Company
END



SELECT Id, CompanyName,
	   (CASE Country
			WHEN 'USA' THEN 'USA'
			WHEN 'UK' THEN 'UK'
			WHEN 'France' THEN 'France'
			WHEN 'Germany' THEN 'Germany'
			ELSE 'Other'
		END) AS Country INTO Company
FROM Supplier 


SELECT C.Id, C.CompanyName,
	   ISNULL(C.[USA],0) AS [USA],
	   ISNULL(C.[UK],0) AS [UK],
	   ISNULL(C.[France],0) AS [France],
	   ISNULL(C.[Germany],0) AS [Germany],
	   ISNULL(C.[Other],0) AS [Other]
	   

FROM
(
	SELECT * FROM Company
	PIVOT (COUNT(Country) FOR Country IN ([USA],[UK],[France],[Germany],[Other])) AS PivotedCompany
) C
ORDER BY C.Id

---Câu 4
--Xuất danh sách các hóa đơn gồm OrderNumber, OrderDate (format: dd mm yyyy), 
--CustomerName, Address (format: “Phone: …… , City: …. and Country: ….”), 
--TotalAmount làm tròn không chữ số thập phân và đơn vị theo kèm là Euro) 

SELECT O.OrderNumber,
	   OrderDate = CONVERT(VARCHAR(10),O.OrderDate, 103),
	   CustomerName = C.FirstName + SPACE(1) + C.LastName,
	   [Address] = 'Phone: ' + C.Phone + ', ' + 'City: ' + C.City + ' and Country: ' + C.Country,
	   TotalAmount = LTRIM(STR(CAST(O.TotalAmount AS DECIMAL(10)),10,0) + ' Euro')
FROM [Order] O
INNER JOIN Customer C ON O.CustomerId = C.Id
ORDER BY O.Id

---Câu 5
--Xuất danh sách các sản phẩm dưới dạng đóng gói bags. 
--Thay đổi chữ bags thành ‘túi’ (Lưu ý: để dùng tiếng việt có dấu ta ghi chuỗi dưới dạng N’túi’)

SELECT Id, ProductName, SupplierId, UnitPrice,
		Package = STUFF(Package, CHARINDEX('bags', Package), LEN('bags'), N'túi')
FROM Product
WHERE Package LIKE '%bags%'

---Câu 6
--Xuất danh sách các khách hàng theo tổng số hóa đơn mà khách hàng đó có, 
--sắp xếp theo thứ tự giảm dần của tổng số hóa đơn,  kèm theo đó là  
--các thông tin phân hạng DENSE_RANK và nhóm (chia thành 3 nhóm) (Gợi ý: dùng NTILE(3) để chia nhóm. 
SELECT CustomerId, COUNT(OrderNumber) AS OrderCount INTO OCount
FROM [Order] GROUP BY CustomerId

SELECT*FROM OCount

SELECT OC.CustomerId,
	   CustomerName = C.FirstName + SPACE(1) + C.LastName , 
	   OC.OrderCount,
	   [Rank] = DENSE_RANK() OVER (ORDER BY OrderCount),
	   [Group] = NTILE(3) OVER (ORDER BY OC.OrderCount DESC)
FROM OCount OC 
INNER JOIN Customer C ON OC.CustomerId = C.Id
ORDER BY OC.OrderCount DESC
