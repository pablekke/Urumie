using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp;

namespace WebAppReact.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TareaController : ControllerBase
	{

		private readonly WebContext _webContext;

        public TareaController(WebContext context)
        {
            
			_webContext = context;	
        }
		//[HttpGet]
		//[Route("lista")]
		//public async Task<IActionResult> Lista(){

		//	List<Tarea> lista = _webContext.Tareas.OrderByDescending
		//}

		//  }
	}
}