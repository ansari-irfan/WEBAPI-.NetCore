using HPPanelServices.Business.Interfaces;
using HPPanelServices.Data.Repository.Interfaces;
using HPPanelServices.Model.DataObject;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HPPanelServices.Business.Implementations
{
    public class UserService : IUserService
    {
        private IUnitOfWork unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public Task<ResponseDTO<DefaultUserDTO>> DefaultUserLogin(RequestDTO<string> request)
        {
            throw new NotImplementedException();
        }
    }
}
