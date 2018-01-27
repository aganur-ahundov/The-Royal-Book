﻿using System.Collections.Generic;
using System.Web.Mvc;
using TRB.BLL.Models;

namespace TRB.MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var BookList = new List<BookListItem>()
            {
                new BookListItem { Name = "Harry Potter", Author = "J.K. Rowling", Year = "2017", Description = "«Перевернув конверт трясущимися руками, Гарри увидел на обратной стороне лиловую сургучную печать с гербом: лев, орел, барсук и змея вокруг большой буквы 'Х'»." },
                new BookListItem { Name = "Зеленая миля", Author = "Стивен Кинг", Description = "Роман-событие, ставший лауреатом премии Брэма Стокера и вдохновивший Фрэнка Дарабонта на создание культового фильма, в котором Том Хэнкс сыграл, возможно, свою лучшую роль. …Стивен Кинг приглашает читателей в жуткий мир тюремного блока смертников, откуда уходят, чтобы не вернуться, приоткрывает дверь последнего пристанища тех, кто преступил закон и теперь отсчитывает последние часы...", Year = "2017" },
                new BookListItem { Name = "Унесенные ветром", Author = "Маргарет Митчелл", Description = "Эта книга стала самой популярной и самой любимой для нескольких поколений женщин, и ничего равного ей не создано по сей день. Эта книга легла в основу самого знаменитого фильма всех времен и народов. Проходят годы и годы, но \"Унесенные ветром\" не стареют, и теперь уже новым читательницам предстоит смеяться и плакать, любить и страдать, бороться и надеяться вместе с великолепной Скарлетт О'Хара...", Year = "2007" },
                 new BookListItem { Name = "Harry Potter", Author = "J.K. Rowling", Year = "2017", Description = "«Перевернув конверт трясущимися руками, Гарри увидел на обратной стороне лиловую сургучную печать с гербом: лев, орел, барсук и змея вокруг большой буквы 'Х'»." },
                new BookListItem { Name = "Зеленая миля", Author = "Стивен Кинг", Description = "Роман-событие, ставший лауреатом премии Брэма Стокера и вдохновивший Фрэнка Дарабонта на создание культового фильма, в котором Том Хэнкс сыграл, возможно, свою лучшую роль. …Стивен Кинг приглашает читателей в жуткий мир тюремного блока смертников, откуда уходят, чтобы не вернуться, приоткрывает дверь последнего пристанища тех, кто преступил закон и теперь отсчитывает последние часы...", Year = "2017" },
                new BookListItem { Name = "Унесенные ветром", Author = "Маргарет Митчелл", Description = "Эта книга стала самой популярной и самой любимой для нескольких поколений женщин, и ничего равного ей не создано по сей день. Эта книга легла в основу самого знаменитого фильма всех времен и народов. Проходят годы и годы, но \"Унесенные ветром\" не стареют, и теперь уже новым читательницам предстоит смеяться и плакать, любить и страдать, бороться и надеяться вместе с великолепной Скарлетт О'Хара...", Year = "2007" },
                 new BookListItem { Name = "Harry Potter", Author = "J.K. Rowling", Year = "2017", Description = "«Перевернув конверт трясущимися руками, Гарри увидел на обратной стороне лиловую сургучную печать с гербом: лев, орел, барсук и змея вокруг большой буквы 'Х'»." },
                new BookListItem { Name = "Зеленая миля", Author = "Стивен Кинг", Description = "Роман-событие, ставший лауреатом премии Брэма Стокера и вдохновивший Фрэнка Дарабонта на создание культового фильма, в котором Том Хэнкс сыграл, возможно, свою лучшую роль. …Стивен Кинг приглашает читателей в жуткий мир тюремного блока смертников, откуда уходят, чтобы не вернуться, приоткрывает дверь последнего пристанища тех, кто преступил закон и теперь отсчитывает последние часы...", Year = "2017" },
                new BookListItem { Name = "Унесенные ветром", Author = "Маргарет Митчелл", Description = "Эта книга стала самой популярной и самой любимой для нескольких поколений женщин, и ничего равного ей не создано по сей день. Эта книга легла в основу самого знаменитого фильма всех времен и народов. Проходят годы и годы, но \"Унесенные ветром\" не стареют, и теперь уже новым читательницам предстоит смеяться и плакать, любить и страдать, бороться и надеяться вместе с великолепной Скарлетт О'Хара...", Year = "2007" }
            };
            
            return View("/Views/Home/Index.cshtml", BookList);
        }
    }
}