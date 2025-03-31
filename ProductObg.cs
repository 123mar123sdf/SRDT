using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Расписание_занятий
{
    class ProductObg
    {
        public static int ID_Понедельник { get; set; }
        public static Nullable<int> ID_Дня_недели { get; set; }
        public static Nullable<int> Номер_урока { get; set; }
        public static string Время { get; set; }
        public static Nullable<int> ID_Предмета { get; set; }
        public static Nullable<int> ID_Учителя { get; set; }
        public static Nullable<int> ID_Кабинета { get; set; }
        public static Nullable<int> ID_Группы { get; set; }

    }
}
