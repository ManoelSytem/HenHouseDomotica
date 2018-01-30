using HenHouseDomotica.Models;
using HenHouseDomotica.Views;
using System.Collections.ObjectModel;


namespace HenHouseDomotica.Services
{
    public class ItemService
    {
        private static ObservableCollection<MasterPageItem> menuLista { get; set; }

        public static ObservableCollection<MasterPageItem> GetMenuItens()
        {
            menuLista = new ObservableCollection<MasterPageItem>();
            // Criando as paginas para navegação
            // Definimos o titulo para o item
            // o icone do lado esquerdo e a pagina que vamos abrir
            var HomeView = new MasterPageItem() { Title = "Dashboard ", TargetType = typeof(HomePage) };
            var EventoView = new MasterPageItem() { Title = "Eventos", TargetType = typeof(EventoPage) };
            var SobreView = new MasterPageItem() { Title = "Sobre", TargetType = typeof(SobrePage) };
            // Adicionando items no menuLista
            menuLista.Add(HomeView);
            menuLista.Add(EventoView);
            menuLista.Add(SobreView);
            //retorna a lista de itens 
            return menuLista;
        }
    }
}
