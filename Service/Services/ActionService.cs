using Domain.Interfaces;
using Domain.Models;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ActionService
    {
        private readonly IActionRepository actionRepository;

        public ActionService(IActionRepository _actionRepository)
        {
            actionRepository = _actionRepository;
        }

        public async Task<ActionViewModel> Get(int id)
        {

        }

        public async Task Insert(ActionEntity actionEntity)
        {

        }

        public async Task Edit(ActionEntity actionEntity)
        {

        }

        public async Task Delete(int id)
        {

        }
    }
}
