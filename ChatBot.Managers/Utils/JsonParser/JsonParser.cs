using ChatBot.Managers.Types.Abstracts;
using ChatBot.Managers.Types.Concrete;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Managers.Utils.JsonParser
{
    public class JsonParser
    {

        public static IResolvable ParseJSONToMenuOrQuestion(string json)
        {
            JObject jObject = JObject.Parse(json);

            string id, type;
            Dictionary<string,string> otherDetails = jObject.ToObject<Dictionary<string, string>>();
            if ((string)jObject["type"] == "question")
            {
                return new Question((string)jObject["selected_question_id"], otherDetails);

            }else if((string)jObject["type"] == "menu")
            {
                return new Menu((string)jObject["id"], otherDetails);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
