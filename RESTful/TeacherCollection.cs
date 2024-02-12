

public class TeacherCollection
{
    static Teacher GetTeacher(int number)
{
    List<Teacher> teachers = new() {new() {Name = "Micke", Hitpoint = 100}, new() {Name = "Martin", Hitpoint = 100}, new() {Name = "Lena", Hitpoint = 100}};

    if (number < 0 || number >= teachers.Count)
    {
        
    }
    

    return teachers[number];

    
}
}


