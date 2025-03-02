using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodePractice.TextEditor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.TextEditor.Tests
{
    [TestClass()]
    public class TextEditorTests
    {
        [TestMethod()]
        public void TextEditorTest()
        {
            var textEditor = new TextEditor();
            Assert.AreEqual("|", textEditor.OutText());
        }

        [TestMethod()]
        public void AddTextTest()
        {
            var textEditor = new TextEditor();
            textEditor.AddText("leetcode");
            Assert.AreEqual("leetcode|", textEditor.OutText());
        }

        [TestMethod()]
        public void DeleteTextTest()
        {
            var textEditor = new TextEditor();
            textEditor.AddText("leetcode");
            Assert.AreEqual(4, textEditor.DeleteText(4));
            Assert.AreEqual("leet|", textEditor.OutText());
        }

        [TestMethod()]
        public void CursorLeftTest()
        {
            var textEditor = new TextEditor();
            textEditor.AddText("leetcode");
            Assert.AreEqual(4, textEditor.DeleteText(4));
            textEditor.AddText("practice");
            Assert.AreEqual("leetpractice|", textEditor.OutText());
            Assert.AreEqual("etpractice", textEditor.CursorRight(3));
            Assert.AreEqual("leetpractice|", textEditor.OutText());
            Assert.AreEqual("leet", textEditor.CursorLeft(8));
            Assert.AreEqual("leet|practice", textEditor.OutText());

        }

        [TestMethod()]
        public void CursorRightTest()
        {
            var textEditor = new TextEditor();
            textEditor.AddText("leetcode");
            Assert.AreEqual(4, textEditor.DeleteText(4));
            textEditor.AddText("practice");
            Assert.AreEqual("leetpractice|", textEditor.OutText());
            Assert.AreEqual("etpractice", textEditor.CursorRight(3));
            Assert.AreEqual("leetpractice|", textEditor.OutText());
        }

        [TestMethod()]
        public void ErrorTest()
        {
            var textEditor = new TextEditor();
            textEditor.AddText("bxyackuncqzcqo");

            var left1 = textEditor.CursorLeft(12);
            Assert.AreEqual("bx", left1);
            Assert.AreEqual("bx|yackuncqzcqo", textEditor.OutText());

            var value = textEditor.DeleteText(3);
            Assert.AreEqual(2, value);
            Assert.AreEqual("|yackuncqzcqo", textEditor.OutText());

            var left2 = textEditor.CursorLeft(5);
            Assert.AreEqual("", left2);
            Assert.AreEqual("|yackuncqzcqo", textEditor.OutText());

            textEditor.AddText("osdhyvqxf");
            Assert.AreEqual("osdhyvqxf|yackuncqzcqo", textEditor.OutText());

            var right1 = textEditor.CursorRight(10);
            Assert.AreEqual("osdhyvqxfyackuncqzc|qo", textEditor.OutText());
            Assert.AreEqual("yackuncqzc", right1);

        }

        [TestMethod()]
        public void Error1Test()
        {
            var textEditor = new TextEditor();

            var left1 = textEditor.DeleteText(9);
            Assert.AreEqual(0, left1);
            Assert.AreEqual("|", textEditor.OutText());

            var value = textEditor.CursorLeft(14);
            Assert.AreEqual(string.Empty, value);

            textEditor.AddText("mjzxkemqyvfrg");
            Assert.AreEqual("mjzxkemqyvfrg|", textEditor.OutText());

            var left2 = textEditor.CursorLeft(5);
            Assert.AreEqual(left2, "mjzxkemq");
            Assert.AreEqual("mjzxkemq|yvfrg", textEditor.OutText());

            textEditor.AddText("svvyobqebssp");
            Assert.AreEqual("mjzxkemqsvvyobqebssp|yvfrg", textEditor.OutText());

            textEditor.AddText("xkoznsq");
            Assert.AreEqual("mjzxkemqsvvyobqebsspxkoznsq|yvfrg", textEditor.OutText());

            var right1 = textEditor.CursorRight(3);
            Assert.AreEqual("mjzxkemqsvvyobqebsspxkoznsqyvf|rg", textEditor.OutText());
            Assert.AreEqual("xkoznsqyvf", right1);
            
        }
    }
}