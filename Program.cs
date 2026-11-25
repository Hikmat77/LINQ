////////////////////////////////////////////////////////////////////////////////////////////////////////////////////      CLASS-TASK(1)
var employees = new List<Employee>
    {
        new() {
            Id = 1, FirstName = "Ali",
            LastName = "Valiev",
            Age = 25,
            Salary = 4500,
            Experience = 3
            },
        new() {
            Id = 2,
            FirstName = "Muhammadjon",
            LastName = "Karimov",
            Age = 30,
            Salary = 6000,
            Experience = 16
            },
        new() {
            Id = 3,
            FirstName = "Sarvar",
            LastName = "Rahimov",
            Age = 40,
            Salary = 7500,
            Experience = 20
            },
        new() {
            Id = 4,
            FirstName = "Dilshod",
            LastName = "Nazarov",
            Age = 22,
            Salary = 3000,
            Experience = 1
            },
        new() {
            Id = 5,
            FirstName = "Nigora",
            LastName = "Safarova",
            Age = 35,
            Salary = 5500,
            Experience = 18
            },
        new() {
            Id = 6,
            FirstName = "Firdavs",
            LastName = "Sharipov",
            Age = 28,
            Salary = 5200,
            Experience = 6
            },
        new() {
            Id = 7,
            FirstName = "Zebo",
            LastName = "Olimova",
            Age = 45, Salary = 9000,
            Experience = 25
            }
    };


////////////////////////////////////////////////      TASK 1

// // Query syntax
// var result =
//     from employee in employees
//     select employee.Salary;


// // Method syntax
// var result = employees.Select(e => e.Salary);

// foreach (var s in result)
// {
//     System.Console.WriteLine(s);
// }

////////////////////////////////////////////////      TASK 2


// Query syntax
// var result =
//     from e in employees
//     where e.FirstName.Length > 6
//     select e;

// Method syntax
// var result = employees.Where(x => x.FirstName.Length>6);
// foreach (var e in result)
// {
//     System.Console.WriteLine($"{e.Id} {e.FirstName} {e.LastName}");
// }

////////////////////////////////////////////////      TASK 3

//Query syntax
// var result =
//     from e in employees
//     where e.Age > employees[0].Age
//     select e;

//Method syntax
// var result = employees.Where(x => x.Age>employees[0].Age);
// foreach (var e in result)
// {
//     System.Console.WriteLine($"{e.FirstName} - {e.Age}");
// }

////////////////////////////////////////////////      TASK 4

//Query syntax
// var result =
//     from e in employees
//     where e.Experience>e.Age/2
//     select e;

//Method syntax
// var result = employees.Where(x => x.Experience > x.Age / 2);
// foreach (var e in result)
// {
//     System.Console.WriteLine($"Name: {e.FirstName}, Experience: {e.Experience}, Age: {e.Age}");
// }

////////////////////////////////////////////////      TASK 5

//Query syntax 
// var result =
//     (from e in employees
//     where e.Salary>5000
//     orderby e.Experience descending
//     select e).Take(3);

//Method syntax
// var result = employees
//         .Where(x => x.Salary > 5000)
//         .OrderByDescending(x => x.Experience)
//         .Take(3);
// foreach (var e in result)
// {
//     Console.WriteLine($"{e.FirstName} - {e.Experience} - {e.Salary}");
// }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////      HOME-TASK(1)

var students = new List<Student>
    {
        new() {
            Id = 1,
            FirstName = "Ali",
            LastName = "Karimov",
            Age = 21,
            Gender = Gender.Male,
            Status = Status.Active,
            DateOfStart = new DateTime(2023, 9, 1),
            DateOfFinish = new DateTime(2027, 6, 30)
            },
        new() {
            Id = 2,
            FirstName = "Sarvar",
            LastName = "Safarov",
            Age = 25,
            Gender = Gender.Male,
            Status = Status.InActive,
            DateOfStart = new DateTime(2018, 9, 1),
            DateOfFinish = new DateTime(2021, 6, 30)
            },
        new() {
            Id = 3,
            FirstName = "Zarina",
            LastName = "Zokirova",
            Age = 19,
            Gender = Gender.Female,
            Status = Status.Active,
            DateOfStart = new DateTime(2024, 9, 1),
            DateOfFinish = new DateTime(2028, 6, 30)
            },
        new() {
            Id = 4,
            FirstName = "Ibrohim",
            LastName = "Ismoilov",
            Age = 30,
            Gender = Gender.Male,
            Status = Status.InActive,
            DateOfStart = new DateTime(2012, 9, 1),
            DateOfFinish = new DateTime(2016, 6, 30)
            },
        new() {
            Id = 5,
            FirstName = "Nigora",
            LastName = "Rahimova",
            Age = 23,
            Gender = Gender.Female,
            Status = Status.Active,
            DateOfStart = new DateTime(2020, 9, 1),
            DateOfFinish = new DateTime(2027, 6, 30)
            },
        new() {
            Id = 6,
            FirstName = "Dilshod",
            LastName = "Nazarov",
            Age = 15,
            Gender = Gender.Male,
            Status = Status.Active,
            DateOfStart = new DateTime(2023, 9, 1),
            DateOfFinish = new DateTime(2027, 6, 30)
            },
        new() {
            Id = 7,
            FirstName = "Firdavs",
            LastName = "Sharipov",
            Age = 27,
            Gender = Gender.Male,
            Status = Status.InActive,
            DateOfStart = new DateTime(2017, 9, 1),
            DateOfFinish = new DateTime(2019, 6, 30)
            },
        new() {
            Id = 8,
            FirstName = "Madina",
            LastName = "Olimova",
            Age = 22,
            Gender = Gender.Female,
            Status = Status.Active,
            DateOfStart = new DateTime(2022, 9, 1),
            DateOfFinish = new DateTime(2027, 6, 30)
            },
        new() {
            Id = 9,
            FirstName = "Aziz",
            LastName = "Akbarov",
            Age = 24,
            Gender = Gender.Male,
            Status = Status.Active,
            DateOfStart = new DateTime(2018, 9, 1),
            DateOfFinish = new DateTime(2027, 6, 30)
            }
    };


////////////////////////////////////////////////      TASK 1

// Query syntax
// var result =
//     from e in students
//     where e.Gender == Gender.Male
//     select e;

// Method syntax
// var result = students.Where(x => x.Gender == Gender.Male);
// foreach (var e in result)
// {
//     Console.WriteLine($"{e.FirstName} {e.LastName} - {e.Gender}");
// }

////////////////////////////////////////////////      TASK 2

// Query syntax
// var result =
//     from e in students
//     where e.Status == Status.InActive
//     select e;

// Method syntax
// var result = students.Where(x => x.Status == Status.InActive);
// foreach (var e in result)
// {
//     Console.WriteLine($"{e.FirstName} {e.LastName} - {e.Status}");
// }

////////////////////////////////////////////////      TASK 3

// Query syntax
// var result =
//     from e in students
//     where DateTime.Now.Year - e.Age > 2000
//     select e;

// Method syntax
// var result = students.Where(x => DateTime.Now.Year - x.Age > 2000);
// foreach (var e in result)
// {
//     Console.WriteLine($"{e.FirstName} {e.LastName} - Birth year: {DateTime.Now.Year - e.Age}");
// }

////////////////////////////////////////////////      TASK 4

// Query syntax
// var result =
//     from e in students
//     where e.Status == Status.Active && e.Age > 20
//     select e;

// Method syntax
// var result = students.Where(x => x.Status == Status.Active && x.Age > 20);
// foreach (var e in result)
// {
//     Console.WriteLine($"{e.FirstName} {e.LastName} - {e.Age} - {e.Status}");
// }

////////////////////////////////////////////////      TASK 5

// Query syntax
// var result =
//     from e in students
//     let birthYear = DateTime.Now.Year - e.Age
//     where e.DateOfStart.Year - birthYear == 16
//     select e;

// Method syntax
// var result = students.Where(x => x.DateOfStart.Year - (DateTime.Now.Year - x.Age) == 16);
// foreach (var e in result)
// {
//     Console.WriteLine($"{e.FirstName} {e.LastName} - Start: {e.DateOfStart:yyyy-MM-dd}");
// }

////////////////////////////////////////////////      TASK 6

// Query syntax
// var result =
//     from e in students
//     let birthYear = DateTime.Now.Year - e.Age
//     where e.DateOfStart.Year - birthYear >= 18
//     select e;

// Method syntax
// var result = students.Where(x => x.DateOfStart.Year - (DateTime.Now.Year - x.Age) >= 18);
// foreach (var e in result)
// {
//     Console.WriteLine($"{e.FirstName} {e.LastName} - Start: {e.DateOfStart:yyyy-MM-dd}");
// }

////////////////////////////////////////////////      TASK 7

// Query syntax
// var result =
//     from e in students
//     where e.FirstName.StartsWith("A") || e.FirstName.StartsWith("I")
//     select e;

// Method syntax
// var result = students.Where(x => x.FirstName.StartsWith("A") || x.FirstName.StartsWith("I"));
// foreach (var e in result)
// {
//     Console.WriteLine($"{e.FirstName} {e.LastName}");
// }

////////////////////////////////////////////////      TASK 8

// Query syntax
// var result =
//     from e in students
//     where e.FirstName[0] == e.LastName[0]
//     select e;

// Method syntax
// var result = students.Where(x => x.FirstName[0] == x.LastName[0]);
// foreach (var e in result)
// {
//     Console.WriteLine($"{e.FirstName} {e.LastName}");
// }

////////////////////////////////////////////////      TASK 9

// Query syntax
// var result =
//     from e in students
//     let birthYear = DateTime.Now.Year - e.Age
//     where e.DateOfStart.Year - birthYear < 18 && e.DateOfFinish.Year - birthYear >= 18
//     select e;

// Method syntax
// var result = students.Where(x =>
//     x.DateOfStart.Year - (DateTime.Now.Year - x.Age) < 18 &&
//     x.DateOfFinish.Year - (DateTime.Now.Year - x.Age) >= 18);
// foreach (var e in result)
// {
//     Console.WriteLine($"{e.FirstName} {e.LastName} - {e.Age}");
// }

////////////////////////////////////////////////      TASK 10

// Query syntax
// var result =
//     from e in students
//     where e.Gender != Gender.Female
//         && e.Status == Status.Active
//         && (e.DateOfFinish - e.DateOfStart).TotalDays > 365 * 2
//         && e.Age < 16
//     select e;

// Method syntax
// var result = students.Where(x =>
//     x.Gender != Gender.Female &&
//     x.Status == Status.Active &&
//     (x.DateOfFinish - x.DateOfStart).TotalDays > 365 * 2 &&
//     x.Age < 16);
// foreach (var e in result)
// {
//     Console.WriteLine($"{e.FirstName} {e.LastName} - {e.Age}");
// }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////      CLASS-TASK(2)

var cities = new List<City>
    {
        new() {
            Id = 1,
            Name = "Dushanbe"
            },
        new() {
            Id = 2,
            Name = "Khujand"
            },
        new() {
            Id = 3,
            Name = "Ayni"
            },
        new() {
            Id = 4,
            Name = "Kulob"
            },
        new() {
            Id = 5,
            Name = "Bokhtar"
            },
        new() {
            Id = 6,
            Name = "Ashgabat"
            }
    };

var people = new List<Person>
    {
        new() {
            Id = 1,
            Name = "Ali",
            Age = 28,
            CityId = 1
            },
        new() {
            Id = 2,
            Name = "Sarvar",
            Age = 22,
            CityId = 2
            },
        new() {
            Id = 3,
            Name = "Zarina",
            Age = 30,
            CityId = 1
            },
        new() {
            Id = 4,
            Name = "Aziz",
            Age = 6,
            CityId = 3
            },
        new() {
            Id = 5,
            Name = "Nigora",
            Age = 25,
            CityId = 2
            },
        new() {
            Id = 6,
            Name = "Omina",
            Age = 4,
            CityId = 6
            },
        new() {
            Id = 7,
            Name = "Ibrohim",
            Age = 35,
            CityId = 1
            },
        new() {
            Id = 8,
            Name = "Dilshod",
            Age = 26,
            CityId = 4
            },
        new() {
            Id = 9,
            Name = "Anvar",
            Age = 40,
            CityId = 3
            },
        new() {
            Id = 10,
            Name = "Madina",
            Age = 5,
            CityId = 5
            },
        new() {
            Id = 11,
            Name = "Umar",
            Age = 25,
            CityId = 1
            }
    };


////////////////////////////////////////////////      TASK 1

// Query syntax
// var result =
//     from p in people
//     where p.Age > 25
//     select new { p.Name, p.Age };

// Method syntax
// var result = people
//         .Where(x => x.Age > 25)
//         .Select(x => new { x.Name, x.Age });
// foreach (var e in result)
// {
//     Console.WriteLine($"{e.Name} - {e.Age}");
// }

////////////////////////////////////////////////      TASK 2

// Query syntax
// var result =
//     from p in people
//     orderby p.Age, p.Name
//     select p;

// Method syntax
// var result = people
//         .OrderBy(x => x.Age)
//         .ThenBy(x => x.Name);
// foreach (var e in result)
// {
//     Console.WriteLine($"{e.Age} - {e.Name}");
// }

////////////////////////////////////////////////      TASK 3

// Query syntax
// var result =
//     from p in people
//     group p by p.Name[0];

// Method syntax
// var result = people.GroupBy(x => x.Name[0]);
// foreach (var g in result)
// {
//     Console.WriteLine($"Letter: {g.Key}");
//     foreach (var e in g)
//     {
//         Console.WriteLine($"    {e.Name} - {e.Age}");
//     }
// }

////////////////////////////////////////////////      TASK 4

// Query syntax
// var result =
//     from p in people
//     join c in cities on p.CityId equals c.Id
//     select new { PersonName = p.Name, CityName = c.Name };

// Method syntax
// var result = people.Join(
//         cities,
//         p => p.CityId,
//         c => c.Id,
//         (p, c) => new { PersonName = p.Name, CityName = c.Name });
// foreach (var e in result)
// {
//     Console.WriteLine($"{e.PersonName} - {e.CityName}");
// }

////////////////////////////////////////////////      TASK 5

// Query syntax
// var result =
//     (from p in people
//     where "AEIOUaeiou".Contains(p.Name[0])
//     select p.Age).Sum();

// Method syntax
// var result = people
//         .Where(x => "AEIOUaeiou".Contains(x.Name[0]))
//         .Sum(x => x.Age);
// Console.WriteLine($"Total age: {result}");

////////////////////////////////////////////////      TASK 6

// Query syntax
// var result =
//     from p in people
//     group p by p.Name[0] into g
//     select new { Letter = g.Key, Count = g.Count() };

// Method syntax
// var result = people
//         .GroupBy(x => x.Name[0])
//         .Select(g => new { Letter = g.Key, Count = g.Count() });
// foreach (var e in result)
// {
//     Console.WriteLine($"{e.Letter} - {e.Count}");
// }

////////////////////////////////////////////////      TASK 7

// Query syntax
// var result =
//     (from c in cities
//     let count = people.Count(p => p.CityId == c.Id)
//     orderby count descending
//     select new { c.Name, Count = count }).Take(1);

// Method syntax
// var result = cities
//         .Select(c => new { c.Name, Count = people.Count(p => p.CityId == c.Id) })
//         .OrderByDescending(x => x.Count)
//         .Take(1);
// foreach (var e in result)
// {
//     Console.WriteLine($"{e.Name} - {e.Count}");
// }

////////////////////////////////////////////////      TASK 8

// Query syntax
// var result =
//     from p in people
//     join c in cities on p.CityId equals c.Id
//     where p.Age >= 2 && p.Age <= 7
//         && c.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase)
//     select new { p.Name, p.Age, CityName = c.Name };

// Method syntax
// var result = people
//         .Join(cities, p => p.CityId, c => c.Id, (p, c) => new { p.Name, p.Age, CityName = c.Name })
//         .Where(x => x.Age >= 2 && x.Age <= 7
//             && x.CityName.StartsWith("A", StringComparison.OrdinalIgnoreCase));
// foreach (var e in result)
// {
//     Console.WriteLine($"{e.Name} - {e.Age} - {e.CityName}");
// }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////      HOME-TASK(2)

var studentss = new List<Studentt>
    {
        new() {
            Id = 1,
            Name = "Alice",
            DateOfBirth = new DateTime(2000, 5, 15)
            },
        new() {
            Id = 2,
            Name = "Bob",
            DateOfBirth = new DateTime(1999, 8, 25)
            },
        new() {
            Id = 3,
            Name = "Charlie",
            DateOfBirth = new DateTime(2001, 3, 10)
            },
        new() {
            Id = 4,
            Name = "Diana",
            DateOfBirth = new DateTime(2002, 11, 2)
            },
        new() {
            Id = 5,
            Name = "Edward",
            DateOfBirth = new DateTime(1998, 1, 20)
            },
        new() {
            Id = 6,
            Name = "Fiona",
            DateOfBirth = new DateTime(2000, 9, 9)
            }
    };

var courses = new List<Course>
    {
        new() {
            Id = 101,
            Title = "Mathematics",
            Credits = 4
            },
        new() {
            Id = 102,
            Title = "Computer Science",
            Credits = 3
            },
        new() {
            Id = 103,
            Title = "Physics",
            Credits = 4
            },
        new() {
            Id = 104,
            Title = "Chemistry",
            Credits = 2
            }
    };

var enrollments = new List<Enrollment>
    {
        new() {
            Id = 1,
            StudentId = 1,
            CourseId = 101,
            EnrollmentDate = new DateTime(2023, 1, 15)
            },
        new() {
            Id = 2,
            StudentId = 1,
            CourseId = 102,
            EnrollmentDate = new DateTime(2023, 1, 20)
            },
        new() {
            Id = 3,
            StudentId = 2,
            CourseId = 101,
            EnrollmentDate = new DateTime(2023, 1, 18)
            },
        new() {
            Id = 4,
            StudentId = 3,
            CourseId = 103,
            EnrollmentDate = new DateTime(2023, 1, 22)
            },
        new() {
            Id = 5,
            StudentId = 3,
            CourseId = 101,
            EnrollmentDate = new DateTime(2023, 1, 25)
            },
        new() {
            Id = 6,
            StudentId = 3,
            CourseId = 102,
            EnrollmentDate = new DateTime(2023, 1, 30)
            },
        new() {
            Id = 7,
            StudentId = 4,
            CourseId = 104,
            EnrollmentDate = new DateTime(2023, 2, 2)
            },
        new() {
            Id = 8,
            StudentId = 4,
            CourseId = 101,
            EnrollmentDate = new DateTime(2023, 2, 5)
            },
        new() {
            Id = 9,
            StudentId = 5,
            CourseId = 103,
            EnrollmentDate = new DateTime(2022, 12, 10)
            },
        new() {
            Id = 10,
            StudentId = 6,
            CourseId = 102,
            EnrollmentDate = new DateTime(2023, 2, 10)
            }
    };


////////////////////////////////////////////////      TASK 1

// Query syntax
// var result =
//     from s in students
//     join e in enrollments on s.Id equals e.StudentId
//     join c in courses on e.CourseId equals c.Id
//     where c.Title == "Mathematics"
//     select s;

// Method syntax
// var result = students
//         .Join(enrollments, s => s.Id, e => e.StudentId, (s, e) => new { s, e.CourseId })
//         .Join(courses, x => x.CourseId, c => c.Id, (x, c) => new { x.s, c.Title })
//         .Where(x => x.Title == "Mathematics")
//         .Select(x => x.s);
// foreach (var e in result)
// {
//     Console.WriteLine($"{e.Id} - {e.Name}");
// }

////////////////////////////////////////////////      TASK 2

// Query syntax
// var result =
//     from s in students
//     join e in enrollments on s.Id equals e.StudentId
//     join c in courses on e.CourseId equals c.Id
//     where s.Name == "Charlie"
//     select c;

// Method syntax
// var result = students
//         .Where(x => x.Name == "Charlie")
//         .Join(enrollments, s => s.Id, e => e.StudentId, (s, e) => e.CourseId)
//         .Join(courses, courseId => courseId, c => c.Id, (courseId, c) => c);
// foreach (var e in result)
// {
//     Console.WriteLine($"{e.Id} - {e.Title} - {e.Credits}");
// }

////////////////////////////////////////////////      TASK 3

// Query syntax
// var result =
//     from e in enrollments
//     group e by e.StudentId into g
//     where g.Count() > 1
//     from s in students
//     where s.Id == g.Key
//     select s;

// Method syntax
// var result = enrollments
//         .GroupBy(x => x.StudentId)
//         .Where(g => g.Count() > 1)
//         .SelectMany(g => students.Where(s => s.Id == g.Key));
// foreach (var e in result)
// {
//     Console.WriteLine($"{e.Id} - {e.Name}");
// }

////////////////////////////////////////////////      TASK 4

// Query syntax
// var result =
//     from e in enrollments
//     join s in students on e.StudentId equals s.Id
//     join c in courses on e.CourseId equals c.Id
//     let age = DateTime.Now.Year - s.DateOfBirth.Year
//     group age by new { AgeRange = age / 5 * 5, c.Title } into g
//     select new { g.Key.AgeRange, g.Key.Title, AverageAge = g.Average() };

// Method syntax
// var result = enrollments
//         .Join(students, e => e.StudentId, s => s.Id, (e, s) => new { e.CourseId, Age = DateTime.Now.Year - s.DateOfBirth.Year })
//         .Join(courses, x => x.CourseId, c => c.Id, (x, c) => new { x.Age, c.Title })
//         .GroupBy(x => new { AgeRange = x.Age / 5 * 5, x.Title })
//         .Select(g => new { g.Key.AgeRange, g.Key.Title, AverageAge = g.Average(x => x.Age) });
// foreach (var e in result)
// {
//     Console.WriteLine($"{e.AgeRange}-{e.AgeRange + 4} | {e.Title} | {e.AverageAge}");
// }

////////////////////////////////////////////////      TASK 5

// Query syntax
// var result =
//     from s in students
//     join e in enrollments on s.Id equals e.StudentId
//     join c in courses on e.CourseId equals c.Id
//     where e.EnrollmentDate >= new DateTime(2023, 1, 20) && c.Credits >= 4
//     select new { s.Name, c.Title, c.Credits, e.EnrollmentDate };

// Method syntax
// var result = students
//         .Join(enrollments, s => s.Id, e => e.StudentId, (s, e) => new { s.Name, e.CourseId, e.EnrollmentDate })
//         .Join(courses, x => x.CourseId, c => c.Id, (x, c) => new { x.Name, c.Title, c.Credits, x.EnrollmentDate })
//         .Where(x => x.EnrollmentDate >= new DateTime(2023, 1, 20) && x.Credits >= 4);
// foreach (var e in result)
// {
//     Console.WriteLine($"{e.Name} - {e.Title} - {e.Credits} - {e.EnrollmentDate:yyyy-MM-dd}");
// }

////////////////////////////////////////////////      TASK 6

// Query syntax
// var result =
//     from s in students
//     let total = (from e in enrollments
//                  join c in courses on e.CourseId equals c.Id
//                  where e.StudentId == s.Id
//                  select c.Credits).Sum()
//     select new { s.Name, TotalCredits = total };

// Method syntax
// var result = students
//         .Select(s => new
//         {
//             s.Name,
//             TotalCredits = enrollments
//                 .Where(e => e.StudentId == s.Id)
//                 .Join(courses, e => e.CourseId, c => c.Id, (e, c) => c.Credits)
//                 .Sum()
//         });
// foreach (var e in result)
// {
//     Console.WriteLine($"{e.Name} - {e.TotalCredits}");
// }

////////////////////////////////////////////////      TASK 7

// Query syntax
// var result =
//     from c in courses
//     select new { c.Title, Count = enrollments.Count(e => e.CourseId == c.Id) };

// Method syntax
// var result = courses
//         .Select(c => new { c.Title, Count = enrollments.Count(e => e.CourseId == c.Id) });
// foreach (var e in result)
// {
//     Console.WriteLine($"{e.Title} - {e.Count}");
// }

////////////////////////////////////////////////      TASK 8

// var bobId = students.First(s => s.Name == "Bob").Id;

// Query syntax
// var result =
//     from c in courses
//     where !enrollments.Any(e => e.StudentId == bobId && e.CourseId == c.Id)
//     select c;

// Method syntax
// var result = courses
//         .Where(c => !enrollments.Any(e => e.StudentId == bobId && e.CourseId == c.Id));
// foreach (var e in result)
// {
//     Console.WriteLine($"{e.Id} - {e.Title}");
// }


////////////////////////////////////////////////////////////////////////////////////////////////////////////////////      CLASS-TASK(3)

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 13, 15, 17, 20, 23, 25, 29, 31, 97, 100 };
var cars = new List<Car>
    {
        new() {
            Id = 1,
            Brand = "Toyota",
            Model = "Camry",
            Year = 2020
            },
        new() {
            Id = 2,
            Brand = "Honda",
            Model = "Civic",
            Year = 2018
            },
        new() {
            Id = 3,
            Brand = "BMW",
            Model = "X5",
            Year = 2020
            },
        new() {
            Id = 4,
            Brand = "Mercedes",
            Model = "C200",
            Year = 2019
            },
        new() {
            Id = 5,
            Brand = "Kia",
            Model = "Rio",
            Year = 2018
            },
        new() {
            Id = 6,
            Brand = "Hyundai",
            Model = "Solaris",
            Year = 2020
            },
        new() {
            Id = 7,
            Brand = "Chevrolet",
            Model = "Cobalt",
            Year = 2015
            },
        new() {
            Id = 8,
            Brand = "Lada",
            Model = "Granta",
            Year = 2019
            },
        new() {
            Id = 9,
            Brand = "Ford",
            Model = "Focus",
            Year = 2015
            },
        new() {
            Id = 10,
            Brand = "Nissan",
            Model = "Qashqai",
            Year = 2018
            }
    };
////////////////////////////////////////////////      TASK 1

// Query syntax
// var result =
//     from p in people
//     where p.Age > 30
//     select p.Name;

// Method syntax
// var result = people
//         .Where(x => x.Age > 30)
//         .Select(x => x.Name);
// foreach (var e in result)
// {
//     Console.WriteLine(e);
// }

////////////////////////////////////////////////      TASK 2

// Query syntax
// var result =
//     from p in people
//     group p by p.Age into g
//     orderby g.Key
//     select new { Age = g.Key, Count = g.Count() };

// Method syntax
// var result = people
//         .GroupBy(x => x.Age)
//         .OrderBy(g => g.Key)
//         .Select(g => new { Age = g.Key, Count = g.Count() });
// foreach (var e in result)
// {
//     Console.WriteLine($"Age: {e.Age} - Count: {e.Count}");
// }

////////////////////////////////////////////////      TASK 3

// Query syntax
// var result = 
//     (from p in people
//     orderby p.Age descending
//     select p).Take(5);

// Method syntax
// var result = people
//         .OrderByDescending(x => x.Age)
//         .Take(5);
// foreach (var p in result)
// {
//     System.Console.WriteLine($"{p.Name} - {p.Age}");
// }

////////////////////////////////////////////////      TASK 4

// bool IsPrime(int n)
// {
//     if (n < 2) return false;
//     if (n % 2 == 0) return n == 2;
//     for (int i = 3; i * i <= n; i += 2)
//     {
//         if (n % i == 0) return false;
//     }
//     return true;
// }

// Query syntax (PLINQ)
// var result =
//     from n in numbers.AsParallel().AsOrdered()
//     where IsPrime(n)
//     select n;

//  Method syntax (PLINQ)
// var result = numbers
//         .AsParallel()
//         .AsOrdered()
//         .Where(x => IsPrime(x));
// foreach (var n in result)
// {
//     System.Console.Write(n + " ");
// }

////////////////////////////////////////////////      TASK 5

// Query syntax (PLINQ)
// var result =
//     from c in cars.AsParallel()
//     group c by c.Year into g
//     orderby g.Key
//     select new { Year = g.Key, Count = g.Count() };

// Method syntax (PLINQ)
// var result = cars
//         .AsParallel()
//         .GroupBy(x => x.Year)
//         .OrderBy(g => g.Key)
//         .Select(g => new { Year = g.Key, Count = g.Count() });
// foreach (var e in result)
// {
//     Console.WriteLine($"Year: {e.Year} - Count: {e.Count}");
// }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////      HOME-TASK(3)

var books = new List<Book>
    {
        new() {
            Title = "C#",
            Author = "Albahari"
            },
        new() {
            Title = "C#",
            Author = "Albahari"
            },
        new() {
            Title = "LINQ",
            Author = "Rattz"
            },
        new() {
            Title = "CLR via C#",
            Author = "Richter"
            },
        new() {
            Title = "LINQ",
            Author = "Rattz"
            },
        new() {
            Title = "C#",
            Author = "Skeet"
            }
    };

//1
var nums1 = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6 };
var sorted1 = nums1.OrderBy(x => x).ToList();
int cnt1 = sorted1.Count();
double median1;
if (cnt1 % 2 == 0)
{
    median1 = new List<int> { sorted1.ElementAt(cnt1 / 2 - 1), sorted1.ElementAt(cnt1 / 2) }.Average();
}
else
{
    median1 = sorted1.ElementAt(cnt1 / 2);
}
System.Console.WriteLine(median1);


//2
var a2 = new List<int> { 1, 2, 3, 4 };
var b2 = new List<int> { 2, 3, 5, 6 };
var c2 = new List<int> { 2, 3, 7, 8 };
var common2 = a2.Intersect(b2).Intersect(c2);
foreach (var item in common2)
{
    System.Console.WriteLine(item);
}


//3
var nums3 = new List<int> { 1, 2, 3, 1, 2, 5, 6 };
var runs3 = nums3.Aggregate(new List<List<int>>(), (acc, x) =>
{
    if (acc.Count > 0 && acc[^1][^1] < x)
    {
        acc[^1].Add(x);
    }
    else
    {
        acc.Add(new List<int> { x });
    }
    return acc;
});
var best3 = runs3.OrderByDescending(r => r.Count).First();
System.Console.WriteLine(best3.Sum());


//4
var items4 = new List<string> { "a", "b", "a", "c", "b", "a" };
int n4 = 2;
var top4 = items4
    .AsParallel()
    .GroupBy(x => x)
    .OrderByDescending(g => g.Count())
    .ThenBy(g => g.Key)
    .Take(n4)
    .Select(g => new { g.Key, Count = g.Count() });
foreach (var t in top4)
{
    System.Console.WriteLine($"{t.Key} (x{t.Count})");
}


//5
var books5 = new List<Book>
{
    new Book { Title = "C#", Author = "Albahari" },
    new Book { Title = "C#", Author = "Albahari" },
    new Book { Title = "LINQ", Author = "Rattz" }
};
var unique5 = books5
    .GroupBy(b => new { b.Title, b.Author })
    .Select(g => g.First());
foreach (var bk in unique5)
{
    System.Console.WriteLine($"{bk.Title} - {bk.Author}");
}


//6
var nums6 = new List<int> { 1, 5, 12, 7, 3, 9 };
int min6 = 4;
int max6 = 10;
var result6 = nums6.Where(x => x >= min6 && x <= max6);
foreach (var item in result6)
{
    System.Console.WriteLine(item);
}

//7
var students7 = new List<(string Name, int Age)>
{
    ("Alice", 22),
    ("Bob", 19),
    ("Carol", 20)
};
int threshold7 = 20;
var split7 = students7.ToLookup(s => s.Age > threshold7);
System.Console.WriteLine("Older:");
foreach (var item in split7[true])
{
    System.Console.WriteLine($"{item.Name} {item.Age}");
}
System.Console.WriteLine($"<= {threshold7}:");
foreach (var item in split7[false])
{
    System.Console.WriteLine($"{item.Name} {item.Age}");
}


//8
var nums8 = new List<int> { 1, 2, 2, 3, 3, 3, 4 };
int n8 = 2;
var result8 = nums8
    .GroupBy(x => x)
    .Where(g => g.Count() == n8)
    .Select(g => g.Key);
foreach (var item in result8)
{
    System.Console.WriteLine(item);
}


//9
var words9 = new List<string> { "cat", "elephant", "ox", "dog" };
var longest9 = words9.OrderByDescending(w => w.Length).First();
System.Console.WriteLine(longest9);


//10
var nums10 = new List<int> { 199, 200, 155, 1999 };
var best10 = nums10
    .AsParallel()
    .Select(x => new { Number = x, Sum = x.ToString().Sum(ch => ch - '0') })
    .OrderByDescending(x => x.Sum)
    .First();
System.Console.WriteLine($"{best10.Number} - {best10.Sum}");