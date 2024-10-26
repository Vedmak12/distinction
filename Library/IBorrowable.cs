namespace Library
{
    public interface IBorrowable
    {
        bool LoanItem(int itemId, int memberId);
        void ReturnItem(int itemId);
    }
}
