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
    public class AccountRepository : BaseRepository, IAccountRepository
    {
        public IEnumerable<UserAccount> GetAll()
        {
            return null; // _context.GetAllUserAccounts();
        }

        public UserAccount Get(string id)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            SqlCommand command = new SqlCommand("GetUserAccount",conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            
            command.Parameters.Add(new SqlParameter("UserId", id));
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable t = new DataTable();
            adapter.Fill(t);
            if (t.Rows.Count == 0)
                return null;
            return new UserAccount { AccountId = (int)t.Rows[0][0], UserId = (string)t.Rows[0][1], Password = (string)t.Rows[0][2] };
        }

        public UserAccount Add(UserAccount account)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            SqlCommand command = new SqlCommand("AddUserAccount", conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;            
            command.Parameters.Add(new SqlParameter("UserId", account.UserId));
            command.Parameters.Add(new SqlParameter("Password", account.Password));
            
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable t = new DataTable();
            adapter.Fill(t);
            if (t.Rows.Count == 0)
                return null;
            return new UserAccount { AccountId = (int)t.Rows[0][0], UserId = (string)t.Rows[0][1], Password = (string)t.Rows[0][2] };
        }

        public bool Update(UserAccount account)
        {
            return false; // _context.UpdateUserAccount(account);
        }

        public void Remove(string id)
        {
            //_context.RemoveUserAccount(id);
        }

        public bool Verify(string id, string password)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<UserAccount> GetAll(string filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserAccount> Search(string filter)
        {
            throw new NotImplementedException();
        }
    }
}
