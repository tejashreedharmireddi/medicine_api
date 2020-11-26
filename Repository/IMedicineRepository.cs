using Medicine2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medicine2.Repository
{
    public interface IMedicineRepository
    {
        public List<MedicineListModel> GetAll();
    }
}
