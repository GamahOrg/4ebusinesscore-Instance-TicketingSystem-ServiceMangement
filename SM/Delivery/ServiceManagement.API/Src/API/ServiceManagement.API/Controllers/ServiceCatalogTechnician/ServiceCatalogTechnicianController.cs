namespace TicketingSystem.ServiceManagement.Controllers.ServiceCatalogTechnician
{

    public class ServiceCatalogTechnicianController : ApiBaseController
    {
        private readonly IMediator _mediator;

        public ServiceCatalogTechnicianController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<ResponseDTO> GetAllTechnicians(Guid id)
        {
            return await _mediator.Send(new GetAllServiceCatalogTechnicinasQuery(id));
        }

        [HttpPost]
        public async Task<ResponseDTO> PostServiceCatalogTech(PostServiceCatalogTechniciansCommandd command) => await _mediator.Send(command);

        [HttpPut]
        public async Task<ResponseDTO> PutServiceCatalogTech(PutServiceCatalogTechniciansCommand command) => await _mediator.Send(command);

        [HttpDelete]
        public async Task<ResponseDTO> PostServiceCatalogTech(DeleteServiceCatalogTechnicianCommand command) => await _mediator.Send(command);

    }
}
