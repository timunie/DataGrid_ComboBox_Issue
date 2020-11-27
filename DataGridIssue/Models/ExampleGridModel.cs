using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DataGridIssue.Models
{
    public class ExampleGridModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Field { get; set; }
        public int? SelectedID { get; set; }
    }
}
