using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTL;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public static class RaceDAC
    {
        public static List<RaceDTO> GetRaces()
        {
            List<RaceDTO> races = new List<RaceDTO>();

            using (SqlConnection cnn = DAC.NewConnection)
            using (SqlCommand cmd = cnn.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from race order by title asc";

                //cmd.Parameters.Add(new SqlParameter("account_id", SqlDbType.Int)).Value = activeAccountID;

                cnn.Open();
                using (SqlDataReader result = cmd.ExecuteReader())
                {
                    while (result.Read())
                    {
                        races.Add(new RaceDTO(result));
                    }
                }

                return races;
            }
        }
    }
}
