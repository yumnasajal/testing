public class Registration
{
    public string RegisterCourse(
        bool isLoggedIn,
        bool isCourseFull,
        bool alreadyRegistered)
    {
        if (!isLoggedIn)
            return "Error: Student must be logged in.";

        if (isCourseFull)
            return "Error: Course is full.";

        if (alreadyRegistered)
            return "Error: Student is already registered.";

        return "Course registered successfully.";
    }
}