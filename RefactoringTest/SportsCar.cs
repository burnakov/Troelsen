using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefactoringTest
{
    public class SportsCar : Car
    {
        public string GetPetName()
        {
            petName = "Patrick";
            return petName;
        }
    }
}