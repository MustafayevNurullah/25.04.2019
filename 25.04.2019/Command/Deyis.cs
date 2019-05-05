using _25._04._2019.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _25._04._2019.Command
{
    class Deyis : ICommand
    {
       public QruplarView qruplarView { get; set; }
        public Deyis(QruplarView QruplarView)
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


        }
    }
}
