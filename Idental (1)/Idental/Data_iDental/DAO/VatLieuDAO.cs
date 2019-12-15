using Data_iDental.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_iDental.DAO
{
    public class VatLieuDAO
    {
        public List<VatLieu> GetVatLieu()
        {
            const string proc = "XemVatLieu";
            List<SqlParameter> para = new List<SqlParameter>()
            {
               

            };
            IDataReader reader = DataProvider.ExecuteReader(proc, para);
            List<VatLieu> result = new List<VatLieu>();
            VatLieu tk;
            while (reader.Read())
            {
                tk = new VatLieu();
                tk.AvailableAmount = Convert.ToInt32(reader["AvailableAmount"]);
                tk.MaterialID = Convert.ToInt32(reader["MaterialID"]);
                tk.MaterialName = Convert.ToString(reader["MaterialName"]);
                tk.ProviderName = Convert.ToString(reader["ProviderName"]);
                tk.PhoneNumder = Convert.ToString(reader["PhoneNumder"]);
                result.Add(tk);
            }
            return result;
        }
        public bool PostVatLieu(ThemVatLieu dv)
        {
            const string proc = "ThemVatLieu";
            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("AVAILABLEAMOUNT", dv.AVAILABLEAMOUNT),
                new SqlParameter("ExpirationDate", dv.ExpirationDate),
                new SqlParameter("MATERIALNAME", dv.MATERIALNAME),
                new SqlParameter("PROVIDERID", dv.PROVIDERID),
            };
            int res = DataProvider.ExecuteNonQuery(proc, para);

            if (res > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool PutVatLieu(SuaVatLieu dv)
        {
            const string proc = "SuaVatLieu";
            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("AVAILABLEAMOUNT", dv.AVAILABLEAMOUNT),
                new SqlParameter("ExpirationDate", dv.ExpirationDate),
                new SqlParameter("MATERIALNAME", dv.MATERIALNAME),
                new SqlParameter("PROVIDERID", dv.PROVIDERID),
            };
            int res = DataProvider.ExecuteNonQuery(proc, para);

            if (res > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteVatLieu(XoaVatLieu dv)
        {
            const string proc = "XoaVatLieu";
            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter("AVAILABLEAMOUNT", dv.MATERIALID),
                
            };
            int res = DataProvider.ExecuteNonQuery(proc, para);

            if (res > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
