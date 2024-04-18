using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bouncing_Ball
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MoveBall(ref double x, ref double y, ref int xChange, ref int yChange)
        {
            if ((x <= 0) || (x >= ballCanvas.Width))
            {
                xChange = -xChange;
            }
            if ((y <= 0) || (y >= ballCanvas.Height))
            {
                yChange = -yChange;
            }

            x = x + xChange;
            y = y + yChange;
        }       
    }
}
