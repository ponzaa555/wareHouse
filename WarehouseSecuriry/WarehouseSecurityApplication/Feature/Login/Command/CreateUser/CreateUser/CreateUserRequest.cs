using System;

namespace WarehouseSecurityApplication.Feature.Login.Command.CreateUser.CreateUser;

public class CreateUserRequest
{
    public string Username {get; set;}
    public string Password {get; set;}
}
