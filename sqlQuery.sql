CREATE TABLE Categories
(
    Id INT PRIMARY KEY,
    Name TEXT
);
 
CREATE TABLE Products
(
    Id INT PRIMARY KEY,
  	Name TEXT,
    CategoriesId INT NULL,
    FOREIGN KEY (CategoriesId) REFERENCES Categories (Id)
);

INSERT INTO Categories
VALUES
	(1, 'Машины'),
	(2, 'Книги'),
	(3, 'Цветы');
   
INSERT INTO Products
VALUES
	(1, 'Лада веста', 1),
    (2, 'Цветы для элджернона', 2),
    (3, 'Роза', 3),
    (4, 'Кит', NULL),
    (5, 'Шкода', 1),
    (6, 'Вася Пупкин', NULL);
    
SELECT
	Products.Id,
    Products.Name,
    Categories.Name AS Category
FROM
	Products 
    LEFT JOIN Categories
    	ON Products.CategoriesId = Categories.Id