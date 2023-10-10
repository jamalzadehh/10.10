using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "        Salam,    AzerbAycAnA  XoS     geLmisIniz.   ";
            string output = FormatSentence(input);
            Console.WriteLine(output);

        }
    }

    class Program    //Neyi sehv etdiyimi tapa bilmedim. 
    {
        static string FormatSentence(string sentence) { 
            sentence = sentence.Trim();
            sentence = string.Join(" ", sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            TextInfo textInfo = new CultureInfo("a-Z", false).TextInfo;
            sentence = textInfo.ToTitleCase(sentence.ToLower());
            return sentence;            
      }      }

    
      
        
    
}