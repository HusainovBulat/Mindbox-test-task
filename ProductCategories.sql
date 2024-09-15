SELECT p.Name, c.Name
FROM Products p
LEFT JOIN ProductCategories pc ON p.ID = pc.ProductID
LEFT JOIN Categories c ON pc.CategoryID = c.ID;