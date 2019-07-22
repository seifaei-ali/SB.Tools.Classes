using System;
using System.Collections.Generic;
using System.Text;

namespace SB.Tools.Other
{
    public class GoodSpeechOfBigMan
    {
        /// <summary>
        /// نام فایلی که کتاب های انتخاب شده در آن ذخیره می شوند
        /// </summary>
        private const string strFileName = "SelectedBook.xml";

        private static System.Random objRand = new Random();

        public static List<GoodSpeechOfBigMan> LoadOfFile(string fileName)
        {
            System.IO.StreamReader objStream = null;
            System.Xml.Serialization.XmlSerializer serializer = null;
            try
            {
                List<GoodSpeechOfBigMan> returnValue = new List<GoodSpeechOfBigMan>();
                objStream = new System.IO.StreamReader(fileName);
                serializer = new System.Xml.Serialization.XmlSerializer(returnValue.GetType());
                return (List<GoodSpeechOfBigMan>)serializer.Deserialize(objStream.BaseStream);
            }
            catch (System.Exception ex)
            {
                System.Exception newEx = new System.Exception("برنامه هنگام بازیابی سخنان افراد بزرگ دچار خطا شده است", ex);
                newEx.Data.Add(SeifaeiBrothersException.cntKeyNameExceptionID, "2FCD308D-679A-4DD9-9636-239B49E3B6F8");
                throw newEx;
            }
            finally
            {
                try
                {
                    if (objStream != null)
                    {
                        objStream.Close();
                    }
                }
                catch { }
            }
        }

        public static void SaveInFile(List<GoodSpeechOfBigMan> listGoodSpeech, string fileName)
        {
            System.IO.StreamWriter objStream = null;
            try
            {
                if (!System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(fileName)))
                {
                    System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(fileName));
                }

                objStream = new System.IO.StreamWriter(fileName, true);
                System.Xml.Serialization.XmlSerializer objSerialize = new System.Xml.Serialization.XmlSerializer(listGoodSpeech.GetType());
                objSerialize.Serialize(objStream.BaseStream, listGoodSpeech);
            }
            catch (System.Exception ex)
            {
                System.Exception newEx = new System.Exception("برنامه هنگام ذخیره سخنان افراد بزرگ دچار خطا شده است", ex);
                newEx.Data.Add(SeifaeiBrothersException.cntKeyNameExceptionID, "359DBD81-B0FB-4DFA-B4F5-69AFCBFAF18C");
                throw newEx;
            }
            finally
            {
                if (objStream != null)
                {
                    objStream.Close();
                }
            }
        }

        public static GoodSpeechOfBigMan GetRandom(List<GoodSpeechOfBigMan> listGoodSpeech)
        {
            try
            {
                GoodSpeechOfBigMan returnValue = new GoodSpeechOfBigMan();
                if (listGoodSpeech != null && listGoodSpeech.Count > 0)
                {
                    returnValue = listGoodSpeech[objRand.Next(0, listGoodSpeech.Count - 1)];
                }
                return returnValue;
            }
            catch (System.Exception ex)
            {
                System.Exception newEx = new System.Exception("برنامه هنگام انتخاب یک جمله زیبا دچار خطا شده است", ex);
                newEx.Data.Add(SeifaeiBrothersException.cntKeyNameExceptionID, "F8824BE2-0BF9-42AA-8C61-402F923E7663");
                throw newEx;
            }
        }

        public static GoodSpeechOfBigMan GetRandom(List<List<GoodSpeechOfBigMan>> listBookCollection)
        {
            try
            {
                if (listBookCollection != null && listBookCollection.Count > 0)
                {
                    return GetRandom(listBookCollection[objRand.Next(0, listBookCollection.Count)]);
                }
                return new GoodSpeechOfBigMan();
            }
            catch (System.Exception ex)
            {
                System.Exception newEx = new System.Exception("برنامه هنگام انتخاب تصادفی یک جمله زیبا دچار خطا شده است", ex);
                newEx.Data.Add(SeifaeiBrothersException.cntKeyNameExceptionID, "91F5DC7D-48B0-434E-8DEB-7320DCDD485C");
                throw newEx;
            }
        }

        /// <summary>
        /// این متد یک فولدر را می گیرد و لیست فایلها و یا نام فایل هائی که قابل دسترس هستند را باز می گرداند
        /// </summary>
        public static List<string> GetBooksOfFolder(string folderPath, bool onlyFileName)
        {
            System.IO.StreamReader objStream = null;
            try
            {
                List<string> returnValue = new List<string>();
                System.Xml.Serialization.XmlSerializer objSerializer = new System.Xml.Serialization.XmlSerializer(typeof(List<GoodSpeechOfBigMan>));
                System.Xml.XmlReader objXMLReader;

                string[] aryFile = System.IO.Directory.GetFiles(folderPath);
                foreach (string itemFileName in aryFile)
                {
                    objStream = new System.IO.StreamReader(itemFileName);
                    objXMLReader = System.Xml.XmlReader.Create(objStream);
                    if (objSerializer.CanDeserialize(objXMLReader))
                    {
                        if (onlyFileName)
                        {
                            returnValue.Add(System.IO.Path.GetFileNameWithoutExtension(itemFileName));
                        }
                        else
                        {
                            returnValue.Add(itemFileName);
                        }
                    }
                }
                return returnValue;
            }
            catch (System.Exception ex)
            {
                System.Exception newEx = new System.Exception("برنامه هنگام شناسائی لیست کتاب های جملات زیبا دچار خطا شده است", ex);
                newEx.Data.Add(SeifaeiBrothersException.cntKeyNameExceptionID, "6C178EE4-8DD5-43CD-BEFA-3C3A9AB464CB");
                throw newEx;
            }
        }

        public static void SaveSelectedBookName(string folderPath, List<string> listBooks)
        {
            System.IO.StreamWriter objStream = null;
            try
            {
                objStream = new System.IO.StreamWriter(folderPath + "\\" + strFileName);
                System.Xml.Serialization.XmlSerializer objSerializer = new System.Xml.Serialization.XmlSerializer(listBooks.GetType());
                objSerializer.Serialize(objStream, listBooks);
            }
            catch (System.Exception ex)
            {
                System.Exception newEx = new System.Exception("برنامه هنگام ذخیره نام کتاب های انتخاب شده دچار خطا شده است", ex);
                newEx.Data.Add(SeifaeiBrothersException.cntKeyNameExceptionID, "A6C3491F-08F2-4FC1-8607-57BDD5DCD1C1");
                throw newEx;
            }
            finally
            {
                try
                {
                    if (objStream != null)
                    {
                        objStream.Close();
                    }
                }
                catch { }
            }
        }

        public static List<string> LoadSelectedBookName(string folderPath)
        {
            System.IO.StreamReader objStream = null;
            try
            {
                objStream = new System.IO.StreamReader(folderPath + "\\" + strFileName);
                System.Xml.Serialization.XmlSerializer objSerializer = new System.Xml.Serialization.XmlSerializer(typeof(List<string>));
                return (List<string>)objSerializer.Deserialize(objStream);
            }
            catch (System.Exception ex)
            {
                System.Exception newEx = new System.Exception("برنامه هنگام بازیابی نام کتاب های انتخاب شده دچار خطا شده است", ex);
                newEx.Data.Add(SeifaeiBrothersException.cntKeyNameExceptionID, "3F5F4E83-5546-4A5F-9E2B-0B716BBAF5A9");
                throw newEx;
            }
            finally
            {
                try
                {
                    if (objStream != null)
                    {
                        objStream.Close();
                    }
                }
                catch { }
            }
        }

        public GoodSpeechOfBigMan()
        {
        }

        public GoodSpeechOfBigMan(string person, string speech)
        {
            this.Speech = speech;
            this.Person = person;
        }

        /// <summary>
        /// این متد همه کتاب های انتخاب شده را با لیست جملاتشان باز می گرداند
        /// در صورتی که فایل کتاب های انتخاب شده وجود نداشته باشد همه کتاب های
        /// موجود در مسیر داده شده را به عنوان نتیجه باز می گرداند
        /// </summary>
        public static List<List<GoodSpeechOfBigMan>> GetSelectedBooksCollection(string folderName)
        {
            try
            {
                List<List<GoodSpeechOfBigMan>> returnValue = new List<List<GoodSpeechOfBigMan>>();
                List<string> listFiles;
                try
                {
                    listFiles = LoadSelectedBookName(folderName);
                }
                catch
                {
                    listFiles = GetBooksOfFolder(folderName, true);
                }

                foreach (string itemBookName in listFiles)
                {
                    //try
                    {
                        List<GoodSpeechOfBigMan> temp = LoadOfFile(folderName + "\\" + itemBookName + ".xml");
                        if (temp != null && temp.Count > 0)
                        {
                            returnValue.Add(temp);
                        }
                    }
                    //catch { }
                }
                return returnValue;
            }
            catch (System.Exception ex)
            {
                System.Exception newEx = new System.Exception("برنامه هنگام بازیابی همه کتاب های سخنان افراد بزرگ و جملات داخل آنها دچار خطا شده است", ex);
                newEx.Data.Add(SeifaeiBrothersException.cntKeyNameExceptionID, "9E4561A5-EA19-4A96-8ABE-BE5B66A2ED5D");
                throw newEx;
            }
        }

        #region --> define property Person

        private string _Person;

        /// <summary>
        /// فردی که سخن گفته
        /// </summary>
        public string Person
        {
            get { return _Person; }
            set { _Person = value; }
        }

        #endregion //define property Person

        #region --> define property Speech

        private string _Speech;

        /// <summary>
        /// سخن فرد
        /// </summary>
        public string Speech
        {
            get { return _Speech; }
            set { _Speech = value; }
        }

        #endregion //define property Speech

        public override string ToString()
        {
            return this.Speech + (string.IsNullOrEmpty(this.Person) ? string.Empty : " <<" + this.Person + ">>");
        }
    }
}
