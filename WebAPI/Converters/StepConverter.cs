using Domain.Models.Recipes;
using WebAPI.Dto.Recipes;

namespace WebAPI.Converters
{
    public static class StepConverter
    {
        public static List<Step> ConvertStepListFromDto(this List<StepDto> stepDtos)
        {
            List<Step> stepList = new List<Step>();

            foreach (StepDto stepDto in stepDtos)
            {
                stepList.Add(new Step
                {
                    Number = stepDto.Number,
                    Description = stepDto.Description,
                }
                            );
            }
            return stepList;
        }

        public static List<StepDto> ConvertStepListToDto(this List<Step> steps)
        {
            List<StepDto> stepDtos = new List<StepDto>();

            foreach (Step step in steps)
            {
                stepDtos.Add(new StepDto { Number = step.Number, Description = step.Description });
            }

            return stepDtos;
        }
    }

}
