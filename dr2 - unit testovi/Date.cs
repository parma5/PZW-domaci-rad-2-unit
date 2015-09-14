namespace dr2
{
    public class Date
    {
        public int year { get; set; }
        public int month { get; set; }
        public int day { get; set; }

        public Date(int day, int month, int year)
        {
            if (day > 0 && day < 32)
            {
                this.day = day;
            }
            else
            {
                this.day = 1;
            }
            if (month > 0 && month < 13)
            {
                this.month = month;
            }
            else
            {
                this.month = 1;
            }
            if (year > 0)
            {
                this.year = year;
            }
            else
            {
                this.year = 1;
            }
        }

        public string getMonthName()
        {
            var monthName = "";
            switch (this.month)
            {
                case 1:
                    monthName = "siječanj";
                    break;
                case 2:
                    monthName = "veljača";
                    break;
                case 3:
                    monthName = "ožujak";
                    break;
                case 4:
                    monthName = "travanj";
                    break;
                case 5:
                    monthName = "svibanj";
                    break;
                case 6:
                    monthName = "lipanj";
                    break;
                case 7:
                    monthName = "srpanj";
                    break;
                case 8:
                    monthName = "kolovoz";
                    break;
                case 9:
                    monthName = "rujan";
                    break;
                case 10:
                    monthName = "listopad";
                    break;
                case 11:
                    monthName = "studeni";
                    break;
                case 12:
                    monthName = "prosinac";
                    break;
            }
            return monthName;
        }

        public int getNumberOfRemainingDaysInMonth()
        {
            if (this.month == 2 && this.isLeapYear() == false)
            {
                return 28 - this.day;
            }
            else if (this.month == 2 && this.isLeapYear() == true)
            {
                return 29 - this.day;
            }
            else if (this.month == 4 || this.month == 6 || this.month == 9 || this.month == 11)
            {
                return 30 - this.day;
            }
            else
            {
                return 31 - this.day;
            }
        }

        public bool isLeapYear()
        {
            if (this.year % 4 == 0)
            {
                if (this.year % 100 != 0)
                {
                    return true;
                }
                else if (this.year % 400 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
