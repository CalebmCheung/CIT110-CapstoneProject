using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProjectCIT110
{
    class Program
    {
        public enum Account
        {
            SAVINGS,
            CHECKING,
            RETIREMENTFUND,

        }
        
        
        //************************************************
        // App: Bank Account Tracker
        // Author: Cheung , Caleb
        // Date: 4/22/2019
        //*************************************************;
        
        static void Main(string[] args)
        {
            //Variables
            double savingsBalance;
            double checkingBalance;
            double retirementFund;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;

            DisplayWelcomeScreen();

            savingsBalance = DisplayGetSavings();
            checkingBalance = DisplayGetCheckings();
            retirementFund = DisplayGetRetirementFund();

            DisplayMenu(savingsBalance, checkingBalance, retirementFund);

            DisplayClosingScreen();
        }

        static double DisplayGetRetirementFund()
        {
            double retirementInitalBalance = 0;
            bool validEntry;
            string userResponse;
            validEntry = false;
            DisplayHeader("Retirement Account Information");

            while (!validEntry)
            {
                Console.Write("Please enter you Retirement Account balance: ");
                userResponse = Console.ReadLine();

                if (!double.TryParse(userResponse, out retirementInitalBalance))
                {
                    Console.WriteLine("Please enter a numerical balance");
                }
                else if (retirementInitalBalance < 0)
                {
                    Console.WriteLine("Please enter a balance 0 or greater");
                }
                else
                {
                    Console.WriteLine($"Your Retirement Account contians ${retirementInitalBalance}");
                    Console.WriteLine();
                    validEntry = true;
                    DisplayContinuePrompt();
                }
            }

            return retirementInitalBalance;
        }
    
        static void DisplayMenu(double savingsBalance,double checkingBalance,double retirementFund)
        {
            //variables
            bool exiting = false;
            string menuChoice;

            while (!exiting)
            {
                DisplayHeader("Main Menu");

                //Menu Options
                Console.WriteLine("1) View Account");
                Console.WriteLine("2) Withdraw Money");
                Console.WriteLine("3) Deposit Money");
                Console.WriteLine("4) Calculate Intrest");
                Console.WriteLine("E) Exit");
                Console.WriteLine();
                Console.Write("Enter Menu Choice:");
                menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        DisplayAccountInformation(savingsBalance,checkingBalance, retirementFund);
                        break;

                    case "2":
                        savingsBalance = DisplayWithdrawSavings(savingsBalance);
                        checkingBalance = DisplayWithdrawCheckings(checkingBalance);
                        retirementFund = DisplayWithdrawRetirementFund(retirementFund);
                        break;

                    case "3":
                        savingsBalance = DisplayDepositeSavings(savingsBalance);
                        checkingBalance = DisplayDepositeCheckings(checkingBalance);
                        retirementFund = DisplayDepositeRetirement(retirementFund);
                        break;

                    case "4":
                        DisplayCalculateIntrest(savingsBalance, checkingBalance, retirementFund);
                        break;

                    case "e":
                    case "E":
                        exiting = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Please Enter a Proper Menu Choice");
                        DisplayContinuePrompt();
                        break;
                }
            }

        }

        static double DisplayDepositeRetirement(double retirementFund)
        {
            Console.Clear();
            //variables
            double newRetirementFund;
            double deposite = 0;
            bool validEntry;
            string userResponse;

            validEntry = false;

            DisplayHeader("Retirement Fund Information");
            Console.WriteLine();
            Console.WriteLine($"Retirement Fund: ${retirementFund}");

            //Ask User and Validate
            while (!validEntry)
            {
                Console.WriteLine();
                Console.Write("Please enter the amount you would like to Deposite: ");
                userResponse = Console.ReadLine();

                if (!double.TryParse(userResponse, out deposite))
                {
                    Console.WriteLine("Please enter a numerical balance");
                }
                else if (deposite < 0)
                {
                    Console.WriteLine("Please enter an amount 0 or greater");
                }
                else
                {
                    Console.WriteLine($"${deposite} has been added to your Retirement Fund");
                    Console.WriteLine();
                    validEntry = true;
                    DisplayContinuePrompt();
                }
            }

            newRetirementFund = retirementFund + deposite;

            return newRetirementFund;
        }

        static double DisplayDepositeCheckings(double checkingBalance)
        {
            Console.Clear();
            //variables
            double newCheckingBalance;
            double deposite = 0;
            bool validEntry;
            string userResponse;

            validEntry = false;

            DisplayHeader("Checking Account Information");
            Console.WriteLine();
            Console.WriteLine($"Checking Balance: ${checkingBalance}");

            //Ask User and Validate
            while (!validEntry)
            {
                Console.WriteLine();
                Console.Write("Please enter the amount you would like to Deposite: ");
                userResponse = Console.ReadLine();

                if (!double.TryParse(userResponse, out deposite))
                {
                    Console.WriteLine("Please enter a numerical balance");
                }
                else if (deposite < 0)
                {
                    Console.WriteLine("Please enter an amount 0 or greater");
                }
                else
                {
                    Console.WriteLine($"${deposite} has been added to your Checking Account");
                    Console.WriteLine();
                    validEntry = true;
                    DisplayContinuePrompt();
                }
            }

            newCheckingBalance = checkingBalance + deposite;

            return newCheckingBalance;
        }

        static double DisplayDepositeSavings(double savingsBalance)
        {
            Console.Clear();
            //variables
            double newSavingsBalance;
            double deposite = 0;
            bool validEntry;
            string userResponse;

            validEntry = false;

            DisplayHeader("Saving Account Information");
            Console.WriteLine();
            Console.WriteLine($"Savings Balance: ${savingsBalance}");

            //Ask User and Validate
            while (!validEntry)
            {
                Console.WriteLine();
                Console.Write("Please enter the amount you would like to Deposite: ");
                userResponse = Console.ReadLine();

                if (!double.TryParse(userResponse, out deposite))
                {
                    Console.WriteLine("Please enter a numerical balance");
                }
                else if (deposite < 0)
                {
                    Console.WriteLine("Please enter an amount 0 or greater");
                }
                else
                {
                    Console.WriteLine($"${deposite} has been added to your Savings Account");
                    Console.WriteLine();
                    validEntry = true;
                    DisplayContinuePrompt();
                }
            }

            newSavingsBalance = savingsBalance + deposite;

            return newSavingsBalance;
        }

        static double DisplayWithdrawRetirementFund(double retirementFund)
        {
            Console.Clear();
            //variables
            double newRetirementFund;
            double withdraw = 0;
            bool validEntry;
            string userResponse;

            validEntry = false;

            DisplayHeader("Retirement Fund Information");
            Console.WriteLine();
            Console.WriteLine($"Retirement Fund: ${retirementFund}");

            //Ask User and Validate
            while (!validEntry)
            {
                Console.WriteLine();
                Console.Write("Please enter the amount you would like to withdraw: ");
                userResponse = Console.ReadLine();

                if (!double.TryParse(userResponse, out withdraw))
                {
                    Console.WriteLine("Please enter a numerical balance");
                }
                else if (withdraw < 0)
                {
                    Console.WriteLine("Please enter an amount 0 or greater");
                }
                else if (withdraw > retirementFund)
                {
                    Console.WriteLine("You can not over draw you account");
                }
                else
                {
                    Console.WriteLine($"${withdraw} has been deducted from your Retirement Fund");
                    Console.WriteLine();
                    validEntry = true;
                    DisplayContinuePrompt();
                }
            }

            newRetirementFund = retirementFund - withdraw;

            return newRetirementFund;
        }

        static double DisplayWithdrawCheckings(double checkingBalance)
        {
            Console.Clear();
            //variables
            double newCheckingBalance;
            double withdraw = 0;
            bool validEntry;
            string userResponse;

            validEntry = false;

            DisplayHeader("Checking Account Information");
            Console.WriteLine();
            Console.WriteLine($"Checking Balance: ${checkingBalance}");

            //Ask User and Validate
            while (!validEntry)
            {
                Console.WriteLine();
                Console.Write("Please enter the amount you would like to withdraw: ");
                userResponse = Console.ReadLine();

                if (!double.TryParse(userResponse, out withdraw))
                {
                    Console.WriteLine("Please enter a numerical balance");
                }
                else if (withdraw < 0)
                {
                    Console.WriteLine("Please enter an amount 0 or greater");
                }
                else if (withdraw > checkingBalance)
                {
                    Console.WriteLine("You can not over draw you account");
                }
                else
                {
                    Console.WriteLine($"${withdraw} has been deducted from your Checking Account");
                    Console.WriteLine();
                    validEntry = true;
                    DisplayContinuePrompt();
                }
            }

            newCheckingBalance = checkingBalance - withdraw;

            return newCheckingBalance;
        }

        static void DisplayCalculateIntrest(double savingsBalance, double checkingBalance, double retirementFund)
        {
            //variables
            bool exiting = false;
            string menuChoice;

            while (!exiting)
            {
                DisplayHeader("Calculate Interest");

                //Menu Options
                Console.WriteLine("1) Savings");
                Console.WriteLine("2) Checking");
                Console.WriteLine("3) Retirement");
                Console.WriteLine("E) back");
                Console.WriteLine();
                Console.Write("Enter Menu Choice:");
                menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        DisplaySavingsInterest(savingsBalance);
                        break;

                    case "2":
                        DisplayCheckingInterest(checkingBalance);
                        break;

                    case "3":
                        DisplayRetirementInterest(retirementFund);
                        break;

                    case "e":
                    case "E":
                        exiting = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Please Enter a Proper Menu Choice");
                        DisplayContinuePrompt();
                        break;
                }
            }
        }

        static void DisplayRetirementInterest(double retirementFund)
        {
            Console.Clear();
            //Varaibles
            double interestRate = 0;
            double balanceAfterInterest = 0;
            double appliedPercentage = 0;
            double numberOfYears = 0;
            bool validEntryRate;
            bool validEntryYears;

            validEntryRate = false;
            validEntryYears = false;

            DisplayHeader("Calculate Interest");
            Console.WriteLine();
            Console.WriteLine($"Retirement Fund: ${retirementFund}");

            //Ask user for rate and validate
            while (!validEntryRate)
            {
                Console.WriteLine();
                Console.Write("Please enter the Interest Rate as a decimal number: ");

                if (!double.TryParse(Console.ReadLine(), out interestRate))
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a numerical rate");
                }
                else if (interestRate < 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a number above 0");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Interest Rate:{interestRate}");
                    validEntryRate = true;
                }
            }

            while (!validEntryYears)
            {
                Console.WriteLine();
                Console.Write("Please enter the number of years this rate will apply: ");

                if (!double.TryParse(Console.ReadLine(), out numberOfYears))
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter the amount of years");
                }
                else if (numberOfYears < 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a number above 0");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Number of years:{numberOfYears}");
                    validEntryYears = true;
                }
            }

            balanceAfterInterest = retirementFund;

            for (int index = 0; index < numberOfYears; index++)
            {
                appliedPercentage = balanceAfterInterest * interestRate;
                balanceAfterInterest = balanceAfterInterest + appliedPercentage;
            }

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($"After {numberOfYears} years at a rate of {interestRate}% your Retirement Fund will have ${balanceAfterInterest}");
            Console.WriteLine($"[Gained:${balanceAfterInterest - retirementFund}]");

            DisplayContinuePrompt();
        }

        static void DisplayCheckingInterest(double checkingBalance)
        {
            Console.Clear();
            //Varaibles
            double interestRate = 0;
            double balanceAfterInterest = 0;
            double appliedPercentage = 0;
            double numberOfYears = 0;
            bool validEntryRate;
            bool validEntryYears;

            validEntryRate = false;
            validEntryYears = false;

            DisplayHeader("Calculate Interest");
            Console.WriteLine();
            Console.WriteLine($"Checking Balance: ${checkingBalance}");

            //Ask user for rate and validate
            while (!validEntryRate)
            {
                Console.WriteLine();
                Console.Write("Please enter the Interest Rate as a decimal number: ");

                if (!double.TryParse(Console.ReadLine(), out interestRate))
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a numerical rate");
                }
                else if (interestRate < 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a number above 0");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Interest Rate:{interestRate}");
                    validEntryRate = true;
                }
            }

            while (!validEntryYears)
            {
                Console.WriteLine();
                Console.Write("Please enter the number of years this rate will apply: ");

                if (!double.TryParse(Console.ReadLine(), out numberOfYears))
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter the amount of years");
                }
                else if (numberOfYears < 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a number above 0");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Number of years:{numberOfYears}");
                    validEntryYears = true;
                }
            }

            balanceAfterInterest = checkingBalance;

            for (int index = 0; index < numberOfYears; index++)
            {
                appliedPercentage = balanceAfterInterest * interestRate;
                balanceAfterInterest = balanceAfterInterest + appliedPercentage;
            }

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($"After {numberOfYears} years at a rate of {interestRate}% your Checking balance will be ${balanceAfterInterest}");
            Console.WriteLine($"[Gained:${balanceAfterInterest - checkingBalance}]");

            DisplayContinuePrompt();
        }

        static void DisplaySavingsInterest(double savingsBalance)
        {
            Console.Clear();
            //Varaibles
            double interestRate = 0;
            double balanceAfterInterest = 0;
            double appliedPercentage = 0;
            double numberOfYears = 0;
            bool validEntryRate;
            bool validEntryYears;

            validEntryRate = false;
            validEntryYears = false;

            DisplayHeader("Calculate Interest");
            Console.WriteLine();
            Console.WriteLine($"Savings Balance: ${savingsBalance}");

            //Ask user for rate and validate
            while (!validEntryRate)
            {
                Console.WriteLine();
                Console.Write("Please enter the Interest Rate as a decimal number: ");

                if (!double.TryParse(Console.ReadLine(),out interestRate))
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a numerical rate");
                }
                else if (interestRate < 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a number above 0");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Interest Rate:{interestRate}");
                    validEntryRate = true;
                }
            }

            while (!validEntryYears)
            {
                Console.WriteLine();
                Console.Write("Please enter the number of years this rate will apply: ");

                if (!double.TryParse(Console.ReadLine(), out numberOfYears))
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter the amount of years");
                }
                else if (numberOfYears < 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a number above 0");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Number of years:{numberOfYears}");
                    validEntryYears = true;
                }
            }

            balanceAfterInterest = savingsBalance;

            for (int index = 0; index < numberOfYears; index++)
            {
                appliedPercentage = balanceAfterInterest * interestRate;
                balanceAfterInterest = balanceAfterInterest + appliedPercentage;
            }

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($"After {numberOfYears} years at a rate of {interestRate}% your Savings balance will be ${balanceAfterInterest}");
            Console.WriteLine($"[Gained:${balanceAfterInterest - savingsBalance}]");

            DisplayContinuePrompt();

        }

        static double DisplayWithdrawSavings(double savingsBalance)
        {
            Console.Clear();
            //variables
            double newSavingsBalance;
            double withdraw = 0;
            bool validEntry;
            string userResponse;

            validEntry = false;

            DisplayHeader("Saving Account Information");
            Console.WriteLine();
            Console.WriteLine($"Savings Balance: ${savingsBalance}");

            //Ask User and Validate
            while (!validEntry)
            {
                Console.WriteLine();
                Console.Write("Please enter the amount you would like to withdraw: ");
                userResponse = Console.ReadLine();

                if (!double.TryParse(userResponse, out withdraw))
                {
                    Console.WriteLine("Please enter a numerical balance");
                }
                else if (withdraw < 0)
                {
                    Console.WriteLine("Please enter an amount 0 or greater");
                }
                else if (withdraw > savingsBalance)
                {
                    Console.WriteLine("You can not over draw you account");
                }
                else
                {
                    Console.WriteLine($"${withdraw} has been deducted from your Savings Account");
                    Console.WriteLine();
                    validEntry = true;
                    DisplayContinuePrompt();
                }
            }

            newSavingsBalance = savingsBalance - withdraw;

            return newSavingsBalance;
        }

        static void DisplayAccountInformation(double savingsBalance, double checkingBalance, double retirementFund)
        {
            Console.Clear();
            //variables
            bool exiting = false;
            string menuChoice;

            while (!exiting)
            {
                DisplayHeader("Accounts");

                //Menu Options
                Console.WriteLine("1) Savings");
                Console.WriteLine("2) Checking");
                Console.WriteLine("3) Retirement");
                Console.WriteLine("4) All");
                Console.WriteLine("E) <Back");
                Console.WriteLine();
                Console.Write("Select Account:");
                menuChoice = Console.ReadLine();
                Console.WriteLine();

                switch (menuChoice)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine($"Savings Balance: ${savingsBalance}");
                        DisplayContinuePrompt();                     
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine($"Checking Balance: ${checkingBalance}");
                        DisplayContinuePrompt();
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine($"Retirement Balance: ${retirementFund}");
                        DisplayContinuePrompt();
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine($"Savings Balance: ${savingsBalance}");
                        Console.WriteLine();
                        Console.WriteLine($"Checking Balance: ${checkingBalance}");
                        Console.WriteLine();
                        Console.WriteLine($"Retirement Balance: ${retirementFund}");
                        DisplayContinuePrompt();
                        break;

                    case "e":
                    case "E":
                        exiting = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Please Enter a Proper Menu Choice");
                        DisplayContinuePrompt();
                        break;
                }
            }
        }

        static void DisplayHeader(string headerText)
        {
            // Display Header
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t" + headerText);
            Console.WriteLine();

        }

        static void DisplayWelcomeScreen()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\tWelcome to your personal Bank Account Tracker.");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        static double DisplayGetSavings()
        {
            //Variables
            double savingsInitalBalance = 0;
            bool validEntry;
            string userResponse;

            validEntry = false;

            DisplayHeader("Saving Account Information");
            
            while (!validEntry)
            {
                Console.Write("Please enter you Savings Account balance: ");
                userResponse = Console.ReadLine();

                if (!double.TryParse(userResponse, out savingsInitalBalance))
                {
                    Console.WriteLine("Please enter a numerical balance");
                }
                else if (savingsInitalBalance < 0)
                {
                    Console.WriteLine("Please enter a balance 0 or greater");
                }
                else
                {
                    Console.WriteLine($"Your Savings Account contians ${savingsInitalBalance}");
                    Console.WriteLine();
                    validEntry = true;
                    DisplayContinuePrompt();
                }
            }

            return savingsInitalBalance;
        }

        static double DisplayGetCheckings()
        {
            double checkingsInitalBalance = 0;
            bool validEntry;
            string userResponse;
            validEntry = false;
            DisplayHeader("Checking Account Information");

            while (!validEntry)
            {
                Console.Write("Please enter you Checking Account balance: ");
                userResponse = Console.ReadLine();

                if (!double.TryParse(userResponse, out checkingsInitalBalance))
                {
                    Console.WriteLine("Please enter a numerical balance");
                }
                else if (checkingsInitalBalance < 0)
                {
                    Console.WriteLine("Please enter a balance 0 or greater");
                }
                else
                {
                    Console.WriteLine($"Your Checking Account contians ${checkingsInitalBalance}");
                    Console.WriteLine();
                    validEntry = true;
                    DisplayContinuePrompt();
                }
            }

            return checkingsInitalBalance;
        }

        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\tPress any key to continue.");
            Console.ReadKey();
        }

        static void DisplayClosingScreen()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\tThank you for using The Bank Account Tracker");
            Console.WriteLine();

            DisplayContinuePrompt();
        }
    }
}
