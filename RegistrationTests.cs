using Xunit;

public class RegistrationTests
{
    private readonly Registration _registration = new();

    [Fact]
    public void RegisterCourse_WhenStudentIsNotLoggedIn_ReturnsLoginError()
    {
        var result = _registration.RegisterCourse(
            isLoggedIn: false,
            isCourseFull: false,
            alreadyRegistered: false);

        Assert.Equal("Error: Student must be logged in.", result);
    }

    [Fact]
    public void RegisterCourse_WhenStudentIsNotLoggedInAndCourseIsFull_ReturnsLoginError()
    {
        var result = _registration.RegisterCourse(
            isLoggedIn: false,
            isCourseFull: true,
            alreadyRegistered: false);

        Assert.Equal("Error: Student must be logged in.", result);
    }

    [Fact]
    public void RegisterCourse_WhenCourseIsFull_ReturnsCourseFullError()
    {
        var result = _registration.RegisterCourse(
            isLoggedIn: true,
            isCourseFull: true,
            alreadyRegistered: false);

        Assert.Equal("Error: Course is full.", result);
    }

    [Fact]
    public void RegisterCourse_WhenAlreadyRegistered_ReturnsDuplicateRegistrationError()
    {
        var result = _registration.RegisterCourse(
            isLoggedIn: true,
            isCourseFull: false,
            alreadyRegistered: true);

        Assert.Equal("Error: Student is already registered.", result);
    }

    [Fact]
    public void RegisterCourse_WhenCourseIsFullAndAlreadyRegistered_ReturnsCourseFullError()
    {
        var result = _registration.RegisterCourse(
            isLoggedIn: true,
            isCourseFull: true,
            alreadyRegistered: true);

        Assert.Equal("Error: Course is full.", result);
    }

    [Fact]
    public void RegisterCourse_WhenStudentIsLoggedInCourseHasSpaceAndIsNotRegistered_ReturnsSuccess()
    {
        var result = _registration.RegisterCourse(
            isLoggedIn: true,
            isCourseFull: false,
            alreadyRegistered: false);

        Assert.Equal("Course registered successfully.", result);
    }
}