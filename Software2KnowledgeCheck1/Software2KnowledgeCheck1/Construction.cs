using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2KnowledgeCheck1
{
    public class Construction
    {
        public void CreateUnit<T>(T building, List<Building> buildings) where T : Building
        {
            // Get materials
            var materialRepo = new MaterialsRepo();
            var materialsNeeded = materialRepo.GetMaterials();

            var permitRepo = new ZoningAndPermitRepo();

            var buildingWasMade = ConstructBuilding<Apartment>(materialsNeeded, permitRepo.GetPermit(), permitRepo.ZoningApproves());

            if (buildingWasMade)
            {
                buildings.Add(building);
            }
        }
        public bool ConstructBuilding<T>(List<Materials> materials, bool permit, bool zoning) where T : Building
        {
            if (permit && zoning)
            {
                foreach (var material in materials)
                {
                    var firststep = material.MaterialConstructionFirstStep();
                    Console.WriteLine($"{firststep}");

                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
