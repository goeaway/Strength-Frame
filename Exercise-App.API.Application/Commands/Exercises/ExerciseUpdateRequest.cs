using Exercise_App.API.Application.Models.DTO;
using MediatR;

namespace Exercise_App.API.Application.Commands.Exercises
{
    public class ExerciseUpdateRequest : IRequest<ExerciseUpdateResponse>
    {
        public ExerciseDTO DTO { get; set; }

        public ExerciseUpdateRequest(ExerciseDTO dto)
        {
            DTO = dto;
        }
    }
}