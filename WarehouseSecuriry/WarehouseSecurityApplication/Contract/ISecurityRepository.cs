using WarehouseSecurityApplication.Feature.Login.Command.CreateUser;
using WarehouseSecurityApplication.Feature.Login.Command.CreateUser.CreateUser;
using WarehouseSecurityApplication.Feature.Login.Command.Login;

namespace WarehouseSecurityApplication.Contract;

public interface ISecurityRepository
{
    Task<LoginResualt> login(LoginCommand request);
    Task<CreateUserResualt> CreateUser(CreateUserCommand command);
}
