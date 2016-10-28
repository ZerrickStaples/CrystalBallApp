using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrystalBallApp.Models
{
    public class CrystalBall
    {
        //get random number
        //create an array of strings for responses

        public string getResponse()
        {
            string[] responses = { "Hey", "What's up", "Hello" };
            //get random number object
            Random randomNum = new Random();
            var num = randomNum.Next(0, responses.Length);
            return responses[num];

        }
    }
}