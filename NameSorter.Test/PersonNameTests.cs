using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace NameSorter.Test
{
    /// <summary>
    /// 'PersonNameTests' Test class for Class Library
    /// </summary>

    [TestClass]
    public class PersonNameTests
    {
        //Postivie TestCase

        [TestMethod]
        public void SplitFullName_FirstNamMiddleNameAndLastName_ReturnsStringArrayOfLengthAsPerGivenName()
        {
            //Arrange
            string[] expectedFirst = {"Leo"};
            string fullNameFirst = "Leo";
            string[] expectedSecond = { "Leo", "Gardner" };
            string fullNameSecond = "Leo Gardner";
            string[] expectedThird = { "Leo","Alis", "Gardner" };
            string fullNameThird = "Leo Alis Gardner";

            //Act
            string[] actualFirst =  Library.PeronName.SplitFullName(fullNameFirst);
            string[] actualSecond = Library.PeronName.SplitFullName(fullNameSecond);
            string[] actualThird = Library.PeronName.SplitFullName(fullNameThird);

            //Assert
            CollectionAssert.AreEqual(expectedFirst, actualFirst);
            CollectionAssert.AreEqual(expectedSecond, actualSecond);
            CollectionAssert.AreEqual(expectedThird, actualThird);
        }

        //Negative TestCase
        [TestMethod]
        public void SplitFullName_EmptyStrin_ReturnsEmptyString()
        {
            //Arrange
            string[] expected = {""};
            string fullName = " ";

            //Act
            string[] actual = Library.PeronName.SplitFullName(fullName);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
