using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HPPanelServices.Business.Implementations;
using HPPanelServices.Business.Interfaces;
using HPPanelServices.Data;
using HPPanelServices.Data.Repository.Implementations;
using HPPanelServices.Model.DataObject;
using Microsoft.AspNetCore.Mvc;

namespace HPPanelServices.API.Controllers
{
    public class UserController : Controller
    {
        private IUserService _userService;
        public UserController(UnitOfWork<HPPanelDBConext> unitOfWork)
        {
            _userService = new UserService(unitOfWork);
        }

        [HttpPost]
        [Route("DefaultUserLogin")]
        public async Task<ResponseDTO<DefaultUserDTO>> DefaultUserLogin(RequestDTO<string> request)
        {
            return await _userService.DefaultUserLogin(request);
        }
    }
}