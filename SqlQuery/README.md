# SQL Query

## Задание №3

В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

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
