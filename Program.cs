//
// Домашнее задание к занятию 15. Интерфейсы.
//
// Задача 1. Разработать интерфейс ISeries генерации ряда чисел. Интерфейс содержит следующие элементы:
//
// - метод void setStart(int x) -устанавливает начальное значение
// - метод int getNext() -возвращает следующее число ряда
// - метод void reset() -выполняет сброс к начальному значению
//
// Разработать классы ArithProgression и GeomProgression, которые реализуют интерфейс ISeries. 
// В классах реализовать методы интерфейса в соответствии с логикой арифметической и геометрической прогрессии соответственно.
//

using DZ15;

ArithProgression arithProgression = new ArithProgression();
arithProgression.setStart();
for (int i = 0; i < 4; i++)
{
    arithProgression.getNext();
}
arithProgression.reset();
GeomProgression geomProgression = new GeomProgression();
Console.WriteLine();
geomProgression.setStart();
for (int i = 0; i < 4; i++)
{
    geomProgression.getNext();
}
geomProgression.reset();
Console.ReadKey();

