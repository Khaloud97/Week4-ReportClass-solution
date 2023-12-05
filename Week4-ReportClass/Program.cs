namespace Week4_ReportClass
{
    internal class Program
    {

        public int id { get; set; }
        public string Gender { get; set; }
        public string name { get; set; }
        public int TotalSales { get; set; }

        

        static void Main(string[] args)
        {
          Program[] Pro = new Program[]
          {
            new Program {id = 101 ,name ="khaloud", Gender="Female" ,TotalSales =75000 },
            new Program {id = 102 ,name ="Sara", Gender="Female" ,TotalSales =6000 },
            new Program {id = 103 ,name ="Hamed", Gender="Male" ,TotalSales =30920 },
            new Program {id = 104 ,name ="Reem", Gender="Female" ,TotalSales =11222 },
            new Program {id = 105 ,name ="Ahamed", Gender="Male" ,TotalSales =1920 },
            new Program {id = 106 ,name ="Johana", Gender="Female" ,TotalSales =11222 },
            new Program {id = 107 ,name ="Maryam", Gender="Male" ,TotalSales =89202 },
            new Program {id = 108 ,name ="Mona", Gender="Female" ,TotalSales =3000 },
           };

            Console.WriteLine("Employees sale count: \n");

            Report report = new Report();
            report.TotalSales(Pro);
            report.TotalSalesMore30(Pro);
            report.TotalSalesLess30(Pro);


            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("------------------With delegate----------------------\n\n");

            //dataType | functionName | (calssName + plase where value is save ) =>  calcolation 

            bool greater60k(Program p) => p.TotalSales >= 60000;
            bool between30k_60k(Program p) => p.TotalSales < 60000 && p.TotalSales >= 30000;
            bool less30k(Program p) => p.TotalSales < 30000;

            report.ProcesEmployee(Pro, "Report of Sale more than 60 k:", greater60k);
            report.ProcesEmployee(Pro, "Report of Sale between 30k and 60k:", between30k_60k);
            report.ProcesEmployee(Pro, "Report of Sale less than 30k:", less30k);


            //report.ProcesEmployee(Pro, "Report of Sale less than 30k:",(program) => program.TotalSales < 30000);

        }
    }
}