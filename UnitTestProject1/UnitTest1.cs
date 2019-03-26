using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml;
using System.Text;
using Martin_G_Praktika_Forms;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WriteNodeTest()
        {
            // Выдаёт следующее:
            /*
             * Message: Метод теста UnitTestProject1.UnitTest1.WriteNodeTest создал исключение: 
System.Xml.XmlException: Отсутствует корневой элемент..

            ХОТЯ делая тест через сам проэкт, всё работает идеально.
             */
            Assert.IsTrue(Martin_G_Praktika_Forms.Form1.NodeTest("write"));

        }
       
    }
}
