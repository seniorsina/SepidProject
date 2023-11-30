using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TeamManagementAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class SysListController : ControllerBase
{
    private ISysListRepository sysListRepository;
    public SysListController(ISysListRepository sysListRepository)
    {
        this.sysListRepository = sysListRepository;
    }

    [HttpGet("{flag:int}")]
    public IActionResult GetSysListByFl(int flag)
    {
        try
        {
            var list = sysListRepository.GetSysListByFlag(flag);
            return Ok(list);
        }
        catch
        {
            return StatusCode(500);
        }
    }
}
