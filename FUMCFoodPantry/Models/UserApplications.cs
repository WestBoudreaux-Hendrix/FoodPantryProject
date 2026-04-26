using System.ComponentModel.DataAnnotations;

public class UserApplications
{
    [Required]
    public int Id { get; set; }
    [Required]
    public int MemberId { get; set;}
    [Required]
    public DateTime Date { get; set;}
    [Required]
    public String FirstName { get; set;}
    [Required]
    public String MiddleName { get; set;}
    [Required]
    public String LastName { get; set;}
    [Required]
    public String Address { get; set;}
    [Required]
    public String City { get; set;}
    [Required]
    [StringLength(2, MinimumLength = 2)]
    [RegularExpression("^[A-Z]{2}$", ErrorMessage = "State must be a valid 2-letter abbreviation.")]
    public String State { get; set;}
    [Required]
    public int Zip { get; set;}

}