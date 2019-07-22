using System.Collections.Generic;
using System.Linq;
using System.Text;
using SB.Tools.Classes.Language;
using SB.Tools.Classes.Response;
using SB.Tools.DateTime;

namespace System
{
    public static class SeifaeiBrothersDateTime
    {
        #region --> Fileds & Properties

        #region --> define property objPersianCalendar

        private static System.Globalization.PersianCalendar _objPersianCalendar = new System.Globalization.PersianCalendar();

        /// <summary>
        /// شیء که با استفاده از آن می توان به تاریخ شمسی دسترسی داشت
        /// </summary>
        public static System.Globalization.PersianCalendar objPersianCalendar
        {
            get { return _objPersianCalendar; }
        }

        #endregion //define property objPersianCalendar

        #region --> define property objHijriCalendar

        private static System.Globalization.HijriCalendar _objHijriCalendar = new Globalization.HijriCalendar();

        /// <summary>
        /// تاریخ قمری
        /// </summary>
        public static System.Globalization.HijriCalendar objHijriCalendar
        {
            get { return _objHijriCalendar; }
        }

        #endregion //define property objHijriCalendar

        #region --> define property objHebrewCalendar

        private static System.Globalization.HebrewCalendar _objHebrewCalendar = new Globalization.HebrewCalendar();

        /// <summary>
        /// تاریخ عبری
        /// </summary>
        public static System.Globalization.HebrewCalendar objHebrewCalendar
        {
            get { return _objHebrewCalendar; }
        }

        #endregion //define property objHebrewCalendar

        #endregion //Fileds & Properties

        #region --> Get name Of month and number of month of name

        /// <summary>
        /// این متد شماره ماه را می گیرد و نام آنرا باز می گرداند
        /// </summary>
        /// <param name="month">شماره ماه مورد نظر</param>
        public static string GetNameOfMonth_Milady(int month)
        {
            string result = string.Empty;

            if (month == 1) result = Texts.January;
            else if (month == 2) result = Texts.February;
            else if (month == 3) result = Texts.March;
            else if (month == 4) result = Texts.April;
            else if (month == 5) result = Texts.May;
            else if (month == 6) result = Texts.June;
            else if (month == 7) result = Texts.July;
            else if (month == 8) result = Texts.August;
            else if (month == 9) result = Texts.September;
            else if (month == 10) result = Texts.October;
            else if (month == 11) result = Texts.November;
            else if (month == 12) result = Texts.December;

            if (string.IsNullOrEmpty(result))
            {
                Exception newEx = new Exception(String.Format(Texts.MonthNumberIsNotValid, month));
                newEx.Data.Add(SeifaeiBrothersException.cntKeyNameExceptionID, "40B10F75-874D-425E-8302-8B3F707DD972");
                throw newEx;
            }

            return result;
        }

        public static string GetNameOfMonth_Persian(int month)
        {
            string result = string.Empty;
            if (month == 1) result = Texts.Farvardin;
            else if (month == 2) result = Texts.Ordibehesht;
            else if (month == 3) result = Texts.Khordad;
            else if (month == 4) result = Texts.Tir;
            else if (month == 5) result = Texts.Mordad;
            else if (month == 6) result = Texts.Shahrivar;
            else if (month == 7) result = Texts.Mehr;
            else if (month == 8) result = Texts.Aban;
            else if (month == 9) result = Texts.Azar;
            else if (month == 10) result = Texts.Dey;
            else if (month == 11) result = Texts.Bahman;
            else if (month == 12) result = Texts.Esfand;

            if (string.IsNullOrEmpty(result))
            {
                Exception newEx = new Exception(string.Format(Texts.MonthNumberIsNotValid, month));
                newEx.Data.Add(SeifaeiBrothersException.cntKeyNameExceptionID, "B46C9DBB-4076-4EFD-BE18-47EE6C88B8A3");
                throw newEx;
            }
            return result;
        }

        public static string GetNameOfMonth_Hijri(int month)
        {
            string result = string.Empty;

            if (month == 1) result = Texts.Muharram;
            else if (month == 2) result = Texts.Safar;
            else if (month == 3) result = Texts.Rabi_al_awwal;
            else if (month == 4) result = Texts.Rabi_al_thani;
            else if (month == 5) result = Texts.Jumada_al_awwal;
            else if (month == 6) result = Texts.Jumada_al_thani;
            else if (month == 7) result = Texts.Rajab;
            else if (month == 8) result = Texts.Shaaban;
            else if (month == 9) result = Texts.Ramazan;
            else if (month == 10) result = Texts.Shawwal;
            else if (month == 11) result = Texts.Dhu_al_Qidah;
            else if (month == 12) result = Texts.Dhu_al_Hijjah;

            if (string.IsNullOrEmpty(result))
            {
                Exception newEx = new Exception(string.Format(Texts.MonthNumberIsNotValid, month));
                newEx.Data.Add(SeifaeiBrothersException.cntKeyNameExceptionID, "B10B9967-0FF1-44DE-BCBA-79BAA28F3F6A");
                throw newEx;
            }

            return result;
        }

        public static string GetNameOfMonth_Hebrew(int year, int month)
        {
            string result = string.Empty;
            if (month == 1) result = Texts.Tishri;
            else if (month == 2) result = Texts.Marheshwan;
            else if (month == 3) result = Texts.Kislew;
            else if (month == 4) result = Texts.Tebeth;
            else if (month == 5) result = Texts.Shevat;



            if (objHebrewCalendar.GetMonthsInYear(year) == 13)
            {

                if (month == 6) result = Texts.AdarI;
                else if (month == 7) result = Texts.AdarII;
                else if (month == 8) result = Texts.Nisan;
                else if (month == 9) result = Texts.Iyyar;
                else if (month == 10) result = Texts.Siwan;
                else if (month == 11) result = Texts.Tammuz;
                else if (month == 12) result = Texts.Av;
                else if (month == 13) result = Texts.Elul;
            }
            else
            {
                if (month == 6) result = Texts.Adar;
                else if (month == 7) result = Texts.Nisan;
                else if (month == 8) result = Texts.Iyyar;
                else if (month == 9) result = Texts.Siwan;
                else if (month == 10) result = Texts.Tammuz;
                else if (month == 11) result = Texts.Av;
                else if (month == 12) result = Texts.Elul;
            }

            if (string.IsNullOrEmpty(result))
            {
                Exception newEx = new Exception(string.Format(Texts.NumberMonthYearInHebrewIsMistake, month, year.ToString("D4")));
                newEx.Data.Add(SeifaeiBrothersException.cntKeyNameExceptionID, "4B186CB7-33D4-4A85-9D8C-D005AB526AD1");
                throw newEx;
            }

            return result;
        }

        public static string GetNameOfMonth(int year, int month, SB.Tools.DateTime.CalendarType calendarType)
        {
            switch (calendarType)
            {
                case SB.Tools.DateTime.CalendarType.PersianCalendar:
                    return GetNameOfMonth_Persian(month);
                case SB.Tools.DateTime.CalendarType.HijriCalendar:
                    return GetNameOfMonth_Hijri(month);
                case SB.Tools.DateTime.CalendarType.HebrewCalendar:
                    return GetNameOfMonth_Hebrew(year, month);
                default:
                    return GetNameOfMonth_Milady(month);
            }
        }

        /// <summary>
        ///این متد نام یک ماه را می گیرد و شماره ماه را 
        ///باز می گرداند در صورت اشتباه بودن نام ماه عدد صفر باز گردنده می شود
        /// </summary>
        public static int GetNumberPersianMonth(string monthName)
        {
            if (string.IsNullOrEmpty(monthName))
            {
                return 0;
            }
            for (int i = 1; i <= 12; i++)
            {
                if (GetNameOfMonth_Persian(i) == monthName)
                {
                    return i;
                }
            }
            return 0;
        }

        /// <summary>
        ///این متد نام یک ماه را می گیرد و شماره ماه را 
        ///باز می گرداند در صورت اشتباه بودن نام ماه عدد صفر باز گردنده می شود
        /// </summary>
        public static int GetNumberHijriMonth(string monthName)
        {
            if (string.IsNullOrEmpty(monthName))
            {
                return 0;
            }
            for (int i = 1; i <= 12; i++)
            {
                if (GetNameOfMonth_Hijri(i) == monthName)
                {
                    return i;
                }
            }
            return 0;
        }

        /// <summary>
        ///این متد نام یک ماه را می گیرد و شماره ماه را 
        ///باز می گرداند در صورت اشتباه بودن نام ماه عدد صفر باز گردنده می شود
        /// </summary>
        public static int GetNumberChristianMonth(string monthName)
        {
            if (string.IsNullOrEmpty(monthName))
            {
                return 0;
            }
            for (int i = 1; i <= 12; i++)
            {
                if (GetNameOfMonth_Milady(i) == monthName)
                {
                    return i;
                }
            }
            return 0;
        }

        /// <summary>
        ///این متد نام یک ماه را می گیرد و شماره ماه را 
        ///باز می گرداند در صورت اشتباه بودن نام ماه عدد صفر باز گردنده می شود
        /// </summary>
        public static int GetNumberHebrewMonth(int Year, string monthName)
        {
            if (string.IsNullOrEmpty(monthName))
            {
                return 0;
            }
            for (int i = 1; i <= 13; i++)
            {
                if (GetNameOfMonth_Hebrew(Year, i) == monthName)
                {
                    return i;
                }
            }
            return 0;
        }

        public static string GetNameOfYear(int year, SB.Tools.DateTime.CalendarType calendarType)
        {
            string Result = string.Empty;

            #region --> Set Persian Calendar

            if (calendarType == SB.Tools.DateTime.CalendarType.PersianCalendar)
            {
                switch (year % 12)
                {
                    case 0: Result = Texts.Snake; break;
                    case 1: Result = Texts.Horse; break;
                    case 2: Result = Texts.Sheep; break;
                    case 3: Result = Texts.Monkey; break;
                    case 4: Result = Texts.Hen; break;
                    case 5: Result = Texts.Dog; break;
                    case 6: Result = Texts.Pig; break;
                    case 7: Result = Texts.Mouse; break;
                    case 8: Result = Texts.Cow; break;
                    case 9: Result = Texts.Panther; break;
                    case 10: Result = Texts.Rabbit; break;
                    case 11: Result = Texts.Whale; break;
                }
            }
            #endregion //Set Persian Calendar

            #region --> Christian Calendar

            else if (calendarType == SB.Tools.DateTime.CalendarType.ChristianCalendar)
            {
                Result = Texts.Christian;
            }

            #endregion //Christian Calendar

            #region --> Hijri Calendar

            else if (calendarType == SB.Tools.DateTime.CalendarType.HijriCalendar)
            {
                Result = Texts.Hijri;
            }

            #endregion //Hijri Calendar

            #region --> Hebrew Calendar

            else if (calendarType == SB.Tools.DateTime.CalendarType.HebrewCalendar)
            {
                Result = Texts.Hebrew;
            }

            #endregion //Hebrew Calendar

            return Result;
        }

        #endregion //Get name Of month and number of month of name

        #region --> Extended methods

        #region --> Add Date

        public static DateTime AddYears(this DateTime source, SB.Tools.DateTime.CalendarType calendarType, int years)
        {
            try
            {
                switch (calendarType)
                {
                    case SB.Tools.DateTime.CalendarType.PersianCalendar:
                        return SeifaeiBrothersDateTime.objPersianCalendar.AddYears(source, years);
                    case SB.Tools.DateTime.CalendarType.HijriCalendar:
                        return SeifaeiBrothersDateTime.objHijriCalendar.AddYears(source, years);
                    case SB.Tools.DateTime.CalendarType.HebrewCalendar:
                        return SeifaeiBrothersDateTime.objHebrewCalendar.AddYears(source, years);
                    default:
                        return source.AddYears(years);
                }
            }
            catch (Exception ex)
            {
                Exception newEx = new Exception(string.Format(Texts.ErrorInAddYear, years, source.ToString(calendarType, SB.Tools.DateTime.ToStringFormat.ShortDateTime)), ex);
                newEx.Data.Add(SeifaeiBrothersException.cntKeyNameExceptionID, "A748A4B0-77DA-46CB-B63B-48ECBB66BD68");
                throw newEx;
            }
        }

        public static DateTime AddMonths(this DateTime source, SB.Tools.DateTime.CalendarType calendarType, int months)
        {
            try
            {
                switch (calendarType)
                {
                    case SB.Tools.DateTime.CalendarType.PersianCalendar:
                        return SeifaeiBrothersDateTime.objPersianCalendar.AddMonths(source, months);
                    case SB.Tools.DateTime.CalendarType.HijriCalendar:
                        return SeifaeiBrothersDateTime.objHijriCalendar.AddMonths(source, months);
                    case SB.Tools.DateTime.CalendarType.HebrewCalendar:
                        return SeifaeiBrothersDateTime.objHebrewCalendar.AddMonths(source, months);
                    default:
                        return source.AddMonths(months);
                }
            }
            catch (Exception ex)
            {
                Exception newEx = new Exception(string.Format(Texts.ErrorInAddMonths, months, source.ToString(calendarType, SB.Tools.DateTime.ToStringFormat.ShortDateTime)), ex);
                newEx.Data.Add(SeifaeiBrothersException.cntKeyNameExceptionID, "A8585F9D-7F03-4805-AE6B-CFE625994BD9");
                throw newEx;
            }
        }

        public static DateTime AddDays(this DateTime source, SB.Tools.DateTime.CalendarType calendarType, int days)
        {
            try
            {
                switch (calendarType)
                {
                    case SB.Tools.DateTime.CalendarType.PersianCalendar:
                        return SeifaeiBrothersDateTime.objPersianCalendar.AddDays(source, days);
                    case SB.Tools.DateTime.CalendarType.HijriCalendar:
                        return SeifaeiBrothersDateTime.objHijriCalendar.AddDays(source, days);
                    case SB.Tools.DateTime.CalendarType.HebrewCalendar:
                        return SeifaeiBrothersDateTime.objHebrewCalendar.AddDays(source, days);
                    default:
                        return source.AddDays(days);
                }
            }
            catch (Exception ex)
            {
                Exception newEx = new Exception(string.Format(Texts.ErrorInAddDays, days, source.ToString(calendarType, SB.Tools.DateTime.ToStringFormat.ShortDateTime)), ex);
                newEx.Data.Add(SeifaeiBrothersException.cntKeyNameExceptionID, "A8585F9D-7F03-4805-AE6B-CFE625994BD9");
                throw newEx;
            }
        }

        public static DateTime AddHours(this DateTime source, SB.Tools.DateTime.CalendarType calendarType, int hours)
        {
            try
            {
                switch (calendarType)
                {
                    case SB.Tools.DateTime.CalendarType.PersianCalendar:
                        return SeifaeiBrothersDateTime.objPersianCalendar.AddHours(source, hours);
                    case SB.Tools.DateTime.CalendarType.HijriCalendar:
                        return SeifaeiBrothersDateTime.objHijriCalendar.AddHours(source, hours);
                    case SB.Tools.DateTime.CalendarType.HebrewCalendar:
                        return SeifaeiBrothersDateTime.objHebrewCalendar.AddHours(source, hours);
                    default:
                        return source.AddHours(hours);
                }
            }
            catch (Exception ex)
            {
                Exception newEx = new Exception(string.Format(Texts.ErrorInAddHours, hours, source.ToString(calendarType, SB.Tools.DateTime.ToStringFormat.ShortDateTime)), ex);
                newEx.Data.Add(SeifaeiBrothersException.cntKeyNameExceptionID, "9E7E4F90-2612-4A89-937D-E78E6C9752A8");
                throw newEx;
            }
        }

        public static DateTime AddMinutes(this DateTime source, SB.Tools.DateTime.CalendarType calendarType, int minutes)
        {
            try
            {
                switch (calendarType)
                {
                    case SB.Tools.DateTime.CalendarType.PersianCalendar:
                        return SeifaeiBrothersDateTime.objPersianCalendar.AddMinutes(source, minutes);
                    case SB.Tools.DateTime.CalendarType.HijriCalendar:
                        return SeifaeiBrothersDateTime.objHijriCalendar.AddMinutes(source, minutes);
                    case SB.Tools.DateTime.CalendarType.HebrewCalendar:
                        return SeifaeiBrothersDateTime.objHebrewCalendar.AddMinutes(source, minutes);
                    default:
                        return source.AddMinutes(minutes);
                }
            }
            catch (Exception ex)
            {
                Exception newEx = new Exception(string.Format(Texts.ErrorInAddMinutes, minutes, source.ToString(calendarType, SB.Tools.DateTime.ToStringFormat.ShortDateTime)), ex);
                newEx.Data.Add(SeifaeiBrothersException.cntKeyNameExceptionID, "9E7E4F90-2612-4A89-937D-E78E6C9752A8");
                throw newEx;
            }
        }

        public static DateTime AddSeconds(this DateTime source, SB.Tools.DateTime.CalendarType calendarType, int seconds)
        {
            try
            {
                switch (calendarType)
                {
                    case SB.Tools.DateTime.CalendarType.PersianCalendar:
                        return SeifaeiBrothersDateTime.objPersianCalendar.AddSeconds(source, seconds);
                    case SB.Tools.DateTime.CalendarType.HijriCalendar:
                        return SeifaeiBrothersDateTime.objHijriCalendar.AddSeconds(source, seconds);
                    case SB.Tools.DateTime.CalendarType.HebrewCalendar:
                        return SeifaeiBrothersDateTime.objHebrewCalendar.AddSeconds(source, seconds);
                    default:
                        return source.AddSeconds(seconds);
                }
            }
            catch (Exception ex)
            {
                Exception newEx = new Exception(string.Format(Texts.ErrorInAddSeconds, seconds, source.ToString(calendarType, SB.Tools.DateTime.ToStringFormat.ShortDateTime)), ex);
                newEx.Data.Add(SeifaeiBrothersException.cntKeyNameExceptionID, "1C23AD7D-9F22-4E9B-8C31-E14EB5EFA54D");
                throw newEx;
            }
        }

        public static DateTime AddMilliseconds(this DateTime source, SB.Tools.DateTime.CalendarType calendarType, int milliseconds)
        {
            try
            {
                switch (calendarType)
                {
                    case SB.Tools.DateTime.CalendarType.PersianCalendar:
                        return SeifaeiBrothersDateTime.objPersianCalendar.AddMilliseconds(source, milliseconds);
                    case SB.Tools.DateTime.CalendarType.HijriCalendar:
                        return SeifaeiBrothersDateTime.objHijriCalendar.AddMilliseconds(source, milliseconds);
                    case SB.Tools.DateTime.CalendarType.HebrewCalendar:
                        return SeifaeiBrothersDateTime.objHebrewCalendar.AddMilliseconds(source, milliseconds);
                    default:
                        return source.AddMilliseconds(milliseconds);
                }
            }
            catch (Exception ex)
            {
                Exception newEx = new Exception(string.Format(Texts.ErrorInAddMinutes, milliseconds, source.ToString(calendarType, SB.Tools.DateTime.ToStringFormat.ShortDateTime)), ex);
                newEx.Data.Add(SeifaeiBrothersException.cntKeyNameExceptionID, "127271B5-B937-4177-94D0-7A67661E885F");
                throw newEx;
            }
        }

        #endregion //Add Date

        #region --> Define Events of Calendar

        public static List<string> GetEvents_PersianDate(this DateTime source)
        {
            List<string> Result = new List<string>();
            int month = source.GetMonth(SB.Tools.DateTime.CalendarType.PersianCalendar);
            int Day = source.GetDayOfMonth(SB.Tools.DateTime.CalendarType.PersianCalendar);
            #region month 1

            if (month == 1)
            {
                switch (Day)
                {
                    case 1:
                        Result.Add("آغاز نوروز");
                        break;
                    case 2:
                        Result.Add("هجوم ماموران ستم شاهی پهلوی به مدرسه فیضه قم در سال 1342 شمسی");
                        Result.Add("آغاز عملیات فتح المبین در سال 1363 شمسی");
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        Result.Add("همه پرسی تغییر رژیم شاهنشاهی به جمهوری اسلامی در سال 1358 شمسی");
                        break;
                    case 11:
                        Result.Add("به رسمیت شناخته شدن تاریخ هجری شمسی به جای تاریخ هجری قمری با رای مجلس شورای ملی در سال 1304 شمسی");
                        break;
                    case 12:
                        Result.Add("روز جمهوری اسلامی ایران");
                        break;
                    case 13:
                        Result.Add("روز طبیعت");
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        Result.Add("آغاز هفته سلامت");
                        break;
                    case 19:
                        Result.Add("شهادت آیت الله سید محمد باقر صدر و خواهر ایشان توسط رژیم بعث عراق در سال 1359 شمسی");
                        break;
                    case 20:
                        Result.Add("روز ملی فناوری هسته ای");
                        Result.Add("قطع مناسبات سیاسی ایران و آمریکا در سال 1359 شمسی");
                        break;
                    case 21:
                        Result.Add("شهادت امیر سپهبد علی صیاد شیرازی توسط منافقین در سال 1378 شمسی");
                        Result.Add("تاسیس بنیاد مسکن انقلاب اسلامی به فرمان امام خمینی در سال 1358 شمسی");
                        break;
                    case 22:
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        Result.Add("روز بزرگداشت عطار نیشابوری");
                        break;
                    case 26:
                        break;
                    case 27:
                        break;
                    case 28:
                        break;
                    case 29:
                        Result.Add("روز ارتش جمهوری اسلامی");
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 2

            else if (month == 2)
            {
                switch (Day)
                {
                    case 1:
                        break;
                    case 2:
                        Result.Add("تاسیس سپاه پاسداران در سال 1358 شمسی");
                        Result.Add("روز زمین پاک");
                        break;
                    case 3:
                        Result.Add("روز بزرگداشت شیخ بهائی");
                        Result.Add("شهادت شهید قرنی");
                        break;
                    case 4:
                        break;
                    case 5:
                        Result.Add("شکست حمله نظامی آمریکا به ایران در طبس در سال 1359 شمسی");
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        Result.Add("روز شوراها");
                        break;
                    case 10:
                        Result.Add("روز ملی خلیج فارس");
                        Result.Add("آغاز عملیات بیت المقدس در سال 1361 شمسی");
                        Result.Add("شهادت سردار فاتح بازی دراز");
                        break;
                    case 11:
                        break;
                    case 12:
                        Result.Add("شهادت استاد مرتضی مطهری در سال 1358 شمسی و روز معلم");
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        Result.Add("روز بزرگداشت شیخ صدوق");
                        break;
                    case 16:
                        break;
                    case 17:
                        Result.Add("روز اسناد ملی");
                        Result.Add("سالروز تشکیل بسیج سازندگی");
                        break;
                    case 18:
                        Result.Add("آزاد سازی هویزه سال 61 هجری");
                        break;
                    case 19:
                        Result.Add("روز بزرگداشت شیخ کلینی");
                        break;
                    case 20:
                        break;
                    case 21:
                        break;
                    case 22:
                        break;
                    case 23:
                        break;
                    case 24:
                        Result.Add("لغو امتیاز تنباکو به فتوای آیت الله میرزا حسن شیرازی در سال 1270 شمسی");
                        break;
                    case 25:
                        Result.Add("روز بزرگداشت فردوسی");
                        break;
                    case 26:
                        break;
                    case 27:
                        Result.Add("روز ارتباطات و روابط عمومی");
                        break;
                    case 28:
                        Result.Add("روز بزرگداشت حکیم عمر خیام تنظیم کننده تقویم شمسی دقیقترین تقویم گذشته و حال و اینده دنیا");
                        break;
                    case 29:
                        Result.Add("روز بسیج عشایری");
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 3

            else if (month == 3)
            {
                switch (Day)
                {
                    case 1:
                        Result.Add("آغاز محاصره اقتصادی جمهوری اسلامی ایران توسط آمریکا در سال 1359 شمسی");
                        Result.Add("روز بهره وری و بهینه سازی مصرف");
                        Result.Add("روز بزرگداشت ملاصدرا - صدرالمتاهلین");
                        break;
                    case 2:
                        break;
                    case 3:
                        Result.Add("فتح خرمشهر در عملیات بیت المقدس در سال 1361 شمسی و روز مقاومت،ایثار و پیروزی");
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        Result.Add("افتتاح اولین دوره مجلس شورای اسلامی در سال 1359 شمسی");
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        Result.Add("رحلت حضرت امام خمینی و انتخاب حضرت آیت الله خامنه ای به عنوان رهبری در سال 1368 شمسی");
                        break;
                    case 15:
                        Result.Add("زندانی شدن امام خمینی توسط ماموران شاه و قیام 15 خرداد در سال 1342 شمسی");
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        Result.Add("شهادت آیت الله سعیدی به دست ماموران شاه در سال 1349 شمسی");
                        Result.Add("عزل بنی صدر از فرماندهی کل قوا");
                        break;
                    case 21:
                        break;
                    case 22:
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        Result.Add("روز گل و گیاه");
                        break;
                    case 26:
                        break;
                    case 27:
                        Result.Add("روز جهاد کشاورزی و تشکیل جهاد سازندگی به فرمان امام خمینی در سال 1358 شمسی");
                        break;
                    case 28:
                        break;
                    case 29:
                        Result.Add("در گذشت دکتر علی شریعتی در سال 1356 شمسی");
                        break;
                    case 30:
                        Result.Add("انفجار در حرم امام رضا )ع( به دست منافقین کئر دل در سال 1373 شمسی");
                        break;
                    case 31:
                        Result.Add("شهادت دکتر مصطفی چمران در سال 1360 شمسی و سالروز بسیج اساتید");
                        break;
                }
            }

            #endregion

            #region month 4

            else if (month == 4)
            {
                switch (Day)
                {
                    case 1:
                        Result.Add("عزل بنی صدر از ریاست جمهوری");
                        Result.Add("روز تبلیغ و اطلاع رسانی و سالروز فرمان امام خمینی مبنی بر تاسیس سازمان تبلیغات اسلامی در سال 1360 شمسی");
                        Result.Add("روز اصناف");
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        Result.Add("روز ترور آیت الله خامنه ای در سال 1360");
                        break;
                    case 7:
                        Result.Add("شهادت ایت الله بهشتی و 72 تن از یارانش با انفجار بمب به دست منافین  در سال 1360 شمسی و روز قوه قضائیه");
                        break;
                    case 8:
                        Result.Add("بمباران شیمیائی سردشت");
                        Result.Add("روز مبارزه با سلاح شیمیائی و میکروبی");
                        break;
                    case 9:
                        break;
                    case 10:
                        Result.Add("روز صنعت و معدن");
                        break;
                    case 11:
                        Result.Add("شهادت آیت الله صدوقی چهارمین شهید محراب به دست منافقان کور دل در سال 1361 شمسی");
                        break;
                    case 12:
                        Result.Add("سرنگونی هواپیمای مسافر بری جمهوری اسلامی ایران توسط ناو آمریکائی در خلیج فارس در سال 1367 شمسی");
                        Result.Add("روز بزرگداشت علامه امینی");
                        break;
                    case 13:
                        break;
                    case 14:
                        Result.Add("روز قلم");
                        break;
                    case 15:
                        break;
                    case 16:
                        Result.Add("روز مالیات");
                        break;
                    case 17:
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case 21:
                        Result.Add("روز عفاف و حجاب");
                        Result.Add("کشف توطئه کودتای آمریکائی در پایگاه هوائی شهید نوژه در سال 1359 شمسی");
                        Result.Add("حمله به مسجد گوهر شاد و کشتار مردم توسط رضا خان میرپنج در سال 1314 شمسی");
                        break;
                    case 22:
                        break;
                    case 23:
                        Result.Add("گشایش نخستین مجلس خبرگان رهبری در سال 1362 شمسی");
                        break;
                    case 24:
                        break;
                    case 25:
                        Result.Add("روز بهزیستی و تامین اجتماعی");
                        break;
                    case 26:
                        break;
                    case 27:
                        Result.Add("اعلام پذیرش قطعنامه 598 شورای امنیت از سوی ایران در سال 1367 شمسی");
                        break;
                    case 28:
                        break;
                    case 29:
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 5

            else if (month == 5)
            {
                switch (Day)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        Result.Add("سالروز عملیات غرور آفرین مرصاد در سال 1367 شمسی");
                        break;
                    case 6:
                        Result.Add("روز کارآفرینی و آموزشهای فنی و حرفه ای");
                        break;
                    case 7:
                        break;
                    case 8:
                        Result.Add("روز بزرگداشت شیخ شهاب الدین سهروردی  ملقب به شیخ اشراق");
                        break;
                    case 9:
                        Result.Add("روز اهدای خون");
                        break;
                    case 10:
                        break;
                    case 11:
                        Result.Add("شهادت آیت الله شیخ فضل الله نوری در سال 1288 شمسی");
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        Result.Add("صدور فرمان مشروطیت در سال 1358 شمسی");
                        Result.Add("روز حقوق بشر اسلامی و کرامت انسانی");
                        break;
                    case 15:
                        break;
                    case 16:
                        Result.Add("تشکیل جهاد دانشگاهی در سال 1359 شمسی");
                        break;
                    case 17:
                        Result.Add("روز خبرنگار");
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case 21:
                        break;
                    case 22:
                        break;
                    case 23:
                        Result.Add("روز مقاومت اسلامی");
                        break;
                    case 24:
                        break;
                    case 25:
                        break;
                    case 26:
                        Result.Add("آغاز بازگشت آزادگان به وطن در سال 1369 شمسی");
                        break;
                    case 27:
                        break;
                    case 28:
                        Result.Add("کودتای آمریکا برای بازگرداندن شاه در سال 1332 شمسی");
                        Result.Add("گشایش مجلس خبرگان برای بررسی نهائی قانون اساسی جمهوری اسلامی ایران در سال 1358 شمسی");
                        break;
                    case 29:
                        Result.Add("آتش بس رسمی ایران و عراق در سال 1367");
                        break;
                    case 30:
                        Result.Add("روز بزرگداشت علامه مجلسی");
                        break;
                    case 31:
                        Result.Add("روز مساجد");
                        break;
                }
            }

            #endregion

            #region month 6

            else if (month == 6)
            {
                switch (Day)
                {
                    case 1:
                        Result.Add("روز پزشک و روز بزرگداشت بو علی سینا");
                        break;
                    case 2:
                        Result.Add("آغاز هفته دولت");
                        break;
                    case 3:
                        Result.Add("اشغال ایران توسط متفقین و فرار رضا خان در سال 1320 شمسی");
                        break;
                    case 4:
                        Result.Add("روز کارمند");
                        break;
                    case 5:
                        Result.Add("روز دارو سازی و روز بزرگداشت محمد بن زکریای رازی");
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        Result.Add("انفجار دفتر نخست وزیری به دست منافقین و شهادت آقایان رجائی و باهنر در سال 1360 شمسی و روز مبارزه با تروریسم");
                        break;
                    case 9:
                        break;
                    case 10:
                        Result.Add("روز بانکداری اسلامی و سالروز تصویب قانون عملیات بانکی بدون ربا! در سال 1362 شمسی");
                        break;
                    case 11:
                        Result.Add("روز صنعت چاپ");
                        break;
                    case 12:
                        Result.Add("وفات پروفسور حسابی فیزیکدان برجسته ایرانی در سن 90 سالگی در سال 1371 شمسی");
                        Result.Add("روز بهورز");
                        break;
                    case 13:
                        Result.Add("روز تعاون و روز بزگداشت ابوریحان بیرونی");
                        break;
                    case 14:
                        Result.Add("شهادت آیت الله قدوسی در سال 1360 شمسی");
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                    case 17:
                        Result.Add("قیام 17 شهریور و شهادت جمعی از مردم به دست ماموران شاه در سال 1357 مشمسی");
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        Result.Add("شهادت دومین شهید محراب آیت الله مدنی به دست منافقین در سال 1360 شمسی");
                        break;
                    case 21:
                        Result.Add("روز سینما");
                        break;
                    case 22:
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        break;
                    case 26:
                        break;
                    case 27:
                        Result.Add("روز شعر و ادب فارسی، روز بزرگداشت استاد محمد حسین شهریار");
                        break;
                    case 28:
                        break;
                    case 29:
                        break;
                    case 30:
                        Result.Add("روز جهانی گفتگوی تمدن ها");
                        break;
                    case 31:
                        Result.Add("آغاز جنگ تحمیلی در سال 1359 شمسی و آغاز هفته دفاع مقدس");
                        break;
                }
            }

            #endregion

            #region month 7

            else if (month == 7)
            {
                switch (Day)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        Result.Add("شکست حصر آبادان در عملیات ثامن الائمه در سال 1360 شمسی");
                        break;
                    case 6:
                        break;
                    case 7:
                        Result.Add("روز آتش نشانی و ایمنی");
                        Result.Add("شهادت محمد جهان آرا و کلاهدوز و فلاحی و فکوری و نامجو در سال 1360 شمسی");
                        break;
                    case 8:
                        Result.Add("روز بزرگداشت مولانا");
                        break;
                    case 9:
                        Result.Add("روز همبستگی و همدردی با کودکان و نوجوانان فلسطینی");
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        Result.Add("هجرت حضرت امام خمینی از عراق به پاریس در سال 1357 شمسی");
                        Result.Add("روز نیروی انتظامی");
                        break;
                    case 14:
                        Result.Add("روز دامپزشکی");
                        break;
                    case 15:
                        break;
                    case 16:
                        Result.Add("روز بمباران شیمیائی صومار در سال 1366");
                        break;
                    case 17:
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        Result.Add("روز بزرگداشت حافظ");
                        Result.Add("روز اسکان معلولان و سالمندان ");
                        Result.Add("روز ملی کاهش اثرات بلایای طبیعی");
                        break;
                    case 21:
                        break;
                    case 22:
                        break;
                    case 23:
                        Result.Add("شهادت پنجمین شهید مهراب آیت الله اشرفی اصفهانی به دست منافقین در سال 1361 شمسی");
                        break;
                    case 24:
                        Result.Add("روز پیوند اولیاء و مربیان");
                        break;
                    case 25:
                        break;
                    case 26:
                        Result.Add("روز تربیت بدنی و ورزش");
                        break;
                    case 27:
                        break;
                    case 28:
                        break;
                    case 29:
                        Result.Add("روز صادرات");
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 8

            else if (month == 8)
            {
                switch (Day)
                {
                    case 1:
                        Result.Add("روز آمار و برنامه ریزی");
                        Result.Add("شهادت مظلومانه آیت الله حاج سید مصطفی خمینی در سال 1356 شمسی");
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        Result.Add("اعتراض و افشاگری حضرت امام خمینی علیه پذیرش کاپیتولاسیون در سال 1343 شمسی");
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        Result.Add("شهادت محمد حسین فهمیده و روز نوجوان و روز بسیج دانش آموزی");
                        break;
                    case 9:
                        break;
                    case 10:
                        Result.Add("شهادت آیت الله قاضی طباطبائی اولین شهید مهراب به دست منافقان در سال 1358 شمسی");
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        Result.Add("تبعید حضرت امام خمینی از ایران به ترکیه");
                        Result.Add("تسخیر لانه جاسوسی آمریکا به دست دانشجویان پیرو خط امام در سال 1358 شمسی");
                        Result.Add("روز ملی مبارزه با استکبار جهانی و روز دانش آموز");
                        break;
                    case 14:
                        Result.Add("روز فرهنگ عمومی");
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        Result.Add("روز ملی کیفیت");
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case 21:
                        break;
                    case 22:
                        Result.Add("شهادت سید علی اندرزگو به دست ماموران ستم شاهی پهلوی در سال 1357 شمسی");
                        break;
                    case 23:
                        break;
                    case 24:
                        Result.Add("روز کتاب و کتابخوانی");
                        Result.Add("روز بزرگداشت آیت الله سید محمد حسین طباطبائی");
                        Result.Add("تصویب قانون اساسی جمهوری اسلامی ایران در سال 1358");
                        break;
                    case 25:
                        Result.Add("ستارخان سردار ملي قهرمان بنام مشروطيت درگذشت در سال 1293 شمسی");
                        break;
                    case 26:
                        break;
                    case 27:
                        break;
                    case 28:
                        Result.Add("روز تکریم بازنشستگان");
                        break;
                    case 29:
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 9

            else if (month == 9)
            {
                switch (Day)
                {
                    case 1:
                        Result.Add("آغاز هفته بسیج");
                        break;
                    case 2:
                        break;
                    case 3:
                        Result.Add("شهادت مظلومانه زائران خانه خدا به دست ماموران ال سعود در سال 1366 شمسی");
                        break;
                    case 4:
                        break;
                    case 5:
                        Result.Add("روز بسیج مستضعفان و تشکیل بسیج مستضعفان به فرمان حضرت امام خمینی در سال 1358 شمسی");
                        break;
                    case 6:
                        break;
                    case 7:
                        Result.Add("روز نیروی دریائی");
                        break;
                    case 8:
                        break;
                    case 9:
                        Result.Add("روز بزرگداشت شیخ مفید");
                        break;
                    case 10:
                        Result.Add("شهادت آیت الله سید حسن مدرس در سال 1316 شمسی و روز مجلس");
                        break;
                    case 11:
                        Result.Add("شهادت میرزا کوچک خان جنگلی در سال 1300 شمسی");
                        break;
                    case 12:
                        Result.Add("تصویب قانون اساسی جمهوری اسلامی در سال 1358 شمسی");
                        break;
                    case 13:
                        Result.Add("روز بیمه");
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        Result.Add("روز دانشجو");
                        break;
                    case 17:
                        break;
                    case 18:
                        Result.Add("معرفی عراق به عنوان مسئول و آغازگر جنگ از سوی سازمان ملل در سال 1370 شمسی");
                        break;
                    case 19:
                        Result.Add("تشکیل شورای عالی انقلاب فرهنگی به فرمان امام خمینی در سال 1363 شمسی");
                        break;
                    case 20:
                        Result.Add("شهادت آیت الله دستغیب سومین شهید محراب به دست منافقین کور دل در سال 1360 شمسی");
                        Result.Add("آغاز هفته پژوهش و فناوری");
                        break;
                    case 21:
                        break;
                    case 22:
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        Result.Add("روز پژوهش، روز تجلیل از شهید تندگویان");
                        break;
                    case 26:
                        Result.Add("روز حمل و نقل");
                        break;
                    case 27:
                        Result.Add("شهادت ایت الله دکتر محمد مفتح در سال 1358 شمسی و روز وحدت حوزه و دانشگاه");
                        break;
                    case 28:
                        break;
                    case 29:
                        break;
                    case 30:
                        Result.Add("شب یلدا");
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 10

            else if (month == 10)
            {
                switch (Day)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        Result.Add("روز ملی ایمنی در برابر زلزله");
                        break;
                    case 6:
                        break;
                    case 7:
                        Result.Add("روز تجلیل از اسرا و مفقودان");
                        Result.Add("سالروز تشکیل نهضت سواد آموزی به فرمان حضرت امام خمینی در سال 1358 شمسی");
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        Result.Add("ابلاغ پیام تاریخی حضرت امام خمینی به گورباچف رهبر شوروی سابق در سال 1367 شمسی");
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                    case 17:
                        Result.Add("اجرای طرح کشف حجاب توسط رضا خان در سال 1314 شمسی");
                        break;
                    case 18:
                        break;
                    case 19:
                        Result.Add("قیام خونین مردم قم در سال 1356 شمسی");
                        Result.Add("آغاز عملیات کربلای 5");
                        break;
                    case 20:
                        Result.Add("شهادت میرزا امیر خان امیر کبیر در سال 1230 شمسی");
                        break;
                    case 21:
                        break;
                    case 22:
                        Result.Add("تشکیل شورای انقلاب به فرمان امام خمینی در سال 1357 شمسی");
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        break;
                    case 26:
                        Result.Add("فرار شاه معدوم در سال 1357 شمسی");
                        break;
                    case 27:
                        Result.Add("شهادت نواب صفوی در سال 1334 شمسی");
                        break;
                    case 28:
                        break;
                    case 29:
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 11

            else if (month == 11)
            {
                switch (Day)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        Result.Add("انتخاب اولین دوره ریاست جمهوری در سال 1358 شمسی");
                        break;
                    case 6:
                        Result.Add("سالروز حماسه مردم آمل و قیام علیه شاه");
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        Result.Add("بازگشت حضرت امام خمینی به ایران در سال 1357 شمسی و آغاز دهه فجر انقلاب اسلامی");
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        break;
                    case 19:
                        Result.Add("روز نیروی هوائی");
                        break;
                    case 20:
                        Result.Add("آغاز عملیات والفجر 8");
                        break;
                    case 21:
                        Result.Add("شکسته شدن حکومت نظامی به فرمان امام خمینی در سال 1357 شمسی");
                        break;
                    case 22:
                        Result.Add("روز انقلاب اسلامی ایران و سقوط نظام شاهنشاهیدر سال 1357 شمسی");
                        break;
                    case 23:
                        Result.Add("روز وقف");
                        break;
                    case 24:
                        break;
                    case 25:
                        Result.Add("صدور حکم ارتداد سلمان رشدی نویسنده کتاب ایات شیطانی توسط امام خمینی در سال 1367 شمسی");
                        break;
                    case 26:
                        break;
                    case 27:
                        break;
                    case 28:
                        break;
                    case 29:
                        Result.Add("روز سپندار مزگان روز عشق ایرانی");
                        Result.Add("قیام مردم تبریز به مناسبت چهلمین روز شهادت شهدای قم در سال 1356 شمسی");
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 12

            else if (month == 12)
            {
                switch (Day)
                {
                    case 1:
                        Result.Add("شهادت آیت الله محلاتی");
                        break;
                    case 2:
                        break;
                    case 3:
                        Result.Add("کودتای انگلیسی رضاخان در سال 1299 شمسی");
                        break;
                    case 4:
                        break;
                    case 5:
                        Result.Add("روز بزرگداشت خواجه نصیرالدین طوسی و روز مهندسی");
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        Result.Add("روز ملی حمایت از حقوق مصرف کنندگان");
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        Result.Add("روز احسان و نیکوکاری");
                        break;
                    case 15:
                        Result.Add("روز درختکاری");
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        Result.Add("روز بزرگداشت سید جمال الدین اسد آبادی");
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case 21:
                        break;
                    case 22:
                        Result.Add("روز بزرگداشت شهدا و سالروز صدور فرمان حضرت امام خمینی مبنی بر تاسیس بنیاد شهید انقلاب اسلامی در سال 1358 شمسی");
                        break;
                    case 23:
                        break;
                    case 24:
                        Result.Add("برگزاری انتخابات اولین دوره مجلس شورای اسلامی در سال 1358 شمسی");
                        break;
                    case 25:
                        Result.Add("بمباران شیمیائی حلبچه توسط رژیم بعث عراق در سال 1366 شمسی");
                        Result.Add("روز بزرگداشت پروین اعتصامی");
                        break;
                    case 26:
                        break;
                    case 27:
                        break;
                    case 28:
                        break;
                    case 29:
                        Result.Add("روز ملی شدن صنعت نفت در سال 1329 شمسی");
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            return Result;

        }

        public static List<string> GetEventHijriDate(this DateTime source)
        {
            List<string> Result = new List<string>();
            int month = source.GetMonth(SB.Tools.DateTime.CalendarType.HijriCalendar);
            int Day = source.GetDayOfMonth(SB.Tools.DateTime.CalendarType.HijriCalendar);

            #region month 1

            if (month == 1)
            {
                switch (Day)
                {
                    case 1:
                        Result.Add("آغاز سال جدید تقویم قمری");
                        Result.Add("آغاز هفته احیای امر به معروف و نهی از منکر");
                        break;
                    case 2:
                        Result.Add("ورود امام حسین و یارانش به دشت کربلا در سال 61 قمری");
                        break;
                    case 3:
                        Result.Add("ورود عمر سعد ملعون و یارانش به دشت کربلا در سال 61 قمری");
                        break;
                    case 4:
                        Result.Add("خطبه خواندن ابن زیاد در مسجد کوفه در جهت دعوت مردم برای به شهادنت رساندن امام حسین ");
                        break;
                    case 5:
                        break;
                    case 6:
                        Result.Add("شهادت حضرت یحیی علیه السلام");
                        Result.Add("وفات سید رضی رحمت الله الیه گردآوردنده نهج البلاغه در سال 406 قمری");
                        break;
                    case 7:
                        Result.Add("بستن آب به روی امام حسین و یارانش توسط عمر سعد ملعون در سال 61 قمری");
                        break;
                    case 8:
                        break;
                    case 9:
                        Result.Add("تاسوعای حسینی");
                        Result.Add("حضور سپاهیان شمر ملعون به صحرای کربلا برای جنگ با امام حسین در سال 61 قمری");
                        break;
                    case 10:
                        Result.Add("عاشورای حسینی - شهادت امام حسین و یارانش در سال 61 قمری");
                        break;
                    case 11:
                        Result.Add("عبور بازماندگان کاروان اسیران واقعه کربلا از قتلگاه به کوفه در سال 61 قمری");
                        break;
                    case 12:
                        Result.Add("شهادت امام سجاد به روایتی در سال 95 قمری");
                        break;
                    case 13:
                        Result.Add("آوردن اهل البیت امام حسین به مجلس ابن زیاد ملعون در سال 61 قمری");
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        Result.Add("حرکت سرهای مطهر شهدای کربلا از کوفه به شام در سال 61 قمری");
                        break;
                    case 17:
                        break;
                    case 18:
                        Result.Add("تغییر قبله مسلمین از بیت المقدس به کعبه در سال 2 قمری در مکه");
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case 21:
                        break;
                    case 22:
                        Result.Add("وفات شیخ طوسی عالم بزرگ شیعی موسس حوزه علمیه نجف اشرف در سال 406 قمری");
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        Result.Add("شهادت امام سجاد علیه السلام به روایتی در سال 95 قمری");
                        break;
                    case 26:
                        break;
                    case 27:
                        break;
                    case 28:
                        Result.Add("انقراض دولت بنی عباس باقتل خلیفه مستعصم عباسی توسط هلاکوخان در سال 656 قمری");
                        break;
                    case 29:
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 2

            else if (month == 2)
            {
                switch (Day)
                {
                    case 1:
                        Result.Add("آغاز جنگ صفین در سال 37 قمری");
                        Result.Add("ورود کاروان اسیران واقعه کربلا به شام در سال 61 قمری");
                        Result.Add("شهادت زید بن علی علیه السلام در سال 121 قمری");
                        break;
                    case 2:
                        break;
                    case 3:
                        Result.Add("ولادت امام محمد باقر به روایتی در سال 57 قمری");
                        break;
                    case 4:
                        break;
                    case 5:
                        Result.Add("شهادت حضرت رقیه در سال 61 قمری");
                        Result.Add("تبعید امام جواد از مدینه به بغداد");
                        break;
                    case 6:
                        break;
                    case 7:
                        Result.Add("ولادت حضرت امام موسی کاظم در سال 128 قمری");
                        break;
                    case 8:
                        Result.Add("وفات جناب سلمان فارسی در سال 35 قمری");
                        break;
                    case 9:
                        Result.Add("شهادت عمار یاسر درجنگ صفین در سال 35 قمری");
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case 21:
                        break;
                    case 22:
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        break;
                    case 26:
                        break;
                    case 27:
                        break;
                    case 28:
                        Result.Add("رحلت رسول اکرم 'ص' در سال 11 قمری");
                        Result.Add("شهادت امام حسن مجتبی در سال 50 قمری");
                        break;
                    case 29:
                        Result.Add("شهادت امام رضا علیه اسلام در سال 203 قمری");
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 3

            else if (month == 3)
            {
                switch (Day)
                {
                    case 1:
                        Result.Add("مهاجرت حضرت رسول اکرم از مکه به مدینه در سال 1 قمری");
                        Result.Add("لیله المبیت یا شبی که حضرت علی بر بستر حضرت رسول اکرم خوابید در سال 1 قمری");
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        Result.Add("رفتن حضرت رسول اکرم در غار ثور در سال 1 قمری");
                        break;
                    case 5:
                        Result.Add("وفات حضرت سکینه در سال 117 قمری");
                        break;
                    case 6:
                        Result.Add("سالروز تولد مولانا جلال الدین محمد بلخی در بلخ  در سال 604 قمری");
                        break;
                    case 7:
                        break;
                    case 8:
                        Result.Add("شهادت امام حسن عسگری و به امامت رسیدن حضرت مهدی در سال 260 قمری");
                        break;
                    case 9:
                        break;
                    case 10:
                        Result.Add("وفات جناب عبدالمطلب جد رسول خدا در سال 45 قبل از هجرت قمری");
                        break;
                    case 11:
                        break;
                    case 12:
                        Result.Add("میلاد مبارک پیامبر اسلام و عام الفیل به روایت اهل سنت در سال 53 قبل از هجرت قمری  و 570 میلادی و آغاز هفته وحدت");
                        break;
                    case 13:
                        break;
                    case 14:
                        Result.Add("هلاکت یزیدبن معاویه ملعون در سال 64 قمری");
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                    case 17:
                        Result.Add("میلاد مبارک پیامبر اسلام و عام الفیل در سال 53 قبل از هجرت قمری  و 570 میلادی و آغاز هفته وحدت");
                        Result.Add("میلاد حضرت امام صادق در سال 83 قمری");
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case 21:
                        break;
                    case 22:
                        Result.Add("غزوه بنی نضیر وبخشیدن فدک از حضرت محمد به حضرت فاطمه در سال 4 قمری");
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        break;
                    case 26:
                        Result.Add("صلح امام حسن 'ع' با معاویه در سال 41 قمری");
                        break;
                    case 27:
                        break;
                    case 28:
                        break;
                    case 29:
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 4

            else if (month == 4)
            {
                switch (Day)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        Result.Add("ولادت امام حسن عسگری در سال 232 قمری");
                        break;
                    case 9:
                        break;
                    case 10:
                        Result.Add("وفات حضرت معصومه در سال 201 قمری");
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        Result.Add("قیام مختار ثقفی به خونخواهی امام حسین در سال 66 قمری");
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case 21:
                        break;
                    case 22:
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        break;
                    case 26:
                        break;
                    case 27:
                        break;
                    case 28:
                        break;
                    case 29:
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 5

            else if (month == 5)
            {
                switch (Day)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        Result.Add("ولادت حضرت زینب در سال 5 قمری و روز پرستار");
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        Result.Add("جنگ جمل در سال 36 قمری");
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        Result.Add("شهادت مظلومانه حضرت فاطمه زهرا به روایتی در سال 11 قمری");
                        break;
                    case 14:
                        break;
                    case 15:
                        Result.Add("میلاد حضرت امام سجاد به روایتی در سال 38 قمری");
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case 21:
                        break;
                    case 22:
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        break;
                    case 26:
                        break;
                    case 27:
                        break;
                    case 28:
                        break;
                    case 29:
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 6

            else if (month == 6)
            {
                switch (Day)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        Result.Add("شهادت مظلومانه حضرت فاطمه زهرا به روایتی در سال 11 قمری");
                        break;
                    case 4:
                        break;
                    case 5:
                        Result.Add("وفات مولانا جلال الدین محمد بلخی در قونیه در سن 68 سالگی در سال 672 قمری");
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        Result.Add("وفات حضرت ام البنین مادر حضرت ابوالفضل در سال 64 قمری");
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        Result.Add("رحلت فقیه عالیقدر آیت الله شیخ مرتضی انصاری ملقب به استاد المتاخرین در سال 1281 قمری");
                        break;
                    case 19:
                        break;
                    case 20:
                        Result.Add("میلاد فرخنده حضرت فاطمه زهرا در سال 8 قبل از هجرت قمری");
                        Result.Add("ولادت حضرت امام خمینی در سال 1320 قمری");
                        break;
                    case 21:
                        break;
                    case 22:
                        break;
                    case 23:
                        break;
                    case 24:
                        Result.Add("رحلت حضرت آیت الله العظمی سید محمد رضا گلپایگانی در سال 1414 قمری");
                        break;
                    case 25:
                        Result.Add("رحلت حضرت آیت الله العظمی شیخ محمد علی اراکی در سال 1415 قمری");
                        break;
                    case 26:
                        Result.Add("دیدار شمس الدین محمد بن ملک داد تبریزی با مولانا و متحول شدن مولانا در سال 642 قمری");
                        break;
                    case 27:
                        break;
                    case 28:
                        break;
                    case 29:
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 7

            else if (month == 7)
            {
                switch (Day)
                {
                    case 1:
                        Result.Add("ولادت امام محمد باقر به روایتی در سال 57 قمری");
                        break;
                    case 2:
                        break;
                    case 3:
                        Result.Add("شهادت امام علی النقی 'امام هادی' در سال 254 قمری");
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        Result.Add("فتح مصر به دست سپاهیان اسلام در سال 20 قمری");
                        break;
                    case 9:
                        Result.Add("ولادت حضرت علی اصغر در سال 60 قمری");
                        break;
                    case 10:
                        Result.Add("میلاد مبارک امام محمد تقی 'امام جواد' در سال 195 قمری");
                        break;
                    case 11:
                        break;
                    case 12:
                        Result.Add("ورود حضرت علی 'ع' به شهر کوفه در سال 36 قمری");
                        break;
                    case 13:
                        Result.Add("میلاد مسعود امام علی 'ع' در داخل خانه خدا در سال 23 قبل از هجرت قمری");
                        Result.Add("آغاز ایام اعتکاف");
                        break;
                    case 14:
                        break;
                    case 15:
                        Result.Add("وفات حضرت زینب در سال 62 قمری");
                        Result.Add("هلاکت معاویه ملعون در سال 60 قمری");
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        break;
                    case 19:
                        Result.Add("درگذشت شاه اسماعیل صفوی موسس صفویان در سال 930 قمری");
                        break;
                    case 20:
                        break;
                    case 21:
                        break;
                    case 22:
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        Result.Add("شهادت باب الحوائج امام موسی کاظم در سال 183 قمری");
                        break;
                    case 26:
                        break;
                    case 27:
                        Result.Add("بعثت مبارک حضرت رسول اکرم در سال 13 قبل از هجرت قمری");
                        break;
                    case 28:
                        Result.Add("حرکت امام حسین از مدینه به طرف مکه قمری برای قیام بر علیه یزید در سال 60");
                        break;
                    case 29:
                        Result.Add("وفات حضرت خدیجه بروایتی 3 سال قبل از هجرت قمری");
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 8

            else if (month == 8)
            {
                switch (Day)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        Result.Add("میلاد مسعود حضرت امام حسین در سال 4 قمری و روز پاسدار");
                        break;
                    case 4:
                        Result.Add(" میلاد مسعود حضرت ابوالفضل العباس در سال 26 قمری و روز جانباز");
                        break;
                    case 5:
                        Result.Add("میلاد باسعادت حضرت امام سجاد در سال 38 قمری");
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        Result.Add("میلاد مسعود حضرت علی اکبر در سال 33 قمری و روز جوان");
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        Result.Add("میلاد فرخنده حضرت حجت بن الحسن در سال 255 قمری و روز مستضعفین");
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        break;
                    case 19:
                        Result.Add("غزوه بنی المصطلق در سال 6 قمری");
                        break;
                    case 20:
                        break;
                    case 21:
                        break;
                    case 22:
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        break;
                    case 26:
                        break;
                    case 27:
                        break;
                    case 28:
                        break;
                    case 29:
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 9

            else if (month == 9)
            {
                switch (Day)
                {
                    case 1:
                        break;
                    case 2:
                        Result.Add("تفویض ولایتعهدی حضرت امام رضا در سال 201 قمری");
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        Result.Add("بیعت مردم با ولایتعهدی امام رضا در سال 201 قمری");
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        Result.Add("تاسیس تاریخ هجری شمسی توسط حکیم عمر خیام نیشابوری و در سال 471 قمری");
                        break;
                    case 10:
                        Result.Add("وفات حضرت خدیجه بروایتی سه سال قبل از هجرت");
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        Result.Add("قتل مختار ثقفی در سال 67 قمری");
                        break;
                    case 15:
                        Result.Add("ولادت کریم اهل البیت امام حسن مجتبی در سال 3 قمری");
                        Result.Add("اعزام و حرکت مسلم بن عقیل به کوفه در سال 60 قمری");
                        break;
                    case 16:
                        break;
                    case 17:
                        Result.Add("معراج مبارک پیامبر اسلام دز 6 ماه قبل از هجرت");
                        Result.Add("غزوه بدر در سال 2 قمری");
                        break;
                    case 18:
                        break;
                    case 19:
                        Result.Add("ضربت خوردن امام علی 'ع' درمسجد کوفه در نماز صبح در سال 40 قمری");
                        Result.Add("شب قدر");
                        break;
                    case 20:
                        break;
                    case 21:
                        Result.Add("شهادت امیر المومنین علی 'ع' براثر ضربت ابن ملجم مرادی ملعون در سال 40 قمری");
                        Result.Add("شب قدر");
                        break;
                    case 22:
                        break;
                    case 23:
                        Result.Add("شب قدر");
                        break;
                    case 24:
                        break;
                    case 25:
                        break;
                    case 26:
                        break;
                    case 27:
                        Result.Add("درگذشت علامه محمد باقر مجلسی مولف کتاب 'بحار الانوار' در سال 1110 قمری");
                        break;
                    case 28:
                        break;
                    case 29:
                        Result.Add("غزوه حنین در سال 8 قمری");
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 10

            else if (month == 10)
            {
                switch (Day)
                {
                    case 1:
                        Result.Add("عید سعید فطر");
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        Result.Add("ورود مسلم بن عقیل به کوفه وبیعت 18هزار نفری با آن جناب در سال 60 قمری");
                        break;
                    case 6:
                        break;
                    case 7:
                        Result.Add("غزوه احد در سال 3 قمری");
                        break;
                    case 8:
                        Result.Add("تخریب بقاع متبرکه ائمه بقیع توسط وهابیون در سال 1344 قمری");
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        Result.Add("شهادت حضرت حمزه عموی پیامبر'ص' درجنگ احد در سال 3 قمری");
                        Result.Add("وفات حضرت عبد العظیم حسنی در سال 252 قمری");
                        break;
                    case 16:
                        break;
                    case 17:
                        Result.Add("جنگ احزاب 'خندق' در سال 5 قمری");
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        Result.Add("تبعید امام موسی کاظم'ع' ازمدینه به عراق در سال 179 قمری");
                        break;
                    case 21:
                        Result.Add("فتح اندلس بدست سپاهیان اسلام در سال 92 قمری");
                        break;
                    case 22:
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        Result.Add("شهادت امام جعفر صادق در سال 148 قمری");
                        break;
                    case 26:
                        break;
                    case 27:
                        break;
                    case 28:
                        break;
                    case 29:
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 11

            else if (month == 11)
            {
                switch (Day)
                {
                    case 1:
                        Result.Add("ولادت فرخنده حضرت معصومه سال 173 قمری");
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        Result.Add("ولادت باسعادت امام رضا در سال 148 قمری");
                        break;
                    case 17:
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case 21:
                        break;
                    case 22:
                        break;
                    case 23:
                        Result.Add("غزوه بنی قریظه در سال 5 قمری");
                        break;
                    case 24:
                        break;
                    case 25:
                        break;
                    case 26:
                        break;
                    case 27:
                        break;
                    case 28:
                        break;
                    case 29:
                        break;
                    case 30:
                        Result.Add("شهادت حضرت جواد الائمه امام محمد تقی سال 220 قمری");
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 12

            else if (month == 12)
            {
                switch (Day)
                {
                    case 1:
                        Result.Add("ازدواج مبارک وآسمانی حضرت علی'ع' وحضرت فاطمه'س' در سال 2 قمری و روز ازدواج و خانواده");
                        break;
                    case 2:
                        break;
                    case 3:
                        Result.Add("ورود پیامبر اسلام'ص' به مکه درسفر حج الوداع در سال 11 قمری");
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        Result.Add("شهادت امام محمد باقر العاوم در سال 114 قمری");
                        break;
                    case 8:
                        Result.Add("حرکت امام حسین 'ع' از مکه بسوی کوفه");
                        break;
                    case 9:
                        Result.Add("روز عرفه");
                        Result.Add("شهادت حضرت مسلم بن عقیل وهانی بن عروه در سال 60 قمری");
                        break;
                    case 10:
                        Result.Add("عید سعید قربان");
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        Result.Add("ولادت باسعادت امام علی النقی در سال 212 قمری");
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        Result.Add("عید سعید غدیر خم در سال 10 قمری");
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case 21:
                        break;
                    case 22:
                        Result.Add("شهادت جناب میثم تمار از یاران حضرت علی در سال 60 هجری");
                        break;
                    case 23:
                        break;
                    case 24:
                        Result.Add("جریان مباهله پیامبر اسلام 'ص' با مسیحیان نجران در سال 10 قمری");
                        Result.Add("روز انگشتر بخشیدن حضرت علی 'ع' به فقیری درنماز  در حالت رکوع");
                        break;
                    case 25:
                        break;
                    case 26:
                        break;
                    case 27:
                        break;
                    case 28:
                        break;
                    case 29:
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion


            #region HijriDate

            #endregion

            return Result;
        }

        public static List<string> GetEventChristianDate(this DateTime source)
        {
            List<string> Result = new List<string>();
            int month = source.GetMonth(SB.Tools.DateTime.CalendarType.ChristianCalendar);
            int Day = source.GetDayOfMonth(SB.Tools.DateTime.CalendarType.ChristianCalendar);

            #region month 1

            if (month == 1)
            {
                switch (Day)
                {
                    case 1:
                        Result.Add("آغاز سال جدید میلادی");
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        Result.Add("وفات گالیلئو گالیه ستاره شناس مشهور ایتالیائی در سن 78 سالگی در سال 1642 میلادی");
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case 21:
                        break;
                    case 22:
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        break;
                    case 26:
                        break;
                    case 27:
                        break;
                    case 28:
                        break;
                    case 29:
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 2

            else if (month == 2)
            {
                switch (Day)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        Result.Add("تولد توماس آلوا ادیسون تاجر و مخترع آمریکائی در سال 1847 میلادی");
                        break;
                    case 12:
                        break;
                    case 13:
                        Result.Add("حمله بمب افکن های سنگین انگلیس و آمریکا به شهر تسلیم شده درسدن و کشتار 40هزار غیر نظامی آلمانی در سال 1945 میلادی");
                        break;
                    case 14:
                        Result.Add("روز ولنتاین و شهادت Valentine مقدس");
                        break;
                    case 15:
                        Result.Add("تولد گایلئو گالیله ستاره شناس معروف ایتالیائی در سال 1564 میلادی");
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case 21:
                        Result.Add("روز جهانی زبان مادری");
                        break;
                    case 22:
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        break;
                    case 26:
                        break;
                    case 27:
                        break;
                    case 28:
                        break;
                    case 29:
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 3

            else if (month == 3)
            {
                switch (Day)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        Result.Add("تولد الگساندر گراهام بل دانشمند انگلیسی و مخترع تلفن در سال 1847 میلادی");
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        Result.Add("روز جهانی زن");
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        Result.Add("تولد آلبرت انیشتین نابغه بزرگ فیزیک در سال 1879 میلادی ");
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case 21:
                        break;
                    case 22:
                        Result.Add("روز جهانی آب");
                        break;
                    case 23:
                        Result.Add("روز جهانی هواشناسی");
                        break;
                    case 24:
                        break;
                    case 25:
                        break;
                    case 26:
                        break;
                    case 27:
                        break;
                    case 28:
                        break;
                    case 29:
                        break;
                    case 30:
                        break;
                    case 31:
                        Result.Add("وفات آیزاک نیوتن فیزیکدان معروف انگلیسی در سن 85 ساگی در سال 1727 میلادی");
                        break;
                }
            }

            #endregion

            #region month 4

            else if (month == 4)
            {
                switch (Day)
                {
                    case 1:
                        break;
                    case 2:
                        Result.Add("روز جهانی کتاب کودک");
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        Result.Add("روزی که آمریکا عملا وارد جنگ جهانی اول شد در سال 1917 میلادی");
                        break;
                    case 6:
                        break;
                    case 7:
                        Result.Add("روز جهانی بهداشت");
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        Result.Add("تولد لئوناردو داوینچی نقاش معروف ایتالیائی در سال 1452 میلادی");
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        Result.Add("وفات آلبرت انیشتین در سن 72 سالگی در سال 1955 میلادی");
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case 21:
                        break;
                    case 22:
                        break;
                    case 23:
                        break;
                    case 24:
                        Result.Add("براي نخستين بار در تاريخ جنگ هاي عمومي، آلمان ها در جنگ جهانی اول در سال 1915 از گازهاي شيميايي استفاده كردند ");
                        break;
                    case 25:
                        Result.Add("وفات الکساندر گراهام بل دانشمند انگلیسی مخترع تلفن در سن 75 سالگی در سال 1922 میلادی");
                        break;
                    case 26:
                        break;
                    case 27:
                        break;
                    case 28:
                        break;
                    case 29:
                        break;
                    case 30:
                        Result.Add("خودکشی هیتلر در قرار گاه زیر زمینیش در سال 1945 میلادی");
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 5

            else if (month == 5)
            {
                switch (Day)
                {
                    case 1:
                        Result.Add("روز جهانی کارگر");
                        break;
                    case 2:
                        Result.Add("وفات لئوناردو داوینچی نقاش معروف ایتالیائی در سن 67 سالگی در سال 1519 میلادی");
                        break;
                    case 3:
                        Result.Add("روز جهانی آزادی مطبوعات");
                        break;
                    case 4:
                        break;
                    case 5:
                        Result.Add("روز جهانی ماما");
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        Result.Add("روز جهانی صلیب سرخ و حلال احمر");
                        Result.Add("تسلیم شدن بی قید و شرط آلمان در جنگ جهانی دوم در سال 1945 میلادی");
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        Result.Add("روز جهانی پرستار");
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        Result.Add("روز جهانی موزه و میراث فرهنگی");
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case 21:
                        break;
                    case 22:
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        break;
                    case 26:
                        break;
                    case 27:
                        break;
                    case 28:
                        break;
                    case 29:
                        break;
                    case 30:
                        break;
                    case 31:
                        Result.Add("روز جهانی بدون دخانیات");
                        break;
                }
            }

            #endregion

            #region month 6

            else if (month == 6)
            {
                switch (Day)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        Result.Add("روز جهانی محیط زیست");
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        Result.Add("روز جهانی صنایع دستی");
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                    case 17:
                        Result.Add("روز جهانی بیایان زدائی");
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case 21:
                        break;
                    case 22:
                        Result.Add("حمله 5 میلیون سرباز المانی به خاک شوروی در جنگ جهانی دوم در سال 1941 میلادی");
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        break;
                    case 26:
                        Result.Add("روز جهانی مبارزه با مواد مخدر");
                        break;
                    case 27:
                        break;
                    case 28:
                        Result.Add("به قتل رسیدن ولیعهد اتریش و همسرش به دست جواب صربستانی در سارایوو که باعث اغاز جنگ جهانی اول شد در سال 1914 میلادی");
                        Result.Add("پایان جنگ جهانی اول با انعقاد صلح پاریس در سال 1919 میلادی");
                        break;
                    case 29:
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 7

            else if (month == 7)
            {
                switch (Day)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        Result.Add("روز جهانی کار و کارگر");
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case 21:
                        break;
                    case 22:
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        break;
                    case 26:
                        break;
                    case 27:
                        break;
                    case 28:
                        Result.Add("اعلام جنگ اتریش به صربستان و آغاز جنگ جهانی اول در سال 1914 میلادی");
                        break;
                    case 29:
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 8

            else if (month == 8)
            {
                switch (Day)
                {
                    case 1:
                        Result.Add("روز جهانی شیر مادر");
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        Result.Add("حمله اتمی آمریکا به شهر هیروشیمای ژاپن در سال 1945 میلادی");
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        Result.Add("حمله اتمی آمریکا به شهر ناکازوکی ژاپن در سال 1945 میلادی");
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        Result.Add("روز جهانی چپ دست ها");
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case 21:
                        break;
                    case 22:
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        break;
                    case 26:
                        break;
                    case 27:
                        break;
                    case 28:
                        break;
                    case 29:
                        break;
                    case 30:
                        break;
                    case 31:
                        Result.Add("تبدیل ایران به دو قسمت تحت نفوذ در شمال و جنوب و یک قسمت بی طرف در مرکز با قرارداد سنپترزبورگ روسیه و انگلیس در سال 1907 میلادی");
                        break;
                }
            }

            #endregion

            #region month 9

            else if (month == 9)
            {
                switch (Day)
                {
                    case 1:
                        Result.Add("اعلام جنگ جهانی دوم با اعلام جنگ آلمان به لهستان در سال 1939 میلادی");
                        break;
                    case 2:
                        Result.Add("امضای تسلیم نامه به قید و شرط نیروهای مسلح ژاپنی در عرشه رزم ناو آمریکائی میسوری در جنگ جهانی دوم در سال 1945 میلادی");
                        break;
                    case 3:
                        Result.Add("اعلان جنگ انگلیس و فرانسه به آلمان بعد از حمله این کشور به لهستان در جنگ جهانی دوم در سال 1939 میلادی");
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case 21:
                        Result.Add("روز جهانی آلزایمر");
                        Result.Add("روز جهانی صلح");
                        break;
                    case 22:
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        break;
                    case 26:
                        break;
                    case 27:
                        Result.Add("روز جهانی جهانگردی");
                        break;
                    case 28:
                        break;
                    case 29:
                        break;
                    case 30:
                        Result.Add("روز جهانی ناشنوایان");
                        Result.Add("روز جهانی دریانوردی");
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 10

            else if (month == 10)
            {
                switch (Day)
                {
                    case 1:
                        Result.Add("حمله عثمانی به غرب ایران و تصرف مهاباد به بهانه حضور روس در ایران در سال 1914 میلادی");
                        Result.Add("روز جهانی سالمندان");
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        Result.Add("روز جهانی کودک");
                        break;
                    case 9:
                        Result.Add("روز جهانی پست");
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        Result.Add("روز جهانی استاندارد");
                        break;
                    case 15:
                        Result.Add("روز جهانی نابینایان");
                        break;
                    case 16:
                        Result.Add("روز جهانی غذا");
                        break;
                    case 17:
                        break;
                    case 18:
                        Result.Add("وفات توماس آلوا ادیسون تاجر و مخترع آمریکائی در سن 84 سالگی در سال 1931 میلادی");
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case 21:
                        break;
                    case 22:
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        break;
                    case 26:
                        break;
                    case 27:
                        break;
                    case 28:
                        break;
                    case 29:
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 11

            else if (month == 11)
            {
                switch (Day)
                {
                    case 1:
                        Result.Add("اعلام بی طرفی ایران در جنگ جهانی اول توسط احمد شاه در سال 1914");
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                    case 17:
                        Result.Add("روز جهانی دانش آموز");
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case 21:
                        break;
                    case 22:
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        Result.Add("روز جهانی رفع خشونت علیه زنان");
                        break;
                    case 26:
                        break;
                    case 27:
                        break;
                    case 28:
                        break;
                    case 29:
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 12

            else if (month == 12)
            {
                switch (Day)
                {
                    case 1:
                        Result.Add("روز جهانی مبارزه با ایدز");
                        break;
                    case 2:
                        break;
                    case 3:
                        Result.Add("روز جهانی معلولان");
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        Result.Add("روز جهانی هواپیمائی");
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        Result.Add("روز جهانی حقوق بشر");
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case 21:
                        break;
                    case 22:
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        Result.Add("تولد آیزاک نیوتن فیزیکدان معروف انگلیسی در سال 1642 میلادی");
                        break;
                    case 26:
                        break;
                    case 27:
                        break;
                    case 28:
                        break;
                    case 29:
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region Christian Date





            #endregion


            return Result;
        }

        public static List<string> GetEventHeberwDate(this DateTime source)
        {
            List<string> Result = new List<string>();
            int month = source.GetMonth(SB.Tools.DateTime.CalendarType.HebrewCalendar);
            int Day = source.GetDayOfMonth(SB.Tools.DateTime.CalendarType.HebrewCalendar);

            #region month 1

            if (month == 1)
            {
                switch (Day)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case 21:
                        break;
                    case 22:
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        break;
                    case 26:
                        break;
                    case 27:
                        break;
                    case 28:
                        break;
                    case 29:
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 2

            else if (month == 2)
            {
                switch (Day)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case 21:
                        break;
                    case 22:
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        break;
                    case 26:
                        break;
                    case 27:
                        break;
                    case 28:
                        break;
                    case 29:
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 3

            else if (month == 3)
            {
                switch (Day)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case 21:
                        break;
                    case 22:
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        break;
                    case 26:
                        break;
                    case 27:
                        break;
                    case 28:
                        break;
                    case 29:
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 4

            else if (month == 4)
            {
                switch (Day)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case 21:
                        break;
                    case 22:
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        break;
                    case 26:
                        break;
                    case 27:
                        break;
                    case 28:
                        break;
                    case 29:
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 5

            else if (month == 5)
            {
                switch (Day)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case 21:
                        break;
                    case 22:
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        break;
                    case 26:
                        break;
                    case 27:
                        break;
                    case 28:
                        break;
                    case 29:
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 6

            else if (month == 6)
            {
                switch (Day)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case 21:
                        break;
                    case 22:
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        break;
                    case 26:
                        break;
                    case 27:
                        break;
                    case 28:
                        break;
                    case 29:
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 7

            else if (month == 7)
            {
                switch (Day)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case 21:
                        break;
                    case 22:
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        break;
                    case 26:
                        break;
                    case 27:
                        break;
                    case 28:
                        break;
                    case 29:
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 8

            else if (month == 8)
            {
                switch (Day)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case 21:
                        break;
                    case 22:
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        break;
                    case 26:
                        break;
                    case 27:
                        break;
                    case 28:
                        break;
                    case 29:
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 9

            else if (month == 9)
            {
                switch (Day)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case 21:
                        break;
                    case 22:
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        break;
                    case 26:
                        break;
                    case 27:
                        break;
                    case 28:
                        break;
                    case 29:
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 10

            else if (month == 10)
            {
                switch (Day)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case 21:
                        break;
                    case 22:
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        break;
                    case 26:
                        break;
                    case 27:
                        break;
                    case 28:
                        break;
                    case 29:
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 11

            else if (month == 11)
            {
                switch (Day)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case 21:
                        break;
                    case 22:
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        break;
                    case 26:
                        break;
                    case 27:
                        break;
                    case 28:
                        break;
                    case 29:
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region month 12

            else if (month == 12)
            {
                switch (Day)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case 21:
                        break;
                    case 22:
                        break;
                    case 23:
                        break;
                    case 24:
                        break;
                    case 25:
                        break;
                    case 26:
                        break;
                    case 27:
                        break;
                    case 28:
                        break;
                    case 29:
                        break;
                    case 30:
                        break;
                    case 31:
                        break;
                }
            }

            #endregion

            #region Christian Date

            #endregion

            return Result;
        }

        public static string GetEvents(this DateTime source, string strBetweenEvery)
        {
            string strResult = string.Empty;

            List<string> lst = source.GetEvents_PersianDate();
            foreach (string item in lst)
            {
                strResult += item + strBetweenEvery;
            }

            lst = source.GetEventChristianDate();
            foreach (string item in lst)
            {
                strResult += item + strBetweenEvery;
            }

            lst = source.GetEventHijriDate();
            foreach (string item in lst)
            {
                strResult += item + strBetweenEvery;
            }

            lst = source.GetEventHeberwDate();
            foreach (string item in lst)
            {
                strResult += item + strBetweenEvery;
            }

            if (!string.IsNullOrEmpty(strResult))
            {
                strResult.Remove(strResult.Length - strBetweenEvery.Length);
            }
            return strResult;
        }

        #endregion //Define Events of Calendar

        #region --> Messages

        /// <summary>
        /// این متد پیام لحظه جاری را باز می گرداند مثل صبح بخیر و یا شب بخیر
        /// </summary>
        public static string GetMessageHours(this DateTime source, string UserName)
        {
            string strResult = Texts.GoodTime + " " + UserName;
            if (source.GetMonth(SB.Tools.DateTime.CalendarType.PersianCalendar) >= 1 && source.GetMonth(SB.Tools.DateTime.CalendarType.PersianCalendar) <= 6)
            {
                source = source.AddHours(-1);
            }

            if (source.Hour >= 4 && source.Hour <= 10)
            {
                strResult = Texts.GoodMorning + " " + UserName;
            }
            else if (source.Hour >= 11 && source.Hour <= 13)
            {
                strResult = Texts.GoodAfternoon + " " + UserName;
            }
            else if (source.Hour >= 14 && source.Hour <= 17)
            {
                strResult = Texts.GoodEvening + " " + UserName;
            }
            else if (source.Hour >= 8 && source.Hour <= 12)
            {
                strResult = Texts.GoodNight + " " + UserName;
            }

            return strResult;
        }

        #endregion //Messages

        #region --> Prayer Time

        /// <summary>
        /// برای محاسبه اوقات شرعی استفاده می شود
        /// و یک لیست از دیت تایم ها را باز می گرداند که به ترتیب معرف اوقات مختلف هستند
        /// <para>ایندکس 0 : اذان صبح</para>
        /// <para>ایندکس 1 : طلوع آفتاب</para>
        /// <para>ایندکس 2 : اذان ظهر</para>
        /// <para>ایندکس 3 : غروب آفتاب</para>
        /// <para>ایندکس 4 : اذان مغرب</para>
        /// <para>ایندکس 5 : نیمه شب شرعی</para>
        /// </summary>
        /// <param name="longitude">طول جغرافیائی</param>
        /// <param name="latitude">عرض جغرافیائی</param>
        /// <param name="objDate">تاریخ روزی که می خواهید اوقات شرعی محاسبه شود</param>
        public static List<DateTime> GetPrayerTimes(this DateTime source, double longitude, double latitude)
        {
            source = new DateTime(source.Year, source.Month, source.Day);
            System.Globalization.PersianCalendar objPersianCalendar = new System.Globalization.PersianCalendar();
            int PersianDayOfYear = objPersianCalendar.GetDayOfYear(source);
            double ChangeAngle = 23.45 * Math.Sin(2 * Math.PI * PersianDayOfYear / 365);
            double DC = 2 * Math.PI / 365;
            double ConstDay = DC * (source.DayOfYear + 10) + 0.033 * Math.Sin(DC * (source.DayOfYear - 2));
            double eqt = -1 * (9.8 * Math.Sin(2 * ConstDay) + 7.6 * Math.Sin(ConstDay - 0.2));

            int HourIsAdd = (objPersianCalendar.GetMonth(source) < 7 && objPersianCalendar.GetMonth(source) > 0) ? 1 : 0;
            double ZOHR = 12 + HourIsAdd + (3.5 - (longitude / 15)) - (eqt / 60);
            DateTime objTempDateTime = source;

            List<DateTime> objResultList = new List<DateTime>();

            //اذان صبح
            DateTime objDateTimeAzanSobh = objTempDateTime.AddHours(ZOHR - T_ForParyerTime(17.8, latitude, ChangeAngle));
            objResultList.Add(objDateTimeAzanSobh);
            objTempDateTime = source;

            //طلوع آفتاب
            objResultList.Add(objTempDateTime.AddHours(ZOHR - T_ForParyerTime(0.8333, latitude, ChangeAngle)));
            objTempDateTime = source;

            //اذان ظهر
            objResultList.Add(objTempDateTime.AddHours(ZOHR));
            objTempDateTime = source;

            //غروب آفتاب
            DateTime objDateTimeGhrobAftab = objTempDateTime.AddHours(ZOHR + T_ForParyerTime(0.8333, latitude, ChangeAngle));
            objResultList.Add(objDateTimeGhrobAftab);
            objTempDateTime = source;

            //اذان مغرب
            objResultList.Add(objTempDateTime.AddHours(ZOHR + T_ForParyerTime(4, latitude, ChangeAngle)));
            objTempDateTime = source;

            //نمیمه شب شرعی
            TimeSpan distance = objDateTimeGhrobAftab - objDateTimeAzanSobh;
            objResultList.Add(objDateTimeGhrobAftab.AddSeconds((86400 - distance.TotalSeconds) / 2));
            return objResultList;
        }

        /// <summary>
        /// برای محاسبه اوقات شرعی استفاده می شود
        /// و یک لیست از رشته ها را باز می گرداند که به ترتیب معرف اوقات مختلف هستند
        /// <para>ایندکس 0 : اذان صبح</para>
        /// <para>ایندکس 1 : طلوع آفتاب</para>
        /// <para>ایندکس 2 : اذان ظهر</para>
        /// <para>ایندکس 3 : غروب آفتاب</para>
        /// <para>ایندکس 4 : اذان مغرب</para>
        /// <para>ایندکس 5 : نیمه شب شرعی</para>
        /// </summary>
        /// <param name="longitude">طول جغرافیائی</param>
        /// <param name="latitude">عرض جغرافیائی</param>
        /// <param name="objDate">تاریخ روزی که می خواهید اوقات شرعی محاسبه شود</param>
        public static List<string> GetPrayerTimesText(this DateTime source, double longitude, double latitude)
        {
            List<DateTime> objListDate = source.GetPrayerTimes(longitude, latitude);
            List<string> objResultText = new List<string>();
            objResultText.Add(Texts.AzanMorning + " =     ' " + objListDate[0].Minute + " : " + objListDate[0].Hour);
            objResultText.Add(Texts.Sunrise + " =   ' " + objListDate[1].Minute + " : " + objListDate[1].Hour);
            objResultText.Add(Texts.AzanPM + " =     ' " + objListDate[2].Minute + " : " + ((objListDate[2].Hour > 12) ? (objListDate[2].Hour - 12) : objListDate[2].Hour));
            objResultText.Add(Texts.Sunset + " =   ' " + objListDate[3].Minute + " : " + (objListDate[3].Hour - 12));
            objResultText.Add(Texts.AzanMorocco + " =    ' " + objListDate[4].Minute + " : " + (objListDate[4].Hour - 12));
            objResultText.Add(Texts.MidnightPrayer + " = ' " + objListDate[5].Minute + " : " + (objListDate[5].Hour));
            return objResultText;
        }

        public static string GetPrayerTimesTextResult(this DateTime source, double longitude, double latitude)
        {
            List<DateTime> objListDate = source.GetPrayerTimes(longitude, latitude);
            StringBuilder objResultText = new StringBuilder();
            objResultText.AppendLine(Texts.AzanMorning + " =     ' " + objListDate[0].Minute + " : " + objListDate[0].Hour);
            objResultText.AppendLine(Texts.Sunrise + " =   ' " + objListDate[1].Minute + " : " + objListDate[1].Hour);
            objResultText.AppendLine(Texts.AzanPM + " =     ' " + objListDate[2].Minute + " : " + ((objListDate[2].Hour > 12) ? (objListDate[2].Hour - 12) : objListDate[2].Hour));
            objResultText.AppendLine(Texts.Sunset + " =   ' " + objListDate[3].Minute + " : " + (objListDate[3].Hour - 12));
            objResultText.AppendLine(Texts.AzanMorocco + " =    ' " + objListDate[4].Minute + " : " + (objListDate[4].Hour - 12));
            objResultText.AppendLine(Texts.MidnightPrayer + " = ' " + objListDate[5].Minute + " : " + (objListDate[5].Hour));
            return objResultText.ToString();
        }

        private static double T_ForParyerTime(double dblParametr, double latitude, double ChangeAngle)
        {
            double r_dblParametr = dblParametr * Math.PI / 180;
            double r_latitude = latitude * Math.PI / 180;
            double r_ChangeAngle = ChangeAngle * Math.PI / 180;

            return (Math.Acos((-Math.Sin(r_dblParametr) - (Math.Sin(r_latitude) * Math.Sin(r_ChangeAngle))) / (Math.Cos(r_latitude) * Math.Cos(r_ChangeAngle))) * 180) / (15 * Math.PI);
        }

        #endregion //Prayer Time

        #region --> Weeks

        /// <summary>
        /// این متد شماره هفته در تاریخ را محاسبه می کند
        /// </summary>
        /// <returns></returns>
        public static int GetWeekNumberInMonth(this DateTime source, SB.Tools.DateTime.CalendarType calendarType, DayOfWeek startDayWeek)
        {
            int countDayInMonth = source.GetDaysInMonth(calendarType);
            DateTime firstDayOfMonth = ToDateTime(calendarType, source.GetYear(calendarType), source.GetMonth(calendarType), 1);
            int dayOfFirstStartDayWeek = 1 + (((int)startDayWeek >= (int)firstDayOfMonth.DayOfWeek) ? ((int)startDayWeek - (int)firstDayOfMonth.DayOfWeek) : (7 + (int)startDayWeek) - (int)firstDayOfMonth.DayOfWeek);

            int result = 1;
            int day = source.GetDayOfMonth(calendarType);

            if (dayOfFirstStartDayWeek == 1)
            {
                dayOfFirstStartDayWeek = 8;
            }

            while (true)
            {
                if (day < dayOfFirstStartDayWeek)
                {
                    break;
                }

                result++;
                dayOfFirstStartDayWeek += 7;
            }

            return result;
        }

        #endregion //Weeks

        public static SB.Tools.DateTime.Season GetSeason(this DateTime source)
        {
            int intMonth = source.GetMonth(SB.Tools.DateTime.CalendarType.PersianCalendar);
            if (intMonth <= 3)
            {
                return SB.Tools.DateTime.Season.Spring;
            }
            else if (intMonth <= 6)
            {
                return SB.Tools.DateTime.Season.Summer;
            }
            else if (intMonth <= 9)
            {
                return SB.Tools.DateTime.Season.Autumn;
            }
            else
            {
                return SB.Tools.DateTime.Season.Winter;
            }
        }

        public static string GetPersianSeasonName(this DateTime source)
        {
            switch (source.GetSeason())
            {
                case Season.Autumn:
                    return "پائیز";
                case Season.Spring:
                    return "بهار";
                case Season.Summer:
                    return "تابستان";
                case Season.Winter:
                    return "زمستان";
            }
            return String.Empty;
        }

        public static int GetDaysInMonth(this DateTime source, SB.Tools.DateTime.CalendarType calendarType)
        {
            switch (calendarType)
            {
                case SB.Tools.DateTime.CalendarType.PersianCalendar:
                    return SeifaeiBrothersDateTime.objPersianCalendar.GetDaysInMonth(source.GetYear(calendarType), source.GetMonth(calendarType));
                case SB.Tools.DateTime.CalendarType.HijriCalendar:
                    return SeifaeiBrothersDateTime.objHijriCalendar.GetDaysInMonth(source.GetYear(calendarType), source.GetMonth(calendarType));
                case SB.Tools.DateTime.CalendarType.HebrewCalendar:
                    return SeifaeiBrothersDateTime.objHebrewCalendar.GetDaysInMonth(source.GetYear(calendarType), source.GetMonth(calendarType));
                default:
                    return DateTime.DaysInMonth(source.Year, source.Month);
            }
        }

        public static string GetNameOfYear(this DateTime source, SB.Tools.DateTime.CalendarType calendarType)
        {
            return GetNameOfYear(source.GetYear(calendarType), calendarType);
        }

        public static string GetNameOfMonth(this DateTime source, SB.Tools.DateTime.CalendarType calendarType)
        {
            switch (calendarType)
            {
                case SB.Tools.DateTime.CalendarType.PersianCalendar:
                    return GetNameOfMonth_Persian(source.GetMonth(SB.Tools.DateTime.CalendarType.PersianCalendar));
                case SB.Tools.DateTime.CalendarType.HijriCalendar:
                    return GetNameOfMonth_Hijri(source.GetMonth(SB.Tools.DateTime.CalendarType.HijriCalendar));
                case SB.Tools.DateTime.CalendarType.HebrewCalendar:
                    return GetNameOfMonth_Hebrew(source.GetYear(SB.Tools.DateTime.CalendarType.HebrewCalendar), source.GetMonth(SB.Tools.DateTime.CalendarType.HebrewCalendar));
                default:
                    return GetNameOfMonth_Milady(source.GetMonth(SB.Tools.DateTime.CalendarType.ChristianCalendar));
            }
        }

        public static int GetYear(this DateTime source, SB.Tools.DateTime.CalendarType calendarType)
        {
            switch (calendarType)
            {
                case SB.Tools.DateTime.CalendarType.PersianCalendar:
                    return objPersianCalendar.GetYear(source);
                case SB.Tools.DateTime.CalendarType.HijriCalendar:
                    return objHijriCalendar.GetYear(source);
                case SB.Tools.DateTime.CalendarType.HebrewCalendar:
                    return objHebrewCalendar.GetYear(source);
                default:
                    return source.Year;
            }
        }

        public static int GetMonth(this DateTime source, SB.Tools.DateTime.CalendarType calendarType)
        {
            switch (calendarType)
            {
                case SB.Tools.DateTime.CalendarType.PersianCalendar:
                    return objPersianCalendar.GetMonth(source);
                case SB.Tools.DateTime.CalendarType.HijriCalendar:
                    return objHijriCalendar.GetMonth(source);
                case SB.Tools.DateTime.CalendarType.HebrewCalendar:
                    return objHebrewCalendar.GetMonth(source);
                default:
                    return source.Month;
            }
        }

        public static int GetDayOfMonth(this DateTime source, SB.Tools.DateTime.CalendarType calendarType)
        {
            switch (calendarType)
            {
                case SB.Tools.DateTime.CalendarType.PersianCalendar:
                    return objPersianCalendar.GetDayOfMonth(source);
                case SB.Tools.DateTime.CalendarType.HijriCalendar:
                    return objHijriCalendar.GetDayOfMonth(source);
                case SB.Tools.DateTime.CalendarType.HebrewCalendar:
                    return objHebrewCalendar.GetDayOfMonth(source);
                default:
                    return source.Day;
            }
        }

        public static int GetDayOfYear(this DateTime source, SB.Tools.DateTime.CalendarType calendarType)
        {
            switch (calendarType)
            {
                case SB.Tools.DateTime.CalendarType.PersianCalendar:
                    return objPersianCalendar.GetDayOfYear(source);
                case SB.Tools.DateTime.CalendarType.HijriCalendar:
                    return objHijriCalendar.GetDayOfYear(source);
                case SB.Tools.DateTime.CalendarType.HebrewCalendar:
                    return objHebrewCalendar.GetDayOfYear(source);
                default:
                    return source.DayOfYear;
            }
        }

        public static int GetMonthsInYear(this DateTime source, SB.Tools.DateTime.CalendarType calendarType)
        {
            return GetMonthsInYear(calendarType, source.GetYear(calendarType));
        }

        public static bool IsLeapDay(this DateTime source, SB.Tools.DateTime.CalendarType calendarType)
        {
            switch (calendarType)
            {
                case SB.Tools.DateTime.CalendarType.PersianCalendar:
                    return objPersianCalendar.IsLeapDay(source.GetYear(SB.Tools.DateTime.CalendarType.PersianCalendar), source.GetMonth(SB.Tools.DateTime.CalendarType.PersianCalendar), source.GetDayOfMonth(SB.Tools.DateTime.CalendarType.PersianCalendar));
                case SB.Tools.DateTime.CalendarType.HijriCalendar:
                    return objHijriCalendar.IsLeapDay(source.GetYear(SB.Tools.DateTime.CalendarType.HijriCalendar), source.GetMonth(SB.Tools.DateTime.CalendarType.HijriCalendar), source.GetDayOfMonth(SB.Tools.DateTime.CalendarType.HijriCalendar));
                case SB.Tools.DateTime.CalendarType.HebrewCalendar:
                    return objHebrewCalendar.IsLeapDay(source.GetYear(SB.Tools.DateTime.CalendarType.HebrewCalendar), source.GetMonth(SB.Tools.DateTime.CalendarType.HebrewCalendar), source.GetDayOfMonth(SB.Tools.DateTime.CalendarType.HebrewCalendar));
                default:
                    return false;
            }
        }

        public static bool IsLeapMonth(this DateTime source, SB.Tools.DateTime.CalendarType calendarType)
        {
            switch (calendarType)
            {
                case SB.Tools.DateTime.CalendarType.PersianCalendar:
                    return objPersianCalendar.IsLeapMonth(source.GetYear(SB.Tools.DateTime.CalendarType.PersianCalendar), source.GetMonth(SB.Tools.DateTime.CalendarType.PersianCalendar));
                case SB.Tools.DateTime.CalendarType.HijriCalendar:
                    return objHijriCalendar.IsLeapMonth(source.GetYear(SB.Tools.DateTime.CalendarType.HijriCalendar), source.GetMonth(SB.Tools.DateTime.CalendarType.HijriCalendar));
                case SB.Tools.DateTime.CalendarType.HebrewCalendar:
                    return objHebrewCalendar.IsLeapMonth(source.GetYear(SB.Tools.DateTime.CalendarType.HebrewCalendar), source.GetMonth(SB.Tools.DateTime.CalendarType.HebrewCalendar));
                default:
                    return false;
            }
        }

        public static bool IsLeapYear(this DateTime source, SB.Tools.DateTime.CalendarType calendarType)
        {
            switch (calendarType)
            {
                case SB.Tools.DateTime.CalendarType.PersianCalendar:
                    return objPersianCalendar.IsLeapYear(source.GetYear(SB.Tools.DateTime.CalendarType.PersianCalendar));
                case SB.Tools.DateTime.CalendarType.HijriCalendar:
                    return objHijriCalendar.IsLeapYear(source.GetYear(SB.Tools.DateTime.CalendarType.HijriCalendar));
                case SB.Tools.DateTime.CalendarType.HebrewCalendar:
                    return objHebrewCalendar.IsLeapYear(source.GetYear(SB.Tools.DateTime.CalendarType.HebrewCalendar));
                default:
                    return DateTime.IsLeapYear(source.GetYear(SB.Tools.DateTime.CalendarType.ChristianCalendar));
            }
        }

        /// <summary>
        /// این متد نام روزهای هفته را باز می گرداند
        /// </summary>
        /// <param name="PersianName">اگر می خواهیم نام روز بصورت فارسی بدست اید مقدار دستی و اگر می خواهیم بصورت لاتین بنویسیم مقدار نادرستی برای این پارامتر ارسال شود</param>
        /// <returns></returns>
        public static string GetNameOfDayInWeek(this DateTime source, bool shortName)
        {
            return GetNameOfDayInWeek(source.DayOfWeek, shortName);
        }

        /// <summary>
        /// این متد نام روزهای هفته را باز می گرداند
        /// </summary>
        /// <param name="PersianName">اگر می خواهیم نام روز بصورت فارسی بدست اید مقدار دستی و اگر می خواهیم بصورت لاتین بنویسیم مقدار نادرستی برای این پارامتر ارسال شود</param>
        /// <returns></returns>
        public static string GetNameOfDayInWeek(DayOfWeek dayOfWeek, bool shortName)
        {
            string result = string.Empty;

            if (shortName)
            {
                switch (dayOfWeek)
                {
                    case DayOfWeek.Friday: result = Texts.ShortNameFriday; break;
                    case DayOfWeek.Monday: result = Texts.ShortNameMonday; break;
                    case DayOfWeek.Saturday: result = Texts.ShortNameSaturday; break;
                    case DayOfWeek.Sunday: result = Texts.ShortNameSunday; break;
                    case DayOfWeek.Thursday: result = Texts.ShortNameThursday; break;
                    case DayOfWeek.Tuesday: result = Texts.ShortNameTuesday; break;
                    case DayOfWeek.Wednesday: result = Texts.ShortNameWednesday; break;
                }
            }
            else
            {
                switch (dayOfWeek)
                {
                    case DayOfWeek.Friday: result = Texts.NameFriday; break;
                    case DayOfWeek.Monday: result = Texts.NameMonday; break;
                    case DayOfWeek.Saturday: result = Texts.NameSaturday; break;
                    case DayOfWeek.Sunday: result = Texts.NameSunday; break;
                    case DayOfWeek.Thursday: result = Texts.NameThursday; break;
                    case DayOfWeek.Tuesday: result = Texts.NameTuesday; break;
                    case DayOfWeek.Wednesday: result = Texts.NameWednesday; break;
                }
            }

            return result;
        }

        /// <summary>
        /// در صورتی که تاریخ در محدوده تاریخ ساپورت شده قرار داشته باشد مقدار درستی باز می گرداند
        /// </summary>
        public static bool IsValid(this DateTime source, SB.Tools.DateTime.CalendarType calendarType)
        {
            return (source <= GetMaxSupportedDateTime(calendarType) && source >= GetMinSupportedDateTime(calendarType));
        }

        public static string ToString(this System.DateTime source, SB.Tools.DateTime.CalendarType calendarType, SB.Tools.DateTime.ToStringFormat format)
        {
            return ToString(source, calendarType, format, true);
        }

        public static string ToString(this System.DateTime source, SB.Tools.DateTime.CalendarType calendarType, SB.Tools.DateTime.ToStringFormat format, bool throwExceptionIfDateIsNotValid)
        {
            if (source.IsValid(calendarType))
            {
                int year = source.GetYear(calendarType);
                int month = source.GetMonth(calendarType);
                int day = source.GetDayOfMonth(calendarType);

                switch (format)
                {
                    case SB.Tools.DateTime.ToStringFormat.ShortDate:
                        return year.ToString("D4") + "/" + month.ToString("D2") + "/" + day.ToString("D2");
                    case SB.Tools.DateTime.ToStringFormat.ShortDateByMonthName:
                        return day.ToString("D2") + " " + source.GetNameOfMonth(calendarType) + " " + year.ToString("D4");
                    case SB.Tools.DateTime.ToStringFormat.ShortDateByMonthNameAndMonthNumber:
                        return day.ToString("D2") + " " + source.GetNameOfMonth(calendarType) + "(" + month.ToString("D2") + ")" + " " + year.ToString("D4");
                    case SB.Tools.DateTime.ToStringFormat.LongDate:
                        return source.GetNameOfDayInWeek(false) + " " + day.ToString("D2") + " " + source.GetNameOfMonth(calendarType) + " " + year.ToString("D4");
                    case SB.Tools.DateTime.ToStringFormat.LongDateByMonthNumber:
                        return source.GetNameOfDayInWeek(false) + " " + day.ToString("D2") + " " + source.GetNameOfMonth(calendarType) + "(" + month.ToString("D2") + ") " + year.ToString("D4");
                    case SB.Tools.DateTime.ToStringFormat.ShortDateTime:
                        return year.ToString("D4") + "/" + month.ToString("D2") + "/" + day.ToString("D2") + " " + source.Hour.ToString("D2") + ":" + source.Minute.ToString("D2") + ":" + source.Second.ToString("D2");
                    case SB.Tools.DateTime.ToStringFormat.ShortDateTimeByMonthName:
                        return day.ToString("D2") + " " + source.GetNameOfMonth(calendarType) + " " + year.ToString("D4") + " " + source.Hour.ToString("D2") + ":" + source.Minute.ToString("D2") + ":" + source.Second.ToString("D2");
                    case SB.Tools.DateTime.ToStringFormat.LongDateTime:
                        return source.GetNameOfDayInWeek(false) + " " + day.ToString("D2") + " " + source.GetNameOfMonth(calendarType) + " " + year.ToString("D4") + " " + source.Hour.ToString("D2") + ":" + source.Minute.ToString("D2") + ":" + source.Second.ToString("D2");
                    case SB.Tools.DateTime.ToStringFormat.WithotDayShortDate:
                        return year.ToString("D4") + "/" + month.ToString("D2");
                    case SB.Tools.DateTime.ToStringFormat.WithotDayShortDateByMonthName:
                        return source.GetNameOfMonth(calendarType) + " " + year.ToString("D4");
                    case SB.Tools.DateTime.ToStringFormat.WithotDayShortDateByMonthNameAndMonthNumber:
                        return source.GetNameOfMonth(calendarType) + "(" + month.ToString("D2") + ")" + " " + year.ToString("D4");
                }
            }
            else if (throwExceptionIfDateIsNotValid)
            {
                Exception newEx = new Exception(string.Format(Texts.NotSupportDate, source, GetCalendarName(calendarType)));
                newEx.Data.Add(SeifaeiBrothersException.cntKeyNameExceptionID, "95C1160C-9F6A-4EFF-84C4-20EE8CE9E7F9");
                throw newEx;
            }
            return string.Empty;
        }

        public static bool Equal(this System.DateTime source, DateTime secoundDateTime, SB.Tools.DateTime.EnumDateTimeCompareType enuCompare)
        {
            if (enuCompare == SB.Tools.DateTime.EnumDateTimeCompareType.Date)
            {
                return (source.Year == secoundDateTime.Year && source.Month == secoundDateTime.Month && source.Day == secoundDateTime.Day);
            }

            if (enuCompare == SB.Tools.DateTime.EnumDateTimeCompareType.DateTime)
            {
                return (source.Year == secoundDateTime.Year && source.Month == secoundDateTime.Month && source.Day == secoundDateTime.Day &&
                        source.Hour == secoundDateTime.Hour && source.Minute == secoundDateTime.Minute && source.Second == secoundDateTime.Second && source.Millisecond == secoundDateTime.Millisecond);
            }

            if (enuCompare == SB.Tools.DateTime.EnumDateTimeCompareType.HourMinute)
            {
                return (source.Hour == secoundDateTime.Hour && source.Minute == secoundDateTime.Minute);
            }

            if (enuCompare == SB.Tools.DateTime.EnumDateTimeCompareType.HourMinuteSecound)
            {
                return (source.Hour == secoundDateTime.Hour && source.Minute == secoundDateTime.Minute && source.Second == secoundDateTime.Second);
            }

            if (enuCompare == SB.Tools.DateTime.EnumDateTimeCompareType.Time)
            {
                return (source.Hour == secoundDateTime.Hour && source.Minute == secoundDateTime.Minute && source.Second == secoundDateTime.Second && source.Millisecond == secoundDateTime.Millisecond);
            }

            if (enuCompare == SB.Tools.DateTime.EnumDateTimeCompareType.YearMonth)
            {
                return (source.Year == secoundDateTime.Year && source.Month == secoundDateTime.Month);
            }

            return false;
        }

        public static long ToLong(this System.DateTime source)
        {
            return
                long.Parse(
                    source.Year.ToString("0000") + source.Month.ToString("00") + source.Day.ToString("00") +
                    source.Hour.ToString("00") + source.Minute.ToString("00") + source.Second.ToString("00") +
                    source.Millisecond.ToString("000"));
        }

        #endregion //Extended methods

        #region --> Other DateTime Methods

        public static int ContainInList(List<DateTime> lstDates, DateTime dateTime, SB.Tools.DateTime.EnumDateTimeCompareType enuCompare)
        {
            if (lstDates != null && lstDates.Count > 0)
            {

                for (int i = 0; i < lstDates.Count; i++)
                {
                    if (lstDates[i].Equal(dateTime, enuCompare))
                    {
                        return i;
                    }
                }
            }

            return -1;
        }

        public static DateTime GetMaxSupportedDateTime(SB.Tools.DateTime.CalendarType calendarType)
        {
            switch (calendarType)
            {
                case SB.Tools.DateTime.CalendarType.PersianCalendar:
                    return objPersianCalendar.MaxSupportedDateTime;
                case SB.Tools.DateTime.CalendarType.HijriCalendar:
                    return objHijriCalendar.MaxSupportedDateTime;
                case SB.Tools.DateTime.CalendarType.HebrewCalendar:
                    return objHebrewCalendar.MaxSupportedDateTime;
                default:
                    return DateTime.MaxValue;
            }
        }

        public static DateTime GetMinSupportedDateTime(SB.Tools.DateTime.CalendarType calendarType)
        {
            switch (calendarType)
            {
                case SB.Tools.DateTime.CalendarType.PersianCalendar:
                    return objPersianCalendar.MinSupportedDateTime;
                case SB.Tools.DateTime.CalendarType.HijriCalendar:
                    return objHijriCalendar.MinSupportedDateTime;
                case SB.Tools.DateTime.CalendarType.HebrewCalendar:
                    return objHebrewCalendar.MinSupportedDateTime;
                default:
                    return DateTime.MinValue;
            }
        }

        /// <summary>
        /// این متد نوع تقویم و سال و ماه و روز را می گیرد و تاریخ مورد مظر را باز می گرداند
        /// </summary>
        public static DateTime ToDateTime(SB.Tools.DateTime.CalendarType calendarType, int year, int month, int day)
        {
            DateTime now = DateTime.Now;
            return ToDateTime(calendarType, year, month, day, now.Hour, now.Minute, now.Second, now.Millisecond);
        }

        /// <summary>
        /// این متد نوع تقویم و سال و ماه و روز را می گیرد و تاریخ مورد مظر را باز می گرداند
        /// </summary>
        public static DateTime ToDateTime(SB.Tools.DateTime.CalendarType calendarType, int year, int month, int day, int hour, int minute, int second, int miliSecond)
        {
            DateTime now = DateTime.Now;
            switch (calendarType)
            {
                case SB.Tools.DateTime.CalendarType.PersianCalendar:
                    return objPersianCalendar.ToDateTime(year, month, day, hour, minute, second, miliSecond);
                case SB.Tools.DateTime.CalendarType.HijriCalendar:
                    return objHijriCalendar.ToDateTime(year, month, day, hour, minute, second, miliSecond);
                case SB.Tools.DateTime.CalendarType.HebrewCalendar:
                    return objHebrewCalendar.ToDateTime(year, month, day, hour, minute, second, miliSecond);
                default:
                    return new DateTime(year, month, day, hour, minute, second, miliSecond);
            }
        }

        public static string GetCalendarName(SB.Tools.DateTime.CalendarType calendarType)
        {
            switch (calendarType)
            {
                case SB.Tools.DateTime.CalendarType.PersianCalendar:
                    return Texts.PersianCalendarName;
                case SB.Tools.DateTime.CalendarType.HijriCalendar:
                    return Texts.HijriCalendarName;
                case SB.Tools.DateTime.CalendarType.HebrewCalendar:
                    return Texts.HebrewCalendarName;
                default:
                    return Texts.ChristianCalendarName;
            }
        }

        public static bool TryParse(SB.Tools.DateTime.CalendarType calendarType, string str, out DateTime dateTime)
        {
            string[] ary = str.Trim().Split(" ".ToCharArray());
            if (ary.Length == 2 || ary.Length == 1)
            {
                string[] aryDate = ary[0].Contains('/') ? ary[0].Split("/".ToCharArray()) : ary[0].Split("-".ToCharArray());
                if (aryDate.Length == 3)
                {
                    int year, month, day, hour, minute, second, miliSecond;
                    year = month = day = hour = minute = second = miliSecond = 0;

                    if (int.TryParse(aryDate[0], out year)
                        && int.TryParse(aryDate[1], out month)
                        && int.TryParse(aryDate[2], out day))
                    {
                        if (ary.Length == 2)
                        {
                            string[] aryTime = ary[1].Split(":".ToCharArray());
                            if (aryTime.Length >= 1)
                                int.TryParse(aryTime[0], out hour);
                            if (aryTime.Length >= 2)
                                int.TryParse(aryTime[1], out minute);
                            if (aryTime.Length >= 3)
                                int.TryParse(aryTime[2], out second);
                            if (aryTime.Length >= 4)
                                int.TryParse(aryTime[3], out miliSecond);
                        }
                        return TryPars(calendarType, year, month, day, hour, minute, second, miliSecond, out dateTime);
                    }
                }
            }
            dateTime = DateTime.Now;
            return false;
        }

        public static bool TryPars(SB.Tools.DateTime.CalendarType calendarType, int year, int month, int day, out DateTime dateTime)
        {
            dateTime = DateTime.Today;

            if (IsValidYear(calendarType, year) && IsValidMonth(calendarType, year, month) && IsValidDay(calendarType, year, month, day))
            {
                dateTime = SeifaeiBrothersDateTime.ToDateTime(calendarType, year, month, day);
                return true;
            }
            return false;
        }

        public static bool TryPars(SB.Tools.DateTime.CalendarType calendarType, int year, int month, int day, int hour, int minute, int second, int miliSecond, out DateTime dateTime)
        {
            dateTime = DateTime.Today;

            if (IsValidYear(calendarType, year)
                && IsValidMonth(calendarType, year, month)
                && IsValidDay(calendarType, year, month, day)
                && hour > -1 && hour < 24
                && minute > -1 && minute < 60
                && second > -1 && second < 60
                && miliSecond > -1 && miliSecond < 1000)
            {
                dateTime = SeifaeiBrothersDateTime.ToDateTime(calendarType, year, month, day, hour, minute, second, miliSecond);
                return true;
            }
            return false;
        }

        public static bool IsValidYear(SB.Tools.DateTime.CalendarType calendarType, int year)
        {
            if (year < GetMinSupportedDateTime(calendarType).GetYear(calendarType) || year > GetMaxSupportedDateTime(calendarType).GetYear(calendarType))
            {
                return false;
            }
            return true;
        }

        public static bool IsValidMonth(SB.Tools.DateTime.CalendarType calendarType, int year, int month)
        {
            if (!IsValidYear(calendarType, year))
            {
                return false;
            }

            DateTime minDate = GetMinSupportedDateTime(calendarType);
            DateTime maxDate = GetMaxSupportedDateTime(calendarType);

            int maxMonth = year == maxDate.GetYear(calendarType) ? maxDate.GetMonth(calendarType) : SeifaeiBrothersDateTime.GetMonthsInYear(calendarType, year);
            int minMonth = year == minDate.GetYear(calendarType) ? minDate.GetMonth(calendarType) : 1;

            if (month > maxMonth || month < minMonth)
            {
                return false;
            }


            return true;
        }

        public static bool IsValidDay(SB.Tools.DateTime.CalendarType calendarType, int year, int month, int day)
        {
            if (!IsValidMonth(calendarType, year, month))
            {
                return false;
            }

            int maxDay = SeifaeiBrothersDateTime.GetDaysInMonth(calendarType, year, month);
            int minDay = 1;
            DateTime minDate = SeifaeiBrothersDateTime.GetMinSupportedDateTime(calendarType);
            DateTime maxDate = SeifaeiBrothersDateTime.GetMaxSupportedDateTime(calendarType);
            if (year == minDate.GetYear(calendarType) && month == minDate.GetMonth(calendarType))
            {
                minDay = minDate.GetDayOfMonth(calendarType);
            }

            if (year == maxDate.GetYear(calendarType) && month == maxDate.GetMonth(calendarType))
            {
                maxDay = maxDate.GetDayOfMonth(calendarType);
            }

            if (day < minDay || day > maxDay)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// این متد تعداد ماه های سال را بر می گرداند چنانچه سال پشتیبالی نشود مقدار منفی یک باز گردانده می شود
        /// </summary>
        public static int GetMonthsInYear(SB.Tools.DateTime.CalendarType calendarType, int year)
        {
            if (!IsValidYear(calendarType, year))
            {
                return -1;
            }

            switch (calendarType)
            {
                case SB.Tools.DateTime.CalendarType.PersianCalendar:
                    return objPersianCalendar.GetMonthsInYear(year);
                case SB.Tools.DateTime.CalendarType.HijriCalendar:
                    return objHijriCalendar.GetMonthsInYear(year);
                case SB.Tools.DateTime.CalendarType.HebrewCalendar:
                    return objHebrewCalendar.GetMonthsInYear(year);
                default:
                    return 12;
            }
        }

        /// <summary>
        /// این متد تعدادروز های ماه را بر می گرداند چنانچه سال و ماه پشتیبالی نشود مقدار منفی یک باز گردانده می شود
        /// </summary>
        public static int GetDaysInMonth(SB.Tools.DateTime.CalendarType calendarType, int year, int month)
        {
            if (!IsValidMonth(calendarType, year, month))
            {
                return -1;
            }

            switch (calendarType)
            {
                case SB.Tools.DateTime.CalendarType.PersianCalendar:
                    return objPersianCalendar.GetDaysInMonth(year, month);
                case SB.Tools.DateTime.CalendarType.HijriCalendar:
                    return objHijriCalendar.GetDaysInMonth(year, month);
                case SB.Tools.DateTime.CalendarType.HebrewCalendar:
                    return objHebrewCalendar.GetDaysInMonth(year, month);
                default:
                    return System.DateTime.DaysInMonth(year, month);
            }

        }

        public static Response<DateTime> GetDateTimeOfLong(long number)
        {
            var response = new Response<DateTime>();
            try
            {
                string strlng = number.ToString();
                if (strlng.Length != 17)
                {
                    throw new Exception("DateNumber must has 17 char." + strlng + " has " + strlng.Length + " char.");
                }

                response.Object = new DateTime(int.Parse(strlng.Substring(0, 4)), int.Parse(strlng.Substring(4, 2)), int.Parse(strlng.Substring(6, 2)),
                                               int.Parse(strlng.Substring(8, 2)), int.Parse(strlng.Substring(10, 2)), int.Parse(strlng.Substring(12, 2)), int.Parse(strlng.Substring(14)));
            }
            catch (Exception ex)
            {
                response.Exception = ex;
            }
            return response;
        }

        /// <summary>
        /// این متد تاریخ فعلی را با زمان آغاز روز بر می گرداند
        /// </summary>
        public static DateTime GetStartDay_DateTime(this DateTime source)
        {
            return new DateTime(source.Year, source.Month, source.Day, 0, 0, 0);
        }

        /// <summary>
        /// این متد تاریخ فعلی را با زمان پایان روز بر می گرداند
        /// </summary>
        public static DateTime GetEndDay_DateTime(this DateTime source)
        {
            return new DateTime(source.Year, source.Month, source.Day, 23, 59, 59);
        }
        #endregion //Other DateTime Methods
    }
}
