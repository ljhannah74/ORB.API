using orb.api.Controllers;
using orb.api.DAL;
using orb.api.DTOs;
using orb.api.test;

namespace orb.api.Test;

public class OrbControllerTest
{
     private readonly OrbController _controller;
     private readonly IOrbDAL _dal;

    public OrbControllerTest()
    {
        _dal = new OrbDALMock();
        _controller = new OrbController(_dal);
    }

    [Fact]
    public void GetStates_WhenCalled_ReturnsData()
    {
        var okResult = _controller.GetStates();

        var states = Assert.IsType<List<StateDTO>>(okResult.Value);

        Assert.Equal(3, states.Count);
    }
}