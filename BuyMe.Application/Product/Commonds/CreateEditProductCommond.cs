﻿using BuyMe.Domain.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyMe.Application.Product.Commonds
{
    public class CreateEditProductCommond: IRequest<int>
    {
        public int? ProductId { get; set; }
        public string ProductName { get; set; }
        public int? CategoryId { get; set; }
        public string Barcode { get; set; }
        public Decimal? DefaultBuyingPrice { get; set; }
        public Decimal? DefaultSellingPrice { get; set; }
        public int? CurrencyId { get; set; }
        public int? BranchId { get; set; }
        public string BranchName { get; set; }
        public string Description { get; set; }
        public int? UnitOfMeasureId { get; set; }
        public string UOM { get; set; }
        public int? CompanyId { get; set; }
        public string CurrencyCode { get; set; }
    }
}