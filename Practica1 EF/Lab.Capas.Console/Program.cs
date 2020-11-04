using Lab.Logic;
using Lab.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Lab.Capas
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Estuve haciendo una parte web que no esta terminada con todas las funciones como agregar/moficar/eliminar pero desde consola funcionan
            
            TerritoriesLogic terLog = new TerritoriesLogic();
            var territorios = terLog.GetAll();

            #region Buscar todos los territorios
            foreach (var t in territorios)
            {  
                Console.WriteLine("Territory Id: {0} \nTerritory Description : {1} \nRegion ID: {2}\n", t.TerritoryID, t.TerritoryDescription, t.RegionID);
            }
            #endregion
            Console.WriteLine("Insertando nuevo territorio");
            try
            {
                terLog.Insert(new Lab.Entities.Territories
                {
                    RegionID = 1,
                    TerritoryDescription = "Territorio nuevo"

                });
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            CategoriesLogic catLog = new CategoriesLogic();
            try
            {
                #region Buscar una categoria

                bool si = true;
                do
                {
                    Console.WriteLine("\nBuscar una categoria:");
                    int number = Int32.Parse(Console.ReadLine());
                    var category = catLog.GetOne(number);
                    if (category != null)
                    {
                        Console.WriteLine("\nCategory Id: {0} \nCategory Name: {1} \nDescription: {2}", category.CategoryID, category.CategoryName, category.Description);
                        si = false;
                    }
                    else
                    {
                        Console.WriteLine($"El numero {number} es incorrecto");
                        si = true;
                    }
                } while (si == true);
                #endregion
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Insertando nueva categoria");
            try
            {
                catLog.Insert(new Lab.Entities.Categories
                {

                    CategoryName = "Nueva categoria",
                    Description = "Prueba"

                }); 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //prueba delete
            //terLog.Delete(id); //remplazar id por un id 
           // terLog.Update();

            Console.ReadKey();
        }
    }
}
