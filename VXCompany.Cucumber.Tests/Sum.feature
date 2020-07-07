Feature: sum

Scenario: 1 + 1 = 2
Given the number 1
And we add 1
When calculating
Then the result should be 2

Scenario: 2 + 2 = 4
Given the number 2
And we add 2
When calculating
Then the result should be 4

Scenario: 4 * 3 = 12
Given the number 3
And we add 3
And we add 3
And we add 3
When calculating
Then the result should be 12

Scenario Outline: x + y = z
Given the number <x>
And we add <y>
When calculating
Then the result should be <z>
Examples:
| x   | y   | z   |
| 1   | 1   | 2   |
| 2   | 2   | 4   |
| 100 | 100 | 200 |