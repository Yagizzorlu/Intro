using Intro.DataAccess.Abstracts;
using Intro.DataAccess.Concretes;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business;

public class CourseManager
{
    //dependency injection

    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)   //Beni new'leyen,bana bu interface'i implement eden bir şey vermek zorunda.
    {
        _courseDal = courseDal;
    }

    public List<Course> GetAll()   //bu bir operasyondur. 
    {
        return _courseDal.GetAll();
        //normalde veri kaynağından çekeceğiz.
        //Console.WriteLine("Kurslar listelendi.");
    }
}
