namespace Project.RequestModels;

public class CreateIndividualClientModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PESEL { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
}