using DungeonLibrary;
namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test_MaxLife()
        {
            //arrange
            Player player = new("test", 0, 0, 100, Race.Candy, new(WeaponType.Staff));
            int expected = 100;
            //act
            player.Life += 20;
            //assert
            Assert.Equal(expected, player.Life);
        }
        [Fact]
        public void Test_WeaponDamage()
        {
            Weapon wTest = new("", 5, 25, 25, false, WeaponType.Axe);
            Player pTest = new("", 100, 0, 0, Race.Wizard, wTest);

            var actual = pTest.CalcDamage();

            Assert.InRange(actual, 5, 25);
        }

        
    }
}