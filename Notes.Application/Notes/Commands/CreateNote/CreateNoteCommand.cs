using MediatR;

namespace Notes.Application.Notes.Commands.CreateNote;

public class CreateNoteCommand : IRequest<Guid>
{
    public Guid UserID { get; set; }
    public string Title { get; set; }
    public string Details { get; set; }
}