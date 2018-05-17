using HPPanelServices.Model.DataObject;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HPPanelServices.Business.Interfaces
{
    public interface IUserService
    {
        Task<ResponseDTO<DefaultUserDTO>> DefaultUserLogin(RequestDTO<string> request);


    }
}
