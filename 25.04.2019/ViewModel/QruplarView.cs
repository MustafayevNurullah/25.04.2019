using _25._04._2019.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._04._2019.ViewModel
{
    class QruplarView : BaseView
    {

       private Qruplar CurrentQruplar;
       public  Qruplar currentQruplar
        {
            get
            {

                return CurrentQruplar;
            }
            set
            {
                CurrentQruplar = value;
                OnpropertyChanged(new PropertyChangedEventArgs(nameof(currentQruplar)));

            }
        }

        private Qruplar SelectQruplar;
        public Qruplar selectQruplar
        {
            get
            {

                return SelectQruplar;
            }
            set
            {
                SelectQruplar = value;
                OnpropertyChanged(new PropertyChangedEventArgs(nameof(selectQruplar)));

            }
        }






        private ObservableCollection<Qruplar> Groups;

        public ObservableCollection<Qruplar> groups
        {
            get
            {
                return Groups;
            }
            set
            {

                Groups = value;
                OnpropertyChanged(new PropertyChangedEventArgs("groups"));
            }
        }
        public List<Filial> Filials = new List<Filial>();
        public List<XidmetNovu> XidmetNovu = new List<XidmetNovu>();
        public List<Seviyye> Seviyyes = new List<Seviyye>();
      





    }
}
