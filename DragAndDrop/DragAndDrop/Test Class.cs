using DragAndDrop.Driver.SeleniumPOM.Driver;
using DragAndDrop.Page;

namespace DragAndDrop
{
    public class TestClass
    {
        DragAndDropPage dragAndDrop;
        
        [SetUp]
        public void BeforeScenario()
        {
            
            WebDriver.Initialize();
            dragAndDrop = new DragAndDropPage();
        }
        [TearDown]

        public void AfterScenario()
        {

            WebDriver.CleanUp();

        }

           



        [Test]
        public void Test1()
        {
            dragAndDrop.MoveObject();
        }
        

    }


}