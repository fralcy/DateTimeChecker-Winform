using DateTimeChecker;

[TestClass]
public class DateValidationTests
{
    private Form? _form;

    [TestInitialize]
    public void Setup()
    {
        _form = new Form();
    }

    // Test cases for DaysInMonth
    [TestMethod]
    [DataRow((short)2024, (byte)1, (byte)31)] 
    [DataRow((short)2024, (byte)3, (byte)31)]
    [DataRow((short)2024, (byte)5, (byte)31)]
    [DataRow((short)2024, (byte)7, (byte)31)]
    [DataRow((short)2024, (byte)8, (byte)31)]
    [DataRow((short)2024, (byte)10, (byte)31)]
    [DataRow((short)2024, (byte)12, (byte)31)]

    [DataRow((short)2024, (byte)4, (byte)30)]
    [DataRow((short)2024, (byte)6, (byte)30)]
    [DataRow((short)2024, (byte)9, (byte)30)]
    [DataRow((short)2024, (byte)11, (byte)30)]

    [DataRow((short)2024, (byte)2, (byte)29)]

    [DataRow((short)2023, (byte)2, (byte)28)]

    [DataRow((short)2000, (byte)2, (byte)29)]

    [DataRow((short)1900, (byte)2, (byte)28)]

    [DataRow((short)2024, (byte)0, (byte)0)]
    [DataRow((short)2024, (byte)13, (byte)0)]
    public void DaysInMonth_ReturnsCorrectDays(short year, byte month, byte expectedDays)
    {
        byte result = _form.DaysInMonth(year, month);

        Assert.AreEqual(expectedDays, result);
    }
    // Test cases for IsValidDate
    [TestMethod]
    [DataRow((short)2000, (byte)2, (byte)29, true)]
    [DataRow((short)2000, (byte)2, (byte)30, false)]
    [DataRow((short)1900, (byte)2, (byte)28, true)]
    [DataRow((short)1900, (byte)2, (byte)29, false)]
    [DataRow((short)1000, (byte)1, (byte)1, true)]
    [DataRow((short)3000, (byte)12, (byte)31, true)]
    [DataRow((short)2024, (byte)1, (byte)31, true)]
    [DataRow((short)2024, (byte)4, (byte)15, true)]
    public void IsValidDate_ReturnsExpectedResult(short year, byte month, byte day, bool expected)
    {
        bool result = _form.IsValidDate(year, month, day);

        Assert.AreEqual(expected, result);
    }

    [TestCleanup]
    public void Cleanup()
    {
        if (_form != null)
        {
            _form.Dispose();
        }
    }
}