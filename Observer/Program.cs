using Observer.BusinessEntities;


SomePublisher publisher = new SomePublisher();
ConcreteSubscriberA subscriberA = new ConcreteSubscriberA();
publisher.Subscribe(subscriberA);
ConcreteSubscriberB subscriberB = new ConcreteSubscriberB();
publisher.Subscribe(subscriberB);
publisher.SomeBusinessLogic();
publisher.SomeBusinessLogic();
publisher.Unsubscribe(subscriberB);
publisher.SomeBusinessLogic();
Console.ResetColor();
Console.WriteLine();
Console.WriteLine();
