using System;

// Base Character class
public abstract class Character
{
    public abstract void ShowAttributes();
}

// Warrior subclass
public class Warrior : Character
{
    public override void ShowAttributes()
    {
        Console.WriteLine("Warrior: High strength and defense.");
    }
}

// Mage subclass
public class Mage : Character
{
    public override void ShowAttributes()
    {
        Console.WriteLine("Mage: High intelligence and magic power.");
    }
}

// Abstract Factory interface
public interface ICharacterFactory
{
    Character CreateCharacter();
}

// Warrior Factory
public class WarriorFactory : ICharacterFactory
{
    public Character CreateCharacter()
    {
        return new Warrior();
    }
}

// Mage Factory
public class MageFactory : ICharacterFactory
{
    public Character CreateCharacter()
    {
        return new Mage();
    }
}

// Main function to demonstrate the pattern
public class Program
{
    public static void Main(string[] args)
    {
        ICharacterFactory? factory = null;

        Console.WriteLine("Choose a character type: 1) Warrior 2) Mage");

        try
        {
            string? input = Console.ReadLine() ?? throw new FormatException("Input cannot be null.");

            int choice = int.Parse(input);

            switch (choice)
            {
                case 1:
                    factory = new WarriorFactory();
                    break;
                case 2:
                    factory = new MageFactory();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please restart the program and choose either 1 or 2.");
                    return;
            }

            Character character = factory.CreateCharacter();
            character.ShowAttributes();
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a numeric value (1 or 2).");
        }
    }
}

// Project: Basic Game Character System using Abstract Factory Pattern
// Structure: Abstract Factory Pattern
// Aim: To demonstrate how the Abstract Factory pattern simplifies the creation of different character types.
// Failure: If the pattern is overkill for the number of characters.

