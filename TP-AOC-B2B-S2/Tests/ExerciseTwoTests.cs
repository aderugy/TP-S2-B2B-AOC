using Exercises.Exercise2;

namespace Tests;

public class ExerciseTwoTests
{
    private static readonly Queue<long> _queue = new();

    private static readonly Monkey _monkey = new(_queue, l => 5 * l, 13, 2, 0);

    [Fact]
    public void HasItemsLeftTests()
    {
        Assert.False(_monkey.HasItemsLeft());
        _queue.Enqueue(10L);
        Assert.True(_monkey.HasItemsLeft());
        _queue.Clear();
    }

    [Fact]
    public void GetItemNextTests()
    {
        _queue.Enqueue(10L);
        _queue.Enqueue(12L);
        Assert.Equal(10L, _monkey.GetNextItem());
        Assert.Equal(12L, _monkey.GetNextItem());
        Assert.False(_monkey.HasItemsLeft());
        _queue.Clear();
    }

    [Fact]
    public void AddItemTests()
    {
        Assert.False(_monkey.HasItemsLeft());
        _monkey.AddItem(10L);
        Assert.True(_monkey.HasItemsLeft());
        Assert.Equal(10L, _monkey.GetNextItem());
        Assert.False(_monkey.HasItemsLeft());
    }

    [Fact]
    public void ApplyOperationTests()
    {
        _monkey.AddItem(10L);
        Assert.Equal(50L, _monkey.ApplyOperation());
        Assert.False(_monkey.HasItemsLeft());
    }

    [Fact]
    public void MonkeyInspectionTestTests()
    {
        Assert.Equal(2, _monkey.Test(13));
        Assert.Equal(2, _monkey.Test(26));
        Assert.Equal(0, _monkey.Test(2));
        Assert.Equal(0, _monkey.Test(25));
    }

    [Fact]
    public void ParseMonkeyInventoryTests()
    {
        string data = "Starting items: 79, 98";
        List<long> inventory = Monkey.ParseMonkeyInventory(data).ToList();
        Assert.Equal(2, inventory.Count);
        Assert.Equal(79, inventory[0]);
        Assert.Equal(98, inventory[1]);

        data = "Starting items: 79";
        inventory = Monkey.ParseMonkeyInventory(data).ToList();
        Assert.Single(inventory);
        Assert.Equal(79, inventory[0]);
    }

    [Fact]
    public void ParseMonkeyOperationTests()
    {
        string data = "Operation: new = old * 19";
        Assert.Equal(190L, Monkey.ParseMonkeyOperation(data)(10L));

        data = "Operation: new = old * old";
        Assert.Equal(100L, Monkey.ParseMonkeyOperation(data)(10L));
    }

    [Fact]
    public void GetLastValueAsIntTests()
    {
        string data = "Test: divisible by 23";
        Assert.Equal(23, Monkey.GetLastValueAsInt(data));
        data = "If true: throw to monkey 2";
        Assert.Equal(2, Monkey.GetLastValueAsInt(data));
        data = "If false: throw to monkey 3";
        Assert.Equal(3, Monkey.GetLastValueAsInt(data));
    }

    [Fact]
    public void Exercise2EasyPart1()
    {
        SolutionEx2 easySolution = new(Utils.TestFilesPath + "easy2");
        Assert.Equal(10605, easySolution.SolvePart1());
    }

    [Fact]
    public void Exercise2HardPart1()
    {
        SolutionEx2 hardSolution = new(Utils.TestFilesPath + "hard2");
        Assert.Equal(51075, hardSolution.SolvePart1());
    }

    [Fact]
    public void Exercise2EasyPart2()
    {
        SolutionEx2 easySolution = new(Utils.TestFilesPath + "easy2");
        Assert.Equal(2713310158L, easySolution.SolvePart2());
    }

    [Fact]
    public void Exercise2HardPart2()
    {
        SolutionEx2 hardSolution = new(Utils.TestFilesPath + "hard2");
        Assert.Equal(11741456163L, hardSolution.SolvePart2());
    }
}
