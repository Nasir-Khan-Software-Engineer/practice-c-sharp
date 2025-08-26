# Enums in C#

## Enum Basics
- By default, the first enumerator has value `0`.
- Each successive enumerator increases by `1`.
- Enum is an **integral type**; you cannot use `string` or other non-numeric types.

## How values are stored and casted
- Enums store their **underlying integer** internally.
- Names (`Sunday`, `Monday`) are compile-time labels.
- Cast to integer → numeric value.
- Cast from integer → enum value (may not match a named member).

## When to use enums
- Small, related sets of constants (e.g., days, months, directions).
- Improve readability vs. raw integers/strings.
- Restrict input to predefined values (e.g., `LogLevel.Info`).
- Represent named states or modes (e.g., `GameState.Playing`).
- Performance matters: lightweight value types faster than strings.

## When NOT to use enums
- Values change frequently → use config/database.
- Values need extra data/behavior → use classes/records or Smart Enum pattern.
- Enums are large or need localization → use lookup tables.
