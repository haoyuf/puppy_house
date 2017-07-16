using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL.Repository
{
    public class PuppyImpl : IPuppy
    {
        string connectionString = ConfigurationManager.ConnectionStrings["puppyHouseContext"].ConnectionString;

        public void addNewPuppy(Puppy newPuppyInfo)
        {
            throw new NotImplementedException();
        }

        public void deletePuppy(int puppyId)
        {
            throw new NotImplementedException();
        }

        public List<Puppy> getAllPuppies()
        {
            string queryString = "Select * from puppy";
            List<Puppy> allPuppies = new List<Puppy>();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(queryString, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Puppy aPuppy = new Model.Puppy()
                        {
                            Id = (int)reader["id"],
                            Name = reader["name"].ToString(),
                            Gender = reader["gender"].ToString(),
                            Breed = reader["breed"].ToString(),
                            Color = reader["color"].ToString(),
                            OwnerName = reader["owner_name"].ToString(),
                            Weight = float.Parse(reader["weight"].ToString()),
                            DOB = (DateTime)reader["dob"],
                        };
                        allPuppies.Add(aPuppy);
                    }
                }
            }
            return allPuppies;
        }

        public List<Puppy> getPuppyByGender(string gender)
        {
            throw new NotImplementedException();
        }

        public void updatePuppy(Puppy updatedPuppy)
        {
            throw new NotImplementedException();
        }
    }
}
