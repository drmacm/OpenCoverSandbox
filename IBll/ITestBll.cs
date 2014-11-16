
namespace IBll
{
    //[ContractClass(typeof(ITestBllContract))]
    public interface ITestBll
    {
        int Method1(int id);
    }


    //[ContractClassFor(typeof(ITestBll))]
    //internal abstract class ITestBllContract : ITestBll
    //{
    //    public int Method1(int id)
    //    {
    //        Contract.Requires<ArgumentException>(id > 0, "Value must be greater than zero");

    //        return default(int);
    //    }
    //}
}
