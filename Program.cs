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

