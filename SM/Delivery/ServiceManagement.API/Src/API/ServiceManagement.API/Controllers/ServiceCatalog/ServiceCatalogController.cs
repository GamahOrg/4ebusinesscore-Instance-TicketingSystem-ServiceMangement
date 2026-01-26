namespace TicketingSystem.ServiceManagement.Controllers.ServiceCatalog
{

    public class ServiceCatalogController : ApiBaseController
    {
        private readonly IMediator _mediator;
        public ServiceCatalogController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<ResponseDTO> GetServiceCatalogById(Guid id) => await _mediator.Send(new GetServiceCatalogByIdQuery(id));

        [HttpGet]
        public async Task<ResponseDTO> GetAllServiceCatalog(int pageNumber, int pageSize)
        {
            return await _mediator.Send(new GetAllServiceCatalogQuery(new PaginationModel(pageNumber, pageSize)));
        }

        [HttpPost]
        public async Task<ResponseDTO> PostServiceCatalog(PostServiceCatalogCommand command) => await _mediator.Send(command);

        [HttpPut("{id}")]
        public async Task<ResponseDTO> PutServiceCatalog(PutServiceCatalogCommand command, Guid id)
        {
            command.Id = id;
            return await _mediator.Send(command);
        }

        [HttpDelete("{id}")]
        public async Task<ResponseDTO> DeleteServiceCatalog(Guid id) => await _mediator.Send(new DeleteServiceCatalogCommand(id));
    }
}
