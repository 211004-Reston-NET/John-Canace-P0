using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SFBL;
using SFDL;
using SFDL.Entities;

namespace SFUI
{
    /// <summary>
    /// Designed to create menu objects
    /// </summary>
    public class MenuFactory : IFactory
    {
        public IMenu GetMenu(MenuType p_menu)
        {
            var configuration = new ConfigurationBuilder() //Configurationbuilder is the class that came from the Microsoft.extensions.configuration package
                .SetBasePath(Directory.GetCurrentDirectory()) //Gets the current directory of the RRUI file path
                .AddJsonFile("appsetting.json") //Adds the appsetting.json file in our RRUI
                .Build(); //Builds our configuration

            DbContextOptions<_211004restonnetdemoContext> options = new DbContextOptionsBuilder<_211004restonnetdemoContext>()
                .UseSqlServer(configuration.GetConnectionString("Reference2DB"))
                .Options;

            switch (p_menu)
            {
                case MenuType.MainMenu:
                    return new MainMenu();
                case MenuType.StoreMenu:
                    return new StoreMenu();
                case MenuType.CustomerMenu:
                    return new CustomerMenu();
                case MenuType.ShowStoreFront:
                    return new ShowStoreFront(new StoreFrontBL(new CloudRespository(new _211004restonnetdemoContext(options))));
                case MenuType.StoreFrontShown:
                    return new StoreFrontShown(new StoreFrontBL(new CloudRespository(new _211004restonnetdemoContext(options))));
                case MenuType.StoreInventory:
                    return new StoreInventory(new ProductBL(new CloudRespository(new _211004restonnetdemoContext(options))));
                case MenuType.AddStoreFront:
                    return new AddStoreFront(new StoreFrontBL(new CloudRespository(new _211004restonnetdemoContext(options))));
                case MenuType.OrderMenu:
                    return new OrderMenu();
                case MenuType.ShowLine_Item:
                    return new ShowLine_Item(new Line_ItemBL(new CloudRespository(new _211004restonnetdemoContext(options))));
                case MenuType.AddCustomer:
                    return new AddCustomer(new CustomerBL(new CloudRespository(new _211004restonnetdemoContext(options))));
                case MenuType.ShowCustomer:
                    return new ShowCustomer(new CustomerBL(new CloudRespository(new _211004restonnetdemoContext(options))));
                case MenuType.CustomerShown:
                    return new CustomerShown(new CustomerBL(new CloudRespository(new _211004restonnetdemoContext(options))));
                default:
                    return null;
            }
        }
    }
}