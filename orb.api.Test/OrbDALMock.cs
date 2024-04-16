namespace orb.api.test;
using orb.api.DAL;
using orb.api.DTOs;

class OrbDALMock : IOrbDAL
{
    private readonly List<StateDTO> states;
    private readonly List<CountyDTO> counties;

    public OrbDALMock()
    {
        states = new List<StateDTO>()
        {
            new StateDTO() { StateName = "PA" }, 
            new StateDTO() { StateName = "MD" }, 
            new StateDTO() { StateName = "FL" },
        };

        counties = new List<CountyDTO>()
        {
            new CountyDTO() { StateName = "PA", CountyName = "WASHINGTON" },
            new CountyDTO() { StateName = "PA", CountyName = "ALLEGHENY" },
            new CountyDTO() { StateName = "MD", CountyName = "BALTIMORE" },
        };
    }
    public List<StateDTO> GetStates()
    {
        return this.states;
    }

    public List<CountyDTO> GetCountiesByState(string stateName)
    {
        return this.counties.Where(c => c.StateName == stateName).ToList();
    }
}