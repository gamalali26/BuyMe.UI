﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyMe.Application.Common.Models
{
    public class DataManager
    {
        public DataManager(int? take = null, int? skip = null, string searchValue = null)
        {
            Take = take;
            Skip = skip;
            SearchValue = searchValue;
        }
        public int? Take { get; set; }
        public int? Skip { get; set; }
        public string SearchValue { get; set; }
    }
}
