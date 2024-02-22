using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__heromaker_10;


namespace C__avatar_maker_app_12
{
    //-----START------- C# avatar maker app 12 static list to work as a global variable ----------------------------
    //public class HeroList
    //------END------ C# avatar maker app 12 static list to work as a global variable ----------------------------

    //------START------ C# avatar maker app 13 use a static class to store a list of objects -------------------------------
    static class HeroList       // Static means that there will be exactly one copy of the list in the entire application.
    //------END------ C# avatar maker app 13 use a static class to store a list of objects -------------------------------
    {
        //-----START------- C# avatar maker app 12 static list to work as a global variable ----------------------------
        //public List<Hero> hallOfFame = new List<Hero>();
        //------END------ C# avatar maker app 12 static list to work as a global variable ----------------------------

        //------START------ C# avatar maker app 13 use a static class to store a list of objects -------------------------------
        static public List<Hero> hallOfFame = new List<Hero>();
        //------END------ C# avatar maker app 13 use a static class to store a list of objects -------------------------------


    }
}
