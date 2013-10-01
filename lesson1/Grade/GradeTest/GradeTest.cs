using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grade;

namespace GradeTest
{
    [TestClass]
    public class GradeTest
    {
        private Grade.Grade grade = new Grade.Grade();

        [TestMethod]
        public void whenScoreIsMoreThan80_thenGradeIs4()
        {
            Assert.AreEqual(4, grade.grade(80));
            Assert.AreEqual(4, grade.grade(81));
        }

        [TestMethod]
        public void whenScoreIsMoreThan70_thenGradeIs3()
        {
            Assert.AreEqual(3, grade.grade(70));
            Assert.AreEqual(3, grade.grade(79));
        }

        [TestMethod]
        public void whenScoreIsMoreThan60_thenGradeIs2()
        {
            Assert.AreEqual(2, grade.grade(60));
            Assert.AreEqual(2, grade.grade(69));
        }

        [TestMethod]
        public void whenScoreIsMoreThan50_thenGradeIs1()
        {
            Assert.AreEqual(1, grade.grade(50));
            Assert.AreEqual(1, grade.grade(59));
        }

        [TestMethod]
        [ExpectedException(typeof(UnderFlow))]
        public void whenScoreIsLessThan0_thenThrowException()
        {
            grade.grade(-1);
        }
    }
}
