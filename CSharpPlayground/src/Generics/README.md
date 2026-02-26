# Generics — Variance in C#

Explores how generic type parameters behave when inheritance is involved.

## Concepts covered
- **Invariance**: why `List<Course>` is not a `List<Training>` even though `Course : Training`
- **Covariance (`out`)**: when a more specific generic can be treated as a more general one (producer pattern)
- **Contravariance (`in`)**: when a more general generic can be treated as a more specific one (consumer pattern)

## Key interfaces
- `ITrainingProducer<out T>` — covariance example
- `ITrainingConsumer<in T>` — contravariance example

## Why it matters in practice
These concepts appear in MediatR's `IRequest<TResponse>` and in the `BuildingBlocks.CQRS` 
abstractions used in microservices, where `ICommand<out TResponse>` and `IQuery<out TResponse>` 
leverage covariance to reflect that the generic type is always a result, never an input.