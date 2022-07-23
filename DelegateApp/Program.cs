// See https://aka.ms/new-console-template for more information
using static DelegateApp.DelegateClass;

//Instanting a delegate
Calculate calculator;
Calculate addCalculator = new Calculate(AddNumbers);
Calculate substractCalculator = new Calculate(Substract);
Calculate multiplyCalculator = new Calculate(Multiply);
Calculate divideCalculator = new Calculate(Divide);

//Calling the delegate instances at a time
addCalculator(10, 5); // 15
substractCalculator(10, 5); //5
multiplyCalculator(10, 5); //50
divideCalculator(10, 5); //2

//multicasting
//Calling the delagate method all at once
calculator = addCalculator; // add two variables
calculator += substractCalculator; // substract two variables
calculator += multiplyCalculator;
calculator += divideCalculator;
calculator(10, 5); // 15 5 50 2

