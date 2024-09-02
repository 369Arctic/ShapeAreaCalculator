# SQL Queries

## ������� 3

� ���� ������ MS SQL Server ���� �������� � ���������. ������ �������� ����� ��������������� ����� ���������, � ����� ��������� ����� ���� ����� ���������. �������� SQL ������ ��� ������ ���� ��� ���� �������� � ��� ���������. ���� � �������� ��� ���������, �� ��� ��� ��� ����� ������ ����������.

```sql
SELECT
    p.ProductName AS [Product Name],
    c.CategoryName AS [Category Name]
FROM
    Products p
LEFT JOIN
    ProductCategories pc ON p.ProductID = pc.ProductID
LEFT JOIN
    Categories c ON pc.CategoryID = c.CategoryID
ORDER BY
    p.ProductName,
    c.CategoryName;
