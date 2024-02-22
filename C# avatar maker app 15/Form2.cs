using C__avatar_maker_app_12;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__avatar_maker_app_13
{
    public partial class Form2 : Form
    {
        //-----START------- C# avatar maker app 15 sort a list of objects tutorial -----------------------------------------
        BindingSource bs = new BindingSource();
        //-----END------- C# avatar maker app 15 sort a list of objects tutorial -----------------------------------------

        public Form2()
        {
            InitializeComponent();
            //-----START------- C# avatar maker app 13 use a static class to store a list of objects -------------------------------
            //BindingSource bs = new BindingSource(); // move above Form() constructor
            bs.DataSource = HeroList.hallOfFame;
            listBox1.DataSource = bs;
            listBox1.DisplayMember = "Name";    //ErrorSolutionFrom:Hero class needs a ToString() method or ListBox1 needs a DisplayMember property set.
            //-----END------- C# avatar maker app 13 use a static class to store a list of objects -------------------------------

        }

        //-----START------- C# avatar maker app 15 sort a list of objects tutorial -----------------------------------------
        private void btn_sortAZ_Click(object sender, EventArgs e)
        {
            HeroList.hallOfFame.Sort();     //ERROR: The hero class should have the CompareTo method
            bs.ResetBindings(false);
        }

        private void btn_sortZA_Click(object sender, EventArgs e)
        {
            HeroList.hallOfFame.Sort();
            HeroList.hallOfFame.Reverse();
            bs.ResetBindings(false);
        }
        //-----END------- C# avatar maker app 15 sort a list of objects tutorial -----------------------------------------

    }
}
