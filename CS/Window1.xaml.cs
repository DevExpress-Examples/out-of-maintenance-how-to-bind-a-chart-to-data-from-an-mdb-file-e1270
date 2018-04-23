using System.Windows;

namespace WpfApplication1 {

    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();

            carSeries.DataSource = 
                new CarsDBDataSetTableAdapters.CarsTableAdapter().GetData();
        }
    }
}
