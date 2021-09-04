﻿namespace BuyMe.Domain.Entities
{
    public class SalesType
    {
        public int Id { get; set; }
        public string SalesTypeName { get; set; }
        public string SalesTypeDescription { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}