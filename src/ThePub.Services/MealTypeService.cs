using System.Collections.Generic;
using System.Linq;
using ThePub.Data;
using ThePub.Data.DTO;
using ThePub.Services.Contracts;

namespace ThePub.Services
{
    public class MealTypeService : IMealTypeService
    {
        private readonly PubDbContext context;

        public MealTypeService(PubDbContext context)
        {
            this.context = context;
        }

        public IReadOnlyCollection<MealTypeDTO> GetAllMealTypes(string userRole)
        {
            var mealTypes = this.context.MealTypes
                .Select(mt => new MealTypeDTO
                {
                    Id = mt.Id,
                    Name = mt.Name,
                    Meals = mt.Meals
                        .Select(m => new MealDTO { Id = m.Id, Name = m.Name })
                        .ToList()
                })
                .ToList();

            if (userRole == Constants.KnowsTheRightPeopleRoleName)
            {
                mealTypes.Add(mealTypes.First(x => x.Id == Constants.DessertMealTypeId));
            }

            return mealTypes;
        }
    }
}
