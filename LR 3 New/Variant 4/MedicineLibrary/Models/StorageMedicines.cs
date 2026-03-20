using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant_4
{
    public class StorageMedicines : IDataOfMedicines
    {
        public List<Medicines> Load()
        {
            List<Medicines> allMedicines = new List<Medicines>();
            string path = ".\\data.csv";
            StreamReader sr = new StreamReader(path);

            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] lines = line.Split(';');
                allMedicines.Add(new Medicines(lines[1], Convert.ToDouble(lines[2]), lines[3], lines[4], Convert.ToDateTime(lines[5]), lines[6], lines[7], lines[0]));
            }

            sr.Close();

            return allMedicines;
        }
    }
}
