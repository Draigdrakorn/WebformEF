﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Webform_with_entity_framework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CRUDTestEntities : DbContext
    {
        public CRUDTestEntities()
            : base("name=CRUDTestEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DepartmentInformation> DepartmentInformations { get; set; }
        public virtual DbSet<EmployeeInformation> EmployeeInformations { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    
        public virtual int departmentAdd(string departmentID, string departmentName)
        {
            var departmentIDParameter = departmentID != null ?
                new ObjectParameter("DepartmentID", departmentID) :
                new ObjectParameter("DepartmentID", typeof(string));
    
            var departmentNameParameter = departmentName != null ?
                new ObjectParameter("DepartmentName", departmentName) :
                new ObjectParameter("DepartmentName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("departmentAdd", departmentIDParameter, departmentNameParameter);
        }
    
        public virtual int departmentDelete(string departmentID)
        {
            var departmentIDParameter = departmentID != null ?
                new ObjectParameter("DepartmentID", departmentID) :
                new ObjectParameter("DepartmentID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("departmentDelete", departmentIDParameter);
        }
    
        public virtual ObjectResult<departmentSelect_Result> departmentSelect()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<departmentSelect_Result>("departmentSelect");
        }
    
        public virtual int departmentUpdate(string departmentName, string departmentID)
        {
            var departmentNameParameter = departmentName != null ?
                new ObjectParameter("DepartmentName", departmentName) :
                new ObjectParameter("DepartmentName", typeof(string));
    
            var departmentIDParameter = departmentID != null ?
                new ObjectParameter("DepartmentID", departmentID) :
                new ObjectParameter("DepartmentID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("departmentUpdate", departmentNameParameter, departmentIDParameter);
        }
    
        public virtual int employeeAdd(string name, string address, string departmentID)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var departmentIDParameter = departmentID != null ?
                new ObjectParameter("DepartmentID", departmentID) :
                new ObjectParameter("DepartmentID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("employeeAdd", nameParameter, addressParameter, departmentIDParameter);
        }
    
        public virtual int employeeDelete(Nullable<int> sno)
        {
            var snoParameter = sno.HasValue ?
                new ObjectParameter("Sno", sno) :
                new ObjectParameter("Sno", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("employeeDelete", snoParameter);
        }
    
        public virtual ObjectResult<employeeSelect_Result> employeeSelect()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<employeeSelect_Result>("employeeSelect");
        }
    
        public virtual int employeeUpdate(Nullable<int> sno, string name, string address, string departmentID)
        {
            var snoParameter = sno.HasValue ?
                new ObjectParameter("Sno", sno) :
                new ObjectParameter("Sno", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var departmentIDParameter = departmentID != null ?
                new ObjectParameter("DepartmentID", departmentID) :
                new ObjectParameter("DepartmentID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("employeeUpdate", snoParameter, nameParameter, addressParameter, departmentIDParameter);
        }
    
        public virtual ObjectResult<selectDepartmentByID_Result> selectDepartmentByID(string departmentID)
        {
            var departmentIDParameter = departmentID != null ?
                new ObjectParameter("DepartmentID", departmentID) :
                new ObjectParameter("DepartmentID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<selectDepartmentByID_Result>("selectDepartmentByID", departmentIDParameter);
        }
    
        public virtual ObjectResult<selectEmployeeByID_Result> selectEmployeeByID(Nullable<int> sno)
        {
            var snoParameter = sno.HasValue ?
                new ObjectParameter("Sno", sno) :
                new ObjectParameter("Sno", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<selectEmployeeByID_Result>("selectEmployeeByID", snoParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}