using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public struct PalyerDTO
{
    public string? Name { get; set; }

    public string? LastName { get; set; }

    public string? BirthDate { get; set; }

    public string? ContractStartDate { get; set; }

    public string? ContractEndDate { get; set; }

    public string? SocialNumber { get; set; }
    public string? Description { get; set; }
    public int? TeamId { get; set; }
}

public struct PalyerUpdateDTO
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public string? LastName { get; set; }

    public string? BirthDate { get; set; }

    public string? ContractStartDate { get; set; }

    public string? ContractEndDate { get; set; }

    public string? SocialNumber { get; set; }
    public string? Description { get; set; }
    public int? TeamId { get; set; }
}