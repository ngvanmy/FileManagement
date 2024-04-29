using EasyAbp.FileManagement.Files;
using EasyAbp.FileManagement.Users;
using MongoDB.Driver;
using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace EasyAbp.FileManagement.MongoDB
{
    [ConnectionStringName(FileManagementDbProperties.ConnectionStringName)]
    public class FileManagementMongoDbContext : AbpMongoDbContext, IFileManagementMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */
public IMongoCollection<File> Files => Collection<File>();
public IMongoCollection<FileUser> FileUsers => Collection<FileUser>();
        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureFileManagement();
        }
    }
}