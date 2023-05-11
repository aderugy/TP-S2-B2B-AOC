using System;
using System.Collections.Generic;
using System.IO;
using Exercises;

namespace Tests;

public class FileManagerTests
{
    /*
    [Fact]
    public void FileEmptyTest()
    {
        Assert.Throws<EmptyDatasetException>(() => new FileManager(Utils.TestFilesPath + "filemanagerempty"));
    }

    [Fact]
    public void FileNotFoundTest()
    {
        Assert.Throws<FileNotFoundException>(() => new FileManager(""));
    }

    [Fact]
    public void IndexerTests()
    {
        FileManager fm = new(Utils.TestFilesPath + "filemanager");
        Assert.Throws<IndexOutOfRangeException>(() => fm[-1]);
        Assert.Throws<IndexOutOfRangeException>(() => fm.Current);
        Assert.Throws<IndexOutOfRangeException>(() => fm[11]);

        for (int i = 0; i < 11; i++)
            Assert.Equal(i.ToString(), fm[i]);
    }

    [Fact]
    public void GetMultipleLinesTests()
    {
        FileManager fm = new(Utils.TestFilesPath + "filemanager");
        
        List<string> ses = fm.GetMultipleLines(11);
        for (int index = 0; index < ses.Count; index++)
            Assert.Equal(index.ToString(), ses[index]);
        
        fm.Reset();
        Assert.Throws<IndexOutOfRangeException>(() => fm.GetMultipleLines(12));
        
        fm.Reset();
        Assert.Equal(4, fm.GetMultipleLines(4).Count);
    }

    [Fact]
    public void TakeWhileTests()
    {
        
    }
    */
}