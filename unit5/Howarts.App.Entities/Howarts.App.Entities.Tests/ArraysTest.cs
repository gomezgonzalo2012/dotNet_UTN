using System.Collections;
namespace Howarts.App.Entities.Tests
{
    public class ArraysTest
    {
        [Fact]
        public void Array_initializing()
        {
            string[] arreglo = new string[4];
            arreglo[0] = "A";
            arreglo[1] = "B";
            arreglo[2] = "C";
            arreglo[3] = "D";
            
            Assert.Contains("A", arreglo);
            Assert.Contains("B", arreglo);
            Assert.Contains("c".ToUpper(), arreglo);
            Assert.Contains("A", arreglo);
            
        }

        [Fact]
        public void ArrayList_should_contain_any_type()
        {
            ArrayList array = new ArrayList();
            array.Add("A");
            array.Add(new Muggle());
            array.Add(false);

            Assert.IsType<Muggle>(array[1]); // verify the type
        }
    }
}