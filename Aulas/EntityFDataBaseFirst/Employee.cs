
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace EntityFDataBaseFirst
{

using System;
    using System.Collections.Generic;
    
public partial class Employee
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Employee()
    {

        this.EmployeeDepartmentHistory = new HashSet<EmployeeDepartmentHistory>();

        this.EmployeePayHistory = new HashSet<EmployeePayHistory>();

        this.JobCandidate = new HashSet<JobCandidate>();

        this.PurchaseOrderHeader = new HashSet<PurchaseOrderHeader>();

    }


    public int BusinessEntityID { get; set; }

    public string NationalIDNumber { get; set; }

    public string LoginID { get; set; }

    public Nullable<short> OrganizationLevel { get; set; }

    public string JobTitle { get; set; }

    public System.DateTime BirthDate { get; set; }

    public string MaritalStatus { get; set; }

    public string Gender { get; set; }

    public System.DateTime HireDate { get; set; }

    public bool SalariedFlag { get; set; }

    public short VacationHours { get; set; }

    public short SickLeaveHours { get; set; }

    public bool CurrentFlag { get; set; }

    public System.Guid rowguid { get; set; }

    public System.DateTime ModifiedDate { get; set; }



    public virtual Person Person { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<EmployeePayHistory> EmployeePayHistory { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<JobCandidate> JobCandidate { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeader { get; set; }

    public virtual SalesPerson SalesPerson { get; set; }

}

}
