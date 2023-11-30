Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProject2/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Sub two numbers
	Given the first number is 4
	And the second number is  2
	When the two numbers are Sub
	Then the result should be  2

	@tag3
Scenario: Mul two numbers
	Given the first number is 4
	And the second number is  2
	When the two numbers are Mul
	Then the result should be  8

	@tag4
Scenario: Div two numbers
	Given the first number is  4
	And the second number is  2
	When the two numbers are Div
	Then the result should be  2

	@tag5
Scenario: Sqt two numbers
	Given the first number is  4
	#And the second number is  2
	When the two numbers are Sqt
	Then the result should be  16