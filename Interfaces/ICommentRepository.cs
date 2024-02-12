using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiDotNet8.Models;

namespace webapiDotNet8.Interfaces
{
    public interface ICommentRepository
    {
        Task<List<Comment>> GetAllAsync();
        Task<Comment?> GetByIdAsync(int id);
        Task<Comment> CreateAsync(Comment commentModel);
        Task<Comment?> UpdateAsync(int id, Comment commentModel);
        Task<Comment?> DeleteAsync(int id);
    }
}