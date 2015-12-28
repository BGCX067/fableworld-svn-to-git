using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DTL
{
    public class CharacterDTO
    {
        public String Name { get; set; }
        public Int32 ClassID { get; set; }
        public Int32 RaceID { get; set; }
        public bool IsMale { get; set; }
        
        public CharacterDTO(String name, Int32 classID, Int32 raceID, bool isMale)
        {
            Name = name;
            ClassID = classID;
            RaceID = raceID;
            IsMale = isMale;
        }

        public CharacterDTO(IDataReader dataReader)
        {
            Name = Convert.ToString(dataReader["name"]);
            ClassID = Convert.ToInt32(dataReader["class_id"]);
            RaceID = Convert.ToInt32(dataReader["race_id"]);
            IsMale = Convert.ToBoolean(dataReader["is_male"]);
        }
    
    }
}
