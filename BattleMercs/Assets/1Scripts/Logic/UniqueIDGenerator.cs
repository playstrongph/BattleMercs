using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace _1Scripts.Logic
{
   public class UniqueIDGenerator : MonoBehaviour, IUniqueIDGenerator
   {
      private readonly List<string> _usedIDs = new List<string>();
      
      public string GenerateUniqueID()
      {
         // ReSharper disable once StringLiteralTypo
         string alphanumericChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
         System.Random random = new System.Random();

         while (true)
         {
            StringBuilder idBuilder = new StringBuilder();

            // Generate the first three characters (ABC)
            for (int i = 0; i < 3; i++)
            {
               idBuilder.Append(alphanumericChars[random.Next(alphanumericChars.Length)]);
            }

            // Insert a "-" after the letters
            idBuilder.Append("-");

            // Generate the last three digits (123)
            for (int i = 0; i < 3; i++)
            {
               idBuilder.Append(random.Next(10)); // Random digit (0-9)
            }

            string newID = idBuilder.ToString();

            // Check if the ID is unique
            if (!_usedIDs.Contains(newID))
            {
               _usedIDs.Add(newID);
               return newID;
            }
         }
      }
   }
}
