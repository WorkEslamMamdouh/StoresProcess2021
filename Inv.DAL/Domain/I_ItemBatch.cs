//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inv.DAL.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class I_ItemBatch
    {
        public int ItemBatchId { get; set; }
        public string BarCode { get; set; }
        public Nullable<int> ItemID { get; set; }
        public Nullable<int> CompCode { get; set; }
        public Nullable<decimal> OnhandQty { get; set; }
        public Nullable<decimal> ReceivedQty { get; set; }
        public Nullable<decimal> UnitCost { get; set; }
        public string BatchCode { get; set; }
        public Nullable<System.DateTime> ProdDate { get; set; }
        public Nullable<System.DateTime> ExpDate { get; set; }
        public string SerialNo { get; set; }
        public string ExtraSpecCode { get; set; }
        public Nullable<bool> IsAddable { get; set; }
        public Nullable<bool> IsDeliverable { get; set; }
        public string AddDelRemarks { get; set; }
        public string ProdBatchNo { get; set; }
    }
}
