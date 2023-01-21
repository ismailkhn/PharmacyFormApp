using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacyyyyyyyy.Models
{
    public class MedicineToCategory
    {
        public int Id { get; set; }
        
        public int MedicineId { get; set; }

        public int CategoryId { get; set; }


        public virtual Category Categories { get; set; }

    }
}
