using StudentManagementAPI.Models;

namespace StudentManagementAPI.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAllAsync();
        Task<Student?> GetByIdAsync(int id);
        Task<Student> CreateAsync(Student student);
        Task UpdateByIdAsync(Student student);
        Task DeleteAsync(Student student);
    }
}
