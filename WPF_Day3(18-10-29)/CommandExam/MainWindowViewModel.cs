﻿using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CommandExam
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private Emp _SelectedEmp;
        public Emp SelectedEmp {
            get { return _SelectedEmp; }
            set { _SelectedEmp = value;
                OnPropertyChanged("SelectedEmp");
            } 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string Pname = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Pname));
        }

        public RelayCommand AddEmpCommand { get; set; }
        public ObservableCollection<Emp> Emps { get; set; }

        public MainWindowViewModel()
        {
            Emps = new ObservableCollection<Emp>();
            Emps.Add(new Emp { Ename = "홍길동", Job="Salesman" });
            Emps.Add(new Emp { Ename = "김길동", Job="Programmer" });
            Emps.Add(new Emp { Ename = "정길동", Job="Manager" });
            Emps.Add(new Emp { Ename = "박길동", Job="CEO" });
            Emps.Add(new Emp { Ename = "성길동", Job="CFO" });

            AddEmpCommand = new RelayCommand(AddEmp);
        }
        public void AddEmp(object param) {
            Emps.Add(new Emp { Ename = param.ToString()});
        }
        
        
    }
}
