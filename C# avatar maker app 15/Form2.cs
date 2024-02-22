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
        public Form2()
        {
            InitializeComponent();
            //-----START------- C# avatar maker app 13 use a static class to store a list of objects -------------------------------
            BindingSource bs = new BindingSource();
            bs.DataSource = HeroList.hallOfFame;
            listBox1.DataSource = bs;
            listBox1.DisplayMember = "Name";    //ErrorSolutionFrom:Hero class needs a ToString() method or ListBox1 needs a DisplayMember property set.
            //-----END------- C# avatar maker app 13 use a static class to store a list of objects -------------------------------

        }
    }
}
