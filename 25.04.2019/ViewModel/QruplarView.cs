﻿using _25._04._2019.Command;
using _25._04._2019.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _25._04._2019.ViewModel
{
    class QruplarView : BaseView
    {
        public ElaveEt Add => new ElaveEt(this);
        public Deyis Update => new Deyis(this);
        public Imtina imtina => new Imtina(this);
        public QruplarView()
        {
            CurrentQruplar = new Qruplar();
            SelectQruplar = new Qruplar();
        }
       private Qruplar CurrentQruplar ;
    private int State;
        public int state
        {
            get
            {

                return State;
            }
            set
            {
                State = value;

                OnpropertyChanged(new PropertyChangedEventArgs(nameof(state)));

            }
        }  
        public Qruplar currentQruplar
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
                state = 2;
                SelectQruplar = value;
                if(value!=null)
                {
                     currentQruplar = selectQruplar.Clone();
                }
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
 
        public List<Filial> Filials { get; set; }
        public List<XidmetNovu> XidmetNovu { get; set; }
        public List<Seviyye> Seviyyes { get; set; }


    }
}
