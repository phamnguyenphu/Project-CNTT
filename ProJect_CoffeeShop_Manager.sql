CREATE DATABASE PROJECT_COFFEESHOP_MANAGER1
GO
-- TẠO DATABASE

USE PROJECT_COFFEESHOP_MANAGER1
GO

-- Các table cần tạo trong quản lí coffee shop
--1. Table Customer
--2. Products
--3. Products Category
--4. Account User
--5. Bill Status
--6. Bill Information

-- Tạo bảng Table Customer
CREATE TABLE Table_Customer
(
	Id_Table INT IDENTITY PRIMARY KEY,
	Name_Table NVARCHAR(50) NOT NULL,
	Status_Table NVARCHAR(50) NOT NULL DEFAULT N'Bàn trống'
)
GO


-- Tạo bảng Products_Category
CREATE TABLE Products_Category
(
	Id_Products_Category INT IDENTITY PRIMARY KEY,
	Name_Products_Category NVARCHAR(100) NOT NULL
)
GO



-- Tạo bảng Products
CREATE TABLE Products
(
	Id_Products INT IDENTITY PRIMARY KEY,
	Name_Products NVARCHAR(100) NOT NULL,
	Id_Products_Category INT NOT NULL,
	Products_price FLOAT NOT NULL, 
	
	FOREIGN KEY (Id_Products_Category) REFERENCES dbo.Products_Category(Id_Products_Category)
)
GO



-- Taọ bảng Account_User
CREATE TABLE Account_User
(
	UserName_AccountUser NVARCHAR(50) PRIMARY KEY,	
	PassWord_AccountUser NVARCHAR(50) NOT NULL
)
GO


-- Tạo bảng Bill_Status
CREATE TABLE Bill_Status
(
	Id_Bill_Status INT IDENTITY PRIMARY KEY,
	Time_Checkin DATE NOT NULL DEFAULT GETDATE(),
	Time_Checkout DATE,
	Id_Table INT NOT NULL,
	Status_bill INT NOT NULL DEFAULT 0			-- 1: đã thanh toán && 0: chưa thanh toán

	FOREIGN KEY (Id_Table) REFERENCES dbo.Table_Customer(Id_Table)
)
GO


-- Tạo bảng Bill_Information
CREATE TABLE Bill_Information
(
	Id_Bill_Information INT IDENTITY PRIMARY KEY,
	Id_Bill_Status INT NOT NULL,
	Id_Products INT NOT NULL,
	count INT NOT NULL

	FOREIGN KEY (Id_Bill_Status) REFERENCES dbo.Bill_Status(Id_Bill_Status),
	FOREIGN KEY (Id_Products) REFERENCES dbo.Products(Id_Products)
)
GO



-- Thực hiện việc insert dữ liệu cho các bảng
INSERT INTO dbo.Account_User
        ( UserName_AccountUser ,
          PassWord_AccountUser
        )
VALUES  ( N'phamnguyenphu' , -- UserName_AccountUser - nvarchar(50)
          N'nguyenphu2'  -- PassWord_AccountUser - nvarchar(50)
        )
INSERT INTO dbo.Account_User
        ( UserName_AccountUser ,
          PassWord_AccountUser
        )
VALUES  ( N'phamthanhtrung' , -- UserName_AccountUser - nvarchar(50)
          N'123456'  -- PassWord_AccountUser - nvarchar(50)
        )
GO

-- Tạo hàm user procedure cho login -- BẢNG ACCOUNT USER --> LÀM TÍNH NĂNG ĐĂNG NHẬP
CREATE PROC USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account_User WHERE UserName_AccountUser = @userName AND PassWord_AccountUser = @passWord
END
GO


-- NHẬP dữ liệu vào bảng table-customer
INSERT INTO dbo.Table_Customer
        ( Name_Table, Status_Table )
VALUES  ( N'Bàn A01', -- Name_Table - nvarchar(50)
          N'Bàn trống'  -- Status_Table - nvarchar(50)
          )
INSERT INTO dbo.Table_Customer
        ( Name_Table, Status_Table )
VALUES  ( N'Bàn A02', -- Name_Table - nvarchar(50)
          N'Bàn trống'  -- Status_Table - nvarchar(50)
          )
INSERT INTO dbo.Table_Customer
        ( Name_Table, Status_Table )
VALUES  ( N'Bàn A03', -- Name_Table - nvarchar(50)
          N'Bàn trống'  -- Status_Table - nvarchar(50)
          )
INSERT INTO dbo.Table_Customer
        ( Name_Table, Status_Table )
VALUES  ( N'Bàn A04', -- Name_Table - nvarchar(50)
          N'Bàn trống'  -- Status_Table - nvarchar(50)
          )
INSERT INTO dbo.Table_Customer
        ( Name_Table, Status_Table )
VALUES  ( N'Bàn A05', -- Name_Table - nvarchar(50)
          N'Bàn trống'  -- Status_Table - nvarchar(50)
          )
INSERT INTO dbo.Table_Customer
        ( Name_Table, Status_Table )
VALUES  ( N'Bàn A06', -- Name_Table - nvarchar(50)
          N'Bàn trống'  -- Status_Table - nvarchar(50)
          )
INSERT INTO dbo.Table_Customer
        ( Name_Table, Status_Table )
VALUES  ( N'Bàn B01', -- Name_Table - nvarchar(50)
          N'Bàn trống'  -- Status_Table - nvarchar(50)
          )
INSERT INTO dbo.Table_Customer
        ( Name_Table, Status_Table )
VALUES  ( N'Bàn B02', -- Name_Table - nvarchar(50)
          N'Bàn trống'  -- Status_Table - nvarchar(50)
          )
INSERT INTO dbo.Table_Customer
        ( Name_Table, Status_Table )
VALUES  ( N'Bàn B03', -- Name_Table - nvarchar(50)
          N'Bàn trống'  -- Status_Table - nvarchar(50)
          )
INSERT INTO dbo.Table_Customer
        ( Name_Table, Status_Table )
VALUES  ( N'Bàn B04', -- Name_Table - nvarchar(50)
          N'Bàn trống'  -- Status_Table - nvarchar(50)
          )
INSERT INTO dbo.Table_Customer
        ( Name_Table, Status_Table )
VALUES  ( N'Bàn B05', -- Name_Table - nvarchar(50)
          N'Bàn trống'  -- Status_Table - nvarchar(50)
          )
INSERT INTO dbo.Table_Customer
        ( Name_Table, Status_Table )
VALUES  ( N'Bàn B06', -- Name_Table - nvarchar(50)
          N'Bàn trống'  -- Status_Table - nvarchar(50)
          )
INSERT INTO dbo.Table_Customer
        ( Name_Table, Status_Table )
VALUES  ( N'Bàn B07', -- Name_Table - nvarchar(50)
          N'Bàn trống'  -- Status_Table - nvarchar(50)
          )
INSERT INTO dbo.Table_Customer
        ( Name_Table, Status_Table )
VALUES  ( N'Bàn C01', -- Name_Table - nvarchar(50)
          N'Bàn trống'  -- Status_Table - nvarchar(50)
          )
INSERT INTO dbo.Table_Customer
        ( Name_Table, Status_Table )
VALUES  ( N'Bàn C02', -- Name_Table - nvarchar(50)
          N'Bàn trống'  -- Status_Table - nvarchar(50)
          )
INSERT INTO dbo.Table_Customer
        ( Name_Table, Status_Table )
VALUES  ( N'Bàn C03', -- Name_Table - nvarchar(50)
          N'Bàn trống'  -- Status_Table - nvarchar(50)
          )
GO

-- Tạo hàm get tất cả bàn đã nhập liệu vào Visual 
CREATE PROC GetTable_Customer
AS SELECT * FROM dbo.Table_Customer
GO 


-- NHẬP dữ liệu vào bảng products category
INSERT INTO dbo.Products_Category
        ( Name_Products_Category )
VALUES  ( N'Đồ ăn'  -- Name_Products_Category - nvarchar(100)
          )
INSERT INTO dbo.Products_Category
        ( Name_Products_Category )
VALUES  ( N'Thức uống'  -- Name_Products_Category - nvarchar(100)
          )
GO



-- NHẬP dữ liệu vào bảng products 
INSERT INTO dbo.Products
        ( Name_Products ,
          Id_Products_Category ,
          Products_price
        )
VALUES  ( N'Hạt điều rang muối' , -- Name_Products - nvarchar(100)
          1 , -- Id_Products_Category - int
          42000.0  -- Products_price - float
        )
INSERT INTO dbo.Products
        ( Name_Products ,
          Id_Products_Category ,
          Products_price
        )
VALUES  ( N'Mít sấy' , -- Name_Products - nvarchar(100)
          1 , -- Id_Products_Category - int
          39000.0  -- Products_price - float
        )
		
INSERT INTO dbo.Products
        ( Name_Products ,
          Id_Products_Category ,
          Products_price
        )
VALUES  ( N'Cafe đen' , -- Name_Products - nvarchar(100)
          2 , -- Id_Products_Category - int
          30000.0  -- Products_price - float
        )
INSERT INTO dbo.Products
        ( Name_Products ,
          Id_Products_Category ,
          Products_price
        )
VALUES  ( N'Cafe sữa' , -- Name_Products - nvarchar(100)
          2 , -- Id_Products_Category - int
          32000.0  -- Products_price - float
        )
INSERT INTO dbo.Products
        ( Name_Products ,
          Id_Products_Category ,
          Products_price
        )
VALUES  ( N'Bạc xỉu' , -- Name_Products - nvarchar(100)
          2 , -- Id_Products_Category - int
          35000.0  -- Products_price - float
        )
INSERT INTO dbo.Products
        ( Name_Products ,
          Id_Products_Category ,
          Products_price
        )
VALUES  ( N'Caramel macchiato đá' , -- Name_Products - nvarchar(100)
          2 , -- Id_Products_Category - int
          50000.0  -- Products_price - float
        )
INSERT INTO dbo.Products
        ( Name_Products ,
          Id_Products_Category ,
          Products_price
        )
VALUES  ( N'Trà phúc bồn tử ' , -- Name_Products - nvarchar(100)
          2 , -- Id_Products_Category - int
          50000.0  -- Products_price - float
        )
INSERT INTO dbo.Products
        ( Name_Products ,
          Id_Products_Category ,
          Products_price
        )
VALUES  ( N'Trà đào cam sả ' , -- Name_Products - nvarchar(100)
          2 , -- Id_Products_Category - int
          45000.0  -- Products_price - float
        )
INSERT INTO dbo.Products
        ( Name_Products ,
          Id_Products_Category ,
          Products_price
        )
VALUES  ( N'Espresso đá' , -- Name_Products - nvarchar(100)
          2 , -- Id_Products_Category - int
          45000.0  -- Products_price - float
        )
INSERT INTO dbo.Products
        ( Name_Products ,
          Id_Products_Category ,
          Products_price
        )
VALUES  ( N'Socola đá' , -- Name_Products - nvarchar(100)
          2 , -- Id_Products_Category - int
          59000.0  -- Products_price - float
        )
INSERT INTO dbo.Products
        ( Name_Products ,
          Id_Products_Category ,
          Products_price
        )
VALUES  ( N'Trà matcha latte đá' , -- Name_Products - nvarchar(100)
          2 , -- Id_Products_Category - int
          59000.0  -- Products_price - float
        )
INSERT INTO dbo.Products
        ( Name_Products ,
          Id_Products_Category ,
          Products_price
        )
VALUES  ( N'Trà đen macchiato' , -- Name_Products - nvarchar(100)
          2 , -- Id_Products_Category - int
          42000.0  -- Products_price - float
        )
INSERT INTO dbo.Products
        ( Name_Products ,
          Id_Products_Category ,
          Products_price
        )
VALUES  ( N'Trà sữa chân châu đường đen' , -- Name_Products - nvarchar(100)
          2 , -- Id_Products_Category - int
          37000.0  -- Products_price - float
        )
GO





-- Hàm nhập dữ liệu vào bảng bill_information
CREATE PROC Bill_Information_Insert
@idBill INT, @idFood INT, @count INT
AS
BEGIN

	DECLARE @isExitsBillInfo INT
	DECLARE @foodCount INT = 1
	
	SELECT @isExitsBillInfo = b.Id_Bill_Information, @foodCount = b.count 
	FROM dbo.Bill_Information AS b 
	WHERE b.Id_Bill_Status = @idBill AND b.Id_Products = @idFood

	IF (@isExitsBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF (@newCount > 0)
			UPDATE dbo.Bill_Information	SET count = @foodCount + @count WHERE Id_Products = @idFood
		ELSE
			DELETE dbo.Bill_Information WHERE Id_Bill_Status = @idBill AND Id_Products = @idFood
	END
	ELSE
	BEGIN
		INSERT	dbo.Bill_Information
		        ( Id_Bill_Status ,
		          Id_Products ,
		          count
		        )
		VALUES  ( @idBill , -- Id_Bill_Status - int
		          @idFood , -- Id_Products - int
		          @count  -- count - int
		        )
	END
END
GO


-- hàm nhập dữ liệu vào bảng bill_status 
CREATE PROC Bill_Insert
@idTable INT
AS
BEGIN
	INSERT dbo.Bill_Status
	        ( Time_Checkin ,
	          Time_Checkout ,
	          Id_Table ,
	          Status_bill
	        )
	VALUES  ( GETDATE() , -- Time_Checkin - date
	          NULL , -- Time_Checkout - date
	          @idTable , -- Id_Table - int
	          0  -- Status_bill - int
	        )
END
GO

 

-- Hàm trigger để update bàn sau khi thanh toán
CREATE TRIGGER Update_Bill_Information
ON dbo.Bill_Information AFTER INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = Id_Bill_Status FROM Inserted
	
	DECLARE @idTable INT
	
	SELECT @idTable = Id_Table FROM dbo.Bill_Status WHERE Id_Bill_Status = @idBill AND Status_bill = 0
	
	UPDATE dbo.Table_Customer SET Status_Table = N'Bàn có người' WHERE Id_Table = @idTable
END
GO

drop trigger Update_Bill_Information 
GO

CREATE TRIGGER Update_Bill_Status	
ON dbo.Bill_Status AFTER UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = Id_Bill_Status FROM Inserted
	
	DECLARE @idTable INT
	
	SELECT @idTable = Id_Table FROM dbo.Bill_Status WHERE Id_Bill_Status=@idBill
	
	DECLARE @count int = 0
	
	SELECT @count = COUNT(*) FROM dbo.Bill_Status WHERE Id_Table = @idTable AND Status_bill = 0
	
	IF (@count = 0)
		UPDATE dbo.Table_Customer SET Status_Table = N'Bàn trống' WHERE Id_Table = @idTable
END
GO


DELETE dbo.Bill_Status
DELETE dbo.Bill_Information
        