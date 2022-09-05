# SalesTaxesApp

This is a windows forms application created in order to solve Problem #2 from the proposed exercises (Sales Tax). The application consists of 3 basic forms
in order to simulate a cash register, generate a receipt and manage inventory information.

Among the basic classes created are the following:
CartLineItem - Individual items whithin the Shopping Cart
ShoppingCart - Main object for the Shopping Cart
Product - Basic Product Information
Enums - Holds ProductTypeEnum (Book, Exercise, Electronics, Food and Medical types)

The following windows forms were created.
CashRegister - Manages Shopping Cart information,
Inventory - Manages Inventory Information,
Receipt - Displays a cash receipt.

There's also a Test project for Unit testing (using NUnit), the basic tests are centered among the functionality for the shopping Cart, the following test cases 
have been created:

CalculateSubTotal,
CalculateSalesTax,
CalculateTotal,
IsTaxExempt,
IsNotTaxExempt,
IsIimportedGood

The system also allows to manage Inventory, the only functionality missing is in regards taking into consideration Tax-Free states.

The solution was created using Visual Studio 2022 and C#.
