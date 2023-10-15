using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace _1Scripts.Logic
{
   public class UniqueIDGenerator : MonoBehaviour, IUniqueIDGenerator
   {
      [Header("ID Length")]
      [SerializeField] private int letterCharactersLength = 9;
      //[SerializeField] private int numbersCharactersLength = 3;
      
      private readonly List<string> _usedIDs = new List<string>();
      
      public string GenerateUniqueID()
      {
         // ReSharper disable once StringLiteralTypo
         string alphanumericChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&*1234567890";
         System.Random random = new System.Random();

         while (true)
         {
            StringBuilder idBuilder = new StringBuilder();

            // Generate the first three characters (ABC)
            for (int i = 0; i < letterCharactersLength; i++)
            {
               idBuilder.Append(alphanumericChars[random.Next(alphanumericChars.Length)]);
            }

            /*// Insert a "-" after the letters
            idBuilder.Append("-");

            // Generate the last three digits (123)
            for (int i = 0; i < numbersCharactersLength; i++)
            {
               idBuilder.Append(random.Next(10)); // Random digit (0-9)
            }*/

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
