Feature: CalcatorFunctionalTesting
       In order check
       As a calc function
       I want to test the Basic operations and Advanced operations
@BasicOperations
Scenario Outline: Add two numbers
	Given Calculator is opened 
	When I have entered <a> into calc
	And I press <Operation>
	And I have also entered <b> into calc
	And I press Equals
	Then the result should be <Result> on the screen

Examples:
| a | Operation | b | Result |
| 1 | Add       | 1 | 2      |
| 2 | Add       | 2 | 4      |


@BasicOperations 
Scenario Outline: Subtract two numbers
	Given Calculator is opened 
	When I have entered <a> into calc
	And I press <Operation>
	And I have also entered <b> into calc
	And I press Equals
	Then the result should be <Result> on the screen

Examples:
| a | Operation | b | Result |
| 1 | Subtract | 0 | 1      |
| 6 | Subtract | 2 | 4      |


@BasicOperations
Scenario Outline: Multiply two numbers
	Given Calculator is opened 
	When I have entered <a> into calc
	And I press <Operation>
	And I have also entered <b> into calc
	And I press Equals
	Then the result should be <Result> on the screen

Examples:
| a | Operation | b | Result |
| 1 | Multiply | 0 | 0      |
| 6 | Multiply | 2 | 12      |

@AdvancedOperation
Scenario Outline: Factorial calculation
Given Calculator is opened 
When I have opened calclator in <mode> mode
And I press <a>
And I press <Operation>
Then the result should be <Result> on the screen

Examples:
| mode       | Operation | a | Result |
| Scientific | Factorial     | 5 | 120    |

@AdvancedOperation
Scenario Outline: Mortagae monthly payment calculation
Given Calculator is opened 
When I have opened calclator in <mode> mode
And I select Output Field as <paymentType>
And I enter Purchase price as  <purchagePrice>
And I enter Down payment as <downpayment>
And I enter Term (years) as  <term>
And I enter Interest rate (%) as  <roi>
And I press Calculate
Then the calculated results should be <result>

Examples:
| mode     | paymentType     | purchagePrice | downpayment | term | roi | result  |
| Mortgage | Monthly Payment | 13000         | 1000        | 1    | 1   | 1005.42 |

