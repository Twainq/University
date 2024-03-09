using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Administration
    {
        public string name { get; set; }

        public int age { get; set; }

        public string pass { get; set; }
        public string login { get; set; }
        public List<Student> students { get; set; }
        public List<Prepod> prepods { get; set; }
        public List<Group> groups { get; set; }
        public Administration()
        {
            students = new List<Student>
            {
                new Student("Victorov A.P", 17, 1, "897979797", "peru@gmail.com","student1","student1","P11",new List<int>{ 5,4,3,2,1}),
                new Student("Egorov A.P", 17, 1, "897979797", "peru@gmail.com","student2","student2","P11",new List<int>{ 5,5,5,2,3}),
                new Student("Solomonov A.P", 17, 1, "897979797", "peru@gmail.com","student3","student3","P11",new List<int>{ 4,4,3,5,2}),
                new Student("Alekseev A.P", 17, 1, "897979797", "peru@gmail.com","student4","student4","P12" ,new List < int > { 5, 4, 4, 3, 5 }),
                new Student("Sergeev A.P", 17, 1, "897979797", "peru@gmail.com","student5","student5", "P12",new List<int>{ 3,3,4,2,4})
            };
            prepods = new List<Prepod>
            {
                new Prepod("Pavlov E.A",33,304,"math",50000,"prepod1", "prepod1"),
                new Prepod("Konovaliv U.U", 25, 215, "rus.lang",65000,"prepod2", "prepod2"),
                new Prepod("Satorov I.N", 21, 244, "physics",60000,"prepod3", "prepod3")
            };
            groups = new List<Group>
            {
                new Group("P11"),
                new Group("P12")
            };

        }
    }
}
