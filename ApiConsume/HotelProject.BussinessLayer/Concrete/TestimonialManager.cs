using HotelProject.BussinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BussinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {

        private readonly ITestimonialDal _testimonialdal;
        public TestimonialManager(ITestimonialDal t)
        {
            _testimonialdal = t;
        }
        public Testimonial TGetById(int id)
        {
            return _testimonialdal.GetByID(id);
        }

        public void TDelete(Testimonial entity)
        {
            _testimonialdal.Delete(entity);
        }

        public List<Testimonial> TGetList()
        {
            return _testimonialdal.GetList();
        }

        public void TInsert(Testimonial entity)
        {
           _testimonialdal.insert(entity);
        }

        public void TUpdate(Testimonial entity)
        {
            _testimonialdal.Update(entity);
        }
    }
}
