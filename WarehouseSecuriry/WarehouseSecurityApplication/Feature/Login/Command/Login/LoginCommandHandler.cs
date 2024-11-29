using System;
using MediatR;
using WarehouseSecurityApplication.Contract;

namespace WarehouseSecurityApplication.Feature.Login.Command.Login;

public class LoginCommandHandler : IRequestHandler<LoginCommand,LoginResualt>
{
    private ISecurityRepository _repo;
    public LoginCommandHandler(ISecurityRepository repo)
    {
        _repo = repo;   
    }
    public async Task<LoginResualt> Handle(LoginCommand req , CancellationToken token)
    {
        throw new NotImplementedException();   
    }
}
