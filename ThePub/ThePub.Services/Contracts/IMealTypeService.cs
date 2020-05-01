using System.Collections.Generic;
using ThePub.Data.DTO;

public interface IMealTypeService
{
    IReadOnlyCollection<MealTypeDTO> GetAllMealTypes();
}