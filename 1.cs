using System;
class HelloWorld {
  static void Main() {

         Console.WriteLine(sil("   Salam"));
 
        }   
         
        static string sil(string text)
        
        {
            string result = "";
            
        
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] != ' ')
            
             result+= text[i];
            
        }

        return result;
        
  }
}
