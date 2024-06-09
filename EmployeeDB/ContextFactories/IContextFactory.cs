using EmployeeDB.Contexts;

namespace EmployeeDB.ContextFactories
{
    public interface IContextFactory
    {
        public Context Create();
    }
}
