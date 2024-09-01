namespace ElemPut.Models
{
    public class Table
    {
        public List<Dictionary<string, string>> Body { get; set; }
        public int TotalItems { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages => (int)Math.Ceiling((double)TotalItems / PageSize);

        public IEnumerable<Dictionary<string, string>> GetCurrentPageData()
        {
            return Body
                .Skip((CurrentPage - 1) * PageSize)
                .Take(PageSize);
        }
    }
}