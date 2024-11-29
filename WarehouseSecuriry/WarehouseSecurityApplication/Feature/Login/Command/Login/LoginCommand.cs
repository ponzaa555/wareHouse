using System;
using MediatR;

namespace WarehouseSecurityApplication.Feature.Login.Command.Login;

public class LoginCommand : IRequest<LoginResualt>
{
    public string Username {get; set;}
    public string Password {get; set;}
    public LoginCommand(string username , string password)
    {
        Username = username;
        Password = password;
    }
}
