using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructClassComparison;

namespace StructClassComparison
{
   class Program
   {
      #region StructLesson struct

      public struct StructLesson
      {
         public int x;
         public int y;

         public StructLesson (int x, int y)
         {
            this.x = x;
            this.y = y;
         }//end Structs constructor
      }
      #endregion

      static void Main(string[] args)
      {
         #region Structs v. Classes

         StructLesson originalStructValue = new StructLesson();
         originalStructValue.x = 13;
         originalStructValue.y = 13;

         Console.WriteLine("Initial struct values are " + originalStructValue.x + " and " + originalStructValue.y + ".");
         Console.WriteLine();

         ModifyThisStruct(originalStructValue);
         Console.WriteLine("Struct values after modification are " + originalStructValue.x + " and " + originalStructValue.y + ".");
         Console.WriteLine();

         ClassComparison originalClassValue = new ClassComparison(13, 13);
         Console.WriteLine("Initial class values are " + originalClassValue.x + " and " + originalClassValue.y + ".");
         Console.WriteLine();

         ModifyThisClass(originalClassValue);
         Console.WriteLine("Class values after modification are " +originalClassValue.x + " and " +originalClassValue.y + ".");
         Console.WriteLine();

         #endregion
      }//end Main

      static void ModifyThisStruct(StructLesson newStruct)
      {
         newStruct.x = 23;
         newStruct.y = 23;

         Console.WriteLine("Inside ModifyThisStruct.");
         Console.WriteLine();
         Console.WriteLine("Modified struct values are " + newStruct.x + " and " + newStruct.y + ".");
      }

      static void ModifyThisClass(ClassComparison newClass)
      {
         newClass.x = 23;
         newClass.y = 23;

         Console.WriteLine("Inside ModifyClass.");
         Console.WriteLine();
         Console.WriteLine("Modified class values are " + newClass.x  + " and " + newClass.y + ".");
      }
      
   }//end class
}//end namespace
