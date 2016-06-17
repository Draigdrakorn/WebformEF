using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webform_with_entity_framework
{
    public partial class CRUDOperation : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CRUDTestEntities ctx = new CRUDTestEntities();
            List<departmentSelect_Result> departmentList = ctx.departmentSelect().ToList();
            List<employeeSelect_Result> employeeList = ctx.employeeSelect().ToList();
            string departmentDetails = "";
            string employeeDetails = "";
            int totalEmployees = employeeList.Count();

            foreach (var dres in departmentList)
            {
                int dIDCounter = 0;
                foreach (var eres in employeeList)
                {
                    if (eres.DepartmentID == dres.DepartmentID)
                    {
                        dIDCounter++;
                    }
                }
                if (dIDCounter == 0)
                {
                    dIDCounter = 1;
                    employeeDetails = "<td colspan=\"3\"> No employee </td>";
                }
                else
                {
                    int employeeNoPerDepartment = 0;
                    for (int i = 0; i < employeeList.Count(); i++)
                    {
                        if (employeeList[i].DepartmentID == dres.DepartmentID)
                        {
                            employeeNoPerDepartment++;
                            if (employeeNoPerDepartment == 1)
                            {
                                employeeDetails = "<td>" + employeeList[i].Sno + "</td><td>" +
                                                    employeeList[i].Name + "</td><td>" +
                                                    employeeList[i].Address + "</td>";
                            }
                            else
                            {
                                employeeDetails += "</tr><tr><td>" + employeeList[i].Sno + "</td><td>" +
                                                    employeeList[i].Name + "</td><td>"
                                                    + employeeList[i].Address + "</td></tr>";
                            }
                        }
                    }
                }
                departmentDetails += "<tr><td rowspan=\"" + dIDCounter + "\">" +
                                     dres.DepartmentID + "</td><td rowspan=\"" +
                                     dIDCounter + "\">" +
                                     dres.DepartmentName + "</td>";
                if (dIDCounter <= 1)
                {
                    departmentDetails = departmentDetails + employeeDetails + "</tr>";
                }
                else
                {
                    departmentDetails = departmentDetails + employeeDetails;
                }
            }
            innerTable.InnerHtml = departmentDetails;
        }

        protected void btnAddDepartment_Click(object sender, EventArgs e)
        {
            employeeDataInput.Visible = false;
            departmentDataInput.Visible = true;
            btnConfirmUpdateDepartment.Visible = false;
            btnConfirmDeleteDepartment.Visible = false;
            btnConfirmAddDepartment.Visible = true;
            deptName.Visible = true;
        }

        protected void btnUpdateDepartment_Click(object sender, EventArgs e)
        {
            employeeDataInput.Visible = false;
            departmentDataInput.Visible = true;
            btnConfirmAddDepartment.Visible = false;
            btnConfirmDeleteDepartment.Visible = false;
            btnConfirmUpdateDepartment.Visible = true;
            deptName.Visible = true;
        }

        protected void btnDeleteDepartment_Click(object sender, EventArgs e)
        {
            employeeDataInput.Visible = false;
            departmentDataInput.Visible = true;
            btnConfirmAddDepartment.Visible = false;
            btnConfirmDeleteDepartment.Visible = true;
            btnConfirmUpdateDepartment.Visible = false;
            deptName.Visible = false;
        }

        protected void btnConfirmDeleteDepartment_Click(object sender, EventArgs e)
        {
            CRUDTestEntities ctx = new CRUDTestEntities();
            List<departmentSelect_Result> departmentList = ctx.departmentSelect().ToList();
            List<employeeSelect_Result> employeeList = ctx.employeeSelect().ToList();
            int departmentIDCheck = 0;
            string departmentID = txtDepartmentID.Text;
            foreach (var department in departmentList)
            {
                if (department.DepartmentID == departmentID)
                {
                    departmentIDCheck = 1;
                    break;
                }
                else
                {
                    departmentIDCheck = 0;
                }
            }
            if (departmentIDCheck == 1)
            {
                int dIDCounter = 0;
               
                    foreach (var eres in employeeList)
                    {
                        if (eres.DepartmentID == departmentID)
                        {
                            dIDCounter = 1;
                            break;
                        }
                    }
                    
                
                if (dIDCounter == 1 )
                {
                    Response.Write("<script>alert(\"The department Contains employees. Only empty Departments can be deleted.\")</script>");
                }
                else
                {
                    ctx.departmentDelete(departmentID);
                    Response.Redirect(Request.RawUrl);
                }
            }
            else
            {
                Response.Write("<script>alert(\"The department does not exist\")</script>");
            }
            
        }

        protected void btnConfirmAddDepartment_Click(object sender, EventArgs e)
        {
            CRUDTestEntities ctx = new CRUDTestEntities();
            string departmentID = txtDepartmentID.Text;
            string departmentName = txtDepartmentName.Text;
            ctx.departmentAdd(departmentID, departmentName);
            Response.Redirect(Request.RawUrl);
        }

        protected void btnConfirmUpdateDepartment_Click(object sender, EventArgs e)
        {
            CRUDTestEntities ctx = new CRUDTestEntities();
            List<departmentSelect_Result> departmentList = ctx.departmentSelect().ToList();
            int departmentIDCheck = 0;
            string departmentID = txtDepartmentID.Text;
            string departmentName = txtDepartmentName.Text;
            foreach (var department in departmentList)
            {
                if (department.DepartmentID == departmentID)
                {
                    departmentIDCheck = 1;
                    break;
                }
                else
                {
                    departmentIDCheck = 0;
                }
            }
            if (departmentIDCheck == 1)
            {
                ctx.departmentUpdate(departmentName, departmentID);
                Response.Redirect(Request.RawUrl);
            }
            else
            {
                Response.Write("<script>alert(\"The department does not exist\")</script>");
            }
        }

        protected void btnAddEmployee_Click(object sender, EventArgs e)
        {
            departmentDataInput.Visible = false;
            employeeDataInput.Visible = true;
            btnConfirmUpdateEmployee.Visible = false;
            btnConfirmDeleteEmployee.Visible = false;
            btnConfirmAddEmployee.Visible = true;
            empID.Visible = false;
            empName.Visible = true;
            empDept.Visible = true;
            empAddress.Visible = true;
        }

        protected void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            departmentDataInput.Visible = false;
            employeeDataInput.Visible = true;
            btnConfirmAddEmployee.Visible = false;
            btnConfirmUpdateEmployee.Visible = true;
            btnConfirmDeleteEmployee.Visible = false;
            empID.Visible = true;
            empName.Visible = true;
            empDept.Visible = true;
            empAddress.Visible = true;
        }

        protected void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            departmentDataInput.Visible = false;
            employeeDataInput.Visible = true;
            btnConfirmAddEmployee.Visible = false;
            btnConfirmUpdateEmployee.Visible = false;
            btnConfirmDeleteEmployee.Visible = true;
            empID.Visible = true;
            empName.Visible = false;
            empDept.Visible = false;
            empAddress.Visible = false;
        }

        protected void btnConfirmDeleteEmployee_Click(object sender, EventArgs e)
        {
            CRUDTestEntities ctx = new CRUDTestEntities();
            List<employeeSelect_Result> employeeList = ctx.employeeSelect().ToList();
            int employeeIDCheck = 0;
            int employeeID = Int32.Parse(txtEmployeeID.Text);
            foreach (var employee in employeeList   )
            {
                if (employee.Sno == employeeID)
                {
                    employeeIDCheck = 1;
                    break;
                }
                else
                {
                    employeeIDCheck = 0;
                }
            }
            if(employeeIDCheck == 1)
            {
                ctx.employeeDelete(employeeID);
                Response.Redirect(Request.RawUrl);
            }
            else
            {
                Response.Write("<script>alert(\"The Employee does not exist\")</script>");
            }
        }

        protected void btnConfirmAddEmployee_Click(object sender, EventArgs e)
        {
            CRUDTestEntities ctx = new CRUDTestEntities();
            List<departmentSelect_Result> departmentList = ctx.departmentSelect().ToList();
            int departmentIDCheck = 0;
            string employeeName = txtEmployeeName.Text;
            string employeeAddress = txtEmployeeAddress.Text;
            string departmentID = txtEmployeeDepartmentID.Text;
            foreach (var department in departmentList)
            {
                if(department.DepartmentID == departmentID)
                {
                    departmentIDCheck = 1;
                    break;
                }
                else
                {
                    departmentIDCheck = 0;
                }
            }
            if(departmentIDCheck == 1)
            {
                ctx.employeeAdd(employeeName, employeeAddress, departmentID);
                Response.Redirect(Request.RawUrl);
            }
            else
            {
                Response.Write("<script>alert(\"The department does not exist\")</script>");
            }
        }

        protected void btnConfirmUpdateEmployee_Click(object sender, EventArgs e)
        {
            CRUDTestEntities ctx = new CRUDTestEntities();
            List<employeeSelect_Result> employeeList = ctx.employeeSelect().ToList();
            int employeeIDCheck = 0;
            int employeeID = Int32.Parse(txtEmployeeID.Text);
            string employeeName = txtEmployeeName.Text;
            string employeeAddress = txtEmployeeAddress.Text;
            string departmentID = txtEmployeeDepartmentID.Text;
            foreach (var employee in employeeList)
            {
                if (employee.Sno == employeeID)
                {
                    employeeIDCheck = 1;
                    break;
                }
                else
                {
                    employeeIDCheck = 0;
                }
            }
            if (employeeIDCheck == 1)
            {
                ctx.employeeUpdate(employeeID, employeeName, employeeAddress, departmentID);
                Response.Redirect(Request.RawUrl);
            }
            else
            {
                Response.Write("<script>alert(\"The Employee does not exist\")</script>");
            }
        }
    }
}