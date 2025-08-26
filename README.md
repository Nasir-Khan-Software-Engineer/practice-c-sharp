# Enums in C#

## Enum Basics
- By default, the first enumerator has value `0`.
- Each successive enumerator increases by `1`.
- Enum is an **integral type**; you cannot use `string` or other non-numeric types.

### How values are stored and casted
- Enums store their **underlying integer** internally.
- Names (`Sunday`, `Monday`) are compile-time labels.
- Cast to integer → numeric value.
- Cast from integer → enum value (may not match a named member).

### When to use enums
- Small, related sets of constants (e.g., days, months, directions).
- Improve readability vs. raw integers/strings.
- Restrict input to predefined values (e.g., `LogLevel.Info`).
- Represent named states or modes (e.g., `GameState.Playing`).
- Performance matters: lightweight value types faster than strings.

### When NOT to use enums
- Values change frequently → use config/database.
- Values need extra data/behavior → use classes/records or Smart Enum pattern.
- Enums are large or need localization → use lookup tables.


## Modern C# Method Techniques

### Tuples for Multiple Return Values
**Use When:**
- A method naturally produces more than one result and you don’t want to create a separate class or struct.  
- You want lightweight, readable code for returning multiple values.  
- You want named fields for clarity.

### Local Functions (Methods inside Methods)

**Use When:**
- You have helper logic that is only relevant inside one method.  
- You want to keep the class clean by not creating private methods that are not used elsewhere.  
- You want readability and modularity without polluting the class namespace.