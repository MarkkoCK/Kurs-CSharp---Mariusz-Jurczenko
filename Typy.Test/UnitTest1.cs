using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Typy.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateMaxGrade()
        {
            Diary diary = new Diary();
            diary.AddRating(8.9f);
            diary.AddRating(8f);
            diary.AddRating(7f);
            diary.AddRating(5f);
            diary.AddRating(3f);
            diary.AddRating(10f);

            DiaryStatistics stats = diary.ComputeStatistics();

            Assert.AreEqual(10f, stats.MaxGrade);        
        }

        [TestMethod]
        public void PassByValueClass()
        {
            Diary diary = new Diary();
            diary.Name = "Jacek";

            SetName(diary);

            Assert.AreEqual("Marcin", diary.Name);
        }

        private void SetName(Diary diary)
        {
            diary.Name = "Marcin";
        }

        [TestMethod]
        public void TestIsTrue()
        {
            bool value = true;
            Assert.IsTrue(value);
        }
    }
}
