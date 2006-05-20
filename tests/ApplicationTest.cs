//
// ApplicationTest.cs: NUnit Test Suite for gstreamer-sharp
//
// Authors:
//   Aaron Bockover (abockover@novell.com)
//
// (C) 2006 Novell, Inc.
//

using System;
using NUnit.Framework;

[TestFixture]
public class ApplicationTest
{
    [Test]
    public void Init()
    {
        Gst.Application.Init();
        Gst.Application.Deinit();
    }
    
    [Test]
    public void InitArgs()
    {
        string [] args = { "arg_a", "arg_b" };
        Gst.Application.Init("gstreamer-sharp-test", ref args);
        Gst.Application.Deinit();
    }
    
    [Test]
    public void InitArgsCheck()
    {
        string [] args = { "arg_a", "arg_b" };
        Gst.Application.InitCheck("gstreamer-sharp-test", ref args);
        Gst.Application.Deinit();
    }

    [Test]
    public void TestVersion()
    {
        Assert.AreEqual(Gst.Application.Version.Minor, 10);
    }
    
    [Test]
    public void TestVersionString()
    {   
        Assert.IsNotNull(Gst.Application.Version.ToString());
    }
    
    [Test]
    public void TestVersionDescription()
    {
        Assert.IsNotNull(Gst.Application.Version.Description);
    }
}
