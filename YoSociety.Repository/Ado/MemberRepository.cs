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
    public class MemberRepository : BaseRepository, IMemberRepository
    {
        public List<SocietyMember> GetSocieties(int memberId)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand("GetSocietyForMember", conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("MemberId", memberId));
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable t = new DataTable();
            adapter.Fill(t);

            var result = new List<SocietyMember>();
            foreach (DataRow item in t.Rows)
            {
                result.Add(new SocietyMember { SocietyId = (int)item[0], MemberId = (int)item[1], FlatNo = (short)item[2], MemberType = (short)item[3], SocietyName = (string)item[4] });
            }
            return result;
        }

        public SocietyMember AddSociety(SocietyMember society)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            SqlCommand command = new SqlCommand("AddSocietyForMember", conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("societyId", society.SocietyId));
            command.Parameters.Add(new SqlParameter("memberId", society.MemberId));
            command.Parameters.Add(new SqlParameter("flatNo", society.FlatNo));
            command.Parameters.Add(new SqlParameter("memberType", society.MemberType));

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable t = new DataTable();
            adapter.Fill(t);
            if (t.Rows.Count == 0)
                return null;
            return new SocietyMember { SocietyId = (int)t.Rows[0][0], MemberId = (int)t.Rows[0][1], FlatNo = (short)t.Rows[0][2], MemberType = (short)t.Rows[0][3], SocietyName = (string)t.Rows[0][4] };
        }
                
        public IEnumerable<SocietyMember> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SocietyMember> GetAll(string filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SocietyMember> Search(string filter)
        {
            throw new NotImplementedException();
        }

        public SocietyMember Get(string id)
        {
            throw new NotImplementedException();
        }

        public SocietyMember Add(SocietyMember item)
        {
            throw new NotImplementedException();
        }

        public bool Update(SocietyMember item)
        {
            throw new NotImplementedException();
        }

        public void Remove(string id)
        {
            throw new NotImplementedException();
        }
    }
}
