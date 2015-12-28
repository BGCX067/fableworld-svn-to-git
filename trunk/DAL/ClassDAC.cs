using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTL;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public static class ClassDAC
    {
        public static List<ClassDTO> GetClasses()
        {
            List<ClassDTO> classes = new List<ClassDTO>();

            using (SqlConnection cnn = DAC.NewConnection)
            using (SqlCommand cmd = cnn.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from class order by title asc";

                //cmd.Parameters.Add(new SqlParameter("account_id", SqlDbType.Int)).Value = activeAccountID;

                cnn.Open();
                using (SqlDataReader result = cmd.ExecuteReader())
                {
                    while (result.Read())
                    {
                        classes.Add(new ClassDTO(result));
                    }
                }

                return classes;
            }
        }
    }
}
