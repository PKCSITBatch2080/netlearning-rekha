using System;

Console.WriteLine(36886765);

DataTypes dt = new();
dt.Learn();

Methods m = new();
m.Greet("Hi");
m.CalculateBMI(222.2f, 333.33f);

var highest = m.GetMax(3.4, 5.6, 78.4, 23.4);
var highest2 = m.GetMax(3.4, 5.6);
var highest3 = m.GetMax(3.4, 5.6, 78.4, 23.4, 67.8);
var highest4 = m.GetMax(3.4);

Generics g = new();
g.Display<string>(" Rekha ");
g.Display<int>(888);

Student rama = new Student();
Student rekha = new Student("Rekha Aryal", 123);

rama.RollNumber = 22;      // Assined
rekha.RollNumber = 223;    // Not Assigned



