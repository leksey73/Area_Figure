CREATE TABLE products (
	id INT PRIMARY KEY NOT NULL,
	product_name VARCHAR (255)
);

INSERT INTO products
VALUES
	(1, '�����'),
	(2, '�����'),
	(3, '������'),
	(4, '���������� ������'),
	(5, '����������� ������'),
	(6, '������ Ariel'),
	(7, '�������� �������� Domestos'),
	(8, '�������'),
	(9, '������������� ����'),
	(10,'������ ����'),
	(11, '����� Bosh'),
	(12, '����������� ���� Makita'),
	(13, '���������� ���� PARTNER'),
	(14, '�����'),
	(15, '����'),
	(16, 'Iphone 11'),
	(17, 'SvetoCopy ������'),
	(18, '������� �����'),
	(19, '��������'),
	(20, '��������������');

CREATE TABLE categories (
	id INT PRIMARY KEY,
	categorie_name VARCHAR (255)
);

INSERT INTO categories
VALUES
	(1, '������'),
	(2, '������� �����'),
	(3, '�����������');

CREATE TABLE products_categories (
	product_id INT FOREIGN KEY REFERENCES products(id),
	category_id INT FOREIGN KEY REFERENCES categories(id),
	PRIMARY KEY (product_id, category_id)
);

INSERT INTO products_categories
VALUES
	(1, 1),
	(2, 1),
	(3, 1),
	(4, 1),
	(5, 1),
	(6, 2),
	(7, 2),
	(8, 2),
	(9, 2),
	(10, 2),
	(11, 3),
	(12, 3),
	(13, 3),
	(14, 3),
	(15, 3);

SELECT  p.id, p.product_name, c.id, c.categorie_name
FROM products p
LEFT JOIN products_categories p_c
	ON p.id = p_c.product_id
LEFT JOIN categories c
	ON p_c.category_id = c.id;
	
select * from categories;
select * from products;
