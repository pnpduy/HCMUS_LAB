--Câu 1
--Theo mỗi  OrderID cho biết số lượng Quantity của mỗi ProductID chiếm tỷ lệ bao nhiêu phần trăm
SELECT OrderId, Quantity, ProductId,
        SUM (Quantity) OVER (PARTITION  BY OrderId) AS TotalQuantity,
        CAST (((1.0* Quantity)/(SUM(Quantity) OVER (PARTITION BY OrderId))*100)
                                          AS DECIMAL(6,2)) AS PercentofQuantity
FROM OrderItem 

--Câu 2
--Xuất các hóa đơn kèm theo thông tin ngày trong tuần của hóa đơn là : Thứ 2, 3,4,5,6,7, Chủ Nhật
SELECT DATENAME(dw, OrderDate) AS [Day Name],*
FROM [Order]
WHERE DATENAME (dw, OrderDate)='MONday' or
	  DATENAME (dw, OrderDate)='Tuesday' or
	  DATENAME (dw, OrderDate)='Wednesday' or
	  DATENAME (dw, OrderDate)='Thursday' or
	  DATENAME (dw, OrderDate)='Friday' or
	  DATENAME (dw, OrderDate)='Saturday' or
	  DATENAME (dw, OrderDate)='Sunday' 

--Câu 3
--Với mỗi ProductID trong OrderItem xuất các thông tin gồm OrderID, ProductID, ProductName, UnitPrice, Quantity, ContactInfo, CONtactType.
--Trong đó ContactInfo ưu tiên Fax, nếu không thì dùng Phone của Supplier sản phẩm đó. 
--Còn ContactType là ghi chú đó là loại ContactInfo nào
SELECT  OI.OrderID, OI.ProductId, P.ProductName, P.UnitPrice, OI.Quantity, 
	    coalesce(Fax,Phone) AS ContactInfo, 
		CASE coalesce(Fax,Phone) WHEN Fax THEN 'Fax' ELSE 'Phone' END AS ContactType
FROM OrderItem OI inner join Product P ON OI.ProductId = P.Id,Supplier S
WHERE P.SupplierId = S.Id
	 
--Câu 4
--Cho biết Id của database Northwind, Id của bảng Supplier, Id của User mà bạn đang đăng nhập là bao nhiêu.
--Cho biết luôn tên User mà đang đăng nhập
DECLARE @sys_usr CHAR(30),@user_name CHAR(30);  
SET @sys_usr = SYSTEM_USER; 
SET @user_name = USER_NAME();
SELECT DB_ID('Northwind') AS [DatabASe ID],
	   object_id('Supplier') AS [Table ID],
	   USER_ID(@user_name) AS [User ID],
	   @sys_usr AS [User_Name],
	   user_name(1) AS [Else UserName]

 --Câu 5
 --Cho biết các thông tin user_update, user_seek, user_scan 
 --và user_lookup trên bảng Order trong database Northwind
SELECT [TableName]=OBJECT_NAME(object_id),
        user_updates, user_seeks, user_scans, user_lookups
FROM sys.dm_db_index_usage_stats AS SIUS
WHERE database_id=DB_ID('Northwind') and OBJECT_NAME(object_id)='Order'

--Câu 6
--Dùng WITH phân chia cây như sau : Mức 0 là các Quốc Gia(Country), mức 1 là các Thành Phố 
--(City) thuộc Country đó, và mức 2 là các Hóa Đơn (Order) thuộc khách hàng từ Country-City đó
with OrderCategory(Country, City, OrderNumber, alevel)
AS
(
	SELECT distinct Country,
					City = cASt('' AS NVARCHAR(255)),
					OrderNumber = cASt('' AS NVARCHAR(255)),
					alevel = 0
	FROM Supplier,[Order]

	UNION all

	SELECT C.Country,
		   City = cASt(C.City AS NVARCHAR(255)),
		   OrderNumber = cASt('' AS NVARCHAR(255)),
	       alevel = OC.alevel + 1
	FROM OrderCategory OC inner join Customer C ON OC.Country = C.Country
	WHERE OC.alevel = 0

	UNION all

	SELECT C.Country,
		   City = cASt(C.City AS NVARCHAR(255)),
		   OrderNumber = cASt(O.OrderNumber AS NVARCHAR(255)),
	       alevel = OC.alevel + 1
	FROM OrderCategory OC inner join Customer C 
	ON OC.Country = C.Country and OC.City = C.City inner join [Order] 
	AS O ON C.Id= O.CustomerId

	WHERE OC.alevel = 1
)
SELECT [Quoc gia] = CASE WHEN alevel = 0 THEN Country ELSE '--' END,
	   [Thanh pho] = CASE WHEN alevel = 1 THEN City ELSE '----' END,
	   [Hoa don] = OrderNumber,
	   Cap = alevel
FROM OrderCategory
order BY Country, City, OrderNumber, alevel

--Câu 7
--Xuất những hóa đơn từ khách hàng France mà có 
--tổng số lượng Quantity lớn hơn 50 của các sản phẩm thuộc hóa đơn ấy 
with SumQuantityByOrder AS
(
    SELECT OI.OrderId, SumQuantity=SUM(Quantity)
    FROM OrderItem AS OI
    GROUP BY OrderId
),
CustomerByOrder AS
(
    SELECT O.*, SQBO.SumQuantity 
    FROM Customer AS C inner join [Order] AS O ON C.Id=O.CustomerId
        inner join SumQuantityByOrder AS SQBO ON O.Id=SQBO.OrderId
    WHERE C.Country='France'
)
SELECT*
FROM CustomerByOrder
WHERE SumQuantity>50