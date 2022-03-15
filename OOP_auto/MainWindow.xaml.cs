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

namespace OOP_auto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        vehicle auto1;
        vehicle auto2;
        public MainWindow()
        {
            InitializeComponent();
            auto1 = new vehicle("Skoda");
            auto1.Type = "Osobni auto";
            Showvehicle(auto1, txt1);

            auto2 = new vehicle("VW");
            auto2.Type = "Dodavka";
            Showvehicle(auto2, txt2);
            // auto.1.brand frerrari
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
            auto1.move();
            auto2.move();
            Showvehicle(auto1, txt1);
            Showvehicle(auto2, txt2);
        }
    }
}
