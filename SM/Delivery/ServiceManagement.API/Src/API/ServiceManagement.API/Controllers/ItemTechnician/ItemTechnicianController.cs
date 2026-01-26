namespace TicketingSystem.ServiceManagement.Controllers.ItemTechnician
{

    public class ItemTechnicianController : ApiBaseController
    {
        private readonly IMediator _mediator;
        public ItemTechnicianController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ResponseDTO> PostItemTechnician(PostItemTechnicianCommand command) => await _mediator.Send(command);

        [HttpPut]
        public async Task<ResponseDTO> PutItemTechnician(PutItemTechnicianCommand command) => await _mediator.Send(command);

        [HttpDelete]
        public async Task<ResponseDTO> DeleteItemTechnician(DeleteItemTechnicianCommand command) => await _mediator.Send(command);
    }
}
