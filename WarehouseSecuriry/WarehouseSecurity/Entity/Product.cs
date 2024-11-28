using System;
using System.Collections.Generic;

namespace WarehouseSecurity.Entity;

public partial class Product
{
    public string ProductId { get; set; } = null!;

    public string? Barcode { get; set; }

    public string? Productname { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }

    public bool? IsActive { get; set; }
}
