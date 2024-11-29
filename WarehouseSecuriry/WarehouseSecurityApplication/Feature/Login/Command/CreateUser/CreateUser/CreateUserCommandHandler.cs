using System;
using MediatR;
using WarehouseSecurityApplication.Contract;

namespace WarehouseSecurityApplication.Feature.Login.Command.CreateUser.CreateUser;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand , CreateUserResualt>
{
    private ISecurityRepository _repo;
    public CreateUserCommandHandler(ISecurityRepository repo)
    {
        _repo =repo;
    }
    public async Task<CreateUserResualt> Handle(CreateUserCommand command , CancellationToken token)
    {
        var res = new CreateUserResualt();
        res = await _repo.CreateUser(command);
        return res;
    }
}
