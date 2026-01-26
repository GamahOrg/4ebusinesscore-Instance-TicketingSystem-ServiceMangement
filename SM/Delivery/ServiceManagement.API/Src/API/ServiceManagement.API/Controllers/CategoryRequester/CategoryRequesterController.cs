namespace TicketingSystem.ServiceManagement.Controllers.CategoryRequester
{

    public class CategoryRequesterController : ApiBaseController
    {
        private readonly IMediator _mediator;
        public CategoryRequesterController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ResponseDTO> PostCategoryRequester(PostCategoryRequesterCommand command) => await _mediator.Send(command);

        [HttpPut]
        public async Task<ResponseDTO> PutCategoryRequester(PutCategoryRequesterCommand command) => await _mediator.Send(command);

        [HttpDelete]
        public async Task<ResponseDTO> DeleteCategoryRequester(DeleteCategoryRequesterCommand command) => await _mediator.Send(command);
    }
}
