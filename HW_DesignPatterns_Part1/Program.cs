using HW_DesignPatterns_Part1;


#region Singleton

Clock time1 = Clock.GetInstance();
Clock time2 = Clock.GetInstance();


if (time1 == time2)
{
    Console.WriteLine("The Current Time: " + time1.time);
}
else
{
    Console.WriteLine("Try Again");
}

#endregion

Console.WriteLine("==========================================");

#region Chain of Responsibility

Car car1 = new Car("KIA", 5488595, true);
Car car2 = new Car("Mazda", 6582145, false);
Car car3 = new Car("BMW", 2545968, false);
Car car4 = new Car("Toyota", 3265894, true);
Car car5 = new Car("Tesla", 2548679, false);

GarageHandler initialTest = new InitialTest();
GarageHandler mechanicInspection = new MechanicInspection();
GarageHandler electricianInspection = new ElectricianInspection();
GarageHandler specialistDiagnosis = new SpecialistDiagnosis();

initialTest.NextTest(mechanicInspection);
mechanicInspection.NextTest(electricianInspection);
electricianInspection.NextTest(specialistDiagnosis);
specialistDiagnosis.NextTest(null);

Console.WriteLine("Test Result: ");
initialTest.HandleCar(car1);

#endregion

Console.WriteLine("==========================================");

#region Factory

DietFactory dietFactory = new DietFactory();
dietFactory.ChoosenDiet(25, 60, 1.60);
dietFactory.ChoosenDiet(50, 80, 1.75);
dietFactory.ChoosenDiet(62, 87, 1.90);



#endregion

