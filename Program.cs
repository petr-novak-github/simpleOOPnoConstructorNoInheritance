using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Vytvořte třídy Student, Accountant a Teacher (tedy všechny tři budou v jednom souboru). 
//Všechny tři budou mít datovou složku age, Student navíc scholarship, Accountant a Teacher 
//místo toho salary. A Teacher navíc třetí datovou složku: teachingTime(počet úvazkových hodin).
//Všechny datové složky budou celočíselné. Všechny třídy budou obsahovat metodu writeInfo(), 
//která vypíše hodnotu všech datových složek. Do metody Main() umístěte vytvoření po jedné instanci z tříd Student,
//Accountant i Teacher (nazvěte je např. s1, a1, t1) včetně naplnění datových složek nějakými hodnotami. 
//Potom datové složky každé instance vypište. 
//V tomto bodě ještě nepoužívejte konstruktory ani dědičnost a dejte si pozor, abyste nedělali třídy jako vnitřní!

namespace simpleOOPnoConstructorNoInheritance
{

	class Student
	{
		// datove slozky tridy
		public int age, scholarship;

		//metoda tridy
		public void writeInfo()
		{
			Console.WriteLine($"věk studenta: {age}, scholarship: {scholarship}");
			// interpolovane stringy
		}
	}
	class Accountant
	{
		public int age, salary;
		public void writeInfo()
		{
			Console.WriteLine("věk ekonomky: " + age + ", salary: " + salary);
		}
	}
	class Teacher
	{
		public int age, salary, teachingTime;
		public void writeInfo()
		{
			Console.Write("věk učitele:  " + age + ", salary: " + salary);
			Console.WriteLine(", počet úvazkových hodin: " + teachingTime);
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Student s1 = new Student();
			s1.age = 20;
			s1.scholarship = 1000;
			s1.writeInfo();
			Accountant e1 = new Accountant();
			e1.age = 30;
			e1.salary = 12000;
			e1.writeInfo();
			Teacher u1 = new Teacher();
			u1.age = 40;
			u1.salary = 20000;
			u1.teachingTime = 22;
			u1.writeInfo();
			Console.ReadLine();
		}
	}
}