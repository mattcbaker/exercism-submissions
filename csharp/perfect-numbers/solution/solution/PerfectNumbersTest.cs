using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Constraints;

[TestFixture]
public class PerfectNumbersTest
{
    [TestCase(3)]
    [TestCase(7)]
    [TestCase(13)]
    public void Can_classify_deficient_numbers(int number)
    {
        Assert.That(PerfectNumbers.Classify(number), Is.EqualTo(NumberType.Deficient));
    }
    
    [TestCase(6)]
    [TestCase(28)]
    [TestCase(496)]
    public void Can_classify_perfect_numbers(int number)
    {
        Assert.That(PerfectNumbers.Classify(number), Is.EqualTo(NumberType.Perfect));
    }
    
    [TestCase(12)]
    [TestCase(18)]
    [TestCase(20)]
    public void Can_classify_abundant_numbers(int number)
    {
        Assert.That(PerfectNumbers.Classify(number), Is.EqualTo(NumberType.Abundant));
    }
}

public enum NumberType
{
    Deficient,
    Perfect,
    Abundant
}

public class PerfectNumbers
{
    public static NumberType Classify(int number)
    {
        var sum = Enumerable.Range(1, number - 1)
            .Sum(x => (number%x == 0) ? x : 0);

        if (sum < number) return NumberType.Deficient;
        if (sum == number) return NumberType.Perfect;

        return NumberType.Abundant;
    }
}