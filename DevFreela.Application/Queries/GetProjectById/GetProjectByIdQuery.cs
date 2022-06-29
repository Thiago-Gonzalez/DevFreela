using DevFreela.Application.ViewModels;
using MediatR;

namespace DevFreela.Application.Queries.GetProjectById
{
    public class GetProjectByIdQuery : IRequest<ProjectDetailsViewModel>
    {
        public int Id { get; private set; }
        public GetProjectByIdQuery(int id)
        {
            Id = id;
        }
    }
}
