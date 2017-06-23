
namespace _05.NoteStatistics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<double> inputFrequencies = Console.ReadLine()
                .Split(' ').Select(double.Parse).ToList();

            List<double> frequencies = new List<double>
            {261.63, 277.18, 293.66, 311.13, 329.63, 349.23, 369.99, 392.00, 415.30, 440.00, 466.16, 493.88};

            List<string> notes = new List<string>
            {"C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B"};

            List<string> representNotes = new List<string>();

            foreach (var frequency in inputFrequencies)
            {
                int noteIndex = frequencies.IndexOf(frequency);
                string note = notes[noteIndex];
                representNotes.Add(note);
            } 

            Console.WriteLine("Notes: {0}", string.Join(" ", representNotes));

            List<string> naturalNotes = new List<string>();
            List<string> sharpNotes = new List<string>();

            foreach (var note in representNotes)
            {
                if (note.Contains("#"))
                {
                    sharpNotes.Add(note);
                }
                else
                {
                    naturalNotes.Add(note);
                }
            }

            Console.WriteLine("Naturals: {0}", string.Join(", ", naturalNotes));
            Console.WriteLine("Sharps: {0}", string.Join(", ", sharpNotes));

            double sumNaturalNotes = 0;

            foreach (var note in naturalNotes)
            {
                int frequencyIndex = notes.IndexOf(note);
                double frequency = frequencies[frequencyIndex];
                sumNaturalNotes += frequency;
            }

            double sumSharpNotes = 0;

            foreach (var note in sharpNotes)
            {
                int frequencyIndex = notes.IndexOf(note);
                double frequency = frequencies[frequencyIndex];
                sumSharpNotes += frequency;
            }

            Console.WriteLine($"Naturals sum: {sumNaturalNotes}");
            Console.WriteLine($"Sharps sum: {sumSharpNotes}");

        }
    }
}
