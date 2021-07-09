using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfAppUtilisationDuViewModel.Model;
using WpfAppUtilisationDuViewModel.ViewModel;

namespace WpfAppUtilisationDuViewModel.CommandClient
{
    public class AjouterClientCommand : ICommand
    {
        // cette classe s'appelle un Relai de Commande
        // tester la capacité d'exécution de l'ajout du client
        // => Validation de la saisie la saisie utilisateur
        // D'ordonner l'Ajout du client --> elle l'ordonne si la capacicté d'execution est vrai
        private ClientViewModel clientViewModel;

        public AjouterClientCommand(ClientViewModel clientViewModel)
        {
        
            this.clientViewModel = clientViewModel;
        
        
        }

        // La classe qui gére les Commandes est la classe CommandManager
        // contient un delegate Suggestion des evèmenments peut informer toutes autres delegates
        // qui souhaites etre informés
       
        // 
         
        public bool CanExecute(object parameter)
            // validation de la saisie utilisateur (id > 100 ou Nom doit avoir 1 char)
        {
            // Pour récupérer le client qui est dans le paramètre, on fait un CAST
            Client _client = (Client)parameter;
            bool ok = false;
            // test validation saisie utilisateur id > 1000 (par exemple pas d'id < 1000)
            if (_client != null)
            { // tests
                // on peut utiliser des regex 
                ok = _client.Id > 1000;
                ok = ok && (_client.Nom.Length > 2);
            }
                return ok;
        }
        public event EventHandler CanExecuteChanged
        {
            //
            add {  CommandManager.RequerySuggested += value;             }
            remove { CommandManager.RequerySuggested -= value; }
        }


        public void Execute(object parameter)
        {
            // ordonner l'execution
            Client clientAAjouter = new Client(); // nouvelle référence, pour 
            Client clientParam = (Client)parameter;
            // AutoMapper
            clientAAjouter.Id = clientParam.Id;
            clientAAjouter.Nom = clientParam.Nom;
            clientAAjouter.Prenom = clientParam.Prenom;

            clientViewModel.AjouterClient(clientAAjouter); // Modifier
        }
    }
}
