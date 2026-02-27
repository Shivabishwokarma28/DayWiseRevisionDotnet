using System;
using System.Collections.Generic;

namespace DocumentSystem
{
    // Parent Class: The blueprint that cannot be instantiated
    public abstract class Document
    {
        // 1. Shared Property
        public string FileName { get; set; }

        // 2. Concrete Method: Shared logic for all documents
        public void Save() 
        {
            Console.WriteLine($"[SAVE]: {FileName} has been saved to the hard drive.");
        }

        // 3. Abstract Method: Forced requirement for all children
        public abstract void Open(); 
    }

    // Child Class 1
    public class PdfDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine($"[OPEN]: Opening '{FileName}' as a PDF using Adobe Reader logic...");
        }
    }

    // Child Class 2
    public class WordDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine($"[OPEN]: Opening '{FileName}' as a Word Doc using Microsoft Office logic...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Note: You CANNOT do 'new Document()' - it would cause a compiler error.
            
            // Create a list of Documents (Polymorphism)
            List<Document> myFiles = new List<Document>();

            myFiles.Add(new PdfDocument { FileName = "Tax_Report.pdf" });
            myFiles.Add(new WordDocument { FileName = "Resume_Draft.docx" });

            foreach (var doc in myFiles)
            {
                // Every document knows how to Save (inherited logic)
                doc.Save(); 

                // Every document opens differently (overridden logic)
                doc.Open(); 
                
                Console.WriteLine("----------------------------------");
            }

            Console.WriteLine("All documents processed.");
            Console.ReadKey();
        }
    }
}
