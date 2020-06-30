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

namespace ListViewExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataContext context;
        public MainWindow()
        {
            InitializeComponent();

            context = new DataContext();
            
            MyPeople = context.GetPeople();
        }

        public IList<Person> MyPeople
        {
            get { return (IList<Person>)GetValue(MyPeopleProperty); }
            set { SetValue(MyPeopleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyPeople.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyPeopleProperty =
            DependencyProperty.Register("MyPeople", typeof(IList<Person>), typeof(MainWindow), new PropertyMetadata(default(IList<Person>)));


    }
}
