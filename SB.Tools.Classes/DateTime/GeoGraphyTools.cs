using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SB.Tools.DateTime
{
    #region City Name

    public enum enuCityName
    {
        None,
        Tabriz,
        Oromie,
        Ardabil,
        Esfehan,
        Eilam,
        Boshehr,
        Tehran,
        ShahreKord,
        Birjand,
        Mashhad,
        Bojnord,
        Ahvaz,
        Zanjan,
        Semnan,
        Zahedan,
        Shiraz,
        Ghazvin,
        Ghom,
        Sanandaj,
        Kerman,
        Kermanshah,
        Yasoj,
        Gorgan,
        Rasht,
        Khoramabad,
        Sari,
        Arak,
        BandarAbas,
        Hamedan,
        Yazd
    }

    #endregion City Name

    public class GeoGraphyTools
    {
        public class CityInfo
        {
            ///<summary>
            /// نام انگلیسی شهر
            ///</summary>
            private enuCityName _CityName;
            ///<summary>
            /// نام انگلیسی شهر
            ///</summary>		
            public enuCityName CityName
            {
                get { return _CityName; }
                private set { _CityName = value; }
            }


            ///<summary>
            /// نام فارسی شهر
            ///</summary>
            private string _PersianCityName;
            ///<summary>
            /// نام فارسی شهر
            ///</summary>		
            public string PersianCityName
            {
                get { return _PersianCityName; }
                private set { _PersianCityName = value; }
            }


            ///<summary>
            /// طول جغرافیائی شهر
            ///</summary>
            private double _Longitude;
            ///<summary>
            /// طول جغرافیائی شهر
            ///</summary>		
            public double Longitude
            {
                get { return _Longitude; }
                private set { _Longitude = value; }
            }


            ///<summary>
            /// عرض جغرافیائی شهر
            ///</summary>
            private double _Latitute;
            ///<summary>
            /// عرض جغرافیائی شهر
            ///</summary>		
            public double Latitute
            {
                get { return _Latitute; }
                private set { _Latitute = value; }
            }

            ///<summary>
            /// نام کشوری که شهر متعلق به ان است
            ///</summary>
            private string _CountryName;
            ///<summary>
            /// نام کشوری که شهر متعلق به ان است
            ///</summary>		
            public string CountryName
            {
                get { return _CountryName; }
                set { _CountryName = value; }
            }

            public CityInfo(enuCityName objCityName, string PersianCityName, double Longitude, double Latitude, string CountryName)
            {
                this.PersianCityName = PersianCityName;
                this.Longitude = Longitude;
                this.Latitute = Latitude;
                this.CountryName = CountryName;
                this.CityName = objCityName;
            }
        }

        public class CityInfoCollection
        {
            public static CityInfoCollection Default = new CityInfoCollection(true);

            private List<CityInfo> AllCity = new List<CityInfo>();

            public CityInfoCollection(bool AddExistCity)
            {
                if (AddExistCity)
                {
                    #region Define All City Info
                    CityInfo[] objTemp = {
                     new CityInfo(enuCityName.None, "انتخاب نشده", 0, 0, "انتخاب نشده"),
                     new CityInfo(enuCityName.Tabriz, "تبریز", 46.28, 38.08, "ایران"),
                     new CityInfo(enuCityName.Oromie, "ارومیه", 45.07, 37.55, "ایران"),
                     new CityInfo(enuCityName.Ardabil, "اردبیل", 48.3, 38.25, "ایران"),
                     new CityInfo(enuCityName.Esfehan, "اصفهان", 48.3, 32.68, "ایران"),
                     new CityInfo(enuCityName.Eilam, "ایلام", 46.42, 33.64, "ایران"),
                     new CityInfo(enuCityName.Boshehr, "بوشهر", 50.84, 28.97, "ایران"),
                     new CityInfo(enuCityName.Tehran, "تهران", 51.41, 35.7, "ایران"),
                     new CityInfo(enuCityName.ShahreKord, "شهرکرد", 50.86, 32.33, "ایران"),
                     new CityInfo(enuCityName.Birjand, "بیرجند", 59.21, 32.86, "ایران"),
                     new CityInfo(enuCityName.Mashhad, "مشهد", 59.58, 33.55, "ایران"),
                     new CityInfo(enuCityName.Bojnord, "بروجرد", 48.5, 33.55, "ایران"),
                     new CityInfo(enuCityName.Ahvaz, "اهواز", 48.68, 31.32, "ایران"),
                     new CityInfo(enuCityName.Zanjan, "زنجان", 48.5, 36.68, "ایران"),
                     new CityInfo(enuCityName.Semnan, "سمنان", 53.39, 35.58, "ایران"),
                     new CityInfo(enuCityName.Zahedan, "زاهدان", 60.86, 29.5, "ایران"),
                     new CityInfo(enuCityName.Shiraz, "شیراز", 52.52, 29.62, "ایران"),
                     new CityInfo(enuCityName.Ghazvin, "قزوین", 50, 36.28, "ایران"),
                     new CityInfo(enuCityName.Ghom, "قم", 50.88, 34.64, "ایران"),
                     new CityInfo(enuCityName.Sanandaj, "سنندج", 47, 35.31, "ایران"),
                     new CityInfo(enuCityName.Kerman, "کرمان", 57.06, 30.29, "ایران"),
                     new CityInfo(enuCityName.Kermanshah, "کرمانشاه", 47.09, 34.34, "ایران"),
                     new CityInfo(enuCityName.Yasoj, "یاسوج", 51.59, 30.67, "ایران"),
                     new CityInfo(enuCityName.Gorgan, "گرگان", 54.44, 36.84, "ایران"),
                     new CityInfo(enuCityName.Rasht, "رشت", 49.59, 37.28, "ایران"),
                     new CityInfo(enuCityName.Khoramabad, "خرم آباد", 48.34, 48.34, "ایران"),
                     new CityInfo(enuCityName.Sari, "ساری", 53.06, 36.57, "ایران"),
                     new CityInfo(enuCityName.Arak, "اراک", 49.7, 34.09, "ایران"),
                     new CityInfo(enuCityName.BandarAbas, "بندرعباس", 56.29, 27.19, "ایران"),
                     new CityInfo(enuCityName.Hamedan, "همدان", 48.52, 34.8, "ایران"),
                     new CityInfo(enuCityName.Yazd, "یزد", 54.35, 31.89, "ایران")
                                             };
                    this.AllCity.AddRange(objTemp);
                    #endregion Define All City Info

                }
            }

            public CityInfo this[enuCityName CityName]
            {
                get
                {
                    CityInfo objResult = null;
                    foreach (CityInfo item in this.AllCity)
                    {
                        if (item.CityName == CityName)
                        {
                            objResult = item;
                            break;
                        }
                    }
                    return objResult;
                }
            }

            /// <summary>
            /// این ایندکسر مشخصات یک شهر را باز می گرداند
            /// </summary>
            /// <param name="Index">پارامتر همان عدد مقدار شمارشی نام شهر می باشد</param>
            /// <returns></returns>
            public CityInfo this[int Index]
            {
                get
                {
                    if (!Enum.IsDefined(typeof(enuCityName), Index))
                    {
                        return null;
                    }
                    return this[(enuCityName)Index];
                }
            }

            public CityInfo this[string PersianCityName]
            {
                get
                {
                    CityInfo objResult = null;
                    foreach (CityInfo item in this.AllCity)
                    {
                        if (item.PersianCityName == PersianCityName)
                        {
                            objResult = item;
                            break;
                        }
                    }
                    return objResult;
                }
            }

            public List<CityInfo> GetAllCityOfCountry(string CountryName)
            {
                List<CityInfo> objresult = new List<CityInfo>();

                foreach (CityInfo item in this.AllCity)
                {
                    if (item.CountryName == CountryName)
                    {
                        objresult.Add(item);
                    }
                }

                return objresult;
            }

            ///<summary>
            /// تعداد شهر موجود در مجموعه
            ///</summary>		
            public int Count
            {
                get { return this.AllCity.Count; }
            }
        }


    }
}
