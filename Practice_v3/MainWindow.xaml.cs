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

namespace Practice_v3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Start_btn_Click(object sender, RoutedEventArgs e)
        {
            List<RegStorage> regStorages = new List<RegStorage>();

            regStorages.Add(new RegStorage(0, 
                                            DL_SupplyFrom_1.SelectedIndex, 
                                            Convert.ToInt32(TB_Capacity_1.Text), 
                                            TB_isConsumable_1.IsChecked.Value,
                                            Convert.ToInt32(TB_maxConsumable_1.Text), 
                                            Convert.ToInt32(TB_minConsumable_1.Text)));

            regStorages.Add(new RegStorage(1,
                                            DL_SupplyFrom_2.SelectedIndex,
                                            Convert.ToInt32(TB_Capacity_2.Text),
                                            TB_isConsumable_2.IsChecked.Value,
                                            Convert.ToInt32(TB_maxConsumable_2.Text),
                                            Convert.ToInt32(TB_minConsumable_2.Text)));

            regStorages.Add(new RegStorage(2,
                                            DL_SupplyFrom_3.SelectedIndex,
                                            Convert.ToInt32(TB_Capacity_3.Text),
                                            TB_isConsumable_3.IsChecked.Value,
                                            Convert.ToInt32(TB_maxConsumable_3.Text),
                                            Convert.ToInt32(TB_minConsumable_3.Text)));

            regStorages.Add(new RegStorage(3,
                                            DL_SupplyFrom_4.SelectedIndex,
                                            Convert.ToInt32(TB_Capacity_4.Text),
                                            TB_isConsumable_4.IsChecked.Value,
                                            Convert.ToInt32(TB_maxConsumable_4.Text),
                                            Convert.ToInt32(TB_minConsumable_4.Text)));

            regStorages.Add(new RegStorage(4,
                                            DL_SupplyFrom_5.SelectedIndex,
                                            Convert.ToInt32(TB_Capacity_5.Text),
                                            TB_isConsumable_5.IsChecked.Value,
                                            Convert.ToInt32(TB_maxConsumable_5.Text),
                                            Convert.ToInt32(TB_minConsumable_5.Text)));

            regStorages.Add(new RegStorage(5,
                                            DL_SupplyFrom_6.SelectedIndex,
                                            Convert.ToInt32(TB_Capacity_6.Text),
                                            TB_isConsumable_6.IsChecked.Value,
                                            Convert.ToInt32(TB_maxConsumable_6.Text),
                                            Convert.ToInt32(TB_minConsumable_6.Text)));

            SimulationForm simulation = new SimulationForm(regStorages);
            simulation.Show();

        }

        #region Visibility
        private void TB_isConsumable_1_Checked(object sender, RoutedEventArgs e)
        {
            SwitchableName_1.Visibility = Visibility.Visible;
            SwitchableMin_1.Visibility = Visibility.Visible;
            SwitchableMax_1.Visibility = Visibility.Visible;
            TB_minConsumable_1.Visibility = Visibility.Visible;
            TB_maxConsumable_1.Visibility = Visibility.Visible;
        }

        private void TB_isConsumable_1_Unchecked(object sender, RoutedEventArgs e)
        {
            SwitchableName_1.Visibility = Visibility.Hidden;
            SwitchableMin_1.Visibility = Visibility.Hidden;
            SwitchableMax_1.Visibility = Visibility.Hidden;
            TB_minConsumable_1.Visibility = Visibility.Hidden;
            TB_maxConsumable_1.Visibility = Visibility.Hidden;
        }

        private void TB_isConsumable_2_Checked(object sender, RoutedEventArgs e)
        {
            SwitchableName_2.Visibility = Visibility.Visible;
            SwitchableMin_2.Visibility = Visibility.Visible;
            SwitchableMax_2.Visibility = Visibility.Visible;
            TB_minConsumable_2.Visibility = Visibility.Visible;
            TB_maxConsumable_2.Visibility = Visibility.Visible;
        }

        private void TB_isConsumable_2_Unchecked(object sender, RoutedEventArgs e)
        {
            SwitchableName_2.Visibility = Visibility.Hidden;
            SwitchableMin_2.Visibility = Visibility.Hidden;
            SwitchableMax_2.Visibility = Visibility.Hidden;
            TB_minConsumable_2.Visibility = Visibility.Hidden;
            TB_maxConsumable_2.Visibility = Visibility.Hidden;
        }

        private void TB_isConsumable_3_Checked(object sender, RoutedEventArgs e)
        {
            SwitchableName_3.Visibility = Visibility.Visible;
            SwitchableMin_3.Visibility = Visibility.Visible;
            SwitchableMax_3.Visibility = Visibility.Visible;
            TB_minConsumable_3.Visibility = Visibility.Visible;
            TB_maxConsumable_3.Visibility = Visibility.Visible;
        }

        private void TB_isConsumable_3_Unchecked(object sender, RoutedEventArgs e)
        {
            SwitchableName_3.Visibility = Visibility.Hidden;
            SwitchableMin_3.Visibility = Visibility.Hidden;
            SwitchableMax_3.Visibility = Visibility.Hidden;
            TB_minConsumable_3.Visibility = Visibility.Hidden;
            TB_maxConsumable_3.Visibility = Visibility.Hidden;
        }

        private void TB_isConsumable_4_Checked(object sender, RoutedEventArgs e)
        {
            SwitchableName_4.Visibility = Visibility.Visible;
            SwitchableMin_4.Visibility = Visibility.Visible;
            SwitchableMax_4.Visibility = Visibility.Visible;
            TB_minConsumable_4.Visibility = Visibility.Visible;
            TB_maxConsumable_4.Visibility = Visibility.Visible;
        }

        private void TB_isConsumable_4_Unchecked(object sender, RoutedEventArgs e)
        {
            SwitchableName_4.Visibility = Visibility.Hidden;
            SwitchableMin_4.Visibility = Visibility.Hidden;
            SwitchableMax_4.Visibility = Visibility.Hidden;
            TB_minConsumable_4.Visibility = Visibility.Hidden;
            TB_maxConsumable_4.Visibility = Visibility.Hidden;
        }

        private void TB_isConsumable_5_Checked(object sender, RoutedEventArgs e)
        {
            SwitchableName_5.Visibility = Visibility.Visible;
            SwitchableMin_5.Visibility = Visibility.Visible;
            SwitchableMax_5.Visibility = Visibility.Visible;
            TB_minConsumable_5.Visibility = Visibility.Visible;
            TB_maxConsumable_5.Visibility = Visibility.Visible;
        }

        private void TB_isConsumable_5_Unchecked(object sender, RoutedEventArgs e)
        {
            SwitchableName_5.Visibility = Visibility.Hidden;
            SwitchableMin_5.Visibility = Visibility.Hidden;
            SwitchableMax_5.Visibility = Visibility.Hidden;
            TB_minConsumable_5.Visibility = Visibility.Hidden;
            TB_maxConsumable_5.Visibility = Visibility.Hidden;
        }

        private void TB_isConsumable_6_Checked(object sender, RoutedEventArgs e)
        {
            SwitchableName_6.Visibility = Visibility.Visible;
            SwitchableMin_6.Visibility = Visibility.Visible;
            SwitchableMax_6.Visibility = Visibility.Visible;
            TB_minConsumable_6.Visibility = Visibility.Visible;
            TB_maxConsumable_6.Visibility = Visibility.Visible;
        }

        private void TB_isConsumable_6_Unchecked(object sender, RoutedEventArgs e)
        {
            SwitchableName_6.Visibility = Visibility.Hidden;
            SwitchableMin_6.Visibility = Visibility.Hidden;
            SwitchableMax_6.Visibility = Visibility.Hidden;
            TB_minConsumable_6.Visibility = Visibility.Hidden;
            TB_maxConsumable_6.Visibility = Visibility.Hidden;
        }
        #endregion
    }
}
