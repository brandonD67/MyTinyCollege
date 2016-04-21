using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade.Test
{
    [TestClass]
    class GradeBookTest
    {
        [TestMethod]

        public void ComputeHighestGrade()
        {
            GradeBook.GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeBookTest.GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(90, result.HighestGrade);


        }

    }
}
