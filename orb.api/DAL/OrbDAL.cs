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

    public OrbDTO GetOrbByCountyState(string stateName, string countyName)
    {
        var resource = new OrbDTO();

        using(var connection = new SqliteConnection(_connectionString))
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "SELECT * from ORB WHERE state=@state AND county=@county";
            command.Parameters.AddWithValue("@state", stateName);
            command.Parameters.AddWithValue("@county", countyName);

            using (var reader = command.ExecuteReader())
            {
                reader.Read();
                resource = new OrbDTO
                {
                    StateName = (string) reader["state"],
                    CountyName = (string) reader["county"],
                    LastUpdate = (string) reader["last_update"],
                    resources = new List<OrbDetailsDTO>
                    {
                        new OrbDetailsDTO
                        {
                            Type = "Land Records",
                            Url = (string) reader["land_url"],
                            User = (string) reader["county_user"],
                            Password = (string) reader["county_pwd"]
                        },
                        new OrbDetailsDTO
                        {
                            Type = "Assessor",
                            Url = (string) reader["assessor_url"],
                            User = (string) reader["assessor_user"],
                            Password = (string) reader["assessor_pwd"]
                        },
                        new OrbDetailsDTO
                        {
                            Type = "Tax Collector",
                            Url = (string) reader["tax_url"],
                            User = (string) reader["tax_user"],
                            Password = (string) reader["tax_pwd"]
                        },
                    }
                };
                
            }
        }

        return resource;
    }
}

