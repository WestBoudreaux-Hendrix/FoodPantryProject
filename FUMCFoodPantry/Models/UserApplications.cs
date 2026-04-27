using System.ComponentModel.DataAnnotations;

public class UserApplications
{
    public int Id { get; set; }
    public int MemberId { get; set;}
    public DateTime Date { get; set;}
    [Required]
    public string FirstName { get; set;}
    public string MiddleName { get; set;}
    [Required]
    public string LastName { get; set;}
    [Required]
    public string Address { get; set;}
    [Required]
    public string City { get; set;}
    [Required]
    [StringLength(2, MinimumLength = 2)]
    [RegularExpression("^[A-Z]{2}$", ErrorMessage = "State must be a valid 2-letter abbreviation.")]
    public string State { get; set;}
    [Required]
    public int Zip { get; set;}

}