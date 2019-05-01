using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseString
{
    class SpecChar
    {
        //Given the string “devCodeCamp”, return what index the character ‘m’ is at within the string.




        //member variables (HAS A)
        string input;
        



        //Constructor (BUILDS OBJECT)
        public SpecChar()
        {
          input = "devCodeCamp";
            
        }





        //member methods(CAN DO)
        
        public int CodeChar()
        {
            int letter = input.IndexOf("m");
            return letter;
        }
        
      
     



    }
}
