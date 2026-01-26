namespace TicketingSystem.ServiceManagement.Controllers.MainClassificationTechnician
{

    public class MainClassificationTechnicianController : ApiBaseController
    {
        private readonly IMediator _mediator;

        public MainClassificationTechnicianController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<ResponseDTO> GetAllTechnicians(Guid id)
        {
            return await _mediator.Send(new GetAllMainClassificationTechniciansQuery(id));
        }

        [HttpPost]
        public async Task<ResponseDTO> PostTechnicians(PostMainClassificationTechnnciansCommand command) => await _mediator.Send(command);

        [HttpPut]
        public async Task<ResponseDTO> PutTechnicians(PutMainClassificationTechniciansCommand command) => await _mediator.Send(command);

        [HttpDelete]
        public async Task<ResponseDTO> DeleteTechnicians(DeleteMainClassificationTechnicianCommand command) => await _mediator.Send(command);
    }
}
