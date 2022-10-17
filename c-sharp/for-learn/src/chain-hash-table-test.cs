using CSharp4;

MyHashTable<int, int> set = new MyHashTable<int, int>();

set.InsertNode(1, 111);
set.InsertNode(2, 110);
set.InsertNode(3, 110);
set.InsertNode(4, 90);
set.InsertNode(5, 80);
set.InsertNode(6, 70);
set.InsertNode(7, 60);
set.InsertNode(8, 50);
set.InsertNode(9, 40);
set.InsertNode(10, 30);
set.InsertNode(11, 20);

Console.WriteLine(set.GetValue(1));

set.DisplayTree();
