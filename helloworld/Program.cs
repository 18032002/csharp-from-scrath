namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            DateOnly dateConverted = new DateOnly();
            string nameInput;
            string birthdayInput;

            Console.WriteLine("Hola Bienvenido a el calculador de años!");
            Console.WriteLine("Escribe tu nombre: ");
            nameInput = Console.ReadLine();

            Console.WriteLine($"Un gusto conocerte {nameInput}");

            Console.WriteLine("Escribe tu fecha de nacimiento en formato dd/mm/yy: ");
            birthdayInput = Console.ReadLine();

            bool isDateValid = DateOnly.TryParse(birthdayInput, out dateConverted);

            if (isDateValid == false)
            {
                Console.WriteLine("La fecha de nacimiento es invalida usted nos envio este dato erroneo (birthdayInpu)");
                var Person = new Person{
                    Name = birthdayInput,
                    Birthday = dateConverted,
                    Age = DateTime.Now.Year-dateConverted.Year
                };
            Console.WriteLine($"Tu nombre: {Person.Name}");
            Console.WriteLine($"Tu fecha de nacimiento: {Person.Birthday}");
            Console.WriteLine($"Tu edad es: {Person.Age} años!");
            }

            Console.WriteLine();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateOnly Birthday { get; set; }
    }
}