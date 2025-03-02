using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.TextEditor
{
    /// <summary>
    /// 文本编辑器
    /// </summary>
    public class TextEditor
    {
        private LinkedList<char> _list = new();

        private const char CURSOR = '|';

        private int cursorIndex = 0;

        public TextEditor()
        {

        }

        /// <summary>
        /// 添加文本
        /// </summary>
        /// <param name="text"></param>
        public void AddText(string text)
        {
            int i = 0;
            var way = cursorIndex == 0 ? 0 : 1;
            LinkedListNode<char>? node = _list.First;
            while (null != node)
            {
                if (i + 1 == cursorIndex)
                {
                    foreach (char c in text)
                    {
                        LinkedListNode<char>? next = new(c);
                        if(way == 0)
                        {
                            _list.AddBefore(node, next);
                        } 
                        else
                        {
                            _list.AddAfter(node, next);
                            node = next;
                        }
                        
                        cursorIndex++;
                    }
                    return;
                }
                if (null != node.Next)
                    node = node.Next;
                i++;
            }

            foreach (char c in text)
            {
                _list.AddLast(c);
                cursorIndex++;
            }
        }

        /// <summary>
        /// 删除文本
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        public int DeleteText(int k)
        {
            for (var i = 0; i < k; i++)
            {
                if (cursorIndex == 0)
                {
                    return i;
                }

                cursorIndex--;
                RemoveAt(cursorIndex);
            }
            return k;
        }

        /// <summary>
        /// 按序号删除
        /// </summary>
        /// <param name="index"></param>
        private void RemoveAt(int index)
        {
            int i = 0;
            LinkedListNode<char>? node = _list.First;
            while (null != node)
            {
                if (i == index)
                {
                    _list.Remove(node);
                    return;
                }
                if (null != node.Next)
                    node = node.Next;
                i++;
            }
        }

        /// <summary>
        /// 指针左移动
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        public string CursorLeft(int k)
        {
            if (cursorIndex <= k)
            {
                cursorIndex = 0;
            } 
            else
            {
                cursorIndex -= k;
            }
    
            if (cursorIndex <= 10)
            {
                return string.Concat(_list.Take(cursorIndex));
            }
            else
            {
                return string.Concat(_list.Skip(cursorIndex - 10).Take(10));
            }
        }

        /// <summary>
        /// 指针右移动
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        public string CursorRight(int k)
        {
            if (cursorIndex + k >= _list.Count)
            {
                cursorIndex = _list.Count;
            }
            else
            {
                cursorIndex += k;
            }

            if(cursorIndex < 10)
            {
                return string.Concat(_list.Take(cursorIndex));
            } 
            else
            {
                return string.Concat(_list.Skip(cursorIndex - 10).Take(10));
            }
        }

        private StringBuilder _buider = new ();

        /// <summary>
        /// 打印编辑器内容
        /// </summary>
        /// <returns></returns>
        public string OutText()
        {
            _buider.Clear();
            bool foud = false;
            for (var i = 0; i < _list.Count; i++)
            {
                if (i == cursorIndex)
                {
                    _buider.Append(CURSOR);

                    foud = true;
                }
                _buider.Append(_list.ElementAt(i));
            }

            if (!foud)
            {
                _buider.Append(CURSOR);
            }

            return _buider.ToString();
        }
    }
}
