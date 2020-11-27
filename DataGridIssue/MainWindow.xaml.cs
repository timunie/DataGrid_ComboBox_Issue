using DataGridIssue.Models;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace DataGridIssue
{
    public partial class MainWindow : MetroWindow, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<ExampleGridModel> exampleGridList { get; set; }
        public ObservableCollection<ExampleComboboxModel> exampleComboboxList { get; set; }

        public MainWindow()
        {
            exampleGridList = new ObservableCollection<ExampleGridModel>();
            exampleComboboxList = new ObservableCollection<ExampleComboboxModel>();

            GenerateDummyData();

            InitializeComponent();
            DataContext = this;
        }

        private void GenerateDummyData()
        {
            for(int i = 0; i < 400; i++)
            {
                var model = new ExampleGridModel();
                model.Field = "Field " + i.ToString();

                exampleGridList.Add(model);
            }

            for (int i = 0; i < 40; i++)
            {
                var model = new ExampleComboboxModel();
                model.ID = i;
                model.Title = "Value " + i.ToString();

                exampleComboboxList.Add(model);
            }
        }
    }
}
