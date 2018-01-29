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
            var HomeView = new MasterPageItem() { Title = "Dashboard ", TargetType = typeof(dashboardPageView) };
            // Adicionando items no menuLista
            menuLista.Add(HomeView);
            //retorna a lista de itens 
            return menuLista;
        }
    }
}
