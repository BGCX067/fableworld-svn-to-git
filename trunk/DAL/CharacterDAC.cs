using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTL;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public static class CharacterDAC
    {
        public static void CreateCharacter(CharacterDTO character, Int32 activeAccountID)
        {
            using (SqlConnection conn = DAC.NewConnection)
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[CHARACTER_PKG.CREATE]";

                cmd.Parameters.Add(new SqlParameter("name", SqlDbType.NVarChar)).Value = character.Name;
                cmd.Parameters.Add(new SqlParameter("race_id", SqlDbType.Int)).Value = character.RaceID;
                cmd.Parameters.Add(new SqlParameter("class_id", SqlDbType.Int)).Value = character.ClassID;
                cmd.Parameters.Add(new SqlParameter("account_id", SqlDbType.Int)).Value = activeAccountID;

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static List<CharacterDTO> GetCharactersNotInParty(Int32 activeAccountID)
        {
            List<CharacterDTO> characters = new List<CharacterDTO>();

            using (SqlConnection cnn = DAC.NewConnection)
            using (SqlCommand cmd = cnn.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from character where account_id = @account_id order by name asc";

                cmd.Parameters.Add(new SqlParameter("account_id", SqlDbType.Int)).Value = activeAccountID;

                cnn.Open();
                using (SqlDataReader result = cmd.ExecuteReader())
                {
                    while (result.Read())
                    {
                        characters.Add(new CharacterDTO(result));
                    }
                }

                return characters;
            }
        }

        public static List<CharacterDTO> GetCharactersInParty(int activeAccountID)
        {
            List<CharacterDTO> characters = new List<CharacterDTO>();

            using (SqlConnection cnn = DAC.NewConnection)
            using (SqlCommand cmd = cnn.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from characters_in_party_vw where account_id = @account_id order by name asc";

                cmd.Parameters.Add(new SqlParameter("account_id", SqlDbType.Int)).Value = activeAccountID;

                cnn.Open();
                using (SqlDataReader result = cmd.ExecuteReader())
                {
                    while (result.Read())
                    {
                        characters.Add(new CharacterDTO(result));
                    }
                }

                return characters;
            }
        }
    }
}
