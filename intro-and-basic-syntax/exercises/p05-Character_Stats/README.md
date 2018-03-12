### [](https://github.com/TeamworkSoftwareTechnologies/programming-fudamentals/blob/master/README.md#problem-5--character-stats)Problem 5. * Character Stats
## Problem 5. * Character Stats

Write a program, which **displays information** about a video game character. You will receive their **name, current health, maximum health, current energy** and **maximum energy** on separate lines. The **current** values will **always** be valid (**equal** or **lower** than their respective **max** values). Print them in the format as per the examples.

# Examples

|  Input  |  Output  |
|:---| --- |
| Mayro | Name: Mayro   |
| 5     | Health: \|\|\|\|\|\|\.\.\.\.\.\| |
| 10    | Energy: \|\|\|\|\|\|\|\|\|\|\.\| |
| 9     |                                  |
| 10    |                                  |

|  Input  |  Output  |
|:---| --- |
| Bauser | Name: Bauser   |
| 10     | Health: \|\|\|\|\|\|\|\|\|\|\|\| |
| 10     | Energy: \|\|\|\|\|\|\|\|\|\|\|\| |
| 10     |                                  |
| 10     |                                  |

|  Input  |  Output  |
|:---| --- |
| Loogi | Name: Loogi   |
| 8     | Health: \|\|\|\|\|\|\|\|\|\.\.\.\.\.\.\.\.\.\.\.\.\| |
| 20    | Energy: \|\|\|\.\.\.\.\.\.\.\.\.\.\.\.\| |
| 2     |                                  |
| 14    |                                  |

|  Input  |  Output  |
|:---| --- |
| Toad   | Name: Toad   |
| 0      | Health: \|\.\.\.\.\.\| |
| 5      | Energy: \|\.\.\.\.\.\.\.\.\.\.\| |
| 0      |                                  |
| 10     |                                  |

# Hints

You can print a character **multiple** times, using **new string(character, count).**