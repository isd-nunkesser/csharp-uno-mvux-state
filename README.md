# csharp-uno-mvux-state

Education consumer for showing a modern state-first approach with Uno Platform + MVUX.

## Main concept

- Central immutable state
- Explicit state transitions
- UI projection from state
- Testable update logic

## Learning goal

Students should compare a state-first C# approach with Flutter/SwiftUI/Compose patterns and evaluate trade-offs.

## Minimal flow

1. Action enters update pipeline.
2. State transition is computed.
3. Derived view state is projected.
4. UI renders from projection.

## Suggested next step

Add a small Uno MVUX sample app and reuse the same counter/todo domain to enable side-by-side comparison.
