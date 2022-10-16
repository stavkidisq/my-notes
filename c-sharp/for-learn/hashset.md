### Структура HashSet в C#.

#### Определение HashSet в C#.

**HashSet** - это коллекция в пространстве имен `System.Collections.Generic`. Она является **неупорядоченной**, а также **динамической**. Самая главная особенность 
данной коллекции состоит в том, что в ней могут храниться только **уникальные элементы** (если в коллекцию добавить повторяющийся элемент, то он будет удален).

#### Отличия HashSet от словаря.

**HashSet**, как и **Dictionary**, представляет собой коллекцию на основе хэшей, благодаря чему поиск выполняется очень **быстро**. 

Структура **HashSet** имеет следующие отличия
- В отличие от славаря, **HashSet** хранит только **значения**.
- **Невозможна** сортировка структуры данных.
- Может хранить элементы только **одного** типа.

#### Добавление данных в коллекцию HashSet.

Для добавления данных в коллекцию используется метод `Add`.

```csharp
using System.Collections.Generic;

HashSet<string> hashList = new HashSet<string>();

hashList.Add("New-York");
hashList.Add("Los-Angeles");
hashList.Add("Chicago");
hashList.Add("Houston");
hashList.Add("New-York");
hashList.Add("New-York");
hashList.Add("Chicago");

foreach (var hash in hashList)
{
    Console.WriteLine(hash);
}
```

![image](https://user-images.githubusercontent.com/57217014/196034977-a7d20f0e-5231-4d9b-9ee2-7b9944a8db3b.png)

Данная программа вывела на консоль элементы, однако все **повторения** были удалены.

#### Удаление данных из коллекции HashSet.

Для удаления элементов из коллекции используются слудующие методы: `Remove` и `RemoveWhere`.

```csharp
hashList.Remove("Chicago");
hashList.RemoveWhere(item => item[0] == 'N');
```

Чтобы удалить все элементы, можно воспользоваться функцией `Clear`.

```csharp
hashList.Clear();
```

#### Объединение коллекций.

Объединение коллекций происходит с использованием метода `UnionWith`.

```csharp
using System.Collections.Generic;

HashSet<string> hashListA = new HashSet<string> { "New-York", "Los-Angeles", "Chicago" };
HashSet<string> hashListB = new HashSet<string> { "Houston", "Phoenix", "Chicago" };

hashListA.UnionWith(hashListB);

foreach(var hash in hashListA)
{
    Console.WriteLine(hash);
}
```

![image](https://user-images.githubusercontent.com/57217014/196041298-c2e53745-5634-47cf-80f3-81eae5228324.png)

#### Пересечение коллекций.

Для пересечения коллекций применяется метод `IntersectWith`.

```csharp
using System.Collections.Generic;

HashSet<string> hashListA = new HashSet<string> { "New-York", "Los-Angeles", "Chicago" };
HashSet<string> hashListB = new HashSet<string> { "Houston", "Phoenix", "Chicago" };

hashListA.IntersectWith(hashListB);

foreach(var hash in hashListA)
{
    Console.WriteLine(hash);
}
```

![image](https://user-images.githubusercontent.com/57217014/196041556-bcdcea5b-e764-4f8f-a239-f1d90fa3c61b.png)

#### Резюме.

**HashSet** может оптимально применяться там, где нужно производить операции над множествами (вычитание, пересечение и т.д.). Однако нужно помнить, что данные операции являются избыточными, т.е. они поглащают больше ресурсов, чем нужно для хранения элементов. Поэтому множества не должны превышать допустимое количество (примерно 100-1000 элементов).
