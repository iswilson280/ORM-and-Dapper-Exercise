﻿
using System;
namespace ORM_Dapper
{
	public class Product
	{
        public int ProductID { get; set; }
        public double Price { get; set; }
        public int CategoryID { get; set; }
        public bool OnSale { get; set; }
        public int StockLevel { get; set; }
    }

}


