﻿using _25._04._2019.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace _25._04._2019.Command
{
    class ElaveEt : ICommand
    {
      public   QruplarView qruplarView { get; set; }
        public ElaveEt( QruplarView QruplarView)
        {
            qruplarView = QruplarView;
        }
      

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
             var item = qruplarView.groups.FirstOrDefault(x => x.Id==qruplarView.currentQruplar.Id);

            qruplarView.groups.Add(qruplarView.currentQruplar);
            //if(item==null)
            //{
            //}
            qruplarView.state = 2;
            
        }
    }
}
