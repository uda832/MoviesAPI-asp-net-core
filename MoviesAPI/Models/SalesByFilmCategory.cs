using System;
using System.Collections.Generic;

namespace MoviesAPI
{
    public partial class SalesByFilmCategory
    {
        public string Category { get; set; }
        public decimal? TotalSales { get; set; }
    }
}
