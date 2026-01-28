namespace Wk3Assignment3._3
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Data.Students.Add(new Student() { FirstName = "Bao", LastName = "Tran", Address = "123 Main St", Grade = Grade.A, AdmissionMonth = MonthOfAdmission.September }) ;
            Data.Students.Add(new Student() { FirstName = "Sophia", LastName = "Tran", Address = "321 Main St", Grade = Grade.B, AdmissionMonth = MonthOfAdmission.February }) ;

            Application.Run(new Form1());
        }
    }
}