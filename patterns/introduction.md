### Вступление. Паттерны.

#### Табличная классификация паттернов проектирования.

Паттерны делятся на *три* основных типа: *порождающие*, *структурные* и *поведенческие*.

![image](https://user-images.githubusercontent.com/57217014/195411451-2ffface0-d74a-4228-bb7a-04a6540e262b.png)

#### Краткое описание паттернов проектироания.

##### Порождающие паттерны

1. **Abstract Factory (абстрактная фабрика)** - представляет интерфейс для создания семейств связанных между собой или зависимых объектов без указания их конкретных классов.
2. **Factory Method (фабричный метод)** - определяет интерфейс для создания объеков, позволяя подклассам решить, экземпляр какого касса следует создавать. Позволяет классу передать ответственность за создание экземпляра в подклассы.
3. **Singleton (одиночка)** - гарантирует, что некоторый класс может ущестовать только в одном экземпляре, и предоставляет глобальную точку доступа к нему.
4. **Prototype (прототип)** - описывает виды создаваемых объектов с помощью прототипа и создает новые объекты путем его копирования.
5. **Builder (строитель)** - отделяет конструирование сложного объекта от его представления, чтобы один процесс консруирования мог использоваться для создания различных представлений.

##### Структурные паттерны

1. **Adapter (адаптер)** - преобразует интерфейс класса вдругой интерфейс, ожидаемый клиентами. Обеспечивает совместную работу классов, которая былабы невозможна без данного паттерна из-зи несовмесимости интерфейсов.
2. **Bridge (мост)** - отделяет абстракцию от реализации, чтобы изможно было изменять независимо друг от друга.
3. **Decorator (декоратор)** - динамически наделяет объект новыми обязанностями. Декораторы применяются для расширения существующей функциональности и являются 
гибкой альтернативой порождению подклассов.
4. **Proxy (заместитель)** - подменяет другой объект для контроля доступа к нему.
5. **Composite (компоновщик)** - группирует объекты в древовидные структуры для представления иерарархий типа «часть — целое». Позволяет клиентам работать с единичными 
объектами так же, как с группами объектов.

##### Паттерны поведения

1. **Interpreter (интерпретатор)** - для заданного языка определяет представление его грамматики вместе с интерпретатором, который использует представление для интерпретации предложений языка.
2. **Template Method (шаблонный метод)** - определяет скелет алгоритма, перекладывая ответственность за некоторые его шаги на подклассы. Позволяет подклассам переопределять отдельные шаги алгоритма, не меняя его общей структуры.
3. **Iterator (итератор)** - дает возможность последовательно обойти все элементы составного объекта, не раскрывая его внутреннего представления.
4. **Command (команда)** - инкапсулирует запрос в виде объекта, позволяя тем самым параметризовывать клиентов по типу запроса, ставить запросы в очередь, протоколировать их и поддерживать отмену выполнения операций.
5. **Observer (наблюдатель)** - определяет между объектами зависимость типа «один-ко-многим», так что при изменении состояния одного объекта все зависящие от него получают уведомление и автоматически обновляются.