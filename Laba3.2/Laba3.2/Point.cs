using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3._2
//За допомогою Visual Studio створіть проект за шаблоном Console Application.
//Потрібно:
//Створити класи Point та Figure.
//Клас Point повинен містити два цілих поля і одне рядкове поле.
//Створити три властивості одним методом доступу get.
//Створити власний конструктор, у тілі якого проініціалізуйте поля значеннями аргументів.
//Клас Figure повинен містити конструктори, які приймають від 3 до 5 аргументів типу Point.
//Створити два методи: double LengthSide(Point A, Point B), що розраховує довжину сторони багатокутника;
//void PerimeterCalculator(), що розраховує периметр багатокутника.Написати програму, яка виводить
//на екран назву та периметр багатокутника.
{
    internal class Point
    {
        int x;
        int y;
        string name;

        public Point(string name, int x, int y)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public string GetPoint()
        {
            return name + "(" + x + "," + y + ")";
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

    }
}
