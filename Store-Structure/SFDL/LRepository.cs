using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using SFModels;

namespace SFDL
{
    //The repository class has a bunch of methods that we will use to get or store information from the database
    //Does not actually hold the data itself
    public class LRepository : ILRepository
    {
        //Filepath need to reference from the startup project (RRUI) and hence why we need to go back a folder and cd into RRDL
        private const string _filepath = "./../SFDL/Database/Line_Item.json";
        private string _jsonString;

        public Line_Item AddLine_Item(Line_Item l_item)
        {
            //The reason why we need to grab all the information back is because File.WriteAllText method will overwrite anything inside the JSON file
            List<Line_Item> listOfLineItem = GetAllLine_Items();

            //We added the new restaurant from the parameter 
            listOfLineItem.Add(l_item);

            _jsonString = JsonSerializer.Serialize(listOfLineItem, new JsonSerializerOptions{WriteIndented=true});

            //This is what adds the storefront.json
            File.WriteAllText(_filepath,_jsonString);

            //Will return a storefront object from the parameter
            return l_item;
        }


        public List<Line_Item> GetAllLine_Items()
        {
            //File class will just read everything in the StoreFront.json and put it in a string
            _jsonString = File.ReadAllText(_filepath);

            //Since we are converting from a string to an object that C# understands we need to deserialize the string to object.
            //Json Serializer has a static method called Deserialize and thats why you don't need to instantiate it
            //The parameter of the Deserialize method needs a string variable that holds the json file
            return JsonSerializer.Deserialize<List<Line_Item>>(_jsonString);
        }
    }
}