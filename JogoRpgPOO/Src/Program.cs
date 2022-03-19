using JogoRpgPOO.Entities;


Hero arus= new Hero("Arus", 12, "Knight");

Wizard wizard = new Wizard("Jennica", 23, "White Wizard");


Console.WriteLine(arus.Attack());
Console.WriteLine(wizard.Attack());
Console.WriteLine(wizard.Attack2(1));



Console.ReadLine();