using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProject
{
    public class MoodAnalyzer
    {
        public string message;
        public MoodAnalyzer(string message) // creating a constructor with one string parameter
        {
            this.message = message; // Assigning value to local variable
        }
        public string AnalyzeMood() // Creating method to find mood based on message
        {
            if (message.ToLower().Contains("happy")) // If message contains sad word then return sad mood else return happy mood
            {
                return "HAPPY";
            }
            else
            {
                return "SAD";
            }
        }
    }
}
