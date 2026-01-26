
namespace TicketingSystem.ServiceManagement.Controllers.Item
{

    [Authorize]
    public class ItemController : ApiBaseController
    {
        private readonly IMediator _mediator;
        public ItemController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<ResponseDTO> PostItem(PostItemCommand command) => await _mediator.Send(command);

        [HttpGet]
        [Route("{id}")]
        public async Task<ResponseDTO> GetItemById(Guid id) => await _mediator.Send(new GetItemByIdQuery(id));

        [HttpGet]
        public async Task<ResponseDTO> GetAllItems(int pageNumber, int pageSize) => await _mediator.Send(new GetAllItemsQuery(pageNumber, pageSize));

        [HttpPut]
        [Route("{id}")]
        public async Task<ResponseDTO> PutItem([FromRoute] Guid id, PutItemCommand command)
        {
            return await _mediator.Send(new PutItemCommand()
            {
                ItemId = id,
                Item = command.Item
            });
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ResponseDTO> DeleteItem(Guid id) => await _mediator.Send(new DeleteItemCommand(id));

        [HttpGet("getItemByRequestTemplateId/id")]
        public async Task<ResponseDTO> GetItemById([FromQuery] GetItemByRequestTemplateIdQuery getItemByRequestTemplateIdQuery) => await _mediator.Send(getItemByRequestTemplateIdQuery);
    }
}
