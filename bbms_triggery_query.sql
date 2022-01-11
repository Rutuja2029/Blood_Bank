
Create TRIGGER UpdateRequestAndStock
ON REQUEST
FOR UPDATE
AS

DECLARE @stock_id INT
DECLARE @required_quantity INT
DECLARE @amount_to_pay DECIMAL(10,2)
DECLARE @remaining_quantity INT
DECLARE @bag_quantity INT
DECLARE @request_id INT
SELECT @stock_id = request_id from deleted
SELECT @stock_id = stock_id from deleted
SELECT @required_quantity = required_quantity from deleted
SELECT @amount_to_pay = @required_quantity*1000.00
SELECT @bag_quantity = bag_quantity from BLOODSTOCK where stock_id = @stock_id
SELECT @remaining_quantity = @bag_quantity-@required_quantity
BEGIN
IF @bag_quantity>0
UPDATE BLOODSTOCK SET bag_quantity =@remaining_quantity WHERE stock_id = @stock_id;

END;

UPDATE REQUEST SET status = 'Approved' WHERE request_id =1;

----------------------------------------------------------------
