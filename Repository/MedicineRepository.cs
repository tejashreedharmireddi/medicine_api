using Medicine2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medicine2.Repository
{
    public class MedicineRepository:IMedicineRepository
    {
      static  List<MedicineListModel> med = new List<MedicineListModel>() {
            new MedicineListModel{Id=1, Name="Paracetmol", Cost=50},
            new MedicineListModel{Id=2, Name="Keto", Cost=200},
            new MedicineListModel{Id=3, Name="Dolo", Cost=100},
            new MedicineListModel{Id=4, Name="Zincold", Cost=50},
        };

        public  List<MedicineListModel> GetAll()
        {
            return med;
        }

        
    }
}
