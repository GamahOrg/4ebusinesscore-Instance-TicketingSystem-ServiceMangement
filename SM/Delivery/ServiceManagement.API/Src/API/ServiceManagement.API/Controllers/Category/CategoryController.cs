namespace TicketingSystem.ServiceManagement.Controllers.Category
{

    public class CategoryController : ApiBaseController
    {
        private readonly IMediator _mediator;
        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ResponseDTO> PostCategory(PostCategoryCommand command) => await _mediator.Send(command);

        [HttpGet]
        [Route("{id}")]
        public async Task<ResponseDTO> GetCategoryById(Guid id) => await _mediator.Send(new GetCategoryByIdQuery(id));

        [HttpGet]
        public async Task<ResponseDTO> GetAllCategories(int pageNumber, int pageSize) => await _mediator.Send(new GetAllCategoriesQuery(pageNumber, pageSize));

        [HttpPut]
        [Route("{id}")]
        public async Task<ResponseDTO> PutCategory([FromRoute] Guid id, PutCategoryCommand command)
        {
            command.CategoryId = id;
            return await _mediator.Send(command);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ResponseDTO> DeleteCategory(Guid id) => await _mediator.Send(new DeleteCategoryCommand { CategoryId = id });
    }
}
