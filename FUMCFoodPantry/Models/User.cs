using System.ComponentModel.DataAnnotations;

public class User
{
    public int Id { get; set; }

    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    public string MiddleName { get; set; }

    [Required]
    public string Role { get; set; }

    public DateTime DateJoined { get; set; }


    public string AdditionalInformation {get; set; }
    
}