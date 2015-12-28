using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DTL
{
    public class ClassDTO
    {
        public Int32 ID { get; set; }
        public String Title { get; set; }

        public ClassDTO(IDataReader dataReader)
        {
            ID = Convert.ToInt32(dataReader["id"]);
            Title = Convert.ToString(dataReader["title"]);
        }
    }
}
