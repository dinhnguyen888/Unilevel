using Microsoft.EntityFrameworkCore;
using Unilevel.DTOs;
using Unilevel.Models;

namespace Unilevel.Services
{
    public class DistributorService 
    {
        private readonly AppDbContext _dbContext;

        public DistributorService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddDistributorAsync(DistributorDTO distributorDto)
        {
            using var transaction = await _dbContext.Database.BeginTransactionAsync();

            try
            {
                // Thêm mới Distributor
                var distributor = new Distributor
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = distributorDto.FullName,
                    Email = distributorDto.Email,
                    PhoneNumber = distributorDto.PhoneNumber,
                    SaleManagementId = distributorDto.SaleManagement
                };

                await _dbContext.Distributor.AddAsync(distributor);

                // Thêm các SaleDistributor liên quan
                foreach (var saleId in distributorDto.Sales)
                {
                    var saleDistributor = new SaleDistributor
                    {
                        DistributorId = distributor.Id,
                        SaleStaffId = saleId
                    };

                    await _dbContext.SaleDistributor.AddAsync(saleDistributor);
                }

                await _dbContext.SaveChangesAsync();
                await transaction.CommitAsync();
            }
            catch
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

        public async Task UpdateDistributorAsync(string id, DistributorDTO distributorDto)
        {
            using var transaction = await _dbContext.Database.BeginTransactionAsync();

            try
            {
                // Lấy distributor từ database
                var distributor = await _dbContext.Distributor.FindAsync(id);
                if (distributor == null)
                    throw new Exception("Distributor not found");

                // Cập nhật thông tin distributor
                distributor.UserName = distributorDto.FullName;
                distributor.Email = distributorDto.Email;
                distributor.PhoneNumber = distributorDto.PhoneNumber;
                distributor.SaleManagementId = distributorDto.SaleManagement;

                // Xóa các SaleDistributor cũ
                var existingSaleDistributors = _dbContext.SaleDistributor
                    .Where(sd => sd.DistributorId == id);
                _dbContext.SaleDistributor.RemoveRange(existingSaleDistributors);

                // Thêm mới các SaleDistributor
                foreach (var saleId in distributorDto.Sales)
                {
                    var saleDistributor = new SaleDistributor
                    {
                        DistributorId = distributor.Id,
                        SaleStaffId = saleId
                    };

                    await _dbContext.SaleDistributor.AddAsync(saleDistributor);
                }

                await _dbContext.SaveChangesAsync();
                await transaction.CommitAsync();
            }
            catch
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

        public async Task DeleteDistributorAsync(string id)
        {
            using var transaction = await _dbContext.Database.BeginTransactionAsync();

            try
            {
                // Xóa SaleDistributor liên quan
                var relatedSaleDistributors = _dbContext.SaleDistributor
                    .Where(sd => sd.DistributorId == id);
                _dbContext.SaleDistributor.RemoveRange(relatedSaleDistributors);

                // Xóa Distributor
                var distributor = await _dbContext.Distributor.FindAsync(id);
                if (distributor == null)
                    throw new Exception("Distributor not found");

                _dbContext.Distributor.Remove(distributor);

                await _dbContext.SaveChangesAsync();
                await transaction.CommitAsync();
            }
            catch
            {
                await transaction.RollbackAsync();
                throw;
            }
        }
    }
}
