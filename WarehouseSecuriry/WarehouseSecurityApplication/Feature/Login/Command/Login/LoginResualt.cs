using System;

namespace WarehouseSecurityApplication.Feature.Login.Command.Login;

public class LoginResualt
{
    public string Username {get; set;}
    public string token {get; set;}
    public DateTime Expired {get; set;}
    public string Role {get; set;}
}
