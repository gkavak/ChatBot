using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Managers.Utils.Resolvers
{
    public sealed class MenuResolver
    {
        private static MenuResolver _instance;
        private Dictionary<string, string> _menus;
        private string mapFilePath;

        private MenuResolver()
        {
            _menus = createMenuMap(mapFilePath);
        }
        public static MenuResolver GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MenuResolver();
            }
            return _instance;
        }


        private Dictionary<string, string> createMenuMap(string path)
        {
            if (path == null)
            {
                Console.WriteLine("Set menu id mappings file path first!");
                return new NotImplementedException();
            }
            else
            {
                throw new NotImplementedException();
            }
        }
        public List<string> GetQuestionListByMenuId(string menuId)
        {

            return _menus[menuId].Split(",").ToList();
        }
    }
}
