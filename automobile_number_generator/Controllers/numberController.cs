using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace automobile_number_generator.Controllers
{
    public class numberController : Controller
    {
        // GET: number/random
        public ViewResult random()
        {
            // Create an element of Random class.
            Random rand = new Random();

            // Create an array of letters for the number.
            char[] letters = new[]
            {
                'А', 'Е', 'Т', 'О', 'Р', 'Н',
                'У', 'К', 'Х', 'С', 'В', 'М'
            };

            // Create a constant containing the region number.
            const string region = "116 RUS";

            // Create list for numbers.
            List<string> numbers = new List<string>() { };

            // Declare a variable.
            string number;

            // Generate a new number.
            do
            {
                number = letters[rand.Next(0, letters.Length)] +
                   Convert.ToString(rand.Next(0, 10)) + Convert.ToString(rand.Next(0, 10)) +
                   Convert.ToString(rand.Next(0, 10)) +
                    letters[rand.Next(0, letters.Length)] +
                    letters[rand.Next(0, letters.Length)] + " | " + region;
            }
            while (numbers.BinarySearch(number) >= 0);

            // Add to list a new number.
            numbers.Add(number);

            // Return a new number to controller.
            ViewData["Number"] = number;
            return View("random");
        }
    }
}