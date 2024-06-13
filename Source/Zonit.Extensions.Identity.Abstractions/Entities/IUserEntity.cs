namespace Zonit.Extensions.Identity;

public interface IUserEntity
{
    public UserModel? User { get; init; }
    public Guid? UserId { get; set; }
}