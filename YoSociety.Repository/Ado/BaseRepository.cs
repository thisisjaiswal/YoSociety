using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;


namespace YoSociety.Repository.Ado
{
    public class BaseRepository
    {
        public static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

    }
}
