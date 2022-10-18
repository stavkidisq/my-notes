### Отношения между классами.

#### Наследование.

Наслеование является одной из основных парадигм ООП. Позволяет передать функционал от одного класса (родительского) к другому (наследнику). Наследование на языке C# выглядит так

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
public class Team { //... }

public class Player
{
  public Team Team { get; set; }
}
```

Ассоциация на UML выглядит так

![image](https://user-images.githubusercontent.com/57217014/196494932-9e6aed81-38f9-4ec7-89f9-90be4769593f.png)

Знаки рядом со стрелкой ("1" и звездочка) означают связь один ко многим. То есть одна команда может содержать несколько игроков.

#### Композиция

Композиция отражает отношение **HAS A**, то есть отношение "имеет". Композиция на языке C# выгладит так

```csharp
public class ElectricalEngine { //... }

public Car
{
  private ElectricalEngine Engine { get; set; }
  
  public Car(ElectricalEngine _carEngine)
  {
    Engine = _engine;
  }
}
```

Композиция на UML выглядит так

![image](https://user-images.githubusercontent.com/57217014/196496701-8ac5bca2-7b23-47d5-9dbf-0f9e252f0ffe.png)

Объект двигателя является зависимым от объекта машины, так как, если уничтожить машину, то двигатель будет ненужным. Поэтому жизненный цикл двигателя будет равным жизненному циклу машины.

#### Агрегация

Агрегация похожа на композицию, так как она тоже определяет отношение **HAS A**, однако это разные вещи. Агрегация на языке C# выглядит так

```csharp
public class Engine { //... }

public Car
{
  private Engine Engine { get; set; }
  
  public Car(ElectricalEngine _carEngine)
  {
    Engine = _engine;
  }
}
```

Агрегация на UML выглядит так

![image](https://user-images.githubusercontent.com/57217014/196497908-10bcac7c-8837-4231-9a3f-d3caf4b5ded4.png)

Здесь жизненный цикл класса двигателя не равен жизненному циклу класса машины. Также можно сказать, что данные классы равноправны. То есть при уничтожении одного класса, другой может существовать. Как правило объект, который содержится в другом классе, должен быть абстрактным или вообще являться интерфейсом.

