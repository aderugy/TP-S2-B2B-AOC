using Exercises.Exercise1;

namespace Tests;

public class ExerciseOneTests
{
    [Fact]
    public void Exercise1EasyPart1()
    {
        SolutionEx1 easySolution = new(Utils.TestFilesPath + "easy1");
        Assert.Equal(24000, easySolution.SolvePart1());
    }

    [Fact]
    public void Exercise1HardPart1()
    {
        SolutionEx1 hardSolution = new(Utils.TestFilesPath + "hard1");
        Assert.Equal(66186, hardSolution.SolvePart1());
    }

    [Fact]
    public void Exercise1EasyPart2()
    {
        SolutionEx1 easySolution = new(Utils.TestFilesPath + "easy1");
        Assert.Equal(45000, easySolution.SolvePart2());
    }

    [Fact]
    public void Exercise1HardPart2()
    {
        SolutionEx1 hardSolution = new(Utils.TestFilesPath + "hard1");
        Assert.Equal(196804, hardSolution.SolvePart2());
    }
}
