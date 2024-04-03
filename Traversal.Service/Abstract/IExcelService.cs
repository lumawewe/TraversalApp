
namespace Traversal.Service.Abstract
{
    public interface IExcelService
    {
        byte[] ExcelList<T>(List<T> t) where T : class;
    }
}
