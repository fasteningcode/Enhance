Feature: APITests
	TradeMe Sandbox environment API

@mytag
Scenario: Retrieve a list of charities and confirm that St John is included in the list
	Given I retrieve the charities list
	Then I verified the St John is included in the list