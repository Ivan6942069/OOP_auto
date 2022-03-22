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
using System.Windows.Threading;

namespace OOP_auto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        vehicle auto1;
        vehicle auto2;
        DispatcherTimer timer;
        public MainWindow()
        {
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 2);
            timer.Tick += Timer_Tick;
            InitializeComponent();
            auto1 = new vehicle("Skoda");
            auto1.Type = "Osobni auto";
            Showvehicle(auto1, txt1);

            auto2 = new vehicle("VW");
            auto2.Type = "Dodavka";
            auto2.FuelLevel += 100;
            Showvehicle(auto2, txt2);
            // auto.1.brand frerrari
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            auto1.move();
            auto2.move();
            Showvehicle(auto1, txt1);
            Showvehicle(auto2, txt2);
        }

        public void Showvehicle(vehicle vehicle, TextBox textbox)
        {
            textbox.Text = $"brand: {vehicle.Brand}\n";
            textbox.Text += $"Type: {vehicle.Type}\n";
            textbox.Text += $"Fuel: {vehicle.Fuel}\n";
            textbox.Text += $"Engine volume: {vehicle.EngineVolume}\n";
            textbox.Text += $"Fuel level: {vehicle.FuelLevel}\n";
            textbox.Text += $"Distance:{vehicle.Distance}\n";
            textbox.Text += $"Pneu state:{Math.Round(vehicle.PneuState, 2)}\n";
        }

        private void move_btn_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void refuel_Click(object sender, RoutedEventArgs e)
        {
            auto1.refuel();
            //auto2.refuel();
            Showvehicle(auto1, txt1);
            //Showvehicle(auto2, txt2);
        }

        private void re_tire_btn_Click(object sender, RoutedEventArgs e)
        {
            auto1.retire();
            //auto2.retire();
            Showvehicle(auto1, txt1);
            //Showvehicle(auto2, txt2);
        }

        private void stop_btn_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

        private void move_bt2n_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void stop_btn2_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
