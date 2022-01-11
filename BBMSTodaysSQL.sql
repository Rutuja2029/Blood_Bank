CREATE DATABASE BBMS;

CREATE TABLE BLOODSTOCK(
stock_id int primary key identity,
blood_group varchar(250),
price_perBag decimal(10,2),
status varchar(250),bag_quantity int

);

select * from BLOODSTOCK;

CREATE TABLE HOSPITAL(
hospital_id int primary key identity,
hospital_name varchar(250),
address varchar(250),
phone_no varchar(250),
email varchar(250),
password varchar(250),
state varchar(250),
city varchar(250),
createdOn Date,
updatedOn Date
);
select * from HOSPITAL;

CREATE TABLE ADMIN (
admin_id int primary key identity,
admin_name varchar(250),
admin_email varchar(250),
admin_password varchar(250),
isActive varchar(50)
);
select * from ADMIN;

CREATE TABLE REQUEST(
request_id int primary key identity,
request_date Date,
hospital_id int foreign key references HOSPITAL(hospital_id),
required_quantity int,
stock_id int foreign key references BLOODSTOCK(stock_id),
status varchar(250),
amount_to_pay decimal(10,2),
paymentStatus varchar(150),
createdOn Date,
updatedOn Date
);

select * from REQUEST;
select * from Hospital;
select * from BLOODSTOCK;
DELETE FROM REQUEST;
UPDATE BLOODSTOCK SET bag_quantity=12 WHERE stock_id=1;
INSERT INTO Admin Values('Rutuja','rutuja@gmail.com','password','Active');

INSERT INTO HOSPITAL VALUES('Synergy Hospital','Sangli','0233-456565','synergy@gmail.com','password','MH','Sangli',GETDATE(),null);
INSERT INTO HOSPITAL VALUES('Civil Hospital','Kolhapur','0221-343435','kcve@gov.in','password','MH','Kolhapur',GETDATE(),null);

INSERT INTO BLOODSTOCK VALUES('O Positive',1000.00,'Available',12),('O Negative',1000.00,'Available',12),('A Positive',1000.00,'Available',12),('B Positive',1000.00,'Available',12),('AB Positive',1000.00,'Available',12),('AB Negative',1000.00,'Available',12),('B Negative',1000.00,'Available',12);

INSERT INTO REQUEST VALUES(GETDATE(),1,2,1,'Pending',null,'InComplete',GETDATE(),NULL);

SELECT * FROM REQUEST;

UPDATE REQUEST SET status='Approved' WHERE request_id=4;