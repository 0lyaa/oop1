using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
//За допомогою Visual Studio створіть проект за шаблоном Console Application.
//Потрібно:
//Створити клас Book.Створити класи Title, Author та Content, кожен з яких повинен містити
//одне рядкове поле та метод void Show().
//Реалізуйте можливість додавання до книги назви книги, імені автора та змісту.
//Виведіть на екран різними кольорами за допомогою методу Show() назву книги, ім'я автора та зміст.
{
    internal class Book
    {
        Title title;
        Author author;
        Content content;

        public Book(Title title, Author author, Content content)
        {
            this.title = title;
            this.author = author;
            this.content = content;
        }

        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }

    }
}
