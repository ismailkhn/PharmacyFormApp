using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacyyyyyyyy.Models
{
    public class Medicine
    {
        public int Id { get; set; }


        [MaxLength(100)]
        public string Name { get; set; } = null!;
        public bool isReceipt { get; set; }


        [MaxLength(500)]
        public string? Description { get; set; }
        public decimal Price { get; set; }  
        public decimal Cost { get; set; }
        public decimal Count { get; set; }
        public DateTime ProduceDate { get; set; }
        public DateTime ExpireDate { get; set; }



        public List<MedicineToCategory> MedicineToCategories { get; set; }

        public List<MedicineToFirm> MedicineToFirms { get; set; }   



    }
}
