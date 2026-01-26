


using Newtonsoft.Json;

namespace _4EPlatForm.Infrastructure.Context;
public class ContextSeedData
{
    private static DBContext _dbContext;


    public static void Seed(DBContext appDbContext)
    {
        _dbContext = appDbContext;
        _dbContext.Database.EnsureCreated();
        // call functions
        SeedMainClassificaton();
        SeedElectronicsServices();
        SeedMainClassificationtTitleDetailes();
    }
    private static void SeedMainClassificaton()
    {
        if (!_dbContext.MainClassifications.Any())
        {


            string mainClassificationAsJson = File.ReadAllText(@"SeedData" + Path.DirectorySeparatorChar + "MainClassification.json");

            var mainClassificationModels = JsonConvert.DeserializeObject<List<MainClassification>>(mainClassificationAsJson);

            _dbContext.MainClassifications.AddRange(mainClassificationModels);

            _dbContext.SaveChanges();
        }
    }
    private static void SeedMainClassificationtTitleDetailes()
    {
        if (!_dbContext.MainClassificationtTitleDetailes.Any())
        {


            string mainClassificationAsJson = File.ReadAllText(@"SeedData" + Path.DirectorySeparatorChar + "MainClassificationtTitleDetailes.json");

            var mainClassificationModels = JsonConvert.DeserializeObject<List<MainClassificationtTitleDetailes>>(mainClassificationAsJson);

            _dbContext.MainClassificationtTitleDetailes.AddRange(mainClassificationModels);

            _dbContext.SaveChanges();
        }
        else
        {
            string mainClassificationAsJson = File.ReadAllText(@"SeedData" + Path.DirectorySeparatorChar + "MainClassificationtTitleDetailes.json");

            var mainClassificationModels = JsonConvert.DeserializeObject<List<MainClassificationtTitleDetailes>>(mainClassificationAsJson);

            var mainClassification = _dbContext.MainClassificationtTitleDetailes.ToList();
            mainClassificationModels.ForEach(n =>
            {
                var x=mainClassification.FirstOrDefault(a=>a.Id==n.Id);
                if (x != null)
                {

                    x.Title = n.Title;
                    x.TitleDescription = n.TitleDescription;
                    x.CatalogDescription = n.CatalogDescription;
                    x.CategoryDescription = n.CategoryDescription;
                    x.ItemDescription = n.ItemDescription;
                    x.SubjectDescription = n.SubjectDescription;
                    x.MainClassificationDescription = n.MainClassificationDescription;
                    x.MainClassificationId = n.MainClassificationId;
                    x.ServiceType = n.ServiceType;
                    x.DefaultCheck = n.DefaultCheck;
                    _dbContext.MainClassificationtTitleDetailes.Update(x);
                    _dbContext.SaveChanges();
                }

            });
        }
    }
    private static void SeedElectronicsServices()
    {
        if (!_dbContext.StaticElectronicsServices.Any())
        {


            string mainClassificationAsJson = File.ReadAllText(@"SeedData" + Path.DirectorySeparatorChar + "ElectronicsServices.json");

            var ElectronicsServices = JsonConvert.DeserializeObject<List<StaticElectronicsServices>>(mainClassificationAsJson);

            _dbContext.StaticElectronicsServices.AddRange(ElectronicsServices);

            _dbContext.SaveChanges();
        }
        else
        {
            string mainClassificationAsJson = File.ReadAllText(@"SeedData" + Path.DirectorySeparatorChar + "ElectronicsServices.json");

            var ElectronicsServices = JsonConvert.DeserializeObject<List<StaticElectronicsServices>>(mainClassificationAsJson);

            var main = _dbContext.StaticElectronicsServices.ToList();

            ElectronicsServices.ForEach(n =>
            {
                var electronic = main.FirstOrDefault(x => x.Id == n.Id);
                if (electronic == null)
                    _dbContext.StaticElectronicsServices.Add(n);
                else
                {
                    electronic.Id = n.Id;
                    electronic.Name = n.Name;
                    electronic.Description = n.Description;
                    electronic.Link = n.Link;
                    electronic.Icon = n.Icon;
                    electronic.workspacekey = n.workspacekey;
                    _dbContext.StaticElectronicsServices.Update(electronic);

                }

            });
            _dbContext.SaveChanges();

        }
    }
}