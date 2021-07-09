using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppUtilisationDuViewModel.Model
{
    // cette class est une classe de type entité (Objet-valeur)
    // Stockée dans une base, généralement elle mappe une table
    // cad que vous avez une table qui a le même structure
    // Si la classe est générée par ORM (Entity framework)
    // Vous ne pouvez pas la modier 

    // Notre INotifiyPropertyChanged ne sera pas fait dans cette classe
    // La responsabilité de notifier l'IHM sera prise par le ViewModel
  public  class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

// faire un nouveau projet comme celui de l'adhérent en utilisant une classe client
    }
}
