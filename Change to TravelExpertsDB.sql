
USE TravelExperts

ALTER TABLE Customers ADD username VARCHAR(50),
	password VARCHAR(255) 
GO



CREATE UNIQUE NONCLUSTERED INDEX idx_username_notnull ON Customers(username)
WHERE username IS NOT NULL
GO  

ALTER TABLE Customers ADD CONSTRAINT username_length CHECK(datalength(username)>=5)  
GO

ALTER TABLE Customers ADD CONSTRAINT password_length CHECK(datalength(password)>=5)  
GO


INSERT INTO Customers(CustFirstName,CustLastName,CustAddress,CustCity,CustProv,CustPostal,CustCountry,CustHomePhone,CustBusPhone,CustEmail,username,password)
VALUES('Admin','Admin','SAIT','Calgary','AB','I1I 1I1','Canada','000-000','000-000','1@2.com','admin','P@ssw0rd')
