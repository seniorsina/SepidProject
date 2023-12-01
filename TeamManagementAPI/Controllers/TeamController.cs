using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Models.Model;

namespace TeamManagementAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TeamController : ControllerBase
{
    private ITeamRepository teamRepository;
    public TeamController(ITeamRepository team)
    {
        teamRepository = team;
    }

    [HttpGet]
    public IActionResult GetAllTeam()
    {
        try
        {
            var teamList = teamRepository.GetAllTeam(false).ToList();
            return Ok(teamList);
        }
        catch
        {
            return StatusCode(500);
        }
    }

    [HttpPost]
    public IActionResult AddNewTeam([FromBody] TeamDto t)
    {
        try
        {
            Team team = new Team()
            {
                Name = t.Name,
                EstablishmentِDate = t.EstablishmentِDate,
                TeamType = t.TeamType,
                Grade = t.Grade,
                FirstColor = t.FirstColor,
                SecondColor = t.SecondColor,
                Description = t.Description,
                Players = new List<Player>()
            };
            teamRepository.AddTeam(team);
            return Ok();
        }
        catch
        {
            return StatusCode(500);
        }
    }


    [HttpPut]
    public IActionResult UpdateTeam([FromBody] Team t)
    {
        try
        {
            Team team = teamRepository.GetTeam(t.Id);

            if (team == null)
            {
                return NotFound();
            }
            team.Name = t.Name;
            team.EstablishmentِDate = t.EstablishmentِDate;
            team.TeamType = t.TeamType;
            team.Grade = t.Grade;
            team.FirstColor = t.FirstColor;
            team.SecondColor = t.SecondColor;
            team.Description = t.Description;
            teamRepository.UpdateATeam(team);
            return Ok();
        }
        catch
        {
            return StatusCode(500);
        }
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteATeam(int id)
    {
        try
        {
            teamRepository.RemoveATeam(id);
            return Ok();
        }
        catch
        {
            return StatusCode(500);
        }
    }

}
