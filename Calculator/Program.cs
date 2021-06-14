using System;

namespace Menu
{
    public class Program
    {
		public static void Main(string[] args)
		{
			//start
			Console.Clear();
			Console.Title = "Calculator";
			bool end = false;
			
			while(end == false)
			{
				//variable
				double num1 = 0,num2 = 0,ans = 0;
				string[] opt = {
					"<Add>",
					" Subtract",
					" Multiply",
					" Divide"
				};
				string[] endopt = {
					"<Continue>",
					" Exit"
				};
				int index = 1,redo = 0,endindex = 1,endo = 0;
				ConsoleKeyInfo menu;
				ConsoleKeyInfo endmenu;
				
				Console.Clear();
				//input1
				Console.BackgroundColor = ConsoleColor.White;
				Console.ForegroundColor = ConsoleColor.Black;
				Console.WriteLine("      _______    ________  _           _______    _       _  _           ________  _________  ________  _______\n     //_____/   //     // //          //_____/   //      // //          //     // /________/ //_____// //_____/\n    //         //     // //          //         //      // //          //     //     //     //     // //     / \n   //         //-----// //          //         //      // //          //-----//     //     //     // //_____/  \n  //         //-----// //          //         //      // //          //-----//     //     //     // // //      \n //_______  //     // //________  //_______  //______// //________  //     //     //     //_____// //   //     \n//_______/ //     // //________/ //_______/ //______// //________/ //     //     //     //_____// //     //    \n");
				Console.ResetColor();
				Console.BackgroundColor = ConsoleColor.White;
				Console.ForegroundColor = ConsoleColor.Black;
				Console.WriteLine("Welcome To\n");
				Console.ResetColor();
				Console.Write("Enter first number: ");
				num1 = Convert.ToDouble(Console.ReadLine());
				
				//input2
				Console.Write("\nEnter second number: ");
				num2 = Convert.ToDouble(Console.ReadLine());
				
				Console.Clear();
				Console.BackgroundColor = ConsoleColor.White;
				Console.ForegroundColor = ConsoleColor.Black;
				Console.WriteLine("      _______    ________  _           _______    _       _  _           ________  _________  ________  _______\n     //_____/   //     // //          //_____/   //      // //          //     // /________/ //_____// //_____/\n    //         //     // //          //         //      // //          //     //     //     //     // //     / \n   //         //-----// //          //         //      // //          //-----//     //     //     // //_____/  \n  //         //-----// //          //         //      // //          //-----//     //     //     // // //      \n //_______  //     // //________  //_______  //______// //________  //     //     //     //_____// //   //     \n//_______/ //     // //________/ //_______/ //______// //________/ //     //     //     //_____// //     //    \n");
				Console.ResetColor();
				Console.BackgroundColor = ConsoleColor.White;
				Console.ForegroundColor = ConsoleColor.Black;
				Console.WriteLine("Welcome To\n");
				Console.ResetColor();
				Console.Write("Enter first number: ");
				Console.WriteLine(num1);
				Console.Write("\nEnter second number: ");
				Console.WriteLine(num2);
				Console.WriteLine("");
				Console.BackgroundColor = ConsoleColor.Blue;
				Console.ForegroundColor = ConsoleColor.Black;
				Console.WriteLine(opt[0]);
				Console.ResetColor();
				Console.WriteLine(opt[1]);
				Console.WriteLine(opt[2]);
				Console.WriteLine(opt[3]);
				
				//input3 OR menu
				while(redo == 0)
				{
					menu = Console.ReadKey(true);
					if(menu.Key == ConsoleKey.UpArrow)
					{
						index--;
					}else if(menu.Key == ConsoleKey.DownArrow)
					{
						index++;
					}else if(menu.Key == ConsoleKey.Enter)
					{
						redo++;
						if(index == 1)
						{
							ans = num1 + num2;
						}else if(index == 2)
						{
							ans = num1 - num2;
						}else if(index == 3)
						{
							ans = num1 * num2;
						}else if(index == 4)
						{
							while(num2 == 0)
							{
								Console.WriteLine("\nEnter a non zero divisor");
								num2 = Convert.ToDouble(Console.ReadLine());
							}
							ans = num1 / num2;
						}
						
					}
					
					switch(index)
					{
						case 0:
						index = 1;
						Console.Clear();
						opt[0] = "<Add>";
						opt[1] = " Subtract";
						opt[2] = " Multiply";
						opt[3] = " Divide";
						Console.BackgroundColor = ConsoleColor.White;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine("      _______    ________  _           _______    _       _  _           ________  _________  ________  _______\n     //_____/   //     // //          //_____/   //      // //          //     // /________/ //_____// //_____/\n    //         //     // //          //         //      // //          //     //     //     //     // //     / \n   //         //-----// //          //         //      // //          //-----//     //     //     // //_____/  \n  //         //-----// //          //         //      // //          //-----//     //     //     // // //      \n //_______  //     // //________  //_______  //______// //________  //     //     //     //_____// //   //     \n//_______/ //     // //________/ //_______/ //______// //________/ //     //     //     //_____// //     //    \n");
						Console.ResetColor();
						Console.BackgroundColor = ConsoleColor.White;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine("Welcome To\n");
						Console.ResetColor();
						Console.Write("Enter first number: ");
						Console.WriteLine(num1);
						Console.Write("\nEnter second number: ");
						Console.WriteLine(num2);
						Console.WriteLine("");
						Console.BackgroundColor = ConsoleColor.Blue;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine(opt[0]);
						Console.ResetColor();
						Console.WriteLine(opt[1]);
						Console.WriteLine(opt[2]);
						Console.WriteLine(opt[3]);
						break;
						case 1:
						index = 1;
						Console.Clear();
						opt[0] = "<Add>";
						opt[1] = " Subtract";
						opt[2] = " Multiply";
						opt[3] = " Divide";
						Console.BackgroundColor = ConsoleColor.White;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine("      _______    ________  _           _______    _       _  _           ________  _________  ________  _______\n     //_____/   //     // //          //_____/   //      // //          //     // /________/ //_____// //_____/\n    //         //     // //          //         //      // //          //     //     //     //     // //     / \n   //         //-----// //          //         //      // //          //-----//     //     //     // //_____/  \n  //         //-----// //          //         //      // //          //-----//     //     //     // // //      \n //_______  //     // //________  //_______  //______// //________  //     //     //     //_____// //   //     \n//_______/ //     // //________/ //_______/ //______// //________/ //     //     //     //_____// //     //    \n");
						Console.ResetColor();
						Console.BackgroundColor = ConsoleColor.White;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine("Welcome To\n");
						Console.ResetColor();
						Console.Write("Enter first number: ");
						Console.WriteLine(num1);
						Console.Write("\nEnter second number: ");
						Console.WriteLine(num2);
						Console.WriteLine("");
						Console.BackgroundColor = ConsoleColor.Blue;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine(opt[0]);
						Console.ResetColor();
						Console.WriteLine(opt[1]);
						Console.WriteLine(opt[2]);
						Console.WriteLine(opt[3]);
						break;
						case 2:
						index = 2;
						Console.Clear();
						opt[0] = " Add";
						opt[1] = "<Subtract>";
						opt[2] = " Multiply";
						opt[3] = " Divide";
						Console.BackgroundColor = ConsoleColor.White;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine("      _______    ________  _           _______    _       _  _           ________  _________  ________  _______\n     //_____/   //     // //          //_____/   //      // //          //     // /________/ //_____// //_____/\n    //         //     // //          //         //      // //          //     //     //     //     // //     / \n   //         //-----// //          //         //      // //          //-----//     //     //     // //_____/  \n  //         //-----// //          //         //      // //          //-----//     //     //     // // //      \n //_______  //     // //________  //_______  //______// //________  //     //     //     //_____// //   //     \n//_______/ //     // //________/ //_______/ //______// //________/ //     //     //     //_____// //     //    \n");
						Console.ResetColor();
						Console.BackgroundColor = ConsoleColor.White;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine("Welcome To\n");
						Console.ResetColor();
						Console.Write("Enter first number: ");
						Console.WriteLine(num1);
						Console.Write("\nEnter second number: ");
						Console.WriteLine(num2);
						Console.WriteLine("");
						Console.WriteLine(opt[0]);
						Console.BackgroundColor = ConsoleColor.Blue;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine(opt[1]);
						Console.ResetColor();
						Console.WriteLine(opt[2]);
						Console.WriteLine(opt[3]);
						break;
						case 3:
						index = 3;
						Console.Clear();
						opt[0] = " Add ";
						opt[1] = " Subtract";
						opt[2] = "<Multiply>";
						opt[3] = " Divide";
						Console.BackgroundColor = ConsoleColor.White;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine("      _______    ________  _           _______    _       _  _           ________  _________  ________  _______\n     //_____/   //     // //          //_____/   //      // //          //     // /________/ //_____// //_____/\n    //         //     // //          //         //      // //          //     //     //     //     // //     / \n   //         //-----// //          //         //      // //          //-----//     //     //     // //_____/  \n  //         //-----// //          //         //      // //          //-----//     //     //     // // //      \n //_______  //     // //________  //_______  //______// //________  //     //     //     //_____// //   //     \n//_______/ //     // //________/ //_______/ //______// //________/ //     //     //     //_____// //     //    \n");
						Console.ResetColor();
						Console.BackgroundColor = ConsoleColor.White;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine("Welcome To\n");
						Console.ResetColor();
						Console.Write("Enter first number: ");
						Console.WriteLine(num1);
						Console.Write("\nEnter second number: ");
						Console.WriteLine(num2);
						Console.WriteLine("");
						Console.WriteLine(opt[0]);
						Console.WriteLine(opt[1]);
						Console.BackgroundColor = ConsoleColor.Blue;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine(opt[2]);
						Console.ResetColor();
						Console.WriteLine(opt[3]);
						break;
						case 4:
						index = 4;
						Console.Clear();
						opt[0] = " Add";
						opt[1] = " Subtract";
						opt[2] = " Multiply";
						opt[3] = "<Divide>";
						Console.BackgroundColor = ConsoleColor.White;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine("      _______    ________  _           _______    _       _  _           ________  _________  ________  _______\n     //_____/   //     // //          //_____/   //      // //          //     // /________/ //_____// //_____/\n    //         //     // //          //         //      // //          //     //     //     //     // //     / \n   //         //-----// //          //         //      // //          //-----//     //     //     // //_____/  \n  //         //-----// //          //         //      // //          //-----//     //     //     // // //      \n //_______  //     // //________  //_______  //______// //________  //     //     //     //_____// //   //     \n//_______/ //     // //________/ //_______/ //______// //________/ //     //     //     //_____// //     //    \n");
						Console.ResetColor();
						Console.BackgroundColor = ConsoleColor.White;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine("Welcome To\n");
						Console.ResetColor();
						Console.Write("Enter first number: ");
						Console.WriteLine(num1);
						Console.Write("\nEnter second number: ");
						Console.WriteLine(num2);
						Console.WriteLine("");
						Console.WriteLine(opt[0]);
						Console.WriteLine(opt[1]);
						Console.WriteLine(opt[2]);
						Console.BackgroundColor = ConsoleColor.Blue;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine(opt[3]);
						Console.ResetColor();
						break;
						case 5:
						index = 4;
						Console.Clear();
						opt[0] = " Add";
						opt[1] = " Subtract";
						opt[2] = " Multiply";
						opt[3] = "<Divide>";
						Console.BackgroundColor = ConsoleColor.White;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine("      _______    ________  _           _______    _       _  _           ________  _________  ________  _______\n     //_____/   //     // //          //_____/   //      // //          //     // /________/ //_____// //_____/\n    //         //     // //          //         //      // //          //     //     //     //     // //     / \n   //         //-----// //          //         //      // //          //-----//     //     //     // //_____/  \n  //         //-----// //          //         //      // //          //-----//     //     //     // // //      \n //_______  //     // //________  //_______  //______// //________  //     //     //     //_____// //   //     \n//_______/ //     // //________/ //_______/ //______// //________/ //     //     //     //_____// //     //    \n");
						Console.ResetColor();
						Console.BackgroundColor = ConsoleColor.White;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine("Welcome To\n");
						Console.ResetColor();
						Console.Write("Enter first number: ");
						Console.WriteLine(num1);
						Console.Write("\nEnter second number: ");
						Console.WriteLine(num2);
						Console.WriteLine("");
						Console.WriteLine(opt[0]);
						Console.WriteLine(opt[1]);
						Console.WriteLine(opt[2]);
						Console.BackgroundColor = ConsoleColor.Blue;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine(opt[3]);
						Console.ResetColor();
						break;
					}
				}
				
				//input3.5 OR ending menu
				Console.Clear();
				Console.BackgroundColor = ConsoleColor.White;
				Console.ForegroundColor = ConsoleColor.Black;
				Console.WriteLine("      _______    ________  _           _______    _       _  _           ________  _________  ________  _______\n     //_____/   //     // //          //_____/   //      // //          //     // /________/ //_____// //_____/\n    //         //     // //          //         //      // //          //     //     //     //     // //     / \n   //         //-----// //          //         //      // //          //-----//     //     //     // //_____/  \n  //         //-----// //          //         //      // //          //-----//     //     //     // // //      \n //_______  //     // //________  //_______  //______// //________  //     //     //     //_____// //   //     \n//_______/ //     // //________/ //_______/ //______// //________/ //     //     //     //_____// //     //    \n");
				Console.ResetColor();
				Console.BackgroundColor = ConsoleColor.White;
				Console.ForegroundColor = ConsoleColor.Black;
				Console.WriteLine("Welcome To\n");
				Console.ResetColor();
				Console.Write("Enter first number: ");
				Console.WriteLine(num1);
				Console.Write("\nEnter second number: ");
				Console.WriteLine(num2);
				Console.WriteLine("");
				Console.WriteLine($"Your answer: {ans}\n");
				Console.BackgroundColor = ConsoleColor.Blue;
				Console.ForegroundColor = ConsoleColor.Black;
				Console.WriteLine(endopt[0]);
				Console.ResetColor();
				Console.WriteLine(endopt[1]);
				while(endo == 0)
				{
					endmenu = Console.ReadKey();
					if(endmenu.Key == ConsoleKey.UpArrow)
					{
						endindex--;
					}else if(endmenu.Key == ConsoleKey.DownArrow)
					{
						endindex++;
					}else if(endmenu.Key == ConsoleKey.Enter)
					{
						endo++;
						if(endindex == 1)
						{
							end = false;
						}else if(endindex == 2)
						{
							end = true;
						}
					}
					
					switch(endindex)
					{
						case 0:
						endindex = 1;
						Console.Clear();
						endopt[0] = "<Continue>";
						endopt[1] = " Exit";
						Console.BackgroundColor = ConsoleColor.White;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine("      _______    ________  _           _______    _       _  _           ________  _________  ________  _______\n     //_____/   //     // //          //_____/   //      // //          //     // /________/ //_____// //_____/\n    //         //     // //          //         //      // //          //     //     //     //     // //     / \n   //         //-----// //          //         //      // //          //-----//     //     //     // //_____/  \n  //         //-----// //          //         //      // //          //-----//     //     //     // // //      \n //_______  //     // //________  //_______  //______// //________  //     //     //     //_____// //   //     \n//_______/ //     // //________/ //_______/ //______// //________/ //     //     //     //_____// //     //    \n");
						Console.ResetColor();
						Console.BackgroundColor = ConsoleColor.White;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine("Welcome To\n");
						Console.ResetColor();
						Console.Write("Enter first number: ");
						Console.WriteLine(num1);
						Console.Write("\nEnter second number: ");
						Console.WriteLine(num2);
						Console.WriteLine("");
						Console.WriteLine($"Your answer: {ans}\n");
						Console.BackgroundColor = ConsoleColor.Blue;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine(endopt[0]);
						Console.ResetColor();
						Console.WriteLine(endopt[1]);
						break;
						case 1:
						endindex = 1;
						Console.Clear();
						endopt[0] = "<Continue>";
						endopt[1] = " Exit";
						Console.BackgroundColor = ConsoleColor.White;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine("      _______    ________  _           _______    _       _  _           ________  _________  ________  _______\n     //_____/   //     // //          //_____/   //      // //          //     // /________/ //_____// //_____/\n    //         //     // //          //         //      // //          //     //     //     //     // //     / \n   //         //-----// //          //         //      // //          //-----//     //     //     // //_____/  \n  //         //-----// //          //         //      // //          //-----//     //     //     // // //      \n //_______  //     // //________  //_______  //______// //________  //     //     //     //_____// //   //     \n//_______/ //     // //________/ //_______/ //______// //________/ //     //     //     //_____// //     //    \n");
						Console.ResetColor();
						Console.BackgroundColor = ConsoleColor.White;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine("Welcome To\n");
						Console.ResetColor();
						Console.Write("Enter first number: ");
						Console.WriteLine(num1);
						Console.Write("\nEnter second number: ");
						Console.WriteLine(num2);
						Console.WriteLine("");
						Console.WriteLine($"Your answer: {ans}\n");
						Console.BackgroundColor = ConsoleColor.Blue;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine(endopt[0]);
						Console.ResetColor();
						Console.WriteLine(endopt[1]);
						break;
						case 2:
						endindex = 2;
						Console.Clear();
						endopt[0] = " Continue";
						endopt[1] = "<Exit>";
						Console.BackgroundColor = ConsoleColor.White;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine("      _______    ________  _           _______    _       _  _           ________  _________  ________  _______\n     //_____/   //     // //          //_____/   //      // //          //     // /________/ //_____// //_____/\n    //         //     // //          //         //      // //          //     //     //     //     // //     / \n   //         //-----// //          //         //      // //          //-----//     //     //     // //_____/  \n  //         //-----// //          //         //      // //          //-----//     //     //     // // //      \n //_______  //     // //________  //_______  //______// //________  //     //     //     //_____// //   //     \n//_______/ //     // //________/ //_______/ //______// //________/ //     //     //     //_____// //     //    \n");
						Console.ResetColor();
						Console.BackgroundColor = ConsoleColor.White;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine("Welcome To\n");
						Console.ResetColor();
						Console.Write("Enter first number: ");
						Console.WriteLine(num1);
						Console.Write("\nEnter second number: ");
						Console.WriteLine(num2);
						Console.WriteLine("");
						Console.WriteLine($"Your answer: {ans}\n");
						Console.WriteLine(endopt[0]);
						Console.BackgroundColor = ConsoleColor.Blue;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine(endopt[1]);
						Console.ResetColor();
						break;
						case 3:
						endindex = 2;
						Console.Clear();
						endopt[0] = " Continue";
						endopt[1] = "<Exit>";
						Console.BackgroundColor = ConsoleColor.White;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine("      _______    ________  _           _______    _       _  _           ________  _________  ________  _______\n     //_____/   //     // //          //_____/   //      // //          //     // /________/ //_____// //_____/\n    //         //     // //          //         //      // //          //     //     //     //     // //     / \n   //         //-----// //          //         //      // //          //-----//     //     //     // //_____/  \n  //         //-----// //          //         //      // //          //-----//     //     //     // // //      \n //_______  //     // //________  //_______  //______// //________  //     //     //     //_____// //   //     \n//_______/ //     // //________/ //_______/ //______// //________/ //     //     //     //_____// //     //    \n");
						Console.ResetColor();
						Console.BackgroundColor = ConsoleColor.White;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine("Welcome To\n");
						Console.ResetColor();
						Console.Write("Enter first number: ");
						Console.WriteLine(num1);
						Console.Write("\nEnter second number: ");
						Console.WriteLine(num2);
						Console.WriteLine("");
						Console.WriteLine($"Your answer: {ans}\n");
						Console.WriteLine(endopt[0]);
						Console.BackgroundColor = ConsoleColor.Blue;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine(endopt[1]);
						Console.ResetColor();
						break;
					}
				}
			}
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}
    }
}
