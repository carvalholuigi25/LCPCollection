namespace LCPCollection.Shared.Classes.Auth;
public class AuthenticatedResponse
{
    public string? Token { get; set; }
    public string? RefreshToken { get; set; }
    public Users? UsersInfo { get; set; }
}
