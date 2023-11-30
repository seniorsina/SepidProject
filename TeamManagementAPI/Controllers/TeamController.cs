using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

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
}
