using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Model;
using Repository;

namespace TeamManagementAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PlayerController : ControllerBase
{
    private IPlayerRepository playerRepository;
    public PlayerController(IPlayerRepository p)
    {
        playerRepository = p;
    }

    [HttpGet]
    public IActionResult GetAllplayer()
    {
        try
        {
            var player = playerRepository.GetAllPlayer(false).ToList();
            return Ok(player);
        }
        catch
        {
            return StatusCode(500);
        }
    }

    [HttpGet("{teamid:int}")]
    public IActionResult GetPlayerOfTeam(int teamId)
    {
        try
        {
          var players =  playerRepository.GetTeamPlayers(teamId,false);
            return Ok(players);
        }
        catch
        {
            return StatusCode(500);
        }
    }

    [HttpPost]
    public IActionResult AddNewPlayer([FromBody] PalyerDTO P)
    {
        try
        {
            Player player = new Player()
            {
                Name = P.Name,
                LastName = P.LastName,
                BirthDate = P.BirthDate,
                SocialNumber = P.SocialNumber,
                TeamId = P.TeamId,
                ContractStartDate = P.ContractStartDate,
                ContractEndDate = P.ContractEndDate,
                Description = P.Description,
            };
            playerRepository.AddPlayer(player);
            return Ok();
        }
        catch
        {
            return StatusCode(500);
        }
    }


    [HttpPut]
    public IActionResult UpdateAPlayer([FromBody] PalyerUpdateDTO P)
    {
        try
        {
            Player player = playerRepository.GetPlayer(P.Id);

            if (player == null)
            {
                return NotFound();
            }
            player.Name = P.Name;
            player.LastName = P.LastName;
            player.BirthDate = P.BirthDate;
            player.SocialNumber = P.SocialNumber;
            player.TeamId = P.TeamId;
            player.ContractStartDate = P.ContractStartDate;
            player.ContractEndDate = P.ContractEndDate;
            player.Description = P.Description;
            playerRepository.UpdateAPlayer(player);
            return Ok();
        }
        catch
        {
            return StatusCode(500);
        }
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteAPlayer(int id)
    {
        try
        {
            playerRepository.RemoveAPlayer(id);
            return Ok();
        }
        catch
        {
            return StatusCode(500);
        }
    }
}
