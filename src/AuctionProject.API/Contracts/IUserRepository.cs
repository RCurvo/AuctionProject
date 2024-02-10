using AuctionProject.API.Entities;

namespace AuctionProject.API.Contracts;

public interface IUserRepository
{
    public bool ExistsUserWithEmail(string email);

    public User GetUserByEmail(string email);
}
