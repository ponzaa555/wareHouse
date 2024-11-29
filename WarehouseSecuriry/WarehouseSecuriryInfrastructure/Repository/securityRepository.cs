using System;
using WarehouseSecurity.Entity;
using WarehouseSecurityApplication.Contract;
using WarehouseSecurityApplication.Feature.Login.Command.CreateUser;
using WarehouseSecurityApplication.Feature.Login.Command.CreateUser.CreateUser;
using WarehouseSecurityApplication.Feature.Login.Command.Login;


namespace WarehouseSecuriryInfrastructure.Repository;

public class securityRepository : ISecurityRepository
{
    private readonly SecurityContext _context;
    private DateTime _date = DateTime.Now;
    public securityRepository(SecurityContext context)
    {
        _context = context;
    }

    public async Task<CreateUserResualt> CreateUser(CreateUserCommand command)
    {
        var userId = Guid.NewGuid().ToString();
        var res = new CreateUserResualt();
        Account account = new Account
        {
            Id = userId,
            Username = command.Username,
            Password = command.Password,
            CreateDate = _date
        };
        await _context.Account.AddAsync(account);
        _context.SaveChanges();
        res.Msg = $"Create userId : {userId} sucessful";
        return res;
    }

    public Task<LoginResualt> login(LoginCommand request)
    {
        throw new NotImplementedException();
    }
}
