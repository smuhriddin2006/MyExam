using System.Diagnostics.CodeAnalysis;

public class Math
{
   public const double PI = 3.14;
   public const double E = 2.71;

   public int Max(int val1, int val2)
   {
      int mx = -99;
      if(val1 > mx)mx = val1;
      if(val2 > mx)mx = val2;
      return mx;
   }
      public int Min(int val1, int val2)
   {
      int mn = 99;
      if(val1 < mn)mn = val1;
      if(val2 < mn)mn = val2;
      return mn;
  
   }

}