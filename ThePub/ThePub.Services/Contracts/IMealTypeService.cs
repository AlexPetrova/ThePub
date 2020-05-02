using System.Collections.Generic;
using ThePub.Data.DTO;

namespace ThePub.Services.Contracts
{
    public interface IMealTypeService
    {
        IReadOnlyCollection<MealTypeDTO> GetAllMealTypes(string userRole);
    }
}
