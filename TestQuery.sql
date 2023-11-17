CREATE TABLE Products (
	Id INT PRIMARY KEY,
	"Name" TEXT
);

INSERT INTO Products
VALUES (1, 'Iphone'), (2, 'Carrot'), (3, 'BMW'), (4, 'MacBook');

CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	"Name" TEXT
);

INSERT INTO Categories
VALUES (1, 'Phone'), (2, 'Car'), (3, 'Food');

CREATE TABLE ProductCategories (
	Product_Id INT FOREIGN KEY REFERENCES Products(Id),
	Category_Id INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (Product_Id, Category_Id)
);

INSERT INTO ProductCategories
VALUES (1, 1), (2, 3), (3, 2);

SELECT p."Name" AS ProductName,
c."Name" AS CategoryName
FROM Products p
LEFT JOIN ProductCategories pc
	ON p.Id = pc.Product_Id
LEFT JOIN Categories c
	ON pc.Category_Id = c.Id;