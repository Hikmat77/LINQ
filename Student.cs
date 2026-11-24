enum Gender { Male, Female }
enum Status { Active, InActive }

class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int Age { get; set; }
    public Gender Gender { get; set; }
    public Status Status { get; set; }
    public DateTime DateOfStart { get; set; }
    public DateTime DateOfFinish { get; set; }
}