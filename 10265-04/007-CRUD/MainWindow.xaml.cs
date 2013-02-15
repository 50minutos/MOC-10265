using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Diagnostics;

namespace _007_CRUD
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            AtualizarDados();
        }

        private void AtualizarDados()
        {
            using (var mc = new ModelContainer())
            {
                var dados = mc.Clientes.Select(x => new { x.Id, x.Nome }).ToList();

                Dados.ItemsSource = dados;
            }
        }

        private void Ins_Click(object sender, RoutedEventArgs e)
        {
            using (var mc = new ModelContainer())
            {
                mc.Clientes.AddObject(
                    new Cliente { Nome = "Epaminondas" }
                    );

                mc.SaveChanges();

                AtualizarDados();
            }
        }

        private void Upd_Click(object sender, RoutedEventArgs e)
        {
            if (Dados.SelectedItem == null) return;

            using (var mc = new ModelContainer())
            {
                var id = Convert.ToInt32(Dados.SelectedItem.GetType().GetProperties().FirstOrDefault(x => x.Name.Equals("Id")).GetValue(Dados.SelectedItem, null));

                var cliente = mc.Clientes.FirstOrDefault(x => x.Id == id);

                if (cliente == null) return;

                cliente.Nome += " alterado";

                mc.SaveChanges();

                AtualizarDados();
            }
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            if (Dados.SelectedItem == null) return;

            using (var mc = new ModelContainer())
            {
                var id = Convert.ToInt32(Dados.SelectedItem.GetType().GetProperties().FirstOrDefault(x => x.Name.Equals("Id")).GetValue(Dados.SelectedItem, null));

                var cliente = mc.Clientes.FirstOrDefault(x => x.Id == id);

                if (cliente == null) return;

                mc.Clientes.DeleteObject(cliente);

                mc.SaveChanges();

                AtualizarDados();
            }
        }
    }
}
