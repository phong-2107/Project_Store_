using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LoginService
    {
        public List<TaiKhoanLogin> GetAll()
        {
            Model context = new Model();
            return context.TaiKhoanLogins.ToList();
        }
    }
}
