
namespace Week4_ReportClass
{
    internal class Report
    {  
        //delegate example:                 

        public delegate bool salesCondition(Program p);

        //       functionName  --  className to serch from it --  function + filter condation
        public void ProcesEmployee(Program[] pp ,string Title , salesCondition con)
        {
            Console.WriteLine(Title);
            Console.WriteLine("----------------------------------------");
            foreach (Program p in pp)
            {
                if (con(p))
                {

                    Console.WriteLine($"{p.id} | {p.name} | {p.Gender} | {p.TotalSales}");

                }
            }
            Console.WriteLine("\n\n");

        }




        //-------------------------------------------------------------------------------------
        //-----------------------------------with out delegate--------------------------------------------------
        public Report() { }
        public void TotalSales(Program[] prog)
        {
            Console.WriteLine("Report for emplyee total Sales more than 60 k:");
            Console.WriteLine("----------------------------------------");
            foreach (Program program in prog)
            {
                if (program.TotalSales >= 60000) {

                    Console.WriteLine($"{program.id} | {program.name} | {program.Gender} | {program.TotalSales}");

                }
            }
            Console.WriteLine("\n\n");
        }

        public void TotalSalesMore30(Program[] prog)
        {
            Console.WriteLine("Report for emplyee total Sales more than 30k and less than 60k :");
            Console.WriteLine("----------------------------------------");
            foreach (Program program in prog)
            {
                if (program.TotalSales < 60000 && program.TotalSales >=30000)
                {

                    Console.WriteLine($"{program.id} | {program.name} | {program.Gender} | {program.TotalSales}");

                }
            }
            Console.WriteLine("\n\n");
        }

        public void TotalSalesLess30(Program[] prog)
        {
            Console.WriteLine("Report for emplyee total Sales less than 30k :");
            Console.WriteLine("----------------------------------------");
            foreach (Program program in prog)
            {
                if (program.TotalSales < 30000)
                {

                    Console.WriteLine($"{program.id} | {program.name} | {program.Gender} | {program.TotalSales}");

                }
            }
            Console.WriteLine("\n\n");
        }



    }
}
