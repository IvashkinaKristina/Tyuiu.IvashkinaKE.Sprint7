using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.IvashkinaKE.Sprint7.Project.V3.Lib;

namespace Tyuiu.IvashkinaKE.Sprint7.Project.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void TestMethod1()
        {
            string[,] array = { { "1", "Семёнов Илья Павлович", "Мельникайте 70", "профессор", "01", "дискретная математика", "12", "семинар", "высшая математика", "101", "МиПИТ", "11", "522" },
                                { "2", "Сергеева Ксения Яновна", "Володарского 38", "лаборант", "02", "ядерная физика", "14", "экзамен", "физика", "202", "МиПИТ", "22", "340" },
                                { "3", "Андреенко Станислав Аркадьевич", "Республики 47", "декан", "03", "изучение языка Питон", "16", "коллоквиум", "программирование", "303", "МиПИТ", "33", "715" }, };
        }
    }
       
    }

