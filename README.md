# POS Restaurant
POS Restaurant is a desktop-based application for the restaurant of any kind. This application built within .NET framework using C# programming language. This application suffice the data entry using either form or we can import from csv. The data entered is stored in memory and we can create order and generate report as per the requirement.

## User Manual
* Open application clicking the pos_restaurant.exe, which is a startup file. It can be seen when project is debugged or released.
* When an application starts, we will see the dashboard window. From this window, we can import data from csv and populate in our table. We can enter data manually in our table using form. We can use sorting option either by price or by name.
* When we insert some data and select any of those data, we will see Payment button.
* When we click Payment button, we will see payment panel. Here we can define quantity and cash we received from customer.
* Once the user enters the value of quantity for each item, the total amount is automatically calculated. As the user enters cash received, the system automatically returns the value of cash returns. If validation succeeded, we can confirm payment and stored in a table of sell report.
* We can see the confirmed data and chart of that table in Sell Report. Total revenue field returns and returns total sales.
All the data are stored in memory so if we close application, whatever we have stored will lost.

## Data Structure and Algorithm
*	__Microsoft.VisualBasic.IO__ - It is imported to parse data from CSV file using TextFieldParser.
*	__Collections__ - Collections is for storing data in List to retrieve or iterate those data later.
*	__Component Model__ - To sort data in data grid view, we use method of component model.
*	__LINQ__ - To make any query in rows of data, we use LINQ. Here, LINQ is for sum and count purposes of rows of data in data grid view and display total price and total record.
*	__Windows Forms__ - It is for taking input and giving output in a friendly GUI. 
