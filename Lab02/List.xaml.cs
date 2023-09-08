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

namespace Lab02
{
    /// <summary>
    /// Lógica de interacción para List.xaml
    /// </summary>
    public partial class List : Window
    {
        public List()
        {
            InitializeComponent();

            List<Conductores> personas = new List<Conductores>
        {
            new Conductores { Nombre = "Juan" },
            new Conductores { Nombre = "María" },
            new Conductores { Nombre = "Pedro" }
        };
            lstNombres.ItemsSource = personas;
        }
    }
}
