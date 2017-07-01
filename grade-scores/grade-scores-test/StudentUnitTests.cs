using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GradeScores.Student;

namespace grade_scores_test
{
    [TestClass]
    public class StudentUnitTests
    {
        [TestInitialize()]
        public void Initialize()
        {
            
        }

        [TestMethod]
        [TestCategory("Test Student Class")]
        public void NullFirstnameReturnsNullStudent()
        {
            IStudent actual = Student.Create(null, "Jones", 100);
            Assert.IsNull(actual);
        }

        [TestMethod]
        [TestCategory("Test Student Class")]
        public void ZeroLengthFirstnameReturnsNullStudent()
        {
            IStudent actual = Student.Create("", "Jones", 100);
            Assert.IsNull(actual);
        }

        [TestMethod]
        [TestCategory("Test Student Class")]
        public void NullLastnameReturnsNullStudent()
        {
            IStudent actual = Student.Create("John", null, 100);
            Assert.IsNull(actual);
        }

        [TestMethod]
        [TestCategory("Test Student Class")]
        public void ZeroLengthLastnameReturnsNullStudent()
        {
            IStudent actual = Student.Create("John", "", 100);
            Assert.IsNull(actual);
        }

        [TestMethod]
        [TestCategory("Test Student Class")]
        public void GreaterThan100ScoreReturnsNullStudent()
        {
            IStudent actual = Student.Create("John", "Jones", 101);
            Assert.IsNull(actual);
        }

        [TestMethod]
        [TestCategory("Test Student Class")]
        public void CorrectDataReturnsAStudent()
        {
            var expected = typeof(Student);
            var actual = Student.Create("John", "Jones", 50).GetType();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Test Student Class")]
        public void ReturnsCorrectlyFormatedString()
        {
            var expected = "Jones, John, 50";
            var actual = Student.Create("John", "Jones", 50).ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Test Student Class")]
        public void Accepts0Score()
        {
            var expected = "Jones, John, 0";
            var actual = Student.Create("John", "Jones", 0).ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Test Student Class")]
        public void Accepts100Score()
        {
            var expected = "Jones, John, 100";
            var actual = Student.Create("John", "Jones", 100).ToString();
            Assert.AreEqual(expected, actual);
        }

    }
}
