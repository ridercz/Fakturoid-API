//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InvoicingImport.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Invoice
    {
        public Invoice()
        {
            this.Items = new HashSet<Item>();
            this.Payments = new HashSet<Payment>();
        }
    
        public int InvoiceId { get; set; }
        public int SeqId { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateTaxed { get; set; }
        public System.DateTime DateDue { get; set; }
        public int ContactId { get; set; }
        public int BillAddress { get; set; }
        public int PostalAddress { get; set; }
        public int PaymentMethod { get; set; }
        public string Notes { get; set; }
        public string InternalNotes { get; set; }
    
        public virtual Contact Contact { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}