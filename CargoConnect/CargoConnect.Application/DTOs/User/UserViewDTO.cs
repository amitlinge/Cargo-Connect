using CargoConnect.Common.Enums;

public class UserViewDTO
{
    public Guid Id { get; set; }

    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Email { get; set; }
    public string Phone { get; set; }

    public Roles Role { get; set; }
}