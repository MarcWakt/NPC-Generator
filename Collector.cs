using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCGen
{
    class Collector
    {
        public string name;
        public List<string> maleNameList;
        public List<string> femaleNameList;
        public List<string> otherNameList;
        public List<string> lastNameList;
        public List<string> jobHighList;
        public List<string> jobLowList;
        public List<string> homeHighList;
        public List<string> homeLowList;
        public List<string> physTraitList;
        public List<string> persTraitList;
        public List<string> itemList;

        private StreamReader sr;

        //Parsing = one word per row
        //1st row: culture name i.e. "Orcish"
        //following parses - added to maleNameList
        //after parsing word "female" parse to femaleNameList
        //after parsing word "lastNames" parse to lastNameList
        //after parsing word "jobHigh" parse to jobHighList
        //after parsing word "jobLow" parse to jobLowList
        //after parsing word "homeHigh" parse to homeHighList
        //after parsing word "homeLow" parse to homeLowList

        public Collector(string filepath)
        {
            maleNameList = new List<string>();
            femaleNameList = new List<string>();
            otherNameList = new List<string>();
            lastNameList = new List<string>();
            jobHighList = new List<string>();
            jobLowList = new List<string>();
            homeHighList = new List<string>();
            homeLowList = new List<string>();
            physTraitList = new List<string>();
            persTraitList = new List<string>();
            itemList = new List<string>();

            try
            {
                using (sr = new StreamReader(filepath))
                {
                    string line;
                    List<string> currentList = maleNameList;
                    while((line = sr.ReadLine()) != null)
                    {
                        if(name == null)
                        {
                            name = line;
                        }
                        else if(line == "female")
                        {
                            currentList = femaleNameList;
                        }
                        else if(line == "lastName")
                        {
                            currentList = lastNameList;
                        }
                        else if(line == "jobHigh")
                        {
                            currentList = jobHighList;
                        }
                        else if(line == "jobLow")
                        {
                            currentList = jobLowList;
                        }
                        else if(line == "homeHigh")
                        {
                            currentList = homeHighList;
                        }
                        else if(line == "homeLow")
                        {
                            currentList = homeLowList;
                        }
                        else if(line == "physicalTrait")
                        {
                            currentList = physTraitList;
                        }
                        else if(line == "personalityTrait")
                        {
                            currentList = persTraitList;
                        }
                        else if(line == "item")
                        {
                            currentList = itemList;
                        }
                        else
                        {
                            currentList.Add(line);
                        }
                    }
                    otherNameList.AddRange(maleNameList);
                    otherNameList.AddRange(femaleNameList);
                }
            }
            catch
            {
                Console.WriteLine("Error at Collector");
            }
        }

        public string GetName(string gender, int randValue1, int randValue2)
        {
            string name;
            if (gender == "Male") name = maleNameList[randValue1];
            else if (gender == "Female") name = femaleNameList[randValue1];
            else name = maleNameList[randValue1];
            name += " " + lastNameList[randValue2];

            return name;
        }

        public string GetJob(string socClass, int randValue)
        {
            if (socClass == "High")
                return jobHighList[randValue];
            else
                return jobLowList[randValue];
        }

        public string GetHome(string socClass, int randValue)
        {
            if (socClass == "High")
                return homeHighList[randValue];
            else
                return homeLowList[randValue];
        }

        public string GetPhysicalTrait(int randValue)
        {
            return physTraitList[randValue];
        }

        public string GetPersonalityTrait(int randValue)
        {
            return persTraitList[randValue];
        }

        public string GetItem(int randValue)
        {
            return itemList[randValue];
        }
    }
}
