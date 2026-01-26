namespace TicketingSystem.ServiceManagement.Controllers.ServiceCatalogRequesters
{

    public class ServiceCatalogRequesterController : ApiBaseController
    {
        private readonly IMediator _mediator;

        public ServiceCatalogRequesterController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ResponseDTO> PostRequester(PostServiceCatalogRequestersCommand command) => await _mediator.Send(command);

        [HttpPut]
        public async Task<ResponseDTO> PutRequester(PutServiceCatalogRequestersCommand command) => await _mediator.Send(command);

        [HttpDelete]
        public async Task<ResponseDTO> DeleteRequester(DeleteServiceCatalogRequesterCommand command) => await _mediator.Send(command);
    }
}
