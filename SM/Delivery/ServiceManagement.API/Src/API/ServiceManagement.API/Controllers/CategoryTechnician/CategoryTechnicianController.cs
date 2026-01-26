namespace TicketingSystem.ServiceManagement.Controllers.CategoryTechnician
{

    public class CategoryTechnicianController : ApiBaseController
    {
        private readonly IMediator _mediator;
        public CategoryTechnicianController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ResponseDTO> PostCategoryTechnician(PostCategoryTechnicianCommand command) => await _mediator.Send(command);

        [HttpPut]
        public async Task<ResponseDTO> PutCategoryTechnician(PutCategoryTechnicianCommand command) => await _mediator.Send(command);

        [HttpDelete]
        public async Task<ResponseDTO> DeleteCategoryTechnician(DeleteCategoryTechnicianCommand command) => await _mediator.Send(command);

        [HttpGet]
        [Route("CategoryId")]
        public async Task<ResponseDTO> GetAllCategoryTechnicians(Guid id)
        {
            return await _mediator.Send(new GetAllCategoryTechnicianQuery(id));
        }
    }
}
