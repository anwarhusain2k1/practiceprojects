using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class operation
    {
        public List<laptop_list> get()
        {
            ramsEntities context = new ramsEntities();
            List<laptop_list> list = context.laptop_list.ToList();
            return list;
        }
        public laptop_list buy(int id)
        {
            ramsEntities context = new ramsEntities();
            List<laptop_list> list = context.laptop_list.ToList();
            laptop_list buy = list.Find(X => X.laptopid == id);
            return buy;
        }
        

    }
}
