Imports CarLibrary
Module Module1

    Sub Main()
        Console.WriteLine("**** VB CarLibrary Client App ****")
        Dim van As New MiniVan()
        van.TurboBoost()

        Dim viper As New SportsCar()
        viper.TurboBoost()

        Dim dreamCar As New PerformanceCar()
        dreamCar.PetName = "Hank"
        dreamCar.TurboBoost()
        Console.ReadLine()
    End Sub

End Module
