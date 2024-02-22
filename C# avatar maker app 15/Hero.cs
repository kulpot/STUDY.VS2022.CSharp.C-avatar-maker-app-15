using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__heromaker_10
{
    //------START------ C# heromaker 10 hero object ---------------------------------------------------------
    //public class Hero   

    //-----START------- C# avatar maker app 15 sort a list of objects tutorial -----------------------------------------
    public class Hero : IComparable
    //-----END------- C# avatar maker app 15 sort a list of objects tutorial -----------------------------------------
    {
        // HeroConstructorMethod //Create->Highlight all Hero Properties->CTRL+. ->Select Create Constructor Method
        public Hero(string name, 
            bool[] specialAbilities, 
            List<string> officeLocations, 
            string preferredTransport, 
            int speed, int staming, int strength, 
            DateTime birthday, 
            DateTime superPowerDiscoveryDate, 
            DateTime fatefulDay, 
            decimal yearsExperience, 
            string capeColor, 
            int darkSidePropensity, 
            string portraitPhoto)
        {
            Name = name;
            SpecialAbilities = specialAbilities;
            OfficeLocations = officeLocations;
            PreferredTransport = preferredTransport;
            Speed = speed;
            Staming = staming;
            Strength = strength;
            Birthday = birthday;
            SuperPowerDiscoveryDate = superPowerDiscoveryDate;
            FatefulDay = fatefulDay;
            YearsExperience = yearsExperience;
            CapeColor = capeColor;
            DarkSidePropensity = darkSidePropensity;
            PortraitPhoto = portraitPhoto;
        }

        // HeroProperties
        public string Name { get; set; }
        public bool[] SpecialAbilities { get; set; }
        public List<String> OfficeLocations { get; set; }
        public string PreferredTransport {  get; set; }
        
        public int Speed { get; set; }   // This also could have benn stored as an array of int "int[] speedStamingStrength = {0,0,0};
        public int Staming { get; set; }   
        public int Strength { get; set; }

        public DateTime Birthday { get; set; }
        public DateTime SuperPowerDiscoveryDate { get; set; }
        public DateTime FatefulDay { get; set; }

        public decimal YearsExperience { get; set; }

        public String CapeColor { get; set; }
        //public string CapeColor { get; set; }

        public int DarkSidePropensity { get; set; }

        public String PortraitPhoto { get; set; }
        //public string PortraitPhoto { get; set; }
        //-----END------- C# heromaker 10 hero object ---------------------------------------------------------

        //-----START------- C# avatar maker app 15 sort a list of objects tutorial -----------------------------------------
        public int CompareTo(object obj)
        {
            Hero other = (Hero)obj;
            return Name.CompareTo(other.Name);
        }
        //-----END------- C# avatar maker app 15 sort a list of objects tutorial -----------------------------------------

    }
}
