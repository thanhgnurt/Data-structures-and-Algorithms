﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Pratice.Trees
{
    class Node
    {
        //--Property---
        public Node left;
        public Node right;
        private Node parent;
        private Node nextSibling;
        public int index;
        public int data;
        public int quatity;

        //--Contructor--
        public Node()
        {
            data = 0;
            quatity = 0;
            index = -1;
            left = null;
            right = null;
            left = null;
            right = null;
            parent = null;
            nextSibling = null;
        }
        public Node(int nodeData)
        {
            data = nodeData;
            index = -1;
            quatity = 1;
            left = null;
            right = null;
            parent = null;
            nextSibling = null;
        }
        public Node(int nodeData, int indexInArray)
        {
            data = nodeData;
            index = indexInArray;
            quatity = 1;
            left = null;
            right = null;
            left = null;
            right = null;
            parent = null;
            nextSibling = null;
        }

        //--Method---
        public void InsertNode(int element)
        {
            if (element < data)
            {
                if (left == null)
                {
                    left = new Node(element);
                    left.parent = this;
                    left.nextSibling = right;

                }
                else
                {
                    left.InsertNode(element);
                }
            }
            else
            {
                if (element == data) quatity++;
                else
                {
                    if (right == null)
                    {
                        right = new Node(element);
                        right.parent = this;
                    }
                    else
                    {
                        right.InsertNode(element);
                    }
                }
            }
        }

        public Node Parent(int x)
        {
            if (x < data)
            {
                if (left == null) return null;
                else
                {
                    return left.Parent(x);
                }
            }
            else
            {
                if (x == data)
                {
                    return this;
                }
                else
                {
                    if (right == null) return null;
                    else
                    {
                        return right.Parent(x);

                    }

                }
            }
        }

        public Node NextSibling(int x)
        {
            if (x < data)
            {
                if (left == null) return null;
                else
                {
                    return left.NextSibling(x);
                }
            }
            else
            {
                if (x == data)
                {
                    return this.right;
                }
                else
                {
                    if (right == null) return null;
                    else
                    {
                        return right.NextSibling(x);

                    }

                }
            }
        }


        public void InsertNodeIndex(int element, int indexInArray)
        {
            if (element < data)
            {
                if (left == null) left = new Node(element, indexInArray);
                else
                {
                    left.InsertNodeIndex(element, indexInArray);
                }
            }
            else
            {
                if (element == data) quatity++;
                else
                {
                    if (right == null) right = new Node(element, indexInArray);
                    else
                    {
                        right.InsertNodeIndex(element, indexInArray);
                    }
                }
            }
        }
        public int Search(int element)
        {
            
            if (element < data)
            {
                if (left == null) return -1;
                else
                {
                    return left.Search(element);
                }
            }
            else
            {
                if (element == data)
                {
                    return index;
                }
                else
                {
                    if (right == null) return -1;
                    else
                    {
                        return right.Search(element);
                        
                    }
                   
                }
            }
            
        }




    }
    class BTSTree
    {
        public Node root;
        public BTSTree(int dataRoot)
        {
            root = new Node(dataRoot);
        }
        public BTSTree()
        {
            root = null;
        }
        public void InsertNode(int data)
        {
            root.InsertNode(data);
        }
        public void InsertNodeIndex(int data, int index)
        {
            root.InsertNodeIndex(data, index);
        }
        public int Search(int keySearch)
        {
           return root.Search(keySearch);
        }

    }
}