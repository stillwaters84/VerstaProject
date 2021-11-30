using System;
using System.Collections.Generic;
using System.Linq;
using TestTask1.Models;
using System.Threading.Tasks;

namespace TestTask1.Data
{
    public static class DbInitializer
    {
        public static void Initialize(OrderContext context)
        {
            context.Database.EnsureCreated();
            if (context.Orders.Any())
            {
                return;
            }
            //тестовые значения, при наличие базы postgresql не требуется
            var orders = new Order[]
            {
                new Order{SenderCity="Москва",SenderAddress="Улица Пушкина",RecieverCity="Санкт-Петербург",RecieverAddress="Дом Колотушкина",Weight=(float)0.1,Date=DateTime.Parse("2021-11-30")},
                new Order{SenderCity="Санкт-Петербург",SenderAddress="Улица Художника Дятлова",RecieverCity="Архангельск",RecieverAddress="Обводный канал",Weight=(float)0.2,Date=DateTime.Parse("2021-11-29")},
                new Order{SenderCity="Архангельск",SenderAddress="Варавина",RecieverCity="Москва",RecieverAddress="Охотный ряд",Weight=(float)0.3,Date=DateTime.Parse("2021-11-28")}
            };
            context.AddRange(orders);
            context.SaveChanges();
        }
    }
}
