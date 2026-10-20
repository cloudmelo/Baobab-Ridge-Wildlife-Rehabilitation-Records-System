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
                        Animal animal = new Animal( parts[0],parts[1], parts[2],(age), (score));
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
    }
}
