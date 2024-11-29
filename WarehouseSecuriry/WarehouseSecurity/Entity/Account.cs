using System;
using System.Collections.Generic;

namespace WarehouseSecurity.Entity;

public partial class Account
{
    public string Id { get; set; } = null!;

    public string? Username { get; set; }

    public string? Password { get; set; }

    public DateTime? CreateDate { get; set; }
}
