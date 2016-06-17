<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CRUDOperation.ascx.cs" Inherits="Webform_with_entity_framework.CRUDOperation" %>

<div>
        <h1>Department Information</h1>
        <table id="depTable" border="1">
            <tr>
                <th>Department ID</th>
                <th>Department Name</th>
                <th>Employee ID</th>
                <th>Employee Name</th>
                <th>Employee Address</th>
            </tr>
            <p id="innerTable" runat="server">
            </p>
        </table>
        <p><asp:Button ID="btnAddDepartment" Text="Add Department" runat="server" OnClick="btnAddDepartment_Click"/>
           <asp:Button ID="btnUpdateDepartment" Text="Update Department" runat="server" OnClick="btnUpdateDepartment_Click"/>
           <asp:Button ID="btnDeleteDepartment" Text="Delete Department" runat="server" OnClick="btnDeleteDepartment_Click"/>
        </p>
        <p><asp:Button ID="btnAddEmployee" Text="Add Employee" runat="server" OnClick="btnAddEmployee_Click"/>
           <asp:Button ID="btnUpdateEmployee" Text="Update Employee" runat="server" OnClick="btnUpdateEmployee_Click"/>
           <asp:Button ID="btnDeleteEmployee" Text="Delete Employee" runat="server" OnClick="btnDeleteEmployee_Click"/>
        </p>
        <asp:Panel ID="departmentDataInput" runat="server" Visible="false">
          <table>
              <tr>
                  <td>Department ID: </td>
                  <td><asp:TextBox ID="txtDepartmentID" runat="server"></asp:TextBox></td>
              </tr>
              <tr id="deptName" runat="server">
                  <td>Department Name: </td>
                  <td><asp:TextBox ID="txtDepartmentName" runat="server"></asp:TextBox></td>
              </tr>
              <tr>
                  <td>
                     <asp:Button ID="btnConfirmDeleteDepartment" Text="Delete Department" runat="server" OnClick="btnConfirmDeleteDepartment_Click" Visible="false"/>
                     <asp:Button ID="btnConfirmAddDepartment" Text="Add Department" runat="server" OnClick="btnConfirmAddDepartment_Click"/>
                     <asp:Button ID="btnConfirmUpdateDepartment" Text="Update Department" runat="server" OnClick="btnConfirmUpdateDepartment_Click" Visible="false"/>
                  </td>
              </tr>
          </table>
        </asp:Panel>
        <asp:Panel ID="employeeDataInput" runat="server" Visible="false">
            <table>
               <tr id="empID" runat="server">
                  <td>Employee ID: </td>
                  <td><asp:TextBox ID="txtEmployeeID" runat="server"></asp:TextBox></td>
               </tr>
               <tr id="empName" runat="server">
                  <td>Employee Name: </td>
                  <td><asp:TextBox ID="txtEmployeeName" runat="server"></asp:TextBox></td>
              </tr>
              <tr id="empAddress" runat="server">
                  <td>Address: </td>
                  <td><asp:TextBox ID="txtEmployeeAddress" runat="server"></asp:TextBox></td>
              </tr>
              <tr id="empDept" runat="server">
                  <td>Department ID: </td>
                  <td><asp:TextBox ID="txtEmployeeDepartmentID" runat="server"></asp:TextBox></td>
              </tr>
              <tr>
                  <td>
                     <asp:Button ID="btnConfirmDeleteEmployee" Text="Delete Employee" runat="server" OnClick="btnConfirmDeleteEmployee_Click" Visible="false"/>
                     <asp:Button ID="btnConfirmAddEmployee" Text="Add Employee" runat="server" OnClick="btnConfirmAddEmployee_Click"/>
                     <asp:Button ID="btnConfirmUpdateEmployee" Text="Update Employee" runat="server" OnClick="btnConfirmUpdateEmployee_Click" Visible="false"/>
                  </td>
              </tr>
          </table>
        </asp:Panel>
    </div>
    