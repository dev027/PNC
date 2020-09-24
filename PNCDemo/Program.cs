using System;
using System.Collections.Generic;
using PNCDemo.Models;
using PNCDemo.Models.Actuals;

namespace PNCDemo
{
    public static class Program
    {
        static void Main()
        {
            Person person = new Person()
            {
                FirstName = "Steve",
                Surname = "Wright"
            };

            PncActualPersonResult actualPersonResult = new PncActualPersonResult()
            {
                Person = person,
                Message = "My message"
            };

            PncActualResult actualResult = actualPersonResult;
            PncSuccessResult successResult = actualPersonResult;
            PncResult result = actualPersonResult;

            PncSuccessResult successResult1 = (PncSuccessResult)result;
            PncActualResult actualResult1 = (PncActualResult)result;
            PncActualPersonResult personResult1 = (PncActualPersonResult)result;

            Console.WriteLine($"actualPersonResult: {actualPersonResult}");
            Console.WriteLine();
            Console.WriteLine($"actualResult: {actualResult}");
            Console.WriteLine(); 
            Console.WriteLine($"successResult: {successResult}");
            Console.WriteLine(); 
            Console.WriteLine($"result: {result}");
            Console.WriteLine(); 
            Console.WriteLine($"successResult1: {successResult1}");
            Console.WriteLine(); 
            Console.WriteLine($"actualResult1: {actualResult1}");
            Console.WriteLine(); 
            Console.WriteLine($"personResult1: {personResult1}");

            bool isResult = result is PncResult;
            bool isSuccessResult = result is PncSuccessResult;
            bool isFailureResult = result is PncFailureResult;
            bool isPossibleResult = result is PncPossibleResult;
            bool isPossibleListResult = result is PncPossibleListResult;
            bool isActualResult = result is PncActualResult;
            bool isActualAddressResults = result is PncActualAddressResult;
            bool isActualPersonResult = result is PncActualPersonResult;
            bool isActualVehicleResult = result is PncActualVehicleResult;

            Console.WriteLine($"isResult {isResult}");
            Console.WriteLine($"isSuccessResult {isSuccessResult}");
            Console.WriteLine($"isFailureResult {isFailureResult}");
            Console.WriteLine($"isPossibleResult {isPossibleResult}");
            Console.WriteLine($"isPossibleListResult {isPossibleListResult}");
            Console.WriteLine($"isActualResult {isActualResult}");
            Console.WriteLine($"isActualAddressResults {isActualAddressResults}");
            Console.WriteLine($"isActualPersonResult {isActualPersonResult}");
            Console.WriteLine($"isActualVehicleResult {isActualVehicleResult}");

            PncActualVehicleResult vehicleResult = (PncActualVehicleResult)result;
        }
    }
}
