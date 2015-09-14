using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using dr2;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        // constructor
        [TestMethod]
        public void ctorDayLowValue()
        {
            Date date = new Date(0, 3, 2010);
            Console.WriteLine("Dan je {0}", date.day);
        }

        [TestMethod]
        public void ctorDayHighValue()
        {
            Date date = new Date(50, 1, 2010);
            Console.WriteLine("Dan je {0}", date.day);
        }

        [TestMethod]
        public void ctorMonthLowValue()
        {
            Date date = new Date(2, 0, 2010);
            Console.WriteLine("Mjesec je {0}", date.month);
        }

        [TestMethod]
        public void ctorMonthHighValue()
        {
            Date date = new Date(2, 15, 2010);
            Console.WriteLine("Mjesec je {0}", date.month);
        }

        [TestMethod]
        public void ctorYearLowValue()
        {
            Date date = new Date(2, 5, -1);
            Console.WriteLine("Godina je {0}", date.year);
        }

        // get month name
        [TestMethod]
        public void getMonthNameAllCases()
        {
            for (int i = 1; i < 13; i++)
            {
                Date date = new Date(2, i, 2010);
                Console.WriteLine("Mjesec je {0}", date.getMonthName());
            }
        }

        // number of remaining days
        [TestMethod]
        public void getNumberOfRemainingDaysInMonth28()
        {
            Date date = new Date(3, 2, 2013);
            Console.WriteLine("Preostalo je {0} dana do kraja mjeseca", date.getNumberOfRemainingDaysInMonth());
        }

        [TestMethod]
        public void getNumberOfRemainingDaysInMonth29()
        {
            Date date = new Date(3, 2, 2012);
            Console.WriteLine("Preostalo je {0} dana do kraja mjeseca", date.getNumberOfRemainingDaysInMonth());
        }

        [TestMethod]
        public void getNumberOfRemainingDaysInMonth30()
        {
            Date date = new Date(3, 6, 2013);
            Console.WriteLine("Preostalo je {0} dana do kraja mjeseca", date.getNumberOfRemainingDaysInMonth());
        }

        [TestMethod]
        public void getNumberOfRemainingDaysInMonth31()
        {
            Date date = new Date(3, 7, 2013);
            Console.WriteLine("Preostalo je {0} dana do kraja mjeseca", date.getNumberOfRemainingDaysInMonth());
        }

        [TestMethod]
        public void isLeapYear4()
        {
            Date date = new Date(15, 9, 2004);
            if (date.isLeapYear())
            {
                Console.WriteLine("Godina je prijestupna");
            }
            else
            {
                Console.WriteLine("Godina nije prijestupna");
            }
        }

        [TestMethod]
        public void isLeapYear100()
        {
            Date date = new Date(15, 9, 2100);
            if (date.isLeapYear())
            {
                Console.WriteLine("Godina je prijestupna");
            }
            else
            {
                Console.WriteLine("Godina nije prijestupna");
            }
        }

        [TestMethod]
        public void isLeapYear400()
        {
            Date date = new Date(15, 9, 2000);
            if (date.isLeapYear())
            {
                Console.WriteLine("Godina je prijestupna");
            }
            else
            {
                Console.WriteLine("Godina nije prijestupna");
            }
        }

        [TestMethod]
        public void isLeapYearFalse()
        {
            Date date = new Date(15, 9, 1995);
            if (date.isLeapYear())
            {
                Console.WriteLine("Godina je prijestupna");
            }
            else
            {
                Console.WriteLine("Godina nije prijestupna");
            }
        }
    }
}
