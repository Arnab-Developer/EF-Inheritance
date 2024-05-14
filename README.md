# EF Inheritance

Model inheritence (default, TPT, TPC) with Entity Framework demo. 

This is a demo app to show how model inheritence works with Entity Framework. There are 
three ways of how EF manages inheritence. First is `table per hierarchy` which is the default, 
the second is `table per type` and the third is `table per concrete type`.

I have used a simple model structure for this demo `Animal`, `Cat` and `Dog`. There are three
EF contexts and migration folders for the three ways. You can check the migrations to
understand how tables are structured for the three ways.

```mermaid
classDiagram
    class Animal
    {
        Id
        Name
    }
    
    class Cat
    {
        Sound
    }
    
    class Dog
    {
        Breed
    }
    
    Animal <|-- Cat
    Animal <|-- Dog
```

You can find more details in the [EF documentation](https://learn.microsoft.com/en-us/ef/core/modeling/inheritance).