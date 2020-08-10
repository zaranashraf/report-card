using System;

class program 
{
   


  public static void Main (string[] args) 
  {
    
    double a;
    double b;
    double c;
    double d;
    double e;
    string confirm; 
    do 

   { Console.WriteLine("*****************");
    Console.WriteLine("REPORT CARD IN C#");
    Console.WriteLine("*****************");

    Console.Write(" enter your science number : ");
    a = Convert.ToDouble(Console.ReadLine());

    Console.Write(" enter maths number :");
    b = Convert.ToDouble(Console.ReadLine());

    Console.Write(" enter physics number :");
    c = Convert.ToDouble(Console.ReadLine());
 
    Console.Write(" enter chemistry number: ");
    d = Convert.ToDouble(Console.ReadLine());

    Console.Write(" enter computer number :");
    e = Convert.ToDouble(Console.ReadLine());

    double tn = a + b + c + d + e;
    double p = tn * 100/500;
    Console.WriteLine ( "total marks = "+ tn);
    Console.WriteLine (" percentage = " + p );
    
   if (p > 100)
   {
     Console.WriteLine("--------------------------------");
     Console.WriteLine("what are you kidding check again");
     Console.WriteLine("--------------------------------");
   } 
   else if (p<30)
   {
     Console.WriteLine(" sorry you are fail :-(");
   }
    else if (p<=40)
   {
     Console.WriteLine("you got D dont feel ashamed");
   }
   else if (p<=50)
   {
     Console.WriteLine("you got C try harder next time");
   }
   else if (p<=60)
   {
     Console.WriteLine("you got B chill out");
   }
   else if (p<=70)
   {
     Console.WriteLine("you got A well done");
   }
   else if (p<=80)
   {
    Console.WriteLine("you get A+ are you a girl");
   }
   else if (p<=90)
   {
    Console.WriteLine("you get A+ lets start the party");
   }
   else if (p<=96)
   {
     Console.WriteLine("you are angle thats it");
   }
     Console.WriteLine("------------------------------");
     Console.WriteLine("do you want to restart again ?");
     Console.WriteLine("-------------------------------");
     confirm = Console.ReadLine();
   }
   while (confirm == "yes");
   Console.WriteLine("OK THANKYOU BYE ");
   Console.WriteLine("******************");
   Console.WriteLine("developed by zaran");
   Console.WriteLine("******************");
  

    


   


  

  

    


      
    
    



    


    
  
    

  }
}