using System;

namespace Yahya_Olalekan_Assessment_Sol
{
    class Program
    {
        static void Main(string[] args)
        {
            
//             1. Write a program to count how many numbers between 1 and 100 are divisible 
// by 3 with no remainder. Display the count on the console.

             
           
            // int count = 0;
            // for(int i = 1; i < 100; i++)
            // {
            //     if(i % 3 == 0)
            //     {
            //         count++;
            //     }
            // }
            // Console.WriteLine($"The count of the numbers is {count}");
            




// 2. Write a program and ask the user to enter a number. Compute the factorial of 
// the number and print it on the console. For example, if the user enters 5, the 
// program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

                
                
                // Console.Write("Enter a number: ");
                // int num = int.Parse(Console.ReadLine());
                // decimal factorial = 1;
                // for(int i = 1; i <= num; i++)
                // {
                //     factorial *= i;
                // }
                // Console.WriteLine($" {num}! = {factorial}");

            




// 3. Write a program and ask the user to enter a number. The number should be 
// between 1 to 10. If the user enters a valid number, display "Valid" on the console. 
// Otherwise, display "Invalid". (This logic is used a lot in applications where values 
// entered into input boxes need to be validated.)


                    // Console.Write("Enter a number: ");
                    // bool isValid = int.TryParse(Console.ReadLine(), out int num);
                    // if(num > 1 && num < 10)
                    // {
                    //     Console.WriteLine("Valid");
                    // }
                    // else
                    // {
                    //     Console.WriteLine("Invalid");
                    // }






// 4. Write a program which takes two numbers from the console and displays the maximum of the two.


           
            // Console.Write("Enter the first number: ");
            // int firstNum = int.Parse(Console.ReadLine());
           
            // Console.Write("Enter a number: ");
            // int secondNum = int.Parse(Console.ReadLine());
            // int max = firstNum;
            // if(secondNum > max)
            // {
            //     max = secondNum;
            // }
            // Console.WriteLine($"The maximum of the two numbers is {max}");





// 5. Write a program and ask the user to enter the width and height of an image. Then tell if the 
// image is landscape or portrait.


            // Console.Write("Enter the width of an image: ");
            // double width = double.Parse(Console.ReadLine());
           
            // Console.Write("Enter the height of an image: ");
            // double height = double.Parse(Console.ReadLine());
            
            // if(height > width)
            // {
            //     Console.WriteLine("The image is portrait");
            // }
            // else
            // {
            //     Console.WriteLine("The image is landscape");
            // }







// 6. Your job is to write a program for a speed camera. For simplicity, ignore the details such as 
// camera, sensors, etc and focus purely on the logic. Write a program that asks the user to enter the 
// speed limit. Once set, the program asks for the speed of a car. If the user enters a value less than 
// the speed limit, program should display Ok on the console. If the value is above the speed limit, 
// the program should calculate the number of demerit points. For every 5km/hr above the speed limit, 
// 1 demerit points should be incurred and displayed on the console. If the number of demerit points is 
// above 12, the program should display License Suspended.


        //     Console.Write("Enter the speed limit of the car: ");
        //     double speedLimit = double.Parse(Console.ReadLine());
            
        //     Console.Write("Enter the speed of the car: ");
        //     double speeOfcar = double.Parse(Console.ReadLine());
        //     if(speedLimit > speeOfcar)
        //     {
        //         Console.WriteLine("Ok");
        //     }
        //     else if(speeOfcar > speedLimit)
        //     {
        //         double demeritPoint = Math.Floor((speeOfcar - speedLimit) / 5.0);
        //         Console.WriteLine($"Your demerit points is {demeritPoint}");
        //         if(demeritPoint > 12)
        //         {
        //                 Console.WriteLine("Licence Suspended");
        //         }
        //     }







// 7. (Compute the perimeter of a triangle) Write a program that reads three edges for a
// triangle and computes the perimeter if the input is valid. Otherwise, display that
// the input is invalid. The input is valid if the sum of every pair of two edges is
// greater than the remaining edge.


        // Console.Write("Enter the first edge of the triangle: ");
        // double firstEdge  = double.Parse(Console.ReadLine());        
        
        // Console.Write("Enter the second edge of the triangle: ");
        // double secondEdge  = double.Parse(Console.ReadLine());        
        
        // Console.Write("Enter the third edge of the triangle: ");
        // double thirdEdge  = double.Parse(Console.ReadLine()); 

        // if((firstEdge + secondEdge > thirdEdge) || (firstEdge + thirdEdge > secondEdge) || (secondEdge + thirdEdge > firstEdge))
        // {
        //         Console.WriteLine($"The perimeter of the triangle is {firstEdge + secondEdge + thirdEdge}");
        // }
        // else
        // {
        //     Console.WriteLine("The input is invalid!!!");
        // }      




// 8. Write a C# program to print multiple of 7 from 1 to 1000. Prints one number per line.


    //    for(int i = 1; i <= 1000; i++)
    //    {
    //         if(i % 7 == 0)
    //         {
    //             Console.WriteLine(i);
    //         }

    //    }



// 9. Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying 
// and dividing of two numbers which will be entered by the user. Create a method for each 
// operation.


//       Console.Write("Enter the first number: ");
//       double firstNum = Convert.ToInt32(Console.ReadLine());
     
//       Console.Write("Enter the second number: ");
//       double secondNum = Convert.ToInt32(Console.ReadLine());

//       Console.WriteLine(FindAddition(firstNum, secondNum));
//       Console.WriteLine(FindSubtraction(firstNum, secondNum));
//       Console.WriteLine(FindMultiplication(firstNum, secondNum));
//       Console.WriteLine(FindDivision(firstNum, secondNum));







// 10. (Convert Celsius to Fahrenheit) Write a program that reads a Celsius degree in a
// double value from the console, then converts it to Fahrenheit and displays the
// result. The formula for the conversion is as follows:
// fahrenheit = (9 / 5) * celsius + 32


            //   Console.Write("Enter a temperature in Celcius degree: ");
            //   double tempInCelcius  = double.Parse(Console.ReadLine());

            //   double fahrenheit = (9.0 / 5.0) * tempInCelcius + 32;

            //   Console.WriteLine($"The temperature in fahrenheit is {fahrenheit}");
           





// 11. (Compute the volume of a cylinder) Write a program that reads in the radius and
// length of a cylinder and computes the area and volume using the following formulas:
// area = radius * radius pie
// volume = area * length


            //   Console.Write("Enter the radius of the cylinder: ");
            //   double radius  = double.Parse(Console.ReadLine());
             
            //   Console.Write("Enter the length of a cylinder: ");
            //   double length  = double.Parse(Console.ReadLine());

            //   double area = radius * radius * Math.PI;

            //   double volume = area * length;

            //   Console.WriteLine($"The area of the cylinder is {area}");
            //   Console.WriteLine($"The volume of the cylinder is {volume}");







// 12.(Convert feet into meters) Write a program that reads a number in feet, converts it
// to meters, and displays the result. One foot is 0.305 meter


        // Console.Write("Enter a number in feet: ");
        // double numberInFeet  = double.Parse(Console.ReadLine());

        // double numberInMeter = numberInFeet * 0.305;
        // Console.WriteLine($"The number in meters is {numberInMeter}  ");







// 13. Write a program that converts pounds into kilograms.
// The program prompts the user to enter a number in pounds, converts it to
// kilograms, and displays the result. One pound is 0.454 kilograms.


        // Console.Write("Enter a number in pounds: ");
        // double numberInPounds  = double.Parse(Console.ReadLine());

        // double numberInKilogram = numberInPounds * 0.454;
        // Console.WriteLine($"The number in kilogram is {numberInKilogram} ");







// 14.Write a program that reads the subtotal and
// the gratuity rate, then computes the gratuity and total. For example, if the user
// enters 10 for subtotal and 15% for gratuity rate, the program displays $1.5 as gratuity
// and $11.5 as total.


        // Console.Write("Enter the subtotal: ");
        // decimal subtotal = decimal.Parse(Console.ReadLine());
        
        // Console.Write("Enter the gratuity rate: ");
        // decimal gratuityRate = decimal.Parse(Console.ReadLine());

        // decimal gratuity = (gratuityRate / 100m) * subtotal;
        // Console.WriteLine($" Gratuity = ${gratuity}");
        // Console.WriteLine($"Total = ${subtotal + gratuity}");


 

// 15.(Sum the digits in an integer) Write a program that reads an integer between 0 and
// 1000 and adds all the digits in the integer. For example, if an integer is 932, the
// sum of all its digits is 14.
// Hint: Use the % operator to extract digits, and use the / operator to remove the
// extracted digit. For instance, 932 % 10 = 2 and 932 / 10 = 93.


        // Console.Write("Enter a number: ");
        // int num = int.Parse(Console.ReadLine());
        // long sum = 0;
        // for(int i = 1; i < num; i++)
        // {
        //     sum += num % 10;
        //     num = num / 10;
        // }
        // Console.WriteLine($"The sum of the digits is {sum}");






// 16. (Find the number of years) Write a program that prompts the user to enter the
// minutes (e.g., 1 billion), and displays the number of years and days for the
// minutes. For simplicity, assume a year has 365 days.

        //   Console.Write("Enter the minutes: ");
        //   double numberOfMinutes = double.Parse(Console.ReadLine());
        //   //use BigInteger, 1yr = 525,600 mins
        //   double numberInDays = numberOfMinutes / 60 / 24;
        //   Console.Write($"The corresponding number of years and days is: {Math.Floor((numberInDays) / 365)}yrs ");
        //   Console.Write($"{Math.Round(numberInDays % 365)}days"); //to the nearest days






// 17. (Physics: acceleration) Average acceleration is defined as the change of velocity
// divided by the time taken to make the change, as shown in the following formula:
// Write a program that prompts the user to enter the starting velocity in
// meters/second, the ending velocity in meters/second, and the time span t in
// seconds, and displays the average acceleration.


        // Console.Write("Enter the starting velocity: ");
        // double startingVelocity = double.Parse(Console.ReadLine());
        //  Console.Write("Enter the ending velocity: ");
        // double endingVelocity = double.Parse(Console.ReadLine());
       
        // Console.Write("Enter the time: ");
        // double time = double.Parse(Console.ReadLine());

        // double averageAcceleration = (endingVelocity - startingVelocity) / time;

        // Console.WriteLine($"The average acceleration is {averageAcceleration}");





// 18. (Science: calculating energy) Write a program that calculates the energy needed to
// heat water from an initial temperature to a final temperature. Your program should
// prompt the user to enter the amount of water in kilograms and the initial and final
// temperatures of the water. The formula to compute the energy is
// Q = M * (finalTemperature – initialTemperature) * 4184
// where M is the weight of water in kilograms, temperatures are in degrees Celsius,
// and energy Q is measured in joules.



        // Console.Write("Enter the amount of water in Kilograms: ");
        // double amountOfWaterM = double.Parse(Console.ReadLine());
        
        // Console.Write("Enter the initial temperature of water in degrees Celsius: ");
        // double initialTemp = double.Parse(Console.ReadLine());
        
        // Console.Write("Enter the final temperature of water in degrees Celsius: ");
        // double finalTemp = double.Parse(Console.ReadLine());

        // double energyInJoules = amountOfWaterM * (finalTemp - initialTemp) * 4184.00;
        // Console.WriteLine($"The energy needed in Joules is {energyInJoules}");



// 19. Write a program that shows the sign (+ or -) of the product of three real 
// numbers, without calculating it. Use a sequence of if operators.


    // int[] numbers = new int[3]; //{-3, 2, -4};
    // int negativeCount = 0;
    // foreach(var number in numbers)
    // {
    //    if(number < 0)
    //     {
    //         negativeCount++;
    //     }
    // }

    
    // if(negativeCount % 2 == 0)
    // {
    //     Console.WriteLine("The product is +");
    // }
    // else
    // {
    //     Console.WriteLine("The product is -");
    // }


        //  num1 = -4, num2 = 5, num3 = -8;
            //  if((num1 < 0) && (num2 > 0) && (num3 < 0))
            // {
            //   Consointle.WriteLine("Positive");
            // }
            // if((num1 < 0) && (num2 < 0) && (num3 > 0))
            // {
            //   Console.WriteLine("Positive");
            // }
            // if((num1 < 0) && (num2 > 0) && (num3 > 0))
            // {
            //   Console.WriteLine("Negative");
            // }
            // if((num1 < 0) && (num2 < 0) && (num3 < 0))
            // {
            //   Console.WriteLine("Negative");
            // }
            // if((num1 > 0) && (num2 > 0) && (num3 > 0))
            // {
            //   Console.WriteLine("Positive");
            // }
            // if((num1 > 0) && (num2 < 0) && (num3 < 0))
            // {
            //   Console.WriteLine("Positive");
            // }
            // if((num1 > 0) && (num2 < 0) && (num3 > 0))
            // {
            //   Console.WriteLine("Negative");
            // }



          // 20. Write a program that finds the smallest of three integers, using if statements.
        
         //  Write a program that finds the biggest of three integers, using nested if statements.

        //     Console.Write("Enter the first number: "); 
        //     int num1 = int.Parse(Console.ReadLine());          
        //     Console.Write("Enter the second number: "); 
        //     int num2 = int.Parse(Console.ReadLine());          
        //     Console.Write("Enter the third number: "); 
        //     int num3 = int.Parse(Console.ReadLine()); 
        //     if(num1 > num2)
        //     {
        //         if(num1 > num3)
        //         {
        //           Console.WriteLine($" {num1} is the biggest");
        //         }
        //         else if(num1 < num3)
        //         {
        //           Console.WriteLine($" {num3} is the biggest");
        //         }
        //         else
        //         {
        //           Console.WriteLine($" {num1} is equal to {num3}");
        //         }
        //     }
        //     if(num1 < num2)
        //     {
        //         if(num2 > num3)
        //         {
        //           Console.WriteLine($" {num2} is the biggest ");
        //         }
        //         else if(num2 < num3)
        //         {
        //           Console.WriteLine($"{num3} is the biggest");
        //         }
        //         else
        //         {
        //           Console.WriteLine($"{num2} is equal to {num3}");
        //         }
        //     }
        //     if(num1 == num2)
        //     {
        //         if(num1 > num3)
        //         {
        //           Console.WriteLine($"{num1} is equal to {num2} and is the biggest");
        //         }
        //         else if(num1 < num3)
        //         {
        //           Console.WriteLine($"{num3} is the biggest");
        //         }
        //         else
        //         {
        //           Console.WriteLine($"{num1}, {num2} and {num3} are all equal");
        //         }
        //     }         
                   



// 21. Write a program that asks for a digit (0-9), and depending on the input, 
// shows the digit as a word (in English). 


            // Console.Write("Input a digit (0 - 9): ");
            // int digit = int.Parse(Console.ReadLine());
            // switch(digit)
            // {
            //     case 0:
            //     Console.WriteLine("Zero");
            //     break;
            //     case 1:
            //     Console.WriteLine("One");
            //     break;
            //     case 2:
            //     Console.WriteLine("Two");
            //     break;
            //     case 3:
            //     Console.WriteLine("Three");
            //     break;
            //     case 4:
            //     Console.WriteLine("Four");
            //     break;
            //     case 5:
            //     Console.WriteLine("Five");
            //     break;
            //     case 6:
            //     Console.WriteLine("Six");
            //     break;
            //     case 7:
            //     Console.WriteLine("Seven");
            //     break;
            //     case 8:
            //     Console.WriteLine("Eight");
            //     break;
            //     case 9:
            //     Console.WriteLine("Nine");
            //     break;
            //     default:
            //     Console.WriteLine("Invalid input!!!");
            //     break;
            // }





// 22. Write a program that applies bonus points to given scores in the range 
// [1…9] by the following rules:
// - If the score is between 1 and 3, the program multiplies it by 10.
// - If the score is between 4 and 6, the program multiplies it by 100.
// - If the score is between 7 and 9, the program multiplies it by 1000.
// - If the score is 0 or more than 9, the program prints an error 
// message.


        // Console.Write("Input a score (1 - 9): ");
        // int score = int.Parse(Console.ReadLine());
        // if(score > 1 && score < 3)
        // {
        //     Console.WriteLine($"Your bonus is {score * 10} ");
        // }
        // else if(score > 4 && score < 6)
        // {
        //     Console.WriteLine($"Your bonus is {score * 100} ");
        // }
        // else if(score > 7 && score < 9)
        // {
        //     Console.WriteLine($"Your bonus is {score * 1000} ");
        // }
        // else
        // {
        //     Console.WriteLine("Sorry, you dont have bonus!!!");
        // }
           




// 23. Write a program that takes as input a four-digit number in format abcd
// (e.g. 2011) and performs the following actions:
// - Calculates the sum of the digits (in our example 2+0+1+1 = 4).
// - Prints on the console the number in reversed order: dcba (in our example 1102).
// - Puts the last digit in the first position: dabc (in our example 1201).
// - Exchanges the second and the third digits: acbd (in our example 
// 2101)

        
//         Console.Write("Input a four-digit number: ");
//         int fourDigitNum = Convert.ToInt32(Console.ReadLine());
       
//         int a = (fourDigitNum /1000) % 10;
//         int b = (fourDigitNum / 100) % 10;
//         int c = (fourDigitNum / 10) % 10;
//         int d = fourDigitNum % 10;

//         Console.WriteLine("First-digit = {0}, Second-digit = {1}, Third-digit = {2} and Forth-digit = {3}", a, b, c, d);
//         Console.WriteLine($"Sum of the digits is {a + b + c + d} ");
//         Console.WriteLine($"{fourDigitNum} in reverse order is {d}{c}{b}{a}");
//         Console.WriteLine($"The last digit in second position is {d}{a}{b}{c} ");
//         Console.WriteLine($"Exchange of the second and the third digits {a}{c}{b}{d} ");

//        // OR
       
//         string num = fourDigitNum.ToString();
//         int sum = 0;
//         for(int i = 0; i < num.Length; i++)
//         {
//                 sum += fourDigitNum % 10;
//                 fourDigitNum = fourDigitNum / 10;
//         }
//         Console.WriteLine($"Sum of the digits of {num} is {sum} ");
        
       
//         Console.WriteLine($"{num} in reverse order is");
//         for(int i = num.Length - 1; i >= 0; i--)
//         {
//                Console.Write(num[i] + " "); 
//         }






// 24.Write a program that prints on the console the numbers from 1 to N. 
// The number N should be read from the standard input.

        // Console.Write("Enter a number: ");
        // int N = int.Parse(Console.ReadLine());
        // for(int i = 1; i <= N; i++)
        // {
        //     Console.Write(i + " ");
        // }





// 25.Write a program that prints on the console multiples of 5 less than
// 1000 (i.e 5,10, 15......995)


       
        // for(int i = 5; i < 1000; i++)
        // {
        //     if(i % 5 == 0)
        //     {
        //         Console.Write(i + ",");
        //     }
        // }        



// 26.Write a program that prints out the sequence -10, -4, 2, 8, 14, 20.

        // for(int i = -10; i <= 20; i += 6)
        // {
        //     Console.Write(i + " ,");
        // }        





// 27.Write a program that prints out the sequence 49, 40, 31, 22, 13, 4.


        // for(int i = 49; i >= 4; i -= 9)
        // {
        //     Console.Write(i + " ,");
        // }        




// 28.Write a program that prints out the cube of all numbers between 1 and 10.


        // for(int i = 2; i < 10; i++)
        // {
        //     Console.Write(Math.Pow(i, 3) + " ,");
        // }        




// 29.Write a program that prints on the console the numbers from 1 to 50, 
// which are not divisible by 3 and 7 simultaneously.


        // for(int i = 1; i <= 50; i++)
        // {
        //     if(i % 21 != 0)
        //     Console.Write(i + ",");
        // }        






// 30.Write a C# program to check two given integers and return true if one is negative and one is positive


        // Console.Write("Enter the first numbner: ");
        // int firstNum = int.Parse(Console.ReadLine());
       
        // Console.Write("Enter the second numbner: ");
        // int secondNum = int.Parse(Console.ReadLine());

        // if((firstNum > 0 && secondNum < 0) || (firstNum < 0 && secondNum > 0))
        // {
        //     Console.WriteLine(true);
        // }
        // else
        // {
        //     Console.WriteLine(false);
        // }

            
            
            
            
           
        }

       
         static double FindAddition(double firstNum, double secondNum)
       {
                Console.Write($"{firstNum} + {secondNum} =  ");
                return firstNum + secondNum;
       }
      
      
       static double FindSubtraction(double firstNum, double secondNum)
       {
               Console.Write($"{firstNum} - {secondNum} =  ");
                return firstNum - secondNum;
       }
       
      
       static double FindMultiplication(double firstNum, double secondNum)
       {
               Console.Write($"{firstNum} * {secondNum} =  ");
                return firstNum * secondNum;
       }
       
       
       static double FindDivision(double firstNum, double secondNum)
       {
                Console.Write($"{firstNum} / {secondNum} =  ");
                return firstNum / secondNum;
       }




    }
}
