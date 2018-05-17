using HPPanelServices.Utility.Enums;
using System;

namespace HPPanelServices.Model.DataObject
{
    public class ResponseDTO<T>
    {
        public T Data { get; set; }
        public string Message { get; set; }
        public ResponseStatusEnum Status { get; set; }

        public string EndPoint { get; set; }
        public long TimeStamp { get; set; }

        public ResponseDTO()
        {
            Data = default(T);
            TimeStamp = DateTime.UtcNow.Ticks;
        }
    }
}
