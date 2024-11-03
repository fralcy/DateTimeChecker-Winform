namespace DateTimeChecker
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dayTextBox.Clear();
            monthTextBox.Clear();
            yearTextBox.Clear();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            byte day;
            if (byte.TryParse(dayTextBox.Text, out day))
            {
                if (day < 1 || day > 31)
                {
                    MessageBox.Show("Input data for Day is out of range", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Input data for Day is incorrect format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            byte month;
            if (byte.TryParse(monthTextBox.Text, out month))
            {
                if (month < 1 || month > 12)
                {
                    MessageBox.Show("Input data for Month is out of range", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Input data for Month is incorrect format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            short year;
            if (short.TryParse(yearTextBox.Text, out year))
            {
                if (year < 1000 || year > 3000)
                {
                    MessageBox.Show("Input data for Year is out of range", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Input data for Year is incorrect format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (IsValidDate(year, month, day))
                MessageBox.Show($"{day}/{month}/{year} is correct date time!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show($"{day}/{month}/{year} is NOT correct date time!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public bool IsValidDate(short year, byte month, byte  day)
        {
            if (month >= 1 && month <= 12)
            {            
                if (day>=1)
                {
                    if (day <= DaysInMonth(year, month))
                    {
                        return true;
                    }
                    return false;
                }
                return false;
            }
            return false;
        }
        public byte DaysInMonth(short year, byte month)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    if (year % 400 == 0)
                    {
                        return 29;
                    }
                    else if (year % 100 == 0)
                    {
                        return 28;
                    }
                    else if (year % 4 == 0)
                    { 
                        return 29;
                    }
                    else
                    { 
                        return 28; 
                    }
                default:
                    return 0;
            }
        }
    }
}
