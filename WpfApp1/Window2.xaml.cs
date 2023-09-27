using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public static List<Modules> modules = new List<Modules>();
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 obj = new Window1();
            obj.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Module_Code.Text) ||
             string.IsNullOrWhiteSpace(Module_Name.Text) ||
             !int.TryParse(Credit.Text, out int credits) ||
             !int.TryParse(Hours.Text, out int classHours))

            {
                MessageBox.Show("Please enter valid module information.");
                return;
            }
            string ModuleCode;
            string ModuleName;
            int numCredits;
            int NumbHours;
            int calcSelfStudyHours;

            ModuleCode = Module_Code.Text;
            ModuleName = Module_Name.Text;
            numCredits = Convert.ToInt32(Credit.Text);
            NumbHours = Convert.ToInt32(Hours.Text);
            int numweeks = 0;
            /* foreach (semester Semester in AddSemesterDetails.Semesters)
             {
                 numweeks = Semester.munberOfWeeks;

             }*/
            //calcSelfStudyHours = numCredits * 10 / numweeks - NumbHours;
            Modules moduleDetail = new Modules
            {
                Code = ModuleCode,
                Name = ModuleName,
                Credits = numCredits,
                HoursperWeek = NumbHours,
               // selfStudyHours = calcSelfStudyHours,

            };
            modules.Add(moduleDetail);
            // UpdateModuleListView();
            //Clearing text boxes
            Module_Code.Clear();
            Module_Name.Clear();
            Credit.Clear();
            Hours.Clear();
        }
    }
}
