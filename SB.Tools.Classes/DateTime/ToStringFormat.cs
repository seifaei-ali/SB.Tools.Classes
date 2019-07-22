﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SB.Tools.DateTime
{
    public enum  ToStringFormat
    {
        
        /// <summary>
        /// این متد یک تاریخ به میلادی را می گیرد و در صورت درست بودن برای تاریخ قمری یک رشته 
        /// معرف تاریخ قمری مزکور را باز می گرداند
        /// <para>اگر تاریخ ما در سال 1363 و ماه 2 و روز 16 و ساعت 5 و 7 دقیقه و 7 ثانیه صبح باشد</para>
        /// <para>"d" : تاریخ کوتاه : 1363/2/16</para>
        /// </summary>
        ShortDate,

        /// <summary>
        /// این متد یک تاریخ به میلادی را می گیرد و در صورت درست بودن برای تاریخ قمری یک رشته 
        /// معرف تاریخ قمری مزکور را باز می گرداند
        /// <para>اگر تاریخ ما در سال 1363 و ماه 2 و روز 16 و ساعت 5 و 7 دقیقه و 7 ثانیه صبح باشد</para>
        /// <para>تاریخ کوتاه با نام ماه : 16 اردیبهشت 1363</para>
        /// </summary>
        ShortDateByMonthName,

        /// <summary>
        /// این متد یک تاریخ به میلادی را می گیرد و در صورت درست بودن برای تاریخ قمری یک رشته 
        /// معرف تاریخ قمری مزکور را باز می گرداند
        /// <para>اگر تاریخ ما در سال 1363 و ماه 2 و روز 16 و ساعت 5 و 7 دقیقه و 7 ثانیه صبح باشد</para>
        /// <para>تاریخ کوتاه با نام ماه : 16 اردیبهشت(2) 1363</para>
        /// </summary>
        ShortDateByMonthNameAndMonthNumber,

        /// <summary>
        /// این متد یک تاریخ به میلادی را می گیرد و در صورت درست بودن برای تاریخ قمری یک رشته 
        /// معرف تاریخ قمری مزکور را باز می گرداند
        /// <para>اگر تاریخ ما در سال 1363 و ماه 2 و روز 16 و ساعت 5 و 7 دقیقه و 7 ثانیه صبح باشد</para>
        /// <para>"D" : تاریخ بلند :  یکشنبه 16 اردیبهشت 1363</para>
        /// </summary>
        LongDate,

        /// <summary>
        /// این متد یک تاریخ به میلادی را می گیرد و در صورت درست بودن برای تاریخ قمری یک رشته 
        /// معرف تاریخ قمری مزکور را باز می گرداند
        /// <para>اگر تاریخ ما در سال 1363 و ماه 2 و روز 16 و ساعت 5 و 7 دقیقه و 7 ثانیه صبح باشد</para>
        /// <para>"D" : تاریخ بلند :  یکشنبه 16 اردیبهشت(2) 1363</para>
        /// </summary>
        LongDateByMonthNumber,

        /// <summary>
        /// این متد یک تاریخ به میلادی را می گیرد و در صورت درست بودن برای تاریخ قمری یک رشته 
        /// معرف تاریخ قمری مزکور را باز می گرداند
        /// <para>اگر تاریخ ما در سال 1363 و ماه 2 و روز 16 و ساعت 5 و 7 دقیقه و 7 ثانیه صبح باشد</para>
        /// <para> تاریخ کوتاه و زمان: 1363/2/16 5:7:7</para>
        /// </summary>
        ShortDateTime,

        /// <summary>
        /// این متد یک تاریخ به میلادی را می گیرد و در صورت درست بودن برای تاریخ قمری یک رشته 
        /// معرف تاریخ قمری مزکور را باز می گرداند
        /// <para>اگر تاریخ ما در سال 1363 و ماه 2 و روز 16 و ساعت 5 و 7 دقیقه و 7 ثانیه صبح باشد</para>
        /// <para>تاریخ کوتاه با نام ماه : 16 اردیبهشت 1363 5:7:7</para>
        /// </summary>
        ShortDateTimeByMonthName,

        /// <summary>
        /// این متد یک تاریخ به میلادی را می گیرد و در صورت درست بودن برای تاریخ قمری یک رشته 
        /// معرف تاریخ قمری مزکور را باز می گرداند
        /// <para>اگر تاریخ ما در سال 1363 و ماه 2 و روز 16 و ساعت 5 و 7 دقیقه و 7 ثانیه صبح باشد</para>
        /// <para>"D" : تاریخ بلند :  یکشنبه 16 اردیبهشت 1363</para>
        /// </summary>
        LongDateTime,

        /// <summary>
        /// این متد یک تاریخ به میلادی را می گیرد و در صورت درست بودن برای تاریخ قمری یک رشته 
        /// معرف تاریخ قمری مزکور بدون روز  را باز می گرداند
        /// <para>اگر تاریخ ما در سال 1363 و ماه 2 و روز 16 و ساعت 5 و 7 دقیقه و 7 ثانیه صبح باشد</para>
        /// <para>"d" : تاریخ کوتاه : 1363/2</para>
        /// </summary>
        WithotDayShortDate,

        /// <summary>
        /// این متد یک تاریخ به میلادی را می گیرد و در صورت درست بودن برای تاریخ قمری یک رشته 
        /// معرف تاریخ قمری مزکور بدون روز را باز می گرداند
        /// <para>اگر تاریخ ما در سال 1363 و ماه 2 و روز 16 و ساعت 5 و 7 دقیقه و 7 ثانیه صبح باشد</para>
        /// <para>تاریخ کوتاه با نام ماه : اردیبهشت 1363</para>
        /// </summary>
        WithotDayShortDateByMonthName,

        /// <summary>
        /// این متد یک تاریخ به میلادی را می گیرد و در صورت درست بودن برای تاریخ قمری یک رشته 
        /// معرف تاریخ قمری مزکور  بدون روز را باز می گرداند
        /// <para>اگر تاریخ ما در سال 1363 و ماه 2 و روز 16 و ساعت 5 و 7 دقیقه و 7 ثانیه صبح باشد</para>
        /// <para>تاریخ کوتاه با نام ماه : اردیبهشت(2) 1363</para>
        /// </summary>
        WithotDayShortDateByMonthNameAndMonthNumber,

    }
}
