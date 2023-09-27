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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public static List <semesterPlan>  semPlan= new List<semesterPlan>();
        public Window1()
        {
            InitializeComponent();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Validate input
            if (!int.TryParse(weeks.Text, out int week) ||
             !int.TryParse(Hours.Text, out int hours))
            {
                MessageBox.Show("Please enter valid semester information.");
                return;
            }
            
            week = Convert.ToInt32(weeks.Text);

            semesterPlan semesterDetails = new semesterPlan
            {
                numnOfWeeks = week,
                numnOfHours = hours
                // startDate = DatePicker.SelectedDate.Value
            };

            semPlan.Add(semesterDetails);
            weeks.Clear();
            Hours.Clear();
            //datePicker.SelectedDate = null;

            Window3 window3 = new Window3();
            window3.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
