namespace ClubMembershipApplication;

public interface IRegister
{
    bool Register(string[] fields);
    bool EmailExists(string emailAddress);

}