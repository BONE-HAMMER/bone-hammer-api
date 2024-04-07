namespace bone_hammer_api;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    [TestMethod]
public void Can_Create_New_Rating()

// Arrange
var rating = new Rating(1, "Mike", "Great fit!");

// Act (empty)

// Assert
Assert.AreEqual(1, rating.Stars);
Assert.AreEqual("Mike", rating. UserName);
Assert.AreEqual("Great fit!", rating.Review);
}