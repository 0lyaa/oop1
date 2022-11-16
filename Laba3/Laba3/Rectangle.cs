using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
//За допомогою Visual Studio створіть проект за шаблоном Console Application.
//Потрібно: Створити клас із ім'ям Rectangle.
//У тілі класу створити два поля, що описують довжини сторін double side1, side2.
//Створити власний конструктор Rectangle(double side1, double side2), в тілі якого
//поля side1 і side2 ініціалізуються значеннями аргументів.
//Створити два методи, що обчислюють площу прямокутника - double AreaCalculator() та периметр.
//Прямокутник - double PerimeterCalculator().
//Створити дві властивості double Area та double Perimeter з одним методом доступу get.
//Написати програму, яка приймає від користувача довжини двох сторін прямокутника і
//виводить на екран периметр та площу.
{
    internal class Rectangle
    {
        private double Area;
        private double Perimeter;
        double side1;
        double side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
            Area = AreaCalculator();
            Perimeter = PerimeterCalculator();
        }

        public double AreaCalculator()
        {
            return side1 * side2;
        }

        public double PerimeterCalculator()
        {
            return (side1 + side2) * 2;
        }

        public double getArea()
        {
            return Area;
        }
        public double getPerimeter()
        {
            return Perimeter;
        }
    }


}
