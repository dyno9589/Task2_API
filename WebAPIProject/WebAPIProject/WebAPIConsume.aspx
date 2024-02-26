<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebAPIConsume.aspx.cs" Inherits="WebAPIProject.WebAPIConsume" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Employee CRUD</title>
</head>
<body>
    <h1>Employee CRUD Operations</h1>

    <!-- Display Employees -->
    <h2>Employee List</h2>
    <ul id="employeeList"></ul>

    <!-- Add Employee Form -->
    <h2>Add Employee</h2>
    <form id="addEmployeeForm">
        <label for="firstName">First Name:</label>
        <input type="text" id="firstName" required>
        <label for="lastName">Last Name:</label>
        <input type="text" id="lastName" required>
        <label for="gender">Gender:</label>
        <input type="text" id="gender" required>
        <label for="salary">Salary:</label>
        <input type="number" id="salary" required>
        <button type="button" onclick="addEmployee()">Add Employee</button>
    </form>

    <!-- Update Employee Form -->
    <h2>Update Employee</h2>
    <form id="updateEmployeeForm">
        <label for="updateId">Employee ID to Update:</label>
        <input type="number" id="updateId" required>
        <label for="updateFirstName">First Name:</label>
        <input type="text" id="updateFirstName" required>
        <label for="updateLastName">Last Name:</label>
        <input type="text" id="updateLastName" required>
        <label for="updateGender">Gender:</label>
        <input type="text" id="updateGender" required>
        <label for="updateSalary">Salary:</label>
        <input type="number" id="updateSalary" required>
        <button type="button" onclick="updateEmployee()">Update Employee</button>
    </form>

    <!-- Delete Employee Form -->
    <h2>Delete Employee</h2>
    <form id="deleteEmployeeForm">
        <label for="deleteId">Employee ID to Delete:</label>
        <input type="number" id="deleteId" required>
        <button type="button" onclick="deleteEmployee()">Delete Employee</button>
    </form>

    <script src="scripts.js"></script>
</body>
</html>
