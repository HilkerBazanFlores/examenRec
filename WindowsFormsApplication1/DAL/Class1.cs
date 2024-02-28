using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalPersona
    {
        public void insertarPersona(dalPersona pPersona)
        {
            using (var bd= new examenRecuEntities())
            {
                bd.dalPersona.add(pPersona);
            }
        }
    }
}
