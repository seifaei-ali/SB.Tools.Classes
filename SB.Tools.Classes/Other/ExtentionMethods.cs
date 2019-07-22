using System.Collections.Generic;
using System.Linq;
using System.Resources;

// ReSharper disable once CheckNamespace
namespace System
{
    public enum boolToStringFormat
    {
        ToTrueFalse,
        ToOkNotOk
    }

    public static class ExtentionMethods
    {
        public static string ToString(this bool source, boolToStringFormat format)
        {
            string result;
            switch (format)
            {
                case boolToStringFormat.ToOkNotOk:
                    if (source)
                        result = "OK";
                    else
                        result = "NotOK";
                    break;
                default:
                    if (source)
                        result = bool.TrueString;
                    else
                        result = bool.FalseString;
                    break;
            }

            return result;
        }

        /// <summary>
        /// این متد برای اصلاح متن برای همسان سازی ی و ک در عربی و فارسی استفاده می شود
        /// </summary>
        public static string RepairStringFor_ye_Ke(this string source)
        {
            return source.Replace('ي', 'ی').Replace('ك', 'ک');
        }

        public static string GetTitle(this Enum source)
        {
            var memInfo = source.GetType().GetMember(source.ToString()).FirstOrDefault();
            if (memInfo != null)
            {
                var att = memInfo.GetCustomAttributes(typeof(EnumTitle), false);
                if (att.Length > 0
                    && att[0] is EnumTitle)
                {
                    var enumTitle = (EnumTitle)att[0];
                    var rm = new ResourceManager(enumTitle.ResourceType);
                    return rm.GetString(enumTitle.Name);
                }
            }
            return Enum.GetName(source.GetType(), source);
        }

        public static string GetName(this Enum source)
        {
            return Enum.GetName(source.GetType(), source);
        }
    }



}
