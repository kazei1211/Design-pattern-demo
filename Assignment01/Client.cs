using System;
using System.Collections.Generic;

namespace Assignment01
{
    class Client
    {
        public static void Main()
        {
            Manager ceo = new Manager("John", "CEO", 10000);

            Manager marketingDirector = new Manager("Alice", "VDr Marketing", 7000);
            Manager productionDirector = new Manager("Bob", "VDr SanXuat", 7000);
            ceo.AddEmployee(marketingDirector);
            ceo.AddEmployee(productionDirector);

            Staff advertisingStaff1 = new Staff("Charlie", "NV QuangCao", 3000);
            Staff advertisingStaff2 = new Staff("David", "NV QuangCao", 3000);
            marketingDirector.AddEmployee(advertisingStaff1);
            marketingDirector.AddEmployee(advertisingStaff2);

            Staff accountingStaff1 = new Staff("Eve", "NV KeToan", 3000);
            Staff accountingStaff2 = new Staff("Frank", "NV KeToan", 3000);
            Staff logisticsStaff = new Staff("Grace", "NV VanChuyen", 3000);
            productionDirector.AddEmployee(accountingStaff1);
            productionDirector.AddEmployee(accountingStaff2);
            productionDirector.AddEmployee(logisticsStaff);

            ceo.DisplayDetails();
        }
    }
}