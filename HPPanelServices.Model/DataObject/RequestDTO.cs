using HPPanelServices.Utility.Enums;

namespace HPPanelServices.Model.DataObject
{
    public class RequestDTO<T>
    {
        public int Total { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public T Data { get; set; }
        public string Sortdatafield { get; set; }
        public string SortOrder { get; set; }
        public string Message { get; set; }
        public ResponseStatusEnum Status { get; set; }

        public RequestDTO()
        {
            Total = 0;
            Page = 0;
            Data = default(T);
        }
    }
}
