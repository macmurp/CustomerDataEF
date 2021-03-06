USE [CustomerData]
GO
/****** Object:  StoredProcedure [dbo].[getCustomers]    Script Date: 3/13/2021 7:49:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getCustomers] 
AS
BEGIN

select c.CustomerID, c.Firstname, c.Lastname, a.AddressID, a.City, a.[State], a.Street, a.Zip
from Customers as c
inner join Addresses as a
on c.CustomerID = a.CustomerID

END
GO
/****** Object:  StoredProcedure [dbo].[updateCustomers]    Script Date: 3/13/2021 7:49:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updateCustomers]
	@Firstname VARCHAR(50),
	@CustomerID int
AS
BEGIN

update Customers
set
Firstname = @Firstname
where
CustomerID = @CustomerID
END
GO
