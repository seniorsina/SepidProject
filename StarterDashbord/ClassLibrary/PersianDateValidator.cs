using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterDashbord.ClassLibrary;
internal static class PersianDateValidator
{
    public static void ValidatePersianDate(object sender, ErrorProvider errorProvider)
    {
        MaskedTextBox maskedTextBox = sender as MaskedTextBox;
        string[] parts = maskedTextBox.Text.Split('/');
        if (parts.Length != 3)
        {
            errorProvider.SetError(maskedTextBox, "لطفا تاریخ را به فرمت yyyy/mm/dd وارد کنید.");
            return;
        }

        int year, month, day;
        if (!int.TryParse(parts[0], out year) || !int.TryParse(parts[1], out month) || !int.TryParse(parts[2], out day))
        {
            errorProvider.SetError(maskedTextBox, "لطفا تاریخ معتبر وارد کنید.");
            return;
        }

        int currentYear = DateTime.Now.Year;
        if (year < 1300 || year > currentYear)
        {
            errorProvider.SetError(maskedTextBox, "لطفا سالی بین 1300 و سال جاری وارد کنید.");
            return;
        }

        if (month < 1 || month > 12)
        {
            errorProvider.SetError(maskedTextBox, "لطفا ماهی بین 01 و 12 وارد کنید.");
            return;
        }

        int maxDay = (month <= 6) ? 31 : 30;
        if (day < 1 || day > maxDay)
        {
            string monthRange = (month <= 6) ? "01-06" : "07-12";
            errorProvider.SetError(maskedTextBox, $"لطفا روزی بین 01 و {maxDay} برای ماه های {monthRange} وارد کنید.");
            return;
        }

        PersianCalendar pc = new PersianCalendar();
        DateTime enteredDateGregorian = pc.ToDateTime(year, month, day, 0, 0, 0, 0);
        DateTime currentDateGregorian = DateTime.Now;

        if (enteredDateGregorian.Date > currentDateGregorian.Date)
        {
            errorProvider.SetError(maskedTextBox, "تاریخ وارد شده نمی تواند از تاریخ کنونی بیشتر باشد.");
            return;
        }
        errorProvider.SetError(maskedTextBox, "");
    }



}
