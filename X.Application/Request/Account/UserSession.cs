namespace X.Application.Request.Account
{
    public record UserSession(Guid? Id, string? Name, string? Email, string Role);
}