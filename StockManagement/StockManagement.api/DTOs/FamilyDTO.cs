using StockManagement.api.Models;

namespace StockManagement.api.DTOs
{
    public class FamilyDTO
    { 
        public string FamilyId { get; set; } = null!;
        public string FamilyName { get; set; }
        public Family DtoToFamilyModel()
        {
            Family family = new Family
            {
                FamilyId = this.FamilyId,
                FamilyName = this.FamilyName
            };
            return family;
        }

        public FamilyDTO FamilyModelToDto(Family family)
        {
            FamilyDTO dto = new FamilyDTO
            {
               
                FamilyId = family.FamilyId,
                FamilyName = family.FamilyName
              
            };

            return dto;

        }
    }
}




