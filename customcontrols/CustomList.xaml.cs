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

namespace DriveStorage.customcontrols
{
    /// <summary>
    /// Interaction logic for CustomList.xaml
    /// </summary>
    public partial class CustomList : UserControl
    {
        public CustomList()
        {
            InitializeComponent();
            DataContext = new MyFilesViewModel();
        }



        public PathGeometry FileThumb
        {
            get { return (PathGeometry)GetValue(FileThumbProperty); }
            set { SetValue(FileThumbProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FileThumb.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FileThumbProperty =
            DependencyProperty.Register("FileThumb", typeof(PathGeometry), typeof(CustomList));


    }
}
