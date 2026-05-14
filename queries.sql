-- Database Setup

-- 1. Open SSMS and connect to your SQL Server instance

CREATE DATABASE ecommerce;
GO

USE ecommerce;
GO

CREATE TABLE products (
    id              INT PRIMARY KEY IDENTITY(1,1),
    name            NVARCHAR(255) NOT NULL,
    description     NVARCHAR(MAX),
    category        NVARCHAR(255),
    price           DECIMAL(10,2) NOT NULL,
    stock_quantity  INT NOT NULL DEFAULT 0,
    is_active       BIT NOT NULL DEFAULT 1,
    discount        DECIMAL(10,2) NOT NULL DEFAULT 0,
    created_at      DATETIME NOT NULL DEFAULT GETDATE(),
    updated_at      DATETIME NULL
);
GO

-- Stored Procedures Setup

USE ecommerce;
GO

-- Get All Products
CREATE PROCEDURE sp_GetProducts
AS
BEGIN
    SELECT * FROM products
    ORDER BY ISNULL(updated_at, created_at) DESC
END
GO

-- Get Single Product
CREATE PROCEDURE sp_GetProduct
    @id INT
AS
BEGIN
    SELECT * FROM products WHERE id = @id
END
GO

-- Create Product
CREATE PROCEDURE sp_CreateProduct
    @name           NVARCHAR(255),
    @description    NVARCHAR(MAX),
    @category       NVARCHAR(255),
    @price          DECIMAL(10,2),
    @stockQuantity  INT,
    @isActive       BIT,
    @discount       DECIMAL(10,2)
AS
BEGIN
    INSERT INTO products (name, description, category, price, stock_quantity, is_active, discount)
    VALUES (@name, @description, @category, @price, @stockQuantity, @isActive, @discount)
END
GO

-- Update Product
CREATE PROCEDURE sp_UpdateProduct
    @id             INT,
    @name           NVARCHAR(255),
    @description    NVARCHAR(MAX),
    @category       NVARCHAR(255),
    @price          DECIMAL(10,2),
    @stockQuantity  INT,
    @isActive       BIT,
    @discount       DECIMAL(10,2)
AS
BEGIN
    UPDATE products
    SET
        name            = @name,
        description     = @description,
        category        = @category,
        price           = @price,
        stock_quantity  = @stockQuantity,
        is_active       = @isActive,
        discount        = @discount,
        updated_at      = GETDATE()
    WHERE id = @id
END
GO

-- Delete Product
CREATE PROCEDURE sp_DeleteProduct
    @id INT
AS
BEGIN
    DELETE FROM products WHERE id = @id
END
GO

-- Create Table
CREATE TABLE products (
    id INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(255) NOT NULL,
    description NVARCHAR(MAX),
    category NVARCHAR(100),
    price DECIMAL(10, 2) NOT NULL,
    stock_quantity INT NOT NULL DEFAULT 0,
    is_active BIT NOT NULL DEFAULT 1,
    discount DECIMAL(5, 2) NOT NULL DEFAULT 0.00,
    created_at DATETIME NOT NULL DEFAULT GETDATE(),
    updated_at DATETIME NULL
);

-- Dummy Data Insertion
INSERT INTO products (
    name,
    description,
    category,
    price,
    stock_quantity,
    is_active,
    discount,
    created_at,
    updated_at
)
VALUES (
    'Wireless Mouse',
    'A smooth and ergonomic wireless mouse with USB receiver',
    'Electronics',
    499.99,
    50,
    1,
    10.00,
    GETDATE(),
    NULL
);