### Отношения между классами.

#### Наследование.
Является одной из основных парадигм ООП. Позволяет передать функционал от одного класса (родительского) к другому (наследнику). Наследование на языке C# выглядит так

```csharp
public class User
{
  public int Id { get; set; }
  public string Name { get; set; }
}

public class Manager : User
{
  public string Company { get; set; }
}
```

Наследование на UML выглядит так

![image](https://user-images.githubusercontent.com/57217014/196491324-bc847bd2-bafa-4b0e-b722-cf6b7e2b910e.png)

#### Реализация.

Реализация предполагает определение интерфейса и его описание в классах. Реализация на языке C# выглядит так

```csharp
public interface IMovable
{
  void Move();
}

public class Car : IMovable
{
  public void Move()
  {
    Console.WriteLine("Car is driving.");
  }
}
```

Реализация на UML выглядит так

![image](https://user-images.githubusercontent.com/57217014/196492952-cf40c87e-d269-40d6-af55-5ecfa9743c59.png)

#### Ассоциация

Ассоциация - это отношение, при котором объекты одного типа некоторым образом связаны с объектами другого типа. Например, объект так или иначе использует объект
другого класса или содержит его. Ассоциация на языке C# выгладит так

```csharp
public class Team
{
  
}

public class Player
{
  public Team Team { get; set; }
}
```

Ассоциация на UML выглядит так

![image](https://user-images.githubusercontent.com/57217014/196494932-9e6aed81-38f9-4ec7-89f9-90be4769593f.png)
