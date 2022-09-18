### Задание 1.

#### Постановка задачи.
Нам дан класс
```c#
internal class TreeNode
{
  private IEnumerable<TreeNode> Childrens { get; init; }
}
```

Нужно написать функцию `GetAllNodes` следующим образом
```c#
IEnumerable<TreeNode> GetAllNodes(TreeNode root)
{
  //TODO
}
```

Данная функция должна возвращать все элементы переданного в нее дерева всех уровней сложности.

![image](https://user-images.githubusercontent.com/57217014/190916164-56e58502-9e22-4375-beec-06b3eef06f59.png)

#### Решение задачи.

Оформим наш класс `TreeNode` следующим образом

```c#
internal sealed class TreeNode
{
  public string Name { get; set; } = null!;
  public IEnumerable<TreeNode> Children { get; init; } = null!;

  public IEnumerable<TreeNode> GetAllNodes(TreeNode root)
  {
    yield return root; // Возвращение корня дерева
    
    // При дочерней ветке, которая рана null, заканчиваем итерацию и переходим на следующую
    if(root.Children == null)
    {
      yield break;
    }
    
    // Итерация дочерних веток
    foreach(var node in root.Children)
    {
      foreach (var tree in GetAllNodes(node))
      {
        yield return tree;
      }
    }
  }
}
```
