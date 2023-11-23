using Logic;

namespace TestLogic
{
    public class EducationalElementTests
    {
        [Fact]
        public void EducationalElement_NameCannotBeEmpty()
        {
            Action act = () => new EducationalElement("", 1.0f);

            Assert.Throws<Exception>(act);
        }

        [Fact]
        public void EducationalElement_CoefMustBeGreaterThanZero()
        {
            Action act = () => new EducationalElement("Test", 0.0f);

            Assert.Throws<Exception>(act);
        }
    }
}