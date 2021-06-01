/***************************************************************
* Name        : UserAge
* Author      : Devin Baack
* Created     : 5/31/2021
* Course      : CIS 174 - Advanced C#
* Version     : 1.0
* OS          : Windows 10, Visual Studio
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program creates a web page displaying information about the user.
*               Input:  None
*               Output: Formatted web page with all created model attributes
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.
***************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWorker.Model
{
    public class UserAgeModel
    {
        private string name;
        private String birthDate;
        private String age;
        private const String CONSTANT_DATE = "12/31/2021";


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public String BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public string Age
        {
            get { return age; }
            set { age = value; }
        }

        public String AgeThisYear()
        {
            String result = "";
            DateTime bday = Convert.ToDateTime(birthDate);
            DateTime constant = Convert.ToDateTime(CONSTANT_DATE);
            TimeSpan ts = constant.Subtract(bday);

            result = String.Format("Age on December 31st, 2021: {0} years and {1} day(s)", ts.Days / 365, ts.Days % 365);

            return result;
        }
    }
}
