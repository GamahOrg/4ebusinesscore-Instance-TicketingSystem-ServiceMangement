namespace TicketingSystem.ServiceManagement.Controllers.MainClassificationRequester
{

    public class MainClassificationRequesterController : ApiBaseController
    {
        private readonly IMediator _mediator;

        public MainClassificationRequesterController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ResponseDTO> PostRequesters(PostMainClassificationRequestersCommand command) => await _mediator.Send(command);

        [HttpPut]
        public async Task<ResponseDTO> PutRequesters(PutMainClassificationRequestersCommand command) => await _mediator.Send(command);

        [HttpDelete]
        public async Task<ResponseDTO> DeleteRequesters(DeleteMainClassificationRequesterCommand command) => await _mediator.Send(command);
    }
}
