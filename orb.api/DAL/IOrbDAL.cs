namespace orb.api.DAL;

using orb.api.DTOs;

public interface IOrbDAL
{
    List<StateDTO> GetStates();
    List<CountyDTO> GetCountiesByState(string stateName);
}
