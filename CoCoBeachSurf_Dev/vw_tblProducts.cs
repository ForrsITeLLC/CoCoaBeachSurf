﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace AuthModule
{
    public class vw_tblProducts
    {
        public int PrdId { get; set; }
        public int PrdCatId { get; set; }
        public string PrdCode { get; set; }
        public string PrdEngDesc { get; set; }
        public decimal PrdPrice { get; set; }
        public bool PrdStatus { get; set; }
        public DateTime PrdCreatedDate { get; set; }
        public string PrdCreatedBy { get; set; }
        public DateTime PrdModifiedDate { get; set; }
        public string PrdModifiedBy { get; set; }
        public string Category { get; set; }
        public string PrdMfCode { get; set; }
        public string PrdESPDesc { get; set; }
        public bool PrdTaxable { get; set; }
        public int quantity { get; set; }
    }
}