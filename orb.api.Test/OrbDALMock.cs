namespace orb.api.test;
using orb.api.DAL;
using orb.api.DTOs;

class OrbDALMock : IOrbDAL
{
    private readonly List<StateDTO> states;

    public OrbDALMock()
    {
        states = new List<StateDTO>()
        {
            new StateDTO() { StateName = "PA" }, 
            new StateDTO() { StateName = "MD" }, 
            new StateDTO() { StateName = "FL" },
        };
    }
    public List<StateDTO> GetStates()
    {
        return this.states;
    }

    public List<CountyDTO> GetCountiesByState(string stateName) => throw new NotImplementedException();
}