namespace TicketingSystem.ServiceManagement.Controllers.MainClassification
{

    [Authorize]
    public class MainClassificationController : ApiBaseController
    {
        private readonly IMediator _mediator;

        public MainClassificationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<ResponseDTO> GetMainClassificationById(Guid id) => await _mediator.Send(new GetMainClassificationByIdQuery(id));

        [HttpGet]
        public async Task<ResponseDTO> GetAllMainClassification(int pageNumber, int pageSize, string? search = null, Guid? SubSystemId = null)
        {
            return await _mediator.Send(new GetAllMainClassificationQuery(new PaginationModel(pageNumber, pageSize), search, SubSystemId));
        }
        [HttpGet("GetAllMainClassificationUserloginQuery")]
        public async Task<ResponseDTO> GetAllMainClassificationUserloginQuery(int pageNumber, int pageSize, string? search = null)
        {
            return await _mediator.Send(new GetAllMainClassificationUserloginQuery(new PaginationModel(pageNumber, pageSize), search));
        }
        [HttpGet("GetAllMainClassificationUserlogintechnacian")]
        public async Task<ResponseDTO> GetAllMainClassificationUserlogintechnacian(int pageNumber, int pageSize, Guid? SubSystemId)
        {
            return await _mediator.Send(new GetAllMainClassificationUserlogintechnacianQuery(new PaginationModel(pageNumber, pageSize), SubSystemId));
        }

        [HttpGet("GetTree/{id}")]
        public async Task<ResponseDTO> GetMainClassificationTree(Guid id)
        {
            return await _mediator.Send(new GetMainClassificationTreeByIdQuery(id));
        }

        [HttpPost]
        public async Task<ResponseDTO> PostMainClassification(PostMainClassificationCommand command) => await _mediator.Send(command);

        [HttpPut("{id}")]
        public async Task<ResponseDTO> PutMainClassification(Guid id, PutMainClassificationCommand command)
        {
            command.Id = id;
            return await _mediator.Send(command);
        }

        [HttpDelete("{id}")]
        public async Task<ResponseDTO> DeleteMainClassification(Guid id) => await _mediator.Send(new DeleteMainClassificationCommand(id));



        //ElectronicsServices

        [HttpGet("GetAllElectronicsServices")]
        public async Task<ResponseDTO> GetAllElectronicsServices()
        {
            return await _mediator.Send(new GetAllElectronicsServicesQuery());
        }


        [HttpGet("GetElectronicsServicesByMainId/{id}")]
        public async Task<ResponseDTO> GetElectronicsByMainId(Guid id) => await _mediator.Send(new GetElectronicsByMainIdQuery(id));
        [HttpPut("PutManiclassifficationSecuance")]
        public async Task<ResponseDTO> PutManiclassifficationSecuance(PutSecuanceCommand command) => await _mediator.Send(command);
    }
}
