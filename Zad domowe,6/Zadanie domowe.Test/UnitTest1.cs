namespace Zadanie_domowe.Test
{
    public class Tests
    {
        [Test]
        public void TestDidClassWorkRight()
        {
            //arrange
            var user = new Employee("Piotr", "Cybulski", 30);
            user.Addpoints(4);
            user.Addpoints(7);
            //act
            var together = user.sum;
            //assert
            Assert.AreEqual(3, together);
        }
    }
}