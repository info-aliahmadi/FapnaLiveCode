using FapnaLiveCode;

namespace Fapna.LiveCoding.BackEnd.UnitTests.TestCases;

public class StringTests
{
    [Theory]
    [InlineData("Ali", false)]
    [InlineData("AlilA", true)]
    [InlineData("Aibohphobia", false)]
    [InlineData("AibohphobiA", true)]
    [InlineData("AA", true)]
    [InlineData("", false)]
    public void IsPalindrome(string str, bool expectedResult)
    {
        var resultNoLinq = StringHelpers.IsPalindrome(str);

        Assert.Equal(expectedResult, resultNoLinq);
    }

    [Theory]
    [InlineData("Testing the word length", "the word length Testing")]
    [InlineData("Hello my name is Ali", "my is Ali name Hello")]
    public void SortByWordLengthNoLinq(
        string str, string expectedResult)
    {
        var resultNoLinq = StringHelpers.SortByWordLengthNoLinq(str);

        Assert.Equal(expectedResult, resultNoLinq);
    }

    [Theory]
    [InlineData("Testing the word length", "the word length Testing")]
    [InlineData("Hello my name is Ali", "my is Ali name Hello")]
    public void SortByWordLengthWithLinq(
        string str, string expectedResult)
    {
        var resultWithLinq = StringHelpers.SortByWordLengthWithLinq(str);

        Assert.Equal(expectedResult, resultWithLinq);
    }

    [Theory]
    [InlineData("aab", "xxy", true)]
    [InlineData("aab", "xyz", false)]
    [InlineData("Ali", "raw", true)]
    public void AreIsomorphic(
        string str1, string str2, bool expectedResult)
    {
        var result = StringHelpers.AreIsomorphic(str1, str2);

        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData("aab", "baa")]
    [InlineData("rezaaa", "aaazer")]
    [InlineData("Ali", "ilA")]
    public void ReverseString(
        string str1, string expectedResult)
    {
        var result = StringHelpers.ReverseString(str1);

        Assert.Equal(expectedResult, result);
    }
}