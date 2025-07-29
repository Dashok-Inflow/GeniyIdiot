using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace ГенийИдиотClassLibrary1
{
    public class UserStorage
    {
        public static string Path = "Гений-Идиот, результаты тестирования.json";

        public static void SaveUserResults(User user)
        {
            var usersResult = GetUsersResults();
            usersResult.Add(user);
            Save(usersResult);
        }
        public static List<User> GetUsersResults()
        {
            if(!FileProvider.CheckFile(Path))
            {
                return new List<User>();
            }
            var value = FileProvider.GetValue(Path);
            var userResults=JsonConvert.DeserializeObject<List<User>>(value);
            return userResults;
        }

        static void Save(List<User> usersResult)
        {
            var jsonData=JsonConvert.SerializeObject(usersResult,Formatting.Indented);
            FileProvider.Replace(Path, jsonData);
        }
    }
}