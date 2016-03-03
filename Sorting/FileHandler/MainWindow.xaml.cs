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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sorting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        class Dummy : IComparable<Dummy>
        {

            public string Name { get; set; }
            public string Email { get; set; }
            public string Info { get; set; }

            public int CompareTo(Dummy other)
            {
                return (Info.Length > other.Info.Length ? -1 : 1);
             }
        }

        public MainWindow()
        {
            InitializeComponent();

            fillGrid();
        }

        void fillGrid()
        {

            List<Dummy> lst = new List<Dummy>();

            lst.Add(new Dummy() { Name = "Joe", Email = "joe@somedomain.com", Info = "Member of the cocker spaniel club." });
            lst.Add(new Dummy() { Name = "Adrian", Email = "adrian@somedomain.com", Info = "Used to be acrobat" });
            lst.Add(new Dummy() { Name = "Bassie", Email = "bassie@somedomain.com", Info = "His brother used to be a super-hero acrobat, now a days he sells cars." });
            lst.Add(new Dummy() { Name = "Mary", Email = "mary@somedomain.com", Info = "Sweet Mary, I'm coming home!" });
            lst.Add(new Dummy() { Name = "Roger", Email = "roger@somedomain.com", Info = "Likes swimmming in water." });

            lst.Sort();

            dataGrid.ItemsSource = lst;


        }

    }
}
