using JWT_Project.Models;

namespace JWT_Project.Interfaces;

public interface IBookService
{
    public Task<List<BookTitle>> GetBookTitlesAsync();
    public Task<BookInformation> GetBookInformationByIdAsync(GetBookInformationByIdRequest request);
}
