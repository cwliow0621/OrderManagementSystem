//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderTransaction
    {
        public int OrderTransactionId { get; set; }
        public string Name { get; set; }
        public Nullable<int> Employee_EmployeeId { get; set; }
        public Nullable<int> Inventory_InventoryId { get; set; }
        public Nullable<int> Product_ProductId { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Inventory Inventory { get; set; }
        public virtual Product Product { get; set; }
    }
}