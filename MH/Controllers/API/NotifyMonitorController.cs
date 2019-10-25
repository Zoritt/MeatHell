using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MH.Models;
using MH.Data;

namespace MH.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotifyMonitorController : ControllerBase
    {
        ApplicationDbContext _repo;

        public NotifyMonitorController(ApplicationDbContext applicationDbContext)
        {
            _repo = applicationDbContext;
        }

        public IEnumerable<Notify> GetNotifys()
        {
            return _repo.Notifys.ToList();
        }

        ~NotifyMonitorController()
        {
            _repo.Dispose();
        }
    }
}