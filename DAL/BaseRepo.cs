using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BaseRepo
    {
        private UniversityDBEntities context;
       public UniversityDBEntities Context {
            get {
                if (context==null)
                {
                    context = new UniversityDBEntities();
                }
                return context;
            }

        }
    }
}
