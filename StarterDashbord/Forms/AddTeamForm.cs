using StarterDashbord.ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarterDashbord.Forms;
public partial class AddTeamForm : Form
{
    public AddTeamForm()
    {
        InitializeComponent();
        mtxtCreateDate.Leave += (sender, e) => PersianDateValidator.ValidatePersianDate(sender, errorProvider);
    }

    private void maskedTextBox1_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
    {

    }



    private void ValidatePersianDate(object sender)
    {
        MaskedTextBox maskedTextBox = sender as MaskedTextBox;
        string[] parts = maskedTextBox.Text.Split('/');
        if (parts.Length != 3)
        {
            MessageBox.Show("لطفا تاریخ را به فرمت yyyy/mm/dd وارد کنید.");
            return;
        }

        int year, month, day;
        if (!int.TryParse(parts[0], out year) || !int.TryParse(parts[1], out month) || !int.TryParse(parts[2], out day))
        {
            MessageBox.Show("لطفا تاریخ معتبر وارد کنید.");
            return;
        }

        int currentYear = DateTime.Now.Year;
        if (year < 1300 || year > currentYear)
        {
            MessageBox.Show("لطفا سالی بین 1300 و سال جاری وارد کنید.");
            return;
        }

        if (month < 1 || month > 12)
        {
            MessageBox.Show("لطفا ماهی بین 01 و 12 وارد کنید.");
            return;
        }

        int maxDay = (month <= 6) ? 31 : 30;
        if (day < 1 || day > maxDay)
        {
            string monthRange = (month <= 6) ? "01-06" : "07-12";
            MessageBox.Show($"لطفا روزی بین 01 و {maxDay} برای ماه های {monthRange} وارد کنید.");
            return;
        }

        PersianCalendar pc = new PersianCalendar();
        DateTime enteredDateGregorian = pc.ToDateTime(year, month, day, 0, 0, 0, 0);
        DateTime currentDateGregorian = DateTime.Now;

        if (enteredDateGregorian.Date > currentDateGregorian.Date)
        {
            MessageBox.Show("تاریخ وارد شده نمی تواند از تاریخ کنونی بیشتر باشد.");
            return;
        }
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label5_Click(object sender, EventArgs e)
    {

    }
}
