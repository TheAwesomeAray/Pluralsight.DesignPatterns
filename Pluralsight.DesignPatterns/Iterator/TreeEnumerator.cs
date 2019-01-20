using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.Iterator
{
    public class TreeEnumerator<T>
    {
        private Tree<T> _tree;
        public Tree<T> Current { get; private set; }
        private Tree<T> Previous { get; set; }
        private Tree<T> Next { get; set; }
        private Stack<Tree<T>> _breadCrumb;

        public TreeEnumerator(Tree<T> tree)
        {
            _tree = tree;
        }

        public bool MoveNext()
        {
            if (Current == null)
            {
                Reset();
                Current = _tree;
                return true;
            }
            if (Current.LeftChild != null)
            {
                return TraverseLeft();
            }
            if (Current.RightChild != null)
            {
                return TraverseRight();
            }
            return TraverseUpAndRight();
        }

        private bool TraverseUpAndRight()
        {
            if (_breadCrumb.Count > 0)
            {
                Previous = Current;
                while (true)
                {
                    Current = _breadCrumb.Pop();
                    if (Previous != Current.RightChild)
                        break;
                }
                if (Current.RightChild != null)
                {
                    _breadCrumb.Push(Current);
                    Current = Current.RightChild;
                    return true;
                }
            }
            return false;
        }

        private bool TraverseRight()
        {
            _breadCrumb.Push(Current);
            Current = Current.RightChild;
            return true;
        }

        private bool TraverseLeft()
        {
            _breadCrumb.Push(Current);
            Current = Current.LeftChild;
            return true;
        }

        private void Reset()
        {
            Current = null;
        }
    }
}
