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
using System.Windows.Interactivity;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using XrmTaskHelper.Domain.Entities;
using XrmTaskHelper.Infrastructure.Data.Contexts;
using XrmTaskHelper.Infrastructure.Data.Repositories;
using XrmTaskHelper.Services.DomainServices;
using XrmTaskHelperWpf.ViewModels;

namespace XrmTaskHelperWpf.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly XrmTaskDomainService _xrmTaskDs;

        public MainWindow()
        {
            InitializeComponent();

           WindowStartupLocation = WindowStartupLocation.CenterScreen;
           SourceInitialized += (s, a) => this.WindowState = WindowState.Maximized;
        }

        private void Control_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                var textBox = (sender as ContentControl).FindName("PathTextBox") as TextBox;
                System.Diagnostics.Process.Start(textBox.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка при открытии файла");
            }
        }
       
    }
}
