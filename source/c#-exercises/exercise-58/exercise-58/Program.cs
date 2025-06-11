using System;

namespace exercise58 {
    internal class Program {
        static void Main(string[] args) {
            Dictionary<string, string> cookies = new Dictionary<string, string>(); // Instantiate a dictionary to hold cookies
            cookies["user"] = "julia"; // Add a cookie with key "user" and value "julia"
            cookies["email"] = "jubs@gmail.com";
            cookies["phone"] = "+551231242123";
            cookies["phone"] = "+134957483829"; // Sobstituting the value for the key "phone"

            Console.WriteLine(cookies["phone"]);

            if (cookies.ContainsKey("email")) { // Check if the cookie with key "email" exists
                Console.WriteLine(cookies["email"]); // Print the value of the cookie with key "email"
            } else {
                Console.WriteLine($"There is no 'email' key.");
            }

            cookies.Remove("email"); // Remove the cookie with key "email"
            Console.WriteLine($"{cookies["email"]}");

            Console.WriteLine($"{cookies.Count}"); // Size

            Console.WriteLine("All cookies:");
            foreach (KeyValuePair<string, string> item in cookies) {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}