namespace TicketingSystem.ServiceManagement.Controllers.ItemRequester
{

    public class ItemRequesterController : ApiBaseController
    {
        private readonly IMediator _mediator;
        public ItemRequesterController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ResponseDTO> PostItemRequester(PostItemRequesterCommand command) => await _mediator.Send(command);

        [HttpPut]
        public async Task<ResponseDTO> PutItemRequester(PutItemRequesterCommand command) => await _mediator.Send(command);

        [HttpDelete]
        public async Task<ResponseDTO> DeleteItemRequester(DeleteItemRequesterCommand command) => await _mediator.Send(command);
    }
}
