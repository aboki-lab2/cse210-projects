using System;
using System.IO;

// A class to represent a journal entry
class JournalEntry
{
    // Member variables
    private string question; // The prompt for the entry
    private string answer; // The user's response
    private DateTime date; // The date of the entry

    // Constructor
    public JournalEntry(string question, string answer)
    {
        this.question = question;
        this.answer = answer;
        this.date = DateTime.Now;
    }

    // A method to save the entry to a file
    public void SaveToFile(string fileName)
    {
        // Append the entry to the file in a formatted way
        using (StreamWriter writer = File.AppendText(fileName))
        {
            writer.WriteLine("Question: " + question);
            writer.WriteLine("Answer: " + answer);
            writer.WriteLine("Date: " + date.ToString("dd/MM/yyyy"));
            writer.WriteLine();
        }
    }
}

// A class to manage the journal
class Journal
{
    // Member variables
    private string fileName; // The name of the file to store the entries
    private string[] questions; // An array of prompts for the entries
    private int index; // The current index of the questions array

    // Constructor
   public Journal(string fileName)
    {
        this.fileName = fileName;
        // Initialize the questions array with some sample prompts
        questions = new string[]
        {
            "What did you do today?",
            "What are you grateful for?",
            "What are you looking forward to tomorrow?",
            "How are you feeling right now?"
        };
        // Set the index to 0
        index = 0;
    }

    // A method to get the next question from the array
    public string GetNextQuestion()
    {
        // Return the question at the current index and increment the index
    return questions[index++];
    }

    // A method to create a new entry and save it to the file
    public void CreateEntry(string answer)
    {
        // Get the question from the array
        string question = GetNextQuestion();
        // Create a new journal entry object
        JournalEntry entry = new JournalEntry(question, answer);
        // Save the entry to the file
        entry.SaveToFile(fileName);
    }
}

// The main program class
class Program
{
    // The main method
    static void Main(string[] args)
    {
        // Create a new journal object with a file name
        Journal journal = new Journal("journal.txt");
        // A variable to store the user's input
        string input;
        // A loop to ask the user four questions
        for (int i = 0; i < 4; i++)
        {
            // Get the next question from the journal object
            string question = journal.GetNextQuestion();
            // Display the question to the user
            Console.WriteLine(question);
            // Read the user's input
            input = Console.ReadLine();
            // Create a new entry and save it to the file
            journal.CreateEntry(input);
        }
        // Display a message to the user
        Console.WriteLine("Thank you for using the journal program.");
    }
}
