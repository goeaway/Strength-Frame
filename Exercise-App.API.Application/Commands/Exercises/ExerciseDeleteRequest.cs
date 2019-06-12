using MediatR;

namespace Exercise_App.API.Application.Commands.Exercises
{
    public class ExerciseDeleteRequest : IRequest<ExerciseDeleteResponse>
    {
        public int ID { get; set; }

        public ExerciseDeleteRequest(int id)
        {
            ID = id;
        }
    }
}