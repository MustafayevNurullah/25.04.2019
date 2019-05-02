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
        private List<Filial> filials = new List<Filial>();
        public List<Filial> Filials
        {
            get
            {

                return filials;
            }
            set
            {
                filials = value;
                OnpropertyChanged(new PropertyChangedEventArgs("Filials"));

            }
        }

        private List<XidmetNovu> XidmetNovu = new List<XidmetNovu>();
        public List<XidmetNovu> xidmetNovu_
        {

            get
            {
                return XidmetNovu;
            }
            set
            {

                XidmetNovu = value;
                OnpropertyChanged( new PropertyChangedEventArgs("xidmetNovu_"));

            }

        }

        private List<Seviyye> Seviyyes = new List<Seviyye>();
        public List<Seviyye> seviyyes
        {

            get
            {
                return Seviyyes;
            }
            set
            {

                Seviyyes = value;
                OnpropertyChanged(new PropertyChangedEventArgs("seviyyes"));

            }

        }





    }
}
