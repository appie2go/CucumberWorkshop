Feature: Simple additions

Scenario: 1 + 1
   Given the number 1
     And we add 1
    When calculating
    Then the result should be 2

Scenario: 2 + 2
   Given the number 2
     And we add 2
    When calculating
    Then the result should be 4

Scenario: 4 x 3
   Given the number 3
     And we add 3
     And we add 3
     And we add 3
    When calculating
    Then the result should be 12

Scenario Outline: X + X
   Given the number <base>
     And we add <addition>
    When calculating
    Then the result should be <expected result>
Examples:
    | base | addition | expected result |
    | 1    | 1        | 2               |
    | 2    | 2        | 4               |
    | 100  | 100      | 200             |