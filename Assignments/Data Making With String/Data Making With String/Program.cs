using System;
using System.Collections.Generic;
using System.Text;


namespace Data_Making_With_String
{
     class Program
    {
        static void Main()
        {
            string input = "My credit card is 1234-5678-9012-3456";
            string output = Maskcreditcard(input);
            Console.WriteLine(output);

           input = "My social security number is 123-45-6789";
           output= MaskSocialSecurity(input);
            Console.WriteLine(output);

            input = "My credit card number is 1234-5678-9012-3456 and my social security number is 123-45-6789";
            output = MaskData(input);
            Console.WriteLine(output);

        }

        static string Maskcreditcard(string input)
        {
            string[]parts=input.Split(' ');
            for(int i=0;i<parts.Length;i++) 
            {
                string part = parts[i];
                if(part.Length ==19 && part[4] == '-'&& part[9]=='-' && part[14]== '-')
                {
                    string mask = new string('X', 4);
                    string lastfourdigits=part.Substring(15,4);
                    parts[i] = mask+'-'+ mask+'-'+ mask+'-'+ lastfourdigits;

                }
            }
            return string.Join(" ",parts);
        }

        static string MaskSocialSecurity(string input)
        {
            string[] parts = input.Split(' ');
            for (int i = 0; i < parts.Length; i++)
            {
                string part = parts[i];
                if (part.Length == 11 && part[3] == '-' && part[6] == '-' )
                {
                    string mask1 = new string('X', 3);
                    string mask2 = new string('X', 4);

                    string middleTwoDigits = part.Substring(4, 2);
                    parts[i] = mask1 + '-' + middleTwoDigits + '-' + mask2 ;

                }
            }
            return string.Join(" ", parts);
        }

  
        static string MaskData(string input)
        {
            string output = Maskcreditcard(input);
            output=MaskSocialSecurity(output);
            return output;
        }

    }
}
