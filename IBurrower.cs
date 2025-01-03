using System.Data;

namespace DataLayer
{
    public interface IBorrower
    {
        object BorrowReader(IDataReader reader);
    }
}
// incorrect attempt
// public interface IBorrower (IDataReader dataReader){
//     public static BorrowReader();
// }