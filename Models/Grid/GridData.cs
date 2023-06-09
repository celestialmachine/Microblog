namespace Microblog.Models
{
    public class GridData
    {
        //public properties for model binding
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 5;
        public string SortDirection { get; set; } = "desc";
        public string FilterCategory { get; set; } = "all";

        public int GetTotalpages(int count) => (count + PageSize - 1) / PageSize;

        public  void SetFilterAndDirection(string filter, GridData current)
        {
            FilterCategory = filter;
        }

        public void SetFilter(string filter) => FilterCategory = filter;

        public void SetDirection(GridData current)
        {
            if (current.SortDirection == "desc")
            {
                SortDirection = "asc";
            }
            else
            {
                SortDirection= "desc";
            }
        }

        //make copy of self
        public GridData Clone() => (GridData)MemberwiseClone();

        public Dictionary<string, string> ToDictionary() =>
            new Dictionary<string, string>
            {
                { nameof(PageNumber), PageNumber.ToString() },
                { nameof(PageSize), PageSize.ToString() },
                { nameof(FilterCategory), FilterCategory },
                { nameof(SortDirection), SortDirection },
            };
    }
}
