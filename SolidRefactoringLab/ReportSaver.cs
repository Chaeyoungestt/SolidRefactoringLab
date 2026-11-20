using System;

namespace SolidRefactoringLab
{
    public class ReportSaver
    {
        public void SaveToFile(string fileName)
        {
            Console.WriteLine("Saving report to " + fileName + "...");
        }
    }
}
