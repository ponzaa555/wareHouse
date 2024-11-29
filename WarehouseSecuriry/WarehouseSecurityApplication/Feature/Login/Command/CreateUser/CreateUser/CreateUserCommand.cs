using System;
using MediatR;
using WarehouseSecurityApplication.Feature.Login.Command.CreateUser.CreateUser;

namespace WarehouseSecurityApplication.Feature.Login.Command.CreateUser;

public class CreateUserCommand : IRequest<CreateUserResualt>
{
    public string Username {get; set;}
    public string Password {get; set;}
    public CreateUserCommand(string username , string password)
    {
        Username = username ;
        Password = password;
    }
}
