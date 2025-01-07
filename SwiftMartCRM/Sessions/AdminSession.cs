using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMart.Sessions
{
    public class AdminSession
    {
        private static AdminSession instance;
        public static AdminSession Instance => instance ??= new AdminSession();

        // Данные текущего пользователя
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        

        // Приватный конструктор
        private AdminSession() { }
    }
}
