namespace ClubMembershipApplication;

public interface ILogin
{
    User Login(string emailAddress, string password);
}