using BaobabRidgeRecords.Business_Layer;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaobabRidgeRecords.Data_Layer
{
    public class DataHandler
    {
        public DataHandler() { }

        public List<Animal> GetAnimals()
        {
            int skipped = 0;


            List<Animal> animals = new List<Animal>();
            try
            {
                if (!File.Exists("animals.txt"))
                {
                    File.Create("animals.txt").Close();
                    return animals;
                }
                using (StreamReader sr = new StreamReader("animals.txt"))
                {


                    while (!sr.EndOfStream)
                    {
                        string[] parts = sr.ReadLine().Split('|');
                        if (parts.Length != 7)
                        {
                            skipped++;
                            continue;
                        }
                        if (!int.TryParse(parts[3], out int age) || !int.TryParse(parts[4], out int score))
                        {
                            skipped++;
                            continue;
                        }
                        Animal animal = new Animal(parts[0], parts[1], parts[2], (age), (score));
                        animals.Add(animal);

                    }
                    if (skipped > 0)
                    {
                        MessageBox.Show($"{skipped} malformed records were skipped.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return animals;
        }


        public string AddAnimal(Animal newAnimal)
        {
            try
            {
                string filePath = "animals.txt";

                
                List<string> lines = File.Exists(filePath)
                    ? File.ReadAllLines(filePath).ToList()
                    : new List<string>();

                
                foreach (string line in lines)
                {
                    string[] fields = line.Split('|');

                    if (fields.Length > 0 &&
                        fields[0].Equals(
                            newAnimal.AnimalID,
                            StringComparison.OrdinalIgnoreCase))
                    {
                        return $"Animal ID {newAnimal.AnimalID} already exists.";
                    }
                }

                
                string record =
                    $"{newAnimal.AnimalID}|" +
                    $"{newAnimal.Name}|" +
                    $"{newAnimal.Species}|" +
                    $"{newAnimal.Age}|" +
                    $"{newAnimal.RecoveryScore}|" +
                    $"{newAnimal.Status}|" +
                    $"{newAnimal.HousingUnit}";

                File.AppendAllText(filePath, record + Environment.NewLine);

                return $"Animal {newAnimal.AnimalID} was added successfully.";
            }
            catch (IOException ex)
            {
                return $"File error while adding animal: {ex.Message}";
            }
            catch (UnauthorizedAccessException ex)
            {
                return $"Access denied while adding animal: {ex.Message}";
            }
        }


        public string UpdateAnimal(string animalID, Animal updatedAnimal)
        {
            try
            {
                List<string> animals = File.ReadAllLines("animals.txt").ToList();

                for (int i = 0; i < animals.Count; i++)
                {
                    string[] parts = animals[i].Split('|');
                    if (parts[0] == animalID)
                    {
                        animals[i] = updatedAnimal.AnimalID + "|" + updatedAnimal.Name + "|" + updatedAnimal.Species + "|" + updatedAnimal.Age + "|" + updatedAnimal.RecoveryScore + "|" + updatedAnimal.Status + "|" + updatedAnimal.HousingUnit;

                        File.WriteAllLines("animals.txt", animals);

                        return "Animal updated successfully.";
                    }

                }
                return "Animal not found.";
            }
            catch (Exception ex)
            {
                return "Error updating animal: " + ex.Message;
            }

        }

        public string DeleteAnimal(string animalID)
        {
            try
            {
                List<string> animals = File.ReadAllLines("animals.txt").ToList();
                for (int i = 0; i < animals.Count; i++)
                {
                    string[] parts = animals[i].Split('|');
                    if (parts[0] == animalID)
                    {
                        animals.RemoveAt(i);

                        File.WriteAllLines("animals.txt", animals);

                        return "Animal deleted successfully.";
                    }
                }
                return "Animal not found.";
            }
            catch (Exception ex)
            {
                return "Error deleting animal: " + ex.Message;
            }
        }

    public bool MakeSummary(
    int total,
    string averageAge,
    string averageScore,
    int critCount,
    int seriousCount,
    int stableCount,
    int recovCount,
    int releaseCount )
        {
            try
            {
                string filePath = "summary.txt";
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

                using (StreamWriter sw = new StreamWriter(filePath, false))
                {
                    sw.WriteLine("BAOBAB RIDGE WILDLIFE REHABILITATION CENTRE");
                    sw.WriteLine("ANIMAL SUMMARY REPORT");
                    sw.WriteLine($"Generated: {timestamp}");
                    sw.WriteLine();
                    sw.WriteLine("------------------------------------------------");
                    sw.WriteLine($"Total animals: {total}");
                    sw.WriteLine($"Average age (years): {averageAge}");
                    sw.WriteLine($"Average recovery score: {averageScore}");
                    sw.WriteLine();
                    sw.WriteLine("------------------------------------------------");
                    sw.WriteLine("Animals per status:");
                    sw.WriteLine($"  Critical: {critCount}");
                    sw.WriteLine($"  Serious: {seriousCount}");
                    sw.WriteLine($"  Stable: {stableCount}");
                    sw.WriteLine($"  Recovering: {recovCount}");
                    sw.WriteLine($"  Release-Ready: {releaseCount}");
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error while saving summary: " + ex.Message);
                return false;
            }
        }

    }
}
