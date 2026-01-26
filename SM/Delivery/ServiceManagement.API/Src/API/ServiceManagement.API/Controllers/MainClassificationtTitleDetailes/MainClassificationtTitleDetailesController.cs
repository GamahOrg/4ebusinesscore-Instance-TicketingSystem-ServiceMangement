

namespace TicketingSystem.ServiceManagement.Controllers.MainClassification
{

    [Authorize]
    public class MainClassificationtTitleDetailesController : ApiBaseController
    {
        private readonly IMediator _mediator;

        public MainClassificationtTitleDetailesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("GetMainClassificationtTitleDetailesByMainClassificationId")]
        public async Task<ResponseDTO> GetMainClassificationtTitleDetailesByMainClassificationId(Guid mainClassificationId, ServiceType? serviceType = null)
        {
            return await _mediator.Send(new GetMainClassificationtTitleDetailesByMainClassificationIdQuery
            {
                MainClassificationId = mainClassificationId,
                ServiceType = serviceType
            });
        }
        [HttpPost]
        public async Task<ResponseDTO> PostMainClassificationtTitleDetailes(PostMainClassificationtTitleDetailesCommand command) => await _mediator.Send(command);

        [HttpPut]
        public async Task<ResponseDTO> PutMainClassificationtTitleDetailes(PutMainClassificationtTitleDetailesCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
