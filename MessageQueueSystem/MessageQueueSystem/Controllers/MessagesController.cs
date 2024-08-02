using MessageQueueSystem.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class MessagesController : ControllerBase
{
    private readonly IMessageQueueService _messageQueueService;

    public MessagesController(IMessageQueueService messageQueueService)
    {
        _messageQueueService = messageQueueService;
    }

    [HttpPost]
    public IActionResult Post([FromBody] string message)
    {
        _messageQueueService.SendMessage(message);
        return Ok("Message sent to queue");
    }
}
