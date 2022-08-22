using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Dtos
{
    public class UserQuestionDTO
    {
        public string type { get; set; }
        public int id { get; set; } 
        public int selectedQuestionId { get; set; }  
        public string otherDetails { get; set; }


}
}
