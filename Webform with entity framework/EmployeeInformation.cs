//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class EmployeeInformation
    {
        public int Sno { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string DepartmentID { get; set; }
    
        public virtual DepartmentInformation DepartmentInformation { get; set; }
    }
}
