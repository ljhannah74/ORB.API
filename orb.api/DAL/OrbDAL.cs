namespace orb.api.DAL;

using Microsoft.Data.Sqlite;
using orb.api.DTOs;
public class OrbDAL : IOrbDAL
{
    private readonly string _connectionString = "DataSource=ORB_DATABASE.db";

    public OrbDAL() {}

    public List<StateDTO> GetStates() 
    {
        var states = new List<StateDTO>();

        using(var connection = new SqliteConnection(_connectionString))
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "SELECT DISTINCT state from ORB";

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var state = new StateDTO
                    {
                        StateName = reader.GetString(0)
                    };
                    states.Add(state);
                }
            }
        }

        return states;
    }

    public List<CountyDTO> GetCountiesByState(string stateName)
    {
        var counties = new List<CountyDTO>();

        using(var connection = new SqliteConnection(_connectionString))
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "SELECT DISTINCT county from ORB WHERE state=@state";
            command.Parameters.AddWithValue("@state", stateName);

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var county = new CountyDTO
                    {
                        StateName = stateName,
                        CountyName = reader.GetString(0)
                    };
                    counties.Add(county);
                }
            }
        }

        return counties;
    }
}

