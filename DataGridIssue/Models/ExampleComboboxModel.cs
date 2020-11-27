using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DataGridIssue.Models
{
    public class ExampleComboboxModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int? ID { get; set; }
        public string Title { get; set; }
    }
}
