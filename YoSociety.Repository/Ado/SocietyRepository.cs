using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using YoSociety.Entities;

namespace YoSociety.Repository.Ado
{
    public class SocietyRepository : BaseRepository, ISocietyRepository
    {
        public IEnumerable<Society> GetAll()
        {
            return null; // _context.GetAllSocieties();
        }

        public IEnumerable<Society> GetAll(string filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Society> Search(string regNo)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand("SearchSocietyByRegNo", conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("regNo", regNo));
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable t = new DataTable();
            adapter.Fill(t);
            if (t.Rows.Count == 0)
                return null;

            var result = new List<Society>();
            foreach (DataRow item in t.Rows)
            {
                result.Add(new Society { SocietyId = (int)item[0], SocietyName = (string)item[1], RegistrationNo = (string)item[2] });
            }

            return result;
        }

        public Society Get(string id)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand("GetSociety", conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("SocietyId", id));
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable t = new DataTable();
            adapter.Fill(t);
            if (t.Rows.Count == 0)
                return null;
            return new Society { SocietyId = (int)t.Rows[0][0], SocietyName = (string)t.Rows[0][1], RegistrationNo = (string)t.Rows[0][2] };
        }

        public Society Add(Society account)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            SqlCommand command = new SqlCommand("AddSociety", conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;            
            command.Parameters.Add(new SqlParameter("Name", account.SocietyName));
            command.Parameters.Add(new SqlParameter("RegistrationNo", account.RegistrationNo));
            
            
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable t = new DataTable();
            adapter.Fill(t);
            if (t.Rows.Count == 0)
                return null;
            return new Society { SocietyId = (int)t.Rows[0][0], SocietyName = (string)t.Rows[0][1], RegistrationNo = (string)t.Rows[0][2] };
        }

        public bool Update(Society account)
        {
            return false; // _context.UpdateSociety(account);
        }

        public void Remove(string id)
        {
            //_context.RemoveSociety(id);
        }

    }
}
