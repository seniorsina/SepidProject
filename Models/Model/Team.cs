using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Model;

namespace Models.Model;
public class Team
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required(ErrorMessage = "وارد کردن نام تیم الزامی  می باشد")]
    public string Name { get; set; }
    [MaxLength(10)]
    [MinLength(10)]
    public string EstablishmentِDate { get; set; }
    public string TeamType { get; set; }

    public string Grade { get; set; }
    public string FirstColor { get; set; }
    public string SecondColor { get; set; }
    public string? Description { get; set; }

    public ICollection<Player> Players { get; set; }
}
