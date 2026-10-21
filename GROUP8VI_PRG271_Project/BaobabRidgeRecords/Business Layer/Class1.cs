using BaobabRidgeRecords.Data_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace BaobabRidgeRecords.Business_Layer
{
    public class BusinessLayer
    {
        DataHandler dh = new DataHandler();
        public BusinessLayer() { }
        public BindingSource source()
        {
            BindingSource src = new BindingSource();
            src.DataSource = dh.GetAnimals();
            return src;
        }

        public string AddAnimal(Animal newAnimal)
        {
            return dh.AddAnimal(newAnimal);
        }

        public string UpdateAnimal(string AnimalID, Animal updatedAnimal)
        {
            return dh.UpdateAnimal(AnimalID, updatedAnimal);
        }

        public string DeleteAnimal(string AnimalID)
        {
            return dh.DeleteAnimal(AnimalID);
        }

        public List<Animal> GetAnimals()
        {
            return dh.GetAnimals();
        }
        public bool MakeSummary(int total,
        string averageAge,
        string averageScore,
        int critCount,
        int seriousCount,
        int stableCount,
        int recovCount,
        int releaseCount) { 
            
            return dh.MakeSummary(total, averageAge, averageScore, critCount, seriousCount, stableCount, recovCount, releaseCount);
        }

    }
}
