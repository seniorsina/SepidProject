using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models.Model;
public class Player
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? LastName { get;set; }
    [MaxLength(10)]
    [MinLength(10)]
    public string? BirthDate { get; set; }
    [MaxLength(10)]
    [MinLength(10)]
    public string? ContractStartDate { get; set; }
    [MaxLength(10)]
    [MinLength(10)]
    public string? ContractEndDate { get; set; }
    [MaxLength(10)]
    [MinLength(10)]
    public string? SocialNumber { get; set; }
    public string? Description { get; set; }
    public int? TeamId { get; set; }

    [ForeignKey("TeamId")]
    [JsonIgnore]
    public Team Team { get; set; }

}
