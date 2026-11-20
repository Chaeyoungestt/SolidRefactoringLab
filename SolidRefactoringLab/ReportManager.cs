namespace SolidRefactoringLab
{
    public class ReportManager
    {
        private IReportFormatter formatter;

        public ReportManager(IReportFormatter formatter)
        {
            this.formatter = formatter;
        }

        public void GenerateReport()
        {
            formatter.FormatReport();
        }
    }
}
