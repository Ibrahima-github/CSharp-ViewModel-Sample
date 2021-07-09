using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppUtilisationDuViewModel.CommandClient;
using WpfAppUtilisationDuViewModel.Model;

namespace WpfAppUtilisationDuViewModel.ViewModel
{
    public class ClientViewModel
    {
        private static int compteur = 0;
        public static ObservableCollection<Client> Clients { get; set; } // ListeClient
        //
        // Le sujet client va notifier automatiquement l'Observer DP: Observer(UI)
        // On veut conserver une liste de client durant toute l'execution de l'application
        // static --> nous permet d'avoir un repository

        // On créer l'objet sur lequels les TextBox vont se binder -- public

        public Client ClientVM { get; set; }
        // La Commande de l'IHM va se binder sur l'attribut AjouterClientVM qui est une Commande
        public AjouterClientCommand AjouterClientVM {get; set;}
        // dans le dossier CommandClient, on met toutes les actions liées à la gestion du client
        //ctor + tab + tab
        public ClientViewModel()
        {
            // Singleton de la liste
            if (Clients == null)
            {
                Clients = new ObservableCollection<Client>();
                ClientVM = new Client() { Id = 1231, Nom = "Nom 1", Prenom = "Prenom " };
                // Instancier la commande en lui passant en paramètre le context de la classe viewModel
                AjouterClientVM = new AjouterClientCommand(this);
            }
        }

        // Méthode qui insère un objet client dans la liste
        public int AjouterClient(Client client)
        {
            compteur++;
            client.Id = compteur;
            Clients.Add(client);
            return 1; // 
        }



 


    }
}
