﻿using System.Collections;
using tree_problem_solution;

BinarySearchTree tree = new BinarySearchTree();

tree.Insert(7);
tree.Insert(5);
tree.Insert(6);
tree.Insert(8);
tree.Insert(9);
tree.Insert(4);
tree.Insert(10);

Console.WriteLine(tree.GetHeight());
