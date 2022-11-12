using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int index = 1;
            int depreciation = 4000;
            int EOY_Value = 24000;
            int accumulated_Depreciation = 4000;
            bool toContinue = true;
            Console.Write("  YEAR     DEPRECIATION       END-OF-YEAR VALUE     ACCUMULATED DEPRECIATION \n");
            Console.Write("  ----     ------------       -----------------     ------------------------ \n");
            do
            {
                
                Console.Write($" {index,4}         {depreciation}           {EOY_Value,12}                    {accumulated_Depreciation}\n");
                
                if (EOY_Value > 0)
                {
                    index = index + 1;
                    EOY_Value = EOY_Value - depreciation;
                    accumulated_Depreciation = accumulated_Depreciation + depreciation;
                }
                else
                {
                    toContinue = false;
                }

            } while (toContinue);
            
        }
    }
}
