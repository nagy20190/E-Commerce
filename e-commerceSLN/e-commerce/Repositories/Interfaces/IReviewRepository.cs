using e_commerce.Models;

namespace e_commerce.Repositories.Interfaces
{
    public interface IReviewRepository
    {
        public void Add(Review review);
        public void Update(Review review);
        public void Delete(int id);
        public Review GetById(int id);
        public List<Review> GetAll();
        public List<Review> GetAllByCustomerId(int id);
        public List<Review> GetAllByProductId(int id);
        public void Save();
    }
}
