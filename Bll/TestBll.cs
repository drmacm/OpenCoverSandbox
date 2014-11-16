using IBll;
namespace Bll
{
    public class TestBll : ITestBll
    {
        public int Method1(int id)
        {
            if (id < 100)
                return MultiplyBy2(id);
            else
                return 9999;
        }

        private int MultiplyBy2(int id)
        {
            return id * 2;
        }
    }
}
