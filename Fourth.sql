SELECT * FROM Customers;

SELECT * FROM Customers
LEFT JOIN Orders ON Customers.id = Orders.customer_id
    WHERE Orders.id IS NOT NULL;


SELECT * FROM Customers
LEFT JOIN Orders ON Customers.id = Orders.customer_id
    WHERE Orders.id IS NULL;

-- Probably index the email field in the customer table
-- because that's probably the field that you would
-- use to looks up customers; and index that customer_id
-- field in the orders table because that's what you'd use
-- to look up orders for each customer

SELECT
    Customers.name,
    Customers.email,
    COUNT(Orders.id)
FROM Customers
LEFT JOIN Orders ON Customers.id = Orders.customer_id
    WHERE Orders.id IS NOT NULL
GROUP BY Customer.name, Customer.email;


SELECT * FROM Customers
LEFT JOIN Orders ON Customers.id = Orders.customer_id
    WHERE Orders.id IS NOT NULL
    HAVING COUNT(Orders.id) >= 2
    AND COUNT(Orders.id) <= 5;