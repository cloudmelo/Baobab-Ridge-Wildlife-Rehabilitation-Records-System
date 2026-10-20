using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaobabRidgeRecords.Business_Layer
{
    public class Animal
    {
        private string animalID, name, species, status, housingUnit;
        private int age, recoveryScore;

        public Animal(string animalID, string name, string species,int age, int recoveryScore)
        {
            AnimalID = animalID;
            Name = name;
            Species = species;
            Age = age;
            RecoveryScore = recoveryScore;

            ClassifyAnimal(recoveryScore,out string calculatedStatus,out string calculatedHousing);

            Status = calculatedStatus;
            HousingUnit = calculatedHousing;
        }

        public string AnimalID { get => animalID; set => animalID = value; }
        public string Name { get => name; set => name = value; }
        public string Species { get => species; set => species = value; }
        public string Status { get => status; set => status = value; }
        public string HousingUnit { get => housingUnit; set => housingUnit = value; }
        public int Age { get => age; set => age = value; }
        public int RecoveryScore { get => recoveryScore; set => recoveryScore = value; }

        public static void ClassifyAnimal(int score, out string status, out string housingUnit)
        {
            if (score >= 0 && score <= 19)
            {
                status = "Critical";
                housingUnit = "Intensive Care Unit";
            }
            else if (score >= 20 && score <= 39)
            {
                status = "Serious";
                housingUnit = "High-Dependency Ward";
            }
            else if (score >= 40 && score <= 59)
            {
                status = "Stable";
                housingUnit = "Recovery Ward";
            }
            else if (score >= 60 && score <= 79)
            {
                status = "Recovering";
                housingUnit = "Outdoor Enclosure";
            }
            else if (score >= 80 && score <= 100)
            {
                status = "Release-Ready";
                housingUnit = "Pre-Release Camp";
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(score), "Score must be between 0 and 100.");
            }
        }

        public override string ToString()
        {
            return $"{AnimalID} | {Name} | {Species} | {Age} | {RecoveryScore} | {Status} | {HousingUnit}";
        }
    }
}

