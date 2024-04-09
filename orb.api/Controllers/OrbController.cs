using Microsoft.AspNetCore.Mvc;
using orb.api.DAL;
using orb.api.DTOs;

namespace orb.api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrbController
{
    private readonly IOrbDAL _dal;

    public OrbController(IOrbDAL dal) 
    {
        _dal = dal;
    }

    //GET: api/orb
    [HttpGet]
    public ActionResult<IEnumerable<StateDTO>> GetStates()
    {
        var states = _dal.GetStates();
        return states;
    }

    //GET: api/orb/PA
    [HttpGet("{state}")]
    public ActionResult<IEnumerable<CountyDTO>> GetCountiesByState(string state)
    {
        var counties = _dal.GetCountiesByState(state);
        return counties;
    }
}
