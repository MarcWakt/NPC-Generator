using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NPCGen
{
    enum listType { Male, Female, Other, Last, jobHigh, jobLow, homeHigh, homeLow, physicalTrait, personalityTrait, item }

    public partial class Form1 : Form
    {
        List<string> classList;
        List<listType> genderList;
        List<Collector> cultureList;

        string name, job, home, physTrait, persTrait, item;

        Random rand = new Random();

        private void clipBoardBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(resultText.Text);
        }

        public Form1()
        {
            InitializeComponent();
            classList = new List<string>();
            genderList = new List<listType>();
            cultureList = new List<Collector>();

            string filePath = Directory.GetCurrentDirectory();
            filePath += @"\Collections\";
            var txtFiles = Directory.EnumerateFiles(filePath);

            foreach (string file in txtFiles)
            {
                cultureList.Add(new Collector(file));
            }

            genderList.Add(listType.Male);
            genderList.Add(listType.Female);
            genderList.Add(listType.Other);

            classList.Add("High");
            classList.Add("Low");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Collector c in cultureList)
                cultureBox.Items.Add(c.name);
            cultureBox.SelectedIndex = 0;
            foreach (listType s in genderList)
                genderBox.Items.Add(s.ToString());
            genderBox.SelectedIndex = 0;
            foreach (string s in classList)
                classBox.Items.Add(s);
            classBox.SelectedIndex = 0;
            Mix();
        }

        private void mixButton_Click(object sender, EventArgs e)
        {
            Mix();
        }

        private void Mix()
        {
            int randValFirstName, randValLastName, randValJob, randValHome, randValPhysical, randValPersonality, randValItem;
            Collector currentCulture = cultureList.Find(o => o.name == cultureBox.Text);

            randValFirstName = GetRandomValue((listType)Enum.Parse(typeof(listType), genderBox.SelectedItem.ToString()));
            randValLastName = GetRandomValue(listType.Last);

            if (classBox.SelectedItem.ToString() == "High") randValJob = GetRandomValue(listType.jobHigh);
            else randValJob = GetRandomValue(listType.jobLow);

            if (classBox.SelectedItem.ToString() == "High") randValHome = GetRandomValue(listType.homeHigh);
            else randValHome = GetRandomValue(listType.homeLow);

            randValPhysical = GetRandomValue(listType.physicalTrait);
            randValPersonality = GetRandomValue(listType.personalityTrait);
            randValItem = GetRandomValue(listType.item);

            if (!checkName.Checked) name = currentCulture.GetName(genderBox.SelectedItem.ToString(), randValFirstName, randValLastName);
            if (!checkJob.Checked) job = currentCulture.GetJob(classBox.Text, randValJob);
            if (!checkHome.Checked) home = currentCulture.GetHome(classBox.Text, randValHome);
            if (!checkPhys.Checked) physTrait = currentCulture.GetPhysicalTrait(randValPhysical);
            if (!checkPers.Checked) persTrait = currentCulture.GetPersonalityTrait(randValPersonality);
            if (!checkItem.Checked) item = currentCulture.GetItem(randValItem);

            resultText.Text = physTrait + " " + currentCulture.name + ", " + name + ", " + job + " who lives in " + home + ". This one carries " +item+" and seems to be quite "+persTrait+".";

        }

        private int GetRandomValue(listType lt)
        {
            int value;
            Collector currentCulture = cultureList.Find(o => o.name == cultureBox.Text);
            if (lt == listType.Male) value = rand.Next(currentCulture.maleNameList.Count());
            else if (lt == listType.Female) value = rand.Next(currentCulture.femaleNameList.Count());
            else if (lt == listType.Last) value = rand.Next(currentCulture.lastNameList.Count());
            else if (lt == listType.jobHigh) value = rand.Next(currentCulture.jobHighList.Count());
            else if (lt == listType.jobLow) value = rand.Next(currentCulture.jobLowList.Count());
            else if (lt == listType.homeHigh) value = rand.Next(currentCulture.homeHighList.Count());
            else if (lt == listType.homeLow) value = rand.Next(currentCulture.homeLowList.Count());
            else if (lt == listType.physicalTrait) value = rand.Next(currentCulture.physTraitList.Count());
            else if (lt == listType.personalityTrait) value = rand.Next(currentCulture.persTraitList.Count());
            else if (lt == listType.item) value = rand.Next(currentCulture.itemList.Count());
            else value = rand.Next(currentCulture.otherNameList.Count());
            return value;
        }
    }
}
